using System;
using System.Windows.Forms;

namespace POS
{

    public partial class POS : Form
    {
        public POS()
        {
            //Initiallisesmain form and adds new sale as default 
            InitializeComponent();
            Sale sale = new Sale();
            sale.Dock = DockStyle.Fill;
            pnl_main.Controls.Add(sale);
            Globals.fatherForm = this;
        }

        //Creates a new sale in main panel
        public static void NewSale()
        {
            Globals.fatherForm.pnl_main.Controls.Clear();
            Sale sale = new Sale();
            sale.Dock = DockStyle.Fill;
            Globals.fatherForm.pnl_main.Controls.Add(sale);
        }

        //Created a new Sale history in main panel
        public static void NewSaleHistory()
        {
            Globals.fatherForm.pnl_main.Controls.Clear();
            SaleHistory saleHistory = new SaleHistory();
            saleHistory.Dock = DockStyle.Fill;
            Globals.fatherForm.pnl_main.Controls.Add(saleHistory);
        }

        //handles button clicks for changing main panel
        private void btn_new_sale_Click(object sender, EventArgs e)
        {
            NewSale();
        }

        private void btn_sale_history_Click(object sender, EventArgs e)
        {
            NewSaleHistory();
        }

        //Closes form
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    //Globally available vairables
    public class Globals
    {
        public static int branchID = 1;
        public static int staffID = 1;
        public static string rememberToken;
        public static POS fatherForm;
    }
}
