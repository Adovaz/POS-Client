
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
            this.lbl_TotalDue = new System.Windows.Forms.Label();
            this.pnl_cash = new System.Windows.Forms.Panel();
            this.lbl_cashTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_cash.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_TotalDue
            // 
            this.lbl_TotalDue.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_TotalDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalDue.Location = new System.Drawing.Point(0, 0);
            this.lbl_TotalDue.Name = "lbl_TotalDue";
            this.lbl_TotalDue.Size = new System.Drawing.Size(873, 42);
            this.lbl_TotalDue.TabIndex = 0;
            this.lbl_TotalDue.Text = "Due: $00.00";
            this.lbl_TotalDue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_cash
            // 
            this.pnl_cash.Controls.Add(this.panel1);
            this.pnl_cash.Controls.Add(this.lbl_cashTitle);
            this.pnl_cash.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_cash.Location = new System.Drawing.Point(0, 42);
            this.pnl_cash.Name = "pnl_cash";
            this.pnl_cash.Size = new System.Drawing.Size(219, 486);
            this.pnl_cash.TabIndex = 1;
            // 
            // lbl_cashTitle
            // 
            this.lbl_cashTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_cashTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cashTitle.Location = new System.Drawing.Point(0, 0);
            this.lbl_cashTitle.Name = "lbl_cashTitle";
            this.lbl_cashTitle.Size = new System.Drawing.Size(219, 39);
            this.lbl_cashTitle.TabIndex = 0;
            this.lbl_cashTitle.Text = "Cash";
            this.lbl_cashTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 74);
            this.panel1.TabIndex = 1;
            // 
            // MoneyIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 528);
            this.Controls.Add(this.pnl_cash);
            this.Controls.Add(this.lbl_TotalDue);
            this.Name = "MoneyIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoneyIn";
            this.TopMost = true;
            this.pnl_cash.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_TotalDue;
        private System.Windows.Forms.Panel pnl_cash;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_cashTitle;
    }
}