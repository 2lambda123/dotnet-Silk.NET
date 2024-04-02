﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using Humanizer;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Silk.NET.SilkTouch.Naming;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// A mod that reads Khronos specifications to influence codegen.
/// </summary>
/// <param name="logger">The logger.</param>
/// <param name="cfg">The configuration.</param>
[ModConfiguration<Configuration>]
public partial class MixKhronosData(
    ILogger<MixKhronosData> logger,
    IOptionsSnapshot<MixKhronosData.Configuration> cfg
) : IMod, INameTrimmer
{
    internal Dictionary<string, JobData> Jobs = new();
    private static readonly ICulturedStringTransformer _transformer = new NameUtils.NameTransformer(
        4
    );
    private static readonly char[] _listSeparators = { ',', '|', '+' };

    private static readonly Dictionary<string, string> _defaultEnumNativeTypeNameMaps =
        new()
        {
            { "GLenum", "GLEnum" },
            { "EGLenum", "EGLEnum" },
            { "GLbitfield", "GLEnum" }
        };

    internal class JobData
    {
        /// <summary>
        /// The job configuration.
        /// </summary>
        public required Configuration Configuration { get; init; }

        /// <summary>
        /// A mapping of enum native names to group names.
        /// </summary>
        /// <remarks>
        /// This is OpenGL and OpenCL specific.
        /// </remarks>
        // TODO map OpenCL into these concepts
        public Dictionary<string, HashSet<string>> EnumsToGroups { get; } = [];

        /// <summary>
        /// A mapping of group names to constant declarators.
        /// </summary>
        /// <remarks>
        /// This is OpenGL and OpenCL specific.
        /// </remarks>
        // TODO map OpenCL into these concepts
        public Dictionary<string, EnumGroup> Groups { get; } = [];

        /// <summary>
        /// A mapping of feature/extension names to whether they're a feature or not and their API set dependencies for
        /// each profile/variant.
        /// </summary>
        /// <remarks>
        /// Note that feature names refer specifically to <c>GL_VERSION_1_0</c> and <c>VK_VERSION_1_0</c> and not the
        /// profile names such as <c>gl</c> or <c>vulkan</c>. Extension names are in the obvious format i.e.
        /// <c>GL_EXT_direct_state_access</c>.
        /// </remarks>
        public Dictionary<
            string,
            (bool IsExtension, Dictionary<string, HashSet<string>> Dependencies)
        > ApiSets { get; init; } = [];

        /// <summary>
        /// A mapping of native names to their supported API profile attributes.
        /// </summary>
        public Dictionary<string, List<AttributeListSyntax>>? SupportedApiProfiles { get; init; }

        /// <summary>
        /// The vendors contributing to the specification. This is in extension form e.g. Microsoft is MSFT.
        /// </summary>
        public HashSet<string>? Vendors { get; init; }

        /// <summary>
        /// A map of containing symbol names (i.e. function or struct) and applicable symbol names (i.e. field name,
        /// parameter name, or <c>:return</c>)
        /// </summary>
        public Dictionary<
            (string ContainingSymbol, string ApplicableSymbol),
            string
        > GroupUsages { get; init; } = [];
    }

    /// <summary>
    /// Khronos mod configuration.
    /// </summary>
    public record Configuration
    {
        /// <summary>
        /// The path to the XML specification file.
        /// </summary>
        /// <remarks>
        /// Can be null, in which case this is equivalent to just using OpenGL style trimmings on non-OpenGL bindings
        /// which we do want to do in some cases (like OpenAL)
        /// </remarks>
        public string? SpecPath { get; init; }

        /// <summary>
        /// Whether OpenGL-style data type suffixes should be trimmed.
        /// </summary>
        public bool UseDataTypeTrimmings { get; init; }

        /// <summary>
        /// Whether the extension vendor suffixes should be trimmed.
        /// </summary>
        public ExtensionVendorTrimmingMode UseExtensionVendorTrimmings { get; init; }

        /// <summary>
        /// A map of native type names to group names.
        /// </summary>
        public Dictionary<string, string> EnumNativeTypeNames { get; init; } =
            _defaultEnumNativeTypeNameMaps;
    }

    /// <summary>
    /// Modes for trimming extension vendor names.
    /// </summary>
    [JsonConverter(typeof(ExtensionVendorTrimmingModeJsonConverter))]
    public enum ExtensionVendorTrimmingMode
    {
        /// <summary>
        /// Do not trim extension vendors from names. Note that matching vendors may still be used to determine the
        /// offset of data type suffixes.
        /// </summary>
        None,

        /// <summary>
        /// Trim all extension vendor names.
        /// </summary>
        All,

        /// <summary>
        /// Only trim Khronos/first-party extension vendor names i.e. KHR and ARB.
        /// </summary>
        KhronosOnly
    }

    private class ExtensionVendorTrimmingModeJsonConverter
        : JsonConverter<ExtensionVendorTrimmingMode>
    {
        public override ExtensionVendorTrimmingMode Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            if (reader.TokenType == JsonTokenType.True)
            {
                return ExtensionVendorTrimmingMode.All;
            }

            if (reader.GetString() is { } str)
            {
                return Enum.Parse<ExtensionVendorTrimmingMode>(str);
            }

            return ExtensionVendorTrimmingMode.None;
        }

        public override void Write(
            Utf8JsonWriter writer,
            ExtensionVendorTrimmingMode value,
            JsonSerializerOptions options
        ) => writer.WriteStringValue(value.ToString());
    }

    /// <inheritdoc />
    // non-versioned trimmer (and needs to be a big number to come after the default trimmers)
    public Version Version { get; } = new(42, 42, 42, 42);

    /// <inheritdoc />
    public async Task BeforeJobAsync(string key, SilkTouchConfiguration config)
    {
        var currentConfig = cfg.Get(key);
        var specPath = currentConfig.SpecPath;
        if (specPath is null)
        {
            return;
        }

        logger.LogInformation("Reading Khronos XML from \"{}\"...", specPath);
        await using var fs = File.OpenRead(specPath);
        var xml = await XDocument.LoadAsync(fs, LoadOptions.None, default);
        var (apiSets, supportedApiProfiles) = EvaluateProfiles(xml);
        HashSet<string> vendors =
        [
            .. xml.Element("registry")
                ?.Element("tags")
                ?.Elements("tag")
                .Attributes("name")
                .Select(x => x.Value) ?? Enumerable.Empty<string>(),
            .. xml.Element("registry")
                ?.Element("extensions")
                ?.Elements("extension")
                .Attributes("name")
                .Select(x => x.Value.Split('_')[1].ToUpper()) ?? Enumerable.Empty<string>()
        ];
        Jobs[key] = new JobData
        {
            // Get all vendor names
            Vendors = vendors,
            ApiSets = apiSets,
            SupportedApiProfiles = supportedApiProfiles,
            Configuration = currentConfig
        };
        ReadGroups(xml, Jobs[key], vendors);
    }

    internal record EnumGroup(
        string Name,
        TypeSyntax? Type,
        List<VariableDeclaratorSyntax> Enums,
        bool KnownBitmask,
        string? ExclusiveVendor,
        string? Namespace
    );

    private record ProfileEvaluation(
        Version? StartVersion,
        Version? EndVersion,
        HashSet<string> ApiSets,
        HashSet<string>? ImpliedSets = null,
        bool RequireAll = false
    )
    {
        public AttributeSyntax ToAttribute(string profile)
        {
            List<AttributeArgumentSyntax> args =
            [
                AttributeArgument(
                    LiteralExpression(SyntaxKind.StringLiteralExpression, Literal(profile))
                ),
                AttributeArgument(
                    CollectionExpression(
                        SeparatedList<CollectionElementSyntax>(
                            ApiSets
                                .Order()
                                .Select(x =>
                                    ExpressionElement(
                                        LiteralExpression(
                                            SyntaxKind.StringLiteralExpression,
                                            Literal(x)
                                        )
                                    )
                                )
                        )
                    )
                )
            ];
            if (StartVersion is not null)
            {
                args.Add(
                    AttributeArgument(
                        NameEquals(IdentifierName("StartVersion")),
                        null,
                        LiteralExpression(
                            SyntaxKind.StringLiteralExpression,
                            Literal(StartVersion.ToString())
                        )
                    )
                );
            }
            if (EndVersion is not null)
            {
                args.Add(
                    AttributeArgument(
                        NameEquals(IdentifierName("EndVersion")),
                        null,
                        LiteralExpression(
                            SyntaxKind.StringLiteralExpression,
                            Literal(EndVersion.ToString())
                        )
                    )
                );
            }
            if (ImpliedSets is { Count: > 0 })
            {
                args.Add(
                    AttributeArgument(
                        NameEquals(IdentifierName("ImpliedSets")),
                        null,
                        CollectionExpression(
                            SeparatedList<CollectionElementSyntax>(
                                ImpliedSets
                                    .Order()
                                    .Select(x =>
                                        ExpressionElement(
                                            LiteralExpression(
                                                SyntaxKind.StringLiteralExpression,
                                                Literal(x)
                                            )
                                        )
                                    )
                            )
                        )
                    )
                );
            }
            if (RequireAll)
            {
                args.Add(
                    AttributeArgument(
                        NameEquals(IdentifierName("RequireAll")),
                        null,
                        LiteralExpression(SyntaxKind.TrueLiteralExpression)
                    )
                );
            }
            return Attribute(
                IdentifierName("SupportedApiProfile"),
                AttributeArgumentList(SeparatedList(args))
            );
        }
    }

    private (
        Dictionary<
            string,
            (bool IsExtension, Dictionary<string, HashSet<string>> Dependencies)
        > ApiSets,
        Dictionary<string, List<AttributeListSyntax>> SupportedApiProfiles
    ) EvaluateProfiles(XDocument xml)
    {
        // A map of native names to profile names to versions
        var profile = new Dictionary<string, Dictionary<string, List<ProfileEvaluation>>>();

        // A map of API set names (feature/extension names) to whether they're an extension and the other sets they are
        // dependent upon.
        var apiSets =
            new Dictionary<
                string,
                (bool IsExtension, Dictionary<string, HashSet<string>> Dependencies)
            >();

        EvaluateFeatures(xml, profile, apiSets);
        EvaluateExtensions(xml, profile, apiSets);

        // Create attributes for the evaluations.
        return (
            apiSets,
            profile.ToDictionary(
                x => x.Key,
                x =>
                    x.Value.SelectMany(y =>
                        y.Value.Select(z =>
                            AttributeList(SingletonSeparatedList(z.ToAttribute(y.Key)))
                        )
                    )
                        .ToList()
            )
        );
    }

    private class VersionComparer : IComparer<string?>
    {
        public static VersionComparer Instance { get; } = new();

        public int Compare(string? x, string? y) =>
            Version.TryParse(x, out var left) && Version.TryParse(y, out var right)
                ? Comparer<Version>.Default.Compare(left, right)
                : Comparer<string>.Default.Compare(x, y);
    }

    private void EvaluateFeatures(
        XDocument xml,
        Dictionary<string, Dictionary<string, List<ProfileEvaluation>>> profile,
        Dictionary<
            string,
            (bool IsExtension, Dictionary<string, HashSet<string>> Dependencies)
        > apiSets
    )
    {
        // A map of -EITHER- API set names -OR- profile names to native names to include from other profiles.
        // - If the API set name is used, this allows the "depends" attribute (read on) to resolve dependencies of a
        // feature.
        // - If the profile name is used, this allows the "pending inheritance" logic described below to work (and also
        // allows resolution of implicit version dependencies where the "depends" attribute is not used e.g. v1.1
        // depends on v1.0)
        //
        // Note that the "pending inheritance" concept is an extrapolation of the current Vulkan XML schema, the XML
        // schema hasn't formally defined how one profile includes another profile as strongly as OpenGL has.
        // Issue: https://github.com/KhronosGroup/Vulkan-Docs/issues/2326
        //
        // Essentially, the problem is Vulkan 1.0 through 1.2 now have api="vulkan,vulkansc", with a later
        // <feature api="vulkansc"> that <remove>s features from the vulkan profiles. Today we can assume that all
        // <feature>s tagged with api="vulkan,vulkansc" are inherited into the following <feature api="vulkansc">,
        // however this doesn't work should there be a SC profile of Vulkan 1.3. Note that we don't actually care about
        // this, as it's impossible for C# to be used in a safety critical context anyway, but this is nonetheless
        // something we have to account for in a generic Khronos XML parser.
        //
        // Currently this sticks with the current assumptions, though work is underway with Khronos to better define how
        // this should work.
        //
        // Jon Leech's preferred approach to resolving this (as of writing 17/03/2024) is to add a "depends" attribute
        // as they believe that the "number" attribute is an unintentional implementation detail leaking out that spec
        // editors typically just filled in to be the version number out of ease (it was actually just a sorting number
        // to define the order in which the features are applied), which will allow us to resolve it to actual
        // inheritance (as per the set in this dictionary) immediately instead of needing the pending step. We
        // handle both for posterity.
        //
        // Aside from this, we can resolve actual inheritance quite easily given that we can assume that 1.1 includes
        // 1.0 etc, removals notwithstanding (which we'll of course handle)
        var inheritance = new Dictionary<string, HashSet<string>>();

        // Another oddity with "pending inheritance" is removals - we need to keep track of what is removed where an API
        // is a secondary API so that we can remember to populate the EndVersion tag.
        var pendingRemovals = new Dictionary<string, HashSet<string>>();

        // Get all profile elements.
        // TODO topological sort based on "depends"?
        var profileElements =
            xml.Element("registry")
                ?.Elements("feature")
                .OrderBy(x =>
                    x.Attribute("api")
                        ?.Value.Split(
                            _listSeparators,
                            StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries
                        )[0]
                )
                .ThenBy(x => x.Attribute("number")?.Value, VersionComparer.Instance)
                .ToArray() ?? [];

        // Record the variations declared within those elements (OpenGL only atm)
        var profileVariations = new Dictionary<string, HashSet<string>>();

        // Whether we use explicit dependencies (Vulkan only atm)
        var explicitDependencies = profileElements.Attributes("depends").Any();

        // Get all variations of the profiles.
        foreach (var profileElement in profileElements)
        {
            // Get the API name.
            if (profileElement.Attribute("api") is not { Value: { Length: > 0 } name })
            {
                continue;
            }

            // glcore is a variation of gl
            foreach (
                var variant in name.Split(
                    _listSeparators,
                    StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries
                )
            )
            {
                profileVariations[variant] =
                [
                    variant,
                    .. profileElement
                        .Elements()
                        .Attributes("profile")
                        .SelectMany(x =>
                            x.Value.Split(
                                _listSeparators,
                                StringSplitOptions.RemoveEmptyEntries
                                    | StringSplitOptions.TrimEntries
                            )
                        ) // <-- future proofing
                        .Where(x => x != "compatibility") // <-- assuming default "gl" is "glcompatibility"
                        .Select(x => $"{variant}{x}"),
                    .. profileVariations.TryGetValue(variant, out var v) ? v : []
                ];
            }
        }

        // Now we've done that, we reiterate such that we populate the profile dictionary for all variations, filtering
        // APIs as necessary.
        foreach (var profileElement in profileElements)
        {
            // Get the API name.
            if (
                profileElement.Attribute("api")?.Value is not { Length: > 0 } name
                || profileElement.Attribute("name")?.Value is not { Length: > 0 } apiSet
            )
            {
                continue;
            }

            // See the "pending inheritance" concept in the Vulkan XML schema described above.
            var allApis = name.Split(_listSeparators);

            // Get the version number.
            var number = profileElement.Attribute("number")?.Value is { } ver
                ? Version.Parse(ver)
                : null;

            // Get the depends attribute. Note that if this is present, this should have already been identified and
            // explicitDependencies set to true.
            var depends =
                profileElement
                    .Attribute("depends")
                    ?.Value.Split(
                        _listSeparators,
                        StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries
                    ) ?? [];
            Debug.Assert((depends.Length > 0) == explicitDependencies);

            // Evaluate all of the elements.
            for (var i = 0; i < allApis.Length; i++)
            {
                foreach (var variant in profileVariations[allApis[i]])
                {
                    EvaluateFeature(
                        variant,
                        apiSet,
                        allApis[i],
                        depends,
                        number,
                        i > 0,
                        profileElement.Elements(),
                        explicitDependencies,
                        inheritance,
                        profile,
                        pendingRemovals,
                        apiSets
                    );
                }
            }
        }

        // Remove temporary entries in the apiSets dictionary used for secondary API resolution.
        // This should never do anything!
        if (explicitDependencies)
        {
            return;
        }

        // inheritance.Keys are profile/variant names unless we're using explicit dependencies, in which case they're
        // feature names.
        foreach (var profileName in inheritance.Keys)
        {
            if (apiSets.TryGetValue(profileName, out var unresolved))
            {
                logger?.LogWarning(
                    "The following features for secondary API \"{}\" were never resolved to a feature wherein "
                        + "\"{}\" is a primary API: {}",
                    profileName,
                    profileName,
                    string.Join(
                        ", ",
                        unresolved.Dependencies.TryGetValue(profileName, out var v) ? v : []
                    )
                );
                apiSets.Remove(profileName);
            }
        }
    }

    private void EvaluateFeature(
        string variant,
        string apiSet,
        string name,
        string[] depends,
        Version? number,
        bool isSecondary,
        IEnumerable<XElement> actions,
        bool explicitDependencies,
        Dictionary<string, HashSet<string>> inheritance,
        Dictionary<string, Dictionary<string, List<ProfileEvaluation>>> profile,
        Dictionary<string, HashSet<string>> pendingRemovals,
        Dictionary<
            string,
            (bool IsExtension, Dictionary<string, HashSet<string>> Dependencies)
        > apiSets
    )
    {
        // If explicit dependencies are used, the whole concept of implicit dependencies becomes meaningless and
        // potentially damaging to our understanding of the schema if we try to use both in tandem.
        if (isSecondary && explicitDependencies)
        {
            return;
        }

        // Refuse to evaluate disabled variants.
        if (variant == "disabled")
        {
            return;
        }

        // Create a HashSet to store all the symbols in this feature.
        // If we're not using explicit dependencies, then we track the profile-wide symbol list. We assume that the
        // "number" order is being respected.
        var symbols = explicitDependencies
            ? inheritance[apiSet] = []
            : inheritance.TryGetValue(variant, out var syms)
                ? syms
                : inheritance[variant] = [];

        // If we're using implicit dependencies in the form of secondary APIs, the symbol changes we explicitly need to
        // inherit are contained in the pendingChanges dictionary for this variant.
        var removedSymbols = pendingRemovals.TryGetValue(variant, out var cs)
            ? cs
            : pendingRemovals[variant] = [];
        if (!isSecondary)
        {
            // If we're the primary API we should reset our pending changes for the next iteration.
            pendingRemovals[variant] = [];
        }

        // If we're using explicit dependencies, we need to build up our symbol list (which is unique to this
        // feature), inheriting everything from the dependent features.
        foreach (var dependency in depends)
        {
            if (!inheritance.TryGetValue(dependency, out var toInherit))
            {
                // TODO a topological sort would solve this
                throw new InvalidOperationException(
                    $"Feature \"{apiSet}\" references another feature \"{dependency}\" that is "
                        + $"either missing or declared after \"{apiSet}\". Note that SilkTouch currently does not "
                        + $"topological sort based on the \"depends\" attribute in the latter case."
                );
            }

            foreach (var s in toInherit)
            {
                symbols.Add(s);
            }
        }

        // Process all of the additions/removals
        foreach (var action in actions)
        {
            // If the profile attribute is present, and this is the default variant or is otherwise not the
            // specific variant this action applies to, skip.
            if (
                action.Attribute("profile")?.Value is { } v
                && ((variant == name && v != "compatibility") || v != variant[name.Length..])
            )
            {
                continue;
            }

            foreach (var applicableTo in action.Elements())
            {
                if (applicableTo.Attribute("name")?.Value is not { } nativeName)
                {
                    continue;
                }

                switch (action.Name.LocalName)
                {
                    // Adding a new symbol to the profile. We are assuming that these are not duplicated unless
                    // they are removed beforehand, in which case they'll need a new evaluation anyway.
                    case "require":
                    {
                        symbols.Add(nativeName);
                        break;
                    }

                    // Removing the symbol from the profile. We are assuming that the API was added before it
                    // was removed.
                    case "remove":
                    {
                        removedSymbols.Add(nativeName);
                        symbols.Remove(nativeName);
                        break;
                    }
                }
            }
        }

        // Mark the existing symbols as being present in this API set as well.
        if (isSecondary) // we don't have the canonical API set yet
        {
            DeclareSet(apiSets, variant, apiSet, variant, false, depends);
            return;
        }

        DeclareSet(apiSets, apiSet, apiSet, variant, false, depends);

        // ReSharper disable once ForeachCanBePartlyConvertedToQueryUsingAnotherGetEnumerator
        foreach (
            var (present, symbol) in symbols
                .Select(x => (true, x))
                .Concat(removedSymbols.Select(x => (false, x)))
        )
        {
            if (!profile.TryGetValue(symbol, out var profileNamesToEvals))
            {
                profileNamesToEvals = profile[symbol] = [];
            }

            if (!profileNamesToEvals.TryGetValue(variant, out var evals))
            {
                evals = profileNamesToEvals[variant] = [];
            }

            if (present)
            {
                // Do we have an open evaluation for this symbol already?
                if (
                    evals.FindLastIndex(x => x.EndVersion is null && !x.RequireAll)
                    is >= 0
                        and var idx
                )
                {
                    // Append to the existing evaluation.
                    evals[idx].ApiSets.Add(apiSet);
                }
                else
                {
                    // Create a new evaluation if not.
                    evals.Add(new ProfileEvaluation(number, null, [apiSet]));
                }
            }
            else if (
                evals.FindLastIndex(x => x.EndVersion is null && !x.RequireAll) is >= 0 and var idx
            )
            {
                // The symbol has been removed, mark it with the end version.
                evals[idx] = evals[idx] with
                {
                    EndVersion = number
                };
            }
        }
    }

    private static void DeclareSet(
        Dictionary<
            string,
            (bool IsExtension, Dictionary<string, HashSet<string>> Dependencies)
        > apiSets,
        string declaration,
        string apiSet,
        string variant,
        bool isExtension,
        string[] depends
    )
    {
        var otherDeps =
            apiSet == declaration
            && !isExtension
            && apiSets.TryGetValue(variant, out var pendingDep)
            && pendingDep.Dependencies.TryGetValue(variant, out var pend)
                ? pend
                : [];
        if (!apiSets.TryGetValue(declaration, out var unresolved))
        {
            unresolved = apiSets[declaration] = (isExtension, []);
        }

        if (!unresolved.Dependencies.TryGetValue(variant, out var deps))
        {
            deps = unresolved.Dependencies[variant] = [];
        }

        foreach (var dep in depends.Concat(otherDeps))
        {
            deps.Add(dep);
        }

        if (apiSet != declaration)
        {
            deps.Add(apiSet);
        }
    }

    // Read the SupportedApiProfileAttribute.ImpliedSets docs, Vulkan is silly here.
    // Method for parsing strings like:
    // ((VK_KHR_get_physical_device_properties2,VK_VERSION_1_1)+VK_KHR_depth_stencil_resolve),VK_VERSION_1_2
    // and enumerating the cartesian product of the various dependency "options".
    // i.e.
    // (VK_VERSION_1_2,VK_EXT_my_cool_ext)+(VK_NV_my_vendor_ext,VK_KHR_my_other_ext)
    // returns (not necessarily in this order):
    // VK_VERSION_1_2+VK_NV_my_vendor_ext
    // VK_VERSION_1_2+VK_KHR_my_other_ext
    // VK_EXT_my_cool_ext+VK_NV_my_vendor_ext
    // VK_EXT_my_cool_ext+VK_KHR_my_other_ext
    // Note that the RequireAll functionality is so if we have a simple string like "VK_VERSION_1_2+VK_EXT_my_cool_ext"
    // instead of enumerating just one string, we can split it up at the + into:
    // VK_VERSION_1_2
    // VK_EXT_my_cool_ext
    // And, if this is for the ApiSets attribute value (rather than ImpliedSets, which codifies in its documentation the
    // rules around dependency paths), we can set the RequireAll attribute value to true.
    internal static (bool RequireAll, IEnumerable<string> Options) ParseDependencyOptions(
        ReadOnlySpan<char> dependencyString,
        string? topLevelAddReq = null,
        bool allowRequireAll = false
    )
    {
        var bracketDepth = 0;
        var firstBracketIdx = -1;
        var nextBaseIdx = 0;
        var adding = true;
        List<string>? options = null;
        static void Act(
            ref List<string>? options,
            ReadOnlySpan<char> dependencyString,
            int nextBaseIdx,
            int i,
            bool adding,
            ref string? topLevelAddReq
        )
        {
            if (nextBaseIdx >= i)
            {
                return;
            }

            // Is this is an additional requirement?
            if (adding)
            {
                topLevelAddReq = topLevelAddReq is null or { Length: 0 }
                    ? dependencyString[nextBaseIdx..i].ToString()
                    : $"{topLevelAddReq}+{dependencyString[nextBaseIdx..i]}";
            }
            else
            {
                (options ??= []).Add(dependencyString[nextBaseIdx..i].ToString());
            }
        }
        for (var i = 0; i < dependencyString.Length; i++)
        {
            switch (dependencyString[i])
            {
                // Do we have a parenthesised dependency string we need to recurse into?
                case '(' when bracketDepth++ == 0:
                {
                    firstBracketIdx = i;
                    break;
                }
                case ')' when --bracketDepth == 0:
                {
                    // Recurse into the parentheses to handle the inner options.
                    var innerOptions = ParseDependencyOptions(
                        dependencyString[(firstBracketIdx + 1)..i]
                    );

                    // Produce the cartesian product of our existing options.
                    if (options is null or { Count: 0 })
                    {
                        options = innerOptions.Options as List<string> ?? [.. innerOptions.Options];
                    }
                    else
                    {
                        var countBefore = options.Count;
                        foreach (var innerOption in innerOptions.Options)
                        {
                            for (var k = 0; k < countBefore; k++)
                            {
                                options.Add($"{options[k]}+{innerOption}");
                            }
                        }

                        options.RemoveRange(0, countBefore);
                    }

                    firstBracketIdx = -1;
                    nextBaseIdx = i + 1;
                    break;
                }
                case ',' when firstBracketIdx == -1:
                {
                    Act(
                        ref options,
                        dependencyString,
                        nextBaseIdx,
                        i,
                        adding = false,
                        ref topLevelAddReq
                    );
                    nextBaseIdx = i + 1;
                    break;
                }
                case '+' when firstBracketIdx == -1:
                {
                    Act(
                        ref options,
                        dependencyString,
                        nextBaseIdx,
                        i,
                        adding = true,
                        ref topLevelAddReq
                    );
                    nextBaseIdx = i + 1;
                    break;
                }
            }
        }

        Act(
            ref options,
            dependencyString,
            nextBaseIdx,
            dependencyString.Length,
            adding,
            ref topLevelAddReq
        );

        if (options is null or { Count: 0 })
        {
            if (topLevelAddReq is null)
            {
                return (allowRequireAll, []);
            }
            options = [topLevelAddReq];
        }
        else if (topLevelAddReq is not null)
        {
            for (var i = 0; i < options.Count; i++)
            {
                options[i] = $"{topLevelAddReq}+{options[i]}";
            }
        }

        if (allowRequireAll && options is { Count: 1 })
        {
            return (
                true,
                options[0]
                    .Split(
                        '+',
                        StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries
                    )
            );
        }

        return (false, options);
    }

    private void EvaluateExtensions(
        XDocument xml,
        Dictionary<string, Dictionary<string, List<ProfileEvaluation>>> profile,
        Dictionary<
            string,
            (bool IsExtension, Dictionary<string, HashSet<string>> Dependencies)
        > apiSets
    )
    {
        foreach (
            var ext in xml.Element("registry")?.Element("extensions")?.Elements("extension") ?? []
        )
        {
            var name =
                ext.Attribute("name")?.Value
                ?? throw new InvalidOperationException("Extension has no name.");

            // Note that we assume that if an extension is reported to be supported, then at least one of its dependency
            // options is supported. The reason why we can use allowRequireAll is because this is codified in the
            // SupportedApiProfileAttribute documentation - if any one of the reported implications has a +, then you
            // can make only AT LEAST ONE implication. Otherwise, you can imply that all implications are implied.
            var (_, impliedSets) = ext.Attribute("depends")?.Value is { } imp
                ? ParseDependencyOptions(imp, allowRequireAll: true)
                : (false, null);

            var supportedApis =
                ext.Attribute("supported")
                    ?.Value.Split(
                        _listSeparators,
                        StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries
                    ) ?? [];

            foreach (var supportedApi in supportedApis)
            {
                if (supportedApi == "disabled")
                {
                    continue;
                }

                DeclareSet(
                    apiSets,
                    name,
                    name,
                    supportedApi,
                    true,
                    (impliedSets = impliedSets?.ToArray()) as string[] ?? []
                );
            }

            // We're assuming that an extension can't remove stuff because that'd be stupid.
            foreach (var req in ext.Elements("require"))
            {
                var (requireAll, additionalDeps) = req.Attribute("depends")?.Value
                    is { Length: > 0 } add
                    ? ParseDependencyOptions(add, name, true)
                    : (false, null);
                foreach (var api in supportedApis)
                {
                    if (api == "disabled")
                    {
                        continue;
                    }

                    foreach (var symbol in req.Elements().Attributes("name"))
                    {
                        if (!profile.TryGetValue(symbol.Value, out var profileNamesToEvals))
                        {
                            profileNamesToEvals = profile[symbol.Value] = [];
                        }

                        if (!profileNamesToEvals.TryGetValue(api, out var evals))
                        {
                            evals = profileNamesToEvals[api] = [];
                        }

                        // If this is a basic extension with no other dependencies or implications, then let's just
                        // append the extension name to the existing API set list given that there's no side effects.
                        var handled = false;
                        if (impliedSets is null && additionalDeps is null)
                        {
                            foreach (var extantEval in evals)
                            {
                                if (
                                    extantEval.RequireAll
                                    || extantEval.ImpliedSets is { Count: > 0 }
                                )
                                {
                                    continue;
                                }

                                extantEval.ApiSets.Add(name);
                                handled = true;
                                break;
                            }
                        }

                        // Add a new evaluation.
                        if (!handled)
                        {
                            evals.Add(
                                new ProfileEvaluation(
                                    null,
                                    null,
                                    // ReSharper disable once PossibleMultipleEnumeration
                                    additionalDeps?.ToHashSet() ?? [name],
                                    // ReSharper disable once PossibleMultipleEnumeration
                                    impliedSets?.ToHashSet(),
                                    requireAll
                                )
                            );
                        }
                    }
                }
            }
        }
    }

    /// <inheritdoc />
    public void Trim(
        string? container,
        string? hint,
        string? jobKey,
        Dictionary<string, (string Primary, List<string>? Secondary)>? names,
        Dictionary<string, string>? prefixOverrides,
        HashSet<string>? nonDeterminant,
        ref string? identifiedPrefix
    )
    {
        if (names is null || jobKey is null)
        {
            return;
        }

        if (!Jobs.TryGetValue(jobKey, out var job))
        {
            throw new InvalidOperationException(
                "BeforeJobAsync has not run yet! MixKhronosData must come before PrettifyNames in the mod list."
            );
        }

        if (job.Vendors?.Count is 0 or null)
        {
            logger.LogWarning(
                "No vendor information present, assuming no XML was provided? Extension trimming will be skipped."
            );
        }

        // Trim the extension vendor names
        foreach (var (original, (current, previous)) in names)
        {
            var newCurrent = current;
            List<string>? newPrev = null;
            string? identifiedVendor = null;
            var trimVendor = false;
            foreach (var vendor in job.Vendors ?? Enumerable.Empty<string>())
            {
                if (!current.EndsWith(vendor))
                {
                    continue;
                }

                newCurrent = current[..^vendor.Length];
                var newOriginal = original[..^vendor.Length];
                // Sometimes we should keep the vendor prefix so we prefer the promoted functions.
                // ----------vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv--------------------------------------
                trimVendor =
                    !names.ContainsKey(newOriginal)
                    && (
                        job.Configuration.UseExtensionVendorTrimmings
                            == ExtensionVendorTrimmingMode.All
                        || (
                            job.Configuration.UseExtensionVendorTrimmings
                                == ExtensionVendorTrimmingMode.KhronosOnly
                            && vendor is "KHR" or "ARB"
                        )
                    );
                if (trimVendor)
                {
                    newPrev ??= previous ?? [];
                    newPrev.Add(current);
                    names[original] = (newCurrent, newPrev);
                }

                identifiedVendor = vendor;
                break;
            }

            // Below is a hack to ensure extension vendors are capitalised for enums (which are all caps and therefore
            // will not be treated as an acronym)
            if (
                current.All(x => !char.IsLetter(x) || char.IsUpper(x))
                && identifiedVendor is not null
            )
            {
                newPrev ??= previous ?? [];
                var pretty = newCurrent.Prettify(_transformer);

                // Hack to ensure extension vendors are preserved as acronyms
                if (char.IsUpper(pretty[^1]))
                {
                    pretty += ' ';
                }

                if (!trimVendor)
                {
                    // If we're not trimming the vendor, this hack will be the primary name.
                    newPrev.Add(current);
                    names[original] = (pretty + identifiedVendor, newPrev);
                }
                else
                {
                    // If we are trimming the vendor, if at any point we have to fall back on the untrimmed version
                    // we'll want that version to be this hack.
                    newPrev.Add(pretty + identifiedVendor);
                    names[original] = (pretty, newPrev);
                }
            }

            // Another hack to make sure that extension vendors are preserved as acronyms e.g. glTexImage4DSGIS was
            // becoming glTexImage4Dsgis instead of glTexImage4DSGIS
            if (
                current.Any(char.IsLower)
                && char.IsUpper(newCurrent[^1])
                && identifiedVendor is not null
            )
            {
                newPrev ??= previous ?? [];
                if (!trimVendor)
                {
                    // If we're not trimming the vendor, this hack will be the primary name.
                    newPrev.Add(current);
                    names[original] = ($"{newCurrent} {identifiedVendor}", newPrev);
                }
                else
                {
                    // If we are trimming the vendor, if at any point we have to fall back on the untrimmed version
                    // we'll want that version to be this hack. Note that to do this we actually have to nuke the
                    // original name because PrettifyNames orders by match length.
                    newPrev.Remove(current);
                    newPrev.Add($"{newCurrent} {identifiedVendor}");
                    names[original] = (newCurrent, newPrev);
                }
            }

            if (
                !job.Configuration.UseDataTypeTrimmings // don't trim data types
                || newCurrent.Count(x => x == '_') > 1 // is probably an enum
                || EndingsToTrim().Match(newCurrent) is not { Success: true } match // we don't have a data type suffix
                || EndingsNotToTrim().IsMatch(newCurrent) // we need to keep it
            )
            {
                continue;
            }

            newPrev ??= previous ?? [];
            var newPrim = newCurrent.Remove(match.Index);
            if (identifiedVendor is not null && trimVendor)
            {
                // If the only difference between this function and other functions that could conflict is the vendor,
                // it would be extremely confusing if the difference between e.g. a NV function and a non-NV function
                // was one had data type suffixes and the other didn't. Therefore, let's add the new name but with the
                // vendor added as the first secondary (e.g. for glVertex2bOES we first try Vertex2OES). If that doesn't
                // work, we still have the original one (modulo GL prefix) that we added to the secondary list when
                // originally trimming the vendor.
                newPrev.Add(newPrim + identifiedVendor);
            }
            else
            {
                // If trimVendor is false, add the vendor back. We're not trimming vendors so the only other secondary
                // we have is the original current name i.e. primary = glVertex2OES, secondary = glVertex2bOES, which
                // WOULDN'T be in the secondary list already per the if trimVendor above. If we're hitting this else
                // because we haven't identified a vendor, then we're just appending null to this string which does
                // nothing and is effectively equivalent to us having primary = glVertex2, secondary = glVertex2b
                newPrim += identifiedVendor;
                newPrev.Add(current);
            }

            names[original] = (newPrim, newPrev);
        }
    }

    /// <summary>
    /// This regex matches against known OpenGL function endings, picking them out from function names.
    /// It is comprised of two parts - the main matching set (here, the main capturing group), and a negative
    /// lookbehind workaround for difficult-to-match names. The primary set matches the actual function ending,
    /// while the lookbehind asserts that the ending match will not overreach into the end of a word.
    /// </summary>
    // NOTE: LET THIS BE A LESSON! Do NOT add x (fixed) here, these will frequently conflict with integer overloads.
    [GeneratedRegex("(?<!xe)([fdh]v?|u?[isb](64)?v?|v|i_v|fi|hi)$")]
    private static partial Regex EndingsToTrim();

    /// <summary>
    /// This regex acts like a whitelist for endings that could have been matched in some way by the main
    /// expression, but should be exempt from trimming altogether.
    /// </summary>
    [GeneratedRegex(
        "(sh|ib|[tdrey]s|(?<![A-Z])[eE]n[vd]|bled|Attrib|Access|Boolean|Coord|Depth|Feedbacks|Finish|Flag|"
            + "Groups|IDs|Indexed|Instanced|Pixels|Queries|Status|Tess|Through|Uniforms|Varyings|Weight|Width|Bias|Id|"
            + "Fixed|Pass|Address|Configs|Thread|Subpass|Deferred|Extended|Affix|Annex|Box|Aux|Ex|Index|Vertex|Path|"
            + "Arch|ArithAfresh|Both|High|Math|Mesh|Sinh|Bench|Brush|Bunch|Crash|Flush|Depth|Latch|Morph|Pinch|"
            + "Pitch|Stretch|Smooth|Matrix|Radix)$"
    )]
    private static partial Regex EndingsNotToTrim();

    private class Rewriter(JobData job) : CSharpSyntaxRewriter(true)
    {
        public override SyntaxNode? VisitClassDeclaration(ClassDeclarationSyntax node)
        {
            var ret = base.VisitClassDeclaration(node);
            return ret is ClassDeclarationSyntax { Members.Count: 0 } ? null : ret;
        }

        public override SyntaxNode? VisitFieldDeclaration(FieldDeclarationSyntax node)
        {
            if (
                node.Declaration.Variables.Count != 1
                || !node.Modifiers.Any(SyntaxKind.ConstKeyword)
            )
            {
                return base.VisitFieldDeclaration(node);
            }

            var nativeName = node
                .AttributeLists.SelectMany(x => x.Attributes)
                .FirstOrDefault(x => x.IsAttribute("Silk.NET.Core.NativeTypeName"))
                ?.ArgumentList?.Arguments.Select(x =>
                    x.Expression.IsKind(SyntaxKind.StringLiteralExpression)
                        ? (x.Expression as LiteralExpressionSyntax)?.Token
                        : null
                )
                .FirstOrDefault(x => x.HasValue)
                ?.ToString();
            if (nativeName is null || !nativeName.StartsWith("#define "))
            {
                return base.VisitFieldDeclaration(node);
            }

            var nnSpan = nativeName.AsSpan()["#define ".Length..].Trim();
            nativeName = (
                nnSpan.IndexOf(' ') is >= 0 and var idx ? nnSpan[..idx] : nnSpan
            ).ToString();

            if (job.EnumsToGroups.TryGetValue(nativeName, out var groups))
            {
                foreach (var group in groups)
                {
                    job.Groups[group].Enums.Add(node.Declaration.Variables[0]);
                }

                return null;
            }

            return base.VisitFieldDeclaration(node);
        }
    }

    [SuppressMessage("ReSharper", "MoveLocalFunctionAfterJumpStatement")]
    internal void ReadGroups(XDocument doc, JobData data, HashSet<string> vendors)
    {
        // Designed to be compatible with OpenGL, EGL, WGL, GLX, and OpenCL.
        // This will work for Vulkan as well, but for Vulkan the enums are actually "typedef enum"s in the headers and
        // therefore the result of this function will go mostly ignored.
        var anyNamespaced =
            doc.Element("registry")?.Elements("enums").Attributes("namespace").Any() ?? false;
        var likelyOpenCL = false; // OpenCL specific
        var topLevelIntentionalExclusions = new HashSet<string>(); // OpenCL specific
        foreach (var block in doc.Element("registry")?.Elements("enums") ?? [])
        {
            // Is it a bitmask?
            var isBitmask = block.Attribute("type")?.Value == "bitmask";

            // OpenGL/EGL/WGL/GLX namespace
            var enumNamespace = block.Attribute("namespace")?.Value;
            var groupName =
                enumNamespace is not null && !enumNamespace.All(char.IsUpper)
                    ? enumNamespace
                    : null;

            // Create an ungrouped group as well i.e. GLEnum, WGLEnum, etc
            if (enumNamespace is not null)
            {
                groupName ??= $"{enumNamespace}Enum";
            }

            // OpenCL enum name
            if (!anyNamespaced)
            {
                groupName ??= block.Attribute("name")?.Value;
            }

            // Special cases for OpenCL contributed by @Alexx999 for 2.X and ported to 3.0 from:
            // https://github.com/dotnet/Silk.NET/blob/d8919600/src/Core/Silk.NET.BuildTools/Converters/Readers/OpenCLReader.cs#L842-L845
            // Note that this has actually been split into two cases: top-level intentional exclusions and just a silent
            // skip over the block. We continue on in the top-level case to permanently prevent any group operations
            // from occurring on the top-level intentional exclusions because they're special numbers/constants.
            var topLevelIntentionalExclusion =
                groupName is not null && IsIntentionalExclusion(groupName);
            static bool IsIntentionalExclusion(string groupName) =>
                groupName.StartsWith("Constants") // these are constants
                || groupName is "MiscNumbers" or "SpecialNumbers";
            static bool IsUngroupable(string groupName) =>
                IsIntentionalExclusion(groupName)
                || groupName.StartsWith("enums") // these are unnamed
                || groupName is "cl_device_info"; // bug in cl.xml - see see https://github.com/KhronosGroup/OpenCL-Docs/pull/779

            // ...continued from:
            // https://github.com/dotnet/Silk.NET/blob/d8919600/src/Core/Silk.NET.BuildTools/Converters/Readers/OpenCLReader.cs#L855-L870
            if (!anyNamespaced && groupName is not null && !topLevelIntentionalExclusion)
            {
                FixupGroupNameForOpenCL(ref groupName, ref likelyOpenCL, ref isBitmask);
            }

            // Mark the enums
            foreach (var @enum in block.Elements("enum"))
            {
                var enumName =
                    @enum.Attribute("name")?.Value
                    ?? throw new InvalidDataException("Expected \"name\" attribute on <enum>.");
                if (topLevelIntentionalExclusion)
                {
                    topLevelIntentionalExclusions.Add(enumName);
                    continue;
                }

                // Get the group hash set for this enum.
                if (!data.EnumsToGroups.TryGetValue(enumName, out var enumToGroups))
                {
                    data.EnumsToGroups[enumName] = enumToGroups = [];
                }

                // OpenGL-style groups
                var glGroups = @enum
                    .Attribute("group")
                    ?.Value.Split(
                        _listSeparators,
                        StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries
                    );

                // Get the vendor (if the enum name ends with a vendor that is).
                var thisVendor = VendorFromString(enumName, vendors);

                foreach (
                    var group in (groupName is null ? Enumerable.Empty<string>() : [groupName])
                        .Concat(glGroups ?? [])
                        .Concat(block.Attribute("group")?.Value is { Length: > 0 } g ? [g] : [])
                        .Distinct()
                )
                {
                    if (IsUngroupable(group))
                    {
                        continue;
                    }

                    // Update the group info.
                    data.Groups[group] = data.Groups.TryGetValue(group, out var groupInfo)
                        ? groupInfo with
                        {
                            KnownBitmask = isBitmask && groupInfo.KnownBitmask,
                            ExclusiveVendor =
                                thisVendor is not null && groupInfo.ExclusiveVendor == thisVendor
                                    ? thisVendor
                                    : null,
                            Namespace =
                                enumNamespace is not null && groupInfo.Namespace == enumNamespace
                                    ? enumNamespace
                                    : null
                        }
                        : new EnumGroup(group, null, [], isBitmask, thisVendor, enumNamespace);

                    // Mark this enum.
                    enumToGroups.Add(group);
                }
            }
        }

        // Read the group usages from the functions
        foreach (var func in doc.Elements("registry").Elements().Elements("command"))
        {
            var funcName =
                func.Element("proto")?.Element("name")?.Value
                ?? throw new InvalidDataException("command with no name");
            if (
                func.Element("proto")?.Element("ptype")?.Attribute("group")?.Value
                    is { Length: > 0 } retGrp
                && data.Groups.ContainsKey(retGrp)
            )
            {
                data.GroupUsages[(funcName, ":return")] = retGrp;
            }
            foreach (var param in func.Elements("param"))
            {
                var paramName =
                    param.Element("name")?.Value
                    ?? throw new InvalidDataException("param with no name");
                if (
                    param.Attribute("group")?.Value is { Length: > 0 } paramGrp
                    && data.Groups.ContainsKey(paramGrp)
                )
                {
                    data.GroupUsages[(funcName, paramName)] = paramGrp;
                }
            }
        }

        // The relative sanity of the other specs stops here.
        if (!likelyOpenCL)
        {
            return;
        }

        // Add empty enums that are defined in the C headers but have no members (yet).
        // This is also used as a type hinting stage.
        foreach (
            var @enum in doc.Elements("registry")
                .Elements("types")
                .Elements("type")
                .Where(e =>
                    e.Elements("type").SingleOrDefault()?.Value is "cl_bitfield" or "cl_properties"
                )
                .Elements("name")
        )
        {
            // We don't have to do horrible string manipulation here because this ends up in the actual C header, so
            // it's actually correct for once.
            if (!data.Groups.ContainsKey(@enum.Value))
            {
                data.Groups[@enum.Value] = new EnumGroup(
                    @enum.Value,
                    // cl_properties and cl_bitfield are both cl_ulong which is ulong
                    PredefinedType(Token(SyntaxKind.ULongKeyword)),
                    [],
                    @enum.Parent?.Element("type")?.Value == "cl_bitfield",
                    VendorFromString(@enum.Value, vendors),
                    null
                );
            }
        }

        void FixupGroupNameForOpenCL(
            ref string groupName,
            ref bool isLikelyOpenCL,
            ref bool isBitmask
        )
        {
            if (groupName.StartsWith("ErrorCodes") && groupName.Contains('.'))
            {
                groupName = "ErrorCodes";
                isLikelyOpenCL = true;
            }
            else if (groupName.EndsWith(".flags"))
            {
                // NOTE: I've actually gone ahead and disagreed with the original code here because why do we want to
                // strip flags out of the name? There are only three instances of this in the spec currently:
                // cl_arm_svm_alloc.flags, cl_arm_device_svm_capabilities.flags, and
                // cl_intel_advanced_motion_estimation.flags
                //groupName = groupName[..^".flags".Length];
                isBitmask = true;
                isLikelyOpenCL = true;
            }

            if (groupName.Contains('.'))
            {
                logger.LogDebug(
                    "OpenCL-style group name syntax: \"{}\" (replacing '.' with '_')",
                    groupName
                );
                groupName = groupName.Replace('.', '_');
                isLikelyOpenCL = true;
            }
        }

        // Okay so this bit is absolutely freaking bonkers. We're using the <require comment="..."> attribute for
        // meaningful data, which you should literally never do, but in lieu of OpenCL actually annotating their groups
        // properly this will have to do. If there's only human-readable information, we shall automate reading like
        // human!
        // Original code, further comments have line markers where they map into the original code:
        // https://github.com/dotnet/Silk.NET/blob/d8919600/src/Core/Silk.NET.BuildTools/Converters/Readers/OpenCLReader.cs#L878
        foreach (
            var enumRequirement in (doc.Element("registry")?.Elements("feature") ?? [])
                .Concat(doc.Element("registry")?.Elements("extensions").Elements("extension") ?? [])
                .Elements("require")
                .Elements("enum")
        )
        {
            var enumName =
                enumRequirement.Attribute("name")?.Value
                ?? throw new InvalidDataException(
                    "Expected \"name\" attribute on <enum> in <require> tag."
                );

            var thisVendor = VendorFromString(enumName, vendors);

            // If we've already intentionally excluded this enum, don't change that now. L880
            if (topLevelIntentionalExclusions.Contains(enumName))
            {
                continue;
            }

            // TODO we may want to add some NativeNameOverride logic akin to BuildTools' "rename" element in 2.X.
            // This was removed because all of the corner cases for OpenCL specifically no longer apply. L882/L884
            var typeStr = enumRequirement.Parent?.Attribute("comment")?.Value;
            IEnumerable<string>? allTypes = null;

            // Is this a human-readable comment or a verbatim type name? L886
            // NOTE: Adjusted to be !IsAsciiLetterOrDigit instead of just ' ' because of the weird _?? case that should
            // not exist.
            if (
                string.IsNullOrWhiteSpace(typeStr)
                || typeStr.Any(x => !char.IsAsciiLetterOrDigit(x) && x is not ('.' or '_'))
            )
            {
                if (!string.IsNullOrWhiteSpace(typeStr))
                {
                    // If the human comment indicates these are error code enums, put them in the ErrorCode group
                    // already established. L894
                    if (typeStr.Equals("Error codes", StringComparison.OrdinalIgnoreCase))
                    {
                        typeStr = "ErrorCodes";
                    }
                    else if (
                        typeStr.StartsWith("OpenCL ", StringComparison.OrdinalIgnoreCase)
                        && typeStr.Contains("deprecated", StringComparison.OrdinalIgnoreCase)
                    )
                    {
                        // Core spec deprecation notices. L897
                        var typeNameStart = typeStr.IndexOf(' ', startIndex: "OpenCL ".Length) + 1;
                        var typeNameEnd = typeStr.IndexOf(' ', typeNameStart + 1);
                        typeStr = typeStr[typeNameStart..typeNameEnd];
                    }
                    else if (
                        typeStr.StartsWith("cl_uint ", StringComparison.OrdinalIgnoreCase)
                        && !data.EnumsToGroups[enumName].Any(x => x.StartsWith("cl_")) // <-- last resort only
                    )
                    {
                        // QCOM extensions. L902
                        typeStr = typeStr["cl_uint ".Length..];
                    }
                    // @Perksey: New special case for "cl_mem_flags and cl_svm_mem_flags - bitfield".
                    // Essentially we check whether the comment is a grammatical list.
                    else if (
                        typeStr[..(typeStr.IndexOf('-') is >= 0 and var i ? i : ^0)].Trim()
                            is var andList
                        && andList.All(x =>
                            char.IsAsciiLetterOrDigit(x) || x is '.' or ' ' or ',' or '_'
                        )
                        && andList.Split(
                            ' ',
                            StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries
                        )
                            is var splitList
                        && splitList
                            .Select((x, j) => (x, j))
                            .All(x =>
                                x.x.StartsWith("cl_")
                                || (x.x == "and" && x.j == splitList.Length - 2)
                            )
                    )
                    {
                        allTypes = splitList
                            .Where(x => x is not "and" && x.StartsWith("cl_"))
                            .Select(x => x.Trim(','));
                    }
                    else
                    {
                        // Didn't match one of our special cases exactly, so let's not do anything. L903
                        typeStr = null;
                    }
                }
                else // we don't want to do anything if we have an entirely whitespace string...
                {
                    typeStr = null;
                }
            }

            foreach (var group in allTypes ?? (typeStr is null ? [] : [typeStr]))
            {
                // Just in case.
                var tempVar = false;
                var groupStr = group;
                FixupGroupNameForOpenCL(ref groupStr, ref likelyOpenCL, ref tempVar);

                // Update the group info if it doesn't exist.
                if (data.Groups.TryGetValue(groupStr, out var groupInfo))
                {
                    if (thisVendor is not null && groupInfo.ExclusiveVendor != thisVendor)
                    {
                        data.Groups[groupStr] = groupInfo with { ExclusiveVendor = null };
                    }
                }
                else
                {
                    data.Groups[groupStr] = new EnumGroup(
                        groupStr,
                        null,
                        [],
                        (typeStr is not null && typeStr.Contains("bitfield"))
                            || group.Contains("flags"),
                        thisVendor,
                        null
                    );
                }

                // Get the group hash set for this enum.
                if (!data.EnumsToGroups.TryGetValue(enumName, out var enumToGroups))
                {
                    data.EnumsToGroups[enumName] = enumToGroups = [];
                }

                // Mark this enum.
                enumToGroups.Add(groupStr);
            }
        }
    }

    private static string? VendorFromString(string str, HashSet<string> vendors) =>
        str.LastIndexOf('_') is > 0 and var idx
        && idx < str.Length
        && str[idx..].ToUpper() is var vend
        && vendors.Contains(vend)
            ? vend
            : null;
}
