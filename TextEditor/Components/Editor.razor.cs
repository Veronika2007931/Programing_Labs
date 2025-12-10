using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace TextEditor.Components
{
    public partial class Editor : ComponentBase
{
    [Inject]
    protected IJSRuntime JSRuntime { get; set; }

    protected async Task MakeBold()
    {
        await JSRuntime.InvokeVoidAsync("editorActions.execCmd", "bold", "");

    }

    protected async Task MakeItalic()
        {
            await JSRuntime.InvokeVoidAsync("editorActions.execCmd", "italic", "");
        }

        protected async Task MakeUnderline()
        {
            await JSRuntime.InvokeVoidAsync("editorActions.execCmd", "underline", "");
        }

        protected async Task ChangeSize(ChangeEventArgs e)
        {
            await JSRuntime.InvokeVoidAsync("editorActions.execCmd", "fontSize", e.Value?.ToString());
        }

        protected async Task ChangeColor(ChangeEventArgs e)
        {
            await JSRuntime.InvokeVoidAsync("editorActions.execCmd", "foreColor", e.Value?.ToString());
        }
    }


}