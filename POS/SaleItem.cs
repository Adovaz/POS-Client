using System;
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
        public SaleItem()
        {
            InitializeComponent();
        }
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
        public string barcode
        {
            get
            {
                return lbl_brcd.Text;
            }
            set
            {
                lbl_brcd.Text = value;
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
                lbl_itemPrice.Text = value;
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
                lbl_totalItemPrice.Text = value;
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
    }
}
