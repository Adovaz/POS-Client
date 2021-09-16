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
    public partial class SaleHistory : UserControl
    {
        public SaleHistory()
        {
            //Please note that Sale is used in place of transaction in ui for user readability
            InitializeComponent();
            //Get all transactions
            List<TransactionObj> transactions = API.Transactions();
            //Creates and initialises Sale History items
            foreach (TransactionObj transaction in transactions)
            {
                SaleHistoryItem item = new SaleHistoryItem();
                item.transaction = transaction;
                item.total = transaction.total;
                item.staffID= transaction.staff_id;
                item.timedate = transaction.created_at;
                item.Dock = DockStyle.Top;
                pnl_history_main.Controls.Add(item);
            }
        }
    }
}
