﻿using System;
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
        public MoneyIn parent_moneyIn;

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

        public double payment_box
        {
            get
            {
                try
                {
                    double.TryParse(txtBx_payment_method.Text, out double ret);
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
                txtBx_payment_method.Text = value.ToString();
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

        private void txtBx_payment_method_TextChanged(object sender, EventArgs e)
        {
            parent_moneyIn.UpdateDue(parent_moneyIn);
        }

        private void btn_method_Click(object sender, EventArgs e)
        {
            payment_box = parent_moneyIn.current_due;
        }
    }
}
