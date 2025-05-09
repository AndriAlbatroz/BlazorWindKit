using BlazorWindKit.Core.Attributes;

namespace BlazorWindKit.Core.Enums;

public enum TwInteractivity
{
    [TailwindClass("cursor-auto")]
    CursorAuto,

    [TailwindClass("cursor-default")]
    CursorDefault,

    [TailwindClass("cursor-pointer")]
    CursorPointer,

    [TailwindClass("cursor-wait")]
    CursorWait,

    [TailwindClass("cursor-text")]
    CursorText,

    [TailwindClass("cursor-move")]
    CursorMove,

    [TailwindClass("cursor-help")]
    CursorHelp,

    [TailwindClass("cursor-not-allowed")]
    CursorNotAllowed,

    [TailwindClass("cursor-none")]
    CursorNone,

    [TailwindClass("cursor-context-menu")]
    CursorContextMenu,

    [TailwindClass("cursor-progress")]
    CursorProgress,

    [TailwindClass("cursor-cell")]
    CursorCell,

    [TailwindClass("cursor-crosshair")]
    CursorCrosshair,

    [TailwindClass("cursor-vertical-text")]
    CursorVerticalText,

    [TailwindClass("cursor-alias")]
    CursorAlias,

    [TailwindClass("cursor-copy")]
    CursorCopy,

    [TailwindClass("cursor-no-drop")]
    CursorNoDrop,

    [TailwindClass("cursor-grab")]
    CursorGrab,

    [TailwindClass("cursor-grabbing")]
    CursorGrabbing,

    [TailwindClass("cursor-all-scroll")]
    CursorAllScroll,

    [TailwindClass("cursor-col-resize")]
    CursorColResize,

    [TailwindClass("cursor-row-resize")]
    CursorRowResize,

    [TailwindClass("cursor-n-resize")]
    CursorNResize,

    [TailwindClass("cursor-e-resize")]
    CursorEResize,

    [TailwindClass("cursor-s-resize")]
    CursorSResize,

    [TailwindClass("cursor-w-resize")]
    CursorWResize,

    [TailwindClass("cursor-ne-resize")]
    CursorNeResize,

    [TailwindClass("cursor-nw-resize")]
    CursorNwResize,

    [TailwindClass("cursor-se-resize")]
    CursorSeResize,

    [TailwindClass("cursor-sw-resize")]
    CursorSwResize,

    [TailwindClass("cursor-ew-resize")]
    CursorEwResize,

    [TailwindClass("cursor-ns-resize")]
    CursorNsResize,

    [TailwindClass("cursor-nesw-resize")]
    CursorNeswResize,

    [TailwindClass("cursor-nwse-resize")]
    CursorNwseResize,

    [TailwindClass("cursor-zoom-in")]
    CursorZoomIn,

    [TailwindClass("cursor-zoom-out")]
    CursorZoomOut,

    [TailwindClass("resize-none")]
    ResizeNone,

    [TailwindClass("resize-y")]
    ResizeY,

    [TailwindClass("resize-x")]
    ResizeX,

    [TailwindClass("resize")]
    Resize,

    [TailwindClass("scroll-auto")]
    ScrollAuto,

    [TailwindClass("scroll-smooth")]
    ScrollSmooth,

    [TailwindClass("touch-auto")]
    TouchAuto,

    [TailwindClass("touch-none")]
    TouchNone,

    [TailwindClass("touch-pan-x")]
    TouchPanX,

    [TailwindClass("touch-pan-left")]
    TouchPanLeft,

    [TailwindClass("touch-pan-right")]
    TouchPanRight,

    [TailwindClass("touch-pan-y")]
    TouchPanY,

    [TailwindClass("touch-pan-up")]
    TouchPanUp,

    [TailwindClass("touch-pan-down")]
    TouchPanDown,

    [TailwindClass("touch-pinch-zoom")]
    TouchPinchZoom,

    [TailwindClass("touch-manipulation")]
    TouchManipulation,

    [TailwindClass("select-none")]
    SelectNone,

    [TailwindClass("select-text")]
    SelectText,

    [TailwindClass("select-all")]
    SelectAll,

    [TailwindClass("select-auto")]
    SelectAuto
}

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