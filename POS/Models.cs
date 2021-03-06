using System;

namespace POS
{
    //Classes match models in api for json converson

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

    public class ProductObj
    {
        public int id;
        public int product_category;
        public int supplier_id;
        public string name;
        public string description;
    }

    public class TransactionObj
    {
        public int id;
        public int staff_id;
        public double total;
        public string transaction_type;
        public DateTime created_at;
    }

    //Needed as are stored as nested lists
    public class TransactionContent
    {
        public int product_variation_id;
        public int quantity;
    }

    public class SaleObj
    {
        public int transaction_id;
        public int product_variation_id;
        public int quantity;
    }

    //Models for converting json to c# obj correctly
    //--------------------------------------------------------------------------
    public class ProductVariationJson
    {
        public ProductVariationObj[] productVariation;
    }

    public class ProductJson
    {
        public ProductObj Product;
    }

    public class TransactionPostJson
    {
        public string total;
        public string staff_id;
        public string transaction_type;//defaults to sale
        public TransactionContent[] contents;
    }

}
