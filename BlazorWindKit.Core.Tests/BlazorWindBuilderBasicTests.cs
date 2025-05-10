using BlazorWindKit.Core;
using BlazorWindKit.Core.Enums;
using Xunit;

namespace BlazorWindKit.Core.Tests;

public class BlazorWindBuilderBasicTests
{
    [Fact]  
    public void Create_ReturnsNewInstance()
    {
        var builder = BlazorWindBuilder.Create();
        Assert.NotNull(builder);
    }

    [Fact]
    public void Add_WithValidClass_AddsClass()
    {
        var builder = BlazorWindBuilder.Create();
        builder.Add("test-class");
        Assert.Equal("test-class", builder.Build());
    }

    [Fact]
    public void Add_WithCondition_AddsClassWhenTrue()
    {
        var builder = BlazorWindBuilder.Create();
        builder.Add(true, "test-class");
        Assert.Equal("test-class", builder.Build());
    }

    [Fact]
    public void Add_WithCondition_DoesNotAddClassWhenFalse()
    {
        var builder = BlazorWindBuilder.Create();
        builder.Add(false, "test-class");
        Assert.Equal("", builder.Build());
    }

    [Fact]
    public void Custom_AddsRawClass()
    {
        var builder = BlazorWindBuilder.Create();
        builder.Custom("custom-class");
        Assert.Equal("custom-class", builder.Build());
    }

    [Fact]
    public void Responsive_AddsPrefixToClasses()
    {
        var builder = BlazorWindBuilder.Create();
        builder.Sm(b => b.Add("test-class"));
        Assert.Equal("sm:test-class", builder.Build());
    }

    [Fact]
    public void State_AddsPrefixToClasses()
    {
        var builder = BlazorWindBuilder.Create();
        builder.Hover(b => b.Add("test-class"));
        Assert.Equal("hover:test-class", builder.Build());
    }

    [Fact]
    public void Color_AddsColorClass()
    {
        var builder = BlazorWindBuilder.Create();
        builder.BackgroundColor(TwColor.Blue);
        Assert.Equal("bg-blue", builder.Build());
    }

    [Fact]
    public void Color_AddsColorShadeClass()
    {
        var builder = BlazorWindBuilder.Create();
        builder.BackgroundColor(TwColor.Blue, 500);
        Assert.Equal("bg-blue-500", builder.Build());
    }

    [Fact]
    public void Spacing_AddsSpacingClass()
    {
        var builder = BlazorWindBuilder.Create();
        builder.Padding(4);
        Assert.Equal("p-4", builder.Build());
    }

    [Fact]
    public void Sizing_AddsSizingClass()
    {
        var builder = BlazorWindBuilder.Create();
        builder.Width(4);
        Assert.Equal("w-4", builder.Build());
    }

    [Fact]
    public void Typography_AddsTypographyClass()
    {
        var builder = BlazorWindBuilder.Create();
        builder.FontSize(TwTextSize.Lg);
        Assert.Equal("text-lg", builder.Build());
    }

    [Fact]
    public void Border_AddsBorderClass()
    {
        var builder = BlazorWindBuilder.Create();
        builder.BorderWidth(2);
        Assert.Equal("border-2", builder.Build());
    }

    [Fact]
    public void Effects_AddsEffectsClass()
    {
        var builder = BlazorWindBuilder.Create();
        builder.Opacity(50);
        Assert.Equal("opacity-50", builder.Build());
    }

    [Fact]
    public void Transition_AddsTransitionClass()
    {
        var builder = BlazorWindBuilder.Create();
        builder.Transition(TwTransition.All);
        Assert.Equal("transition-all", builder.Build());
    }

    [Fact]
    public void Transform_AddsTransformClass()
    {
        var builder = BlazorWindBuilder.Create();
        builder.Transform(TwTransform.Gpu);
        Assert.Equal("transform-gpu", builder.Build());
    }

    [Fact]
    public void Interactivity_AddsInteractivityClass()
    {
        var builder = BlazorWindBuilder.Create();
        builder.Cursor(TwInteractivity.CursorPointer);
        Assert.Equal("cursor-pointer", builder.Build());
    }

    [Fact]
    public void Layout_AddsLayoutClass()
    {
        var builder = BlazorWindBuilder.Create();
        builder.Display(TwDisplay.Flex);
        Assert.Equal("flex", builder.Build());
    }

    [Fact]
    public void Form_AddsFormClass()
    {
        var builder = BlazorWindBuilder.Create();
        builder.FormInput();
        Assert.Equal("form-input", builder.Build());
    }

    [Fact]
    public void SVG_AddsSVGClass()
    {
        var builder = BlazorWindBuilder.Create();
        builder.StrokeWidth(2);
        Assert.Equal("stroke-2", builder.Build());
    }

    [Fact]
    public void Accessibility_AddsAccessibilityClass()
    {
        var builder = BlazorWindBuilder.Create();
        builder.ScreenReaderOnly();
        Assert.Equal("sr-only", builder.Build());
    }

    [Fact]
    public void Animation_AddsAnimationClass()
    {
        var builder = BlazorWindBuilder.Create();
        builder.Animate(TwAnimation.Spin);
        Assert.Equal("animate-spin", builder.Build());
    }
} 