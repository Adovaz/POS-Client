﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class SaleContents : Form
    {
        public SaleContents(int TransactionID)
        {
            List<SaleObj> sales = API.SalesbyTransaction(TransactionID);
            InitializeComponent();
            foreach (SaleObj sale in sales)
            {
                Tuple<ProductObj, ProductVariationObj> tmp = API.GetProduct(sale.product_variation_id);
                ProductObj product = tmp.Item1;
                ProductVariationObj variation = tmp.Item2;
                SaleContentsItem item = new SaleContentsItem();
                item.name = product.name + "-" + variation.name;
                item.quantity = sale.quantity;
                item.Dock = DockStyle.Top;
                pnl_contents.Controls.Add(item);
            }
        }
    }
}