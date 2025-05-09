using BlazorWindKit.Core.Attributes;

namespace BlazorWindKit.Core.Enums;

public enum TwRounded
{
    [TailwindClass("rounded-none")]
    None,
    [TailwindClass("rounded-sm")]
    Sm,
    [TailwindClass("rounded-md")]
    Md,
    [TailwindClass("rounded-lg")]
    Lg,
    [TailwindClass("rounded-xl")]
    Xl,
    [TailwindClass("rounded-2xl")]
    TwoXl,
    [TailwindClass("rounded-full")]
    Full
}