using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Essentials;
using Xamarin.Forms;
using ZXingBarcodeReader.iOS;

[assembly: Xamarin.Forms.Dependency(typeof(NativeNavigation))]
namespace ZXingBarcodeReader.iOS
{
    public class NativeNavigation : INativeNavigation
    {
        public void OpenBrowser(string url)
        {
            UIApplication.SharedApplication.InvokeOnMainThread(() =>
            {
                //    UIApplication.SharedApplication.Ope
                //    NSApplication.SharedApplication.OpenUrl(new NSUrl(url));
                UIApplication.SharedApplication.OpenUrl(new NSUrl(url));
                //    Browser.OpenAsync(url, BrowserLaunchMode.SystemPreferred);
            });
        }
    }
}