using BlazorWindKit.Core.Attributes;

namespace BlazorWindKit.Core.Enums;
public enum TwAnimation
{
    [TailwindClass("animate-none")]
    None,
    [TailwindClass("animate-spin")]
    Spin,
    [TailwindClass("animate-ping")]
    Ping,
    [TailwindClass("animate-pulse")]
    Pulse,
    [TailwindClass("animate-bounce")]
    Bounce,
    [TailwindClass("animate-fade-in")]
    FadeIn,
    [TailwindClass("animate-fade-out")]
    FadeOut
}
