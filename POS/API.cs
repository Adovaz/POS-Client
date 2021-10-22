using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

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
        //Sends in json!!
        //Accept Url and data in string
        public static string Post(string uri, string postData)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);

            var data = Encoding.ASCII.GetBytes(postData);

            request.Method = "POST";
            request.ContentType = "application/json";
            request.ContentLength = data.Length;

            using (Stream stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            var response = (HttpWebResponse)request.GetResponse();

            return new StreamReader(response.GetResponseStream()).ReadToEnd();
        }

        //Gets Product and Variation for a sale
        public static Tuple<ProductObj, ProductVariationObj> GetSaleItem(string barcode)
        {
            //Set Url
            string variationUrl = @"http://localhost/productvariations/barcode/" + barcode;
            //Conver Json
            ProductVariationObj tmpVariation = JsonConvert.DeserializeObject<ProductVariationJson>(Get(variationUrl)).productVariation[0];
            //Set Url
            string productUrl = @"http://localhost/products/get/" + tmpVariation.product_id;
            //Conver Json
            ProductObj tmpProduct = JsonConvert.DeserializeObject<ProductJson>(Get(productUrl)).Product;

            return new Tuple<ProductObj, ProductVariationObj>(tmpProduct, tmpVariation);
        }

        //Gets Product and Variation 
        public static Tuple<ProductObj, ProductVariationObj> GetProduct(int id)
        {
            ProductVariationObj tmpVariation = JsonConvert.DeserializeObject<ProductVariationObj>(Get(@"http://localhost/productvariations/get/" + id.ToString()));
            string productUrl = @"http://localhost/products/get/" + tmpVariation.product_id;
            ProductObj tmpProduct = JsonConvert.DeserializeObject<ProductJson>(Get(productUrl)).Product;

            return new Tuple<ProductObj, ProductVariationObj>(tmpProduct, tmpVariation);
        }


        //Submits transaction to database
        public static void SubmitTransaction(string contents)
        {
            string transactionURL = @"http://localhost/transactions/new";
            Post(transactionURL, contents);
        }

        //Gets all transactions
        public static List<TransactionObj> Transactions()
        {
            List<TransactionObj> ret = JsonConvert.DeserializeObject<List<TransactionObj>>(Get(@"http://localhost/transactions/all"));
            return ret;
        }

        //Gets sales from transaction (contents of sale)
        public static List<SaleObj> SalesbyTransaction(int id)
        {
            List<SaleObj> ret = JsonConvert.DeserializeObject<List<SaleObj>>(Get(@"http://localhost/transactions/sale/" + id));
            return ret;
        }
    }
}
