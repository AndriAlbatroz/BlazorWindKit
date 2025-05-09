# BlazorWindKit

An open-source Razor Class Library for building TailwindCSS utility classes in Blazor using a fluent, type-safe API.

## Overview

BlazorWindKit provides a powerful solution for generating TailwindCSS classes programmatically in Blazor applications. The library offers:

- Strongly-typed enums for colors, shades, layout, and spacing
- Intuitive fluent syntax
- Support for responsive and state variants (sm:, hover:, etc.)
- Comprehensive class generation including opacity modifiers
- Full support for TailwindCSS utilities including layout, typography, effects, and more

## Features

- Type-safe color and shade management
- Responsive design utilities (sm, md, lg, xl, 2xl)
- State variant support (hover, focus, active, disabled, etc.)
- Opacity modifiers for colors
- Layout and spacing controls
- Typography utilities
- Border and shadow utilities
- Effects and transitions
- Transform operations
- Grid and flexbox layouts
- Form styling
- SVG utilities
- Accessibility features
- Animation support

## Usage Example

```csharp
var css = BlazorWindBuilder.Create()
    .BackgroundColor(TwColor.Blue, 600, 50)
    .TextColor(TwColor.White)
    .BorderRadius(8)
    .Shadow(4)
    .Sm(sm => sm.PaddingX(4))
    .Hover(h => h.BackgroundColor(TwColor.Blue, 700))
    .Transition(TwTransition.All)
    .Transform(TwTransform.Gpu)
    .Build();

// Result: "bg-blue-600/50 text-white rounded-lg shadow-md sm:px-4 hover:bg-blue-700 transition-all transform-gpu"
```

## Key Features in Detail

### Responsive Design
```csharp
.Sm(sm => sm.PaddingX(4))
.Md(md => md.Width(6))
.Lg(lg => lg.GridCols(3))
```

### State Variants
```csharp
.Hover(h => h.BackgroundColor(TwColor.Blue, 700))
.Focus(f => f.Ring(2))
.Active(a => a.Scale(95))
```

### Layout & Spacing
```csharp

.Padding(4)
.MarginX(2)
.Gap(3)
.GridCols(2)
.FlexDirection(TwFlexDirection.Column)
```

### Typography
```csharp
.FontSize(TwTextSize.Lg)
.FontWeight(TwFontWeight.Bold)
.TextAlign(TwTextAlign.Center)
.LetterSpacing(TwLetterSpacing.Wide)
```

### Effects & Transitions
```csharp
.Opacity(75)
.BackdropBlurLg()
.Transition(TwTransition.All)
.Transform(TwTransform.Gpu)
```

## License

This software is free for personal and non-commercial use only.
A commercial license is required for business or commercial purposes.
For licensing inquiries, please contact: dev@micheliandrea.com
