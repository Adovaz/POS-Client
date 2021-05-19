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
            MessageBox.Show("Start of get");
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            MessageBox.Show("Request thing");
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            MessageBox.Show("ysy");
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
            string variation_url = @"https://localhost/productvariations/barcode/"+barcode;
            MessageBox.Show(variation_url);
            string tmp_json_variation = Get("https://localhost/stock/all");
            MessageBox.Show("hete", tmp_json_variation);
            ProductVariationObj tmpVariation = JsonConvert.DeserializeObject<ProductVariationObj>(tmp_json_variation);
            MessageBox.Show("here");

            string product = @"https://localhost/product/get/"+tmpVariation.product_id;
            string tmp_json_product = Get(product);
            ProductObj tmpProduct = JsonConvert.DeserializeObject<ProductObj>(tmp_json_product); ;
           

            return new Tuple<ProductObj, ProductVariationObj>(tmpProduct, tmpVariation);
        }
    }
}
