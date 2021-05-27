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

        //Clears barcode box
        private void ClearButton_Click(object sender, EventArgs e)
        {
            txtBx_Barcode.Text = "";
        }

        private void BarcodeCapture(object sender, KeyEventArgs e)
        {
            //txtBx_Barcode.Text = txtBx_Barcode.Text + e.KeyCode.ToString();
        }

        //Adds item on enter
        private void CheckEnterKeyPress(object sender, KeyPressEventArgs e)
        {
            //Checks for enter press
            if (e.KeyChar == (char)Keys.Return)

            {
                //Error catching
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
                        item.sale = this;
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

        //On complete sale button, 
        private void TakePayment(object sender, EventArgs e)
        {
            UpdateTotal();
            if (Total != 0)
            {
                MoneyIn saleForm = new MoneyIn(Total, this);
                this.Enabled = false;
                saleForm.Show();
            }
            if (Total == 0)
            {
                MessageBox.Show("No items to process", "ERROR");
            }
        }

        public void CompleteSale(MoneyIn moneyIn)
        {
            if(moneyIn.current_due == 0)
            {

            }
            else if(moneyIn.current_due < 0)
            {

            }
            else if(moneyIn.current_due > 0)
            {
                 MessageBox.Show("This Sale has not be paid fully");
            }
        }


        //Public variable for the current sale
        public double Total
        {
            get
            {
                double working_total = 0;
                foreach (SaleItem sale in pnl_items.Controls)
                {
                    working_total += (sale.productAttatched.retail_price * sale.quantity);
                }
                return working_total;
            }
            set
            {
                lbl_total.Text = "$ " + value;
            }
        }

        //Updates the current sales total
        public void UpdateTotal()
        {
            double total = Total;
            Total = total;
        }

    }
}
