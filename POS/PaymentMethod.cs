using System;
using System.Windows.Forms;

namespace POS
{
    public partial class PaymentMethod : UserControl
    {
        public MoneyIn parentMoneyIn;

        public PaymentMethod()
        {
            InitializeComponent();

        }
        //Variables for public access
        public string name
        {
            get
            {
                return btn_method.Text;
            }
            set
            {
                btn_method.Text = value;
            }
        }

        public double value
        {
            get
            {
                try
                {
                    double.TryParse(txt_payed.Text, out double ret);
                    return ret;

                }
                catch
                {
                    MessageBox.Show("Text is not numbers", "ERROR");
                    return 0;
                }
            }
            set
            {
                txt_payed.Text = string.Format("{0:N2}", value.ToString());
            }
        }

        //Checks for incorrect user formatting
        private void txtBx_payment_method_KeyPress(object sender, KeyPressEventArgs e)
        //only allow numeric
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        //Updates the amount due on text change
        private void txtBx_payment_method_TextChanged(object sender, EventArgs e)
        {
            parentMoneyIn.UpdateDue();
        }

        //Autofill Payment
        private void btn_method_Click(object sender, EventArgs e)
        {
            value = parentMoneyIn.currentDue;
        }
    }
}
