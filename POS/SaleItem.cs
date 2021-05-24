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
    public partial class SaleItem : UserControl
    {
        public Sale sale;

        public SaleItem()
        {
            InitializeComponent();
        }

        //External access to text and variables
        public string name
        {
            get
            {
                return lbl_itemName.Text;
            }
            set
            {
                lbl_itemName.Text = value;
            }
        }
        public string description
        {
            get
            {
                return lbl_desc.Text;
            }
            set
            {
                lbl_desc.Text = value;
            }
        }
        public string price
        {
            get
            {
                return lbl_itemPrice.Text;
            }
            set
            {
                lbl_itemPrice.Text = "$" + value;
            }
        }
        public string total
        {
            get
            {
                return lbl_totalItemPrice.Text;
            }
            set
            {
                lbl_totalItemPrice.Text = "$" + value;
            }
        }
        public int quantity
        {
            get
            {
                return Convert.ToInt32(numUD_Quantity.Value);
            }
            set
            {
                numUD_Quantity.Value = value;
            }
        }

        //Product variaton attatched to the this item
        public ProductVariationObj productAttatched;
        
        //Updates the induvidual items total
        private void TotalUpdate(object sender, EventArgs e)
        {
            total = (quantity * productAttatched.retail_price).ToString();
            sale.UpdateTotal();
        }

        //Deletes the element
        private void btn_delete_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
