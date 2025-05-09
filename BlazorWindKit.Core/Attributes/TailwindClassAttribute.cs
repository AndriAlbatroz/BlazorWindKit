using System;

namespace BlazorWindKit.Core.Attributes;

[AttributeUsage(AttributeTargets.Field)]
public class TailwindClassAttribute : Attribute
{
    public string ClassName { get; }

    public TailwindClassAttribute(string className)
    {
        ClassName = className;
    }
}

public enum TailwindCategory
{
    None,
    Backdrop,
    Blend,
    Color,
    Divide,
    Fill,
    Ring,
    RingOffset,
    Stroke,
    Transform,
    Typography,
    Layout,
    Border,
    Effect,
    Transition,
    Animation,
    Interactivity,
    Sizing,
    Spacing,
    Accessibility
} 