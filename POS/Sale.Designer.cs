
namespace POS
{
    partial class Sale
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
            this.Sale_Label = new System.Windows.Forms.Label();
            this.txtBx_Barcode = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Panel6 = new System.Windows.Forms.Panel();
            this.Items_pnl = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_itemName_head = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_brcd_head = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbl_itemPrice_head = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lbl_totalItemPrice_head = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lbl_qty_head = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.Functions_pnl = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ClearButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.Panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sale_Label
            // 
            this.Sale_Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.Sale_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sale_Label.Location = new System.Drawing.Point(0, 0);
            this.Sale_Label.Name = "Sale_Label";
            this.Sale_Label.Size = new System.Drawing.Size(605, 75);
            this.Sale_Label.TabIndex = 0;
            this.Sale_Label.Text = "New Sale";
            this.Sale_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtBx_Barcode
            // 
            this.txtBx_Barcode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBx_Barcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBx_Barcode.Location = new System.Drawing.Point(0, 0);
            this.txtBx_Barcode.Name = "txtBx_Barcode";
            this.txtBx_Barcode.Size = new System.Drawing.Size(510, 38);
            this.txtBx_Barcode.TabIndex = 1;
            this.txtBx_Barcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BarcodeCapture);
            this.txtBx_Barcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnterKeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Panel6);
            this.panel1.Controls.Add(this.Functions_pnl);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 75);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(605, 599);
            this.panel1.TabIndex = 2;
            // 
            // Panel6
            // 
            this.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel6.Controls.Add(this.Items_pnl);
            this.Panel6.Controls.Add(this.panel3);
            this.Panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel6.Location = new System.Drawing.Point(10, 48);
            this.Panel6.Name = "Panel6";
            this.Panel6.Size = new System.Drawing.Size(585, 441);
            this.Panel6.TabIndex = 4;
            // 
            // Items_pnl
            // 
            this.Items_pnl.AutoScroll = true;
            this.Items_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Items_pnl.Location = new System.Drawing.Point(0, 27);
            this.Items_pnl.Name = "Items_pnl";
            this.Items_pnl.Size = new System.Drawing.Size(583, 412);
            this.Items_pnl.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.panel10);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(583, 27);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbl_itemName_head);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(171, 27);
            this.panel4.TabIndex = 7;
            // 
            // lbl_itemName_head
            // 
            this.lbl_itemName_head.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_itemName_head.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemName_head.Location = new System.Drawing.Point(0, 0);
            this.lbl_itemName_head.Name = "lbl_itemName_head";
            this.lbl_itemName_head.Size = new System.Drawing.Size(171, 27);
            this.lbl_itemName_head.TabIndex = 0;
            this.lbl_itemName_head.Text = "Name";
            this.lbl_itemName_head.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lbl_brcd_head);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(171, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(139, 27);
            this.panel5.TabIndex = 8;
            // 
            // lbl_brcd_head
            // 
            this.lbl_brcd_head.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_brcd_head.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_brcd_head.Location = new System.Drawing.Point(0, 0);
            this.lbl_brcd_head.Name = "lbl_brcd_head";
            this.lbl_brcd_head.Size = new System.Drawing.Size(139, 27);
            this.lbl_brcd_head.TabIndex = 0;
            this.lbl_brcd_head.Text = "Barcode";
            this.lbl_brcd_head.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lbl_itemPrice_head);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(310, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(81, 27);
            this.panel7.TabIndex = 9;
            // 
            // lbl_itemPrice_head
            // 
            this.lbl_itemPrice_head.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_itemPrice_head.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemPrice_head.Location = new System.Drawing.Point(0, 0);
            this.lbl_itemPrice_head.Name = "lbl_itemPrice_head";
            this.lbl_itemPrice_head.Size = new System.Drawing.Size(81, 27);
            this.lbl_itemPrice_head.TabIndex = 0;
            this.lbl_itemPrice_head.Text = "Price";
            this.lbl_itemPrice_head.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.lbl_totalItemPrice_head);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(391, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(91, 27);
            this.panel8.TabIndex = 10;
            // 
            // lbl_totalItemPrice_head
            // 
            this.lbl_totalItemPrice_head.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_totalItemPrice_head.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalItemPrice_head.Location = new System.Drawing.Point(0, 0);
            this.lbl_totalItemPrice_head.Name = "lbl_totalItemPrice_head";
            this.lbl_totalItemPrice_head.Size = new System.Drawing.Size(91, 27);
            this.lbl_totalItemPrice_head.TabIndex = 0;
            this.lbl_totalItemPrice_head.Text = "Total";
            this.lbl_totalItemPrice_head.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.lbl_qty_head);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(482, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(46, 27);
            this.panel9.TabIndex = 11;
            // 
            // lbl_qty_head
            // 
            this.lbl_qty_head.AutoSize = true;
            this.lbl_qty_head.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_qty_head.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qty_head.Location = new System.Drawing.Point(0, 0);
            this.lbl_qty_head.Name = "lbl_qty_head";
            this.lbl_qty_head.Size = new System.Drawing.Size(45, 25);
            this.lbl_qty_head.TabIndex = 0;
            this.lbl_qty_head.Text = "Qty";
            // 
            // panel10
            // 
            this.panel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel10.Location = new System.Drawing.Point(528, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(55, 27);
            this.panel10.TabIndex = 12;
            // 
            // Functions_pnl
            // 
            this.Functions_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Functions_pnl.Location = new System.Drawing.Point(10, 489);
            this.Functions_pnl.Name = "Functions_pnl";
            this.Functions_pnl.Size = new System.Drawing.Size(585, 100);
            this.Functions_pnl.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtBx_Barcode);
            this.panel2.Controls.Add(this.ClearButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(585, 38);
            this.panel2.TabIndex = 2;
            // 
            // ClearButton
            // 
            this.ClearButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ClearButton.Location = new System.Drawing.Point(510, 0);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 38);
            this.ClearButton.TabIndex = 2;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            this.ClearButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BarcodeCapture);
            // 
            // Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Sale_Label);
            this.Name = "Sale";
            this.Size = new System.Drawing.Size(605, 674);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BarcodeCapture);
            this.panel1.ResumeLayout(false);
            this.Panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Sale_Label;
        private System.Windows.Forms.TextBox txtBx_Barcode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Panel Panel6;
        private System.Windows.Forms.Panel Functions_pnl;
        private System.Windows.Forms.Panel Items_pnl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_itemName_head;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbl_brcd_head;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lbl_itemPrice_head;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lbl_totalItemPrice_head;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label lbl_qty_head;
    }
}
