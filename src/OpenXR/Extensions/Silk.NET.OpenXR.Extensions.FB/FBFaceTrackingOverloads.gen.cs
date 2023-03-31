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

#pragma warning disable 1591

namespace Silk.NET.OpenXR.Extensions.FB
{
    public static class FBFaceTrackingOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result CreateFaceTrackerFB(this FBFaceTracking thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FaceTrackerCreateInfoFB* createInfo, [Count(Count = 0)] Span<FaceTrackerFB> faceTracker)
        {
            // SpanOverloader
            return thisApi.CreateFaceTrackerFB(session, createInfo, ref faceTracker.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateFaceTrackerFB(this FBFaceTracking thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FaceTrackerCreateInfoFB> createInfo, [Count(Count = 0)] FaceTrackerFB* faceTracker)
        {
            // SpanOverloader
            return thisApi.CreateFaceTrackerFB(session, in createInfo.GetPinnableReference(), faceTracker);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateFaceTrackerFB(this FBFaceTracking thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FaceTrackerCreateInfoFB> createInfo, [Count(Count = 0)] Span<FaceTrackerFB> faceTracker)
        {
            // SpanOverloader
            return thisApi.CreateFaceTrackerFB(session, in createInfo.GetPinnableReference(), ref faceTracker.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetFaceExpressionWeightsFB(this FBFaceTracking thisApi, [Count(Count = 0)] FaceTrackerFB faceTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FaceExpressionInfoFB* expressionInfo, [Count(Count = 0)] Span<FaceExpressionWeightsFB> expressionWeights)
        {
            // SpanOverloader
            return thisApi.GetFaceExpressionWeightsFB(faceTracker, expressionInfo, ref expressionWeights.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetFaceExpressionWeightsFB(this FBFaceTracking thisApi, [Count(Count = 0)] FaceTrackerFB faceTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FaceExpressionInfoFB> expressionInfo, [Count(Count = 0)] FaceExpressionWeightsFB* expressionWeights)
        {
            // SpanOverloader
            return thisApi.GetFaceExpressionWeightsFB(faceTracker, in expressionInfo.GetPinnableReference(), expressionWeights);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetFaceExpressionWeightsFB(this FBFaceTracking thisApi, [Count(Count = 0)] FaceTrackerFB faceTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FaceExpressionInfoFB> expressionInfo, [Count(Count = 0)] Span<FaceExpressionWeightsFB> expressionWeights)
        {
            // SpanOverloader
            return thisApi.GetFaceExpressionWeightsFB(faceTracker, in expressionInfo.GetPinnableReference(), ref expressionWeights.GetPinnableReference());
        }

    }
}

