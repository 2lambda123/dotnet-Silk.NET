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

namespace Silk.NET.OpenGL.Legacy.Extensions.INTEL
{
    [Extension("INTEL_performance_query")]
    public unsafe partial class IntelPerformanceQuery : NativeExtension<GL>
    {
        public const string ExtensionName = "INTEL_performance_query";
        [NativeApi(EntryPoint = "glBeginPerfQueryINTEL", Convention = CallingConvention.Winapi)]
        public partial void BeginPerfQuery([Flow(FlowDirection.In)] uint queryHandle);

        [NativeApi(EntryPoint = "glCreatePerfQueryINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void CreatePerfQuery([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.Out)] uint* queryHandle);

        [NativeApi(EntryPoint = "glCreatePerfQueryINTEL", Convention = CallingConvention.Winapi)]
        public partial void CreatePerfQuery([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.Out)] out uint queryHandle);

        [NativeApi(EntryPoint = "glDeletePerfQueryINTEL", Convention = CallingConvention.Winapi)]
        public partial void DeletePerfQuery([Flow(FlowDirection.In)] uint queryHandle);

        [NativeApi(EntryPoint = "glEndPerfQueryINTEL", Convention = CallingConvention.Winapi)]
        public partial void EndPerfQuery([Flow(FlowDirection.In)] uint queryHandle);

        [NativeApi(EntryPoint = "glGetFirstPerfQueryIdINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFirstPerfQueryId([Flow(FlowDirection.Out)] uint* queryId);

        [NativeApi(EntryPoint = "glGetFirstPerfQueryIdINTEL", Convention = CallingConvention.Winapi)]
        public partial void GetFirstPerfQueryId([Flow(FlowDirection.Out)] out uint queryId);

        [NativeApi(EntryPoint = "glGetNextPerfQueryIdINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNextPerfQueryId([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.Out)] uint* nextQueryId);

        [NativeApi(EntryPoint = "glGetNextPerfQueryIdINTEL", Convention = CallingConvention.Winapi)]
        public partial void GetNextPerfQueryId([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.Out)] out uint nextQueryId);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfQueryDataINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryData([Flow(FlowDirection.In)] uint queryHandle, [Flow(FlowDirection.In)] uint flags, [Flow(FlowDirection.In)] uint dataSize, [Flow(FlowDirection.Out)] void* data, [Flow(FlowDirection.Out)] uint* bytesWritten);

        [NativeApi(EntryPoint = "glGetPerfQueryDataINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryData([Flow(FlowDirection.In)] uint queryHandle, [Flow(FlowDirection.In)] uint flags, [Flow(FlowDirection.In)] uint dataSize, [Flow(FlowDirection.Out)] void* data, [Flow(FlowDirection.Out)] out uint bytesWritten);

        [NativeApi(EntryPoint = "glGetPerfQueryIdByNameINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryIdByName([Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] uint* queryId);

        [NativeApi(EntryPoint = "glGetPerfQueryIdByNameINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryIdByName([Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] out uint queryId);

        [NativeApi(EntryPoint = "glGetPerfQueryIdByNameINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryIdByName([Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] uint* queryId);

        [NativeApi(EntryPoint = "glGetPerfQueryIdByNameINTEL", Convention = CallingConvention.Winapi)]
        public partial void GetPerfQueryIdByName([Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] out uint queryId);

        [NativeApi(EntryPoint = "glGetPerfQueryIdByNameINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryIdByName([Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string queryName, [Flow(FlowDirection.Out)] uint* queryId);

        [NativeApi(EntryPoint = "glGetPerfQueryIdByNameINTEL", Convention = CallingConvention.Winapi)]
        public partial void GetPerfQueryIdByName([Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string queryName, [Flow(FlowDirection.Out)] out uint queryId);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] uint* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] out uint capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] uint* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] out uint capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] uint* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] out uint capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] uint* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] out uint capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] uint* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] out uint capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] uint* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] out uint capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] uint* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] out uint capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] uint* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] out uint capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] uint* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] out uint capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] uint* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] out uint capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] uint* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] out uint capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] uint* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] out uint capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] uint* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] out uint capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] uint* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] out uint capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] uint* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] out uint capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] uint* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] out uint capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] uint* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] out uint capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] uint* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] out uint capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] uint* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] out uint capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] uint* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] out uint capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] uint* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] out uint capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] uint* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] out uint capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] uint* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] out uint capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] uint* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] out uint capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] out PerformanceQueryCapsMaskINTEL capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] out PerformanceQueryCapsMaskINTEL capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] out PerformanceQueryCapsMaskINTEL capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] out PerformanceQueryCapsMaskINTEL capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] out PerformanceQueryCapsMaskINTEL capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] out PerformanceQueryCapsMaskINTEL capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] out PerformanceQueryCapsMaskINTEL capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] out PerformanceQueryCapsMaskINTEL capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] out PerformanceQueryCapsMaskINTEL capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] out PerformanceQueryCapsMaskINTEL capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] out PerformanceQueryCapsMaskINTEL capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] out PerformanceQueryCapsMaskINTEL capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] out PerformanceQueryCapsMaskINTEL capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] out PerformanceQueryCapsMaskINTEL capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] out PerformanceQueryCapsMaskINTEL capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] out PerformanceQueryCapsMaskINTEL capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] out PerformanceQueryCapsMaskINTEL capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] out PerformanceQueryCapsMaskINTEL capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] out PerformanceQueryCapsMaskINTEL capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] out PerformanceQueryCapsMaskINTEL capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] out PerformanceQueryCapsMaskINTEL capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] out PerformanceQueryCapsMaskINTEL capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] out PerformanceQueryCapsMaskINTEL capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] out PerformanceQueryCapsMaskINTEL capsMask);

        public unsafe uint CreatePerfQuery()
        {
            const uint queryId = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreatePerfQuery(queryId, &ret);
            return ret;
        }

        public unsafe uint GetFirstPerfQueryId()
        {
            // ReturnTypeOverloader
            uint ret = default;
            GetFirstPerfQueryId(&ret);
            return ret;
        }

        public unsafe uint GetNextPerfQueryId()
        {
            const uint queryId = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GetNextPerfQueryId(queryId, &ret);
            return ret;
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), counterDescLength, counterDesc, out counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, rawCounterMaxValue);
        }

        public unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue)
        {
            // ImplicitCountSpanOverloader
            GetPerfCounterInfo(queryId, counterId, (uint) counterName.Length, out counterName.GetPinnableReference(), (uint) counterDesc.Length, out counterDesc.GetPinnableReference(), out counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out rawCounterMaxValue);
        }

        public unsafe uint GetPerfQueryIdByName([Flow(FlowDirection.Out)] byte* queryName)
        {
            // ReturnTypeOverloader
            uint ret = default;
            GetPerfQueryIdByName(queryName, &ret);
            return ret;
        }

        public unsafe uint GetPerfQueryIdByName([Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string queryName)
        {
            // ReturnTypeOverloader
            uint ret = default;
            GetPerfQueryIdByName(queryName, &ret);
            return ret;
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<byte> queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] uint* capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), dataSize, noCounters, noInstances, capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<byte> queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] out uint capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), dataSize, noCounters, noInstances, out capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<byte> queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] uint* capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), dataSize, noCounters, out noInstances, capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<byte> queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] out uint capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), dataSize, noCounters, out noInstances, out capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<byte> queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] uint* capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), dataSize, out noCounters, noInstances, capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<byte> queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] out uint capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), dataSize, out noCounters, noInstances, out capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<byte> queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] uint* capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), dataSize, out noCounters, out noInstances, capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<byte> queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] out uint capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), dataSize, out noCounters, out noInstances, out capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<byte> queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] uint* capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), out dataSize, noCounters, noInstances, capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<byte> queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] out uint capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), out dataSize, noCounters, noInstances, out capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<byte> queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] uint* capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), out dataSize, noCounters, out noInstances, capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<byte> queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] out uint capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), out dataSize, noCounters, out noInstances, out capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<byte> queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] uint* capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), out dataSize, out noCounters, noInstances, capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<byte> queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] out uint capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), out dataSize, out noCounters, noInstances, out capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<byte> queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] uint* capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), out dataSize, out noCounters, out noInstances, capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<byte> queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] out uint capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), out dataSize, out noCounters, out noInstances, out capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<string> queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] uint* capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), dataSize, noCounters, noInstances, capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<string> queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] out uint capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), dataSize, noCounters, noInstances, out capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<string> queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] uint* capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), dataSize, noCounters, out noInstances, capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<string> queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] out uint capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), dataSize, noCounters, out noInstances, out capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<string> queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] uint* capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), dataSize, out noCounters, noInstances, capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<string> queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] out uint capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), dataSize, out noCounters, noInstances, out capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<string> queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] uint* capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), dataSize, out noCounters, out noInstances, capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<string> queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] out uint capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), dataSize, out noCounters, out noInstances, out capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<string> queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] uint* capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), out dataSize, noCounters, noInstances, capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<string> queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] out uint capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), out dataSize, noCounters, noInstances, out capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<string> queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] uint* capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), out dataSize, noCounters, out noInstances, capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<string> queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] out uint capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), out dataSize, noCounters, out noInstances, out capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<string> queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] uint* capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), out dataSize, out noCounters, noInstances, capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<string> queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] out uint capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), out dataSize, out noCounters, noInstances, out capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<string> queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] uint* capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), out dataSize, out noCounters, out noInstances, capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<string> queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] out uint capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), out dataSize, out noCounters, out noInstances, out capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<byte> queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), dataSize, noCounters, noInstances, capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<byte> queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] out PerformanceQueryCapsMaskINTEL capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), dataSize, noCounters, noInstances, out capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<byte> queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), dataSize, noCounters, out noInstances, capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<byte> queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] out PerformanceQueryCapsMaskINTEL capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), dataSize, noCounters, out noInstances, out capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<byte> queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), dataSize, out noCounters, noInstances, capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<byte> queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] out PerformanceQueryCapsMaskINTEL capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), dataSize, out noCounters, noInstances, out capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<byte> queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), dataSize, out noCounters, out noInstances, capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<byte> queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] out PerformanceQueryCapsMaskINTEL capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), dataSize, out noCounters, out noInstances, out capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<byte> queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), out dataSize, noCounters, noInstances, capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<byte> queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] out PerformanceQueryCapsMaskINTEL capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), out dataSize, noCounters, noInstances, out capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<byte> queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), out dataSize, noCounters, out noInstances, capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<byte> queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] out PerformanceQueryCapsMaskINTEL capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), out dataSize, noCounters, out noInstances, out capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<byte> queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), out dataSize, out noCounters, noInstances, capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<byte> queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] out PerformanceQueryCapsMaskINTEL capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), out dataSize, out noCounters, noInstances, out capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<byte> queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), out dataSize, out noCounters, out noInstances, capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<byte> queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] out PerformanceQueryCapsMaskINTEL capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), out dataSize, out noCounters, out noInstances, out capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<string> queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), dataSize, noCounters, noInstances, capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<string> queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] out PerformanceQueryCapsMaskINTEL capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), dataSize, noCounters, noInstances, out capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<string> queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), dataSize, noCounters, out noInstances, capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<string> queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] out PerformanceQueryCapsMaskINTEL capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), dataSize, noCounters, out noInstances, out capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<string> queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), dataSize, out noCounters, noInstances, capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<string> queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] out PerformanceQueryCapsMaskINTEL capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), dataSize, out noCounters, noInstances, out capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<string> queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), dataSize, out noCounters, out noInstances, capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<string> queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] out PerformanceQueryCapsMaskINTEL capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), dataSize, out noCounters, out noInstances, out capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<string> queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), out dataSize, noCounters, noInstances, capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<string> queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] out PerformanceQueryCapsMaskINTEL capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), out dataSize, noCounters, noInstances, out capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<string> queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), out dataSize, noCounters, out noInstances, capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<string> queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] out PerformanceQueryCapsMaskINTEL capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), out dataSize, noCounters, out noInstances, out capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<string> queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), out dataSize, out noCounters, noInstances, capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<string> queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] out PerformanceQueryCapsMaskINTEL capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), out dataSize, out noCounters, noInstances, out capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<string> queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] PerformanceQueryCapsMaskINTEL* capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), out dataSize, out noCounters, out noInstances, capsMask);
        }

        public unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<string> queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] out PerformanceQueryCapsMaskINTEL capsMask)
        {
            // ImplicitCountSpanOverloader
            GetPerfQueryInfo(queryId, (uint) queryName.Length, out queryName.GetPinnableReference(), out dataSize, out noCounters, out noInstances, out capsMask);
        }

        public unsafe uint CreatePerfQuery([Flow(FlowDirection.In)] uint queryId)
        {
            // NonKhrReturnTypeOverloader
            CreatePerfQuery(queryId, out uint silkRet);
            return silkRet;
        }

        public unsafe uint GetNextPerfQueryId([Flow(FlowDirection.In)] uint queryId)
        {
            // NonKhrReturnTypeOverloader
            GetNextPerfQueryId(queryId, out uint silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, out counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, out counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, out counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, out counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, out counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, out counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, out counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, out counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc, counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc, counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc, counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc, counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc, counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc, counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc, counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc, counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc, out counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc, out counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc, out counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc, out counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc, out counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc, out counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc, out counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc, out counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc, counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc, counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc, counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc, counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc, counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc, counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc, counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc, counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc, out counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc, out counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc, out counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc, out counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc, out counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc, out counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc, out counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDescLength, out counterDesc, out counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, counterDesc, counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, counterDesc, counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, counterDesc, counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, counterDesc, counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, counterDesc, counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, counterDesc, counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, counterDesc, counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, counterDesc, counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, counterDesc, out counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, counterDesc, out counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, counterDesc, out counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, counterDesc, out counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, counterDesc, out counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, counterDesc, out counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, counterDesc, out counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, counterDesc, out counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, out counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, out counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, out counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, out counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, out counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, out counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, out counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, out counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, out counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, out counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, out counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, out counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, out counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, out counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, out counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, out counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, counterDesc, counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, counterDesc, counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, counterDesc, counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, counterDesc, counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, counterDesc, counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, counterDesc, counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, counterDesc, counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, counterDesc, counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, counterDesc, out counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, counterDesc, out counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, counterDesc, out counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, counterDesc, out counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, counterDesc, out counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, counterDesc, out counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, counterDesc, out counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, counterDesc, out counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, out counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, out counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, out counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, out counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, out counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, out counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, out counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, out counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, out counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, out counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, out counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, out counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, out counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, out counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, out counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, out counterName, counterDescLength, out counterDesc, out counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe uint GetPerfQueryData([Flow(FlowDirection.In)] uint queryHandle, [Flow(FlowDirection.In)] uint flags, [Flow(FlowDirection.In)] uint dataSize, [Flow(FlowDirection.Out)] void* data)
        {
            // NonKhrReturnTypeOverloader
            GetPerfQueryData(queryHandle, flags, dataSize, data, out uint silkRet);
            return silkRet;
        }

        public unsafe uint GetPerfQueryIdByName([Flow(FlowDirection.Out)] out byte queryName)
        {
            // NonKhrReturnTypeOverloader
            GetPerfQueryIdByName(out queryName, out uint silkRet);
            return silkRet;
        }

        public unsafe uint GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances)
        {
            // NonKhrReturnTypeOverloader
            GetPerfQueryInfo(queryId, queryNameLength, queryName, dataSize, noCounters, noInstances, out uint silkRet);
            return silkRet;
        }

        public unsafe uint GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances)
        {
            // NonKhrReturnTypeOverloader
            GetPerfQueryInfo(queryId, queryNameLength, queryName, dataSize, noCounters, out noInstances, out uint silkRet);
            return silkRet;
        }

        public unsafe uint GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances)
        {
            // NonKhrReturnTypeOverloader
            GetPerfQueryInfo(queryId, queryNameLength, queryName, dataSize, out noCounters, noInstances, out uint silkRet);
            return silkRet;
        }

        public unsafe uint GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances)
        {
            // NonKhrReturnTypeOverloader
            GetPerfQueryInfo(queryId, queryNameLength, queryName, dataSize, out noCounters, out noInstances, out uint silkRet);
            return silkRet;
        }

        public unsafe uint GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances)
        {
            // NonKhrReturnTypeOverloader
            GetPerfQueryInfo(queryId, queryNameLength, queryName, out dataSize, noCounters, noInstances, out uint silkRet);
            return silkRet;
        }

        public unsafe uint GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances)
        {
            // NonKhrReturnTypeOverloader
            GetPerfQueryInfo(queryId, queryNameLength, queryName, out dataSize, noCounters, out noInstances, out uint silkRet);
            return silkRet;
        }

        public unsafe uint GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances)
        {
            // NonKhrReturnTypeOverloader
            GetPerfQueryInfo(queryId, queryNameLength, queryName, out dataSize, out noCounters, noInstances, out uint silkRet);
            return silkRet;
        }

        public unsafe uint GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances)
        {
            // NonKhrReturnTypeOverloader
            GetPerfQueryInfo(queryId, queryNameLength, queryName, out dataSize, out noCounters, out noInstances, out uint silkRet);
            return silkRet;
        }

        public unsafe uint GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances)
        {
            // NonKhrReturnTypeOverloader
            GetPerfQueryInfo(queryId, queryNameLength, out queryName, dataSize, noCounters, noInstances, out uint silkRet);
            return silkRet;
        }

        public unsafe uint GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances)
        {
            // NonKhrReturnTypeOverloader
            GetPerfQueryInfo(queryId, queryNameLength, out queryName, dataSize, noCounters, out noInstances, out uint silkRet);
            return silkRet;
        }

        public unsafe uint GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances)
        {
            // NonKhrReturnTypeOverloader
            GetPerfQueryInfo(queryId, queryNameLength, out queryName, dataSize, out noCounters, noInstances, out uint silkRet);
            return silkRet;
        }

        public unsafe uint GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances)
        {
            // NonKhrReturnTypeOverloader
            GetPerfQueryInfo(queryId, queryNameLength, out queryName, dataSize, out noCounters, out noInstances, out uint silkRet);
            return silkRet;
        }

        public unsafe uint GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances)
        {
            // NonKhrReturnTypeOverloader
            GetPerfQueryInfo(queryId, queryNameLength, out queryName, out dataSize, noCounters, noInstances, out uint silkRet);
            return silkRet;
        }

        public unsafe uint GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances)
        {
            // NonKhrReturnTypeOverloader
            GetPerfQueryInfo(queryId, queryNameLength, out queryName, out dataSize, noCounters, out noInstances, out uint silkRet);
            return silkRet;
        }

        public unsafe uint GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances)
        {
            // NonKhrReturnTypeOverloader
            GetPerfQueryInfo(queryId, queryNameLength, out queryName, out dataSize, out noCounters, noInstances, out uint silkRet);
            return silkRet;
        }

        public unsafe uint GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances)
        {
            // NonKhrReturnTypeOverloader
            GetPerfQueryInfo(queryId, queryNameLength, out queryName, out dataSize, out noCounters, out noInstances, out uint silkRet);
            return silkRet;
        }

        public unsafe uint GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances)
        {
            // NonKhrReturnTypeOverloader
            GetPerfQueryInfo(queryId, queryNameLength, out queryName, dataSize, noCounters, noInstances, out uint silkRet);
            return silkRet;
        }

        public unsafe uint GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances)
        {
            // NonKhrReturnTypeOverloader
            GetPerfQueryInfo(queryId, queryNameLength, out queryName, dataSize, noCounters, out noInstances, out uint silkRet);
            return silkRet;
        }

        public unsafe uint GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances)
        {
            // NonKhrReturnTypeOverloader
            GetPerfQueryInfo(queryId, queryNameLength, out queryName, dataSize, out noCounters, noInstances, out uint silkRet);
            return silkRet;
        }

        public unsafe uint GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances)
        {
            // NonKhrReturnTypeOverloader
            GetPerfQueryInfo(queryId, queryNameLength, out queryName, dataSize, out noCounters, out noInstances, out uint silkRet);
            return silkRet;
        }

        public unsafe uint GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances)
        {
            // NonKhrReturnTypeOverloader
            GetPerfQueryInfo(queryId, queryNameLength, out queryName, out dataSize, noCounters, noInstances, out uint silkRet);
            return silkRet;
        }

        public unsafe uint GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances)
        {
            // NonKhrReturnTypeOverloader
            GetPerfQueryInfo(queryId, queryNameLength, out queryName, out dataSize, noCounters, out noInstances, out uint silkRet);
            return silkRet;
        }

        public unsafe uint GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances)
        {
            // NonKhrReturnTypeOverloader
            GetPerfQueryInfo(queryId, queryNameLength, out queryName, out dataSize, out noCounters, noInstances, out uint silkRet);
            return silkRet;
        }

        public unsafe uint GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances)
        {
            // NonKhrReturnTypeOverloader
            GetPerfQueryInfo(queryId, queryNameLength, out queryName, out dataSize, out noCounters, out noInstances, out uint silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDesc, counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDesc, counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDesc, counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDesc, counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDesc, counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDesc, counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDesc, counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDesc, counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDesc, out counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDesc, out counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDesc, out counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDesc, out counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDesc, out counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDesc, out counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDesc, out counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDesc, out counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDesc, counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDesc, counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDesc, counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDesc, counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDesc, counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDesc, counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDesc, counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDesc, counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDesc, out counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDesc, out counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDesc, out counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDesc, out counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDesc, out counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDesc, out counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDesc, out counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] byte* counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterNameLength, counterName, counterDesc, out counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDescLength, counterDesc, counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDescLength, counterDesc, counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDescLength, counterDesc, counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDescLength, counterDesc, counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDescLength, counterDesc, counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDescLength, counterDesc, counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDescLength, counterDesc, counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDescLength, counterDesc, counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDescLength, counterDesc, out counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDescLength, counterDesc, out counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDescLength, counterDesc, out counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDescLength, counterDesc, out counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDescLength, counterDesc, out counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDescLength, counterDesc, out counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDescLength, counterDesc, out counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDescLength, counterDesc, out counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, out counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, out counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, out counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, out counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, out counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, out counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, out counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, out counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, out counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, out counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, out counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, out counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, out counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, out counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, out counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<byte> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, out counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDescLength, counterDesc, counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDescLength, counterDesc, counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDescLength, counterDesc, counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDescLength, counterDesc, counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDescLength, counterDesc, counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDescLength, counterDesc, counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDescLength, counterDesc, counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDescLength, counterDesc, counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDescLength, counterDesc, out counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDescLength, counterDesc, out counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDescLength, counterDesc, out counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDescLength, counterDesc, out counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDescLength, counterDesc, out counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDescLength, counterDesc, out counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDescLength, counterDesc, out counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDescLength, counterDesc, out counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, out counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, out counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, out counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, out counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, out counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, out counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, out counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<byte> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, out counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, out counterOffset, counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, out counterOffset, counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, out counterOffset, counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, out counterOffset, counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, out counterOffset, out counterDataSize, counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, out counterOffset, out counterDataSize, counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, out counterOffset, out counterDataSize, out counterTypeEnum, counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Count(Parameter = "counterNameLength"), Flow(FlowDirection.Out)] Span<string> counterName, [Count(Parameter = "counterDescLength"), Flow(FlowDirection.Out)] Span<string> counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum)
        {
            // NonKhrReturnTypeOverloader
            GetPerfCounterInfo(queryId, counterId, counterName, counterDesc, out counterOffset, out counterDataSize, out counterTypeEnum, out counterDataTypeEnum, out ulong silkRet);
            return silkRet;
        }

        public unsafe uint GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<byte> queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances)
        {
            // NonKhrReturnTypeOverloader
            GetPerfQueryInfo(queryId, queryName, dataSize, noCounters, noInstances, out uint silkRet);
            return silkRet;
        }

        public unsafe uint GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<byte> queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances)
        {
            // NonKhrReturnTypeOverloader
            GetPerfQueryInfo(queryId, queryName, dataSize, noCounters, out noInstances, out uint silkRet);
            return silkRet;
        }

        public unsafe uint GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<byte> queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances)
        {
            // NonKhrReturnTypeOverloader
            GetPerfQueryInfo(queryId, queryName, dataSize, out noCounters, noInstances, out uint silkRet);
            return silkRet;
        }

        public unsafe uint GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<byte> queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances)
        {
            // NonKhrReturnTypeOverloader
            GetPerfQueryInfo(queryId, queryName, dataSize, out noCounters, out noInstances, out uint silkRet);
            return silkRet;
        }

        public unsafe uint GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<byte> queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances)
        {
            // NonKhrReturnTypeOverloader
            GetPerfQueryInfo(queryId, queryName, out dataSize, noCounters, noInstances, out uint silkRet);
            return silkRet;
        }

        public unsafe uint GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<byte> queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances)
        {
            // NonKhrReturnTypeOverloader
            GetPerfQueryInfo(queryId, queryName, out dataSize, noCounters, out noInstances, out uint silkRet);
            return silkRet;
        }

        public unsafe uint GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<byte> queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances)
        {
            // NonKhrReturnTypeOverloader
            GetPerfQueryInfo(queryId, queryName, out dataSize, out noCounters, noInstances, out uint silkRet);
            return silkRet;
        }

        public unsafe uint GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<byte> queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances)
        {
            // NonKhrReturnTypeOverloader
            GetPerfQueryInfo(queryId, queryName, out dataSize, out noCounters, out noInstances, out uint silkRet);
            return silkRet;
        }

        public unsafe uint GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<string> queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances)
        {
            // NonKhrReturnTypeOverloader
            GetPerfQueryInfo(queryId, queryName, dataSize, noCounters, noInstances, out uint silkRet);
            return silkRet;
        }

        public unsafe uint GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<string> queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances)
        {
            // NonKhrReturnTypeOverloader
            GetPerfQueryInfo(queryId, queryName, dataSize, noCounters, out noInstances, out uint silkRet);
            return silkRet;
        }

        public unsafe uint GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<string> queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances)
        {
            // NonKhrReturnTypeOverloader
            GetPerfQueryInfo(queryId, queryName, dataSize, out noCounters, noInstances, out uint silkRet);
            return silkRet;
        }

        public unsafe uint GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<string> queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances)
        {
            // NonKhrReturnTypeOverloader
            GetPerfQueryInfo(queryId, queryName, dataSize, out noCounters, out noInstances, out uint silkRet);
            return silkRet;
        }

        public unsafe uint GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<string> queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances)
        {
            // NonKhrReturnTypeOverloader
            GetPerfQueryInfo(queryId, queryName, out dataSize, noCounters, noInstances, out uint silkRet);
            return silkRet;
        }

        public unsafe uint GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<string> queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances)
        {
            // NonKhrReturnTypeOverloader
            GetPerfQueryInfo(queryId, queryName, out dataSize, noCounters, out noInstances, out uint silkRet);
            return silkRet;
        }

        public unsafe uint GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<string> queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances)
        {
            // NonKhrReturnTypeOverloader
            GetPerfQueryInfo(queryId, queryName, out dataSize, out noCounters, noInstances, out uint silkRet);
            return silkRet;
        }

        public unsafe uint GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Count(Parameter = "queryNameLength"), Flow(FlowDirection.Out)] Span<string> queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances)
        {
            // NonKhrReturnTypeOverloader
            GetPerfQueryInfo(queryId, queryName, out dataSize, out noCounters, out noInstances, out uint silkRet);
            return silkRet;
        }

        public IntelPerformanceQuery(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

