using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    //Functions for API here
    class API
    {
        public static Tuple<Product, ProductVariation> getItemForSale(string barcode)
        {
            Product tmpProduct = new Product();
            ProductVariation tmpVariation = new ProductVariation();

            return new Tuple<Product, ProductVariation>(tmpProduct, tmpVariation);
        }
    }
}
