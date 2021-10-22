using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace POS
{
    public partial class MoneyIn : Form
    {
        public double currentDue;
        public Sale parentSale;
        public double initialDue;

        //initialise window 
        public MoneyIn(double due, Sale current_sale)
        {
            InitializeComponent();
            //Set Variables needed locally
            currentDue = due;
            initialDue = due;
            parentSale = current_sale;
            //Sets label to ammount due
            lbl_due.Text = "Due: " + string.Format("{0:N2}", current_sale.Total);

            //Allows for multiple different playment methods if needed
            List<string> methods = new List<string>();
            methods.Add("Payment");

            //Create and initiallises each payment method in list, sets variables ect.
            foreach (string item in methods)
            {
                PaymentMethod newMethod = new PaymentMethod();
                newMethod.name = item;
                newMethod.parentMoneyIn = this;
                newMethod.Dock = DockStyle.Top;
                pnl_payments.Controls.Add(newMethod);

            }
        }

        //Updates due to correct format 
        public void UpdateDue()
        {
            double taken = 0;
            foreach (PaymentMethod payment in this.pnl_payments.Controls)
            {
                taken += payment.value;
            }
            currentDue = initialDue - taken;
            lbl_due.Text = "Due: " + string.Format("{0:N2}", currentDue);
        }

        //On complete, runs Complete sale function in parent sale
        private void btn_complete_Click(object sender, EventArgs e)
        {
            parentSale.CompleteSale(this);
        }

        //Enables Parent form when closing
        private void MoneyIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentSale.Enabled = true;
        }
    }
}
