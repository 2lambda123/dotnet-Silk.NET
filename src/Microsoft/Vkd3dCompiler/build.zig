const std = @import("std");
const fs = std.fs;

pub fn build(b: *std.Build) void {
    const target = b.standardTargetOptions(.{});
    const mode = b.standardOptimizeOption(.{});

    const shared_lib_options: std.build.SharedLibraryOptions = .{
        .name = "d3dcompile_vkd3d",
        .target = target,
        .optimize = mode,
    };

    const vkd3d_shim: *std.build.LibExeObjStep = b.addSharedLibrary(shared_lib_options);
    vkd3d_shim.addLibraryPath(".");
    vkd3d_shim.linkSystemLibraryName("vkd3d-shader");
    //Since we statically link with vkd3d-shader, we need to dynamically link against SPIRV-Tools ourselves
    vkd3d_shim.linkSystemLibraryName("SPIRV-Tools-shared");
    vkd3d_shim.linkLibC();

    vkd3d_shim.addCSourceFiles(&.{"lib.c"}, &.{"-std=c99", "-fPIC"});
    vkd3d_shim.addSystemIncludePath("../../../build/submodules/vkd3d/include/");
    vkd3d_shim.install();
}
