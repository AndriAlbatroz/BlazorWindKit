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