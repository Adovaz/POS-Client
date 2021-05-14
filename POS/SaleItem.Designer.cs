
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_Quantity)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_itemName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 33);
            this.panel1.TabIndex = 0;
            // 
            // lbl_itemName
            // 
            this.lbl_itemName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_itemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemName.Location = new System.Drawing.Point(0, 0);
            this.lbl_itemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_itemName.Name = "lbl_itemName";
            this.lbl_itemName.Size = new System.Drawing.Size(324, 33);
            this.lbl_itemName.TabIndex = 0;
            this.lbl_itemName.Text = "name";
            this.lbl_itemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_brcd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(324, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 33);
            this.panel2.TabIndex = 1;
            // 
            // lbl_brcd
            // 
            this.lbl_brcd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_brcd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_brcd.Location = new System.Drawing.Point(0, 0);
            this.lbl_brcd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_brcd.Name = "lbl_brcd";
            this.lbl_brcd.Size = new System.Drawing.Size(185, 33);
            this.lbl_brcd.TabIndex = 0;
            this.lbl_brcd.Text = "barcode";
            this.lbl_brcd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_itemPrice);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(509, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(108, 33);
            this.panel3.TabIndex = 2;
            // 
            // lbl_itemPrice
            // 
            this.lbl_itemPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_itemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemPrice.Location = new System.Drawing.Point(0, 0);
            this.lbl_itemPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_itemPrice.Name = "lbl_itemPrice";
            this.lbl_itemPrice.Size = new System.Drawing.Size(108, 33);
            this.lbl_itemPrice.TabIndex = 0;
            this.lbl_itemPrice.Text = "$ind PRC";
            this.lbl_itemPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbl_totalItemPrice);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(617, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(121, 33);
            this.panel4.TabIndex = 4;
            // 
            // lbl_totalItemPrice
            // 
            this.lbl_totalItemPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_totalItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalItemPrice.Location = new System.Drawing.Point(0, 0);
            this.lbl_totalItemPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_totalItemPrice.Name = "lbl_totalItemPrice";
            this.lbl_totalItemPrice.Size = new System.Drawing.Size(121, 33);
            this.lbl_totalItemPrice.TabIndex = 0;
            this.lbl_totalItemPrice.Text = "total PRC";
            this.lbl_totalItemPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.numUD_Quantity);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(738, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(61, 33);
            this.panel5.TabIndex = 5;
            // 
            // numUD_Quantity
            // 
            this.numUD_Quantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numUD_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUD_Quantity.Location = new System.Drawing.Point(0, 0);
            this.numUD_Quantity.Margin = new System.Windows.Forms.Padding(4);
            this.numUD_Quantity.Name = "numUD_Quantity";
            this.numUD_Quantity.Size = new System.Drawing.Size(61, 34);
            this.numUD_Quantity.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(799, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(1);
            this.panel6.Size = new System.Drawing.Size(73, 33);
            this.panel6.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1, 1);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SaleItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SaleItem";
            this.Size = new System.Drawing.Size(872, 33);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numUD_Quantity)).EndInit();
            this.panel6.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button1;
    }
}
