using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    class ProductVariation
    {
        public int id;
        public int product_id;
        public string name;
        public string description;
        public double cost;
        public double retail_price;
        public string barcode_0;
        public string barcode_1;
        public string barcode_2;


    }

    class Product
    {
        public int id;
        public int product_category_id;
        public int supplier_id;
        public string name;
        public string description;
    }
}
