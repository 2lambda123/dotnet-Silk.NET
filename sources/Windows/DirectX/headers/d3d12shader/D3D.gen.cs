// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12shader.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace TerraFX.Interop.DirectX;
public static partial class D3D
{
    [NativeTypeName("#define D3D_SHADER_REQUIRES_STENCIL_REF 0x00000200")]
    public const int D3D_SHADER_REQUIRES_STENCIL_REF = 0x00000200;
    [NativeTypeName("#define D3D_SHADER_REQUIRES_INNER_COVERAGE 0x00000400")]
    public const int D3D_SHADER_REQUIRES_INNER_COVERAGE = 0x00000400;
    [NativeTypeName("#define D3D_SHADER_REQUIRES_TYPED_UAV_LOAD_ADDITIONAL_FORMATS 0x00000800")]
    public const int D3D_SHADER_REQUIRES_TYPED_UAV_LOAD_ADDITIONAL_FORMATS = 0x00000800;
    [NativeTypeName("#define D3D_SHADER_REQUIRES_ROVS 0x00001000")]
    public const int D3D_SHADER_REQUIRES_ROVS = 0x00001000;
    [NativeTypeName("#define D3D_SHADER_REQUIRES_VIEWPORT_AND_RT_ARRAY_INDEX_FROM_ANY_SHADER_FEEDING_RASTERIZER 0x00002000")]
    public const int D3D_SHADER_REQUIRES_VIEWPORT_AND_RT_ARRAY_INDEX_FROM_ANY_SHADER_FEEDING_RASTERIZER = 0x00002000;
    [NativeTypeName("#define D3D_SHADER_REQUIRES_WAVE_OPS 0x00004000")]
    public const int D3D_SHADER_REQUIRES_WAVE_OPS = 0x00004000;
    [NativeTypeName("#define D3D_SHADER_REQUIRES_INT64_OPS 0x00008000")]
    public const int D3D_SHADER_REQUIRES_INT64_OPS = 0x00008000;
    [NativeTypeName("#define D3D_SHADER_REQUIRES_VIEW_ID 0x00010000")]
    public const int D3D_SHADER_REQUIRES_VIEW_ID = 0x00010000;
    [NativeTypeName("#define D3D_SHADER_REQUIRES_BARYCENTRICS 0x00020000")]
    public const int D3D_SHADER_REQUIRES_BARYCENTRICS = 0x00020000;
    [NativeTypeName("#define D3D_SHADER_REQUIRES_NATIVE_16BIT_OPS 0x00040000")]
    public const int D3D_SHADER_REQUIRES_NATIVE_16BIT_OPS = 0x00040000;
    [NativeTypeName("#define D3D_SHADER_REQUIRES_SHADING_RATE 0x00080000")]
    public const int D3D_SHADER_REQUIRES_SHADING_RATE = 0x00080000;
    [NativeTypeName("#define D3D_SHADER_REQUIRES_RAYTRACING_TIER_1_1 0x00100000")]
    public const int D3D_SHADER_REQUIRES_RAYTRACING_TIER_1_1 = 0x00100000;
    [NativeTypeName("#define D3D_SHADER_REQUIRES_SAMPLER_FEEDBACK 0x00200000")]
    public const int D3D_SHADER_REQUIRES_SAMPLER_FEEDBACK = 0x00200000;
    [NativeTypeName("#define D3D_SHADER_REQUIRES_ATOMIC_INT64_ON_TYPED_RESOURCE 0x00400000")]
    public const int D3D_SHADER_REQUIRES_ATOMIC_INT64_ON_TYPED_RESOURCE = 0x00400000;
    [NativeTypeName("#define D3D_SHADER_REQUIRES_ATOMIC_INT64_ON_GROUP_SHARED 0x00800000")]
    public const int D3D_SHADER_REQUIRES_ATOMIC_INT64_ON_GROUP_SHARED = 0x00800000;
    [NativeTypeName("#define D3D_SHADER_REQUIRES_DERIVATIVES_IN_MESH_AND_AMPLIFICATION_SHADERS 0x01000000")]
    public const int D3D_SHADER_REQUIRES_DERIVATIVES_IN_MESH_AND_AMPLIFICATION_SHADERS = 0x01000000;
    [NativeTypeName("#define D3D_SHADER_REQUIRES_RESOURCE_DESCRIPTOR_HEAP_INDEXING 0x02000000")]
    public const int D3D_SHADER_REQUIRES_RESOURCE_DESCRIPTOR_HEAP_INDEXING = 0x02000000;
    [NativeTypeName("#define D3D_SHADER_REQUIRES_SAMPLER_DESCRIPTOR_HEAP_INDEXING 0x04000000")]
    public const int D3D_SHADER_REQUIRES_SAMPLER_DESCRIPTOR_HEAP_INDEXING = 0x04000000;
    [NativeTypeName("#define D3D_SHADER_REQUIRES_WAVE_MMA 0x08000000")]
    public const int D3D_SHADER_REQUIRES_WAVE_MMA = 0x08000000;
    [NativeTypeName("#define D3D_SHADER_REQUIRES_ATOMIC_INT64_ON_DESCRIPTOR_HEAP_RESOURCE 0x10000000")]
    public const int D3D_SHADER_REQUIRES_ATOMIC_INT64_ON_DESCRIPTOR_HEAP_RESOURCE = 0x10000000;
}