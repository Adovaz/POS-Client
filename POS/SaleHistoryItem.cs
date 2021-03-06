using System;
using System.Windows.Forms;

namespace POS
{
    public partial class SaleHistoryItem : UserControl
    {
        public SaleHistoryItem()
        {
            InitializeComponent();
        }
        public TransactionObj transaction;

        //Public variables for changing labels

        public int staffID
        {
            get
            {
                return int.Parse(lbl_staff_id.Text);
            }
            set
            {
                lbl_staff_id.Text = value.ToString();
            }
        }
        public double total
        {
            get
            {
                return double.Parse(lbl_total.Text);
            }
            set
            {
                lbl_total.Text = "$ " + string.Format("{0:N2}", value);
            }
        }
        public DateTime timedate
        {
            get
            {
                return transaction.created_at;
            }
            set
            {
                lbl_time.Text = value.ToLocalTime().ToString();
            }
        }

        //Creates contents form
        private void btn_contents_Click(object sender, EventArgs e)
        {
            SaleContents contents = new SaleContents(transaction.id);
            contents.Show();
        }
    }
}
