using BlazorWindKit.Core.Attributes;

namespace BlazorWindKit.Core.Enums;

public enum TwBorderStyle
{
    [TailwindClass("border-solid")]
    Solid,
    [TailwindClass("border-dashed")]
    Dashed,
    [TailwindClass("border-dotted")]
    Dotted,
    [TailwindClass("border-double")]
    Double,
    [TailwindClass("border-hidden")]
    Hidden,
    [TailwindClass("border-none")]
    None
}