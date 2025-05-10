using BlazorWindKit.Core.Attributes;

namespace BlazorWindKit.Core.Enums;

public enum TwRounded
{
    [TailwindClass("rounded{0}-none")]
    None,
    [TailwindClass("rounded{0}-sm")]
    Sm,
    [TailwindClass("rounded{0}-md")]
    Md,
    [TailwindClass("rounded{0}-lg")]
    Lg,
    [TailwindClass("rounded{0}-xl")]
    Xl,
    [TailwindClass("rounded{0}-2xl")]
    TwoXl,
    [TailwindClass("rounded{0}-full")]
    Full
}