using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ZXingBarcodeReader
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            this.Title = "バーコードリーダー";
        }

        public void Camera_Open(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ScanPage());
        }

        public void NumSearch_Open(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NumSearch());
        }

        public void CodeSearch_Open(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CodeSearch());
        }
    }
}
