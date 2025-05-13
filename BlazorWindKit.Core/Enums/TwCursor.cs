using BlazorWindKit.Core.Attributes;

namespace BlazorWindKit.Core.Enums;

public enum TwCursor
{
    [TailwindClass("cursor-auto")]
    Auto,
    [TailwindClass("cursor-default")]
    Default,
    [TailwindClass("cursor-pointer")]
    Pointer,
    [TailwindClass("cursor-wait")]
    Wait,
    [TailwindClass("cursor-text")]
    Text,
    [TailwindClass("cursor-move")]
    Move,
    [TailwindClass("cursor-help")]
    Help,
    [TailwindClass("cursor-not-allowed")]
    NotAllowed,
    [TailwindClass("cursor-none")]
    None,
    [TailwindClass("cursor-context-menu")]
    ContextMenu,
    [TailwindClass("cursor-progress")]
    Progress,
    [TailwindClass("cursor-cell")]
    Cell,
    [TailwindClass("cursor-crosshair")]
    Crosshair,
    [TailwindClass("cursor-vertical-text")]
    VerticalText,
    [TailwindClass("cursor-alias")]
    Alias,
    [TailwindClass("cursor-copy")]
    Copy,
    [TailwindClass("cursor-no-drop")]
    NoDrop,
    [TailwindClass("cursor-grab")]
    Grab,
    [TailwindClass("cursor-grabbing")]
    Grabbing,
    [TailwindClass("cursor-all-scroll")]
    AllScroll,
    [TailwindClass("cursor-col-resize")]
    ColResize,
    [TailwindClass("cursor-row-resize")]
    RowResize,
    [TailwindClass("cursor-n-resize")]
    NResize,
    [TailwindClass("cursor-e-resize")]
    EResize,
    [TailwindClass("cursor-s-resize")]
    SResize,
    [TailwindClass("cursor-w-resize")]
    WResize,
    [TailwindClass("cursor-ne-resize")]
    NeResize,
    [TailwindClass("cursor-nw-resize")]
    NwResize,
    [TailwindClass("cursor-se-resize")]
    SeResize,
    [TailwindClass("cursor-sw-resize")]
    SwResize,
    [TailwindClass("cursor-ew-resize")]
    EwResize,
    [TailwindClass("cursor-ns-resize")]
    NsResize,
    [TailwindClass("cursor-nesw-resize")]
    NeswResize,
    [TailwindClass("cursor-nwse-resize")]
    NwseResize,
    [TailwindClass("cursor-zoom-in")]
    ZoomIn,
    [TailwindClass("cursor-zoom-out")]
    ZoomOut
}

public enum TwResize
{
    [TailwindClass("resize-none")]
    None,
    [TailwindClass("resize-y")]
    Vertical,
    [TailwindClass("resize-x")]
    Horizontal,
    [TailwindClass("resize")]
    Both
}

public enum TwScrollBehavior
{
    [TailwindClass("scroll-auto")]
    Auto,
    [TailwindClass("scroll-smooth")]
    Smooth
}

public enum TwTouchAction
{
    [TailwindClass("touch-auto")]
    Auto,
    [TailwindClass("touch-none")]
    None,
    [TailwindClass("touch-pan-x")]
    PanX,
    [TailwindClass("touch-pan-y")]
    PanY,
    [TailwindClass("touch-manipulation")]
    Manipulation
}

public enum TwSelect
{
    [TailwindClass("select-none")]
    None,
    [TailwindClass("select-text")]
    Text,
    [TailwindClass("select-all")]
    All,
    [TailwindClass("select-auto")]
    Auto
} 