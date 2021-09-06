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

    public partial class POS : Form
    {
        public POS()
        {
            InitializeComponent();
            Sale sale = new Sale();
            sale.Dock = DockStyle.Fill;
            pnl_main.Controls.Add(sale);
            Globals.fatherForm = this;
        }

        public static void NewSale()
        {
            Globals.fatherForm.pnl_main.Controls.Clear();
            Sale sale = new Sale();
            sale.Dock = DockStyle.Fill;
            Globals.fatherForm.pnl_main.Controls.Add(sale);
        }

        public static void NewSaleHistory()
        {
            Globals.fatherForm.pnl_main.Controls.Clear();
            SaleHistory saleHistory = new SaleHistory();
            saleHistory.Dock = DockStyle.Fill;
            Globals.fatherForm.pnl_main.Controls.Add(saleHistory);
        }

        private void btn_new_sale_Click(object sender, EventArgs e)
        {
            NewSale();
        }

        private void btn_sale_history_Click(object sender, EventArgs e)
        {
            NewSaleHistory();
        }
    }

    public class Globals
    {
        public static int branchID = 1;
        public static int staffID = 1;
        public static string rememberToken;
        public static POS fatherForm;
    }
}
