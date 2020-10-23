// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkQueryPoolCreateInfo")]
    public unsafe partial struct QueryPoolCreateInfo
    {
        public QueryPoolCreateInfo
        (
            StructureType? sType = StructureType.QueryPoolCreateInfo,
            void* pNext = null,
            uint? flags = null,
            QueryType? queryType = null,
            uint? queryCount = null,
            QueryPipelineStatisticFlags? pipelineStatistics = null
        )
        {
            fixed (QueryPoolCreateInfo* @this = &this)
            {
                // all fields automatically initialized here
            }

            if (sType is not null)
            {
                SType = sType.Value;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (queryType is not null)
            {
                QueryType = queryType.Value;
            }

            if (queryCount is not null)
            {
                QueryCount = queryCount.Value;
            }

            if (pipelineStatistics is not null)
            {
                PipelineStatistics = pipelineStatistics.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkStructureType")]
        [NativeName("Type.Name", "VkStructureType")]
        [NativeName("Name", "sType")]
        public StructureType SType;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pNext")]
        public void* PNext;
/// <summary></summary>
        [NativeName("Type", "VkQueryPoolCreateFlags")]
        [NativeName("Type.Name", "VkQueryPoolCreateFlags")]
        [NativeName("Name", "flags")]
        public uint Flags;
/// <summary></summary>
        [NativeName("Type", "VkQueryType")]
        [NativeName("Type.Name", "VkQueryType")]
        [NativeName("Name", "queryType")]
        public QueryType QueryType;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "queryCount")]
        public uint QueryCount;
/// <summary></summary>
        [NativeName("Type", "VkQueryPipelineStatisticFlags")]
        [NativeName("Type.Name", "VkQueryPipelineStatisticFlags")]
        [NativeName("Name", "pipelineStatistics")]
        public QueryPipelineStatisticFlags PipelineStatistics;
    }
}
