// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Buffers;
using System.ComponentModel;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Threading;
using Silk.NET.Core.Contexts;
using Silk.NET.Maths;


namespace Silk.NET.Windowing.Internals
{
    /// <summary>
    /// Abstracts away common view functions to ease implementation of the windowing API.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal abstract class ViewImplementationBase : IView
    {
        private const int InitialInvocationRental = 2;
        // Cache the boxed version of frequency.
        private static readonly double Frequency = Stopwatch.Frequency;

        // Cache the options for when the window is closed
        protected ViewOptions _optionsCache;

        // Game loop fields
        private long _renderTimestamp;
        private long _updateTimestamp;
        private long _lifetimeTimestamp;
        private long _renderPeriod;
        private long _updatePeriod;

        // Invocations
        private readonly ArrayPool<object> _returnArrayPool = ArrayPool<object>.Create();
        private PendingInvocation[]? _pendingInvocations;
        private int _rented;

        // Ensure we keep SwapInterval up-to-date
        private bool _swapIntervalChanged = true;

        /// <summary>
        /// Creates a base view with the given options.
        /// </summary>
        /// <param name="opts">The options, used to configure the view.</param>
        protected ViewImplementationBase(ViewOptions opts)
        {
            _optionsCache = opts;
            FramesPerSecond = opts.FramesPerSecond;
            UpdatesPerSecond = opts.UpdatesPerSecond;
        }

        // Property bases - these have extra functionality baked into their getters and setters
        protected abstract Vector2D<int> CoreSize { get; }
        protected abstract nint CoreHandle { get; }

        // Function bases - again extra functionality on top
        protected abstract void CoreInitialize(ViewOptions opts);
        protected abstract void CoreReset();

        // Other APIs implemented abstractly
        public abstract IGLContext? GLContext { get; }
        public abstract IVkSurface? VkSurface { get; }
        public abstract bool IsClosing { get; }
        public abstract VideoMode VideoMode { get; }
        public abstract bool IsEventDriven { get; set; }
        public abstract Vector2D<int> FramebufferSize { get; }
        public abstract void DoEvents();
        public abstract void ContinueEvents();
        public abstract void Dispose();
        public abstract Vector2D<int> PointToClient(Vector2D<int> point);
        public abstract Vector2D<int> PointToScreen(Vector2D<int> point);
        public abstract void Close();
        protected abstract void RegisterCallbacks();
        protected abstract void UnregisterCallbacks();

        // Events
        public abstract event Action<Vector2D<int>>? Resize;
        public abstract event Action<Vector2D<int>>? FramebufferResize;
        public abstract event Action? Closing;
        public abstract event Action<bool>? FocusChanged;
        public event Action? Load;
        public event Action<double>? Update;
        public event Action<double>? Render;

        // Lifetime controls
        public void Initialize()
        {
            if (IsInitialized)
            {
                return;
            }

            CoreInitialize(_optionsCache);
            RegisterCallbacks();
            EnsureArrayIsReady(-1);
            _renderTimestamp = _updateTimestamp = _lifetimeTimestamp = Stopwatch.GetTimestamp();
            IsInitialized = true;
            IsEventDriven = _optionsCache.IsEventDriven;
            GLContext?.MakeCurrent();
            _swapIntervalChanged = true;
            Load?.Invoke();
        }

        public void Reset()
        {
            _renderTimestamp = _updateTimestamp = _lifetimeTimestamp = Stopwatch.GetTimestamp();
            CoreReset();
            UnregisterCallbacks();
            IsInitialized = false;
        }

        // Game loop controls
        public double FramesPerSecond
        {
            get => _renderPeriod < 1 ? 0 : Frequency / _renderPeriod;
            set => _renderPeriod = value <= double.Epsilon ? 0 : (long) (Frequency / value);
        }

        public double UpdatesPerSecond
        {
            get => _updatePeriod < 1 ? 0 : Frequency / _renderPeriod;
            set => _updatePeriod = value <= double.Epsilon ? 0 : (long) (Frequency / value);
        }

        public bool ShouldSwapAutomatically => _optionsCache.ShouldSwapAutomatically /* TODO set? */;

        // Cache controls for derived classes
        protected VideoMode CachedVideoMode
        {
            get => _optionsCache.VideoMode;
            set => _optionsCache.VideoMode = value;
        }

        // Game loop implementation
        public virtual void Run(Action onFrame)
        {
            while (!IsClosing)
            {
                onFrame();
            }
        }

        public void DoRender()
        {
            DoInvokes();
            // Check elapsed time
            if (VSync || ((Stopwatch.GetTimestamp() - _renderTimestamp) >= _renderPeriod))
            {
                if (!(GLContext is null) && !GLContext.IsCurrent)
                {
                    GLContext.MakeCurrent();
                }

                if (_swapIntervalChanged)
                {
                    GLContext?.SwapInterval(VSync ? 1 : 0);
                    _swapIntervalChanged = false;
                }

                // Re-calculte the elapsed time, resetting the current timestamp
                Render?.Invoke((-Interlocked.Exchange(ref _renderTimestamp, Stopwatch.GetTimestamp()) + _renderTimestamp) / Frequency);

                if (ShouldSwapAutomatically)
                {
                    GLContext?.SwapBuffers();
                }
            }
        }

        public void DoUpdate()
        {
            // Check elapsed time
            if ((Stopwatch.GetTimestamp() - _updateTimestamp) >= _updatePeriod)
            {
                // Re-calculte the elapsed time, resetting the current timestamp
                Update?.Invoke((-Interlocked.Exchange(ref _updateTimestamp, Stopwatch.GetTimestamp()) + _updateTimestamp) / Frequency);
            }
        }

        // Misc properties
        protected bool IsInitialized { get; set; }
        public Vector2D<int> Size => IsInitialized ? CoreSize : default;
        public nint Handle => IsInitialized ? CoreHandle : 0;
        public GraphicsAPI API => _optionsCache.API;
        public double Time => (Stopwatch.GetTimestamp() - _lifetimeTimestamp) / Frequency;
        public int? PreferredDepthBufferBits => _optionsCache.PreferredDepthBufferBits;
        public int? PreferredStencilBufferBits => _optionsCache.PreferredStencilBufferBits;
        public Vector4D<int>? PreferredBitDepth => _optionsCache.PreferredBitDepth;

        public bool VSync
        {
            get => _optionsCache.VSync;
            set
            {
                _swapIntervalChanged = true;
                _optionsCache.VSync = value;
            }
        }

        // Misc implementations
        [MethodImpl(MethodImplOptions.AggressiveInlining | (MethodImplOptions) 512)]
        public Vector2D<int> PointToFramebuffer(Vector2D<int> point)
        {
            // TODO this monstrosity will be gone once Silk.NET.Maths has intrinsics
            if (Vector.IsHardwareAccelerated && Vector<int>.Count >= 2)
            {
#if NETSTANDARD2_1
                // ReSharper disable SuggestVarOrType_Elsewhere
                Span<int> framebufferSizeElements = stackalloc int[Vector<int>.Count];
                Unsafe.As<int, Vector2D<int>>(ref framebufferSizeElements[0]) = FramebufferSize;
                var framebufferSize = new Vector<int>(framebufferSizeElements);
                Span<int> sizeElements = stackalloc int[Vector<int>.Count];
                Unsafe.As<int, Vector2D<int>>(ref sizeElements[0]) = Size;
                var size = new Vector<int>(sizeElements);
                Span<int> pointElements = stackalloc int[Vector<int>.Count];
                Unsafe.As<int, Vector2D<int>>(ref pointElements[0]) = point;
                var thePoint = new Vector<int>(pointElements);
                // ReSharper restore SuggestVarOrType_Elsewhere
#else
                var c = Vector<int>.Count;
                var a = new int[c * 3];
                Unsafe.As<int, Vector2D<int>>(ref a[0]) = FramebufferSize;
                Unsafe.As<int, Vector2D<int>>(ref a[c]) = Size;
                Unsafe.As<int, Vector2D<int>>(ref a[c * 2]) = point;
                var framebufferSize = new Vector<int>(a, 0);
                var size = new Vector<int>(a, c);
                var thePoint = new Vector<int>(a, c * 2);
#endif
                thePoint = Vector.Multiply(thePoint, Vector.Divide(framebufferSize, size));
                return new Vector2D<int>(thePoint[0], thePoint[1]);
            }

            var fSize = FramebufferSize;
            var aSize = Size;
            return new Vector2D<int>
            {
                X = point.X * (fSize.X / aSize.X),
                Y = point.Y * (fSize.Y / aSize.Y)
            };
        }

        // Invoke system
        public object Invoke(Delegate d, params object[] args)
        {
            var rentalIndex = Interlocked.Increment(ref _rented) - 1;
            EnsureArrayIsReady(rentalIndex);
            ref var x = ref _pendingInvocations![rentalIndex];
            x.Delegate = d;
            x.Data = args;
            x.ResetEvent.Reset();
            x.IsComplete = false;
            x.ResetEvent.Wait();
            var ret = x.Data[0];
            _returnArrayPool.Return(x.Data);
            x.Delegate = null;
            x.Data = null;
            return ret;
        }

        public void DoInvokes()
        {
            if (_pendingInvocations is null)
            {
                return;
            }

            var completed = 0;
            for (var i = 0; i < _rented + completed && i < _pendingInvocations.Length; i++)
            {
                ref var invocation = ref _pendingInvocations[i];
                if (invocation.IsComplete || invocation.Delegate is null)
                {
                    completed++;
                }
                else
                {
                    var ret = _returnArrayPool.Rent(1);
                    ret[0] = invocation.Delegate.DynamicInvoke(invocation.Data);
                    invocation.Data = ret;
                    invocation.IsComplete = true;
                    invocation.ResetEvent.Set();
                    Interlocked.Decrement(ref _rented);
                }
            }
        }

        private void EnsureArrayIsReady(int rentalIndex)
        {
            _pendingInvocations ??= new PendingInvocation[InitialInvocationRental];

            if (rentalIndex == -1)
            {
                return;
            }

            var finalSize = _pendingInvocations.Length;
            while (rentalIndex + 1 > finalSize)
            {
                finalSize *= 2;
            }

            if (finalSize == _pendingInvocations.Length)
            {
                return;
            }

            var na = new PendingInvocation[finalSize];
            var og = Interlocked.Exchange(ref _pendingInvocations, na);
            og?.CopyTo(na, 0);
            for (var i = 0; i < na.Length; i++)
            {
                na[i].ResetEvent ??= new ManualResetEventSlim();
            }
        }

        private struct PendingInvocation
        {
            public bool IsComplete { get; set; }
            public Delegate? Delegate { get; set; }
            public object[]? Data { get; set; }
            public ManualResetEventSlim ResetEvent { get; set; }
        }
    }
}
