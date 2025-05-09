using BlazorWindKit.Core.Attributes;

namespace BlazorWindKit.Core.Enums;

public enum TwDropdownDirection
{
    [TailwindClass("origin-top-left")]
    BottomLeft,  // Default: apre verso il basso, allineato a sinistra
    [TailwindClass("origin-top-right")]
    BottomRight, // Apre verso il basso, allineato a destra
    [TailwindClass("origin-bottom-left")]
    TopLeft,     // Apre verso l'alto, allineato a sinistra
    [TailwindClass("origin-bottom-right")]
    TopRight     // Apre verso l'alto, allineato a destra
}
