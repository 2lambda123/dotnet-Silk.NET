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

namespace Silk.NET.SDL
{
    public unsafe partial class Sdl : NativeAPI
    {
        [NativeName("Type", "int")]
        [NativeName("Name", "__ANDROID__")]
        public const int Android = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "HAVE_WINAPIFAMILY_H")]
        public const int HaveWinapifamilyH = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "__WINDOWS__")]
        public const int Windows = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "__WIN32__")]
        public const int Win32 = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "NULL")]
        public const int Null = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "HAVE_WINSDKVER_H")]
        public const int HaveWinsdkverH = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "HAVE_SDKDDKVER_H")]
        public const int HaveSdkddkverH = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "HAVE_STDINT_H")]
        public const int HaveStdintH = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SIZEOF_VOIDP")]
        public const int SizeofVoidp = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "HAVE_GCC_ATOMICS")]
        public const int HaveGccAtomics = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "HAVE_DDRAW_H")]
        public const int HaveDdrawH = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "HAVE_DINPUT_H")]
        public const int HaveDinputH = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "HAVE_DSOUND_H")]
        public const int HaveDsoundH = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "HAVE_DXGI_H")]
        public const int HaveDxgiH = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "HAVE_XINPUT_H")]
        public const int HaveXinputH = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "HAVE_WINDOWS_GAMING_INPUT_H")]
        public const int HaveWindowsGamingInputH = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "HAVE_D3D11_H")]
        public const int HaveD3D11H = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "HAVE_ROAPI_H")]
        public const int HaveRoapiH = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "HAVE_D3D12_H")]
        public const int HaveD3D12H = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "HAVE_SHELLSCALINGAPI_H")]
        public const int HaveShellscalingapiH = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "HAVE_MMDEVICEAPI_H")]
        public const int HaveMmdeviceapiH = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "HAVE_AUDIOCLIENT_H")]
        public const int HaveAudioclientH = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "HAVE_TPCSHRD_H")]
        public const int HaveTpcshrdH = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "HAVE_SENSORSAPI_H")]
        public const int HaveSensorsapiH = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "HAVE_IMMINTRIN_H")]
        public const int HaveImmintrinH = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "HAVE_STDARG_H")]
        public const int HaveStdargH = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "HAVE_STDDEF_H")]
        public const int HaveStddefH = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_AUDIO_DRIVER_WASAPI")]
        public const int AudioDriverWasapi = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_AUDIO_DRIVER_DSOUND")]
        public const int AudioDriverDsound = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_AUDIO_DRIVER_WINMM")]
        public const int AudioDriverWinmm = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_AUDIO_DRIVER_DISK")]
        public const int AudioDriverDisk = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_AUDIO_DRIVER_DUMMY")]
        public const int AudioDriverDummy = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_JOYSTICK_DINPUT")]
        public const int JoystickDinput = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_JOYSTICK_HIDAPI")]
        public const int JoystickHidapi = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_JOYSTICK_VIRTUAL")]
        public const int JoystickVirtual = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_JOYSTICK_WGI")]
        public const int JoystickWgi = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_JOYSTICK_XINPUT")]
        public const int JoystickXinput = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_HAPTIC_DINPUT")]
        public const int HapticDinput = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_HAPTIC_XINPUT")]
        public const int HapticXinput = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_SENSOR_WINDOWS")]
        public const int SensorWindows = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_LOADSO_WINDOWS")]
        public const int LoadsoWindows = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_THREAD_GENERIC_COND_SUFFIX")]
        public const int ThreadGenericCondSuffix = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_THREAD_WINDOWS")]
        public const int ThreadWindows = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_TIMER_WINDOWS")]
        public const int TimerWindows = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_VIDEO_DRIVER_DUMMY")]
        public const int VideoDriverDummy = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_VIDEO_DRIVER_WINDOWS")]
        public const int VideoDriverWindows = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_VIDEO_RENDER_D3D")]
        public const int VideoRenderD3D = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_VIDEO_RENDER_D3D11")]
        public const int VideoRenderD3D11 = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_VIDEO_RENDER_D3D12")]
        public const int VideoRenderD3D12 = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_VIDEO_OPENGL")]
        public const int VideoOpengl = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_VIDEO_OPENGL_WGL")]
        public const int VideoOpenglWgl = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_VIDEO_RENDER_OGL")]
        public const int VideoRenderOgl = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_VIDEO_RENDER_OGL_ES2")]
        public const int VideoRenderOglES2 = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_VIDEO_OPENGL_ES2")]
        public const int VideoOpenglES2 = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_VIDEO_OPENGL_EGL")]
        public const int VideoOpenglEgl = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_VIDEO_VULKAN")]
        public const int VideoVulkan = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_POWER_WINDOWS")]
        public const int PowerWindows = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_FILESYSTEM_WINDOWS")]
        public const int FilesystemWindows = unchecked((int) 0x1);
        [NativeName("Type", "unsigned long long")]
        [NativeName("Name", "SDL_SIZE_MAX")]
        public const ulong SizeMax = unchecked((ulong) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_PRIs64")]
        public const string Pris64 = unchecked((string) "I64d");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_PRIu64")]
        public const string Priu64 = unchecked((string) "I64u");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_PRIx64")]
        public const string PRIx64 = unchecked((string) "I64x");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_PRIX64")]
        public const string PRIX64 = unchecked((string) "I64X");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_PRIs32")]
        public const string Pris32 = unchecked((string) "d");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_PRIu32")]
        public const string Priu32 = unchecked((string) "u");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_PRIx32")]
        public const string PRIx32 = unchecked((string) "x");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_PRIX32")]
        public const string PRIX32 = unchecked((string) "X");
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_LIL_ENDIAN")]
        public const int LilEndian = unchecked((int) 0x4D2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_BIG_ENDIAN")]
        public const int BigEndian = unchecked((int) 0x10E1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_BYTEORDER")]
        public const int Byteorder = unchecked((int) 0x4D2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_FLOATWORDORDER")]
        public const int Floatwordorder = unchecked((int) 0x4D2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_ALPHA_OPAQUE")]
        public const int AlphaOpaque = unchecked((int) 0xFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_ALPHA_TRANSPARENT")]
        public const int AlphaTransparent = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_SWSURFACE")]
        public const int Swsurface = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_PREALLOC")]
        public const int Prealloc = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_RLEACCEL")]
        public const int Rleaccel = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_DONTFREE")]
        public const int Dontfree = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_SIMD_ALIGNED")]
        public const int SimdAligned = unchecked((int) 0x8);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "SDL_WINDOWPOS_UNDEFINED_MASK")]
        public const uint WindowposUndefinedMask = unchecked((uint) 0x1FFF0000);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "SDL_WINDOWPOS_CENTERED_MASK")]
        public const uint WindowposCenteredMask = unchecked((uint) 0x2FFF0000);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_ASSERT_LEVEL")]
        public const int AssertLevel = unchecked((int) 0x1);
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_FILE")]
        public const string File = unchecked((string) "SDL.h");
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_LINE")]
        public const int Line = unchecked((int) 0x1B5);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_MUTEX_TIMEDOUT")]
        public const int MutexTimedout = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_AUDIO_MASK_BITSIZE")]
        public const int AudioMaskBitsize = unchecked((int) 0xFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "AUDIO_U8")]
        public const int AudioU8 = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "AUDIO_S8")]
        public const int AudioS8 = unchecked((int) 0x8008);
        [NativeName("Type", "int")]
        [NativeName("Name", "AUDIO_U16LSB")]
        public const int AudioU16Lsb = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "AUDIO_S16LSB")]
        public const int AudioS16Lsb = unchecked((int) 0x8010);
        [NativeName("Type", "int")]
        [NativeName("Name", "AUDIO_U16MSB")]
        public const int AudioU16Msb = unchecked((int) 0x1010);
        [NativeName("Type", "int")]
        [NativeName("Name", "AUDIO_S16MSB")]
        public const int AudioS16Msb = unchecked((int) 0x9010);
        [NativeName("Type", "int")]
        [NativeName("Name", "AUDIO_U16")]
        public const int AudioU16 = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "AUDIO_S16")]
        public const int AudioS16 = unchecked((int) 0x8010);
        [NativeName("Type", "int")]
        [NativeName("Name", "AUDIO_S32LSB")]
        public const int AudioS32Lsb = unchecked((int) 0x8020);
        [NativeName("Type", "int")]
        [NativeName("Name", "AUDIO_S32MSB")]
        public const int AudioS32Msb = unchecked((int) 0x9020);
        [NativeName("Type", "int")]
        [NativeName("Name", "AUDIO_S32")]
        public const int AudioS32 = unchecked((int) 0x8020);
        [NativeName("Type", "int")]
        [NativeName("Name", "AUDIO_F32LSB")]
        public const int AudioF32Lsb = unchecked((int) 0x8120);
        [NativeName("Type", "int")]
        [NativeName("Name", "AUDIO_F32MSB")]
        public const int AudioF32Msb = unchecked((int) 0x9120);
        [NativeName("Type", "int")]
        [NativeName("Name", "AUDIO_F32")]
        public const int AudioF32 = unchecked((int) 0x8120);
        [NativeName("Type", "int")]
        [NativeName("Name", "AUDIO_U16SYS")]
        public const int AudioU16Sys = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "AUDIO_S16SYS")]
        public const int AudioS16Sys = unchecked((int) 0x8010);
        [NativeName("Type", "int")]
        [NativeName("Name", "AUDIO_S32SYS")]
        public const int AudioS32Sys = unchecked((int) 0x8020);
        [NativeName("Type", "int")]
        [NativeName("Name", "AUDIO_F32SYS")]
        public const int AudioF32Sys = unchecked((int) 0x8120);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_AUDIO_ALLOW_FREQUENCY_CHANGE")]
        public const int AudioAllowFrequencyChange = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_AUDIO_ALLOW_FORMAT_CHANGE")]
        public const int AudioAllowFormatChange = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_AUDIO_ALLOW_CHANNELS_CHANGE")]
        public const int AudioAllowChannelsChange = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_AUDIO_ALLOW_SAMPLES_CHANGE")]
        public const int AudioAllowSamplesChange = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_AUDIOCVT_MAX_FILTERS")]
        public const int AudiocvtMaxFilters = unchecked((int) 0x9);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_MIX_MAXVOLUME")]
        public const int MixMaxvolume = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_CACHELINE_SIZE")]
        public const int CachelineSize = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_BUTTON_LEFT")]
        public const int ButtonLeft = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_BUTTON_MIDDLE")]
        public const int ButtonMiddle = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_BUTTON_RIGHT")]
        public const int ButtonRight = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_BUTTON_X1")]
        public const int ButtonX1 = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_BUTTON_X2")]
        public const int ButtonX2 = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_VIRTUAL_JOYSTICK_DESC_VERSION")]
        public const int VirtualJoystickDescVersion = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_JOYSTICK_AXIS_MAX")]
        public const int JoystickAxisMax = unchecked((int) 0x7FFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_HAT_CENTERED")]
        public const int HatCentered = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_HAT_UP")]
        public const int HatUp = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_HAT_RIGHT")]
        public const int HatRight = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_HAT_DOWN")]
        public const int HatDown = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_HAT_LEFT")]
        public const int HatLeft = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_RELEASED")]
        public const int Released = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_PRESSED")]
        public const int Pressed = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_TEXTEDITINGEVENT_TEXT_SIZE")]
        public const int TexteditingeventTextSize = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_TEXTINPUTEVENT_TEXT_SIZE")]
        public const int TextinputeventTextSize = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_IGNORE")]
        public const int Ignore = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_DISABLE")]
        public const int Disable = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_ENABLE")]
        public const int Enable = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_HAPTIC_POLAR")]
        public const int HapticPolar = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_HAPTIC_CARTESIAN")]
        public const int HapticCartesian = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_HAPTIC_SPHERICAL")]
        public const int HapticSpherical = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_HAPTIC_STEERING_AXIS")]
        public const int HapticSteeringAxis = unchecked((int) 0x3);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "SDL_HAPTIC_INFINITY")]
        public const uint HapticInfinity = unchecked((uint) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_ACCELEROMETER_AS_JOYSTICK")]
        public const string HintAccelerometerAsJoystick = unchecked((string) "SDL_ACCELEROMETER_AS_JOYSTICK");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_ALLOW_ALT_TAB_WHILE_GRABBED")]
        public const string HintAllowAltTabWhileGrabbed = unchecked((string) "SDL_ALLOW_ALT_TAB_WHILE_GRABBED");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_ALLOW_TOPMOST")]
        public const string HintAllowTopmost = unchecked((string) "SDL_ALLOW_TOPMOST");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_ANDROID_APK_EXPANSION_MAIN_FILE_VERSION")]
        public const string HintAndroidApkExpansionMainFileVersion = unchecked((string) "SDL_ANDROID_APK_EXPANSION_MAIN_FILE_VERSION");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_ANDROID_APK_EXPANSION_PATCH_FILE_VERSION")]
        public const string HintAndroidApkExpansionPatchFileVersion = unchecked((string) "SDL_ANDROID_APK_EXPANSION_PATCH_FILE_VERSION");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_ANDROID_BLOCK_ON_PAUSE")]
        public const string HintAndroidBlockOnPause = unchecked((string) "SDL_ANDROID_BLOCK_ON_PAUSE");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_ANDROID_BLOCK_ON_PAUSE_PAUSEAUDIO")]
        public const string HintAndroidBlockOnPausePauseaudio = unchecked((string) "SDL_ANDROID_BLOCK_ON_PAUSE_PAUSEAUDIO");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_ANDROID_TRAP_BACK_BUTTON")]
        public const string HintAndroidTrapBackButton = unchecked((string) "SDL_ANDROID_TRAP_BACK_BUTTON");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_APP_NAME")]
        public const string HintAppName = unchecked((string) "SDL_APP_NAME");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_APPLE_TV_CONTROLLER_UI_EVENTS")]
        public const string HintAppleTVControllerUIEvents = unchecked((string) "SDL_APPLE_TV_CONTROLLER_UI_EVENTS");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_APPLE_TV_REMOTE_ALLOW_ROTATION")]
        public const string HintAppleTVRemoteAllowRotation = unchecked((string) "SDL_APPLE_TV_REMOTE_ALLOW_ROTATION");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_AUDIO_CATEGORY")]
        public const string HintAudioCategory = unchecked((string) "SDL_AUDIO_CATEGORY");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_AUDIO_DEVICE_APP_NAME")]
        public const string HintAudioDeviceAppName = unchecked((string) "SDL_AUDIO_DEVICE_APP_NAME");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_AUDIO_DEVICE_STREAM_NAME")]
        public const string HintAudioDeviceStreamName = unchecked((string) "SDL_AUDIO_DEVICE_STREAM_NAME");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_AUDIO_DEVICE_STREAM_ROLE")]
        public const string HintAudioDeviceStreamRole = unchecked((string) "SDL_AUDIO_DEVICE_STREAM_ROLE");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_AUDIO_RESAMPLING_MODE")]
        public const string HintAudioResamplingMode = unchecked((string) "SDL_AUDIO_RESAMPLING_MODE");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_AUTO_UPDATE_JOYSTICKS")]
        public const string HintAutoUpdateJoysticks = unchecked((string) "SDL_AUTO_UPDATE_JOYSTICKS");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_AUTO_UPDATE_SENSORS")]
        public const string HintAutoUpdateSensors = unchecked((string) "SDL_AUTO_UPDATE_SENSORS");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_BMP_SAVE_LEGACY_FORMAT")]
        public const string HintBmpSaveLegacyFormat = unchecked((string) "SDL_BMP_SAVE_LEGACY_FORMAT");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_DISPLAY_USABLE_BOUNDS")]
        public const string HintDisplayUsableBounds = unchecked((string) "SDL_DISPLAY_USABLE_BOUNDS");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_EMSCRIPTEN_ASYNCIFY")]
        public const string HintEmscriptenAsyncify = unchecked((string) "SDL_EMSCRIPTEN_ASYNCIFY");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_EMSCRIPTEN_KEYBOARD_ELEMENT")]
        public const string HintEmscriptenKeyboardElement = unchecked((string) "SDL_EMSCRIPTEN_KEYBOARD_ELEMENT");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_ENABLE_STEAM_CONTROLLERS")]
        public const string HintEnableSteamControllers = unchecked((string) "SDL_ENABLE_STEAM_CONTROLLERS");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_EVENT_LOGGING")]
        public const string HintEventLogging = unchecked((string) "SDL_EVENT_LOGGING");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_FORCE_RAISEWINDOW")]
        public const string HintForceRaisewindow = unchecked((string) "SDL_HINT_FORCE_RAISEWINDOW");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_FRAMEBUFFER_ACCELERATION")]
        public const string HintFramebufferAcceleration = unchecked((string) "SDL_FRAMEBUFFER_ACCELERATION");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_GAMECONTROLLERCONFIG")]
        public const string HintGamecontrollerconfig = unchecked((string) "SDL_GAMECONTROLLERCONFIG");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_GAMECONTROLLERCONFIG_FILE")]
        public const string HintGamecontrollerconfigFile = unchecked((string) "SDL_GAMECONTROLLERCONFIG_FILE");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_GAMECONTROLLERTYPE")]
        public const string HintGamecontrollertype = unchecked((string) "SDL_GAMECONTROLLERTYPE");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_GAMECONTROLLER_IGNORE_DEVICES")]
        public const string HintGamecontrollerIgnoreDevices = unchecked((string) "SDL_GAMECONTROLLER_IGNORE_DEVICES");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_GAMECONTROLLER_IGNORE_DEVICES_EXCEPT")]
        public const string HintGamecontrollerIgnoreDevicesExcept = unchecked((string) "SDL_GAMECONTROLLER_IGNORE_DEVICES_EXCEPT");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_GAMECONTROLLER_USE_BUTTON_LABELS")]
        public const string HintGamecontrollerUseButtonLabels = unchecked((string) "SDL_GAMECONTROLLER_USE_BUTTON_LABELS");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_GRAB_KEYBOARD")]
        public const string HintGrabKeyboard = unchecked((string) "SDL_GRAB_KEYBOARD");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_HIDAPI_IGNORE_DEVICES")]
        public const string HintHidapiIgnoreDevices = unchecked((string) "SDL_HIDAPI_IGNORE_DEVICES");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_IDLE_TIMER_DISABLED")]
        public const string HintIdleTimerDisabled = unchecked((string) "SDL_IOS_IDLE_TIMER_DISABLED");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_IME_INTERNAL_EDITING")]
        public const string HintImeInternalEditing = unchecked((string) "SDL_IME_INTERNAL_EDITING");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_IME_SHOW_UI")]
        public const string HintImeShowUI = unchecked((string) "SDL_IME_SHOW_UI");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_IME_SUPPORT_EXTENDED_TEXT")]
        public const string HintImeSupportExtendedText = unchecked((string) "SDL_IME_SUPPORT_EXTENDED_TEXT");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_IOS_HIDE_HOME_INDICATOR")]
        public const string HintIosHideHomeIndicator = unchecked((string) "SDL_IOS_HIDE_HOME_INDICATOR");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_JOYSTICK_ALLOW_BACKGROUND_EVENTS")]
        public const string HintJoystickAllowBackgroundEvents = unchecked((string) "SDL_JOYSTICK_ALLOW_BACKGROUND_EVENTS");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_JOYSTICK_HIDAPI")]
        public const string HintJoystickHidapi = unchecked((string) "SDL_JOYSTICK_HIDAPI");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_JOYSTICK_HIDAPI_GAMECUBE")]
        public const string HintJoystickHidapiGamecube = unchecked((string) "SDL_JOYSTICK_HIDAPI_GAMECUBE");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_JOYSTICK_GAMECUBE_RUMBLE_BRAKE")]
        public const string HintJoystickGamecubeRumbleBrake = unchecked((string) "SDL_JOYSTICK_GAMECUBE_RUMBLE_BRAKE");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_JOYSTICK_HIDAPI_JOY_CONS")]
        public const string HintJoystickHidapiJoyCons = unchecked((string) "SDL_JOYSTICK_HIDAPI_JOY_CONS");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_JOYSTICK_HIDAPI_COMBINE_JOY_CONS")]
        public const string HintJoystickHidapiCombineJoyCons = unchecked((string) "SDL_JOYSTICK_HIDAPI_COMBINE_JOY_CONS");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_JOYSTICK_HIDAPI_VERTICAL_JOY_CONS")]
        public const string HintJoystickHidapiVerticalJoyCons = unchecked((string) "SDL_JOYSTICK_HIDAPI_VERTICAL_JOY_CONS");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_JOYSTICK_HIDAPI_LUNA")]
        public const string HintJoystickHidapiLuna = unchecked((string) "SDL_JOYSTICK_HIDAPI_LUNA");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_JOYSTICK_HIDAPI_NINTENDO_CLASSIC")]
        public const string HintJoystickHidapiNintendoClassic = unchecked((string) "SDL_JOYSTICK_HIDAPI_NINTENDO_CLASSIC");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_JOYSTICK_HIDAPI_SHIELD")]
        public const string HintJoystickHidapiShield = unchecked((string) "SDL_JOYSTICK_HIDAPI_SHIELD");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_JOYSTICK_HIDAPI_PS3")]
        public const string HintJoystickHidapiPS3 = unchecked((string) "SDL_JOYSTICK_HIDAPI_PS3");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_JOYSTICK_HIDAPI_PS4")]
        public const string HintJoystickHidapiPS4 = unchecked((string) "SDL_JOYSTICK_HIDAPI_PS4");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_JOYSTICK_HIDAPI_PS4_RUMBLE")]
        public const string HintJoystickHidapiPS4Rumble = unchecked((string) "SDL_JOYSTICK_HIDAPI_PS4_RUMBLE");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_JOYSTICK_HIDAPI_PS5")]
        public const string HintJoystickHidapiPS5 = unchecked((string) "SDL_JOYSTICK_HIDAPI_PS5");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_JOYSTICK_HIDAPI_PS5_PLAYER_LED")]
        public const string HintJoystickHidapiPS5PlayerLed = unchecked((string) "SDL_JOYSTICK_HIDAPI_PS5_PLAYER_LED");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_JOYSTICK_HIDAPI_PS5_RUMBLE")]
        public const string HintJoystickHidapiPS5Rumble = unchecked((string) "SDL_JOYSTICK_HIDAPI_PS5_RUMBLE");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_JOYSTICK_HIDAPI_STADIA")]
        public const string HintJoystickHidapiStadia = unchecked((string) "SDL_JOYSTICK_HIDAPI_STADIA");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_JOYSTICK_HIDAPI_STEAM")]
        public const string HintJoystickHidapiSteam = unchecked((string) "SDL_JOYSTICK_HIDAPI_STEAM");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_JOYSTICK_HIDAPI_SWITCH")]
        public const string HintJoystickHidapiSwitch = unchecked((string) "SDL_JOYSTICK_HIDAPI_SWITCH");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_JOYSTICK_HIDAPI_SWITCH_HOME_LED")]
        public const string HintJoystickHidapiSwitchHomeLed = unchecked((string) "SDL_JOYSTICK_HIDAPI_SWITCH_HOME_LED");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_JOYSTICK_HIDAPI_JOYCON_HOME_LED")]
        public const string HintJoystickHidapiJoyconHomeLed = unchecked((string) "SDL_JOYSTICK_HIDAPI_JOYCON_HOME_LED");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_JOYSTICK_HIDAPI_SWITCH_PLAYER_LED")]
        public const string HintJoystickHidapiSwitchPlayerLed = unchecked((string) "SDL_JOYSTICK_HIDAPI_SWITCH_PLAYER_LED");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_JOYSTICK_HIDAPI_WII")]
        public const string HintJoystickHidapiWii = unchecked((string) "SDL_JOYSTICK_HIDAPI_WII");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_JOYSTICK_HIDAPI_WII_PLAYER_LED")]
        public const string HintJoystickHidapiWiiPlayerLed = unchecked((string) "SDL_JOYSTICK_HIDAPI_WII_PLAYER_LED");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_JOYSTICK_HIDAPI_XBOX")]
        public const string HintJoystickHidapiXbox = unchecked((string) "SDL_JOYSTICK_HIDAPI_XBOX");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_JOYSTICK_HIDAPI_XBOX_360")]
        public const string HintJoystickHidapiXbox360 = unchecked((string) "SDL_JOYSTICK_HIDAPI_XBOX_360");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_JOYSTICK_HIDAPI_XBOX_360_PLAYER_LED")]
        public const string HintJoystickHidapiXbox360PlayerLed = unchecked((string) "SDL_JOYSTICK_HIDAPI_XBOX_360_PLAYER_LED");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_JOYSTICK_HIDAPI_XBOX_360_WIRELESS")]
        public const string HintJoystickHidapiXbox360Wireless = unchecked((string) "SDL_JOYSTICK_HIDAPI_XBOX_360_WIRELESS");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_JOYSTICK_HIDAPI_XBOX_ONE")]
        public const string HintJoystickHidapiXboxOne = unchecked((string) "SDL_JOYSTICK_HIDAPI_XBOX_ONE");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_JOYSTICK_HIDAPI_XBOX_ONE_HOME_LED")]
        public const string HintJoystickHidapiXboxOneHomeLed = unchecked((string) "SDL_JOYSTICK_HIDAPI_XBOX_ONE_HOME_LED");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_JOYSTICK_RAWINPUT")]
        public const string HintJoystickRawinput = unchecked((string) "SDL_JOYSTICK_RAWINPUT");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_JOYSTICK_RAWINPUT_CORRELATE_XINPUT")]
        public const string HintJoystickRawinputCorrelateXinput = unchecked((string) "SDL_JOYSTICK_RAWINPUT_CORRELATE_XINPUT");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_JOYSTICK_ROG_CHAKRAM")]
        public const string HintJoystickRogChakram = unchecked((string) "SDL_JOYSTICK_ROG_CHAKRAM");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_JOYSTICK_THREAD")]
        public const string HintJoystickThread = unchecked((string) "SDL_JOYSTICK_THREAD");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_KMSDRM_REQUIRE_DRM_MASTER")]
        public const string HintKmsdrmRequireDrmMaster = unchecked((string) "SDL_KMSDRM_REQUIRE_DRM_MASTER");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_JOYSTICK_DEVICE")]
        public const string HintJoystickDevice = unchecked((string) "SDL_JOYSTICK_DEVICE");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_LINUX_DIGITAL_HATS")]
        public const string HintLinuxDigitalHats = unchecked((string) "SDL_LINUX_DIGITAL_HATS");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_LINUX_HAT_DEADZONES")]
        public const string HintLinuxHatDeadzones = unchecked((string) "SDL_LINUX_HAT_DEADZONES");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_LINUX_JOYSTICK_CLASSIC")]
        public const string HintLinuxJoystickClassic = unchecked((string) "SDL_LINUX_JOYSTICK_CLASSIC");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_LINUX_JOYSTICK_DEADZONES")]
        public const string HintLinuxJoystickDeadzones = unchecked((string) "SDL_LINUX_JOYSTICK_DEADZONES");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_MAC_BACKGROUND_APP")]
        public const string HintMacBackgroundApp = unchecked((string) "SDL_MAC_BACKGROUND_APP");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_MAC_CTRL_CLICK_EMULATE_RIGHT_CLICK")]
        public const string HintMacCtrlClickEmulateRightClick = unchecked((string) "SDL_MAC_CTRL_CLICK_EMULATE_RIGHT_CLICK");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_MAC_OPENGL_ASYNC_DISPATCH")]
        public const string HintMacOpenglAsyncDispatch = unchecked((string) "SDL_MAC_OPENGL_ASYNC_DISPATCH");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_MOUSE_DOUBLE_CLICK_RADIUS")]
        public const string HintMouseDoubleClickRadius = unchecked((string) "SDL_MOUSE_DOUBLE_CLICK_RADIUS");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_MOUSE_DOUBLE_CLICK_TIME")]
        public const string HintMouseDoubleClickTime = unchecked((string) "SDL_MOUSE_DOUBLE_CLICK_TIME");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_MOUSE_FOCUS_CLICKTHROUGH")]
        public const string HintMouseFocusClickthrough = unchecked((string) "SDL_MOUSE_FOCUS_CLICKTHROUGH");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_MOUSE_NORMAL_SPEED_SCALE")]
        public const string HintMouseNormalSpeedScale = unchecked((string) "SDL_MOUSE_NORMAL_SPEED_SCALE");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_MOUSE_RELATIVE_MODE_CENTER")]
        public const string HintMouseRelativeModeCenter = unchecked((string) "SDL_MOUSE_RELATIVE_MODE_CENTER");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_MOUSE_RELATIVE_MODE_WARP")]
        public const string HintMouseRelativeModeWarp = unchecked((string) "SDL_MOUSE_RELATIVE_MODE_WARP");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_MOUSE_RELATIVE_SCALING")]
        public const string HintMouseRelativeScaling = unchecked((string) "SDL_MOUSE_RELATIVE_SCALING");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_MOUSE_RELATIVE_SPEED_SCALE")]
        public const string HintMouseRelativeSpeedScale = unchecked((string) "SDL_MOUSE_RELATIVE_SPEED_SCALE");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_MOUSE_RELATIVE_SYSTEM_SCALE")]
        public const string HintMouseRelativeSystemScale = unchecked((string) "SDL_MOUSE_RELATIVE_SYSTEM_SCALE");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_MOUSE_RELATIVE_WARP_MOTION")]
        public const string HintMouseRelativeWarpMotion = unchecked((string) "SDL_MOUSE_RELATIVE_WARP_MOTION");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_MOUSE_TOUCH_EVENTS")]
        public const string HintMouseTouchEvents = unchecked((string) "SDL_MOUSE_TOUCH_EVENTS");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_MOUSE_AUTO_CAPTURE")]
        public const string HintMouseAutoCapture = unchecked((string) "SDL_MOUSE_AUTO_CAPTURE");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_NO_SIGNAL_HANDLERS")]
        public const string HintNoSignalHandlers = unchecked((string) "SDL_NO_SIGNAL_HANDLERS");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_OPENGL_ES_DRIVER")]
        public const string HintOpenglESDriver = unchecked((string) "SDL_OPENGL_ES_DRIVER");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_ORIENTATIONS")]
        public const string HintOrientations = unchecked((string) "SDL_IOS_ORIENTATIONS");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_POLL_SENTINEL")]
        public const string HintPollSentinel = unchecked((string) "SDL_POLL_SENTINEL");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_PREFERRED_LOCALES")]
        public const string HintPreferredLocales = unchecked((string) "SDL_PREFERRED_LOCALES");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_QTWAYLAND_CONTENT_ORIENTATION")]
        public const string HintQtwaylandContentOrientation = unchecked((string) "SDL_QTWAYLAND_CONTENT_ORIENTATION");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_QTWAYLAND_WINDOW_FLAGS")]
        public const string HintQtwaylandWindowFlags = unchecked((string) "SDL_QTWAYLAND_WINDOW_FLAGS");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_RENDER_BATCHING")]
        public const string HintRenderBatching = unchecked((string) "SDL_RENDER_BATCHING");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_RENDER_LINE_METHOD")]
        public const string HintRenderLineMethod = unchecked((string) "SDL_RENDER_LINE_METHOD");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_RENDER_DIRECT3D11_DEBUG")]
        public const string HintRenderDirect3D11Debug = unchecked((string) "SDL_RENDER_DIRECT3D11_DEBUG");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_RENDER_DIRECT3D_THREADSAFE")]
        public const string HintRenderDirect3DThreadsafe = unchecked((string) "SDL_RENDER_DIRECT3D_THREADSAFE");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_RENDER_DRIVER")]
        public const string HintRenderDriver = unchecked((string) "SDL_RENDER_DRIVER");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_RENDER_LOGICAL_SIZE_MODE")]
        public const string HintRenderLogicalSizeMode = unchecked((string) "SDL_RENDER_LOGICAL_SIZE_MODE");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_RENDER_OPENGL_SHADERS")]
        public const string HintRenderOpenglShaders = unchecked((string) "SDL_RENDER_OPENGL_SHADERS");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_RENDER_SCALE_QUALITY")]
        public const string HintRenderScaleQuality = unchecked((string) "SDL_RENDER_SCALE_QUALITY");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_RENDER_VSYNC")]
        public const string HintRenderVsync = unchecked((string) "SDL_RENDER_VSYNC");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_PS2_DYNAMIC_VSYNC")]
        public const string HintPS2DynamicVsync = unchecked((string) "SDL_PS2_DYNAMIC_VSYNC");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_RETURN_KEY_HIDES_IME")]
        public const string HintReturnKeyHidesIme = unchecked((string) "SDL_RETURN_KEY_HIDES_IME");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_RPI_VIDEO_LAYER")]
        public const string HintRpiVideoLayer = unchecked((string) "SDL_RPI_VIDEO_LAYER");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_SCREENSAVER_INHIBIT_ACTIVITY_NAME")]
        public const string HintScreensaverInhibitActivityName = unchecked((string) "SDL_SCREENSAVER_INHIBIT_ACTIVITY_NAME");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_THREAD_FORCE_REALTIME_TIME_CRITICAL")]
        public const string HintThreadForceRealtimeTimeCritical = unchecked((string) "SDL_THREAD_FORCE_REALTIME_TIME_CRITICAL");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_THREAD_PRIORITY_POLICY")]
        public const string HintThreadPriorityPolicy = unchecked((string) "SDL_THREAD_PRIORITY_POLICY");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_THREAD_STACK_SIZE")]
        public const string HintThreadStackSize = unchecked((string) "SDL_THREAD_STACK_SIZE");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_TIMER_RESOLUTION")]
        public const string HintTimerResolution = unchecked((string) "SDL_TIMER_RESOLUTION");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_TOUCH_MOUSE_EVENTS")]
        public const string HintTouchMouseEvents = unchecked((string) "SDL_TOUCH_MOUSE_EVENTS");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_VITA_TOUCH_MOUSE_DEVICE")]
        public const string HintVitaTouchMouseDevice = unchecked((string) "SDL_HINT_VITA_TOUCH_MOUSE_DEVICE");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_TV_REMOTE_AS_JOYSTICK")]
        public const string HintTVRemoteAsJoystick = unchecked((string) "SDL_TV_REMOTE_AS_JOYSTICK");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_VIDEO_ALLOW_SCREENSAVER")]
        public const string HintVideoAllowScreensaver = unchecked((string) "SDL_VIDEO_ALLOW_SCREENSAVER");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_VIDEO_DOUBLE_BUFFER")]
        public const string HintVideoDoubleBuffer = unchecked((string) "SDL_VIDEO_DOUBLE_BUFFER");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_VIDEO_EGL_ALLOW_TRANSPARENCY")]
        public const string HintVideoEglAllowTransparency = unchecked((string) "SDL_VIDEO_EGL_ALLOW_TRANSPARENCY");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_VIDEO_EXTERNAL_CONTEXT")]
        public const string HintVideoExternalContext = unchecked((string) "SDL_VIDEO_EXTERNAL_CONTEXT");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_VIDEO_HIGHDPI_DISABLED")]
        public const string HintVideoHighdpiDisabled = unchecked((string) "SDL_VIDEO_HIGHDPI_DISABLED");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_VIDEO_MAC_FULLSCREEN_SPACES")]
        public const string HintVideoMacFullscreenSpaces = unchecked((string) "SDL_VIDEO_MAC_FULLSCREEN_SPACES");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_VIDEO_MINIMIZE_ON_FOCUS_LOSS")]
        public const string HintVideoMinimizeOnFocusLoss = unchecked((string) "SDL_VIDEO_MINIMIZE_ON_FOCUS_LOSS");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_VIDEO_WAYLAND_ALLOW_LIBDECOR")]
        public const string HintVideoWaylandAllowLibdecor = unchecked((string) "SDL_VIDEO_WAYLAND_ALLOW_LIBDECOR");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_VIDEO_WAYLAND_PREFER_LIBDECOR")]
        public const string HintVideoWaylandPreferLibdecor = unchecked((string) "SDL_VIDEO_WAYLAND_PREFER_LIBDECOR");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_VIDEO_WAYLAND_MODE_EMULATION")]
        public const string HintVideoWaylandModeEmulation = unchecked((string) "SDL_VIDEO_WAYLAND_MODE_EMULATION");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_VIDEO_WAYLAND_EMULATE_MOUSE_WARP")]
        public const string HintVideoWaylandEmulateMouseWarp = unchecked((string) "SDL_VIDEO_WAYLAND_EMULATE_MOUSE_WARP");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_VIDEO_WINDOW_SHARE_PIXEL_FORMAT")]
        public const string HintVideoWindowSharePixelFormat = unchecked((string) "SDL_VIDEO_WINDOW_SHARE_PIXEL_FORMAT");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_VIDEO_FOREIGN_WINDOW_OPENGL")]
        public const string HintVideoForeignWindowOpengl = unchecked((string) "SDL_VIDEO_FOREIGN_WINDOW_OPENGL");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_VIDEO_FOREIGN_WINDOW_VULKAN")]
        public const string HintVideoForeignWindowVulkan = unchecked((string) "SDL_VIDEO_FOREIGN_WINDOW_VULKAN");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_VIDEO_WIN_D3DCOMPILER")]
        public const string HintVideoWinD3Dcompiler = unchecked((string) "SDL_VIDEO_WIN_D3DCOMPILER");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_VIDEO_X11_FORCE_EGL")]
        public const string HintVideoX11ForceEgl = unchecked((string) "SDL_VIDEO_X11_FORCE_EGL");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_VIDEO_X11_NET_WM_BYPASS_COMPOSITOR")]
        public const string HintVideoX11NetWMBypassCompositor = unchecked((string) "SDL_VIDEO_X11_NET_WM_BYPASS_COMPOSITOR");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_VIDEO_X11_NET_WM_PING")]
        public const string HintVideoX11NetWMPing = unchecked((string) "SDL_VIDEO_X11_NET_WM_PING");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_VIDEO_X11_WINDOW_VISUALID")]
        public const string HintVideoX11WindowVisualid = unchecked((string) "SDL_VIDEO_X11_WINDOW_VISUALID");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_VIDEO_X11_XINERAMA")]
        public const string HintVideoX11Xinerama = unchecked((string) "SDL_VIDEO_X11_XINERAMA");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_VIDEO_X11_XRANDR")]
        public const string HintVideoX11Xrandr = unchecked((string) "SDL_VIDEO_X11_XRANDR");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_VIDEO_X11_XVIDMODE")]
        public const string HintVideoX11Xvidmode = unchecked((string) "SDL_VIDEO_X11_XVIDMODE");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_WAVE_FACT_CHUNK")]
        public const string HintWaveFactChunk = unchecked((string) "SDL_WAVE_FACT_CHUNK");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_WAVE_RIFF_CHUNK_SIZE")]
        public const string HintWaveRiffChunkSize = unchecked((string) "SDL_WAVE_RIFF_CHUNK_SIZE");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_WAVE_TRUNCATION")]
        public const string HintWaveTruncation = unchecked((string) "SDL_WAVE_TRUNCATION");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_WINDOWS_DISABLE_THREAD_NAMING")]
        public const string HintWindowsDisableThreadNaming = unchecked((string) "SDL_WINDOWS_DISABLE_THREAD_NAMING");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_WINDOWS_ENABLE_MESSAGELOOP")]
        public const string HintWindowsEnableMessageloop = unchecked((string) "SDL_WINDOWS_ENABLE_MESSAGELOOP");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_WINDOWS_FORCE_MUTEX_CRITICAL_SECTIONS")]
        public const string HintWindowsForceMutexCriticalSections = unchecked((string) "SDL_WINDOWS_FORCE_MUTEX_CRITICAL_SECTIONS");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_WINDOWS_FORCE_SEMAPHORE_KERNEL")]
        public const string HintWindowsForceSemaphoreKernel = unchecked((string) "SDL_WINDOWS_FORCE_SEMAPHORE_KERNEL");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_WINDOWS_INTRESOURCE_ICON")]
        public const string HintWindowsIntresourceIcon = unchecked((string) "SDL_WINDOWS_INTRESOURCE_ICON");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_WINDOWS_INTRESOURCE_ICON_SMALL")]
        public const string HintWindowsIntresourceIconSmall = unchecked((string) "SDL_WINDOWS_INTRESOURCE_ICON_SMALL");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_WINDOWS_NO_CLOSE_ON_ALT_F4")]
        public const string HintWindowsNoCloseOnAltF4 = unchecked((string) "SDL_WINDOWS_NO_CLOSE_ON_ALT_F4");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_WINDOWS_USE_D3D9EX")]
        public const string HintWindowsUseD3D9EX = unchecked((string) "SDL_WINDOWS_USE_D3D9EX");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_WINDOWS_DPI_AWARENESS")]
        public const string HintWindowsDpiAwareness = unchecked((string) "SDL_WINDOWS_DPI_AWARENESS");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_WINDOWS_DPI_SCALING")]
        public const string HintWindowsDpiScaling = unchecked((string) "SDL_WINDOWS_DPI_SCALING");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_WINDOW_FRAME_USABLE_WHILE_CURSOR_HIDDEN")]
        public const string HintWindowFrameUsableWhileCursorHidden = unchecked((string) "SDL_WINDOW_FRAME_USABLE_WHILE_CURSOR_HIDDEN");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_WINDOW_NO_ACTIVATION_WHEN_SHOWN")]
        public const string HintWindowNoActivationWhenShown = unchecked((string) "SDL_WINDOW_NO_ACTIVATION_WHEN_SHOWN");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_WINRT_HANDLE_BACK_BUTTON")]
        public const string HintWinrtHandleBackButton = unchecked((string) "SDL_WINRT_HANDLE_BACK_BUTTON");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_WINRT_PRIVACY_POLICY_LABEL")]
        public const string HintWinrtPrivacyPolicyLabel = unchecked((string) "SDL_WINRT_PRIVACY_POLICY_LABEL");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_WINRT_PRIVACY_POLICY_URL")]
        public const string HintWinrtPrivacyPolicyUrl = unchecked((string) "SDL_WINRT_PRIVACY_POLICY_URL");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_X11_FORCE_OVERRIDE_REDIRECT")]
        public const string HintX11ForceOverrideRedirect = unchecked((string) "SDL_X11_FORCE_OVERRIDE_REDIRECT");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_XINPUT_ENABLED")]
        public const string HintXinputEnabled = unchecked((string) "SDL_XINPUT_ENABLED");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_DIRECTINPUT_ENABLED")]
        public const string HintDirectinputEnabled = unchecked((string) "SDL_DIRECTINPUT_ENABLED");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_XINPUT_USE_OLD_JOYSTICK_MAPPING")]
        public const string HintXinputUseOldJoystickMapping = unchecked((string) "SDL_XINPUT_USE_OLD_JOYSTICK_MAPPING");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_AUDIO_INCLUDE_MONITORS")]
        public const string HintAudioIncludeMonitors = unchecked((string) "SDL_AUDIO_INCLUDE_MONITORS");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_X11_WINDOW_TYPE")]
        public const string HintX11WindowType = unchecked((string) "SDL_X11_WINDOW_TYPE");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_QUIT_ON_LAST_WINDOW_CLOSE")]
        public const string HintQuitOnLastWindowClose = unchecked((string) "SDL_QUIT_ON_LAST_WINDOW_CLOSE");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_VIDEODRIVER")]
        public const string HintVideodriver = unchecked((string) "SDL_VIDEODRIVER");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_AUDIODRIVER")]
        public const string HintAudiodriver = unchecked((string) "SDL_AUDIODRIVER");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_KMSDRM_DEVICE_INDEX")]
        public const string HintKmsdrmDeviceIndex = unchecked((string) "SDL_KMSDRM_DEVICE_INDEX");
        [NativeName("Type", "")]
        [NativeName("Name", "SDL_HINT_TRACKPAD_IS_TOUCH_ONLY")]
        public const string HintTrackpadIsTouchOnly = unchecked((string) "SDL_TRACKPAD_IS_TOUCH_ONLY");
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_MAX_LOG_MESSAGE")]
        public const int MaxLogMessage = unchecked((int) 0x1000);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_ANDROID_EXTERNAL_STORAGE_READ")]
        public const int AndroidExternalStorageRead = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_ANDROID_EXTERNAL_STORAGE_WRITE")]
        public const int AndroidExternalStorageWrite = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_MAJOR_VERSION")]
        public const int MajorVersion = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_MINOR_VERSION")]
        public const int MinorVersion = unchecked((int) 0x1A);
        [NativeName("Type", "int")]
        [NativeName("Name", "SDL_PATCHLEVEL")]
        public const int Patchlevel = unchecked((int) 0x5);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "SDL_INIT_TIMER")]
        public const uint InitTimer = unchecked((uint) 0x1);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "SDL_INIT_AUDIO")]
        public const uint InitAudio = unchecked((uint) 0x10);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "SDL_INIT_VIDEO")]
        public const uint InitVideo = unchecked((uint) 0x20);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "SDL_INIT_JOYSTICK")]
        public const uint InitJoystick = unchecked((uint) 0x200);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "SDL_INIT_HAPTIC")]
        public const uint InitHaptic = unchecked((uint) 0x1000);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "SDL_INIT_GAMECONTROLLER")]
        public const uint InitGamecontroller = unchecked((uint) 0x2000);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "SDL_INIT_EVENTS")]
        public const uint InitEvents = unchecked((uint) 0x4000);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "SDL_INIT_SENSOR")]
        public const uint InitSensor = unchecked((uint) 0x8000);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "SDL_INIT_NOPARACHUTE")]
        public const uint InitNoparachute = unchecked((uint) 0x100000);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 251, Column 38 in SDL_platform.h")]
        [NativeApi(EntryPoint = "SDL_GetPlatform")]
        public unsafe partial byte* GetPlatform();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 439, Column 31 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_malloc")]
        public unsafe partial void* Malloc(nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 440, Column 31 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_calloc")]
        public unsafe partial void* Calloc(nuint nmemb, nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 441, Column 31 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_realloc")]
        public unsafe partial void* Realloc(void* mem, nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 442, Column 30 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_free")]
        public unsafe partial void Free(void* mem);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_GetOriginalMemoryFunctions")]
        public unsafe partial void GetOriginalMemoryFunctions(PfnMallocFunc* malloc_func, PfnCallocFunc* calloc_func, PfnReallocFunc* realloc_func, PfnFreeFunc* free_func);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 464, Column 30 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_GetMemoryFunctions")]
        public unsafe partial void GetMemoryFunctions(PfnMallocFunc* malloc_func, PfnCallocFunc* calloc_func, PfnReallocFunc* realloc_func, PfnFreeFunc* free_func);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 474, Column 29 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_SetMemoryFunctions")]
        public partial int SetMemoryFunctions(PfnMallocFunc malloc_func, PfnCallocFunc calloc_func, PfnReallocFunc realloc_func, PfnFreeFunc free_func);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 484, Column 29 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_GetNumAllocations")]
        public partial int GetNumAllocations();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 486, Column 31 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_getenv")]
        public unsafe partial byte* Getenv([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 487, Column 29 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_setenv")]
        public unsafe partial int Setenv([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* value, int overwrite);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 489, Column 30 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_qsort")]
        public unsafe partial void Qsort(void* @base, nuint nmemb, nuint size, PfnVvVvI compare);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 490, Column 32 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_bsearch")]
        public unsafe partial void* Bsearch([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* @base, nuint nmemb, nuint size, PfnVvVvI compare);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 492, Column 29 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_abs")]
        public partial int Abs(int x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 499, Column 29 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_isalpha")]
        public partial int Isalpha(int x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 500, Column 29 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_isalnum")]
        public partial int Isalnum(int x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 501, Column 29 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_isblank")]
        public partial int Isblank(int x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 29 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iscntrl")]
        public partial int Iscntrl(int x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 503, Column 29 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_isdigit")]
        public partial int Isdigit(int x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 504, Column 29 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_isxdigit")]
        public partial int Isxdigit(int x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 505, Column 29 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_ispunct")]
        public partial int Ispunct(int x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 506, Column 29 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_isspace")]
        public partial int Isspace(int x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 507, Column 29 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_isupper")]
        public partial int Isupper(int x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 508, Column 29 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_islower")]
        public partial int Islower(int x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 509, Column 29 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_isprint")]
        public partial int Isprint(int x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 510, Column 29 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_isgraph")]
        public partial int Isgraph(int x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 511, Column 29 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_toupper")]
        public partial int Toupper(int x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 512, Column 29 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_tolower")]
        public partial int Tolower(int x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 514, Column 32 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_crc16")]
        public unsafe partial ushort Crc16(ushort crc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 515, Column 32 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_crc32")]
        public unsafe partial uint Crc32(uint crc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 517, Column 31 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_memset")]
        public unsafe partial void* Memset(void* dst, int c, nuint len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 559, Column 31 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_memcpy")]
        public unsafe partial void* Memcpy(void* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* src, nuint len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 561, Column 31 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_memmove")]
        public unsafe partial void* Memmove(void* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* src, nuint len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 562, Column 29 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_memcmp")]
        public unsafe partial int Memcmp([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* s1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* s2, nuint len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 564, Column 32 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcslen")]
        public unsafe partial nuint Wcslen([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* wstr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 565, Column 32 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcslcpy")]
        public unsafe partial nuint Wcslcpy(char* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* src, nuint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 566, Column 32 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcslcat")]
        public unsafe partial nuint Wcslcat(char* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* src, nuint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 34 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcsdup")]
        public unsafe partial char* Wcsdup([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* wstr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 568, Column 34 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcsstr")]
        public unsafe partial char* Wcsstr([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* haystack, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* needle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 570, Column 29 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcscmp")]
        public unsafe partial int Wcscmp([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* str1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* str2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 571, Column 29 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcsncmp")]
        public unsafe partial int Wcsncmp([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* str1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* str2, nuint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 572, Column 29 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcscasecmp")]
        public unsafe partial int Wcscasecmp([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* str1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* str2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 573, Column 29 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_wcsncasecmp")]
        public unsafe partial int Wcsncasecmp([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* str1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* str2, nuint len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 575, Column 32 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strlen")]
        public unsafe partial nuint Strlen([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* str);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 576, Column 32 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strlcpy")]
        public unsafe partial nuint Strlcpy(byte* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* src, nuint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 577, Column 32 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_utf8strlcpy")]
        public unsafe partial nuint Utf8strlcpy(byte* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* src, nuint dst_bytes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 578, Column 32 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strlcat")]
        public unsafe partial nuint Strlcat(byte* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* src, nuint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 579, Column 31 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strdup")]
        public unsafe partial byte* Strdup([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* str);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 580, Column 31 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strrev")]
        public unsafe partial byte* Strrev(byte* str);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 581, Column 31 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strupr")]
        public unsafe partial byte* Strupr(byte* str);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 582, Column 31 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strlwr")]
        public unsafe partial byte* Strlwr(byte* str);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 583, Column 31 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strchr")]
        public unsafe partial byte* Strchr([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* str, int c);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 584, Column 31 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strrchr")]
        public unsafe partial byte* Strrchr([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* str, int c);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 585, Column 31 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strstr")]
        public unsafe partial byte* Strstr([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* haystack, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* needle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 586, Column 31 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strcasestr")]
        public unsafe partial byte* Strcasestr([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* haystack, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* needle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 587, Column 31 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtokr")]
        public unsafe partial byte* Strtokr(byte* s1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* s2, byte** saveptr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 588, Column 32 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_utf8strlen")]
        public unsafe partial nuint Utf8strlen([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* str);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 589, Column 32 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_utf8strnlen")]
        public unsafe partial nuint Utf8strnlen([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* str, nuint bytes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 591, Column 31 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_itoa")]
        public unsafe partial byte* Itoa(int value, byte* str, int radix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 592, Column 31 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_uitoa")]
        public unsafe partial byte* Uitoa(uint value, byte* str, int radix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 593, Column 31 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_ltoa")]
        public unsafe partial byte* Ltoa(int value, byte* str, int radix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 594, Column 31 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_ultoa")]
        public unsafe partial byte* Ultoa(uint value, byte* str, int radix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 595, Column 31 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_lltoa")]
        public unsafe partial byte* Lltoa(long value, byte* str, int radix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 596, Column 31 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_ulltoa")]
        public unsafe partial byte* Ulltoa(ulong value, byte* str, int radix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 598, Column 29 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_atoi")]
        public unsafe partial int Atoi([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* str);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 599, Column 32 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_atof")]
        public unsafe partial double Atof([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* str);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 600, Column 30 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtol")]
        public unsafe partial int Strtol([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* str, byte** endp, int @base);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 601, Column 39 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtoul")]
        public unsafe partial uint Strtoul([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* str, byte** endp, int @base);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 602, Column 32 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtoll")]
        public unsafe partial long Strtoll([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* str, byte** endp, int @base);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 603, Column 32 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtoull")]
        public unsafe partial ulong Strtoull([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* str, byte** endp, int @base);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 604, Column 32 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strtod")]
        public unsafe partial double Strtod([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* str, byte** endp);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 606, Column 29 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strcmp")]
        public unsafe partial int Strcmp([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* str1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* str2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 607, Column 29 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strncmp")]
        public unsafe partial int Strncmp([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* str1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* str2, nuint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 608, Column 29 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strcasecmp")]
        public unsafe partial int Strcasecmp([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* str1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* str2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 609, Column 29 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_strncasecmp")]
        public unsafe partial int Strncasecmp([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* str1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* str2, nuint len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 611, Column 29 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_sscanf")]
        public unsafe partial int Sscanf([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* text, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fmt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 612, Column 29 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsscanf")]
        public unsafe partial int Vsscanf([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* text, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fmt, byte* ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 613, Column 29 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_snprintf")]
        public unsafe partial int Snprintf(byte* text, nuint maxlen, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fmt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 614, Column 29 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vsnprintf")]
        public unsafe partial int Vsnprintf(byte* text, nuint maxlen, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fmt, byte* ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 615, Column 29 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_asprintf")]
        public unsafe partial int Asprintf(byte** strp, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fmt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 616, Column 29 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_vasprintf")]
        public unsafe partial int Vasprintf(byte** strp, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fmt, byte* ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 638, Column 32 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_acos")]
        public partial double Acos(double x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 31 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_acosf")]
        public partial float Acosf(float x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 640, Column 32 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_asin")]
        public partial double Asin(double x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 641, Column 31 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_asinf")]
        public partial float Asinf(float x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 642, Column 32 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_atan")]
        public partial double Atan(double x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 643, Column 31 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_atanf")]
        public partial float Atanf(float x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 644, Column 32 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_atan2")]
        public partial double Atan2(double y, double x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 645, Column 31 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_atan2f")]
        public partial float Atan2f(float y, float x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 646, Column 32 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_ceil")]
        public partial double Ceil(double x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 647, Column 31 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_ceilf")]
        public partial float Ceilf(float x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 648, Column 32 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_copysign")]
        public partial double Copysign(double x, double y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 649, Column 31 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_copysignf")]
        public partial float Copysignf(float x, float y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 650, Column 32 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_cos")]
        public partial double Cos(double x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 651, Column 31 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_cosf")]
        public partial float Cosf(float x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 652, Column 32 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_exp")]
        public partial double Exp(double x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 653, Column 31 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_expf")]
        public partial float Expf(float x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 654, Column 32 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_fabs")]
        public partial double Fabs(double x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 655, Column 31 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_fabsf")]
        public partial float Fabsf(float x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 656, Column 32 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_floor")]
        public partial double Floor(double x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 657, Column 31 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_floorf")]
        public partial float Floorf(float x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 658, Column 32 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_trunc")]
        public partial double Trunc(double x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 659, Column 31 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_truncf")]
        public partial float Truncf(float x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 660, Column 32 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_fmod")]
        public partial double Fmod(double x, double y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 661, Column 31 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_fmodf")]
        public partial float Fmodf(float x, float y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 662, Column 32 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_log")]
        public partial double Log(double x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 663, Column 31 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_logf")]
        public partial float Logf(float x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 664, Column 32 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_log10")]
        public partial double Log10(double x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 665, Column 31 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_log10f")]
        public partial float Log10f(float x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 666, Column 32 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_pow")]
        public partial double Pow(double x, double y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 667, Column 31 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_powf")]
        public partial float Powf(float x, float y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 668, Column 32 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_round")]
        public partial double Round(double x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 669, Column 31 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_roundf")]
        public partial float Roundf(float x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 670, Column 30 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_lround")]
        public partial int Lround(double x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 671, Column 30 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_lroundf")]
        public partial int Lroundf(float x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 672, Column 32 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_scalbn")]
        public partial double Scalbn(double x, int n);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 673, Column 31 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_scalbnf")]
        public partial float Scalbnf(float x, int n);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 674, Column 32 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_sin")]
        public partial double Sin(double x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 675, Column 31 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_sinf")]
        public partial float Sinf(float x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 676, Column 32 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_sqrt")]
        public partial double Sqrt(double x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 677, Column 31 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_sqrtf")]
        public partial float Sqrtf(float x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 678, Column 32 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_tan")]
        public partial double Tan(double x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 679, Column 31 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_tanf")]
        public partial float Tanf(float x);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 689, Column 37 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_open")]
        public unsafe partial Icon* IconvOpen([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* tocode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fromcode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 691, Column 29 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_close")]
        public unsafe partial int IconvClose(Icon* cd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 692, Column 32 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv")]
        public unsafe partial nuint Iconv(Icon* cd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** inbuf, nuint* inbytesleft, byte** outbuf, nuint* outbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 702, Column 31 in SDL_stdinc.h")]
        [NativeApi(EntryPoint = "SDL_iconv_string")]
        public unsafe partial byte* IconvString([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* tocode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fromcode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* inbuf, nuint inbytesleft);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 361, Column 37 in SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetPixelFormatName")]
        public unsafe partial byte* GetPixelFormatName(uint format);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 379, Column 34 in SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_PixelFormatEnumToMasks")]
        public unsafe partial SdlBool PixelFormatEnumToMasks(uint format, int* bpp, uint* Rmask, uint* Gmask, uint* Bmask, uint* Amask);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 403, Column 32 in SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_MasksToPixelFormatEnum")]
        public partial uint MasksToPixelFormatEnum(int bpp, uint Rmask, uint Gmask, uint Bmask, uint Amask);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 424, Column 43 in SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_AllocFormat")]
        public unsafe partial PixelFormat* AllocFormat(uint pixel_format);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 435, Column 30 in SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_FreeFormat")]
        public unsafe partial void FreeFormat(PixelFormat* format);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 451, Column 38 in SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_AllocPalette")]
        public unsafe partial Palette* AllocPalette(int ncolors);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 466, Column 29 in SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_SetPixelFormatPalette")]
        public unsafe partial int SetPixelFormatPalette(PixelFormat* format, Palette* palette);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 484, Column 29 in SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_SetPaletteColors")]
        public unsafe partial int SetPaletteColors(Palette* palette, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Color* colors, int firstcolor, int ncolors);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 497, Column 30 in SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_FreePalette")]
        public unsafe partial void FreePalette(Palette* palette);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 529, Column 32 in SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_MapRGB")]
        public unsafe partial uint MapRGB([Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, byte r, byte g, byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 564, Column 32 in SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_MapRGBA")]
        public unsafe partial uint MapRGBA([Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, byte r, byte g, byte b, byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 589, Column 30 in SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGB")]
        public unsafe partial void GetRGB(uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, byte* r, byte* g, byte* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 618, Column 30 in SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_GetRGBA")]
        public unsafe partial void GetRGBA(uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, byte* r, byte* g, byte* b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 633, Column 30 in SDL_pixels.h")]
        [NativeApi(EntryPoint = "SDL_CalculateGammaRamp")]
        public unsafe partial void CalculateGammaRamp(float gamma, ushort* ramp);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 66, Column 29 in SDL_error.h")]
        [NativeApi(EntryPoint = "SDL_SetError")]
        public unsafe partial int SetError([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fmt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 103, Column 37 in SDL_error.h")]
        [NativeApi(EntryPoint = "SDL_GetError")]
        public unsafe partial byte* GetError();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 120, Column 32 in SDL_error.h")]
        [NativeApi(EntryPoint = "SDL_GetErrorMsg")]
        public unsafe partial byte* GetErrorMsg(byte* errstr, int maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 130, Column 30 in SDL_error.h")]
        [NativeApi(EntryPoint = "SDL_ClearError")]
        public partial void ClearError();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 152, Column 29 in SDL_error.h")]
        [NativeApi(EntryPoint = "SDL_Error")]
        public partial int Error(Errorcode code);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 34 in SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_HasIntersection")]
        public unsafe partial SdlBool HasIntersection([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* A, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* B);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 34 in SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_IntersectRect")]
        public unsafe partial SdlBool IntersectRect([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* A, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* B, Silk.NET.Maths.Rectangle<int>* result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 178, Column 30 in SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_UnionRect")]
        public unsafe partial void UnionRect([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* A, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* B, Silk.NET.Maths.Rectangle<int>* result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 199, Column 34 in SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_EnclosePoints")]
        public unsafe partial SdlBool EnclosePoints([Flow(Silk.NET.Core.Native.FlowDirection.In)] Point* points, int count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* clip, Silk.NET.Maths.Rectangle<int>* result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 222, Column 34 in SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_IntersectRectAndLine")]
        public unsafe partial SdlBool IntersectRectAndLine([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect, int* X1, int* Y1, int* X2, int* Y2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 34 in SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_HasIntersectionF")]
        public unsafe partial SdlBool HasIntersectionF([Flow(Silk.NET.Core.Native.FlowDirection.In)] FRect* A, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FRect* B);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 303, Column 34 in SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_IntersectFRect")]
        public unsafe partial SdlBool IntersectFRect([Flow(Silk.NET.Core.Native.FlowDirection.In)] FRect* A, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FRect* B, FRect* result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 317, Column 30 in SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_UnionFRect")]
        public unsafe partial void UnionFRect([Flow(Silk.NET.Core.Native.FlowDirection.In)] FRect* A, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FRect* B, FRect* result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 339, Column 34 in SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_EncloseFPoints")]
        public unsafe partial SdlBool EncloseFPoints([Flow(Silk.NET.Core.Native.FlowDirection.In)] FPoint* points, int count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FRect* clip, FRect* result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 363, Column 34 in SDL_rect.h")]
        [NativeApi(EntryPoint = "SDL_IntersectFRectAndLine")]
        public unsafe partial SdlBool IntersectFRectAndLine([Flow(Silk.NET.Core.Native.FlowDirection.In)] FRect* rect, float* X1, float* Y1, float* X2, float* Y2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 183, Column 39 in SDL_blendmode.h")]
        [NativeApi(EntryPoint = "SDL_ComposeCustomBlendMode")]
        public partial BlendMode ComposeCustomBlendMode(BlendFactor srcColorFactor, BlendFactor dstColorFactor, BlendOperation colorOperation, BlendFactor srcAlphaFactor, BlendFactor dstAlphaFactor, BlendOperation alphaOperation);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 160, Column 38 in SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_CreateRGBSurface")]
        public unsafe partial Surface* CreateRGBSurface(uint flags, int width, int height, int depth, uint Rmask, uint Gmask, uint Bmask, uint Amask);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 188, Column 38 in SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_CreateRGBSurfaceWithFormat")]
        public unsafe partial Surface* CreateRGBSurfaceWithFormat(uint flags, int width, int height, int depth, uint format);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 219, Column 38 in SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_CreateRGBSurfaceFrom")]
        public unsafe partial Surface* CreateRGBSurfaceFrom(void* pixels, int width, int height, int depth, int pitch, uint Rmask, uint Gmask, uint Bmask, uint Amask);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 257, Column 38 in SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_CreateRGBSurfaceWithFormatFrom")]
        public unsafe partial Surface* CreateRGBSurfaceWithFormatFrom(void* pixels, int width, int height, int depth, int pitch, uint format);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 274, Column 30 in SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_FreeSurface")]
        public unsafe partial void FreeSurface(Surface* surface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 29 in SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SetSurfacePalette")]
        public unsafe partial int SetSurfacePalette(Surface* surface, Palette* palette);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 312, Column 29 in SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_LockSurface")]
        public unsafe partial int LockSurface(Surface* surface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 323, Column 30 in SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_UnlockSurface")]
        public unsafe partial void UnlockSurface(Surface* surface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 347, Column 38 in SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_LoadBMP_RW")]
        public unsafe partial Surface* LoadBMPRW(RWops* src, int freesrc);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 377, Column 29 in SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SaveBMP_RW")]
        public unsafe partial int SaveBMPRW(Surface* surface, RWops* dst, int freedst);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 405, Column 29 in SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SetSurfaceRLE")]
        public unsafe partial int SetSurfaceRLE(Surface* surface, int flag);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 420, Column 34 in SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_HasSurfaceRLE")]
        public unsafe partial SdlBool HasSurfaceRLE(Surface* surface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 446, Column 29 in SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SetColorKey")]
        public unsafe partial int SetColorKey(Surface* surface, int flag, uint key);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 462, Column 34 in SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_HasColorKey")]
        public unsafe partial SdlBool HasColorKey(Surface* surface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 482, Column 29 in SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetColorKey")]
        public unsafe partial int GetColorKey(Surface* surface, uint* key);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 506, Column 29 in SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SetSurfaceColorMod")]
        public unsafe partial int SetSurfaceColorMod(Surface* surface, byte r, byte g, byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 525, Column 29 in SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceColorMod")]
        public unsafe partial int GetSurfaceColorMod(Surface* surface, byte* r, byte* g, byte* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 547, Column 29 in SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SetSurfaceAlphaMod")]
        public unsafe partial int SetSurfaceAlphaMod(Surface* surface, byte alpha);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 563, Column 29 in SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceAlphaMod")]
        public unsafe partial int GetSurfaceAlphaMod(Surface* surface, byte* alpha);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 582, Column 29 in SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SetSurfaceBlendMode")]
        public unsafe partial int SetSurfaceBlendMode(Surface* surface, BlendMode blendMode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 597, Column 29 in SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetSurfaceBlendMode")]
        public unsafe partial int GetSurfaceBlendMode(Surface* surface, BlendMode* blendMode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 620, Column 34 in SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SetClipRect")]
        public unsafe partial SdlBool SetClipRect(Surface* surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 30 in SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetClipRect")]
        public unsafe partial void GetClipRect(Surface* surface, Silk.NET.Maths.Rectangle<int>* rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 651, Column 38 in SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_DuplicateSurface")]
        public unsafe partial Surface* DuplicateSurface(Surface* surface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 675, Column 38 in SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_ConvertSurface")]
        public unsafe partial Surface* ConvertSurface(Surface* src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* fmt, uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 700, Column 38 in SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_ConvertSurfaceFormat")]
        public unsafe partial Surface* ConvertSurfaceFormat(Surface* src, uint pixel_format, uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 719, Column 29 in SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_ConvertPixels")]
        public unsafe partial int ConvertPixels(int width, int height, uint src_format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* src, int src_pitch, uint dst_format, void* dst, int dst_pitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 745, Column 29 in SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_PremultiplyAlpha")]
        public unsafe partial int PremultiplyAlpha(int width, int height, uint src_format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* src, int src_pitch, uint dst_format, void* dst, int dst_pitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 774, Column 29 in SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_FillRect")]
        public unsafe partial int FillRect(Surface* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect, uint color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 800, Column 29 in SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_FillRects")]
        public unsafe partial int FillRects(Surface* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rects, int count, uint color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 873, Column 29 in SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_UpperBlit")]
        public unsafe partial int UpperBlit(Surface* src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, Silk.NET.Maths.Rectangle<int>* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 899, Column 29 in SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_LowerBlit")]
        public unsafe partial int LowerBlit(Surface* src, Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, Silk.NET.Maths.Rectangle<int>* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 912, Column 29 in SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SoftStretch")]
        public unsafe partial int SoftStretch(Surface* src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 922, Column 29 in SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SoftStretchLinear")]
        public unsafe partial int SoftStretchLinear(Surface* src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 940, Column 29 in SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_UpperBlitScaled")]
        public unsafe partial int UpperBlitScaled(Surface* src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, Silk.NET.Maths.Rectangle<int>* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 963, Column 29 in SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_LowerBlitScaled")]
        public unsafe partial int LowerBlitScaled(Surface* src, Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, Silk.NET.Maths.Rectangle<int>* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 972, Column 30 in SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_SetYUVConversionMode")]
        public partial void SetYUVConversionMode(YUVCONVERSIONMODE mode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 979, Column 49 in SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetYUVConversionMode")]
        public partial YUVCONVERSIONMODE GetYUVConversionMode();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 987, Column 49 in SDL_surface.h")]
        [NativeApi(EntryPoint = "SDL_GetYUVConversionModeForResolution")]
        public partial YUVCONVERSIONMODE GetYUVConversionModeForResolution(int width, int height);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 294, Column 29 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetNumVideoDrivers")]
        public partial int GetNumVideoDrivers();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 309, Column 37 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetVideoDriver")]
        public unsafe partial byte* GetVideoDriver(int index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 340, Column 29 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_VideoInit")]
        public unsafe partial int VideoInit([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* driver_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 351, Column 30 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_VideoQuit")]
        public partial void VideoQuit();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 364, Column 37 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetCurrentVideoDriver")]
        public unsafe partial byte* GetCurrentVideoDriver();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 376, Column 29 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetNumVideoDisplays")]
        public partial int GetNumVideoDisplays();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 390, Column 38 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetDisplayName")]
        public unsafe partial byte* GetDisplayName(int displayIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 406, Column 29 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetDisplayBounds")]
        public unsafe partial int GetDisplayBounds(int displayIndex, Silk.NET.Maths.Rectangle<int>* rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 437, Column 29 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetDisplayUsableBounds")]
        public unsafe partial int GetDisplayUsableBounds(int displayIndex, Silk.NET.Maths.Rectangle<int>* rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 472, Column 29 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetDisplayDPI")]
        public unsafe partial int GetDisplayDPI(int displayIndex, float* ddpi, float* hdpi, float* vdpi);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 485, Column 48 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetDisplayOrientation")]
        public partial DisplayOrientation GetDisplayOrientation(int displayIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 29 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetNumDisplayModes")]
        public partial int GetNumDisplayModes(int displayIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 526, Column 29 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetDisplayMode")]
        public unsafe partial int GetDisplayMode(int displayIndex, int modeIndex, DisplayMode* mode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 549, Column 29 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetDesktopDisplayMode")]
        public unsafe partial int GetDesktopDisplayMode(int displayIndex, DisplayMode* mode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 572, Column 29 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetCurrentDisplayMode")]
        public unsafe partial int GetCurrentDisplayMode(int displayIndex, DisplayMode* mode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 598, Column 43 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetClosestDisplayMode")]
        public unsafe partial DisplayMode* GetClosestDisplayMode(int displayIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DisplayMode* mode, DisplayMode* closest);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 612, Column 29 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetPointDisplayIndex")]
        public unsafe partial int GetPointDisplayIndex([Flow(Silk.NET.Core.Native.FlowDirection.In)] Point* point);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 627, Column 29 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetRectDisplayIndex")]
        public unsafe partial int GetRectDisplayIndex([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 642, Column 29 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowDisplayIndex")]
        public unsafe partial int GetWindowDisplayIndex(Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 663, Column 29 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowDisplayMode")]
        public unsafe partial int SetWindowDisplayMode(Window* window, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DisplayMode* mode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 680, Column 29 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowDisplayMode")]
        public unsafe partial int GetWindowDisplayMode(Window* window, DisplayMode* mode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 695, Column 31 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowICCProfile")]
        public unsafe partial void* GetWindowICCProfile(Window* window, nuint* size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 707, Column 32 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowPixelFormat")]
        public unsafe partial uint GetWindowPixelFormat(Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 780, Column 38 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_CreateWindow")]
        public unsafe partial Window* CreateWindow([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* title, int x, int y, int w, int h, uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 801, Column 38 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_CreateWindowFrom")]
        public unsafe partial Window* CreateWindowFrom([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 817, Column 32 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowID")]
        public unsafe partial uint GetWindowID(Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 833, Column 38 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowFromID")]
        public unsafe partial Window* GetWindowFromID(uint id);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 851, Column 32 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowFlags")]
        public unsafe partial uint GetWindowFlags(Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 865, Column 30 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowTitle")]
        public unsafe partial void SetWindowTitle(Window* window, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* title);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 879, Column 37 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowTitle")]
        public unsafe partial byte* GetWindowTitle(Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 889, Column 30 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowIcon")]
        public unsafe partial void SetWindowIcon(Window* window, Surface* icon);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 906, Column 31 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowData")]
        public unsafe partial void* SetWindowData(Window* window, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 921, Column 31 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowData")]
        public unsafe partial void* GetWindowData(Window* window, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 939, Column 30 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowPosition")]
        public unsafe partial void SetWindowPosition(Window* window, int x, int y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 958, Column 30 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowPosition")]
        public unsafe partial void GetWindowPosition(Window* window, int* x, int* y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 983, Column 30 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowSize")]
        public unsafe partial void SetWindowSize(Window* window, int w, int h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1010, Column 30 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowSize")]
        public unsafe partial void GetWindowSize(Window* window, int* w, int* h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1045, Column 29 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowBordersSize")]
        public unsafe partial int GetWindowBordersSize(Window* window, int* top, int* left, int* bottom, int* right);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1067, Column 30 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowSizeInPixels")]
        public unsafe partial void GetWindowSizeInPixels(Window* window, int* w, int* h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1082, Column 30 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowMinimumSize")]
        public unsafe partial void SetWindowMinimumSize(Window* window, int min_w, int min_h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1099, Column 30 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowMinimumSize")]
        public unsafe partial void GetWindowMinimumSize(Window* window, int* w, int* h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1114, Column 30 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowMaximumSize")]
        public unsafe partial void SetWindowMaximumSize(Window* window, int max_w, int max_h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1131, Column 30 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowMaximumSize")]
        public unsafe partial void GetWindowMaximumSize(Window* window, int* w, int* h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1150, Column 30 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowBordered")]
        public unsafe partial void SetWindowBordered(Window* window, SdlBool bordered);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1169, Column 30 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowResizable")]
        public unsafe partial void SetWindowResizable(Window* window, SdlBool resizable);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1186, Column 30 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowAlwaysOnTop")]
        public unsafe partial void SetWindowAlwaysOnTop(Window* window, SdlBool on_top);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1199, Column 30 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_ShowWindow")]
        public unsafe partial void ShowWindow(Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1210, Column 30 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_HideWindow")]
        public unsafe partial void HideWindow(Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1219, Column 30 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_RaiseWindow")]
        public unsafe partial void RaiseWindow(Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1231, Column 30 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_MaximizeWindow")]
        public unsafe partial void MaximizeWindow(Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1243, Column 30 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_MinimizeWindow")]
        public unsafe partial void MinimizeWindow(Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1255, Column 30 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_RestoreWindow")]
        public unsafe partial void RestoreWindow(Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1274, Column 29 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowFullscreen")]
        public unsafe partial int SetWindowFullscreen(Window* window, uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1300, Column 39 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowSurface")]
        public unsafe partial Surface* GetWindowSurface(Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1319, Column 29 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_UpdateWindowSurface")]
        public unsafe partial int UpdateWindowSurface(Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1341, Column 29 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_UpdateWindowSurfaceRects")]
        public unsafe partial int UpdateWindowSurfaceRects(Window* window, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rects, int numrects);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1363, Column 30 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowGrab")]
        public unsafe partial void SetWindowGrab(Window* window, SdlBool grabbed);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1394, Column 30 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowKeyboardGrab")]
        public unsafe partial void SetWindowKeyboardGrab(Window* window, SdlBool grabbed);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1411, Column 30 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowMouseGrab")]
        public unsafe partial void SetWindowMouseGrab(Window* window, SdlBool grabbed);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1424, Column 34 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowGrab")]
        public unsafe partial SdlBool GetWindowGrab(Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1437, Column 34 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowKeyboardGrab")]
        public unsafe partial SdlBool GetWindowKeyboardGrab(Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1450, Column 34 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowMouseGrab")]
        public unsafe partial SdlBool GetWindowMouseGrab(Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1462, Column 38 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetGrabbedWindow")]
        public unsafe partial Window* GetGrabbedWindow();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1481, Column 29 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowMouseRect")]
        public unsafe partial int SetWindowMouseRect(Window* window, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1494, Column 42 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowMouseRect")]
        public unsafe partial Silk.NET.Maths.Rectangle<int>* GetWindowMouseRect(Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1522, Column 29 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowBrightness")]
        public unsafe partial int SetWindowBrightness(Window* window, float brightness);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1541, Column 31 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowBrightness")]
        public unsafe partial float GetWindowBrightness(Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1560, Column 29 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowOpacity")]
        public unsafe partial int SetWindowOpacity(Window* window, float opacity);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1581, Column 29 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowOpacity")]
        public unsafe partial int GetWindowOpacity(Window* window, float* out_opacity);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1593, Column 29 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowModalFor")]
        public unsafe partial int SetWindowModalFor(Window* modal_window, Window* parent_window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1610, Column 29 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowInputFocus")]
        public unsafe partial int SetWindowInputFocus(Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1642, Column 29 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowGammaRamp")]
        public unsafe partial int SetWindowGammaRamp(Window* window, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* red, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* green, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* blue);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1670, Column 29 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GetWindowGammaRamp")]
        public unsafe partial int GetWindowGammaRamp(Window* window, ushort* red, ushort* green, ushort* blue);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1748, Column 29 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowHitTest")]
        public unsafe partial int SetWindowHitTest(Window* window, PfnHitTest callback, void* callback_data);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1762, Column 29 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_FlashWindow")]
        public unsafe partial int FlashWindow(Window* window, FlashOperation operation);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1777, Column 30 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_DestroyWindow")]
        public unsafe partial void DestroyWindow(Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1796, Column 34 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_IsScreenSaverEnabled")]
        public partial SdlBool IsScreenSaverEnabled();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1806, Column 30 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_EnableScreenSaver")]
        public partial void EnableScreenSaver();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1822, Column 30 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_DisableScreenSaver")]
        public partial void DisableScreenSaver();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1850, Column 29 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_LoadLibrary")]
        public unsafe partial int GLLoadLibrary([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1903, Column 31 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_GetProcAddress")]
        public unsafe partial void* GLGetProcAddress([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* proc);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1912, Column 30 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_UnloadLibrary")]
        public partial void GLUnloadLibrary();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1933, Column 34 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_ExtensionSupported")]
        public unsafe partial SdlBool GLExtensionSupported([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* extension);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 30 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_ResetAttributes")]
        public partial void GLResetAttributes();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1964, Column 29 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_SetAttribute")]
        public partial int GLSetAttribute(GLattr attr, int value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1979, Column 29 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_GetAttribute")]
        public unsafe partial int GLGetAttribute(GLattr attr, int* value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2001, Column 39 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_CreateContext")]
        public unsafe partial void* GLCreateContext(Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2018, Column 29 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_MakeCurrent")]
        public unsafe partial int GLMakeCurrent(Window* window, void* context);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2029, Column 37 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_GetCurrentWindow")]
        public unsafe partial Window* GLGetCurrentWindow();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2041, Column 39 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_GetCurrentContext")]
        public unsafe partial void* GLGetCurrentContext();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 30 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_GetDrawableSize")]
        public unsafe partial void GLGetDrawableSize(Window* window, int* w, int* h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2093, Column 29 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_SetSwapInterval")]
        public partial int GLSetSwapInterval(int interval);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2110, Column 29 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_GetSwapInterval")]
        public partial int GLGetSwapInterval();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2126, Column 30 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_SwapWindow")]
        public unsafe partial void GLSwapWindow(Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2137, Column 30 in SDL_video.h")]
        [NativeApi(EntryPoint = "SDL_GL_DeleteContext")]
        public unsafe partial void GLDeleteContext(void* context);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 109, Column 29 in SDL_vulkan.h")]
        [NativeApi(EntryPoint = "SDL_Vulkan_LoadLibrary")]
        public unsafe partial int VulkanLoadLibrary([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 121, Column 31 in SDL_vulkan.h")]
        [NativeApi(EntryPoint = "SDL_Vulkan_GetVkGetInstanceProcAddr")]
        public unsafe partial void* VulkanGetVkGetInstanceProcAddr();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 130, Column 30 in SDL_vulkan.h")]
        [NativeApi(EntryPoint = "SDL_Vulkan_UnloadLibrary")]
        public partial void VulkanUnloadLibrary();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 160, Column 34 in SDL_vulkan.h")]
        [NativeApi(EntryPoint = "SDL_Vulkan_GetInstanceExtensions")]
        public unsafe partial SdlBool VulkanGetInstanceExtensions(Window* window, uint* pCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** pNames);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 34 in SDL_vulkan.h")]
        [NativeApi(EntryPoint = "SDL_Vulkan_CreateSurface")]
        public unsafe partial SdlBool VulkanCreateSurface(Window* window, Silk.NET.Core.Native.VkHandle instance, Silk.NET.Core.Native.VkNonDispatchableHandle* surface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 204, Column 30 in SDL_vulkan.h")]
        [NativeApi(EntryPoint = "SDL_Vulkan_GetDrawableSize")]
        public unsafe partial void VulkanGetDrawableSize(Window* window, int* w, int* h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 171, Column 30 in SDL_main.h")]
        [NativeApi(EntryPoint = "SDL_SetMainReady")]
        public partial void SetMainReady();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 198, Column 29 in SDL_main.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "SDL_RegisterApp")]
        public unsafe partial int RegisterApp([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, uint style, void* hInst);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 215, Column 30 in SDL_main.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "SDL_UnregisterApp")]
        public partial void UnregisterApp();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 232, Column 29 in SDL_main.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "SDL_WinRTRunApp")]
        public unsafe partial int WinRTRunApp(PfnMainFunc mainFunction, void* reserved);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 248, Column 29 in SDL_main.h")]
        [NativeApi(EntryPoint = "SDL_UIKitRunApp")]
        public unsafe partial int UIKitRunApp(int argc, byte** argv, PfnMainFunc mainFunction);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 52, Column 25 in SDL_assert.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "__debugbreak")]
        public partial void Debugbreak();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 129, Column 41 in SDL_assert.h")]
        [NativeApi(EntryPoint = "SDL_ReportAssertion")]
        public unsafe partial AssertState ReportAssertion(AssertData* arg0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* arg1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* arg2, int arg3);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 220, Column 30 in SDL_assert.h")]
        [NativeApi(EntryPoint = "SDL_SetAssertionHandler")]
        public unsafe partial void SetAssertionHandler(PfnAssertionHandler handler, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 46 in SDL_assert.h")]
        [NativeApi(EntryPoint = "SDL_GetDefaultAssertionHandler")]
        public partial PfnAssertionHandler GetDefaultAssertionHandler();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 262, Column 46 in SDL_assert.h")]
        [NativeApi(EntryPoint = "SDL_GetAssertionHandler")]
        public unsafe partial PfnAssertionHandler GetAssertionHandler(void** puserdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 290, Column 48 in SDL_assert.h")]
        [NativeApi(EntryPoint = "SDL_GetAssertionReport")]
        public unsafe partial AssertData* GetAssertionReport();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 304, Column 30 in SDL_assert.h")]
        [NativeApi(EntryPoint = "SDL_ResetAssertionReport")]
        public partial void ResetAssertionReport();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 106, Column 34 in SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_AtomicTryLock")]
        public unsafe partial SdlBool AtomicTryLock(int* @lock);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 121, Column 30 in SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_AtomicLock")]
        public unsafe partial void AtomicLock(int* @lock);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 138, Column 30 in SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_AtomicUnlock")]
        public unsafe partial void AtomicUnlock(int* @lock);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 183, Column 30 in SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_MemoryBarrierReleaseFunction")]
        public partial void MemoryBarrierReleaseFunction();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 30 in SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_MemoryBarrierAcquireFunction")]
        public partial void MemoryBarrierAcquireFunction();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 283, Column 34 in SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_AtomicCAS")]
        public unsafe partial SdlBool AtomicCAS(AtomicT* a, int oldval, int newval);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 301, Column 29 in SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_AtomicSet")]
        public unsafe partial int AtomicSet(AtomicT* a, int v);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 316, Column 29 in SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_AtomicGet")]
        public unsafe partial int AtomicGet(AtomicT* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 335, Column 29 in SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_AtomicAdd")]
        public unsafe partial int AtomicAdd(AtomicT* a, int v);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 371, Column 34 in SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_AtomicCASPtr")]
        public unsafe partial SdlBool AtomicCASPtr(void** a, void* oldval, void* newval);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 388, Column 31 in SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_AtomicSetPtr")]
        public unsafe partial void* AtomicSetPtr(void** a, void* v);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 404, Column 31 in SDL_atomic.h")]
        [NativeApi(EntryPoint = "SDL_AtomicGetPtr")]
        public unsafe partial void* AtomicGetPtr(void** a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 81, Column 36 in SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_CreateMutex")]
        public unsafe partial Mutex* CreateMutex();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 99, Column 29 in SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_LockMutex")]
        public unsafe partial int LockMutex(Mutex* mutex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 122, Column 29 in SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_TryLockMutex")]
        public unsafe partial int TryLockMutex(Mutex* mutex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 141, Column 29 in SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_UnlockMutex")]
        public unsafe partial int UnlockMutex(Mutex* mutex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 162, Column 30 in SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_DestroyMutex")]
        public unsafe partial void DestroyMutex(Mutex* mutex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 198, Column 34 in SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_CreateSemaphore")]
        public unsafe partial Semaphore* CreateSemaphore(uint initial_value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 217, Column 30 in SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_DestroySemaphore")]
        public unsafe partial void DestroySemaphore(Semaphore* sem);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 244, Column 29 in SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_SemWait")]
        public unsafe partial int SemWait(Semaphore* sem);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 268, Column 29 in SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_SemTryWait")]
        public unsafe partial int SemTryWait(Semaphore* sem);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 293, Column 29 in SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_SemWaitTimeout")]
        public unsafe partial int SemWaitTimeout(Semaphore* sem, uint ms);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 311, Column 29 in SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_SemPost")]
        public unsafe partial int SemPost(Semaphore* sem);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 323, Column 32 in SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_SemValue")]
        public unsafe partial uint SemValue(Semaphore* sem);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 351, Column 35 in SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_CreateCond")]
        public unsafe partial Cond* CreateCond();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 366, Column 30 in SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_DestroyCond")]
        public unsafe partial void DestroyCond(Cond* cond);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 383, Column 29 in SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_CondSignal")]
        public unsafe partial int CondSignal(Cond* cond);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 400, Column 29 in SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_CondBroadcast")]
        public unsafe partial int CondBroadcast(Cond* cond);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 428, Column 29 in SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_CondWait")]
        public unsafe partial int CondWait(Cond* cond, Mutex* mutex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 457, Column 29 in SDL_mutex.h")]
        [NativeApi(EntryPoint = "SDL_CondWaitTimeout")]
        public unsafe partial int CondWaitTimeout(Cond* cond, Mutex* mutex, uint ms);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 127, Column 1 in SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_CreateThread")]
        public unsafe partial Thread* CreateThread(PfnThreadFunction fn, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, void* data, PfnSDLCurrentBeginThread pfnBeginThread, PfnSDLCurrentEndThread pfnEndThread);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 132, Column 1 in SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_CreateThreadWithStackSize")]
        public unsafe partial Thread* CreateThreadWithStackSize(PfnThreadFunction fn, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, nuint stacksize, void* data, PfnSDLCurrentBeginThread pfnBeginThread, PfnSDLCurrentEndThread pfnEndThread);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 272, Column 37 in SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_GetThreadName")]
        public unsafe partial byte* GetThreadName(Thread* thread);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 290, Column 38 in SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_ThreadID")]
        public partial uint ThreadID();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 307, Column 38 in SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_GetThreadID")]
        public unsafe partial uint GetThreadID(Thread* thread);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 322, Column 29 in SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_SetThreadPriority")]
        public partial int SetThreadPriority(ThreadPriority priority);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 357, Column 30 in SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_WaitThread")]
        public unsafe partial void WaitThread(Thread* thread, int* status);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 393, Column 30 in SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_DetachThread")]
        public unsafe partial void DetachThread(Thread* thread);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 408, Column 35 in SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_TLSCreate")]
        public partial uint TLSCreate();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 422, Column 32 in SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_TLSGet")]
        public unsafe partial void* TLSGet(uint id);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_TLSSet")]
        public unsafe partial int TLSSet(uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* value, PfnFreeFunc destructor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 30 in SDL_thread.h")]
        [NativeApi(EntryPoint = "SDL_TLSCleanup")]
        public partial void TLSCleanup();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 276, Column 29 in SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_GetNumAudioDrivers")]
        public partial int GetNumAudioDrivers();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 298, Column 37 in SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_GetAudioDriver")]
        public unsafe partial byte* GetAudioDriver(int index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 325, Column 29 in SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_AudioInit")]
        public unsafe partial int AudioInit([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* driver_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 339, Column 30 in SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_AudioQuit")]
        public partial void AudioQuit();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 358, Column 37 in SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_GetCurrentAudioDriver")]
        public unsafe partial byte* GetCurrentAudioDriver();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 407, Column 29 in SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_OpenAudio")]
        public unsafe partial int OpenAudio(AudioSpec* desired, AudioSpec* obtained);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 465, Column 29 in SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_GetNumAudioDevices")]
        public partial int GetNumAudioDevices(int iscapture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 492, Column 37 in SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_GetAudioDeviceName")]
        public unsafe partial byte* GetAudioDeviceName(int index, int iscapture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 518, Column 29 in SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_GetAudioDeviceSpec")]
        public unsafe partial int GetAudioDeviceSpec(int index, int iscapture, AudioSpec* spec);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 553, Column 29 in SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_GetDefaultAudioInfo")]
        public unsafe partial int GetDefaultAudioInfo(byte** name, AudioSpec* spec, int iscapture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 669, Column 43 in SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_OpenAudioDevice")]
        public unsafe partial uint OpenAudioDevice([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* device, int iscapture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AudioSpec* desired, AudioSpec* obtained, int allowed_changes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 709, Column 41 in SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_GetAudioStatus")]
        public partial AudioStatus GetAudioStatus();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 722, Column 41 in SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_GetAudioDeviceStatus")]
        public partial AudioStatus GetAudioDeviceStatus(uint dev);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 755, Column 30 in SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_PauseAudio")]
        public partial void PauseAudio(int pause_on);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 785, Column 30 in SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_PauseAudioDevice")]
        public partial void PauseAudioDevice(uint dev, int pause_on);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 40 in SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_LoadWAV_RW")]
        public unsafe partial AudioSpec* LoadWAVRW(RWops* src, int freesrc, AudioSpec* spec, byte** audio_buf, uint* audio_len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 898, Column 30 in SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_FreeWAV")]
        public unsafe partial void FreeWAV(byte* audio_buf);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 932, Column 29 in SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_BuildAudioCVT")]
        public unsafe partial int BuildAudioCVT(AudioCVT* cvt, ushort src_format, byte src_channels, int src_rate, ushort dst_format, byte dst_channels, int dst_rate);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 978, Column 29 in SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_ConvertAudio")]
        public unsafe partial int ConvertAudio(AudioCVT* cvt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1011, Column 43 in SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_NewAudioStream")]
        public unsafe partial AudioStream* NewAudioStream(ushort src_format, byte src_channels, int src_rate, ushort dst_format, byte dst_channels, int dst_rate);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1035, Column 29 in SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_AudioStreamPut")]
        public unsafe partial int AudioStreamPut(AudioStream* stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* buf, int len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1054, Column 29 in SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_AudioStreamGet")]
        public unsafe partial int AudioStreamGet(AudioStream* stream, void* buf, int len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1072, Column 29 in SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_AudioStreamAvailable")]
        public unsafe partial int AudioStreamAvailable(AudioStream* stream);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1091, Column 29 in SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_AudioStreamFlush")]
        public unsafe partial int AudioStreamFlush(AudioStream* stream);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1105, Column 30 in SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_AudioStreamClear")]
        public unsafe partial void AudioStreamClear(AudioStream* stream);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1119, Column 30 in SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_FreeAudioStream")]
        public unsafe partial void FreeAudioStream(AudioStream* stream);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1145, Column 30 in SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_MixAudio")]
        public unsafe partial void MixAudio(byte* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* src, uint len, int volume);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1178, Column 30 in SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_MixAudioFormat")]
        public unsafe partial void MixAudioFormat(byte* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* src, ushort format, uint len, int volume);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1229, Column 29 in SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_QueueAudio")]
        public unsafe partial int QueueAudio(uint dev, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, uint len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1277, Column 32 in SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_DequeueAudio")]
        public unsafe partial uint DequeueAudio(uint dev, void* data, uint len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1311, Column 32 in SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_GetQueuedAudioSize")]
        public partial uint GetQueuedAudioSize(uint dev);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1345, Column 30 in SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_ClearQueuedAudio")]
        public partial void ClearQueuedAudio(uint dev);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 30 in SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_LockAudio")]
        public partial void LockAudio();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1415, Column 30 in SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_LockAudioDevice")]
        public partial void LockAudioDevice(uint dev);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1434, Column 30 in SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_UnlockAudio")]
        public partial void UnlockAudio();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1448, Column 30 in SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_UnlockAudioDevice")]
        public partial void UnlockAudioDevice(uint dev);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1466, Column 30 in SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_CloseAudio")]
        public partial void CloseAudio();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1490, Column 30 in SDL_audio.h")]
        [NativeApi(EntryPoint = "SDL_CloseAudioDevice")]
        public partial void CloseAudioDevice(uint dev);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 53, Column 29 in SDL_clipboard.h")]
        [NativeApi(EntryPoint = "SDL_SetClipboardText")]
        public unsafe partial int SetClipboardText([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* text);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 71, Column 32 in SDL_clipboard.h")]
        [NativeApi(EntryPoint = "SDL_GetClipboardText")]
        public unsafe partial byte* GetClipboardText();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 83, Column 34 in SDL_clipboard.h")]
        [NativeApi(EntryPoint = "SDL_HasClipboardText")]
        public partial SdlBool HasClipboardText();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 97, Column 29 in SDL_clipboard.h")]
        [NativeApi(EntryPoint = "SDL_SetPrimarySelectionText")]
        public unsafe partial int SetPrimarySelectionText([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* text);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 116, Column 32 in SDL_clipboard.h")]
        [NativeApi(EntryPoint = "SDL_GetPrimarySelectionText")]
        public unsafe partial byte* GetPrimarySelectionText();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 130, Column 34 in SDL_clipboard.h")]
        [NativeApi(EntryPoint = "SDL_HasPrimarySelectionText")]
        public partial SdlBool HasPrimarySelectionText();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 149, Column 29 in SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_GetCPUCount")]
        public partial int GetCPUCount();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 29 in SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_GetCPUCacheLineSize")]
        public partial int GetCPUCacheLineSize();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 183, Column 34 in SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_HasRDTSC")]
        public partial SdlBool HasRDTSC();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 206, Column 34 in SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_HasAltiVec")]
        public partial SdlBool HasAltiVec();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 228, Column 34 in SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_HasMMX")]
        public partial SdlBool HasMMX();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 250, Column 34 in SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_Has3DNow")]
        public partial SdlBool Has3DNow();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 272, Column 34 in SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_HasSSE")]
        public partial SdlBool HasSSE();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 294, Column 34 in SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_HasSSE2")]
        public partial SdlBool HasSSE2();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 316, Column 34 in SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_HasSSE3")]
        public partial SdlBool HasSSE3();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 338, Column 34 in SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_HasSSE41")]
        public partial SdlBool HasSSE41();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 360, Column 34 in SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_HasSSE42")]
        public partial SdlBool HasSSE42();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 382, Column 34 in SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_HasAVX")]
        public partial SdlBool HasAVX();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 404, Column 34 in SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_HasAVX2")]
        public partial SdlBool HasAVX2();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 417, Column 34 in SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_HasAVX512F")]
        public partial SdlBool HasAVX512F();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 432, Column 34 in SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_HasARMSIMD")]
        public partial SdlBool HasARMSIMD();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 443, Column 34 in SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_HasNEON")]
        public partial SdlBool HasNEON();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 456, Column 34 in SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_HasLSX")]
        public partial SdlBool HasLSX();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 469, Column 34 in SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_HasLASX")]
        public partial SdlBool HasLASX();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 29 in SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_GetSystemRAM")]
        public partial int GetSystemRAM();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 497, Column 32 in SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_SIMDGetAlignment")]
        public partial nuint SIMDGetAlignment();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 536, Column 32 in SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_SIMDAlloc")]
        public unsafe partial void* SIMDAlloc(nuint len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_SIMDRealloc")]
        public unsafe partial void* SIMDRealloc(void* mem, nuint len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 584, Column 30 in SDL_cpuinfo.h")]
        [NativeApi(EntryPoint = "SDL_SIMDFree")]
        public unsafe partial void SIMDFree(void* ptr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 64, Column 38 in SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_GetKeyboardFocus")]
        public unsafe partial Window* GetKeyboardFocus();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 95, Column 38 in SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_GetKeyboardState")]
        public unsafe partial byte* GetKeyboardState(int* numkeys);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 106, Column 30 in SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_ResetKeyboard")]
        public partial void ResetKeyboard();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 119, Column 36 in SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_GetModState")]
        public partial Keymod GetModState();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 138, Column 30 in SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_SetModState")]
        public partial void SetModState(Keymod modstate);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 154, Column 37 in SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_GetKeyFromScancode")]
        public partial int GetKeyFromScancode(Scancode scancode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 170, Column 38 in SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_GetScancodeFromKey")]
        public partial Scancode GetScancodeFromKey(int key);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 195, Column 37 in SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_GetScancodeName")]
        public unsafe partial byte* GetScancodeName(Scancode scancode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 210, Column 38 in SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_GetScancodeFromName")]
        public unsafe partial Scancode GetScancodeFromName([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 229, Column 37 in SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_GetKeyName")]
        public unsafe partial byte* GetKeyName(int key);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 244, Column 37 in SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_GetKeyFromName")]
        public unsafe partial int GetKeyFromName([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 261, Column 30 in SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_StartTextInput")]
        public partial void StartTextInput();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 272, Column 34 in SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_IsTextInputActive")]
        public partial SdlBool IsTextInputActive();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 281, Column 30 in SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_StopTextInput")]
        public partial void StopTextInput();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 291, Column 30 in SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_ClearComposition")]
        public partial void ClearComposition();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 298, Column 34 in SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_IsTextInputShown")]
        public partial SdlBool IsTextInputShown();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 30 in SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_SetTextInputRect")]
        public unsafe partial void SetTextInputRect([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 331, Column 34 in SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_HasScreenKeyboardSupport")]
        public partial SdlBool HasScreenKeyboardSupport();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 343, Column 34 in SDL_keyboard.h")]
        [NativeApi(EntryPoint = "SDL_IsScreenKeyboardShown")]
        public unsafe partial SdlBool IsScreenKeyboardShown(Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 81, Column 38 in SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_GetMouseFocus")]
        public unsafe partial Window* GetMouseFocus();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 104, Column 32 in SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_GetMouseState")]
        public unsafe partial uint GetMouseState(int* x, int* y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 133, Column 32 in SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_GetGlobalMouseState")]
        public unsafe partial uint GetGlobalMouseState(int* x, int* y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 152, Column 32 in SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_GetRelativeMouseState")]
        public unsafe partial uint GetRelativeMouseState(int* x, int* y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 173, Column 30 in SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_WarpMouseInWindow")]
        public unsafe partial void WarpMouseInWindow(Window* window, int x, int y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 196, Column 29 in SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_WarpMouseGlobal")]
        public partial int WarpMouseGlobal(int x, int y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 221, Column 29 in SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_SetRelativeMouseMode")]
        public partial int SetRelativeMouseMode(SdlBool enabled);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 267, Column 29 in SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_CaptureMouse")]
        public partial int CaptureMouse(SdlBool enabled);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 278, Column 34 in SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_GetRelativeMouseMode")]
        public partial SdlBool GetRelativeMouseMode();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 321, Column 37 in SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_CreateCursor")]
        public unsafe partial Cursor* CreateCursor([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* mask, int w, int h, int hot_x, int hot_y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 340, Column 37 in SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_CreateColorCursor")]
        public unsafe partial Cursor* CreateColorCursor(Surface* surface, int hot_x, int hot_y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 355, Column 37 in SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_CreateSystemCursor")]
        public unsafe partial Cursor* CreateSystemCursor(SystemCursor id);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 373, Column 30 in SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_SetCursor")]
        public unsafe partial void SetCursor(Cursor* cursor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 387, Column 37 in SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_GetCursor")]
        public unsafe partial Cursor* GetCursor();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 398, Column 37 in SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_GetDefaultCursor")]
        public unsafe partial Cursor* GetDefaultCursor();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 414, Column 30 in SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_FreeCursor")]
        public unsafe partial void FreeCursor(Cursor* cursor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 436, Column 29 in SDL_mouse.h")]
        [NativeApi(EntryPoint = "SDL_ShowCursor")]
        public partial int ShowCursor(int toggle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 74, Column 30 in SDL_guid.h")]
        [NativeApi(EntryPoint = "SDL_GUIDToString")]
        public unsafe partial void GUIDToString(GUID guid, byte* pszGUID, int cbGUID);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 90, Column 34 in SDL_guid.h")]
        [NativeApi(EntryPoint = "SDL_GUIDFromString")]
        public unsafe partial GUID GUIDFromString([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pchGUID);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 134, Column 30 in SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_LockJoysticks")]
        public partial void LockJoysticks();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 149, Column 30 in SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_UnlockJoysticks")]
        public partial void UnlockJoysticks();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 163, Column 29 in SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_NumJoysticks")]
        public partial int NumJoysticks();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 180, Column 37 in SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickNameForIndex")]
        public unsafe partial byte* JoystickNameForIndex(int device_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 197, Column 37 in SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickPathForIndex")]
        public unsafe partial byte* JoystickPathForIndex(int device_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 205, Column 29 in SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetDevicePlayerIndex")]
        public partial int JoystickGetDevicePlayerIndex(int device_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 223, Column 42 in SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetDeviceGUID")]
        public partial GUID JoystickGetDeviceGUID(int device_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 238, Column 32 in SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetDeviceVendor")]
        public partial ushort JoystickGetDeviceVendor(int device_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 253, Column 32 in SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetDeviceProduct")]
        public partial ushort JoystickGetDeviceProduct(int device_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 268, Column 32 in SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetDeviceProductVersion")]
        public partial ushort JoystickGetDeviceProductVersion(int device_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 282, Column 42 in SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetDeviceType")]
        public partial JoystickType JoystickGetDeviceType(int device_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 297, Column 40 in SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetDeviceInstanceID")]
        public partial int JoystickGetDeviceInstanceID(int device_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 319, Column 39 in SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickOpen")]
        public unsafe partial Joystick* JoystickOpen(int device_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 330, Column 39 in SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickFromInstanceID")]
        public unsafe partial Joystick* JoystickFromInstanceID(int instance_id);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 341, Column 39 in SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickFromPlayerIndex")]
        public unsafe partial Joystick* JoystickFromPlayerIndex(int player_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 350, Column 29 in SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickAttachVirtual")]
        public partial int JoystickAttachVirtual(JoystickType type, int naxes, int nbuttons, int nhats);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 401, Column 29 in SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickAttachVirtualEx")]
        public unsafe partial int JoystickAttachVirtualEx([Flow(Silk.NET.Core.Native.FlowDirection.In)] VirtualJoystickDesc* desc);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 412, Column 29 in SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickDetachVirtual")]
        public partial int JoystickDetachVirtual(int device_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 422, Column 34 in SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickIsVirtual")]
        public partial SdlBool JoystickIsVirtual(int device_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 444, Column 29 in SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickSetVirtualAxis")]
        public unsafe partial int JoystickSetVirtualAxis(Joystick* joystick, int axis, short value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 462, Column 29 in SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickSetVirtualButton")]
        public unsafe partial int JoystickSetVirtualButton(Joystick* joystick, int button, byte value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 480, Column 29 in SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickSetVirtualHat")]
        public unsafe partial int JoystickSetVirtualHat(Joystick* joystick, int hat, byte value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 494, Column 37 in SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickName")]
        public unsafe partial byte* JoystickName(Joystick* joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 507, Column 37 in SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickPath")]
        public unsafe partial byte* JoystickPath(Joystick* joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 520, Column 29 in SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetPlayerIndex")]
        public unsafe partial int JoystickGetPlayerIndex(Joystick* joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 531, Column 30 in SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickSetPlayerIndex")]
        public unsafe partial void JoystickSetPlayerIndex(Joystick* joystick, int player_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 548, Column 42 in SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetGUID")]
        public unsafe partial GUID JoystickGetGUID(Joystick* joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetVendor")]
        public unsafe partial ushort JoystickGetVendor(Joystick* joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 572, Column 32 in SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetProduct")]
        public unsafe partial ushort JoystickGetProduct(Joystick* joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 584, Column 32 in SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetProductVersion")]
        public unsafe partial ushort JoystickGetProductVersion(Joystick* joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 597, Column 32 in SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetFirmwareVersion")]
        public unsafe partial ushort JoystickGetFirmwareVersion(Joystick* joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 610, Column 38 in SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetSerial")]
        public unsafe partial byte* JoystickGetSerial(Joystick* joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 620, Column 42 in SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetType")]
        public unsafe partial JoystickType JoystickGetType(Joystick* joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 637, Column 30 in SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetGUIDString")]
        public unsafe partial void JoystickGetGUIDString(GUID guid, byte* pszGUID, int cbGUID);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 653, Column 42 in SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetGUIDFromString")]
        public unsafe partial GUID JoystickGetGUIDFromString([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pchGUID);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 672, Column 30 in SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_GetJoystickGUIDInfo")]
        public unsafe partial void GetJoystickGUIDInfo(GUID guid, ushort* vendor, ushort* product, ushort* version, ushort* crc16);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 686, Column 34 in SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetAttached")]
        public unsafe partial SdlBool JoystickGetAttached(Joystick* joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 699, Column 40 in SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickInstanceID")]
        public unsafe partial int JoystickInstanceID(Joystick* joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 718, Column 29 in SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickNumAxes")]
        public unsafe partial int JoystickNumAxes(Joystick* joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 736, Column 29 in SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickNumBalls")]
        public unsafe partial int JoystickNumBalls(Joystick* joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 750, Column 29 in SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickNumHats")]
        public unsafe partial int JoystickNumHats(Joystick* joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 764, Column 29 in SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickNumButtons")]
        public unsafe partial int JoystickNumButtons(Joystick* joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 776, Column 30 in SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickUpdate")]
        public partial void JoystickUpdate();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 801, Column 29 in SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickEventState")]
        public partial int JoystickEventState(int state);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 828, Column 32 in SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetAxis")]
        public unsafe partial short JoystickGetAxis(Joystick* joystick, int axis);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 845, Column 34 in SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetAxisInitialState")]
        public unsafe partial SdlBool JoystickGetAxisInitialState(Joystick* joystick, int axis, short* state);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 886, Column 31 in SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetHat")]
        public unsafe partial byte JoystickGetHat(Joystick* joystick, int hat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 908, Column 29 in SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetBall")]
        public unsafe partial int JoystickGetBall(Joystick* joystick, int ball, int* dx, int* dy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 923, Column 31 in SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickGetButton")]
        public unsafe partial byte JoystickGetButton(Joystick* joystick, int button);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 944, Column 29 in SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickRumble")]
        public unsafe partial int JoystickRumble(Joystick* joystick, ushort low_frequency_rumble, ushort high_frequency_rumble, uint duration_ms);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 969, Column 29 in SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickRumbleTriggers")]
        public unsafe partial int JoystickRumbleTriggers(Joystick* joystick, ushort left_rumble, ushort right_rumble, uint duration_ms);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 982, Column 34 in SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickHasLED")]
        public unsafe partial SdlBool JoystickHasLED(Joystick* joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 994, Column 34 in SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickHasRumble")]
        public unsafe partial SdlBool JoystickHasRumble(Joystick* joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1006, Column 34 in SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickHasRumbleTriggers")]
        public unsafe partial SdlBool JoystickHasRumbleTriggers(Joystick* joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1022, Column 29 in SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickSetLED")]
        public unsafe partial int JoystickSetLED(Joystick* joystick, byte red, byte green, byte blue);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1034, Column 29 in SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickSendEffect")]
        public unsafe partial int JoystickSendEffect(Joystick* joystick, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, int size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1045, Column 30 in SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickClose")]
        public unsafe partial void JoystickClose(Joystick* joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1056, Column 48 in SDL_joystick.h")]
        [NativeApi(EntryPoint = "SDL_JoystickCurrentPowerLevel")]
        public unsafe partial JoystickPowerLevel JoystickCurrentPowerLevel(Joystick* joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 143, Column 30 in SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_LockSensors")]
        public partial void LockSensors();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 144, Column 30 in SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_UnlockSensors")]
        public partial void UnlockSensors();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 153, Column 29 in SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_NumSensors")]
        public partial int NumSensors();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 163, Column 37 in SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorGetDeviceName")]
        public unsafe partial byte* SensorGetDeviceName(int device_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 174, Column 40 in SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorGetDeviceType")]
        public partial SensorType SensorGetDeviceType(int device_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 185, Column 29 in SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorGetDeviceNonPortableType")]
        public partial int SensorGetDeviceNonPortableType(int device_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 195, Column 38 in SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorGetDeviceInstanceID")]
        public partial int SensorGetDeviceInstanceID(int device_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 205, Column 37 in SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorOpen")]
        public unsafe partial Sensor* SensorOpen(int device_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 215, Column 37 in SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorFromInstanceID")]
        public unsafe partial Sensor* SensorFromInstanceID(int instance_id);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 225, Column 37 in SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorGetName")]
        public unsafe partial byte* SensorGetName(Sensor* sensor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 236, Column 40 in SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorGetType")]
        public unsafe partial SensorType SensorGetType(Sensor* sensor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 246, Column 29 in SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorGetNonPortableType")]
        public unsafe partial int SensorGetNonPortableType(Sensor* sensor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 256, Column 38 in SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorGetInstanceID")]
        public unsafe partial int SensorGetInstanceID(Sensor* sensor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 270, Column 29 in SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorGetData")]
        public unsafe partial int SensorGetData(Sensor* sensor, float* data, int num_values);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 287, Column 29 in SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorGetDataWithTimestamp")]
        public unsafe partial int SensorGetDataWithTimestamp(Sensor* sensor, ulong* timestamp, float* data, int num_values);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 296, Column 30 in SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorClose")]
        public unsafe partial void SensorClose(Sensor* sensor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 309, Column 30 in SDL_sensor.h")]
        [NativeApi(EntryPoint = "SDL_SensorUpdate")]
        public partial void SensorUpdate();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 165, Column 29 in SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerAddMappingsFromRW")]
        public unsafe partial int GameControllerAddMappingsFromRW(RWops* rw, int freerw);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 201, Column 29 in SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerAddMapping")]
        public unsafe partial int GameControllerAddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* mappingString);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 210, Column 29 in SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerNumMappings")]
        public partial int GameControllerNumMappings();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 220, Column 32 in SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerMappingForIndex")]
        public unsafe partial byte* GameControllerMappingForIndex(int mapping_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 236, Column 32 in SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerMappingForGUID")]
        public unsafe partial byte* GameControllerMappingForGUID(GUID guid);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 255, Column 32 in SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerMapping")]
        public unsafe partial byte* GameControllerMapping(GameController* gamecontroller);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 273, Column 34 in SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_IsGameController")]
        public partial SdlBool IsGameController(int joystick_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 294, Column 37 in SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerNameForIndex")]
        public unsafe partial byte* GameControllerNameForIndex(int joystick_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 313, Column 37 in SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerPathForIndex")]
        public unsafe partial byte* GameControllerPathForIndex(int joystick_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 326, Column 48 in SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerTypeForIndex")]
        public partial GameControllerType GameControllerTypeForIndex(int joystick_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 340, Column 31 in SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerMappingForDeviceIndex")]
        public unsafe partial byte* GameControllerMappingForDeviceIndex(int joystick_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 364, Column 45 in SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerOpen")]
        public unsafe partial GameController* GameControllerOpen(int joystick_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 375, Column 45 in SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerFromInstanceID")]
        public unsafe partial GameController* GameControllerFromInstanceID(int joyid);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 392, Column 45 in SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerFromPlayerIndex")]
        public unsafe partial GameController* GameControllerFromPlayerIndex(int player_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 410, Column 37 in SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerName")]
        public unsafe partial byte* GameControllerName(GameController* gamecontroller);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 427, Column 37 in SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerPath")]
        public unsafe partial byte* GameControllerPath(GameController* gamecontroller);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 440, Column 48 in SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetType")]
        public unsafe partial GameControllerType GameControllerGetType(GameController* gamecontroller);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 452, Column 29 in SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetPlayerIndex")]
        public unsafe partial int GameControllerGetPlayerIndex(GameController* gamecontroller);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 463, Column 30 in SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerSetPlayerIndex")]
        public unsafe partial void GameControllerSetPlayerIndex(GameController* gamecontroller, int player_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 475, Column 32 in SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetVendor")]
        public unsafe partial ushort GameControllerGetVendor(GameController* gamecontroller);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 487, Column 32 in SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetProduct")]
        public unsafe partial ushort GameControllerGetProduct(GameController* gamecontroller);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 499, Column 32 in SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetProductVersion")]
        public unsafe partial ushort GameControllerGetProductVersion(GameController* gamecontroller);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 511, Column 32 in SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetFirmwareVersion")]
        public unsafe partial ushort GameControllerGetFirmwareVersion(GameController* gamecontroller);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 524, Column 38 in SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetSerial")]
        public unsafe partial byte* GameControllerGetSerial(GameController* gamecontroller);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 539, Column 34 in SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetAttached")]
        public unsafe partial SdlBool GameControllerGetAttached(GameController* gamecontroller);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 39 in SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetJoystick")]
        public unsafe partial Joystick* GameControllerGetJoystick(GameController* gamecontroller);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 580, Column 29 in SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerEventState")]
        public partial int GameControllerEventState(int state);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 591, Column 30 in SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerUpdate")]
        public partial void GameControllerUpdate();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 635, Column 48 in SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetAxisFromString")]
        public unsafe partial GameControllerAxis GameControllerGetAxisFromString([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* str);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 651, Column 37 in SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetStringForAxis")]
        public unsafe partial byte* GameControllerGetStringForAxis(GameControllerAxis axis);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 667, Column 1 in SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetBindForAxis")]
        public unsafe partial GameControllerButtonBind GameControllerGetBindForAxis(GameController* gamecontroller, GameControllerAxis axis);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 683, Column 1 in SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerHasAxis")]
        public unsafe partial SdlBool GameControllerHasAxis(GameController* gamecontroller, GameControllerAxis axis);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 703, Column 1 in SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetAxis")]
        public unsafe partial short GameControllerGetAxis(GameController* gamecontroller, GameControllerAxis axis);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 749, Column 50 in SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetButtonFromString")]
        public unsafe partial GameControllerButton GameControllerGetButtonFromString([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* str);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 765, Column 37 in SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetStringForButton")]
        public unsafe partial byte* GameControllerGetStringForButton(GameControllerButton button);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 781, Column 1 in SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetBindForButton")]
        public unsafe partial GameControllerButtonBind GameControllerGetBindForButton(GameController* gamecontroller, GameControllerButton button);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 796, Column 34 in SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerHasButton")]
        public unsafe partial SdlBool GameControllerHasButton(GameController* gamecontroller, GameControllerButton button);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 811, Column 31 in SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetButton")]
        public unsafe partial byte GameControllerGetButton(GameController* gamecontroller, GameControllerButton button);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 819, Column 29 in SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetNumTouchpads")]
        public unsafe partial int GameControllerGetNumTouchpads(GameController* gamecontroller);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 827, Column 29 in SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetNumTouchpadFingers")]
        public unsafe partial int GameControllerGetNumTouchpadFingers(GameController* gamecontroller, int touchpad);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 834, Column 29 in SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetTouchpadFinger")]
        public unsafe partial int GameControllerGetTouchpadFinger(GameController* gamecontroller, int touchpad, int finger, byte* state, float* x, float* y, float* pressure);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 845, Column 34 in SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerHasSensor")]
        public unsafe partial SdlBool GameControllerHasSensor(GameController* gamecontroller, SensorType type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 857, Column 29 in SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerSetSensorEnabled")]
        public unsafe partial int GameControllerSetSensorEnabled(GameController* gamecontroller, SensorType type, SdlBool enabled);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 868, Column 34 in SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerIsSensorEnabled")]
        public unsafe partial SdlBool GameControllerIsSensorEnabled(GameController* gamecontroller, SensorType type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 880, Column 31 in SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetSensorDataRate")]
        public unsafe partial float GameControllerGetSensorDataRate(GameController* gamecontroller, SensorType type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 896, Column 29 in SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetSensorData")]
        public unsafe partial int GameControllerGetSensorData(GameController* gamecontroller, SensorType type, float* data, int num_values);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 915, Column 29 in SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetSensorDataWithTimestamp")]
        public unsafe partial int GameControllerGetSensorDataWithTimestamp(GameController* gamecontroller, SensorType type, ulong* timestamp, float* data, int num_values);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 935, Column 29 in SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerRumble")]
        public unsafe partial int GameControllerRumble(GameController* gamecontroller, ushort low_frequency_rumble, ushort high_frequency_rumble, uint duration_ms);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 960, Column 29 in SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerRumbleTriggers")]
        public unsafe partial int GameControllerRumbleTriggers(GameController* gamecontroller, ushort left_rumble, ushort right_rumble, uint duration_ms);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 971, Column 34 in SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerHasLED")]
        public unsafe partial SdlBool GameControllerHasLED(GameController* gamecontroller);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 984, Column 34 in SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerHasRumble")]
        public unsafe partial SdlBool GameControllerHasRumble(GameController* gamecontroller);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 997, Column 34 in SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerHasRumbleTriggers")]
        public unsafe partial SdlBool GameControllerHasRumbleTriggers(GameController* gamecontroller);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1010, Column 29 in SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerSetLED")]
        public unsafe partial int GameControllerSetLED(GameController* gamecontroller, byte red, byte green, byte blue);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1023, Column 29 in SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerSendEffect")]
        public unsafe partial int GameControllerSendEffect(GameController* gamecontroller, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, int size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1035, Column 30 in SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerClose")]
        public unsafe partial void GameControllerClose(GameController* gamecontroller);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1049, Column 37 in SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetAppleSFSymbolsNameForButton")]
        public unsafe partial byte* GameControllerGetAppleSFSymbolsNameForButton(GameController* gamecontroller, GameControllerButton button);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1063, Column 37 in SDL_gamecontroller.h")]
        [NativeApi(EntryPoint = "SDL_GameControllerGetAppleSFSymbolsNameForAxis")]
        public unsafe partial byte* GameControllerGetAppleSFSymbolsNameForAxis(GameController* gamecontroller, GameControllerAxis axis);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 83, Column 29 in SDL_touch.h")]
        [NativeApi(EntryPoint = "SDL_GetNumTouchDevices")]
        public partial int GetNumTouchDevices();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 96, Column 37 in SDL_touch.h")]
        [NativeApi(EntryPoint = "SDL_GetTouchDevice")]
        public partial long GetTouchDevice(int index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 104, Column 37 in SDL_touch.h")]
        [NativeApi(EntryPoint = "SDL_GetTouchName")]
        public unsafe partial byte* GetTouchName(int index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 111, Column 45 in SDL_touch.h")]
        [NativeApi(EntryPoint = "SDL_GetTouchDeviceType")]
        public partial TouchDeviceType GetTouchDeviceType(long touchID);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 124, Column 29 in SDL_touch.h")]
        [NativeApi(EntryPoint = "SDL_GetNumTouchFingers")]
        public partial int GetNumTouchFingers(long touchID);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 140, Column 38 in SDL_touch.h")]
        [NativeApi(EntryPoint = "SDL_GetTouchFinger")]
        public unsafe partial Finger* GetTouchFinger(long touchID, int index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 61, Column 29 in SDL_gesture.h")]
        [NativeApi(EntryPoint = "SDL_RecordGesture")]
        public partial int RecordGesture(long touchId);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 76, Column 29 in SDL_gesture.h")]
        [NativeApi(EntryPoint = "SDL_SaveAllDollarTemplates")]
        public unsafe partial int SaveAllDollarTemplates(RWops* dst);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 91, Column 29 in SDL_gesture.h")]
        [NativeApi(EntryPoint = "SDL_SaveDollarTemplate")]
        public unsafe partial int SaveDollarTemplate(long gestureId, RWops* dst);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 107, Column 29 in SDL_gesture.h")]
        [NativeApi(EntryPoint = "SDL_LoadDollarTemplates")]
        public unsafe partial int LoadDollarTemplates(long touchId, RWops* src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 703, Column 30 in SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_PumpEvents")]
        public partial void PumpEvents();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 751, Column 29 in SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_PeepEvents")]
        public unsafe partial int PeepEvents(Event* events, int numevents, Eventaction action, uint minType, uint maxType);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 770, Column 34 in SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_HasEvent")]
        public partial SdlBool HasEvent(uint type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 789, Column 34 in SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_HasEvents")]
        public partial SdlBool HasEvents(uint minType, uint maxType);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 811, Column 30 in SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_FlushEvent")]
        public partial void FlushEvent(uint type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 836, Column 30 in SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_FlushEvents")]
        public partial void FlushEvents(uint minType, uint maxType);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 883, Column 29 in SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_PollEvent")]
        public unsafe partial int PollEvent(Event* @event);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 905, Column 29 in SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_WaitEvent")]
        public unsafe partial int WaitEvent(Event* @event);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 931, Column 29 in SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_WaitEventTimeout")]
        public unsafe partial int WaitEventTimeout(Event* @event, int timeout);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 966, Column 29 in SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_PushEvent")]
        public unsafe partial int PushEvent(Event* @event);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1024, Column 30 in SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_SetEventFilter")]
        public unsafe partial void SetEventFilter(PfnEventFilter filter, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1042, Column 34 in SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_GetEventFilter")]
        public unsafe partial SdlBool GetEventFilter(PfnEventFilter* filter, void** userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1071, Column 30 in SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_AddEventWatch")]
        public unsafe partial void AddEventWatch(PfnEventFilter filter, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1087, Column 30 in SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_DelEventWatch")]
        public unsafe partial void DelEventWatch(PfnEventFilter filter, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1106, Column 30 in SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_FilterEvents")]
        public unsafe partial void FilterEvents(PfnEventFilter filter, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1134, Column 31 in SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_EventState")]
        public partial byte EventState(uint type, int state);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1156, Column 32 in SDL_events.h")]
        [NativeApi(EntryPoint = "SDL_RegisterEvents")]
        public partial uint RegisterEvents(int numevents);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 82, Column 31 in SDL_filesystem.h")]
        [NativeApi(EntryPoint = "SDL_GetBasePath")]
        public unsafe partial byte* GetBasePath();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 139, Column 31 in SDL_filesystem.h")]
        [NativeApi(EntryPoint = "SDL_GetPrefPath")]
        public unsafe partial byte* GetPrefPath([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* org, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* app);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 834, Column 29 in SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_NumHaptics")]
        public partial int NumHaptics();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 850, Column 37 in SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticName")]
        public unsafe partial byte* HapticName(int device_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 877, Column 37 in SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticOpen")]
        public unsafe partial Haptic* HapticOpen(int device_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 29 in SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticOpened")]
        public partial int HapticOpened(int device_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 905, Column 29 in SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticIndex")]
        public unsafe partial int HapticIndex(Haptic* haptic);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 916, Column 29 in SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_MouseIsHaptic")]
        public partial int MouseIsHaptic();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 929, Column 37 in SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticOpenFromMouse")]
        public unsafe partial Haptic* HapticOpenFromMouse();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 943, Column 29 in SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_JoystickIsHaptic")]
        public unsafe partial int JoystickIsHaptic(Joystick* joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 966, Column 37 in SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticOpenFromJoystick")]
        public unsafe partial Haptic* HapticOpenFromJoystick(Joystick* joystick);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 978, Column 30 in SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticClose")]
        public unsafe partial void HapticClose(Haptic* haptic);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 996, Column 29 in SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticNumEffects")]
        public unsafe partial int HapticNumEffects(Haptic* haptic);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1013, Column 29 in SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticNumEffectsPlaying")]
        public unsafe partial int HapticNumEffectsPlaying(Haptic* haptic);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1027, Column 38 in SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticQuery")]
        public unsafe partial uint HapticQuery(Haptic* haptic);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1042, Column 29 in SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticNumAxes")]
        public unsafe partial int HapticNumAxes(Haptic* haptic);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1058, Column 29 in SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticEffectSupported")]
        public unsafe partial int HapticEffectSupported(Haptic* haptic, HapticEffect* effect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1077, Column 29 in SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticNewEffect")]
        public unsafe partial int HapticNewEffect(Haptic* haptic, HapticEffect* effect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1101, Column 29 in SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticUpdateEffect")]
        public unsafe partial int HapticUpdateEffect(Haptic* haptic, int effect, HapticEffect* data);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1127, Column 29 in SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticRunEffect")]
        public unsafe partial int HapticRunEffect(Haptic* haptic, int effect, uint iterations);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1146, Column 29 in SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticStopEffect")]
        public unsafe partial int HapticStopEffect(Haptic* haptic, int effect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1162, Column 30 in SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticDestroyEffect")]
        public unsafe partial void HapticDestroyEffect(Haptic* haptic, int effect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1180, Column 29 in SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticGetEffectStatus")]
        public unsafe partial int HapticGetEffectStatus(Haptic* haptic, int effect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1202, Column 29 in SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticSetGain")]
        public unsafe partial int HapticSetGain(Haptic* haptic, int gain);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1221, Column 29 in SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticSetAutocenter")]
        public unsafe partial int HapticSetAutocenter(Haptic* haptic, int autocenter);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1241, Column 29 in SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticPause")]
        public unsafe partial int HapticPause(Haptic* haptic);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1256, Column 29 in SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticUnpause")]
        public unsafe partial int HapticUnpause(Haptic* haptic);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1267, Column 29 in SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticStopAll")]
        public unsafe partial int HapticStopAll(Haptic* haptic);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1283, Column 29 in SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticRumbleSupported")]
        public unsafe partial int HapticRumbleSupported(Haptic* haptic);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1299, Column 29 in SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticRumbleInit")]
        public unsafe partial int HapticRumbleInit(Haptic* haptic);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1316, Column 29 in SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticRumblePlay")]
        public unsafe partial int HapticRumblePlay(Haptic* haptic, float strength, uint length);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1331, Column 29 in SDL_haptic.h")]
        [NativeApi(EntryPoint = "SDL_HapticRumbleStop")]
        public unsafe partial int HapticRumbleStop(Haptic* haptic);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 142, Column 29 in SDL_hidapi.h")]
        [NativeApi(EntryPoint = "SDL_hid_init")]
        public partial int HidInit();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 156, Column 29 in SDL_hidapi.h")]
        [NativeApi(EntryPoint = "SDL_hid_exit")]
        public partial int HidExit();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 177, Column 32 in SDL_hidapi.h")]
        [NativeApi(EntryPoint = "SDL_hid_device_change_count")]
        public partial uint HidDeviceChangeCount();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 199, Column 47 in SDL_hidapi.h")]
        [NativeApi(EntryPoint = "SDL_hid_enumerate")]
        public unsafe partial HidDeviceInfo* HidEnumerate(ushort vendor_id, ushort product_id);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 211, Column 30 in SDL_hidapi.h")]
        [NativeApi(EntryPoint = "SDL_hid_free_enumeration")]
        public unsafe partial void HidFreeEnumeration(HidDeviceInfo* devs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 229, Column 42 in SDL_hidapi.h")]
        [NativeApi(EntryPoint = "SDL_hid_open")]
        public unsafe partial HidDevice* HidOpen(ushort vendor_id, ushort product_id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* serial_number);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 243, Column 42 in SDL_hidapi.h")]
        [NativeApi(EntryPoint = "SDL_hid_open_path")]
        public unsafe partial HidDevice* HidOpenPath([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, int bExclusive);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 269, Column 29 in SDL_hidapi.h")]
        [NativeApi(EntryPoint = "SDL_hid_write")]
        public unsafe partial int HidWrite(HidDevice* dev, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, nuint length);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 290, Column 29 in SDL_hidapi.h")]
        [NativeApi(EntryPoint = "SDL_hid_read_timeout")]
        public unsafe partial int HidReadTimeout(HidDevice* dev, byte* data, nuint length, int milliseconds);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 310, Column 29 in SDL_hidapi.h")]
        [NativeApi(EntryPoint = "SDL_hid_read")]
        public unsafe partial int HidRead(HidDevice* dev, byte* data, nuint length);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 328, Column 29 in SDL_hidapi.h")]
        [NativeApi(EntryPoint = "SDL_hid_set_nonblocking")]
        public unsafe partial int HidSetNonblocking(HidDevice* dev, int nonblock);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 352, Column 29 in SDL_hidapi.h")]
        [NativeApi(EntryPoint = "SDL_hid_send_feature_report")]
        public unsafe partial int HidSendFeatureReport(HidDevice* dev, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, nuint length);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 374, Column 29 in SDL_hidapi.h")]
        [NativeApi(EntryPoint = "SDL_hid_get_feature_report")]
        public unsafe partial int HidGetFeatureReport(HidDevice* dev, byte* data, nuint length);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 383, Column 30 in SDL_hidapi.h")]
        [NativeApi(EntryPoint = "SDL_hid_close")]
        public unsafe partial void HidClose(HidDevice* dev);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 395, Column 29 in SDL_hidapi.h")]
        [NativeApi(EntryPoint = "SDL_hid_get_manufacturer_string")]
        public unsafe partial int HidGetManufacturerString(HidDevice* dev, char* @string, nuint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 407, Column 29 in SDL_hidapi.h")]
        [NativeApi(EntryPoint = "SDL_hid_get_product_string")]
        public unsafe partial int HidGetProductString(HidDevice* dev, char* @string, nuint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 419, Column 29 in SDL_hidapi.h")]
        [NativeApi(EntryPoint = "SDL_hid_get_serial_number_string")]
        public unsafe partial int HidGetSerialNumberString(HidDevice* dev, char* @string, nuint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 432, Column 29 in SDL_hidapi.h")]
        [NativeApi(EntryPoint = "SDL_hid_get_indexed_string")]
        public unsafe partial int HidGetIndexedString(HidDevice* dev, int string_index, char* @string, nuint maxlen);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 441, Column 30 in SDL_hidapi.h")]
        [NativeApi(EntryPoint = "SDL_hid_ble_scan")]
        public partial void HidBleScan(SdlBool active);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2419, Column 34 in SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_SetHintWithPriority")]
        public unsafe partial SdlBool SetHintWithPriority([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* value, HintPriority priority);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2439, Column 34 in SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_SetHint")]
        public unsafe partial SdlBool SetHint([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2457, Column 34 in SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_ResetHint")]
        public unsafe partial SdlBool ResetHint([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2472, Column 30 in SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_ResetHints")]
        public partial void ResetHints();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2485, Column 38 in SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_GetHint")]
        public unsafe partial byte* GetHint([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2500, Column 34 in SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_GetHintBoolean")]
        public unsafe partial SdlBool GetHintBoolean([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, SdlBool default_value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2524, Column 30 in SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_AddHintCallback")]
        public unsafe partial void AddHintCallback([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, PfnHintCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2540, Column 30 in SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_DelHintCallback")]
        public unsafe partial void DelHintCallback([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, PfnHintCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2558, Column 30 in SDL_hints.h")]
        [NativeApi(EntryPoint = "SDL_ClearHints")]
        public partial void ClearHints();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 65, Column 31 in SDL_loadso.h")]
        [NativeApi(EntryPoint = "SDL_LoadObject")]
        public unsafe partial void* LoadObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sofile);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 92, Column 31 in SDL_loadso.h")]
        [NativeApi(EntryPoint = "SDL_LoadFunction")]
        public unsafe partial void* LoadFunction(void* handle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 105, Column 30 in SDL_loadso.h")]
        [NativeApi(EntryPoint = "SDL_UnloadObject")]
        public unsafe partial void UnloadObject(void* handle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 123, Column 30 in SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogSetAllPriority")]
        public partial void LogSetAllPriority(LogPriority priority);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 136, Column 30 in SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogSetPriority")]
        public partial void LogSetPriority(int category, LogPriority priority);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 149, Column 41 in SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogGetPriority")]
        public partial LogPriority LogGetPriority(int category);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 30 in SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogResetPriorities")]
        public partial void LogResetPriorities();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 30 in SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_Log")]
        public unsafe partial void Log([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fmt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 203, Column 30 in SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogVerbose")]
        public unsafe partial void LogVerbose(int category, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fmt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 224, Column 30 in SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogDebug")]
        public unsafe partial void LogDebug(int category, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fmt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 245, Column 30 in SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogInfo")]
        public unsafe partial void LogInfo(int category, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fmt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 266, Column 30 in SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogWarn")]
        public unsafe partial void LogWarn(int category, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fmt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 287, Column 30 in SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogError")]
        public unsafe partial void LogError(int category, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fmt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 308, Column 30 in SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogCritical")]
        public unsafe partial void LogCritical(int category, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fmt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 330, Column 30 in SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogMessage")]
        public unsafe partial void LogMessage(int category, LogPriority priority, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fmt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 30 in SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogMessageV")]
        public unsafe partial void LogMessageV(int category, LogPriority priority, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fmt, byte* ap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 381, Column 30 in SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogGetOutputFunction")]
        public unsafe partial void LogGetOutputFunction(PfnLogOutputFunction* callback, void** userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 393, Column 30 in SDL_log.h")]
        [NativeApi(EntryPoint = "SDL_LogSetOutputFunction")]
        public unsafe partial void LogSetOutputFunction(PfnLogOutputFunction callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 140, Column 29 in SDL_messagebox.h")]
        [NativeApi(EntryPoint = "SDL_ShowMessageBox")]
        public unsafe partial int ShowMessageBox([Flow(Silk.NET.Core.Native.FlowDirection.In)] MessageBoxData* messageboxdata, int* buttonid);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 29 in SDL_messagebox.h")]
        [NativeApi(EntryPoint = "SDL_ShowSimpleMessageBox")]
        public unsafe partial int ShowSimpleMessageBox(uint flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* title, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* message, Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 66, Column 39 in SDL_metal.h")]
        [NativeApi(EntryPoint = "SDL_Metal_CreateView")]
        public unsafe partial void* MetalCreateView(Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 78, Column 30 in SDL_metal.h")]
        [NativeApi(EntryPoint = "SDL_Metal_DestroyView")]
        public unsafe partial void MetalDestroyView(void* view);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 87, Column 31 in SDL_metal.h")]
        [NativeApi(EntryPoint = "SDL_Metal_GetLayer")]
        public unsafe partial void* MetalGetLayer(void* view);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 102, Column 30 in SDL_metal.h")]
        [NativeApi(EntryPoint = "SDL_Metal_GetDrawableSize")]
        public unsafe partial void MetalGetDrawableSize(Window* window, int* w, int* h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 78, Column 40 in SDL_power.h")]
        [NativeApi(EntryPoint = "SDL_GetPowerInfo")]
        public unsafe partial PowerState GetPowerInfo(int* secs, int* pct);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 169, Column 29 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetNumRenderDrivers")]
        public partial int GetNumRenderDrivers();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 185, Column 29 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDriverInfo")]
        public unsafe partial int GetRenderDriverInfo(int index, RendererInfo* info);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 205, Column 29 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_CreateWindowAndRenderer")]
        public unsafe partial int CreateWindowAndRenderer(int width, int height, uint window_flags, Window** window, Renderer** renderer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 227, Column 40 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_CreateRenderer")]
        public unsafe partial Renderer* CreateRenderer(Window* window, int index, uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 249, Column 40 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_CreateSoftwareRenderer")]
        public unsafe partial Renderer* CreateSoftwareRenderer(Surface* surface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 262, Column 40 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderer")]
        public unsafe partial Renderer* GetRenderer(Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 273, Column 38 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderGetWindow")]
        public unsafe partial Window* RenderGetWindow(Renderer* renderer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 29 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRendererInfo")]
        public unsafe partial int GetRendererInfo(Renderer* renderer, RendererInfo* info);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 308, Column 29 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRendererOutputSize")]
        public unsafe partial int GetRendererOutputSize(Renderer* renderer, int* w, int* h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 333, Column 39 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_CreateTexture")]
        public unsafe partial Texture* CreateTexture(Renderer* renderer, uint format, int access, int w, int h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 362, Column 39 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_CreateTextureFromSurface")]
        public unsafe partial Texture* CreateTextureFromSurface(Renderer* renderer, Surface* surface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 386, Column 29 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_QueryTexture")]
        public unsafe partial int QueryTexture(Texture* texture, uint* format, int* access, int* w, int* h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 414, Column 29 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_SetTextureColorMod")]
        public unsafe partial int SetTextureColorMod(Texture* texture, byte r, byte g, byte b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 433, Column 29 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureColorMod")]
        public unsafe partial int GetTextureColorMod(Texture* texture, byte* r, byte* g, byte* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 458, Column 29 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_SetTextureAlphaMod")]
        public unsafe partial int SetTextureAlphaMod(Texture* texture, byte alpha);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 474, Column 29 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureAlphaMod")]
        public unsafe partial int GetTextureAlphaMod(Texture* texture, byte* alpha);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 493, Column 29 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_SetTextureBlendMode")]
        public unsafe partial int SetTextureBlendMode(Texture* texture, BlendMode blendMode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 508, Column 29 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureBlendMode")]
        public unsafe partial int GetTextureBlendMode(Texture* texture, BlendMode* blendMode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 524, Column 29 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_SetTextureScaleMode")]
        public unsafe partial int SetTextureScaleMode(Texture* texture, ScaleMode scaleMode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 538, Column 29 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureScaleMode")]
        public unsafe partial int GetTextureScaleMode(Texture* texture, ScaleMode* scaleMode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 552, Column 29 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_SetTextureUserData")]
        public unsafe partial int SetTextureUserData(Texture* texture, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 566, Column 32 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetTextureUserData")]
        public unsafe partial void* GetTextureUserData(Texture* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 597, Column 29 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateTexture")]
        public unsafe partial int UpdateTexture(Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pixels, int pitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 628, Column 29 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateYUVTexture")]
        public unsafe partial int UpdateYUVTexture(Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Uplane, int Upitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Vplane, int Vpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 654, Column 29 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UpdateNVTexture")]
        public unsafe partial int UpdateNVTexture(Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* UVplane, int UVpitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 686, Column 29 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_LockTexture")]
        public unsafe partial int LockTexture(Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect, void** pixels, int* pitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 722, Column 29 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_LockTextureToSurface")]
        public unsafe partial int LockTextureToSurface(Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect, Surface** surface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 743, Column 30 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_UnlockTexture")]
        public unsafe partial void UnlockTexture(Texture* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 755, Column 34 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderTargetSupported")]
        public unsafe partial SdlBool RenderTargetSupported(Renderer* renderer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 779, Column 29 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_SetRenderTarget")]
        public unsafe partial int SetRenderTarget(Renderer* renderer, Texture* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 795, Column 39 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderTarget")]
        public unsafe partial Texture* GetRenderTarget(Renderer* renderer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 823, Column 29 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderSetLogicalSize")]
        public unsafe partial int RenderSetLogicalSize(Renderer* renderer, int w, int h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 844, Column 30 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderGetLogicalSize")]
        public unsafe partial void RenderGetLogicalSize(Renderer* renderer, int* w, int* h);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 863, Column 29 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderSetIntegerScale")]
        public unsafe partial int RenderSetIntegerScale(Renderer* renderer, SdlBool enable);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 877, Column 34 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderGetIntegerScale")]
        public unsafe partial SdlBool RenderGetIntegerScale(Renderer* renderer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 895, Column 29 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderSetViewport")]
        public unsafe partial int RenderSetViewport(Renderer* renderer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 908, Column 30 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderGetViewport")]
        public unsafe partial void RenderGetViewport(Renderer* renderer, Silk.NET.Maths.Rectangle<int>* rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 926, Column 29 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderSetClipRect")]
        public unsafe partial int RenderSetClipRect(Renderer* renderer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 942, Column 30 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderGetClipRect")]
        public unsafe partial void RenderGetClipRect(Renderer* renderer, Silk.NET.Maths.Rectangle<int>* rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 957, Column 34 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderIsClipEnabled")]
        public unsafe partial SdlBool RenderIsClipEnabled(Renderer* renderer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 982, Column 29 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderSetScale")]
        public unsafe partial int RenderSetScale(Renderer* renderer, float scaleX, float scaleY);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 996, Column 30 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderGetScale")]
        public unsafe partial void RenderGetScale(Renderer* renderer, float* scaleX, float* scaleY);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1020, Column 30 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderWindowToLogical")]
        public unsafe partial void RenderWindowToLogical(Renderer* renderer, int windowX, int windowY, float* logicalX, float* logicalY);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1046, Column 30 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderLogicalToWindow")]
        public unsafe partial void RenderLogicalToWindow(Renderer* renderer, float logicalX, float logicalY, int* windowX, int* windowY);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1079, Column 29 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_SetRenderDrawColor")]
        public unsafe partial int SetRenderDrawColor(Renderer* renderer, byte r, byte g, byte b, byte a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawColor")]
        public unsafe partial int GetRenderDrawColor(Renderer* renderer, byte* r, byte* g, byte* b, byte* a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1128, Column 29 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_SetRenderDrawBlendMode")]
        public unsafe partial int SetRenderDrawBlendMode(Renderer* renderer, BlendMode blendMode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1143, Column 29 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GetRenderDrawBlendMode")]
        public unsafe partial int GetRenderDrawBlendMode(Renderer* renderer, BlendMode* blendMode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1160, Column 29 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderClear")]
        public unsafe partial int RenderClear(Renderer* renderer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1187, Column 29 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawPoint")]
        public unsafe partial int RenderDrawPoint(Renderer* renderer, int x, int y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1213, Column 29 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawPoints")]
        public unsafe partial int RenderDrawPoints(Renderer* renderer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Point* points, int count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1244, Column 29 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawLine")]
        public unsafe partial int RenderDrawLine(Renderer* renderer, int x1, int y1, int x2, int y2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1270, Column 29 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawLines")]
        public unsafe partial int RenderDrawLines(Renderer* renderer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Point* points, int count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1296, Column 29 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawRect")]
        public unsafe partial int RenderDrawRect(Renderer* renderer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1322, Column 29 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawRects")]
        public unsafe partial int RenderDrawRects(Renderer* renderer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rects, int count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1352, Column 29 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderFillRect")]
        public unsafe partial int RenderFillRect(Renderer* renderer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1377, Column 29 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderFillRects")]
        public unsafe partial int RenderFillRects(Renderer* renderer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rects, int count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1409, Column 29 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopy")]
        public unsafe partial int RenderCopy(Renderer* renderer, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* srcrect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1453, Column 29 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyEx")]
        public unsafe partial int RenderCopyEx(Renderer* renderer, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* srcrect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* dstrect, double angle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Point* center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1472, Column 29 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawPointF")]
        public unsafe partial int RenderDrawPointF(Renderer* renderer, float x, float y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1485, Column 29 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawPointsF")]
        public unsafe partial int RenderDrawPointsF(Renderer* renderer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FPoint* points, int count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1501, Column 29 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawLineF")]
        public unsafe partial int RenderDrawLineF(Renderer* renderer, float x1, float y1, float x2, float y2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1515, Column 29 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawLinesF")]
        public unsafe partial int RenderDrawLinesF(Renderer* renderer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FPoint* points, int count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1529, Column 29 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawRectF")]
        public unsafe partial int RenderDrawRectF(Renderer* renderer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FRect* rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1543, Column 29 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderDrawRectsF")]
        public unsafe partial int RenderDrawRectsF(Renderer* renderer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FRect* rects, int count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1558, Column 29 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderFillRectF")]
        public unsafe partial int RenderFillRectF(Renderer* renderer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FRect* rect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1572, Column 29 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderFillRectsF")]
        public unsafe partial int RenderFillRectsF(Renderer* renderer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FRect* rects, int count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1590, Column 29 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyF")]
        public unsafe partial int RenderCopyF(Renderer* renderer, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* srcrect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FRect* dstrect);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1616, Column 29 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderCopyExF")]
        public unsafe partial int RenderCopyExF(Renderer* renderer, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* srcrect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FRect* dstrect, double angle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FPoint* center, RendererFlip flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1644, Column 29 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderGeometry")]
        public unsafe partial int RenderGeometry(Renderer* renderer, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Vertex* vertices, int num_vertices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* indices, int num_indices);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1674, Column 29 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderGeometryRaw")]
        public unsafe partial int RenderGeometryRaw(Renderer* renderer, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* xy, int xy_stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Color* color, int color_stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* uv, int uv_stride, int num_vertices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* indices, int num_indices, int size_indices);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1708, Column 29 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderReadPixels")]
        public unsafe partial int RenderReadPixels(Renderer* renderer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect, uint format, void* pixels, int pitch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1748, Column 30 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderPresent")]
        public unsafe partial void RenderPresent(Renderer* renderer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1763, Column 30 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_DestroyTexture")]
        public unsafe partial void DestroyTexture(Texture* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1777, Column 30 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_DestroyRenderer")]
        public unsafe partial void DestroyRenderer(Renderer* renderer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1808, Column 29 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderFlush")]
        public unsafe partial int RenderFlush(Renderer* renderer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1846, Column 29 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GL_BindTexture")]
        public unsafe partial int GLBindTexture(Texture* texture, float* texw, float* texh);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1861, Column 29 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_GL_UnbindTexture")]
        public unsafe partial int GLUnbindTexture(Texture* texture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1877, Column 31 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderGetMetalLayer")]
        public unsafe partial void* RenderGetMetalLayer(Renderer* renderer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1898, Column 31 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderGetMetalCommandEncoder")]
        public unsafe partial void* RenderGetMetalCommandEncoder(Renderer* renderer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1909, Column 29 in SDL_render.h")]
        [NativeApi(EntryPoint = "SDL_RenderSetVSync")]
        public unsafe partial int RenderSetVSync(Renderer* renderer, int vsync);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 69, Column 38 in SDL_shape.h")]
        [NativeApi(EntryPoint = "SDL_CreateShapedWindow")]
        public unsafe partial Window* CreateShapedWindow([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* title, uint x, uint y, uint w, uint h, uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 82, Column 34 in SDL_shape.h")]
        [NativeApi(EntryPoint = "SDL_IsShapedWindow")]
        public unsafe partial SdlBool IsShapedWindow([Flow(Silk.NET.Core.Native.FlowDirection.In)] Window* window);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 128, Column 29 in SDL_shape.h")]
        [NativeApi(EntryPoint = "SDL_SetWindowShape")]
        public unsafe partial int SetWindowShape(Window* window, Surface* shape, WindowShapeModeVal* shape_mode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 147, Column 29 in SDL_shape.h")]
        [NativeApi(EntryPoint = "SDL_GetShapedWindowMode")]
        public unsafe partial int GetShapedWindowMode(Window* window, WindowShapeModeVal* shape_mode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 56, Column 30 in SDL_system.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "SDL_SetWindowsMessageHook")]
        public unsafe partial void SetWindowsMessageHook(PfnWindowsMessageHook callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 75, Column 29 in SDL_system.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "SDL_Direct3D9GetAdapterIndex")]
        public partial int Direct3D9GetAdapterIndex(int displayIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 91, Column 43 in SDL_system.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "SDL_RenderGetD3D9Device")]
        public unsafe partial IDirect3DDevice9* RenderGetD3D9Device(Renderer* renderer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 107, Column 39 in SDL_system.h")]
        [NativeApi(EntryPoint = "SDL_RenderGetD3D11Device")]
        public unsafe partial Silk.NET.Core.Native.IUnknown* RenderGetD3D11Device(Renderer* renderer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 127, Column 39 in SDL_system.h")]
        [NativeApi(EntryPoint = "SDL_RenderGetD3D12Device")]
        public unsafe partial Silk.NET.Core.Native.IUnknown* RenderGetD3D12Device(Renderer* renderer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 151, Column 34 in SDL_system.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "SDL_DXGIGetOutputInfo")]
        public unsafe partial SdlBool DXGIGetOutputInfo(int displayIndex, int* adapterIndex, int* outputIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 225, Column 29 in SDL_system.h")]
        [NativeApi(EntryPoint = "SDL_iPhoneSetAnimationCallback")]
        public unsafe partial int IPhoneSetAnimationCallback(Window* window, int interval, PfnFreeFunc callback, void* callbackParam);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 243, Column 30 in SDL_system.h")]
        [NativeApi(EntryPoint = "SDL_iPhoneSetEventPump")]
        public partial void IPhoneSetEventPump(SdlBool enabled);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 268, Column 32 in SDL_system.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "SDL_AndroidGetJNIEnv")]
        public unsafe partial void* AndroidGetJNIEnv();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 290, Column 32 in SDL_system.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "SDL_AndroidGetActivity")]
        public unsafe partial void* AndroidGetActivity();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 322, Column 29 in SDL_system.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "SDL_GetAndroidSDKVersion")]
        public partial int GetAndroidSDKVersion();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 331, Column 34 in SDL_system.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "SDL_IsAndroidTV")]
        public partial SdlBool IsAndroidTV();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 340, Column 34 in SDL_system.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "SDL_IsChromebook")]
        public partial SdlBool IsChromebook();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 349, Column 34 in SDL_system.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "SDL_IsDeXMode")]
        public partial SdlBool IsDeXMode();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 356, Column 30 in SDL_system.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "SDL_AndroidBackButton")]
        public partial void AndroidBackButton();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 381, Column 38 in SDL_system.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "SDL_AndroidGetInternalStoragePath")]
        public unsafe partial byte* AndroidGetInternalStoragePath();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 398, Column 29 in SDL_system.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "SDL_AndroidGetExternalStorageState")]
        public partial int AndroidGetExternalStorageState();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 416, Column 38 in SDL_system.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "SDL_AndroidGetExternalStoragePath")]
        public unsafe partial byte* AndroidGetExternalStoragePath();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 428, Column 34 in SDL_system.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "SDL_AndroidRequestPermission")]
        public unsafe partial SdlBool AndroidRequestPermission([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* permission);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 453, Column 29 in SDL_system.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "SDL_AndroidShowToast")]
        public unsafe partial int AndroidShowToast([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* message, int duration, int gravity, int xoffset, int yoffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 465, Column 29 in SDL_system.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "SDL_AndroidSendMessage")]
        public partial int AndroidSendMessage(uint command, int param);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 536, Column 41 in SDL_system.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "SDL_WinRTGetFSPathUNICODE")]
        public unsafe partial char* WinRTGetFSPathUNICODE(WinRTPath pathType);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 559, Column 38 in SDL_system.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "SDL_WinRTGetFSPathUTF8")]
        public unsafe partial byte* WinRTGetFSPathUTF8(WinRTPath pathType);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 568, Column 48 in SDL_system.h")]
        [ExcludeFromOverride(0)]
        [NativeApi(EntryPoint = "SDL_WinRTGetDeviceFamily")]
        public partial WinRTDeviceFamily WinRTGetDeviceFamily();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 581, Column 34 in SDL_system.h")]
        [NativeApi(EntryPoint = "SDL_IsTablet")]
        public partial SdlBool IsTablet();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 584, Column 30 in SDL_system.h")]
        [NativeApi(EntryPoint = "SDL_OnApplicationWillTerminate")]
        public partial void OnApplicationWillTerminate();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 585, Column 30 in SDL_system.h")]
        [NativeApi(EntryPoint = "SDL_OnApplicationDidReceiveMemoryWarning")]
        public partial void OnApplicationDidReceiveMemoryWarning();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 586, Column 30 in SDL_system.h")]
        [NativeApi(EntryPoint = "SDL_OnApplicationWillResignActive")]
        public partial void OnApplicationWillResignActive();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 587, Column 30 in SDL_system.h")]
        [NativeApi(EntryPoint = "SDL_OnApplicationDidEnterBackground")]
        public partial void OnApplicationDidEnterBackground();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 588, Column 30 in SDL_system.h")]
        [NativeApi(EntryPoint = "SDL_OnApplicationWillEnterForeground")]
        public partial void OnApplicationWillEnterForeground();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 589, Column 30 in SDL_system.h")]
        [NativeApi(EntryPoint = "SDL_OnApplicationDidBecomeActive")]
        public partial void OnApplicationDidBecomeActive();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 591, Column 30 in SDL_system.h")]
        [NativeApi(EntryPoint = "SDL_OnApplicationDidChangeStatusBarOrientation")]
        public partial void OnApplicationDidChangeStatusBarOrientation();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 58, Column 32 in SDL_timer.h")]
        [NativeApi(EntryPoint = "SDL_GetTicks")]
        public partial uint GetTicks();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 82, Column 32 in SDL_timer.h")]
        [NativeApi(EntryPoint = "SDL_GetTicks64")]
        public partial ulong GetTicks64();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 123, Column 32 in SDL_timer.h")]
        [NativeApi(EntryPoint = "SDL_GetPerformanceCounter")]
        public partial ulong GetPerformanceCounter();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 134, Column 32 in SDL_timer.h")]
        [NativeApi(EntryPoint = "SDL_GetPerformanceFrequency")]
        public partial ulong GetPerformanceFrequency();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 147, Column 30 in SDL_timer.h")]
        [NativeApi(EntryPoint = "SDL_Delay")]
        public partial void Delay(uint ms);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 196, Column 37 in SDL_timer.h")]
        [NativeApi(EntryPoint = "SDL_AddTimer")]
        public unsafe partial int AddTimer(uint interval, PfnTimerCallback callback, void* param);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 211, Column 34 in SDL_timer.h")]
        [NativeApi(EntryPoint = "SDL_RemoveTimer")]
        public partial SdlBool RemoveTimer(int id);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 141, Column 30 in SDL_version.h")]
        [NativeApi(EntryPoint = "SDL_GetVersion")]
        public unsafe partial void GetVersion(Version* ver);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 170, Column 37 in SDL_version.h")]
        [NativeApi(EntryPoint = "SDL_GetRevision")]
        public unsafe partial byte* GetRevision();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 193, Column 44 in SDL_version.h")]
        [NativeApi(EntryPoint = "SDL_GetRevisionNumber")]
        public partial int GetRevisionNumber();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 91, Column 38 in SDL_locale.h")]
        [NativeApi(EntryPoint = "SDL_GetPreferredLocales")]
        public unsafe partial Locale* GetPreferredLocales();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 69, Column 29 in SDL_misc.h")]
        [NativeApi(EntryPoint = "SDL_OpenURL")]
        public unsafe partial int OpenURL([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* url);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 144, Column 29 in SDL.h")]
        [NativeApi(EntryPoint = "SDL_Init")]
        public partial int Init(uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 29 in SDL.h")]
        [NativeApi(EntryPoint = "SDL_InitSubSystem")]
        public partial int InitSubSystem(uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 183, Column 30 in SDL.h")]
        [NativeApi(EntryPoint = "SDL_QuitSubSystem")]
        public partial void QuitSubSystem(uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 199, Column 32 in SDL.h")]
        [NativeApi(EntryPoint = "SDL_WasInit")]
        public partial uint WasInit(uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 223, Column 30 in SDL.h")]
        [NativeApi(EntryPoint = "SDL_Quit")]
        public partial void Quit();


        public Sdl(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

