// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkExternalSemaphoreFeatureFlagsKHR")]
    public enum ExternalSemaphoreFeatureFlagsKHR : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"ExportableBit\"")]
        [NativeName("Name", "VK_EXTERNAL_SEMAPHORE_FEATURE_EXPORTABLE_BIT")]
        ExternalSemaphoreFeatureExportableBit = 1,
        [Obsolete("Deprecated in favour of \"ImportableBit\"")]
        [NativeName("Name", "VK_EXTERNAL_SEMAPHORE_FEATURE_IMPORTABLE_BIT")]
        ExternalSemaphoreFeatureImportableBit = 2,
        [NativeName("Name", "VK_EXTERNAL_SEMAPHORE_FEATURE_EXPORTABLE_BIT")]
        ExportableBit = 1,
        [NativeName("Name", "VK_EXTERNAL_SEMAPHORE_FEATURE_IMPORTABLE_BIT")]
        ImportableBit = 2,
    }
}
