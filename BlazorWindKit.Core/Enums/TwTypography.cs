using BlazorWindKit.Core.Attributes;

namespace BlazorWindKit.Core.Enums;

public enum TwTextSize
{
    [TailwindClass("text-xs")]
    Xs,

    [TailwindClass("text-sm")]
    Sm,

    [TailwindClass("text-base")]
    Base,

    [TailwindClass("text-lg")]
    Lg,

    [TailwindClass("text-xl")]
    Xl,

    [TailwindClass("text-2xl")]
    Xl2,

    [TailwindClass("text-3xl")]
    Xl3,

    [TailwindClass("text-4xl")]
    Xl4,

    [TailwindClass("text-5xl")]
    Xl5,

    [TailwindClass("text-6xl")]
    Xl6,

    [TailwindClass("text-7xl")]

    Xl7,

    [TailwindClass("text-8xl")]
    Xl8,

    [TailwindClass("text-9xl")]
    Xl9,
}

public enum TwFontWeight
{
    [TailwindClass("font-thin")]
    Thin,

    [TailwindClass("font-extralight")]
    Extralight,

    [TailwindClass("font-light")]
    Light,

    [TailwindClass("font-normal")]
    Normal,

    [TailwindClass("font-medium")]
    Medium,

    [TailwindClass("font-semibold")]
    Semibold,

    [TailwindClass("font-bold")]
    Bold,

    [TailwindClass("font-extrabold")]
    Extrabold,

    [TailwindClass("font-black")]
    Black,
}

public enum TwTextAlign
{

    [TailwindClass("text-left")]
    Left,

    [TailwindClass("text-center")]
    Center,

    [TailwindClass("text-right")]
    Right,

    [TailwindClass("text-justify")]
    Justify,
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