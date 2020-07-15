// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "PointParameterNameSGIS")]
    public enum PointParameterNameSGIS
    {
        [NativeName("Name", "GL_POINT_SIZE_MIN")]
        PointSizeMin = 0x8126,
        [NativeName("Name", "GL_POINT_SIZE_MIN_ARB")]
        PointSizeMinArb = 0x8126,
        [NativeName("Name", "GL_POINT_SIZE_MIN_EXT")]
        PointSizeMinExt = 0x8126,
        [NativeName("Name", "GL_POINT_SIZE_MIN_SGIS")]
        PointSizeMinSgis = 0x8126,
        [NativeName("Name", "GL_POINT_SIZE_MAX")]
        PointSizeMax = 0x8127,
        [NativeName("Name", "GL_POINT_SIZE_MAX_ARB")]
        PointSizeMaxArb = 0x8127,
        [NativeName("Name", "GL_POINT_SIZE_MAX_EXT")]
        PointSizeMaxExt = 0x8127,
        [NativeName("Name", "GL_POINT_SIZE_MAX_SGIS")]
        PointSizeMaxSgis = 0x8127,
        [NativeName("Name", "GL_POINT_FADE_THRESHOLD_SIZE")]
        PointFadeThresholdSize = 0x8128,
        [NativeName("Name", "GL_POINT_FADE_THRESHOLD_SIZE_ARB")]
        PointFadeThresholdSizeArb = 0x8128,
        [NativeName("Name", "GL_POINT_FADE_THRESHOLD_SIZE_EXT")]
        PointFadeThresholdSizeExt = 0x8128,
        [NativeName("Name", "GL_POINT_FADE_THRESHOLD_SIZE_SGIS")]
        PointFadeThresholdSizeSgis = 0x8128,
        [NativeName("Name", "GL_DISTANCE_ATTENUATION_EXT")]
        DistanceAttenuationExt = 0x8129,
        [NativeName("Name", "GL_DISTANCE_ATTENUATION_SGIS")]
        DistanceAttenuationSgis = 0x8129,
        [NativeName("Name", "GL_POINT_DISTANCE_ATTENUATION")]
        PointDistanceAttenuation = 0x8129,
        [NativeName("Name", "GL_POINT_DISTANCE_ATTENUATION_ARB")]
        PointDistanceAttenuationArb = 0x8129,
    }
}
