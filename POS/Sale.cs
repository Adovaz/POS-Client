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

        //Adds item on enter
        private void CheckEnterKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)

            {
                try
                {
                    Tuple<ProductObj, ProductVariationObj> tmpItem = API.getItemForSale(txtBx_Barcode.Text);
                    ProductObj product = tmpItem.Item1;
                    ProductVariationObj variation = tmpItem.Item2;
                    txtBx_Barcode.Text = "";

                    bool has_item = false;

                    foreach (SaleItem sale in pnl_items.Controls)
                    {
                        if (sale.productAttatched.id == variation.id)
                        {
                            sale.quantity++;
                            UpdateTotal();
                            has_item = true;
                        }
                    }

                    if (!has_item)
                    {
                        SaleItem item = new SaleItem();
                        item.Dock = DockStyle.Top;
                        item.productAttatched = variation;
                        item.name = product.name + " - " + variation.name;
                        item.description = product.description + " - " + variation.description;
                        item.price = variation.retail_price.ToString();
                        item.total = variation.retail_price.ToString();
                        item.quantity = 1;
                        pnl_items.Controls.Add(item);
                        UpdateTotal();
                    }
                }
                catch
                {
                    txtBx_Barcode.Text = "";
                    MessageBox.Show("No barcode found", "ERROR");
                }
            }
        }

        private void CompleteSale(object sender, EventArgs e)
        {
            MoneyIn saleForm = new MoneyIn();
            saleForm.Show();
        }

        public void UpdateTotal()
        {
            lbl_total.Text = "Total: " + GetTotal().ToString();
        }

        public double GetTotal()
        {
            double working_total = 0;
            foreach (SaleItem sale in pnl_items.Controls)
            {
                working_total += (sale.productAttatched.retail_price * sale.quantity);
            }
            return working_total;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            txtBx_Barcode.Text = "";
        }
    }
}
