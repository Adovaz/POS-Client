using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

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
            txt_barcodeInput.Text = "";
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
                    Tuple<ProductObj, ProductVariationObj> tmp = API.GetSaleItem(txt_barcodeInput.Text);
                    ProductObj product = tmp.Item1;
                    ProductVariationObj variation = tmp.Item2;
                    txt_barcodeInput.Text = "";
                    bool hasItem = false;
                    //Checks for items existence 
                    foreach (SaleItem sale in pnl_items.Controls)
                    {
                        //Increases quantity if item exists
                        if (sale.productAttatched.id == variation.id)
                        {
                            sale.quantity++;
                            UpdateTotal();
                            hasItem = true;
                        }
                    }
                    //Creates GUI sale item
                    if (!hasItem)
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
                    txt_barcodeInput.Text = "";
                    MessageBox.Show("No barcode found", "ERROR");
                }
            }
        }

        //On complete sale button updates total and opens MoneyIn
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

        //Wraps items into json
        public string CreateTransactionJson()
        {
            TransactionPostJson obj = new TransactionPostJson();
            TransactionContent[] contents = new TransactionContent[32];
            for (int i = 0; i < pnl_items.Controls.Count; i++)
            {
                SaleItem item = (SaleItem)pnl_items.Controls[i];
                TransactionContent tmp = new TransactionContent();
                tmp.product_variation_id = item.productAttatched.id;
                tmp.quantity = item.quantity;
                contents[i] = tmp;
            }
            obj.contents = contents;
            obj.transaction_type = "sale";
            obj.total = Total.ToString();
            obj.staff_id = Globals.staffID.ToString();

            return JsonConvert.SerializeObject(obj);
        }

        //On MoneyIn completed
        public void CompleteSale(MoneyIn moneyIn)
        {
            if(moneyIn.currentDue == 0)
            {
                try
                {
                    API.SubmitTransaction(CreateTransactionJson());
                }
                catch
                {
                    MessageBox.Show("ERROR");
                }
            }
            else if(moneyIn.currentDue < 0)
            {

            }
            else if(moneyIn.currentDue > 0)
            {
                 MessageBox.Show("This Sale has not be paid fully");
            }
        }


        //Public variable for the total of the current sale
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
                lbl_total.Text = "$ " + string.Format("{0:N2}", value);
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
