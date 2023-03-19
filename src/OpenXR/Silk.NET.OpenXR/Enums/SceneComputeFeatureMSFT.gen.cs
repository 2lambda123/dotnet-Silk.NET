// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrSceneComputeFeatureMSFT")]
    public enum SceneComputeFeatureMSFT : int
    {
        [Obsolete("Deprecated in favour of \"PlaneMsft\"")]
        [NativeName("Name", "XR_SCENE_COMPUTE_FEATURE_PLANE_MSFT")]
        SceneComputeFeaturePlaneMsft = 1,
        [Obsolete("Deprecated in favour of \"PlaneMeshMsft\"")]
        [NativeName("Name", "XR_SCENE_COMPUTE_FEATURE_PLANE_MESH_MSFT")]
        SceneComputeFeaturePlaneMeshMsft = 2,
        [Obsolete("Deprecated in favour of \"VisualMeshMsft\"")]
        [NativeName("Name", "XR_SCENE_COMPUTE_FEATURE_VISUAL_MESH_MSFT")]
        SceneComputeFeatureVisualMeshMsft = 3,
        [Obsolete("Deprecated in favour of \"ColliderMeshMsft\"")]
        [NativeName("Name", "XR_SCENE_COMPUTE_FEATURE_COLLIDER_MESH_MSFT")]
        SceneComputeFeatureColliderMeshMsft = 4,
        [Obsolete("Deprecated in favour of \"SerializeSceneMsft\"")]
        [NativeName("Name", "XR_SCENE_COMPUTE_FEATURE_SERIALIZE_SCENE_MSFT")]
        SceneComputeFeatureSerializeSceneMsft = 1000098000,
        [NativeName("Name", "XR_SCENE_COMPUTE_FEATURE_PLANE_MSFT")]
        PlaneMsft = 1,
        [NativeName("Name", "XR_SCENE_COMPUTE_FEATURE_PLANE_MESH_MSFT")]
        PlaneMeshMsft = 2,
        [NativeName("Name", "XR_SCENE_COMPUTE_FEATURE_VISUAL_MESH_MSFT")]
        VisualMeshMsft = 3,
        [NativeName("Name", "XR_SCENE_COMPUTE_FEATURE_COLLIDER_MESH_MSFT")]
        ColliderMeshMsft = 4,
        [NativeName("Name", "XR_SCENE_COMPUTE_FEATURE_SERIALIZE_SCENE_MSFT")]
        SerializeSceneMsft = 1000098000,
    }
}
