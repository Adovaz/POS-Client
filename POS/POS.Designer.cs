
namespace POS
{
    partial class POS
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
            this.pnl_sales = new System.Windows.Forms.Panel();
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnl_sales
            // 
            this.pnl_sales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_sales.Location = new System.Drawing.Point(630, 10);
            this.pnl_sales.Name = "pnl_sales";
            this.pnl_sales.Size = new System.Drawing.Size(611, 674);
            this.pnl_sales.TabIndex = 0;
            // 
            // pnl_menu
            // 
            this.pnl_menu.BackgroundImage = global::POS.Properties.Resources.under_costruction;
            this.pnl_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_menu.Location = new System.Drawing.Point(10, 10);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(620, 674);
            this.pnl_menu.TabIndex = 1;
            // 
            // POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 694);
            this.Controls.Add(this.pnl_sales);
            this.Controls.Add(this.pnl_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "POS";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "POS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_sales;
        private System.Windows.Forms.Panel pnl_menu;
    }
}

