using BlazorWindKit.Core.Enums;
using BlazorWindKit.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWindKit.Core;

public class BlazorWindBuilder
{
    private readonly HashSet<string> _classes = new();

    public static BlazorWindBuilder Create() => new();

    public BlazorWindBuilder Add(string cssClass)
    {
        if (!string.IsNullOrWhiteSpace(cssClass)) 
        {
            _classes.Add(cssClass);
        } 
        return this;
    }

    public BlazorWindBuilder Add(bool condition, string cssClass)
    {
        if (condition && !string.IsNullOrWhiteSpace(cssClass))
        {
            _classes.Add(cssClass);
        }
        return this;
    }
    
    public BlazorWindBuilder When(bool condition, Func<BlazorWindBuilder, BlazorWindBuilder> builder)
    {
        if (condition)
        {
            var innerBuilder = new BlazorWindBuilder();
            var result = builder(innerBuilder);
            foreach (var cls in result._classes)
            {
                _classes.Add(cls);
            }
        }
        return this;
    }

    public BlazorWindBuilder When(Func<bool> condition, Func<BlazorWindBuilder, BlazorWindBuilder> builder)
    {
        if (condition())
        {
            var innerBuilder = new BlazorWindBuilder();
            var result = builder(innerBuilder);
            foreach (var cls in result._classes)
            {
                _classes.Add(cls);
            }
        }
        return this;
    }

    public BlazorWindBuilder Custom(string rawCssClass) => Add(rawCssClass);

    #region Responsive variants

    public BlazorWindBuilder Sm(Action<BlazorWindBuilder> config) => Responsive("sm", config);
    public BlazorWindBuilder Md(Action<BlazorWindBuilder> config) => Responsive("md", config);
    public BlazorWindBuilder Lg(Action<BlazorWindBuilder> config) => Responsive("lg", config);
    public BlazorWindBuilder Xl(Action<BlazorWindBuilder> config) => Responsive("xl", config);
    public BlazorWindBuilder Xxl(Action<BlazorWindBuilder> config) => Responsive("2xl", config);

    private BlazorWindBuilder Responsive(string prefix, Action<BlazorWindBuilder> config)
    {
        var inner = new BlazorWindBuilder();
        config(inner);
        foreach (var cls in inner._classes)
        {
            _classes.Add($"{prefix}:{cls}");
        }
        return this;
    }

    #endregion

    #region State variants

    public BlazorWindBuilder Hover(Action<BlazorWindBuilder> config) => Variant("hover", config);
    public BlazorWindBuilder Focus(Action<BlazorWindBuilder> config) => Variant("focus", config);
    public BlazorWindBuilder Active(Action<BlazorWindBuilder> config) => Variant("active", config);
    public BlazorWindBuilder Disabled(Action<BlazorWindBuilder> config) => Variant("disabled", config);
    public BlazorWindBuilder Show(Action<BlazorWindBuilder> config) => Variant("show", config);
    public BlazorWindBuilder Checked(Action<BlazorWindBuilder> config) => Variant("checked", config);
    public BlazorWindBuilder Required(Action<BlazorWindBuilder> config) => Variant("required", config);
    public BlazorWindBuilder Valid(Action<BlazorWindBuilder> config) => Variant("valid", config);
    public BlazorWindBuilder Invalid(Action<BlazorWindBuilder> config) => Variant("invalid", config);
    public BlazorWindBuilder InRange(Action<BlazorWindBuilder> config) => Variant("in-range", config);
    public BlazorWindBuilder OutOfRange(Action<BlazorWindBuilder> config) => Variant("out-of-range", config);
    public BlazorWindBuilder PlaceholderShown(Action<BlazorWindBuilder> config) => Variant("placeholder-shown", config);
    public BlazorWindBuilder Autofill(Action<BlazorWindBuilder> config) => Variant("autofill", config);
    public BlazorWindBuilder ReadOnly(Action<BlazorWindBuilder> config) => Variant("read-only", config);
    public BlazorWindBuilder Empty(Action<BlazorWindBuilder> config) => Variant("empty", config);
    public BlazorWindBuilder Target(Action<BlazorWindBuilder> config) => Variant("target", config);
    public BlazorWindBuilder Open(Action<BlazorWindBuilder> config) => Variant("open", config);
    public BlazorWindBuilder Default(Action<BlazorWindBuilder> config) => Variant("default", config);
    public BlazorWindBuilder Indeterminate(Action<BlazorWindBuilder> config) => Variant("indeterminate", config);

