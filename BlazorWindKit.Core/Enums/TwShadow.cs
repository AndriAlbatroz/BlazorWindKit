using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorWindKit.Core.Attributes;

namespace BlazorWindKit.Core.Enums;

/// <summary>
/// Represents the box shadow values from Tailwind CSS 4.x
/// </summary>
public enum TwShadow
{
    /// <summary>
    /// No shadow
    /// </summary>
    [TailwindClass("shadow-none")]
    None,

    /// <summary>
    /// Extra extra small shadow
    /// </summary>
    [TailwindClass("shadow-2xs")]
    Xs2,

    /// <summary>
    /// Extra small shadow
    /// </summary>
    [TailwindClass("shadow-xs")]
    Xs,

    /// <summary>
    /// Small shadow
    /// </summary>
    [TailwindClass("shadow-sm")]
    Sm,

    /// <summary>
    /// Medium shadow
    /// </summary>
    [TailwindClass("shadow-md")]
    Md,

    /// <summary>
    /// Large shadow
    /// </summary>
    [TailwindClass("shadow-lg")]
    Lg,

    /// <summary>
    /// Extra large shadow
    /// </summary>
    [TailwindClass("shadow-xl")]
    Xl,

    /// <summary>
    /// Extra extra large shadow
    /// </summary>
    [TailwindClass("shadow-2xl")]
    Xl2,

    /// <summary>
    /// Inner / inset shadow
    /// </summary>
    [TailwindClass("shadow-inset")]
    Inset
}
