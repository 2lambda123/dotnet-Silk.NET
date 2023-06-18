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

namespace Silk.NET.DirectWrite
{
    [Guid("98eff3a5-b667-479a-b145-e2fa5b9fdc29")]
    [NativeName("Name", "IDWriteFontFace5")]
    public unsafe partial struct IDWriteFontFace5 : IComVtbl<IDWriteFontFace5>, IComVtbl<IDWriteFontFace4>, IComVtbl<IDWriteFontFace3>, IComVtbl<IDWriteFontFace2>, IComVtbl<IDWriteFontFace1>, IComVtbl<IDWriteFontFace>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("98eff3a5-b667-479a-b145-e2fa5b9fdc29");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDWriteFontFace4(IDWriteFontFace5 val)
            => Unsafe.As<IDWriteFontFace5, IDWriteFontFace4>(ref val);

        public static implicit operator IDWriteFontFace3(IDWriteFontFace5 val)
            => Unsafe.As<IDWriteFontFace5, IDWriteFontFace3>(ref val);

        public static implicit operator IDWriteFontFace2(IDWriteFontFace5 val)
            => Unsafe.As<IDWriteFontFace5, IDWriteFontFace2>(ref val);

        public static implicit operator IDWriteFontFace1(IDWriteFontFace5 val)
            => Unsafe.As<IDWriteFontFace5, IDWriteFontFace1>(ref val);

