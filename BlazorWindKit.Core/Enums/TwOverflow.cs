using BlazorWindKit.Core.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWindKit.Core.Enums;
public enum TwOverflow
{
    [TailwindClass("overflow-auto")]
    Auto,
    [TailwindClass("overflow-hidden")]
    Hidden,
    [TailwindClass("overflow-clip")]
    Clip,
    [TailwindClass("overflow-visible")]
    Visible,
    [TailwindClass("overflow-scroll")]
    Scroll
}
