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
    public partial class SaleContentsItem : UserControl
    {
        public SaleContentsItem()
        {
            InitializeComponent();
        }
        public ProductVariationObj productVariation;

        public string name
        {
            get
            {
                return lbl_name.Text;
            }
            set
            {
                lbl_name.Text = value;
            }
        }
        public int quantity
        {
            get
            {
                return int.Parse(lbl_qty.Text);
            }
            set
            {
                lbl_qty.Text = value.ToString();
            }
        }
    }
}
