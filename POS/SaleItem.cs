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
            get { return lbl_itemName.Text; }
            set { lbl_itemName.Text = value; }
        }
    }
}
