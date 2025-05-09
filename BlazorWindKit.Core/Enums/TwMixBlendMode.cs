using BlazorWindKit.Core.Attributes;

namespace BlazorWindKit.Core.Enums;

public enum TwMixBlendMode
{
    [TailwindClass("mix-blend-normal")]
    Normal,

    [TailwindClass("mix-blend-multiply")]
    Multiply,

    [TailwindClass("mix-blend-screen")]
    Screen,

    [TailwindClass("mix-blend-overlay")]
    Overlay,

    [TailwindClass("mix-blend-darken")]
    Darken,

    [TailwindClass("mix-blend-lighten")]
    Lighten,

    [TailwindClass("mix-blend-color-dodge")]
    ColorDodge,

    [TailwindClass("mix-blend-color-burn")]
    ColorBurn,

    [TailwindClass("mix-blend-hard-light")]
    HardLight,

    [TailwindClass("mix-blend-soft-light")]
    SoftLight,

    [TailwindClass("mix-blend-difference")]
    Difference,

    [TailwindClass("mix-blend-exclusion")]
    Exclusion,

    [TailwindClass("mix-blend-hue")]
    Hue,

    [TailwindClass("mix-blend-saturation")]
    Saturation,

    [TailwindClass("mix-blend-color")]
    Color,

    [TailwindClass("mix-blend-luminosity")]
    Luminosity
} 