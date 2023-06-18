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
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_vertex_shader")]
    public unsafe partial class ExtVertexShader : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_vertex_shader";
        [NativeApi(EntryPoint = "glBeginVertexShaderEXT", Convention = CallingConvention.Winapi)]
        public partial void BeginVertexShader();

        [NativeApi(EntryPoint = "glBindLightParameterEXT", Convention = CallingConvention.Winapi)]
        public partial uint BindLightParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT value);

        [NativeApi(EntryPoint = "glBindMaterialParameterEXT", Convention = CallingConvention.Winapi)]
        public partial uint BindMaterialParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT value);

        [NativeApi(EntryPoint = "glBindParameterEXT", Convention = CallingConvention.Winapi)]
        public partial uint BindParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT value);

        [NativeApi(EntryPoint = "glBindTexGenParameterEXT", Convention = CallingConvention.Winapi)]
        public partial uint BindTexGenParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT unit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT coord, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT value);

        [NativeApi(EntryPoint = "glBindTextureUnitParameterEXT", Convention = CallingConvention.Winapi)]
        public partial uint BindTextureUnitParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT unit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT value);

        [NativeApi(EntryPoint = "glBindVertexShaderEXT", Convention = CallingConvention.Winapi)]
        public partial void BindVertexShader([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glDeleteVertexShaderEXT", Convention = CallingConvention.Winapi)]
        public partial void DeleteVertexShader([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glDisableVariantClientStateEXT", Convention = CallingConvention.Winapi)]
        public partial void DisableVariantClientState([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glEnableVariantClientStateEXT", Convention = CallingConvention.Winapi)]
        public partial void EnableVariantClientState([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glEndVertexShaderEXT", Convention = CallingConvention.Winapi)]
        public partial void EndVertexShader();

        [NativeApi(EntryPoint = "glExtractComponentEXT", Convention = CallingConvention.Winapi)]
        public partial void ExtractComponent([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint res, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num);

        [NativeApi(EntryPoint = "glGenSymbolsEXT", Convention = CallingConvention.Winapi)]
        public partial uint GenSymbol([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT datatype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT storagetype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT range, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint components);

        [NativeApi(EntryPoint = "glGenVertexShadersEXT", Convention = CallingConvention.Winapi)]
        public partial uint GenVertexShaders([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint range);

        [NativeApi(EntryPoint = "glGetInvariantBooleanvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetInvariantBoolean([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] bool* data);

        [NativeApi(EntryPoint = "glGetInvariantFloatvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetInvariantFloat([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* data);

        [NativeApi(EntryPoint = "glGetInvariantIntegervEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetInvariantInteger([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* data);

        [NativeApi(EntryPoint = "glGetLocalConstantBooleanvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetLocalConstantBoolean([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] bool* data);

        [NativeApi(EntryPoint = "glGetLocalConstantFloatvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetLocalConstantFloat([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* data);

        [NativeApi(EntryPoint = "glGetLocalConstantIntegervEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetLocalConstantInteger([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* data);

        [NativeApi(EntryPoint = "glGetVariantBooleanvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVariantBoolean([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] bool* data);

        [NativeApi(EntryPoint = "glGetVariantFloatvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVariantFloat([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* data);

        [NativeApi(EntryPoint = "glGetVariantIntegervEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVariantInteger([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* data);

        [NativeApi(EntryPoint = "glGetVariantPointervEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVariantPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT value, [Count(Computed = "id"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void** data);

        [NativeApi(EntryPoint = "glInsertComponentEXT", Convention = CallingConvention.Winapi)]
        public partial void InsertComponent([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint res, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num);

        [NativeApi(EntryPoint = "glIsVariantEnabledEXT", Convention = CallingConvention.Winapi)]
        public partial bool IsVariantEnabled([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT cap);

        [NativeApi(EntryPoint = "glSetInvariantEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetInvariant([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "id, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* addr);

        [NativeApi(EntryPoint = "glSetLocalConstantEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetLocalConstant([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "id, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* addr);

        [NativeApi(EntryPoint = "glShaderOp1EXT", Convention = CallingConvention.Winapi)]
        public partial void ShaderOp1([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT op, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint res, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint arg1);

        [NativeApi(EntryPoint = "glShaderOp2EXT", Convention = CallingConvention.Winapi)]
        public partial void ShaderOp2([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT op, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint res, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint arg1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint arg2);

        [NativeApi(EntryPoint = "glShaderOp3EXT", Convention = CallingConvention.Winapi)]
        public partial void ShaderOp3([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT op, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint res, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint arg1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint arg2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint arg3);

        [NativeApi(EntryPoint = "glSwizzleEXT", Convention = CallingConvention.Winapi)]
        public partial void Swizzle([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint res, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint @in, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT outX, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT outY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT outZ, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT outW);

        [NativeApi(EntryPoint = "glVariantbvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void Variant([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte* addr);

        [NativeApi(EntryPoint = "glVariantsvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void Variant([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(Silk.NET.Core.Native.FlowDirection.In)] short* addr);

        [NativeApi(EntryPoint = "glVariantivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void Variant([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* addr);

        [NativeApi(EntryPoint = "glVariantfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void Variant([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* addr);

        [NativeApi(EntryPoint = "glVariantdvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void Variant([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* addr);

        [NativeApi(EntryPoint = "glVariantubvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void Variant([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* addr);

        [NativeApi(EntryPoint = "glVariantusvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void Variant([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* addr);

        [NativeApi(EntryPoint = "glVariantuivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void Variant([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Count(Computed = "id"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* addr);

        [NativeApi(EntryPoint = "glVariantPointerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void VariantPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "id, type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* addr);

        [NativeApi(EntryPoint = "glWriteMaskEXT", Convention = CallingConvention.Winapi)]
        public partial void WriteMask([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint res, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint @in, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT outX, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT outY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT outZ, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT outW);

        public ExtVertexShader(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