    private BlazorWindBuilder Variant(string prefix, Action<BlazorWindBuilder> config)
    {
        var inner = new BlazorWindBuilder();
        config(inner);
        foreach (var cls in inner._classes)
        {
            _classes.Add($"{prefix}:{cls}");
        }
        return this;
    }

    #endregion

    #region Color methods

    public BlazorWindBuilder BackgroundColor(TwColor color) => Add(color.ToTailwindClass("bg"));
    public BlazorWindBuilder BackgroundColor(TwColor color, int shade) => Add(color.ToTailwindClass("bg", shade));
    public BlazorWindBuilder BackgroundColor(TwColor color, double opacity) => Add(color.ToTailwindClass("bg", opacity: opacity));
    public BlazorWindBuilder BackgroundColor(TwColor color, int shade, int opacity) => Add(color.ToTailwindClass("bg", shade, opacity));

    public BlazorWindBuilder TextColor(TwColor color) => Add(color.ToTailwindClass("text"));
    public BlazorWindBuilder TextColor(TwColor color, int shade) => Add(color.ToTailwindClass("text", shade));
    public BlazorWindBuilder TextColor(TwColor color, double opacity) => Add(color.ToTailwindClass("text", opacity: opacity));
    public BlazorWindBuilder TextColor(TwColor color, int shade, int opacity) => Add(color.ToTailwindClass("text", shade, opacity));

    public BlazorWindBuilder BorderColor(TwColor color) => Add(color.ToTailwindClass("border"));
    public BlazorWindBuilder BorderColor(TwColor color, int shade) => Add(color.ToTailwindClass("border", shade));
    public BlazorWindBuilder BorderColor(TwColor color, double opacity) => Add(color.ToTailwindClass("border", opacity: opacity));
    public BlazorWindBuilder BorderColor(TwColor color, int shade, double opacity) => Add(color.ToTailwindClass("border", shade, opacity));

    public BlazorWindBuilder DivideColor(TwColor color, int shade) => Add(color.ToTailwindClass("divide", shade));
    public BlazorWindBuilder DivideColor(TwColor color, int shade, int opacity) => Add(color.ToTailwindClass("divide", shade, opacity));

    public BlazorWindBuilder RingColor(TwColor color, int shade) => Add(color.ToTailwindClass("ring", shade));
    public BlazorWindBuilder RingColor(TwColor color, int shade, int opacity) => Add(color.ToTailwindClass("ring", shade, opacity));

    public BlazorWindBuilder RingOffsetColor(TwColor color, int shade) => Add(color.ToTailwindClass("ring-offset", shade));
    public BlazorWindBuilder RingOffsetColor(TwColor color, int shade, int opacity) => Add(color.ToTailwindClass("ring-offset", shade, opacity));

    public BlazorWindBuilder BorderTopColor(TwColor color, int shade) => Add(color.ToTailwindClass("border-t", shade));
    public BlazorWindBuilder BorderTopColor(TwColor color, int shade, int opacity) => Add(color.ToTailwindClass("border-t", shade, opacity));

    public BlazorWindBuilder Placeholder(TwColor color, int shade) => Add(color.ToTailwindClass("placeholder", shade));
    public BlazorWindBuilder Placeholder(TwColor color, int shade, int opacity) => Add(color.ToTailwindClass("placeholder", shade, opacity));

    public BlazorWindBuilder Fill(TwColor color, int shade) => Add(color.ToTailwindClass("fill", shade));
    public BlazorWindBuilder Fill(TwColor color, int shade, int opacity) => Add(color.ToTailwindClass("fill", shade, opacity));

    public BlazorWindBuilder Stroke(TwColor color, int shade) => Add(color.ToTailwindClass("stroke", shade));
    public BlazorWindBuilder Stroke(TwColor color, int shade, int opacity) => Add(color.ToTailwindClass("stroke", shade, opacity));

    #endregion

    #region Ring

    public BlazorWindBuilder Ring(int width) => Add($"ring-{width}");
    public BlazorWindBuilder RingInset() => Add($"ring-inset");


    #endregion

    #region Spacing

