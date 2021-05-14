using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    class StaffObj
    {
        public int id;
        public string name;
        public string remember_token;
    }

    class ProductVariationObj
    {
        public int id;
        public ProductObj product_variation;
        public string name;
        public string description;
        public double cost;
        public double retail_price;
        public string barcode_0;
        public string barcode_1;
        public string barcode_2;
    }

    class ProductObj
    {
        public int id;
        public int product_category;
        public int supplier_id;
        public string name;
        public string description;
    }

    class TransactionObj
    {
        public StaffObj staff;

        public Array product_variaiton_id;
        public Array quantities;
    }

    class SaleObj
    {
        public int transaction_id;
        public ProductVariationObj variations;
        public int quantity;
    }
}
