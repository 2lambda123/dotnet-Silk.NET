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
using Silk.NET.OpenXR;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenXR.Extensions.MSFT;

[Extension("XR_MSFT_scene_understanding")]
public unsafe partial class MsftSceneUnderstanding : NativeExtension<XR>
{
    public const string ExtensionName = "XR_MSFT_scene_understanding";
    /// <summary>To be documented.</summary>
    [NativeApi(EntryPoint = "xrComputeNewSceneMSFT")]
    public unsafe partial Result ComputeNewSceneMsft([Count(Count = 0)] SceneObserverMSFT sceneObserver, [Count(Count = 0), Flow(FlowDirection.In)] NewSceneComputeInfoMSFT* computeInfo);

    /// <summary>To be documented.</summary>
    [NativeApi(EntryPoint = "xrComputeNewSceneMSFT")]
    public partial Result ComputeNewSceneMsft([Count(Count = 0)] SceneObserverMSFT sceneObserver, [Count(Count = 0), Flow(FlowDirection.In)] in NewSceneComputeInfoMSFT computeInfo);

    /// <summary>To be documented.</summary>
    [NativeApi(EntryPoint = "xrCreateSceneMSFT")]
    public unsafe partial Result CreateSceneMsft([Count(Count = 0)] SceneObserverMSFT sceneObserver, [Count(Count = 0), Flow(FlowDirection.In)] SceneCreateInfoMSFT* createInfo, [Count(Count = 0)] SceneMSFT* scene);

    /// <summary>To be documented.</summary>
    [NativeApi(EntryPoint = "xrCreateSceneMSFT")]
    public unsafe partial Result CreateSceneMsft([Count(Count = 0)] SceneObserverMSFT sceneObserver, [Count(Count = 0), Flow(FlowDirection.In)] SceneCreateInfoMSFT* createInfo, [Count(Count = 0)] ref SceneMSFT scene);

    /// <summary>To be documented.</summary>
    [NativeApi(EntryPoint = "xrCreateSceneMSFT")]
    public unsafe partial Result CreateSceneMsft([Count(Count = 0)] SceneObserverMSFT sceneObserver, [Count(Count = 0), Flow(FlowDirection.In)] in SceneCreateInfoMSFT createInfo, [Count(Count = 0)] SceneMSFT* scene);

    /// <summary>To be documented.</summary>
    [NativeApi(EntryPoint = "xrCreateSceneMSFT")]
    public partial Result CreateSceneMsft([Count(Count = 0)] SceneObserverMSFT sceneObserver, [Count(Count = 0), Flow(FlowDirection.In)] in SceneCreateInfoMSFT createInfo, [Count(Count = 0)] ref SceneMSFT scene);

    /// <summary>To be documented.</summary>
    [NativeApi(EntryPoint = "xrCreateSceneObserverMSFT")]
    public unsafe partial Result CreateSceneObserverMsft([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] SceneObserverCreateInfoMSFT* createInfo, [Count(Count = 0)] SceneObserverMSFT* sceneObserver);

    /// <summary>To be documented.</summary>
    [NativeApi(EntryPoint = "xrCreateSceneObserverMSFT")]
    public unsafe partial Result CreateSceneObserverMsft([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] SceneObserverCreateInfoMSFT* createInfo, [Count(Count = 0)] ref SceneObserverMSFT sceneObserver);

    /// <summary>To be documented.</summary>
    [NativeApi(EntryPoint = "xrCreateSceneObserverMSFT")]
    public unsafe partial Result CreateSceneObserverMsft([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] in SceneObserverCreateInfoMSFT createInfo, [Count(Count = 0)] SceneObserverMSFT* sceneObserver);

    /// <summary>To be documented.</summary>
    [NativeApi(EntryPoint = "xrCreateSceneObserverMSFT")]
    public partial Result CreateSceneObserverMsft([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] in SceneObserverCreateInfoMSFT createInfo, [Count(Count = 0)] ref SceneObserverMSFT sceneObserver);