    public BlazorWindBuilder Padding(int value) => Add($"p-{value}");
    public BlazorWindBuilder PaddingX(int value) => Add($"px-{value}");
    public BlazorWindBuilder PaddingY(int value) => Add($"py-{value}");
    public BlazorWindBuilder Margin(int value) => Add($"m-{value}");
    public BlazorWindBuilder MarginX(int value) => Add($"mx-{value}");
    public BlazorWindBuilder MarginY(int value) => Add($"my-{value}");
    public BlazorWindBuilder Gap(int value) => Add($"gap-{value}");
    public BlazorWindBuilder GapX(int value) => Add($"gap-x-{value}");
    public BlazorWindBuilder GapY(int value) => Add($"gap-y-{value}");
    public BlazorWindBuilder SpaceX(int value) => Add($"space-x-{value}");
    public BlazorWindBuilder SpaceY(int value) => Add($"space-y-{value}");

    #endregion

    #region Sizing

    public BlazorWindBuilder Width(int value) => Add($"w-{value}");
    public BlazorWindBuilder Height(int value) => Add($"h-{value}");

    public BlazorWindBuilder MinWidth(int value) => Add($"min-w-{value}");
    public BlazorWindBuilder MaxWidth(int value) => Add($"max-w-{value}");
    public BlazorWindBuilder MinHeight(int value) => Add($"min-h-{value}");
    public BlazorWindBuilder MaxHeight(int value) => Add($"max-h-{value}");

    // Special sizing values
    public BlazorWindBuilder WidthAuto() => Add("w-auto");
    public BlazorWindBuilder WidthFull() => Add("w-full");
    public BlazorWindBuilder WidthScreen() => Add("w-screen");
    public BlazorWindBuilder WidthMin() => Add("w-min");
    public BlazorWindBuilder WidthMax() => Add("w-max");
    public BlazorWindBuilder WidthFit() => Add("w-fit");

    public BlazorWindBuilder HeightFull() => Add("h-full");

    #endregion

    #region Rounded 

    public BlazorWindBuilder Rounded() => Add("rounded");
    public BlazorWindBuilder Rounded(TwRounded rounded) => Add(rounded.ToTailwindClass());
    public BlazorWindBuilder Rounded(int value) => Add($"rounded-{value}");
    public BlazorWindBuilder RoundedTop(TwRounded rounded) => Add(rounded.ToTailwindClass(stringFormat: new string[] { "-t" }));
    public BlazorWindBuilder RoundedBottom(TwRounded rounded) => Add(rounded.ToTailwindClass(stringFormat: new string[] { "-b" }));
    public BlazorWindBuilder RoundedRight(TwRounded rounded) => Add(rounded.ToTailwindClass(stringFormat: new string[] { "-r" }));
    public BlazorWindBuilder RoundedLeft(TwRounded rounded) => Add(rounded.ToTailwindClass(stringFormat: new string[] { "-l" }));

    #endregion

    #region Typography

    public BlazorWindBuilder FontSize(TwTextSize size) => Add(size.ToTailwindClass());
    public BlazorWindBuilder FontSize(TwTextSize size, int lineHeight) => Add($"{size.ToTailwindClass()}/{lineHeight}"  );
    public BlazorWindBuilder FontWeight(TwFontWeight weight) => Add(weight.ToTailwindClass());
    public BlazorWindBuilder TextAlign(TwTextAlign align) => Add(align.ToTailwindClass());
    public BlazorWindBuilder TextDecoration(TwTextDecoration decoration) => Add(decoration.ToTailwindClass());
    public BlazorWindBuilder TextTransform(TwTextTransform transform) => Add(transform.ToTailwindClass());
    public BlazorWindBuilder TextOverflow(TwTextOverflow overflow) => Add(overflow.ToTailwindClass());
    public BlazorWindBuilder Whitespace(TwWhitespace whitespace) => Add(whitespace.ToTailwindClass());
    public BlazorWindBuilder WordBreak(TwWordBreak wordBreak) => Add(wordBreak.ToTailwindClass());
    public BlazorWindBuilder LetterSpacing(TwLetterSpacing letterSpacing) => Add(letterSpacing.ToTailwindClass());

    #endregion

    #region Border & Shadow

