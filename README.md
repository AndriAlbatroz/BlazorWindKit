# BlazorWindKit

An open-source Razor Class Library for building **TailwindCSS utility classes** in **Blazor** using a fluent, type-safe API.

---

## 🚀 Purpose

**Tailwind.Blazor** helps you generate TailwindCSS classes programmatically in Blazor apps, offering:

- Strongly-typed enums for colors, shades, layout, spacing, and more
- Fluent syntax for intuitive use
- Responsive and state variants like `sm:`, `hover:`, etc.
- Support for classes like `bg-blue-600/50`, `text-red-400`, `rounded-lg`, `shadow-md`

---

## ✨ Example

```csharp
var classes = TailwindClassBuilder.Create()
    .BgColor(TwColor.Blue, TwShade._600, 50)
    .TextColor(TwColor.White)
    .Rounded("lg")
    .Shadow("md")
    .Sm(sm => sm.PaddingX(4))
    .Hover(h => h.BgColor(TwColor.Blue, TwShade._700))
    .ToString();

// Result: "bg-blue-600/50 text-white rounded-lg shadow-md sm:px-4 hover:bg-blue-700"
```

📄 License
This software is free for personal and non-commercial use only.
A commercial license is required for business or commercial purposes.
Please contact me at [dev@micheliandrea.com].
