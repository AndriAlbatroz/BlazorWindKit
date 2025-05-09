using BlazorWindKit.Core.Attributes;

namespace BlazorWindKit.Core.Enums;

public enum TwDropdownMenuDisplayMode
{
    [TailwindClass("fixed")]
    Overlay, 
    [TailwindClass("relative")]
    InFlowPush  // Il menu è nel flusso e spinge il contenuto sottostante
}