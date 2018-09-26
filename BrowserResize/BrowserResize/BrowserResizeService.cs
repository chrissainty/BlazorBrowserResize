using Microsoft.JSInterop;
using System;

namespace BrowserResize
{
    public class BrowserResizeService
    {
        public static event Action OnResize;

        public static int InnerHeight { get; set; }
        public static int InnerWidth { get; set; }

        [JSInvokable]
        public static void OnBrowserResize()
        {
            Console.WriteLine("Browser has resized");
            OnResize?.Invoke();           
        }
    }
}
