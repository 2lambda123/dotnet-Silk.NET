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
using Silk.NET.OpenGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_multi_bind")]
    public unsafe partial class ArbMultiBind : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_multi_bind";
        [NativeApi(EntryPoint = "glBindBuffersBase")]
        public unsafe partial void BindBuffersBase([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers);

        [NativeApi(EntryPoint = "glBindBuffersBase")]
        public partial void BindBuffersBase([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint buffers);

        [NativeApi(EntryPoint = "glBindBuffersBase")]
        public unsafe partial void BindBuffersBase([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Buffer* buffers);

        [NativeApi(EntryPoint = "glBindBuffersBase")]
        public partial void BindBuffersBase([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in Buffer buffers);

        [NativeApi(EntryPoint = "glBindBuffersBase")]
        public unsafe partial void BindBuffersBase([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers);

        [NativeApi(EntryPoint = "glBindBuffersBase")]
        public partial void BindBuffersBase([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint buffers);

        [NativeApi(EntryPoint = "glBindBuffersBase")]
        public unsafe partial void BindBuffersBase([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Buffer* buffers);

        [NativeApi(EntryPoint = "glBindBuffersBase")]
        public partial void BindBuffersBase([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in Buffer buffers);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public unsafe partial void BindBuffersRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] nuint* sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public unsafe partial void BindBuffersRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nuint sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public unsafe partial void BindBuffersRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nint offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] nuint* sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public unsafe partial void BindBuffersRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nint offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nuint sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public unsafe partial void BindBuffersRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] nuint* sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public unsafe partial void BindBuffersRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nuint sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public unsafe partial void BindBuffersRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nint offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] nuint* sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public partial void BindBuffersRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nint offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nuint sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public unsafe partial void BindBuffersRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] nuint* sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public unsafe partial void BindBuffersRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nuint sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public unsafe partial void BindBuffersRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nint offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] nuint* sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public unsafe partial void BindBuffersRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nint offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nuint sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public unsafe partial void BindBuffersRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in Buffer buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] nuint* sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public unsafe partial void BindBuffersRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in Buffer buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nuint sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public unsafe partial void BindBuffersRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in Buffer buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nint offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] nuint* sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public partial void BindBuffersRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in Buffer buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nint offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nuint sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public unsafe partial void BindBuffersRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] nuint* sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public unsafe partial void BindBuffersRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nuint sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public unsafe partial void BindBuffersRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nint offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] nuint* sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public unsafe partial void BindBuffersRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nint offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nuint sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public unsafe partial void BindBuffersRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] nuint* sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public unsafe partial void BindBuffersRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nuint sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public unsafe partial void BindBuffersRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nint offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] nuint* sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public partial void BindBuffersRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nint offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nuint sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public unsafe partial void BindBuffersRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] nuint* sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public unsafe partial void BindBuffersRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nuint sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public unsafe partial void BindBuffersRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nint offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] nuint* sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public unsafe partial void BindBuffersRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nint offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nuint sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public unsafe partial void BindBuffersRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in Buffer buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] nuint* sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public unsafe partial void BindBuffersRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in Buffer buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nuint sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public unsafe partial void BindBuffersRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in Buffer buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nint offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] nuint* sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public partial void BindBuffersRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in Buffer buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nint offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nuint sizes);

        [NativeApi(EntryPoint = "glBindImageTextures")]
        public unsafe partial void BindImageTextures([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* textures);

        [NativeApi(EntryPoint = "glBindImageTextures")]
        public partial void BindImageTextures([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint textures);

        [NativeApi(EntryPoint = "glBindImageTextures")]
        public unsafe partial void BindImageTextures([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Texture* textures);

        [NativeApi(EntryPoint = "glBindImageTextures")]
        public partial void BindImageTextures([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in Texture textures);

        [NativeApi(EntryPoint = "glBindSamplers")]
        public unsafe partial void BindSamplers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* samplers);

        [NativeApi(EntryPoint = "glBindSamplers")]
        public partial void BindSamplers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint samplers);

        [NativeApi(EntryPoint = "glBindSamplers")]
        public unsafe partial void BindSamplers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Sampler* samplers);

        [NativeApi(EntryPoint = "glBindSamplers")]
        public partial void BindSamplers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in Sampler samplers);

        [NativeApi(EntryPoint = "glBindTextures")]
        public unsafe partial void BindTextures([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* textures);

        [NativeApi(EntryPoint = "glBindTextures")]
        public partial void BindTextures([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint textures);

        [NativeApi(EntryPoint = "glBindTextures")]
        public unsafe partial void BindTextures([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Texture* textures);

        [NativeApi(EntryPoint = "glBindTextures")]
        public partial void BindTextures([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in Texture textures);

        [NativeApi(EntryPoint = "glBindVertexBuffers")]
        public unsafe partial void BindVertexBuffers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* strides);

        [NativeApi(EntryPoint = "glBindVertexBuffers")]
        public unsafe partial void BindVertexBuffers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint strides);

        [NativeApi(EntryPoint = "glBindVertexBuffers")]
        public unsafe partial void BindVertexBuffers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nint offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* strides);

        [NativeApi(EntryPoint = "glBindVertexBuffers")]
        public unsafe partial void BindVertexBuffers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nint offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint strides);

        [NativeApi(EntryPoint = "glBindVertexBuffers")]
        public unsafe partial void BindVertexBuffers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* strides);

        [NativeApi(EntryPoint = "glBindVertexBuffers")]
        public unsafe partial void BindVertexBuffers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint strides);

        [NativeApi(EntryPoint = "glBindVertexBuffers")]
        public unsafe partial void BindVertexBuffers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nint offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* strides);

        [NativeApi(EntryPoint = "glBindVertexBuffers")]
        public partial void BindVertexBuffers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nint offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint strides);

        [NativeApi(EntryPoint = "glBindVertexBuffers")]
        public unsafe partial void BindVertexBuffers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* strides);

        [NativeApi(EntryPoint = "glBindVertexBuffers")]
        public unsafe partial void BindVertexBuffers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint strides);

        [NativeApi(EntryPoint = "glBindVertexBuffers")]
        public unsafe partial void BindVertexBuffers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nint offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* strides);

        [NativeApi(EntryPoint = "glBindVertexBuffers")]
        public unsafe partial void BindVertexBuffers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nint offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint strides);

        [NativeApi(EntryPoint = "glBindVertexBuffers")]
        public unsafe partial void BindVertexBuffers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in Buffer buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* strides);

        [NativeApi(EntryPoint = "glBindVertexBuffers")]
        public unsafe partial void BindVertexBuffers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in Buffer buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint strides);

        [NativeApi(EntryPoint = "glBindVertexBuffers")]
        public unsafe partial void BindVertexBuffers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in Buffer buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nint offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* strides);

        [NativeApi(EntryPoint = "glBindVertexBuffers")]
        public partial void BindVertexBuffers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in Buffer buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] in nint offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint strides);

        public unsafe void BindBuffersBase([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> buffers)
        {
            // ImplicitCountSpanOverloader
            BindBuffersBase(target, first, (uint) buffers.Length, in buffers.GetPinnableReference());
        }

        public unsafe void BindBuffersBase([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<Buffer> buffers)
        {
            // ImplicitCountSpanOverloader
            BindBuffersBase(target, first, (uint) buffers.Length, in buffers.GetPinnableReference());
        }

        public unsafe void BindBuffersBase([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> buffers)
        {
            // ImplicitCountSpanOverloader
            BindBuffersBase(target, first, (uint) buffers.Length, in buffers.GetPinnableReference());
        }

        public unsafe void BindBuffersBase([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<Buffer> buffers)
        {
            // ImplicitCountSpanOverloader
            BindBuffersBase(target, first, (uint) buffers.Length, in buffers.GetPinnableReference());
        }

        public unsafe void BindBuffersRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<nuint> sizes)
        {
            // ImplicitCountSpanOverloader
            BindBuffersRange(target, first, (uint) sizes.Length, buffers, offsets, in sizes.GetPinnableReference());
        }

        public unsafe void BindBuffersRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] nuint* sizes)
        {
            // ImplicitCountSpanOverloader
            BindBuffersRange(target, first, (uint) offsets.Length, buffers, in offsets.GetPinnableReference(), sizes);
        }

        public unsafe void BindBuffersRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<nuint> sizes)
        {
            // ImplicitCountSpanOverloader
            BindBuffersRange(target, first, (uint) sizes.Length, buffers, in offsets.GetPinnableReference(), in sizes.GetPinnableReference());
        }

        public unsafe void BindBuffersRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] nuint* sizes)
        {
            // ImplicitCountSpanOverloader
            BindBuffersRange(target, first, (uint) buffers.Length, in buffers.GetPinnableReference(), offsets, sizes);
        }

        public unsafe void BindBuffersRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<nuint> sizes)
        {
            // ImplicitCountSpanOverloader
            BindBuffersRange(target, first, (uint) sizes.Length, in buffers.GetPinnableReference(), offsets, in sizes.GetPinnableReference());
        }

        public unsafe void BindBuffersRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] nuint* sizes)
        {
            // ImplicitCountSpanOverloader
            BindBuffersRange(target, first, (uint) offsets.Length, in buffers.GetPinnableReference(), in offsets.GetPinnableReference(), sizes);
        }

        public unsafe void BindBuffersRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<nuint> sizes)
        {
            // ImplicitCountSpanOverloader
            BindBuffersRange(target, first, (uint) sizes.Length, in buffers.GetPinnableReference(), in offsets.GetPinnableReference(), in sizes.GetPinnableReference());
        }

        public unsafe void BindBuffersRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<nuint> sizes)
        {
            // ImplicitCountSpanOverloader
            BindBuffersRange(target, first, (uint) sizes.Length, buffers, offsets, in sizes.GetPinnableReference());
        }

        public unsafe void BindBuffersRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] nuint* sizes)
        {
            // ImplicitCountSpanOverloader
            BindBuffersRange(target, first, (uint) offsets.Length, buffers, in offsets.GetPinnableReference(), sizes);
        }

        public unsafe void BindBuffersRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<nuint> sizes)
        {
            // ImplicitCountSpanOverloader
            BindBuffersRange(target, first, (uint) sizes.Length, buffers, in offsets.GetPinnableReference(), in sizes.GetPinnableReference());
        }

        public unsafe void BindBuffersRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] nuint* sizes)
        {
            // ImplicitCountSpanOverloader
            BindBuffersRange(target, first, (uint) buffers.Length, in buffers.GetPinnableReference(), offsets, sizes);
        }

        public unsafe void BindBuffersRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<nuint> sizes)
        {
            // ImplicitCountSpanOverloader
            BindBuffersRange(target, first, (uint) sizes.Length, in buffers.GetPinnableReference(), offsets, in sizes.GetPinnableReference());
        }

        public unsafe void BindBuffersRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] nuint* sizes)
        {
            // ImplicitCountSpanOverloader
            BindBuffersRange(target, first, (uint) offsets.Length, in buffers.GetPinnableReference(), in offsets.GetPinnableReference(), sizes);
        }

        public unsafe void BindBuffersRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<nuint> sizes)
        {
            // ImplicitCountSpanOverloader
            BindBuffersRange(target, first, (uint) sizes.Length, in buffers.GetPinnableReference(), in offsets.GetPinnableReference(), in sizes.GetPinnableReference());
        }

        public unsafe void BindBuffersRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<nuint> sizes)
        {
            // ImplicitCountSpanOverloader
            BindBuffersRange(target, first, (uint) sizes.Length, buffers, offsets, in sizes.GetPinnableReference());
        }

        public unsafe void BindBuffersRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] nuint* sizes)
        {
            // ImplicitCountSpanOverloader
            BindBuffersRange(target, first, (uint) offsets.Length, buffers, in offsets.GetPinnableReference(), sizes);
        }

        public unsafe void BindBuffersRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<nuint> sizes)
        {
            // ImplicitCountSpanOverloader
            BindBuffersRange(target, first, (uint) sizes.Length, buffers, in offsets.GetPinnableReference(), in sizes.GetPinnableReference());
        }

        public unsafe void BindBuffersRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] nuint* sizes)
        {
            // ImplicitCountSpanOverloader
            BindBuffersRange(target, first, (uint) buffers.Length, in buffers.GetPinnableReference(), offsets, sizes);
        }

        public unsafe void BindBuffersRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<nuint> sizes)
        {
            // ImplicitCountSpanOverloader
            BindBuffersRange(target, first, (uint) sizes.Length, in buffers.GetPinnableReference(), offsets, in sizes.GetPinnableReference());
        }

        public unsafe void BindBuffersRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] nuint* sizes)
        {
            // ImplicitCountSpanOverloader
            BindBuffersRange(target, first, (uint) offsets.Length, in buffers.GetPinnableReference(), in offsets.GetPinnableReference(), sizes);
        }

        public unsafe void BindBuffersRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<nuint> sizes)
        {
            // ImplicitCountSpanOverloader
            BindBuffersRange(target, first, (uint) sizes.Length, in buffers.GetPinnableReference(), in offsets.GetPinnableReference(), in sizes.GetPinnableReference());
        }

        public unsafe void BindBuffersRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<nuint> sizes)
        {
            // ImplicitCountSpanOverloader
            BindBuffersRange(target, first, (uint) sizes.Length, buffers, offsets, in sizes.GetPinnableReference());
        }

        public unsafe void BindBuffersRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] nuint* sizes)
        {
            // ImplicitCountSpanOverloader
            BindBuffersRange(target, first, (uint) offsets.Length, buffers, in offsets.GetPinnableReference(), sizes);
        }

        public unsafe void BindBuffersRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<nuint> sizes)
        {
            // ImplicitCountSpanOverloader
            BindBuffersRange(target, first, (uint) sizes.Length, buffers, in offsets.GetPinnableReference(), in sizes.GetPinnableReference());
        }

        public unsafe void BindBuffersRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] nuint* sizes)
        {
            // ImplicitCountSpanOverloader
            BindBuffersRange(target, first, (uint) buffers.Length, in buffers.GetPinnableReference(), offsets, sizes);
        }

        public unsafe void BindBuffersRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<nuint> sizes)
        {
            // ImplicitCountSpanOverloader
            BindBuffersRange(target, first, (uint) sizes.Length, in buffers.GetPinnableReference(), offsets, in sizes.GetPinnableReference());
        }

        public unsafe void BindBuffersRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] nuint* sizes)
        {
            // ImplicitCountSpanOverloader
            BindBuffersRange(target, first, (uint) offsets.Length, in buffers.GetPinnableReference(), in offsets.GetPinnableReference(), sizes);
        }

        public unsafe void BindBuffersRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<nuint> sizes)
        {
            // ImplicitCountSpanOverloader
            BindBuffersRange(target, first, (uint) sizes.Length, in buffers.GetPinnableReference(), in offsets.GetPinnableReference(), in sizes.GetPinnableReference());
        }

        public unsafe void BindImageTextures([Flow(FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> textures)
        {
            // ImplicitCountSpanOverloader
            BindImageTextures(first, (uint) textures.Length, in textures.GetPinnableReference());
        }

        public unsafe void BindImageTextures([Flow(FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<Texture> textures)
        {
            // ImplicitCountSpanOverloader
            BindImageTextures(first, (uint) textures.Length, in textures.GetPinnableReference());
        }

        public unsafe void BindSamplers([Flow(FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> samplers)
        {
            // ImplicitCountSpanOverloader
            BindSamplers(first, (uint) samplers.Length, in samplers.GetPinnableReference());
        }

        public unsafe void BindSamplers([Flow(FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<Sampler> samplers)
        {
            // ImplicitCountSpanOverloader
            BindSamplers(first, (uint) samplers.Length, in samplers.GetPinnableReference());
        }

        public unsafe void BindTextures([Flow(FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> textures)
        {
            // ImplicitCountSpanOverloader
            BindTextures(first, (uint) textures.Length, in textures.GetPinnableReference());
        }

        public unsafe void BindTextures([Flow(FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<Texture> textures)
        {
            // ImplicitCountSpanOverloader
            BindTextures(first, (uint) textures.Length, in textures.GetPinnableReference());
        }

        public unsafe void BindVertexBuffers([Flow(FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> strides)
        {
            // ImplicitCountSpanOverloader
            BindVertexBuffers(first, (uint) strides.Length, buffers, offsets, in strides.GetPinnableReference());
        }

        public unsafe void BindVertexBuffers([Flow(FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* strides)
        {
            // ImplicitCountSpanOverloader
            BindVertexBuffers(first, (uint) offsets.Length, buffers, in offsets.GetPinnableReference(), strides);
        }

        public unsafe void BindVertexBuffers([Flow(FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> strides)
        {
            // ImplicitCountSpanOverloader
            BindVertexBuffers(first, (uint) strides.Length, buffers, in offsets.GetPinnableReference(), in strides.GetPinnableReference());
        }

        public unsafe void BindVertexBuffers([Flow(FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* strides)
        {
            // ImplicitCountSpanOverloader
            BindVertexBuffers(first, (uint) buffers.Length, in buffers.GetPinnableReference(), offsets, strides);
        }

        public unsafe void BindVertexBuffers([Flow(FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> strides)
        {
            // ImplicitCountSpanOverloader
            BindVertexBuffers(first, (uint) strides.Length, in buffers.GetPinnableReference(), offsets, in strides.GetPinnableReference());
        }

        public unsafe void BindVertexBuffers([Flow(FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* strides)
        {
            // ImplicitCountSpanOverloader
            BindVertexBuffers(first, (uint) offsets.Length, in buffers.GetPinnableReference(), in offsets.GetPinnableReference(), strides);
        }

        public unsafe void BindVertexBuffers([Flow(FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> strides)
        {
            // ImplicitCountSpanOverloader
            BindVertexBuffers(first, (uint) strides.Length, in buffers.GetPinnableReference(), in offsets.GetPinnableReference(), in strides.GetPinnableReference());
        }

        public unsafe void BindVertexBuffers([Flow(FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> strides)
        {
            // ImplicitCountSpanOverloader
            BindVertexBuffers(first, (uint) strides.Length, buffers, offsets, in strides.GetPinnableReference());
        }

        public unsafe void BindVertexBuffers([Flow(FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* strides)
        {
            // ImplicitCountSpanOverloader
            BindVertexBuffers(first, (uint) offsets.Length, buffers, in offsets.GetPinnableReference(), strides);
        }

        public unsafe void BindVertexBuffers([Flow(FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> strides)
        {
            // ImplicitCountSpanOverloader
            BindVertexBuffers(first, (uint) strides.Length, buffers, in offsets.GetPinnableReference(), in strides.GetPinnableReference());
        }

        public unsafe void BindVertexBuffers([Flow(FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* strides)
        {
            // ImplicitCountSpanOverloader
            BindVertexBuffers(first, (uint) buffers.Length, in buffers.GetPinnableReference(), offsets, strides);
        }

        public unsafe void BindVertexBuffers([Flow(FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> strides)
        {
            // ImplicitCountSpanOverloader
            BindVertexBuffers(first, (uint) strides.Length, in buffers.GetPinnableReference(), offsets, in strides.GetPinnableReference());
        }

        public unsafe void BindVertexBuffers([Flow(FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* strides)
        {
            // ImplicitCountSpanOverloader
            BindVertexBuffers(first, (uint) offsets.Length, in buffers.GetPinnableReference(), in offsets.GetPinnableReference(), strides);
        }

        public unsafe void BindVertexBuffers([Flow(FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> strides)
        {
            // ImplicitCountSpanOverloader
            BindVertexBuffers(first, (uint) strides.Length, in buffers.GetPinnableReference(), in offsets.GetPinnableReference(), in strides.GetPinnableReference());
        }

        public ArbMultiBind(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

