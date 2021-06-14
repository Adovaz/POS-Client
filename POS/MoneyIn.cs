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
    public partial class MoneyIn : Form
    {
        public double currentDue;
        public Sale parentSale;
        public double initialDue;
        public MoneyIn(double due, Sale current_sale)
        {
            InitializeComponent();
            currentDue = due;
            initialDue = due;
            parentSale = current_sale;
            lbl_due.Text = "Due: " + string.Format("{0:N2}", current_sale.Total);

            List<string> methods = new List<string>();
            methods.Add("Debit");
            methods.Add("Eftpos");
            methods.Add("Giftcard");

            PaymentMethod cash = new PaymentMethod();
            cash.name = "Cash: $" + string.Format("{0:N2}", Math.Round(due, 1));
            cash.parentMoneyIn = this;
            cash.Dock = DockStyle.Top;
            pnl_payments.Controls.Add(cash);

            foreach (string item in methods)
            {
                PaymentMethod newMethod = new PaymentMethod();
                newMethod.name = item;
                newMethod.parentMoneyIn = this;
                newMethod.Dock = DockStyle.Top;
                pnl_payments.Controls.Add(newMethod);

            }
        }

        public void UpdateDue(MoneyIn money)
        {
            double taken = 0;
            foreach (PaymentMethod payment in money.pnl_payments.Controls)
            {
                taken += payment.value;
            }
            currentDue = initialDue - taken;
            lbl_due.Text = "Due: " + string.Format("{0:N2}", currentDue);
        }

        private void btn_complete_Click(object sender, EventArgs e)
        {
            parentSale.CompleteSale(this);
        }
    }
}
