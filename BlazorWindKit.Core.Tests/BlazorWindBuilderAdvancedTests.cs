using BlazorWindKit.Core;
using BlazorWindKit.Core.Enums;
using Xunit;

namespace BlazorWindKit.Core.Tests;

public class BlazorWindBuilderAdvancedTests
{
    [Fact]
    public void CreateButton_WithHoverAndFocus_AddsCorrectClasses()
    { 
        var builder = BlazorWindBuilder.Create();
        builder
            .BackgroundColor(TwColor.Blue, 600)
            .TextColor(TwColor.White)
            .Padding(3)
            .PaddingX(6)
            .BorderRadius(6)
            .FontWeight(TwFontWeight.FontMedium)
            .Hover(b => b
                .BackgroundColor(TwColor.Blue, 700)
                .Transform(TwTransform.Gpu)
                .Scale(105))
            .Focus(b => b
                .Ring(2)
                .RingColor(TwColor.Blue, 500)
                .Outline(TwOutline.None));

        var expected = "bg-blue-600 text-white p-3 px-6 rounded-6 font-medium hover:bg-blue-700 hover:transform-gpu hover:scale-105 focus:ring-2 focus:ring-blue-500 focus:outline-none";
        Assert.Equal(expected, builder.Build());
    }

    [Fact]
    public void CreateCard_WithResponsiveDesign_AddsCorrectClasses()
    {
        var builder = BlazorWindBuilder.Create();
        builder
            .BackgroundColor(TwColor.White)
            .BorderRadius(8)
            .Shadow(2)
            .Padding(6)
            .Sm(b => b
                .Padding(8)
                .GridCols(2)
                .Gap(6))
            .Lg(b => b
                .Padding(12)
                .GridCols(3)
                .Gap(8));

        var expected = "bg-white rounded-8 shadow-2 p-6 sm:p-8 sm:grid-cols-2 sm:gap-6 lg:p-12 lg:grid-cols-3 lg:gap-8";
        Assert.Equal(expected, builder.Build());
    }

    [Fact]
    public void CreateNavigation_WithActiveState_AddsCorrectClasses()
    {
        var builder = BlazorWindBuilder.Create();
        builder
            .Display(TwDisplay.Flex)
            .Gap(4)
            .Padding(4)
            .BackgroundColor(TwColor.Gray, 100)
            .Active(b => b
                .BackgroundColor(TwColor.Blue, 500)
                .TextColor(TwColor.White)
                .FontWeight(TwFontWeight.FontBold));

        var expected = "flex gap-4 p-4 bg-gray-100 active:bg-blue-500 active:text-white active:font-bold";
        Assert.Equal(expected, builder.Build());
    }

    [Fact]
    public void CreateFormInput_WithValidation_AddsCorrectClasses()
    {
        var builder = BlazorWindBuilder.Create();
        builder
            .FormInput()
            .Padding(2)
            .BorderWidth(1)
            .BorderColor(TwColor.Gray, 300)
            .BorderRadius(4)
            .WidthFull()
            .Valid(b => b
                .BorderColor(TwColor.Green, 500))
            .Invalid(b => b
                .BorderColor(TwColor.Red, 500)
                .Ring(1)
                .RingColor(TwColor.Red, 500));

        var expected = "form-input p-2 border border-gray-300 rounded-4 w-full valid:border-green-500 invalid:border-red-500 invalid:ring-1 invalid:ring-red-500";
        Assert.Equal(expected, builder.Build());
    }

    [Fact]
    public void CreateModal_WithAnimation_AddsCorrectClasses()
    {
        var builder = BlazorWindBuilder.Create();
        builder
            .Fixed()
            .Inset(0)
            .BackgroundColor(TwColor.Black, opacity: .5)
            .Display(TwDisplay.Flex)
            .Items(TwAlignItems.Center)
            .Justify(TwJustifyContent.Center)
            .Animate(TwAnimation.FadeIn)
            .Transition(TwTransition.All)
            .BackdropBlurSm();

        var expected = "fixed inset-0 bg-black/50 flex items-center justify-center animate-fade-in transition-all backdrop-blur-sm";
        Assert.Equal(expected, builder.Build());
    }

    [Fact]
    public void CreateDropdown_WithHoverAndFocus_AddsCorrectClasses()
    {
        var builder = BlazorWindBuilder.Create();
        builder
            .Position(TwPosition.Relative)
            .Display(TwDisplay.InlineBlock)
            .Hover(b => b
                .Display(TwDisplay.Block))
            .Focus(b => b
                .Outline(TwOutline.None)
                .Ring(2)
                .RingColor(TwColor.Blue, 500))
            .Show(b => b
                .Display(TwDisplay.Block)
                .Animate(TwAnimation.FadeIn));

        var expected = "relative inline-block hover:block focus:outline-none focus:ring-2 focus:ring-blue-500 show:block show:animate-fade-in";
        Assert.Equal(expected, builder.Build());
    }

    [Fact]
    public void CreateTooltip_WithPosition_AddsCorrectClasses()
    {
        var builder = BlazorWindBuilder.Create();
        builder
            .Position(TwPosition.Absolute)
            .ZIndex(50)
            .BackgroundColor(TwColor.Gray, 900)
            .TextColor(TwColor.White)
            .Padding(2)
            .BorderRadius(4)
            .FontSize(TwTextSize.Sm)
            .Whitespace(TwWhitespace.NoWrap)
            .Transform(TwTransform.Gpu)
            .Scale(0);

        var expected = "absolute z-50 bg-gray-900 text-white p-2 rounded-4 text-sm whitespace-nowrap transform-gpu scale-0";
        Assert.Equal(expected, builder.Build());
    }
} 