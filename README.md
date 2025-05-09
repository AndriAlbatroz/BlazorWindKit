# BlazorWindKit

An open-source Razor Class Library for building TailwindCSS utility classes in Blazor using a fluent, type-safe API.

## Overview

BlazorWindKit provides a powerful solution for generating TailwindCSS classes programmatically in Blazor applications. The library offers:

- Strongly-typed enums for colors, shades, layout, and spacing
- Intuitive fluent syntax
- Support for responsive and state variants (sm:, hover:, etc.)
- Comprehensive class generation including opacity modifiers
 
## Features

- Type-safe color and shade management
- Responsive design utilities
- State variant support
- Opacity modifiers
- Layout and spacing controls
- Shadow and border utilities

## Usage Example

```csharp
var css = TailwindClassBuilder.Create()
    .BgColor(TwColor.Blue, TwShade._600, 50)
    .TextColor(TwColor.White)
    .Rounded("lg")
    .Shadow("md")
    .Sm(sm => sm.PaddingX(4))
    .Hover(h => h.BgColor(TwColor.Blue, TwShade._700))
    .ToString();

// Result: "bg-blue-600/50 text-white rounded-lg shadow-md sm:px-4 hover:bg-blue-700"
```

## License

This software is free for personal and non-commercial use only.
A commercial license is required for business or commercial purposes.
For licensing inquiries, please contact: dev@micheliandrea.com