    public BlazorWindBuilder BorderWidth(int value) => Add(value == 1 ? "border" : $"border-{value}");
    public BlazorWindBuilder BorderTopWidth(int value) => Add(value == 1 ? "border-t" : $"border-t-{value}");
    public BlazorWindBuilder BorderRightWidth(int value) => Add(value == 1 ? "border-r" : $"border-r-{value}");
    public BlazorWindBuilder BorderBottomWidth(int value) => Add(value == 1 ? "border-b" : $"border-b-{value}");
    public BlazorWindBuilder BorderLeftWidth(int value) => Add(value == 1 ? "border-l" : $"border-l-{value}");
    public BlazorWindBuilder BorderRadius(int value) => Add($"rounded-{value}");
    public BlazorWindBuilder BorderTopLeftRadius(int value) => Add($"rounded-tl-{value}");
    public BlazorWindBuilder BorderTopRightRadius(int value) => Add($"rounded-tr-{value}");
    public BlazorWindBuilder BorderBottomLeftRadius(int value) => Add($"rounded-bl-{value}");
    public BlazorWindBuilder BorderBottomRightRadius(int value) => Add($"rounded-br-{value}");
    public BlazorWindBuilder Shadow(int value) => Add(value == 1 ? "shadow" : $"shadow-{value}");

    #endregion

    #region Effects

    public BlazorWindBuilder Opacity(int value) => Add($"opacity-{value}");
    
    // Backdrop blur special values
    public BlazorWindBuilder BackdropBlurNone() => Add("backdrop-blur-none");
    public BlazorWindBuilder BackdropBlurSm() => Add("backdrop-blur-sm");
    public BlazorWindBuilder BackdropBlurMd() => Add("backdrop-blur-md");
    public BlazorWindBuilder BackdropBlurLg() => Add("backdrop-blur-lg");
    public BlazorWindBuilder BackdropBlurXl() => Add("backdrop-blur-xl");
    public BlazorWindBuilder BackdropBlur2Xl() => Add("backdrop-blur-2xl");
    public BlazorWindBuilder BackdropBlur3Xl() => Add("backdrop-blur-3xl");
    
    // Other backdrop effects
    public BlazorWindBuilder BackdropBrightness(int value) => Add($"backdrop-brightness-{value}");
    public BlazorWindBuilder BackdropContrast(int value) => Add($"backdrop-contrast-{value}");
    public BlazorWindBuilder BackdropGrayscale(int value) => Add($"backdrop-grayscale-{value}");
    public BlazorWindBuilder BackdropHueRotate(int value) => Add($"backdrop-hue-rotate-{value}");
    public BlazorWindBuilder BackdropInvert(int value) => Add($"backdrop-invert-{value}");
    public BlazorWindBuilder BackdropOpacity(int value) => Add($"backdrop-opacity-{value}");
    public BlazorWindBuilder BackdropSaturate(int value) => Add($"backdrop-saturate-{value}");
    public BlazorWindBuilder BackdropSepia(int value) => Add($"backdrop-sepia-{value}");

    #endregion

    #region Transition
    public BlazorWindBuilder Transition(TwTransition transition) => Add(transition.ToTailwindClass());
    public BlazorWindBuilder TransitionDuration(TwTransition duration) => Add(duration.ToTailwindClass());
    public BlazorWindBuilder TransitionEase(TwTransition ease) => Add(ease.ToTailwindClass());
    public BlazorWindBuilder TransitionDelay(TwTransition delay) => Add(delay.ToTailwindClass());
    #endregion

    #region Transform
    public BlazorWindBuilder Transform(TwTransform transform) => Add(transform.ToTailwindClass());
    public BlazorWindBuilder TransformOrigin(TwTransform origin) => Add(origin.ToTailwindClass());
    
    // Scale methods with numeric values
    public BlazorWindBuilder Scale(int value) => Add($"scale-{value}");
    public BlazorWindBuilder ScaleX(int value) => Add($"scale-x-{value}");
    public BlazorWindBuilder ScaleY(int value) => Add($"scale-y-{value}");
    
    // Rotate methods with numeric values
    public BlazorWindBuilder Rotate(int value) => Add($"rotate-{value}");
    
    // Translate methods with numeric values
    public BlazorWindBuilder TranslateX(int value) => Add($"translate-x-{value}");
    public BlazorWindBuilder TranslateY(int value) => Add($"translate-y-{value}");
    
