using BlazorWindKit.Core;
using Microsoft.AspNetCore.Components;

namespace BlazorWindKit;

public abstract class BlazorWindComponent : ComponentBase
{
    protected BlazorWindBuilder Classes { get; } = BlazorWindBuilder.Create();

    /// <summary>
    /// Gets or sets the additional CSS class names for the component.
    /// </summary>
    [Parameter]
    public string? Class { get; set; }

    /// <summary>
    /// Gets or sets the additional CSS class names for the component.
    /// </summary>
    [Parameter]
    public string? Style { get; set; }

    /// <summary>
    /// Gets or sets the additional attributes for the component.
    /// </summary>
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    /// <summary>
    /// Gets the combined CSS classes for the component.
    /// </summary>
    protected string GetCssClasses()
    {
        var classes = Classes.Build();
        return string.IsNullOrEmpty(Class) ? classes : $"{classes} {Class}";
    }

    /// <summary>
    /// Gets the combined CSS styles for the component.
    /// </summary>
    protected string GetCssStyles()
    {
        return Style ?? string.Empty;
    }

    /// <summary>
    /// Gets the combined attributes for the component.
    /// </summary>
    protected Dictionary<string, object> GetAttributes()
    {
        var attributes = new Dictionary<string, object>
        {
            { "class", GetCssClasses() }
        };

        if (!string.IsNullOrEmpty(Style))
        {
            attributes.Add("style", Style);
        }

        if (AdditionalAttributes != null)
        {
            foreach (var attribute in AdditionalAttributes)
            {
                attributes[attribute.Key] = attribute.Value;
            }
        }

        return attributes;
    }
} 