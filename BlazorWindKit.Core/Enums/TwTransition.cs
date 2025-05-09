using BlazorWindKit.Core.Attributes;

namespace BlazorWindKit.Core.Enums;

public enum TwTransition
{
    [TailwindClass("transition-none")]
    None,

    [TailwindClass("transition-all")]
    All,

    [TailwindClass("transition")]
    Default,

    [TailwindClass("transition-colors")]
    Colors,

    [TailwindClass("transition-opacity")]
    Opacity,

    [TailwindClass("transition-shadow")]
    Shadow,

    [TailwindClass("transition-transform")]
    Transform
}