        public static implicit operator IDWriteFontFace(IDWriteFontFace5 val)
            => Unsafe.As<IDWriteFontFace5, IDWriteFontFace>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteFontFace5 val)
            => Unsafe.As<IDWriteFontFace5, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteFontFace5
        (
            void** lpVtbl = null
        ) : this()
        {
            if (lpVtbl is not null)
            {
                LpVtbl = lpVtbl;
            }
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (IDWriteFontFace5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteFontFace5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteFontFace5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly FontFaceType GetType()
        {
            var @this = (IDWriteFontFace5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            FontFaceType ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, FontFaceType>)@this->LpVtbl[3])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFiles(uint* numberOfFiles, IDWriteFontFile** fontFiles)
        {
            var @this = (IDWriteFontFace5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, uint*, IDWriteFontFile**, int>)@this->LpVtbl[4])(@this, numberOfFiles, fontFiles);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetIndex()
        {
            var @this = (IDWriteFontFace5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, uint>)@this->LpVtbl[5])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly FontSimulations GetSimulations()
        {
            var @this = (IDWriteFontFace5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            FontSimulations ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, FontSimulations>)@this->LpVtbl[6])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 IsSymbolFont()
        {
            var @this = (IDWriteFontFace5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, Silk.NET.Core.Bool32>)@this->LpVtbl[7])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetMetrics(FontMetrics* fontFaceMetrics)
        {
            var @this = (IDWriteFontFace5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, FontMetrics*, void>)@this->LpVtbl[8])(@this, fontFaceMetrics);
        }

        /// <summary>To be documented.</summary>
        public readonly ushort GetGlyphCount()
        {
            var @this = (IDWriteFontFace5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ushort ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, ushort>)@this->LpVtbl[9])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDesignGlyphMetrics([Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, Silk.NET.Core.Bool32 isSideways)
        {
            var @this = (IDWriteFontFace5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[10])(@this, glyphIndices, glyphCount, glyphMetrics, isSideways);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphIndicesA([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* codePoints, uint codePointCount, ushort* glyphIndices)
        {
            var @this = (IDWriteFontFace5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, uint*, uint, ushort*, int>)@this->LpVtbl[11])(@this, codePoints, codePointCount, glyphIndices);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TryGetFontTable(uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, uint* tableSize, void** tableContext, int* exists)
        {
            var @this = (IDWriteFontFace5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableData, tableSize, tableContext, exists);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ReleaseFontTable(void* tableContext)
        {
            var @this = (IDWriteFontFace5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, void*, void>)@this->LpVtbl[13])(@this, tableContext);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphRunOutline(float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
        {
            var @this = (IDWriteFontFace5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndices, glyphAdvances, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySink);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRecommendedRenderingMode(float emSize, float pixelsPerDip, MeasuringMode measuringMode, IDWriteRenderingParams* renderingParams, RenderingMode* renderingMode)
        {
            var @this = (IDWriteFontFace5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, float, float, MeasuringMode, IDWriteRenderingParams*, RenderingMode*, int>)@this->LpVtbl[15])(@this, emSize, pixelsPerDip, measuringMode, renderingParams, renderingMode);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGdiCompatibleMetrics(float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, FontMetrics* fontFaceMetrics)
        {
            var @this = (IDWriteFontFace5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, float, float, Matrix*, FontMetrics*, int>)@this->LpVtbl[16])(@this, emSize, pixelsPerDip, transform, fontFaceMetrics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGdiCompatibleGlyphMetrics(float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, Silk.NET.Core.Bool32 isSideways)
        {
            var @this = (IDWriteFontFace5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, float, float, Matrix*, Silk.NET.Core.Bool32, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[17])(@this, emSize, pixelsPerDip, transform, useGdiNatural, glyphIndices, glyphCount, glyphMetrics, isSideways);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCaretMetrics(CaretMetrics* caretMetrics)
        {
            var @this = (IDWriteFontFace5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, CaretMetrics*, void>)@this->LpVtbl[20])(@this, caretMetrics);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetUnicodeRanges(uint maxRangeCount, UnicodeRange* unicodeRanges, uint* actualRangeCount)
        {
            var @this = (IDWriteFontFace5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, uint, UnicodeRange*, uint*, int>)@this->LpVtbl[21])(@this, maxRangeCount, unicodeRanges, actualRangeCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 IsMonospacedFont()
        {
            var @this = (IDWriteFontFace5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, Silk.NET.Core.Bool32>)@this->LpVtbl[22])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDesignGlyphAdvances(uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, int* glyphAdvances, Silk.NET.Core.Bool32 isSideways)
        {
            var @this = (IDWriteFontFace5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, uint, ushort*, int*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[23])(@this, glyphCount, glyphIndices, glyphAdvances, isSideways);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGdiCompatibleGlyphAdvances(float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, int* glyphAdvances)
        {
            var @this = (IDWriteFontFace5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, float, float, Matrix*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, uint, ushort*, int*, int>)@this->LpVtbl[24])(@this, emSize, pixelsPerDip, transform, useGdiNatural, isSideways, glyphCount, glyphIndices, glyphAdvances);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetKerningPairAdjustments(uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, int* glyphAdvanceAdjustments)
        {
            var @this = (IDWriteFontFace5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, uint, ushort*, int*, int>)@this->LpVtbl[25])(@this, glyphCount, glyphIndices, glyphAdvanceAdjustments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 HasKerningPairs()
        {
            var @this = (IDWriteFontFace5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, Silk.NET.Core.Bool32>)@this->LpVtbl[26])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVerticalGlyphVariants(uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* nominalGlyphIndices, ushort* verticalGlyphIndices)
        {
            var @this = (IDWriteFontFace5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, uint, ushort*, ushort*, int>)@this->LpVtbl[28])(@this, glyphCount, nominalGlyphIndices, verticalGlyphIndices);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 HasVerticalGlyphVariants()
        {
            var @this = (IDWriteFontFace5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, Silk.NET.Core.Bool32>)@this->LpVtbl[29])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 IsColorFont()
        {
            var @this = (IDWriteFontFace5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, Silk.NET.Core.Bool32>)@this->LpVtbl[30])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetColorPaletteCount()
        {
            var @this = (IDWriteFontFace5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, uint>)@this->LpVtbl[31])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetPaletteEntryCount()
        {
            var @this = (IDWriteFontFace5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, uint>)@this->LpVtbl[32])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPaletteEntries(uint colorPaletteIndex, uint firstEntryIndex, uint entryCount, Silk.NET.DXGI.D3Dcolorvalue* paletteEntries)
        {
            var @this = (IDWriteFontFace5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, uint, uint, uint, Silk.NET.DXGI.D3Dcolorvalue*, int>)@this->LpVtbl[33])(@this, colorPaletteIndex, firstEntryIndex, entryCount, paletteEntries);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontFaceReference(IDWriteFontFaceReference** fontFaceReference)
        {
            var @this = (IDWriteFontFace5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, IDWriteFontFaceReference**, int>)@this->LpVtbl[35])(@this, fontFaceReference);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetPanose(Panose* panose)
        {
            var @this = (IDWriteFontFace5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, Panose*, void>)@this->LpVtbl[36])(@this, panose);
        }

        /// <summary>To be documented.</summary>
        public readonly FontWeight GetWeight()
        {
            var @this = (IDWriteFontFace5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            FontWeight ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, FontWeight>)@this->LpVtbl[37])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly FontStretch GetStretch()
        {
            var @this = (IDWriteFontFace5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            FontStretch ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, FontStretch>)@this->LpVtbl[38])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly FontStyle GetStyle()
        {
            var @this = (IDWriteFontFace5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            FontStyle ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, FontStyle>)@this->LpVtbl[39])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFamilyNames(IDWriteLocalizedStrings** names)
        {
            var @this = (IDWriteFontFace5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, IDWriteLocalizedStrings**, int>)@this->LpVtbl[40])(@this, names);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFaceNames(IDWriteLocalizedStrings** names)
        {
            var @this = (IDWriteFontFace5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, IDWriteLocalizedStrings**, int>)@this->LpVtbl[41])(@this, names);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInformationalStrings(InformationalStringID informationalStringID, IDWriteLocalizedStrings** informationalStrings, int* exists)
        {
            var @this = (IDWriteFontFace5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, InformationalStringID, IDWriteLocalizedStrings**, int*, int>)@this->LpVtbl[42])(@this, informationalStringID, informationalStrings, exists);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 HasCharacter(uint unicodeValue)
        {
            var @this = (IDWriteFontFace5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, uint, Silk.NET.Core.Bool32>)@this->LpVtbl[43])(@this, unicodeValue);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 IsCharacterLocal(uint unicodeValue)
        {
            var @this = (IDWriteFontFace5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, uint, Silk.NET.Core.Bool32>)@this->LpVtbl[45])(@this, unicodeValue);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 IsGlyphLocal(ushort glyphId)
        {
            var @this = (IDWriteFontFace5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, ushort, Silk.NET.Core.Bool32>)@this->LpVtbl[46])(@this, glyphId);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AreCharactersLocal([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* characters, uint characterCount, Silk.NET.Core.Bool32 enqueueIfNotLocal, int* isLocal)
        {
            var @this = (IDWriteFontFace5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, char*, uint, Silk.NET.Core.Bool32, int*, int>)@this->LpVtbl[47])(@this, characters, characterCount, enqueueIfNotLocal, isLocal);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AreGlyphsLocal([Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, uint glyphCount, Silk.NET.Core.Bool32 enqueueIfNotLocal, int* isLocal)
        {
            var @this = (IDWriteFontFace5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, ushort*, uint, Silk.NET.Core.Bool32, int*, int>)@this->LpVtbl[48])(@this, glyphIndices, glyphCount, enqueueIfNotLocal, isLocal);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly GlyphImageFormats GetGlyphImageFormats()
        {
            var @this = (IDWriteFontFace5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            GlyphImageFormats ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, GlyphImageFormats>)@this->LpVtbl[50])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphImageData(ushort glyphId, uint pixelsPerEm, GlyphImageFormats glyphImageFormat, GlyphImageData* glyphData, void** glyphDataContext)
        {
            var @this = (IDWriteFontFace5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, ushort, uint, GlyphImageFormats, GlyphImageData*, void**, int>)@this->LpVtbl[51])(@this, glyphId, pixelsPerEm, glyphImageFormat, glyphData, glyphDataContext);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ReleaseGlyphImageData(void* glyphDataContext)
        {
            var @this = (IDWriteFontFace5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, void*, void>)@this->LpVtbl[52])(@this, glyphDataContext);
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetFontAxisValueCount()
        {
            var @this = (IDWriteFontFace5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, uint>)@this->LpVtbl[53])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontAxisValues(FontAxisValue* fontAxisValues, uint fontAxisValueCount)
        {
            var @this = (IDWriteFontFace5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, FontAxisValue*, uint, int>)@this->LpVtbl[54])(@this, fontAxisValues, fontAxisValueCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 HasVariations()
        {
            var @this = (IDWriteFontFace5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, Silk.NET.Core.Bool32>)@this->LpVtbl[55])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontResource(IDWriteFontResource** fontResource)
        {
            var @this = (IDWriteFontFace5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, IDWriteFontResource**, int>)@this->LpVtbl[56])(@this, fontResource);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe Silk.NET.Core.Bool32 Equals(IDWriteFontFace* fontFace)
        {
            var @this = (IDWriteFontFace5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, IDWriteFontFace*, Silk.NET.Core.Bool32>)@this->LpVtbl[57])(@this, fontFace);
            return ret;
        }

    }
}
