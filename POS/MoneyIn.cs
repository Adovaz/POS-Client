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
        public MoneyIn(double due)
        {
            InitializeComponent();

            lbl_TotalDue.Text = "Due: " + due.ToString();

            PaymentMethod cash = new PaymentMethod("Cash");
            cash.Dock = DockStyle.Top;
            pnl_payments.Controls.Add(cash);
            PaymentMethod debit = new PaymentMethod("Debit");
            debit.Dock = DockStyle.Top;
            pnl_payments.Controls.Add(debit);
            PaymentMethod eftpos = new PaymentMethod("Eftpos");
            eftpos.Dock = DockStyle.Top;
            pnl_payments.Controls.Add(eftpos);
            PaymentMethod giftcard = new PaymentMethod("Giftcard");
            giftcard.Dock = DockStyle.Top;
            pnl_payments.Controls.Add(giftcard);

        }
    }
}
