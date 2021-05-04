
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
            this.Sales_Pnl = new System.Windows.Forms.Panel();
            this.Menu_Pnl = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Sales_Pnl
            // 
            this.Sales_Pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sales_Pnl.Location = new System.Drawing.Point(630, 10);
            this.Sales_Pnl.Name = "Sales_Pnl";
            this.Sales_Pnl.Size = new System.Drawing.Size(611, 674);
            this.Sales_Pnl.TabIndex = 0;
            // 
            // Menu_Pnl
            // 
            this.Menu_Pnl.BackgroundImage = global::POS.Properties.Resources.under_costruction;
            this.Menu_Pnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Menu_Pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu_Pnl.Location = new System.Drawing.Point(10, 10);
            this.Menu_Pnl.Name = "Menu_Pnl";
            this.Menu_Pnl.Size = new System.Drawing.Size(620, 674);
            this.Menu_Pnl.TabIndex = 1;
            // 
            // POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 694);
            this.Controls.Add(this.Sales_Pnl);
            this.Controls.Add(this.Menu_Pnl);
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

        private System.Windows.Forms.Panel Sales_Pnl;
        private System.Windows.Forms.Panel Menu_Pnl;
    }
}

