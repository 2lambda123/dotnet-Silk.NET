// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRVReflect
{
    [NativeName("Name", "SpvDecoration_")]
    public enum Decoration : int
    {
        [NativeName("Name", "SpvDecorationRelaxedPrecision")]
        RelaxedPrecision = 0x0,
        [NativeName("Name", "SpvDecorationSpecId")]
        SpecId = 0x1,
        [NativeName("Name", "SpvDecorationBlock")]
        Block = 0x2,
        [NativeName("Name", "SpvDecorationBufferBlock")]
        BufferBlock = 0x3,
        [NativeName("Name", "SpvDecorationRowMajor")]
        RowMajor = 0x4,
        [NativeName("Name", "SpvDecorationColMajor")]
        ColMajor = 0x5,
        [NativeName("Name", "SpvDecorationArrayStride")]
        ArrayStride = 0x6,
        [NativeName("Name", "SpvDecorationMatrixStride")]
        MatrixStride = 0x7,
        [NativeName("Name", "SpvDecorationGLSLShared")]
        Glslshared = 0x8,
        [NativeName("Name", "SpvDecorationGLSLPacked")]
        Glslpacked = 0x9,
        [NativeName("Name", "SpvDecorationCPacked")]
        CPacked = 0xA,
        [NativeName("Name", "SpvDecorationBuiltIn")]
        BuiltIn = 0xB,
        [NativeName("Name", "SpvDecorationNoPerspective")]
        NoPerspective = 0xD,
        [NativeName("Name", "SpvDecorationFlat")]
        Flat = 0xE,
        [NativeName("Name", "SpvDecorationPatch")]
        Patch = 0xF,
        [NativeName("Name", "SpvDecorationCentroid")]
        Centroid = 0x10,
        [NativeName("Name", "SpvDecorationSample")]
        Sample = 0x11,
        [NativeName("Name", "SpvDecorationInvariant")]
        Invariant = 0x12,
        [NativeName("Name", "SpvDecorationRestrict")]
        Restrict = 0x13,
        [NativeName("Name", "SpvDecorationAliased")]
        Aliased = 0x14,
        [NativeName("Name", "SpvDecorationVolatile")]
        Volatile = 0x15,
        [NativeName("Name", "SpvDecorationConstant")]
        Constant = 0x16,
        [NativeName("Name", "SpvDecorationCoherent")]
        Coherent = 0x17,
        [NativeName("Name", "SpvDecorationNonWritable")]
        NonWritable = 0x18,
        [NativeName("Name", "SpvDecorationNonReadable")]
        NonReadable = 0x19,
        [NativeName("Name", "SpvDecorationUniform")]
        Uniform = 0x1A,
        [NativeName("Name", "SpvDecorationUniformId")]
        UniformId = 0x1B,
        [NativeName("Name", "SpvDecorationSaturatedConversion")]
        SaturatedConversion = 0x1C,
        [NativeName("Name", "SpvDecorationStream")]
        Stream = 0x1D,
        [NativeName("Name", "SpvDecorationLocation")]
        Location = 0x1E,
        [NativeName("Name", "SpvDecorationComponent")]
        Component = 0x1F,
        [NativeName("Name", "SpvDecorationIndex")]
        Index = 0x20,
        [NativeName("Name", "SpvDecorationBinding")]
        Binding = 0x21,
        [NativeName("Name", "SpvDecorationDescriptorSet")]
        DescriptorSet = 0x22,
        [NativeName("Name", "SpvDecorationOffset")]
        Offset = 0x23,
        [NativeName("Name", "SpvDecorationXfbBuffer")]
        XfbBuffer = 0x24,
        [NativeName("Name", "SpvDecorationXfbStride")]
        XfbStride = 0x25,
        [NativeName("Name", "SpvDecorationFuncParamAttr")]
        FuncParamAttr = 0x26,
        [NativeName("Name", "SpvDecorationFPRoundingMode")]
        FproundingMode = 0x27,
        [NativeName("Name", "SpvDecorationFPFastMathMode")]
        FpfastMathMode = 0x28,
        [NativeName("Name", "SpvDecorationLinkageAttributes")]
        LinkageAttributes = 0x29,
        [NativeName("Name", "SpvDecorationNoContraction")]
        NoContraction = 0x2A,
        [NativeName("Name", "SpvDecorationInputAttachmentIndex")]
        InputAttachmentIndex = 0x2B,
        [NativeName("Name", "SpvDecorationAlignment")]
        Alignment = 0x2C,
        [NativeName("Name", "SpvDecorationMaxByteOffset")]
        MaxByteOffset = 0x2D,
        [NativeName("Name", "SpvDecorationAlignmentId")]
        AlignmentId = 0x2E,
        [NativeName("Name", "SpvDecorationMaxByteOffsetId")]
        MaxByteOffsetId = 0x2F,
        [NativeName("Name", "SpvDecorationNoSignedWrap")]
        NoSignedWrap = 0x1175,
        [NativeName("Name", "SpvDecorationNoUnsignedWrap")]
        NoUnsignedWrap = 0x1176,
        [NativeName("Name", "SpvDecorationExplicitInterpAMD")]
        ExplicitInterpAmd = 0x1387,
        [NativeName("Name", "SpvDecorationOverrideCoverageNV")]
        OverrideCoverageNV = 0x1480,
        [NativeName("Name", "SpvDecorationPassthroughNV")]
        PassthroughNV = 0x1482,
        [NativeName("Name", "SpvDecorationViewportRelativeNV")]
        ViewportRelativeNV = 0x1484,
        [NativeName("Name", "SpvDecorationSecondaryViewportRelativeNV")]
        SecondaryViewportRelativeNV = 0x1488,
        [NativeName("Name", "SpvDecorationPerPrimitiveNV")]
        PerPrimitiveNV = 0x1497,
        [NativeName("Name", "SpvDecorationPerViewNV")]
        PerViewNV = 0x1498,
        [NativeName("Name", "SpvDecorationPerTaskNV")]
        PerTaskNV = 0x1499,
        [NativeName("Name", "SpvDecorationPerVertexKHR")]
        PerVertexKhr = 0x14A5,
        [NativeName("Name", "SpvDecorationPerVertexNV")]
        PerVertexNV = 0x14A5,
        [NativeName("Name", "SpvDecorationNonUniform")]
        NonUniform = 0x14B4,
        [NativeName("Name", "SpvDecorationNonUniformEXT")]
        NonUniformExt = 0x14B4,
        [NativeName("Name", "SpvDecorationRestrictPointer")]
        RestrictPointer = 0x14EB,
        [NativeName("Name", "SpvDecorationRestrictPointerEXT")]
        RestrictPointerExt = 0x14EB,
        [NativeName("Name", "SpvDecorationAliasedPointer")]
        AliasedPointer = 0x14EC,
        [NativeName("Name", "SpvDecorationAliasedPointerEXT")]
        AliasedPointerExt = 0x14EC,
        [NativeName("Name", "SpvDecorationBindlessSamplerNV")]
        BindlessSamplerNV = 0x1516,
        [NativeName("Name", "SpvDecorationBindlessImageNV")]
        BindlessImageNV = 0x1517,
        [NativeName("Name", "SpvDecorationBoundSamplerNV")]
        BoundSamplerNV = 0x1518,
        [NativeName("Name", "SpvDecorationBoundImageNV")]
        BoundImageNV = 0x1519,
        [NativeName("Name", "SpvDecorationSIMTCallINTEL")]
        SimtcallIntel = 0x15DF,
        [NativeName("Name", "SpvDecorationReferencedIndirectlyINTEL")]
        ReferencedIndirectlyIntel = 0x15E2,
        [NativeName("Name", "SpvDecorationClobberINTEL")]
        ClobberIntel = 0x15E7,
        [NativeName("Name", "SpvDecorationSideEffectsINTEL")]
        SideEffectsIntel = 0x15E8,
        [NativeName("Name", "SpvDecorationVectorComputeVariableINTEL")]
        VectorComputeVariableIntel = 0x15F8,
        [NativeName("Name", "SpvDecorationFuncParamIOKindINTEL")]
        FuncParamIokindIntel = 0x15F9,
        [NativeName("Name", "SpvDecorationVectorComputeFunctionINTEL")]
        VectorComputeFunctionIntel = 0x15FA,
        [NativeName("Name", "SpvDecorationStackCallINTEL")]
        StackCallIntel = 0x15FB,
        [NativeName("Name", "SpvDecorationGlobalVariableOffsetINTEL")]
        GlobalVariableOffsetIntel = 0x15FC,
        [NativeName("Name", "SpvDecorationCounterBuffer")]
        CounterBuffer = 0x1602,
        [NativeName("Name", "SpvDecorationHlslCounterBufferGOOGLE")]
        HlslCounterBufferGoogle = 0x1602,
        [NativeName("Name", "SpvDecorationHlslSemanticGOOGLE")]
        HlslSemanticGoogle = 0x1603,
        [NativeName("Name", "SpvDecorationUserSemantic")]
        UserSemantic = 0x1603,
        [NativeName("Name", "SpvDecorationUserTypeGOOGLE")]
        UserTypeGoogle = 0x1604,
        [NativeName("Name", "SpvDecorationFunctionRoundingModeINTEL")]
        FunctionRoundingModeIntel = 0x16BE,
        [NativeName("Name", "SpvDecorationFunctionDenormModeINTEL")]
        FunctionDenormModeIntel = 0x16BF,
        [NativeName("Name", "SpvDecorationRegisterINTEL")]
        RegisterIntel = 0x16C1,
        [NativeName("Name", "SpvDecorationMemoryINTEL")]
        MemoryIntel = 0x16C2,
        [NativeName("Name", "SpvDecorationNumbanksINTEL")]
        NumbanksIntel = 0x16C3,
        [NativeName("Name", "SpvDecorationBankwidthINTEL")]
        BankwidthIntel = 0x16C4,
        [NativeName("Name", "SpvDecorationMaxPrivateCopiesINTEL")]
        MaxPrivateCopiesIntel = 0x16C5,
        [NativeName("Name", "SpvDecorationSinglepumpINTEL")]
        SinglepumpIntel = 0x16C6,
        [NativeName("Name", "SpvDecorationDoublepumpINTEL")]
        DoublepumpIntel = 0x16C7,
        [NativeName("Name", "SpvDecorationMaxReplicatesINTEL")]
        MaxReplicatesIntel = 0x16C8,
        [NativeName("Name", "SpvDecorationSimpleDualPortINTEL")]
        SimpleDualPortIntel = 0x16C9,
        [NativeName("Name", "SpvDecorationMergeINTEL")]
        MergeIntel = 0x16CA,
        [NativeName("Name", "SpvDecorationBankBitsINTEL")]
        BankBitsIntel = 0x16CB,
        [NativeName("Name", "SpvDecorationForcePow2DepthINTEL")]
        ForcePow2DepthIntel = 0x16CC,
        [NativeName("Name", "SpvDecorationBurstCoalesceINTEL")]
        BurstCoalesceIntel = 0x170B,
        [NativeName("Name", "SpvDecorationCacheSizeINTEL")]
        CacheSizeIntel = 0x170C,
        [NativeName("Name", "SpvDecorationDontStaticallyCoalesceINTEL")]
        DontStaticallyCoalesceIntel = 0x170D,
        [NativeName("Name", "SpvDecorationPrefetchINTEL")]
        PrefetchIntel = 0x170E,
        [NativeName("Name", "SpvDecorationStallEnableINTEL")]
        StallEnableIntel = 0x1711,
        [NativeName("Name", "SpvDecorationFuseLoopsInFunctionINTEL")]
        FuseLoopsInFunctionIntel = 0x1713,
        [NativeName("Name", "SpvDecorationAliasScopeINTEL")]
        AliasScopeIntel = 0x171A,
        [NativeName("Name", "SpvDecorationNoAliasINTEL")]
        NoAliasIntel = 0x171B,
        [NativeName("Name", "SpvDecorationBufferLocationINTEL")]
        BufferLocationIntel = 0x1721,
        [NativeName("Name", "SpvDecorationIOPipeStorageINTEL")]
        IopipeStorageIntel = 0x1738,
        [NativeName("Name", "SpvDecorationFunctionFloatingPointModeINTEL")]
        FunctionFloatingPointModeIntel = 0x17C0,
        [NativeName("Name", "SpvDecorationSingleElementVectorINTEL")]
        SingleElementVectorIntel = 0x17C5,
        [NativeName("Name", "SpvDecorationVectorComputeCallableFunctionINTEL")]
        VectorComputeCallableFunctionIntel = 0x17C7,
        [NativeName("Name", "SpvDecorationMediaBlockIOINTEL")]
        MediaBlockIointel = 0x17FC,
        [NativeName("Name", "SpvDecorationMax")]
        Max = 0x7FFFFFFF,
    }
}
