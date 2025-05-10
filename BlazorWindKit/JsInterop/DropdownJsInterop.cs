using BlazorWindKit.Components.Dropdown;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorWindKit.JsInterop;

public class DropdownJsInterop : IAsyncDisposable
{
    private readonly Lazy<Task<IJSObjectReference>> _moduleTask;

    public DropdownJsInterop(IJSRuntime jsRuntime)
    {
        _moduleTask = new(() => jsRuntime.InvokeAsync<IJSObjectReference>(
            "import", "./_content/BlazorWindKit/dropdownHelper.js").AsTask());
    }

    public async Task<IJSObjectReference> RegisterClickOutside<T>(ElementReference dropdownRef, DotNetObjectReference<BlazorWindDropdown<T>> dotNetRef)
    {
        var module = await _moduleTask.Value;
        return await module.InvokeAsync<IJSObjectReference>("registerClickOutside", dropdownRef, dotNetRef);
    }

    public async ValueTask DisposeAsync()
    {
        if (_moduleTask.IsValueCreated)
        {
            var module = await _moduleTask.Value;
            await module.DisposeAsync();
        }
    }
}