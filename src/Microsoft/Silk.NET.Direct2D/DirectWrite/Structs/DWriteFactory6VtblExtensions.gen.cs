// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite;

public unsafe static class DWriteFactory6VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFactory6> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteFactory6> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteFactory6> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSystemFontCollection(this ComPtr<IDWriteFactory6> thisVtbl, IDWriteFontCollection** fontCollection, Silk.NET.Core.Bool32 checkForUpdates)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontCollection**, Silk.NET.Core.Bool32, int>)@this->LpVtbl[3])(@this, fontCollection, checkForUpdates);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCustomFontCollection(this ComPtr<IDWriteFactory6> thisVtbl, IDWriteFontCollectionLoader* collectionLoader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* collectionKey, uint collectionKeySize, IDWriteFontCollection** fontCollection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontCollectionLoader*, void*, uint, IDWriteFontCollection**, int>)@this->LpVtbl[4])(@this, collectionLoader, collectionKey, collectionKeySize, fontCollection);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterFontCollectionLoader(this ComPtr<IDWriteFactory6> thisVtbl, IDWriteFontCollectionLoader* fontCollectionLoader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontCollectionLoader*, int>)@this->LpVtbl[5])(@this, fontCollectionLoader);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UnregisterFontCollectionLoader(this ComPtr<IDWriteFactory6> thisVtbl, IDWriteFontCollectionLoader* fontCollectionLoader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontCollectionLoader*, int>)@this->LpVtbl[6])(@this, fontCollectionLoader);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReference(this ComPtr<IDWriteFactory6> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.Filetime* lastWriteTime, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, Silk.NET.Core.Win32Extras.Filetime*, IDWriteFontFile**, int>)@this->LpVtbl[7])(@this, filePath, lastWriteTime, fontFile);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCustomFontFileReference(this ComPtr<IDWriteFactory6> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, IDWriteFontFileLoader* fontFileLoader, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, void*, uint, IDWriteFontFileLoader*, IDWriteFontFile**, int>)@this->LpVtbl[8])(@this, fontFileReferenceKey, fontFileReferenceKeySize, fontFileLoader, fontFile);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFace(this ComPtr<IDWriteFactory6> thisVtbl, FontFaceType fontFaceType, uint numberOfFiles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IDWriteFontFile** fontFiles, uint faceIndex, FontSimulations fontFaceSimulationFlags, IDWriteFontFace** fontFace)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, FontFaceType, uint, IDWriteFontFile**, uint, FontSimulations, IDWriteFontFace**, int>)@this->LpVtbl[9])(@this, fontFaceType, numberOfFiles, fontFiles, faceIndex, fontFaceSimulationFlags, fontFace);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRenderingParams(this ComPtr<IDWriteFactory6> thisVtbl, IDWriteRenderingParams** renderingParams)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteRenderingParams**, int>)@this->LpVtbl[10])(@this, renderingParams);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMonitorRenderingParams(this ComPtr<IDWriteFactory6> thisVtbl, nint monitor, IDWriteRenderingParams** renderingParams)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, nint, IDWriteRenderingParams**, int>)@this->LpVtbl[11])(@this, monitor, renderingParams);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCustomRenderingParams(this ComPtr<IDWriteFactory6> thisVtbl, float gamma, float enhancedContrast, float clearTypeLevel, PixelGeometry pixelGeometry, RenderingMode renderingMode, IDWriteRenderingParams** renderingParams)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, float, float, float, PixelGeometry, RenderingMode, IDWriteRenderingParams**, int>)@this->LpVtbl[12])(@this, gamma, enhancedContrast, clearTypeLevel, pixelGeometry, renderingMode, renderingParams);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterFontFileLoader(this ComPtr<IDWriteFactory6> thisVtbl, IDWriteFontFileLoader* fontFileLoader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontFileLoader*, int>)@this->LpVtbl[13])(@this, fontFileLoader);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UnregisterFontFileLoader(this ComPtr<IDWriteFactory6> thisVtbl, IDWriteFontFileLoader* fontFileLoader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontFileLoader*, int>)@this->LpVtbl[14])(@this, fontFileLoader);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory6> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, IDWriteTextFormat** textFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyName, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormat);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTypography(this ComPtr<IDWriteFactory6> thisVtbl, IDWriteTypography** typography)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteTypography**, int>)@this->LpVtbl[16])(@this, typography);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiInterop(this ComPtr<IDWriteFactory6> thisVtbl, IDWriteGdiInterop** gdiInterop)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteGdiInterop**, int>)@this->LpVtbl[17])(@this, gdiInterop);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextLayout(this ComPtr<IDWriteFactory6> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, IDWriteTextFormat* textFormat, float maxWidth, float maxHeight, IDWriteTextLayout** textLayout)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, uint, IDWriteTextFormat*, float, float, IDWriteTextLayout**, int>)@this->LpVtbl[18])(@this, @string, stringLength, textFormat, maxWidth, maxHeight, textLayout);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout(this ComPtr<IDWriteFactory6> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, IDWriteTextFormat* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, IDWriteTextLayout** textLayout)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @string, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, textLayout);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEllipsisTrimmingSign(this ComPtr<IDWriteFactory6> thisVtbl, IDWriteTextFormat* textFormat, IDWriteInlineObject** trimmingSign)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteTextFormat*, IDWriteInlineObject**, int>)@this->LpVtbl[20])(@this, textFormat, trimmingSign);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextAnalyzer(this ComPtr<IDWriteFactory6> thisVtbl, IDWriteTextAnalyzer** textAnalyzer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteTextAnalyzer**, int>)@this->LpVtbl[21])(@this, textAnalyzer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateNumberSubstitution(this ComPtr<IDWriteFactory6> thisVtbl, NumberSubstitutionMethod substitutionMethod, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, Silk.NET.Core.Bool32 ignoreUserOverride, IDWriteNumberSubstitution** numberSubstitution)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, NumberSubstitutionMethod, char*, Silk.NET.Core.Bool32, IDWriteNumberSubstitution**, int>)@this->LpVtbl[22])(@this, substitutionMethod, localeName, ignoreUserOverride, numberSubstitution);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGlyphRunAnalysis(this ComPtr<IDWriteFactory6> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, RenderingMode renderingMode, MeasuringMode measuringMode, float baselineOriginX, float baselineOriginY, IDWriteGlyphRunAnalysis** glyphRunAnalysis)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, GlyphRun*, float, Matrix*, RenderingMode, MeasuringMode, float, float, IDWriteGlyphRunAnalysis**, int>)@this->LpVtbl[23])(@this, glyphRun, pixelsPerDip, transform, renderingMode, measuringMode, baselineOriginX, baselineOriginY, glyphRunAnalysis);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEudcFontCollection(this ComPtr<IDWriteFactory6> thisVtbl, IDWriteFontCollection** fontCollection, Silk.NET.Core.Bool32 checkForUpdates)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontCollection**, Silk.NET.Core.Bool32, int>)@this->LpVtbl[24])(@this, fontCollection, checkForUpdates);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSystemFontFallback(this ComPtr<IDWriteFactory6> thisVtbl, IDWriteFontFallback** fontFallback)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontFallback**, int>)@this->LpVtbl[26])(@this, fontFallback);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFallbackBuilder(this ComPtr<IDWriteFactory6> thisVtbl, IDWriteFontFallbackBuilder** fontFallbackBuilder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontFallbackBuilder**, int>)@this->LpVtbl[27])(@this, fontFallbackBuilder);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TranslateColorGlyphRun(this ComPtr<IDWriteFactory6> thisVtbl, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* worldToDeviceTransform, uint colorPaletteIndex, IDWriteColorGlyphRunEnumerator** colorLayers)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, float, float, GlyphRun*, GlyphRunDescription*, MeasuringMode, Matrix*, uint, IDWriteColorGlyphRunEnumerator**, int>)@this->LpVtbl[28])(@this, baselineOriginX, baselineOriginY, glyphRun, glyphRunDescription, measuringMode, worldToDeviceTransform, colorPaletteIndex, colorLayers);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFaceReference(this ComPtr<IDWriteFactory6> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.Filetime* lastWriteTime, uint faceIndex, FontSimulations fontSimulations, IDWriteFontFaceReference** fontFaceReference)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, Silk.NET.Core.Win32Extras.Filetime*, uint, FontSimulations, IDWriteFontFaceReference**, int>)@this->LpVtbl[34])(@this, filePath, lastWriteTime, faceIndex, fontSimulations, fontFaceReference);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSystemFontSet(this ComPtr<IDWriteFactory6> thisVtbl, IDWriteFontSet** fontSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontSet**, int>)@this->LpVtbl[35])(@this, fontSet);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontSetBuilder(this ComPtr<IDWriteFactory6> thisVtbl, IDWriteFontSetBuilder** fontSetBuilder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontSetBuilder**, int>)@this->LpVtbl[36])(@this, fontSetBuilder);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontCollectionFromFontSet(this ComPtr<IDWriteFactory6> thisVtbl, IDWriteFontSet* fontSet, IDWriteFontCollection1** fontCollection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontSet*, IDWriteFontCollection1**, int>)@this->LpVtbl[37])(@this, fontSet, fontCollection);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontDownloadQueue(this ComPtr<IDWriteFactory6> thisVtbl, IDWriteFontDownloadQueue** fontDownloadQueue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontDownloadQueue**, int>)@this->LpVtbl[39])(@this, fontDownloadQueue);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComputeGlyphOrigins(this ComPtr<IDWriteFactory6> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, MeasuringMode measuringMode, Silk.NET.Maths.Vector2D<float> baselineOrigin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* worldAndDpiTransform, Silk.NET.Maths.Vector2D<float>* glyphOrigins)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, GlyphRun*, MeasuringMode, Silk.NET.Maths.Vector2D<float>, Matrix*, Silk.NET.Maths.Vector2D<float>*, int>)@this->LpVtbl[42])(@this, glyphRun, measuringMode, baselineOrigin, worldAndDpiTransform, glyphOrigins);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInMemoryFontFileLoader(this ComPtr<IDWriteFactory6> thisVtbl, IDWriteInMemoryFontFileLoader** newLoader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteInMemoryFontFileLoader**, int>)@this->LpVtbl[44])(@this, newLoader);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHttpFontFileLoader(this ComPtr<IDWriteFactory6> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* referrerUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* extraHeaders, IDWriteRemoteFontFileLoader** newLoader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, char*, IDWriteRemoteFontFileLoader**, int>)@this->LpVtbl[45])(@this, referrerUrl, extraHeaders, newLoader);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ContainerType AnalyzeContainerType(this ComPtr<IDWriteFactory6> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fileData, uint fileDataSize)
    {
        var @this = thisVtbl.Handle;
        ContainerType ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, void*, uint, ContainerType>)@this->LpVtbl[46])(@this, fileData, fileDataSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UnpackFontFile(this ComPtr<IDWriteFactory6> thisVtbl, ContainerType containerType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fileData, uint fileDataSize, IDWriteFontFileStream** unpackedFontStream)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, ContainerType, void*, uint, IDWriteFontFileStream**, int>)@this->LpVtbl[47])(@this, containerType, fileData, fileDataSize, unpackedFontStream);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontResource(this ComPtr<IDWriteFactory6> thisVtbl, IDWriteFontFile* fontFile, uint faceIndex, IDWriteFontResource** fontResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontFile*, uint, IDWriteFontResource**, int>)@this->LpVtbl[49])(@this, fontFile, faceIndex, fontResource);
        return ret;
    }

}
