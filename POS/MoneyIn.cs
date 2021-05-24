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
        public double ext_due;
        public MoneyIn(double due, Sale current_sale)
        {
            InitializeComponent();
            ext_due = due;
            lbl_TotalDue.Text = "Due: " + current_sale.Total.ToString();

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
            double ongoing_due = ext_due;
            double taken = 0;
            foreach (PaymentMethod payment in money.pnl_payments.Controls)
            {
                taken += payment.payment_box;
            }
            lbl_TotalDue.Text = "Due: " + (ongoing_due - taken).ToString();
        }

    }
}
