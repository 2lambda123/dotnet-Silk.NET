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

namespace Silk.NET.Direct3D.Compilers
{
    public unsafe partial class D3DCompiler : NativeAPI
    {
        [NativeName("Type", "")]
        [NativeName("Name", "D3DCOMPILER_DLL_W")]
        public const string CompilerDllW = unchecked((string) "d3dcompiler_47.dll");
        [NativeName("Type", "")]
        [NativeName("Name", "D3DCOMPILER_DLL_A")]
        public const string CompilerDllA = unchecked((string) "d3dcompiler_47.dll");
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_COMPILER_VERSION")]
        public const int CompilerVersion = unchecked((int) 0x2F);
        [NativeName("Type", "")]
        [NativeName("Name", "D3DCOMPILER_DLL")]
        public const string CompilerDll = unchecked((string) "d3dcompiler_47.dll");
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DCOMPILE_OPTIMIZATION_LEVEL1")]
        public const int CompileOptimizationLevel1 = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DCOMPILE_FLAGS2_FORCE_ROOT_SIGNATURE_LATEST")]
        public const int CompileFlags2ForceRootSignatureLatest = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DCOMPILE_SECDATA_MERGE_UAV_SLOTS")]
        public const int CompileSecdataMergeUavSlots = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DCOMPILE_SECDATA_PRESERVE_TEMPLATE_SLOTS")]
        public const int CompileSecdataPreserveTemplateSlots = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3DCOMPILE_SECDATA_REQUIRE_TEMPLATE_MATCH")]
        public const int CompileSecdataRequireTemplateMatch = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_DISASM_ENABLE_COLOR_CODE")]
        public const int DisasmEnableColorCode = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_DISASM_ENABLE_DEFAULT_VALUE_PRINTS")]
        public const int DisasmEnableDefaultValuePrints = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_DISASM_ENABLE_INSTRUCTION_NUMBERING")]
        public const int DisasmEnableInstructionNumbering = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_DISASM_ENABLE_INSTRUCTION_CYCLE")]
        public const int DisasmEnableInstructionCycle = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_DISASM_DISABLE_DEBUG_INFO")]
        public const int DisasmDisableDebugInfo = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_DISASM_ENABLE_INSTRUCTION_OFFSET")]
        public const int DisasmEnableInstructionOffset = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_DISASM_INSTRUCTION_ONLY")]
        public const int DisasmInstructionOnly = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_DISASM_PRINT_HEX_LITERALS")]
        public const int DisasmPrintHexLiterals = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_GET_INST_OFFSETS_INCLUDE_NON_EXECUTABLE")]
        public const int GetInstOffsetsIncludeNonExecutable = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_COMPRESS_SHADER_KEEP_ALL_PARTS")]
        public const int CompressShaderKeepAllParts = unchecked((int) 0x1);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 51, Column 1 in d3dcompiler.h")]
        [NativeApi(EntryPoint = "D3DReadFileToBlob", Convention = CallingConvention.StdCall)]
        public unsafe partial int ReadFileToBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pFileName, Silk.NET.Core.Native.ID3D10Blob** ppContents);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 61, Column 1 in d3dcompiler.h")]
        [NativeApi(EntryPoint = "D3DWriteBlobToFile", Convention = CallingConvention.StdCall)]
        public unsafe partial int WriteBlobToFile(Silk.NET.Core.Native.ID3D10Blob* pBlob, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pFileName, Silk.NET.Core.Bool32 bOverwrite);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 210, Column 1 in d3dcompiler.h")]
        [NativeApi(EntryPoint = "D3DCompile", Convention = CallingConvention.StdCall)]
        public unsafe partial int Compile([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, nuint SrcDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DShaderMacro* pDefines, Silk.NET.Core.Native.ID3DInclude* pInclude, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntrypoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTarget, uint Flags1, uint Flags2, Silk.NET.Core.Native.ID3D10Blob** ppCode, Silk.NET.Core.Native.ID3D10Blob** ppErrorMsgs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 240, Column 1 in d3dcompiler.h")]
        [NativeApi(EntryPoint = "D3DCompile2", Convention = CallingConvention.StdCall)]
        public unsafe partial int Compile2([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, nuint SrcDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DShaderMacro* pDefines, Silk.NET.Core.Native.ID3DInclude* pInclude, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntrypoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTarget, uint Flags1, uint Flags2, uint SecondaryDataFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSecondaryData, nuint SecondaryDataSize, Silk.NET.Core.Native.ID3D10Blob** ppCode, Silk.NET.Core.Native.ID3D10Blob** ppErrorMsgs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 256, Column 1 in d3dcompiler.h")]
        [NativeApi(EntryPoint = "D3DCompileFromFile", Convention = CallingConvention.StdCall)]
        public unsafe partial int CompileFromFile([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pFileName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DShaderMacro* pDefines, Silk.NET.Core.Native.ID3DInclude* pInclude, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntrypoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTarget, uint Flags1, uint Flags2, Silk.NET.Core.Native.ID3D10Blob** ppCode, Silk.NET.Core.Native.ID3D10Blob** ppErrorMsgs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 274, Column 1 in d3dcompiler.h")]
        [NativeApi(EntryPoint = "D3DPreprocess", Convention = CallingConvention.StdCall)]
        public unsafe partial int Preprocess([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, nuint SrcDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DShaderMacro* pDefines, Silk.NET.Core.Native.ID3DInclude* pInclude, Silk.NET.Core.Native.ID3D10Blob** ppCodeText, Silk.NET.Core.Native.ID3D10Blob** ppErrorMsgs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 299, Column 1 in d3dcompiler.h")]
        [NativeApi(EntryPoint = "D3DGetDebugInfo", Convention = CallingConvention.StdCall)]
        public unsafe partial int GetDebugInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, nuint SrcDataSize, Silk.NET.Core.Native.ID3D10Blob** ppDebugInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 311, Column 1 in d3dcompiler.h")]
        [NativeApi(EntryPoint = "D3DReflect", Convention = CallingConvention.StdCall)]
        public unsafe partial int Reflect([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, nuint SrcDataSize, Guid* pInterface, void** ppReflector);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 324, Column 1 in d3dcompiler.h")]
        [NativeApi(EntryPoint = "D3DReflectLibrary", Convention = CallingConvention.StdCall)]
        public unsafe partial int ReflectLibrary([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, nuint SrcDataSize, Guid* riid, void** ppReflector);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 345, Column 1 in d3dcompiler.h")]
        [NativeApi(EntryPoint = "D3DDisassemble", Convention = CallingConvention.StdCall)]
        public unsafe partial int Disassemble([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, nuint SrcDataSize, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* szComments, Silk.NET.Core.Native.ID3D10Blob** ppDisassembly);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 359, Column 1 in d3dcompiler.h")]
        [NativeApi(EntryPoint = "D3DDisassembleRegion", Convention = CallingConvention.StdCall)]
        public unsafe partial int DisassembleRegion([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, nuint SrcDataSize, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* szComments, nuint StartByteOffset, nuint NumInsts, nuint* pFinishByteOffset, Silk.NET.Core.Native.ID3D10Blob** ppDisassembly);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 372, Column 1 in d3dcompiler.h")]
        [NativeApi(EntryPoint = "D3DCreateLinker", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateLinker(void** ppLinker);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 375, Column 1 in d3dcompiler.h")]
        [NativeApi(EntryPoint = "D3DLoadModule", Convention = CallingConvention.StdCall)]
        public unsafe partial int LoadModule([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, nuint cbSrcDataSize, void** ppModule);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 380, Column 1 in d3dcompiler.h")]
        [NativeApi(EntryPoint = "D3DCreateFunctionLinkingGraph", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateFunctionLinkingGraph(uint uFlags, void** ppFunctionLinkingGraph);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 394, Column 1 in d3dcompiler.h")]
        [NativeApi(EntryPoint = "D3DGetTraceInstructionOffsets", Convention = CallingConvention.StdCall)]
        public unsafe partial int GetTraceInstructionOffsets([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, nuint SrcDataSize, uint Flags, nuint StartInstIndex, nuint NumInsts, nuint* pOffsets, nuint* pTotalInsts);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 409, Column 1 in d3dcompiler.h")]
        [NativeApi(EntryPoint = "D3DGetInputSignatureBlob", Convention = CallingConvention.StdCall)]
        public unsafe partial int GetInputSignatureBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, nuint SrcDataSize, Silk.NET.Core.Native.ID3D10Blob** ppSignatureBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 420, Column 1 in d3dcompiler.h")]
        [NativeApi(EntryPoint = "D3DGetOutputSignatureBlob", Convention = CallingConvention.StdCall)]
        public unsafe partial int GetOutputSignatureBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, nuint SrcDataSize, Silk.NET.Core.Native.ID3D10Blob** ppSignatureBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 431, Column 1 in d3dcompiler.h")]
        [NativeApi(EntryPoint = "D3DGetInputAndOutputSignatureBlob", Convention = CallingConvention.StdCall)]
        public unsafe partial int GetInputAndOutputSignatureBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, nuint SrcDataSize, Silk.NET.Core.Native.ID3D10Blob** ppSignatureBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 452, Column 1 in d3dcompiler.h")]
        [NativeApi(EntryPoint = "D3DStripShader", Convention = CallingConvention.StdCall)]
        public unsafe partial int StripShader([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pShaderBytecode, nuint BytecodeLength, uint uStripFlags, Silk.NET.Core.Native.ID3D10Blob** ppStrippedBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 488, Column 1 in d3dcompiler.h")]
        [NativeApi(EntryPoint = "D3DGetBlobPart", Convention = CallingConvention.StdCall)]
        public unsafe partial int GetBlobPart([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, nuint SrcDataSize, BlobPart Part, uint Flags, Silk.NET.Core.Native.ID3D10Blob** ppPart);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 501, Column 1 in d3dcompiler.h")]
        [NativeApi(EntryPoint = "D3DSetBlobPart", Convention = CallingConvention.StdCall)]
        public unsafe partial int SetBlobPart([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, nuint SrcDataSize, BlobPart Part, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pPart, nuint PartSize, Silk.NET.Core.Native.ID3D10Blob** ppNewShader);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 516, Column 1 in d3dcompiler.h")]
        [NativeApi(EntryPoint = "D3DCreateBlob", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateBlob(nuint Size, Silk.NET.Core.Native.ID3D10Blob** ppBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 534, Column 1 in d3dcompiler.h")]
        [NativeApi(EntryPoint = "D3DCompressShaders", Convention = CallingConvention.StdCall)]
        public unsafe partial int CompressShaders(uint uNumShaders, ShaderData* pShaderData, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppCompressedData);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 546, Column 1 in d3dcompiler.h")]
        [NativeApi(EntryPoint = "D3DDecompressShaders", Convention = CallingConvention.StdCall)]
        public unsafe partial int DecompressShaders([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, nuint SrcDataSize, uint uNumShaders, uint uStartIndex, uint* pIndices, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaders, uint* pTotalShaders);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 570, Column 1 in d3dcompiler.h")]
        [NativeApi(EntryPoint = "D3DDisassemble10Effect", Convention = CallingConvention.StdCall)]
        public unsafe partial int Disassemble10Effect(ID3D10Effect* pEffect, uint Flags, Silk.NET.Core.Native.ID3D10Blob** ppDisassembly);


        public D3DCompiler(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

