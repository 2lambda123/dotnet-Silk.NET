// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Drawing;

namespace Silk.NET.Windowing.Common
{
    /// <summary>
    /// Contains all window properties, used for window creation.
    /// </summary>
    public struct WindowOptions : IWindowProperties
    {
        /// <summary>
        /// Creates an instance of WindowOptions from an existing ViewOptions struct.
        /// </summary>
        /// <param name="opts">The view options to copy where applicable.</param>
        public WindowOptions(ViewOptions opts)
        {
            FramesPerSecond = opts.FramesPerSecond;
            UpdatesPerSecond = opts.UpdatesPerSecond;
            API = opts.API;
            Title = "Silk.NET Window";
            WindowState = WindowState.Fullscreen;
            WindowBorder = WindowBorder.Hidden;
            VSync = opts.VSync;
            RunningSlowTolerance = opts.RunningSlowTolerance;
            IsVisible = true;
            UseSingleThreadedWindow = true;
            ShouldSwapAutomatically = true;
            VideoMode = opts.VideoMode;
            DepthBufferBits = (int)FramebufferBits.DontCare;
        }
        
        /// <inheritdoc />
        public bool IsVisible { get; set; }

        /// <inheritdoc />
        public bool UseSingleThreadedWindow { get; set; }

        /// <inheritdoc />
        public bool ShouldSwapAutomatically { get; set; }

        /// <inheritdoc />
        public VideoMode VideoMode { get; set; }

        /// <inheritdoc />
        public int DepthBufferBits { get; set; }

        /// <inheritdoc />
        public Point Position { get; set; }

        /// <inheritdoc cref="IWindowProperties" />
        public Size Size { get; set; }

        /// <inheritdoc />
        public double FramesPerSecond { get; set; }

        /// <inheritdoc />
        public double UpdatesPerSecond { get; set; }

        /// <inheritdoc />
        public GraphicsAPI API { get; set; }

        /// <inheritdoc />
        public string Title { get; set; }

        /// <inheritdoc />
        public WindowState WindowState { get; set; }

        /// <inheritdoc />
        public WindowBorder WindowBorder { get; set; }

        /// <inheritdoc />
        public VSyncMode VSync { get; set; }
        
        /// <inheritdoc />
        public int RunningSlowTolerance { get; set; }

        /// <summary>
        /// Creates a new WindowOptions struct.
        /// </summary>
        public WindowOptions(bool isVisible, bool useSingleThreadedWindow, Point position, Size size,
            double framesPerSecond, double updatesPerSecond, GraphicsAPI api, string title,
            WindowState windowState, WindowBorder windowBorder, VSyncMode vSync,
            int isRunningSlowlyThreshold, bool shouldSwapAutomatically, VideoMode videoMode,
            int depthBufferBits = (int)FramebufferBits.DontCare)
        {
            IsVisible = isVisible;
            UseSingleThreadedWindow = useSingleThreadedWindow;
            Position = position;
            Size = size;
            FramesPerSecond = framesPerSecond;
            UpdatesPerSecond = updatesPerSecond;
            API = api;
            Title = title;
            WindowState = windowState;
            WindowBorder = windowBorder;
            VSync = vSync;
            RunningSlowTolerance = isRunningSlowlyThreshold;
            ShouldSwapAutomatically = shouldSwapAutomatically;
            VideoMode = videoMode;
            DepthBufferBits = depthBufferBits;
        }

        /// <summary>
        /// Convenience wrapper around creating a new WindowProperties with sensible defaults.
        /// </summary>
        public static WindowOptions Default { get; } = new WindowOptions(true, true, new Point(50, 50),
            new Size(1280, 720), 0.0, 0.0, GraphicsAPI.Default,
            "Silk.NET Window", WindowState.Normal, WindowBorder.Resizable, VSyncMode.On, 5, true, VideoMode.Default);

        /// <summary>
        /// Convenience wrapper around creating a new WindowProperties with sensible values, intended for use with Vulkan.
        /// </summary>
        public static WindowOptions DefaultVulkan { get; } = new WindowOptions(true, true, new Point(50, 50),
            new Size(1280, 720), 0.0, 0.0, GraphicsAPI.DefaultVulkan,
            "Silk.NET Window", WindowState.Normal, WindowBorder.Resizable, VSyncMode.Off, 5, false, VideoMode.Default);
    }
}