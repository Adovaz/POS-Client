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
        public MoneyIn(double due, Sale current_sale)
        {
            InitializeComponent();

            lbl_TotalDue.Text = "Due: " + current_sale.Total.ToString();

            List<string> methods = new List<string>();
            methods.Add("Debit");
            methods.Add("Eftpos");
            methods.Add("Giftcard");

            PaymentMethod cash = new PaymentMethod();
            cash.payment_name = "Cash: $" + string.Format("{0:N2}", Math.Round(due, 1));
            cash.Dock = DockStyle.Top;
            pnl_payments.Controls.Add(cash);

            foreach (string item in methods)
            {
                PaymentMethod newMethod = new PaymentMethod();
                newMethod.payment_name = item;
                newMethod.Dock = DockStyle.Top;
                pnl_payments.Controls.Add(newMethod);

            }
        }

        public void UpdateDue (Sale current_sale)
        {
            int ongoing_due = current_sale.Total;
        }
        
    }
}
