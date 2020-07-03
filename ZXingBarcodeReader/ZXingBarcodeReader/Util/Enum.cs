using System;
using System.Collections.Generic;
using System.Text;

namespace ZXingBarcodeReader.Util
{
    public class Enum
    {
        public static String BaseURL = "http://webhn.local.zoa.co.jp:60001/magic94Scripts/mgrqispi94.dll";

        public static String BarcodeURL = BaseURL + "?APPNAME=WEBHNCTL&PRGNAME=itemSearchByJAN02&ARGUMENTS=-N";

        public static String ShohinNoURL = BaseURL + "?APPNAME=WEBHNCTL&PRGNAME=itemSearchByNum&ARGUMENTS=-N";

        public static String ShohinCodeURL = BaseURL + "?APPNAME=WEBHNCTL&PRGNAME=itemSearchByCode&ARGUMENTS=-A";
    }
}

