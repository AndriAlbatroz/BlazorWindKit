using BlazorWindKit.Core.Attributes;
using BlazorWindKit.Core.Enums;
using System;
using System.Linq;
using System.Reflection;

namespace BlazorWindKit.Core.Extensions;

public static class EnumExtensions
{
    public static string ToTailwindClass(this Enum value, string? prefix = null, params string[] stringFormat)
    {
        var attribute = value.GetType().GetField(value.ToString())?.GetCustomAttribute<TailwindClassAttribute>();

        if (attribute == null)
        {
            return value.ToString().ToLower();
        }

        string css = attribute.ClassName;

        if (stringFormat.Length > 0) 
        {
            css = string.Format(attribute.ClassName, stringFormat);
        }

        return string.IsNullOrEmpty(prefix) ? css : $"{prefix}-{css}";
    }

    public static string ToTailwindClass(this TwColor color, string? prefix = null, int? shade = null, double? opacity = null)
    {
        var colorName = color.ToString().ToLower();
        var className = $"{prefix}-{colorName}";

        if (shade.HasValue)
        {
            className += $"-{shade}";
        }

        if (opacity.HasValue)
        {
            className += $"/{opacity * 100}";
        }

        return className;
    }
} 