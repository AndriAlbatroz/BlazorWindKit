// wwwroot/dropdownHelper.js

export function registerClickOutside(dropdownElement, dotNetHelper) {
    const onClick = (event) => {
        if (!dropdownElement.contains(event.target)) {
            dotNetHelper.invokeMethodAsync("CloseDropdown");
        }
    };

    document.addEventListener("click", onClick);

    return {
        dispose: () => {
            document.removeEventListener("click", onClick);
        }
    };
}
