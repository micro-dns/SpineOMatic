using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpineOMatic_cs.Util
{
    class Lookup
    {
        public static void callAlma(String fixedBarcode)
        {
            Console.WriteLine("Calling alma!");
            //Console.WriteLine(fixedBarcode);
            //Console.WriteLine(Options.apiURL);
            //Console.WriteLine(Options.apiMethod);
            //Console.WriteLine(Options.apiKey);

            String svcRequest = Options.apiURL + Options.apiMethod.Replace("{item_barcode}", fixedBarcode) + "&apikey=" + Options.apiKey;
            //svcRequest = apiURL.Text & apiMethod.Text.Replace("{item_barcode}", fixedBarcode) & "&apikey=" & apiKey.Text

            Console.WriteLine(svcRequest);


        }
    }
}
