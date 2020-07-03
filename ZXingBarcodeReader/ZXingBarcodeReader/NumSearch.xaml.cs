using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ZXingBarcodeReader
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NumSearch : ContentPage
    {
        public NumSearch()
        {
            InitializeComponent();

            this.Title = "商品番号検索";
        }

        public void Open_Search(object sender, EventArgs e)
        {
            DependencyService.Get<INativeNavigation>().OpenBrowser(Util.Enum.ShohinNoURL + EntryValue.Text);
        }
    }
}