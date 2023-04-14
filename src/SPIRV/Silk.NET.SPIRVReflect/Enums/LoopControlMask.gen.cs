// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRVReflect
{
    [Flags]
    [NativeName("Name", "SpvLoopControlMask_")]
    public enum LoopControlMask : int
    {
        [NativeName("Name", "SpvLoopControlMaskNone")]
        MaskNone = 0x0,
        [NativeName("Name", "SpvLoopControlUnrollMask")]
        UnrollMask = 0x1,
        [NativeName("Name", "SpvLoopControlDontUnrollMask")]
        DontUnrollMask = 0x2,
        [NativeName("Name", "SpvLoopControlDependencyInfiniteMask")]
        DependencyInfiniteMask = 0x4,
        [NativeName("Name", "SpvLoopControlDependencyLengthMask")]
        DependencyLengthMask = 0x8,
        [NativeName("Name", "SpvLoopControlMinIterationsMask")]
        MinIterationsMask = 0x10,
        [NativeName("Name", "SpvLoopControlMaxIterationsMask")]
        MaxIterationsMask = 0x20,
        [NativeName("Name", "SpvLoopControlIterationMultipleMask")]
        IterationMultipleMask = 0x40,
        [NativeName("Name", "SpvLoopControlPeelCountMask")]
        PeelCountMask = 0x80,
        [NativeName("Name", "SpvLoopControlPartialCountMask")]
        PartialCountMask = 0x100,
        [NativeName("Name", "SpvLoopControlInitiationIntervalINTELMask")]
        InitiationIntervalIntelmask = 0x10000,
        [NativeName("Name", "SpvLoopControlMaxConcurrencyINTELMask")]
        MaxConcurrencyIntelmask = 0x20000,
        [NativeName("Name", "SpvLoopControlDependencyArrayINTELMask")]
        DependencyArrayIntelmask = 0x40000,
        [NativeName("Name", "SpvLoopControlPipelineEnableINTELMask")]
        PipelineEnableIntelmask = 0x80000,
        [NativeName("Name", "SpvLoopControlLoopCoalesceINTELMask")]
        LoopCoalesceIntelmask = 0x100000,
        [NativeName("Name", "SpvLoopControlMaxInterleavingINTELMask")]
        MaxInterleavingIntelmask = 0x200000,
        [NativeName("Name", "SpvLoopControlSpeculatedIterationsINTELMask")]
        SpeculatedIterationsIntelmask = 0x400000,
        [NativeName("Name", "SpvLoopControlNoFusionINTELMask")]
        NoFusionIntelmask = 0x800000,
    }
}
