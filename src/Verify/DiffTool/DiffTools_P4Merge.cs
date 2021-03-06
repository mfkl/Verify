﻿static partial class DiffTools
{
    public static DiffTool P4Merge() => new DiffTool(
        name: "P4Merge",
        url: "https://www.perforce.com/products/helix-core-apps/merge-diff-tool-p4merge",
        argumentPrefix: string.Empty,
        windowsExePaths: new[]
        {
            @"%ProgramFiles%\Perforce\p4merge.exe"
        },
        osxExePaths: new[]
        {
            @"/Applications/p4merge.app/Contents/MacOS/p4merge"
        },
        linuxExePaths: new[]
        {
            @"/usr/bin/p4merge"
        },
        binaryExtensions: new[]
        {
            "bmp",
            "gif",
            "jpg",
            "jpeg",
            "png",
            "pbm",
            "pgm",
            "ppm",
            "tiff",
            "xbm",
            "xpm"
        });
}