    /// <summary>To be documented.</summary>
    [NativeApi(EntryPoint = "xrDestroySceneMSFT")]
    public partial Result DestroySceneMsft([Count(Count = 0)] SceneMSFT scene);

    /// <summary>To be documented.</summary>
    [NativeApi(EntryPoint = "xrDestroySceneObserverMSFT")]
    public partial Result DestroySceneObserverMsft([Count(Count = 0)] SceneObserverMSFT sceneObserver);

    /// <summary>To be documented.</summary>
    [NativeApi(EntryPoint = "xrEnumerateSceneComputeFeaturesMSFT")]
    public unsafe partial Result EnumerateSceneComputeFeaturesMsft([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint featureCapacityInput, [Count(Count = 0)] uint* featureCountOutput, [Count(Parameter = "featureCapacityInput")] SceneComputeFeatureMSFT* features);

    /// <summary>To be documented.</summary>
    [NativeApi(EntryPoint = "xrEnumerateSceneComputeFeaturesMSFT")]
    public unsafe partial Result EnumerateSceneComputeFeaturesMsft([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint featureCapacityInput, [Count(Count = 0)] uint* featureCountOutput, [Count(Parameter = "featureCapacityInput")] ref SceneComputeFeatureMSFT features);

    /// <summary>To be documented.</summary>
    [NativeApi(EntryPoint = "xrEnumerateSceneComputeFeaturesMSFT")]
    public unsafe partial Result EnumerateSceneComputeFeaturesMsft([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint featureCapacityInput, [Count(Count = 0)] ref uint featureCountOutput, [Count(Parameter = "featureCapacityInput")] SceneComputeFeatureMSFT* features);

    /// <summary>To be documented.</summary>
    [NativeApi(EntryPoint = "xrEnumerateSceneComputeFeaturesMSFT")]
    public partial Result EnumerateSceneComputeFeaturesMsft([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint featureCapacityInput, [Count(Count = 0)] ref uint featureCountOutput, [Count(Parameter = "featureCapacityInput")] ref SceneComputeFeatureMSFT features);

    /// <summary>To be documented.</summary>
    [NativeApi(EntryPoint = "xrGetSceneComponentsMSFT")]
    public unsafe partial Result GetSceneComponentsMsft([Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(FlowDirection.In)] SceneComponentsGetInfoMSFT* getInfo, [Count(Count = 0)] SceneComponentsMSFT* components);

    /// <summary>To be documented.</summary>
    [NativeApi(EntryPoint = "xrGetSceneComponentsMSFT")]
    public unsafe partial Result GetSceneComponentsMsft([Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(FlowDirection.In)] SceneComponentsGetInfoMSFT* getInfo, [Count(Count = 0)] ref SceneComponentsMSFT components);

    /// <summary>To be documented.</summary>
    [NativeApi(EntryPoint = "xrGetSceneComponentsMSFT")]
    public unsafe partial Result GetSceneComponentsMsft([Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(FlowDirection.In)] in SceneComponentsGetInfoMSFT getInfo, [Count(Count = 0)] SceneComponentsMSFT* components);

    /// <summary>To be documented.</summary>
    [NativeApi(EntryPoint = "xrGetSceneComponentsMSFT")]
    public partial Result GetSceneComponentsMsft([Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(FlowDirection.In)] in SceneComponentsGetInfoMSFT getInfo, [Count(Count = 0)] ref SceneComponentsMSFT components);

    /// <summary>To be documented.</summary>
    [NativeApi(EntryPoint = "xrGetSceneComputeStateMSFT")]
    public unsafe partial Result GetSceneComputeStateMsft([Count(Count = 0)] SceneObserverMSFT sceneObserver, [Count(Count = 0)] SceneComputeStateMSFT* state);

    /// <summary>To be documented.</summary>
    [NativeApi(EntryPoint = "xrGetSceneComputeStateMSFT")]
    public partial Result GetSceneComputeStateMsft([Count(Count = 0)] SceneObserverMSFT sceneObserver, [Count(Count = 0)] ref SceneComputeStateMSFT state);

    /// <summary>To be documented.</summary>
    [NativeApi(EntryPoint = "xrGetSceneMeshBuffersMSFT")]
    public unsafe partial Result GetSceneMeshBuffersMsft([Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(FlowDirection.In)] SceneMeshBuffersGetInfoMSFT* getInfo, [Count(Count = 0)] SceneMeshBuffersMSFT* buffers);

    /// <summary>To be documented.</summary>
    [NativeApi(EntryPoint = "xrGetSceneMeshBuffersMSFT")]
    public unsafe partial Result GetSceneMeshBuffersMsft([Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(FlowDirection.In)] SceneMeshBuffersGetInfoMSFT* getInfo, [Count(Count = 0)] ref SceneMeshBuffersMSFT buffers);

    /// <summary>To be documented.</summary>
    [NativeApi(EntryPoint = "xrGetSceneMeshBuffersMSFT")]
    public unsafe partial Result GetSceneMeshBuffersMsft([Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(FlowDirection.In)] in SceneMeshBuffersGetInfoMSFT getInfo, [Count(Count = 0)] SceneMeshBuffersMSFT* buffers);

    /// <summary>To be documented.</summary>
    [NativeApi(EntryPoint = "xrGetSceneMeshBuffersMSFT")]
    public partial Result GetSceneMeshBuffersMsft([Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(FlowDirection.In)] in SceneMeshBuffersGetInfoMSFT getInfo, [Count(Count = 0)] ref SceneMeshBuffersMSFT buffers);

    /// <summary>To be documented.</summary>
    [NativeApi(EntryPoint = "xrLocateSceneComponentsMSFT")]
    public unsafe partial Result LocateSceneComponentsMsft([Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(FlowDirection.In)] SceneComponentsLocateInfoMSFT* locateInfo, [Count(Count = 0)] SceneComponentLocationsMSFT* locations);

    /// <summary>To be documented.</summary>
    [NativeApi(EntryPoint = "xrLocateSceneComponentsMSFT")]
    public unsafe partial Result LocateSceneComponentsMsft([Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(FlowDirection.In)] SceneComponentsLocateInfoMSFT* locateInfo, [Count(Count = 0)] ref SceneComponentLocationsMSFT locations);

    /// <summary>To be documented.</summary>
    [NativeApi(EntryPoint = "xrLocateSceneComponentsMSFT")]
    public unsafe partial Result LocateSceneComponentsMsft([Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(FlowDirection.In)] in SceneComponentsLocateInfoMSFT locateInfo, [Count(Count = 0)] SceneComponentLocationsMSFT* locations);

    /// <summary>To be documented.</summary>
    [NativeApi(EntryPoint = "xrLocateSceneComponentsMSFT")]
    public partial Result LocateSceneComponentsMsft([Count(Count = 0)] SceneMSFT scene, [Count(Count = 0), Flow(FlowDirection.In)] in SceneComponentsLocateInfoMSFT locateInfo, [Count(Count = 0)] ref SceneComponentLocationsMSFT locations);

    /// <summary>To be documented.</summary>
    public unsafe Result EnumerateSceneComputeFeaturesMsft([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint* featureCountOutput, [Count(Parameter = "featureCapacityInput")] Span<SceneComputeFeatureMSFT> features)
    {
        // ImplicitCountSpanOverloader
        return EnumerateSceneComputeFeaturesMsft(instance, systemId, (uint) features.Length, featureCountOutput, ref features.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public unsafe Result EnumerateSceneComputeFeaturesMsft([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ref uint featureCountOutput, [Count(Parameter = "featureCapacityInput")] Span<SceneComputeFeatureMSFT> features)
    {
        // ImplicitCountSpanOverloader
        return EnumerateSceneComputeFeaturesMsft(instance, systemId, (uint) features.Length, ref featureCountOutput, ref features.GetPinnableReference());
    }

    public MsftSceneUnderstanding(INativeContext ctx)
        : base(ctx)
    {
    }
}