    // Skew methods with numeric values
    public BlazorWindBuilder SkewX(int value) => Add($"skew-x-{value}");
    public BlazorWindBuilder SkewY(int value) => Add($"skew-y-{value}");
    #endregion

    #region Interactivity

    public BlazorWindBuilder Cursor(TwInteractivity cursor) => Add(cursor.ToTailwindClass());
    public BlazorWindBuilder Resize(TwInteractivity resize) => Add(resize.ToTailwindClass());
    public BlazorWindBuilder Scroll(TwInteractivity scroll) => Add(scroll.ToTailwindClass());
    public BlazorWindBuilder Touch(TwInteractivity touch) => Add(touch.ToTailwindClass());
    public BlazorWindBuilder Select(TwInteractivity select) => Add(select.ToTailwindClass());

    #endregion

    #region Layout

    public BlazorWindBuilder Position(TwPosition position) => Add(position.ToTailwindClass());
    public BlazorWindBuilder Display(TwDisplay display) => Add(display.ToTailwindClass());
    public BlazorWindBuilder FlexDirection(TwFlexDirection direction) => Add(direction.ToTailwindClass());
    public BlazorWindBuilder Justify(TwJustifyContent justify) => Add(justify.ToTailwindClass());
    public BlazorWindBuilder Items(TwAlignItems align) => Add(align.ToTailwindClass());
    public BlazorWindBuilder Fixed() => Add("fixed");
    public BlazorWindBuilder Inset(int value) => Add($"inset-{value}");
    public BlazorWindBuilder Bottom(int value) => Add($"bottom-{value}");
    public BlazorWindBuilder Right(int value) => Add($"right-{value}");
    public BlazorWindBuilder ZIndex(int value) => Add($"z-{value}");
    public BlazorWindBuilder GridCols(int value) => Add($"grid-cols-{value}");
    public BlazorWindBuilder GridRows(int value) => Add($"grid-rows-{value}");
    public BlazorWindBuilder GridFlow(string flow) => Add($"grid-flow-{flow}");
    public BlazorWindBuilder GridAutoCols(string autoCols) => Add($"auto-cols-{autoCols}");
    public BlazorWindBuilder GridAutoRows(string autoRows) => Add($"auto-rows-{autoRows}");
    public BlazorWindBuilder GridAutoFlow(string autoFlow) => Add($"grid-flow-{autoFlow}");
    public BlazorWindBuilder GridTemplateCols(string templateCols) => Add($"grid-cols-{templateCols}");
    public BlazorWindBuilder GridTemplateRows(string templateRows) => Add($"grid-rows-{templateRows}");
    public BlazorWindBuilder GridColStart(int value) => Add($"col-start-{value}");
    public BlazorWindBuilder GridColEnd(int value) => Add($"col-end-{value}");
    public BlazorWindBuilder GridRowStart(int value) => Add($"row-start-{value}");
    public BlazorWindBuilder GridRowEnd(int value) => Add($"row-end-{value}");
    public BlazorWindBuilder GridColSpan(int value) => Add($"col-span-{value}");
    public BlazorWindBuilder GridRowSpan(int value) => Add($"row-span-{value}");

    #endregion

    #region Form

    public BlazorWindBuilder Outline(TwOutline outline) => Add(outline.ToTailwindClass());
    public BlazorWindBuilder FormInput() => Add("form-input");
    public BlazorWindBuilder FormTextarea() => Add("form-textarea");
    public BlazorWindBuilder FormSelect() => Add("form-select");
    public BlazorWindBuilder FormCheckbox() => Add("form-checkbox");
    public BlazorWindBuilder FormRadio() => Add("form-radio");
    public BlazorWindBuilder FormFile() => Add("form-file");

    #endregion

    #region SVG

    public BlazorWindBuilder StrokeWidth(int width) => Add($"stroke-{width}");

    #endregion

    #region Accessibility

    public BlazorWindBuilder ScreenReaderOnly() => Add("sr-only");
    public BlazorWindBuilder NotScreenReaderOnly() => Add("not-sr-only");

    #endregion

    #region Animation
    public BlazorWindBuilder Animate(TwAnimation animation) => Add(animation.ToTailwindClass());
    #endregion

    public override string ToString() => string.Join(" ", _classes);

    public string Build() => ToString();
}