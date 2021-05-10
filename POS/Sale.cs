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
    public partial class Sale : UserControl
    {
        public Sale()
        {
            InitializeComponent();
        }

        private void BarcodeCapture(object sender, KeyEventArgs e)
        {
            //txtBx_Barcode.Text = txtBx_Barcode.Text + e.KeyCode.ToString();
        }

        private void CheckEnterKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)

            {
                try
                {
                    newitem();
                }
                catch
                {
                    txtBx_Barcode.Text = "";

                }
            }
        }

        private void newitem()
        {
            try
            {
                Tuple<Product, ProductVariation> tmpItem = API.getItemForSale(txtBx_Barcode.Text);
                txtBx_Barcode.Text = "";
                Product tmpProduct = tmpItem.Item1;
                ProductVariation tmpVariation = tmpItem.Item2;
                SaleItem item = new SaleItem();
                item.name = tmpProduct.name + "-" + tmpVariation.name;
                item.Dock = DockStyle.Top;
                Items_pnl.Controls.Add(item);

            }
            catch
            {
                txtBx_Barcode.Text = "";
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            txtBx_Barcode.Text = "";
        }
    }
}
