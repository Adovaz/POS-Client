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
        public double current_due;
        public Sale parent_sale;
        public double init_due;
        public MoneyIn(double due, Sale current_sale)
        {
            InitializeComponent();
            current_due = due;
            init_due = due;
            parent_sale = current_sale;
            lbl_TotalDue.Text = "Due: " + string.Format("{0:N2}", current_sale.Total);

            List<string> methods = new List<string>();
            methods.Add("Debit");
            methods.Add("Eftpos");
            methods.Add("Giftcard");

            PaymentMethod cash = new PaymentMethod();
            cash.payment_name = "Cash: $" + string.Format("{0:N2}", Math.Round(due, 1));
            cash.parent_moneyIn = this;
            cash.Dock = DockStyle.Top;
            pnl_payments.Controls.Add(cash);

            foreach (string item in methods)
            {
                PaymentMethod newMethod = new PaymentMethod();
                newMethod.payment_name = item;
                newMethod.parent_moneyIn = this;
                newMethod.Dock = DockStyle.Top;
                pnl_payments.Controls.Add(newMethod);

            }
        }

        public void UpdateDue(MoneyIn money)
        {
            double taken = 0;
            foreach (PaymentMethod payment in money.pnl_payments.Controls)
            {
                taken += payment.payment_box;
            }
            current_due = init_due - taken;
            lbl_TotalDue.Text = "Due: " + string.Format("{0:N2}", current_due);
        }

        private void btn_complete_Click(object sender, EventArgs e)
        {
            parent_sale.CompleteSale(this);
        }
    }
}
