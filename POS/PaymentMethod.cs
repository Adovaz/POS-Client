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
    public partial class PaymentMethod : UserControl
    {
        public PaymentMethod()
        {
            InitializeComponent();

        }
        public string payment_name
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

        public int payment_box
        {
            get
            {
                try
                {
                    int.TryParse(txtBx_payment_method.Text, out int ret);
                    return ret;

                }
                catch
                {
                    MessageBox.Show("Text is not numbers","ERROR");
                    return 0;
                }
            }
            set
            {

            }
        }

        private void txtBx_payment_method_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
