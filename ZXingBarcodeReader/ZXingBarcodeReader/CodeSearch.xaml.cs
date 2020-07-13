using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ZXingBarcodeReader
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CodeSearch : ContentPage
    {
        public CodeSearch()
        {
            InitializeComponent();

            this.Title = "商品コード検索";
        }

        public void Open_Search(object sender, EventArgs e)
        {
            DependencyService.Get<INativeNavigation>().OpenBrowser(Util.Enum.ShohinCodeURL + HttpUtility.UrlEncode(EntryValue.Text));
        }
    }
}