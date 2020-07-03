using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ZXingBarcodeReader.Android;

[assembly: Xamarin.Forms.Dependency(typeof(NativeNavigation))]
namespace ZXingBarcodeReader.Android
{
    public class NativeNavigation : INativeNavigation
    {
        public static Context Context { get; set; }

        public void OpenBrowser(string url)
        {
            var uri = global::Android.Net.Uri.Parse(url);
            Intent i = new Intent(Intent.ActionView, uri);
            Context.StartActivity(i);
        }
    }
}