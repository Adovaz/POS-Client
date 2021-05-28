using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace POS
{
    //Functions for API here
    class API
    {
        //Universal get function
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

        //Gets Product and Variation for a sale
        public static Tuple<ProductObj, ProductVariationObj> getItemForSale(string barcode)
        {
            string variation_url = @"http://localhost/productvariations/barcode/"+barcode;
            string tmp_json_variation = Get(variation_url);
            ProductVariationJson tmpVariationJson = JsonConvert.DeserializeObject<ProductVariationJson>(tmp_json_variation);
            ProductVariationObj tmpVariation = tmpVariationJson.productVariation[0];
            
            string product_url = @"http://localhost/products/get/"+tmpVariation.product_id;
            string tmp_json_product = Get(product_url);
            ProductJson tmpProductJson = JsonConvert.DeserializeObject<ProductJson>(tmp_json_product);
            ProductObj tmpProduct = tmpProductJson.Product;

            return new Tuple<ProductObj, ProductVariationObj>(tmpProduct, tmpVariation);
        }

        //
        public static void SubmitTrans()
        {
            var request = (HttpWebRequest)WebRequest.Create("http://localhost/transactions/new");

            var postData = "thing1=" + Uri.EscapeDataString("hello");
            postData += "&thing2=" + Uri.EscapeDataString("world");
            var data = Encoding.ASCII.GetBytes(postData);

            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;

            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            var response = (HttpWebResponse)request.GetResponse();

            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
        }
    }
}
