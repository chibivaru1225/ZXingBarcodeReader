using System;
using System.Collections.Generic;
using System.Text;

namespace ZXingBarcodeReader
{
    public interface INativeNavigation
    {

        void OpenBrowser(string code);
    }
}
