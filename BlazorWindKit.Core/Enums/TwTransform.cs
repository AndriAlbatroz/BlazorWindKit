using BlazorWindKit.Core.Attributes;

namespace BlazorWindKit.Core.Enums;

public enum TwTransform
{
    [TailwindClass("transform-none")]
    None,

    [TailwindClass("transform-gpu")]
    Gpu,

    [TailwindClass("transform-cpu")]
    Cpu,

    [TailwindClass("origin-center")]
    OriginCenter,

    [TailwindClass("origin-top")]
    OriginTop,

    [TailwindClass("origin-top-right")]
    OriginTopRight,

    [TailwindClass("origin-right")]
    OriginRight,

    [TailwindClass("origin-bottom-right")]
    OriginBottomRight,

    [TailwindClass("origin-bottom")]
    OriginBottom,

    [TailwindClass("origin-bottom-left")]
    OriginBottomLeft,

    [TailwindClass("origin-left")]
    OriginLeft,

    [TailwindClass("origin-top-left")]
    OriginTopLeft
} 