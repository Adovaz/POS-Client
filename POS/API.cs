using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    //Functions for API here
    class API
    {
        public static string Get(string uri)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }

        public static Tuple<ProductObj, ProductVariationObj> getItemForSale(string barcode)
        {
            string url = @"https://www.google.com";

            MessageBox.Show(Get(url));

            ProductObj tmpProduct = new ProductObj();
            ProductVariationObj tmpVariation = new ProductVariationObj();

            return new Tuple<ProductObj, ProductVariationObj>(tmpProduct, tmpVariation);
        }
    }
}
