
namespace POS
{
    partial class MoneyIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_due = new System.Windows.Forms.Label();
            this.pnl_payments = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_complete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_due
            // 
            this.lbl_due.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_due.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_due.Location = new System.Drawing.Point(0, 0);
            this.lbl_due.Name = "lbl_due";
            this.lbl_due.Size = new System.Drawing.Size(453, 42);
            this.lbl_due.TabIndex = 0;
            this.lbl_due.Text = "Due: $00.00";
            this.lbl_due.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_payments
            // 
            this.pnl_payments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_payments.Location = new System.Drawing.Point(0, 42);
            this.pnl_payments.Name = "pnl_payments";
            this.pnl_payments.Size = new System.Drawing.Size(453, 386);
            this.pnl_payments.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_complete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 428);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 100);
            this.panel1.TabIndex = 3;
            // 
            // btn_complete
            // 
            this.btn_complete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_complete.Location = new System.Drawing.Point(0, 0);
            this.btn_complete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_complete.Name = "btn_complete";
            this.btn_complete.Size = new System.Drawing.Size(453, 100);
            this.btn_complete.TabIndex = 0;
            this.btn_complete.Text = "Complete";
            this.btn_complete.UseVisualStyleBackColor = true;
            this.btn_complete.Click += new System.EventHandler(this.btn_complete_Click);
            // 
            // MoneyIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 528);
            this.Controls.Add(this.pnl_payments);
            this.Controls.Add(this.lbl_due);
            this.Controls.Add(this.panel1);
            this.Name = "MoneyIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoneyIn";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_due;
        private System.Windows.Forms.Panel pnl_payments;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_complete;
    }
}