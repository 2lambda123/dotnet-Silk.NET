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
using Silk.NET.OpenCL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.EXT
{
    [Extension("EXT_migrate_memobject")]
    public unsafe partial class ExtMigrateMemobject : NativeExtension<CL>
    {
        public const string ExtensionName = "EXT_migrate_memobject";
        [NativeApi(EntryPoint = "clEnqueueMigrateMemObjectEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMigrateMemObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemMigrationFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        public ExtMigrateMemobject(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

