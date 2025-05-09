using BlazorWindKit.Core.Attributes;

namespace BlazorWindKit.Core.Enums;

public enum TwAlignment
{
    [TailwindClass("items-start")]
    Start,
    [TailwindClass("items-center")]
    Center,
    [TailwindClass("items-end")]
    End,
    [TailwindClass("justify-between")]
    Between,
    [TailwindClass("justify-around")]
    Around,
    [TailwindClass("justify-evenly")]
    Evenly,
    [TailwindClass("items-stretch")]
    Stretch
}
