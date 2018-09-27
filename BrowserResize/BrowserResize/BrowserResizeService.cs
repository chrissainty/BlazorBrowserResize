using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace BrowserResize
{
    public class BrowserResizeService
    {
        public static event Func<Task> OnResize;

        [JSInvokable]
        public static async Task OnBrowserResize()
        {
            await OnResize?.Invoke();           
        }

        public static async Task<int> GetInnerHeight()
        {
            return await JSRuntime.Current.InvokeAsync<int>("browserResize.getInnerHeight");
        }

        public static async Task<int> GetInnerWidth()
        {
            return await JSRuntime.Current.InvokeAsync<int>("browserResize.getInnerWidth");
        }
    }
}
