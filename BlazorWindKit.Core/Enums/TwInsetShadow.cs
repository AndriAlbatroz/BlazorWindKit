using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorWindKit.Core.Attributes;

namespace BlazorWindKit.Core.Enums;

/// <summary>
/// Represents the inset box shadow values from Tailwind CSS 4.x
/// </summary>
public enum TwInsetShadow
{
    /// <summary>
    /// No inset shadow
    /// </summary>
    [TailwindClass("inset-shadow-none")]
    None,

    /// <summary>
    /// Extra extra small inset shadow
    /// </summary>
    [TailwindClass("inset-shadow-2xs")]
    Xs2,

    /// <summary>
    /// Extra small inset shadow
    /// </summary>
    [TailwindClass("inset-shadow-xs")]
    Xs,

    /// <summary>
    /// Small inset shadow
    /// </summary>
    [TailwindClass("inset-shadow-sm")]
    Sm,
    
    /// <summary>
    /// Medium inset shadow
    /// </summary>
    [TailwindClass("inset-shadow-md")]
    Md,

    /// <summary>
    /// Large inset shadow
    /// </summary>
    [TailwindClass("inset-shadow-lg")]
    Lg,

    /// <summary>
    /// Extra large inset shadow
    /// </summary>
    [TailwindClass("inset-shadow-xl")]
    Xl,

    /// <summary>
    /// Extra extra large inset shadow
    /// </summary>
    [TailwindClass("inset-shadow-2xl")]
    Xl2
} 