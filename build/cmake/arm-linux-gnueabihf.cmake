set(CMAKE_SYSTEM_NAME Linux)
set(CMAKE_SYSTEM_PROCESSOR armv7l)
set(CMAKE_ASM_COMPILER "/usr/bin/arm-linux-gnueabihf-as")
set(CMAKE_C_COMPILER "/usr/bin/arm-linux-gnueabihf-gcc")
set(CMAKE_CXX_COMPILER "/usr/bin/arm-linux-gnueabihf-g++")
set(CMAKE_LINKER "/usr/bin/arm-linux-gnueabihf-ld")
set(PKG_CONFIG_EXECUTABLE "/usr/bin/pkg-config")
set(ENV{PKG_CONFIG_LIBDIR} "/usr/lib/arm-linux-gnueabihf/pkgconfig")
set(ENV{PKG_CONFIG_PATH} "/usr/lib/pkgconfig:/usr/share/pkgconfig")
set(CMAKE_FIND_ROOT_PATH "/usr/arm-linux-gnueabihf")
set(CMAKE_FIND_ROOT_PATH_MODE_PROGRAM NEVER)
set(CMAKE_FIND_ROOT_PATH_MODE_LIBRARY BOTH)
set(CMAKE_FIND_ROOT_PATH_MODE_INCLUDE BOTH)
set(CMAKE_FIND_ROOT_PATH_MODE_PACKAGE BOTH)
