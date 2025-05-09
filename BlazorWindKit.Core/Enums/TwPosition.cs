using BlazorWindKit.Core.Attributes;

namespace BlazorWindKit.Core.Enums;

public enum TwPosition
{
    [TailwindClass("static")]
    Static,
    [TailwindClass("relative")]
    Relative,
    [TailwindClass("absolute")]
    Absolute,
    [TailwindClass("fixed")]
    Fixed,
    [TailwindClass("sticky")]
    Sticky
}