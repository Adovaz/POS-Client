
namespace POS
{
    partial class SaleItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_itemName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_brcd = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_itemPrice = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_totalItemPrice = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.numUD_Quantity = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_Quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_itemName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 22);
            this.panel1.TabIndex = 0;
            // 
            // lbl_itemName
            // 
            this.lbl_itemName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_itemName.Location = new System.Drawing.Point(0, 0);
            this.lbl_itemName.Name = "lbl_itemName";
            this.lbl_itemName.Size = new System.Drawing.Size(228, 22);
            this.lbl_itemName.TabIndex = 0;
            this.lbl_itemName.Text = "name";
            this.lbl_itemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_brcd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(228, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(139, 22);
            this.panel2.TabIndex = 1;
            // 
            // lbl_brcd
            // 
            this.lbl_brcd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_brcd.Location = new System.Drawing.Point(0, 0);
            this.lbl_brcd.Name = "lbl_brcd";
            this.lbl_brcd.Size = new System.Drawing.Size(139, 22);
            this.lbl_brcd.TabIndex = 0;
            this.lbl_brcd.Text = "barcode";
            this.lbl_brcd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_itemPrice);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(367, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(81, 22);
            this.panel3.TabIndex = 2;
            // 
            // lbl_itemPrice
            // 
            this.lbl_itemPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_itemPrice.Location = new System.Drawing.Point(0, 0);
            this.lbl_itemPrice.Name = "lbl_itemPrice";
            this.lbl_itemPrice.Size = new System.Drawing.Size(81, 22);
            this.lbl_itemPrice.TabIndex = 0;
            this.lbl_itemPrice.Text = "$ind PRC";
            this.lbl_itemPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbl_totalItemPrice);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(448, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(91, 22);
            this.panel4.TabIndex = 4;
            // 
            // lbl_totalItemPrice
            // 
            this.lbl_totalItemPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_totalItemPrice.Location = new System.Drawing.Point(0, 0);
            this.lbl_totalItemPrice.Name = "lbl_totalItemPrice";
            this.lbl_totalItemPrice.Size = new System.Drawing.Size(91, 22);
            this.lbl_totalItemPrice.TabIndex = 0;
            this.lbl_totalItemPrice.Text = "total PRC";
            this.lbl_totalItemPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.numUD_Quantity);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(539, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(46, 22);
            this.panel5.TabIndex = 5;
            // 
            // numUD_Quantity
            // 
            this.numUD_Quantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numUD_Quantity.Location = new System.Drawing.Point(0, 0);
            this.numUD_Quantity.Name = "numUD_Quantity";
            this.numUD_Quantity.Size = new System.Drawing.Size(46, 20);
            this.numUD_Quantity.TabIndex = 0;
            // 
            // SaleItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SaleItem";
            this.Size = new System.Drawing.Size(585, 22);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numUD_Quantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_itemName;
        private System.Windows.Forms.Label lbl_brcd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_itemPrice;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_totalItemPrice;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.NumericUpDown numUD_Quantity;
    }
}
