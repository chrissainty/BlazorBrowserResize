using Microsoft.JSInterop;
using System;

namespace BrowserResize
{
    public class BrowserResizeService
    {
        public static event Action OnResize;

        [JSInvokable]
        public static void OnBrowserResize()
        {
            OnResize?.Invoke();           
        }
    }
}
