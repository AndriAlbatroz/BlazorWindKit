using BlazorWindKit.Core.Attributes;

namespace BlazorWindKit.Core.Enums;

public enum TwDisplay
{
    [TailwindClass("block")]
    Block,

    [TailwindClass("inline-block")]
    InlineBlock,

    [TailwindClass("inline")]
    Inline,

    [TailwindClass("flex")]
    Flex,

    [TailwindClass("inline-flex")]
    InlineFlex,

    [TailwindClass("grid")]
    Grid,

    [TailwindClass("inline-grid")]
    InlineGrid,

    [TailwindClass("contents")]
    Contents,

    [TailwindClass("hidden")]
    Hidden,

    [TailwindClass("table")]
    Table,

    [TailwindClass("inline-table")]
    InlineTable,

    [TailwindClass("table-row")]
    TableRow,

    [TailwindClass("table-cell")]
    TableCell,

    [TailwindClass("table-caption")]
    TableCaption,

    [TailwindClass("flow-root")]
    FlowRoot,

    [TailwindClass("list-item")]
    ListItem
}

public enum TwFlexDirection
{
    [TailwindClass("flex-row")]
    Row,
    [TailwindClass("flex-row-reverse")]
    RowReverse,
    [TailwindClass("flex-col")]
    Col,
    [TailwindClass("flex-col-reverse")]
    ColReverse
}

public enum TwJustifyContent
{
    [TailwindClass("justify-start")]
    Start,
    [TailwindClass("justify-end")]
    End,
    [TailwindClass("justify-center")]
    Center,
    [TailwindClass("justify-between")]
    Between,
    [TailwindClass("justify-around")]
    Around,
    [TailwindClass("justify-evenly")]
    Evenly
}

public enum TwAlignItems
{
    [TailwindClass("items-start")]
    Start,
    [TailwindClass("items-end")]
    End,
    [TailwindClass("items-center")]
    Center,
    [TailwindClass("items-baseline")]
    Baseline,
    [TailwindClass("items-stretch")]
    Stretch
} 