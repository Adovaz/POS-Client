using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    public class StaffObj
    {
        public int id;
        public string name;
        public string remember_token;
    }

    public class ProductVariationObj
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
    
    public class ProductVariationJson
    {
        public ProductVariationObj[] productVariation;
    }

    public class ProductObj
    {
        public int id;
        public int product_category;
        public int supplier_id;
        public string name;
        public string description;
    }

    public class ProductJson
    {
        public ProductObj Product;
    }

    public class TransactionObj
    {
        public int staff_id;
        public Array product_variaiton_id;
        public Array quantities;
    }

    public class TransactionJson
    {

    }

    public class SaleObj
    {
        public int transaction_id;
        public int variation;
        public int quantity;
    }
}
