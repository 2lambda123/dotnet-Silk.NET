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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_vertex_program")]
    public unsafe partial class ArbVertexProgram : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_vertex_program";
        [NativeApi(EntryPoint = "glBindProgramARB", Convention = CallingConvention.Winapi)]
        public partial void BindProgram([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program);

        [NativeApi(EntryPoint = "glDeleteProgramsARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteProgram([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* programs);

        [NativeApi(EntryPoint = "glDisableVertexAttribArrayARB", Convention = CallingConvention.Winapi)]
        public partial void DisableVertexAttribArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glEnableVertexAttribArrayARB", Convention = CallingConvention.Winapi)]
        public partial void EnableVertexAttribArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glGenProgramsARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenProgram([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* programs);

        [NativeApi(EntryPoint = "glGetProgramivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgram([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramEnvParameterdvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramEnvParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetProgramEnvParameterfvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramEnvParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetProgramLocalParameterdvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramLocalParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetProgramLocalParameterfvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramLocalParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetProgramStringARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetProgramString([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "target, pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* @string);

        [NativeApi(EntryPoint = "glGetVertexAttribdvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribfvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribPointervARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexAttribPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void** pointer);

        [NativeApi(EntryPoint = "glIsProgramARB", Convention = CallingConvention.Winapi)]
        public partial bool IsProgram([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program);

        [NativeApi(EntryPoint = "glProgramEnvParameter4dARB", Convention = CallingConvention.Winapi)]
        public partial void ProgramEnvParameter4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double z, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double w);

        [NativeApi(EntryPoint = "glProgramEnvParameter4dvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramEnvParameter4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* @params);

        [NativeApi(EntryPoint = "glProgramEnvParameter4fARB", Convention = CallingConvention.Winapi)]
        public partial void ProgramEnvParameter4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float z, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float w);

        [NativeApi(EntryPoint = "glProgramEnvParameter4fvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramEnvParameter4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glProgramLocalParameter4dARB", Convention = CallingConvention.Winapi)]
        public partial void ProgramLocalParameter4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double z, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double w);

        [NativeApi(EntryPoint = "glProgramLocalParameter4dvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramLocalParameter4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* @params);

        [NativeApi(EntryPoint = "glProgramLocalParameter4fARB", Convention = CallingConvention.Winapi)]
        public partial void ProgramLocalParameter4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float z, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float w);

        [NativeApi(EntryPoint = "glProgramLocalParameter4fvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramLocalParameter4([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glProgramStringARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramString([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint len, [Count(Parameter = "len"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* @string);

        [NativeApi(EntryPoint = "glVertexAttrib1dARB", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double x);

        [NativeApi(EntryPoint = "glVertexAttrib1dvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glVertexAttrib1fARB", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x);

        [NativeApi(EntryPoint = "glVertexAttrib1fvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glVertexAttrib1sARB", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] short x);

        [NativeApi(EntryPoint = "glVertexAttrib1svARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glVertexAttrib2dARB", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double y);

        [NativeApi(EntryPoint = "glVertexAttrib2dvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glVertexAttrib2fARB", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y);

        [NativeApi(EntryPoint = "glVertexAttrib2fvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glVertexAttrib2sARB", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] short x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] short y);

        [NativeApi(EntryPoint = "glVertexAttrib2svARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glVertexAttrib3dARB", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double z);

        [NativeApi(EntryPoint = "glVertexAttrib3dvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glVertexAttrib3fARB", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glVertexAttrib3fvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glVertexAttrib3sARB", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] short x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] short y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] short z);

        [NativeApi(EntryPoint = "glVertexAttrib3svARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glVertexAttrib4bvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte* v);

        [NativeApi(EntryPoint = "glVertexAttrib4dARB", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double z, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double w);

        [NativeApi(EntryPoint = "glVertexAttrib4dvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glVertexAttrib4fARB", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float z, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float w);

        [NativeApi(EntryPoint = "glVertexAttrib4fvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glVertexAttrib4ivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glVertexAttrib4sARB", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] short x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] short y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] short z, [Flow(Silk.NET.Core.Native.FlowDirection.In)] short w);

        [NativeApi(EntryPoint = "glVertexAttrib4svARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glVertexAttrib4ubvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* v);

        [NativeApi(EntryPoint = "glVertexAttrib4uivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* v);

        [NativeApi(EntryPoint = "glVertexAttrib4usvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* v);

        [NativeApi(EntryPoint = "glVertexAttrib4NbvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib4N([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte* v);

        [NativeApi(EntryPoint = "glVertexAttrib4NivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib4N([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glVertexAttrib4NsvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib4N([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glVertexAttrib4NubARB", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib4N([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte z, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte w);

        [NativeApi(EntryPoint = "glVertexAttrib4NubvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib4N([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* v);

        [NativeApi(EntryPoint = "glVertexAttrib4NuivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib4N([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* v);

        [NativeApi(EntryPoint = "glVertexAttrib4NusvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib4N([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* v);

        [NativeApi(EntryPoint = "glVertexAttribPointerARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pointer);

        public ArbVertexProgram(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

