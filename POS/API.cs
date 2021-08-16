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
        //Universal post function
        public static string Post(string uri, string postData)
        {
            var request = (HttpWebRequest)WebRequest.Create(uri);

            var data = Encoding.ASCII.GetBytes(postData);

            request.Method = "POST";
            request.Headers.Add("staff_id", Globals.staffID.ToString());
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;

            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            var response = (HttpWebResponse)request.GetResponse();

            return new StreamReader(response.GetResponseStream()).ReadToEnd();
        }

        //Gets Product and Variation for a sale
        public static Tuple<ProductObj, ProductVariationObj> GetSaleItem(string barcode)
        {
            string variationUrl = @"http://localhost/productvariations/barcode/"+barcode;
            ProductVariationObj tmpVariation = JsonConvert.DeserializeObject<ProductVariationJson>(Get(variationUrl)).productVariation[0];  
            string productUrl = @"http://localhost/products/get/"+tmpVariation.product_id;
            ProductObj tmpProduct = JsonConvert.DeserializeObject<ProductJson>(Get(productUrl)).Product;

            return new Tuple<ProductObj, ProductVariationObj>(tmpProduct, tmpVariation);
        }

        //Submits transaction to database
        public static void SubmitTransaction()
        {
            string transactionURL = @"http://localhost/transactions/new";
           
        }
    }
}
