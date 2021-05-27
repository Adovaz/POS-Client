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
            Sales_Pnl.Controls.Add(sale);
        }

        public void newSale()
        {
            Sales_Pnl.Controls.Clear();
            Sale sale = new Sale();
            sale.Dock = DockStyle.Fill;
            Sales_Pnl.Controls.Add(sale);
        }
    }

    public class Globals
    {
        public static int branchID = 1;
        public static int staffID;
        public static string remmeber_token;
    }
}
