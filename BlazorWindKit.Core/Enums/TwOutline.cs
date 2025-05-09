using BlazorWindKit.Core.Attributes;

namespace BlazorWindKit.Core.Enums;

public enum TwOutline
{
    [TailwindClass("outline-none")]
    None,

    [TailwindClass("outline-dashed")]
    Dashed,

    [TailwindClass("outline-dotted")]
    Dotted,

    [TailwindClass("outline-double")]
    Double,

    [TailwindClass("outline-hidden")]
    Hidden,

    [TailwindClass("outline-solid")]
    Solid
} 