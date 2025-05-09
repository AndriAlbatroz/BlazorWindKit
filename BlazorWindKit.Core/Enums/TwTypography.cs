using BlazorWindKit.Core.Attributes;

namespace BlazorWindKit.Core.Enums;

public enum TwTextSize
{
    [TailwindClass("text-xs")]
    TextXs,

    [TailwindClass("text-sm")]
    TextSm,

    [TailwindClass("text-base")]
    TextBase,

    [TailwindClass("text-lg")]
    TextLg,

    [TailwindClass("text-xl")]
    TextXl,

    [TailwindClass("text-2xl")]
    Text2Xl,

    [TailwindClass("text-3xl")]
    Text3Xl,

    [TailwindClass("text-4xl")]
    Text4Xl,

    [TailwindClass("text-5xl")]
    Text5Xl,

    [TailwindClass("text-6xl")]
    Text6Xl,

    [TailwindClass("text-7xl")]
    Text7Xl,

    [TailwindClass("text-8xl")]
    Text8Xl,

    [TailwindClass("text-9xl")]
    Text9Xl,
}

public enum TwFontWeight
{
    [TailwindClass("font-thin")]
    FontThin,

    [TailwindClass("font-extralight")]
    FontExtralight,

    [TailwindClass("font-light")]
    FontLight,

    [TailwindClass("font-normal")]
    FontNormal,

    [TailwindClass("font-medium")]
    FontMedium,

    [TailwindClass("font-semibold")]
    FontSemibold,

    [TailwindClass("font-bold")]
    FontBold,

    [TailwindClass("font-extrabold")]
    FontExtrabold,

    [TailwindClass("font-black")]
    FontBlack,
}

public enum TwTextAlign
{

    [TailwindClass("text-left")]
    TextLeft,

    [TailwindClass("text-center")]
    TextCenter,

    [TailwindClass("text-right")]
    TextRight,

    [TailwindClass("text-justify")]
    TextJustify,
}

public enum TwTextTypography
{

    [TailwindClass("underline")]
    Underline,

    [TailwindClass("line-through")]
    LineThrough,

    [TailwindClass("no-underline")]
    NoUnderline,

    [TailwindClass("uppercase")]
    Uppercase,

    [TailwindClass("lowercase")]
    Lowercase,

    [TailwindClass("capitalize")]
    Capitalize,

    [TailwindClass("normal-case")]
    NormalCase,

    [TailwindClass("truncate")]
    Truncate,
}

public enum TwTextDecoration
{
    [TailwindClass("decoration-solid")]
    Solid,
    [TailwindClass("decoration-double")]
    Double,
    [TailwindClass("decoration-dotted")]
    Dotted,
    [TailwindClass("decoration-dashed")]
    Dashed,
    [TailwindClass("decoration-wavy")]
    Wavy
}

public enum TwTextTransform
{
    [TailwindClass("uppercase")]
    Uppercase,
    [TailwindClass("lowercase")]
    Lowercase,
    [TailwindClass("capitalize")]
    Capitalize,
    [TailwindClass("normal-case")]
    NormalCase
}

public enum TwTextOverflow
{
    [TailwindClass("truncate")]
    Truncate,
    [TailwindClass("text-ellipsis")]
    Ellipsis,
    [TailwindClass("text-clip")]
    Clip
}

public enum TwWhitespace
{
    [TailwindClass("whitespace-normal")]
    Normal,
    [TailwindClass("whitespace-nowrap")]
    NoWrap,
    [TailwindClass("whitespace-pre")]
    Pre,
    [TailwindClass("whitespace-pre-line")]
    PreLine,
    [TailwindClass("whitespace-pre-wrap")]
    PreWrap,
    [TailwindClass("whitespace-break-spaces")]
    BreakSpaces
}

public enum TwWordBreak
{
    [TailwindClass("break-normal")]
    Normal,
    [TailwindClass("break-all")]
    All,
    [TailwindClass("brek-keep")]
    Keep
}

public enum TwLetterSpacing
{
    [TailwindClass("tracking-tighter")]
    Tigher,
    [TailwindClass("tracking-normal")]
    Normal,
    [TailwindClass("tracking-wide")]
    Wide,
    [TailwindClass("tracking-wider")]
    Wider,
    [TailwindClass("tracking-widest")]
    Widset,
}