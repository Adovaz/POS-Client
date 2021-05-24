
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
            this.pnl_items = new System.Windows.Forms.Panel();
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
            this.lbl_total = new System.Windows.Forms.Label();
            this.btn_Process = new System.Windows.Forms.Button();
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
            this.Functions_pnl.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sale_Label
            // 
            this.Sale_Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.Sale_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sale_Label.Location = new System.Drawing.Point(0, 0);
            this.Sale_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Sale_Label.Name = "Sale_Label";
            this.Sale_Label.Size = new System.Drawing.Size(807, 92);
            this.Sale_Label.TabIndex = 0;
            this.Sale_Label.Text = "New Sale";
            this.Sale_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtBx_Barcode
            // 
            this.txtBx_Barcode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBx_Barcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBx_Barcode.Location = new System.Drawing.Point(0, 0);
            this.txtBx_Barcode.Margin = new System.Windows.Forms.Padding(4);
            this.txtBx_Barcode.Name = "txtBx_Barcode";
            this.txtBx_Barcode.Size = new System.Drawing.Size(681, 46);
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
            this.panel1.Location = new System.Drawing.Point(0, 92);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.panel1.Size = new System.Drawing.Size(807, 738);
            this.panel1.TabIndex = 2;
            // 
            // Panel6
            // 
            this.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel6.Controls.Add(this.pnl_items);
            this.Panel6.Controls.Add(this.panel3);
            this.Panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel6.Location = new System.Drawing.Point(13, 59);
            this.Panel6.Margin = new System.Windows.Forms.Padding(4);
            this.Panel6.Name = "Panel6";
            this.Panel6.Size = new System.Drawing.Size(781, 544);
            this.Panel6.TabIndex = 4;
            // 
            // pnl_items
            // 
            this.pnl_items.AutoScroll = true;
            this.pnl_items.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_items.Location = new System.Drawing.Point(0, 33);
            this.pnl_items.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_items.Name = "pnl_items";
            this.pnl_items.Size = new System.Drawing.Size(779, 509);
            this.pnl_items.TabIndex = 1;
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
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(779, 33);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbl_itemName_head);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(231, 33);
            this.panel4.TabIndex = 7;
            // 
            // lbl_itemName_head
            // 
            this.lbl_itemName_head.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_itemName_head.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemName_head.Location = new System.Drawing.Point(0, 0);
            this.lbl_itemName_head.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_itemName_head.Name = "lbl_itemName_head";
            this.lbl_itemName_head.Size = new System.Drawing.Size(231, 33);
            this.lbl_itemName_head.TabIndex = 0;
            this.lbl_itemName_head.Text = "Name";
            this.lbl_itemName_head.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lbl_brcd_head);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(231, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(185, 33);
            this.panel5.TabIndex = 8;
            // 
            // lbl_brcd_head
            // 
            this.lbl_brcd_head.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_brcd_head.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_brcd_head.Location = new System.Drawing.Point(0, 0);
            this.lbl_brcd_head.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_brcd_head.Name = "lbl_brcd_head";
            this.lbl_brcd_head.Size = new System.Drawing.Size(185, 33);
            this.lbl_brcd_head.TabIndex = 0;
            this.lbl_brcd_head.Text = "Description";
            this.lbl_brcd_head.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lbl_itemPrice_head);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(416, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(108, 33);
            this.panel7.TabIndex = 9;
            // 
            // lbl_itemPrice_head
            // 
            this.lbl_itemPrice_head.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_itemPrice_head.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemPrice_head.Location = new System.Drawing.Point(0, 0);
            this.lbl_itemPrice_head.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_itemPrice_head.Name = "lbl_itemPrice_head";
            this.lbl_itemPrice_head.Size = new System.Drawing.Size(108, 33);
            this.lbl_itemPrice_head.TabIndex = 0;
            this.lbl_itemPrice_head.Text = "Price";
            this.lbl_itemPrice_head.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.lbl_totalItemPrice_head);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(524, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(121, 33);
            this.panel8.TabIndex = 10;
            // 
            // lbl_totalItemPrice_head
            // 
            this.lbl_totalItemPrice_head.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_totalItemPrice_head.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalItemPrice_head.Location = new System.Drawing.Point(0, 0);
            this.lbl_totalItemPrice_head.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_totalItemPrice_head.Name = "lbl_totalItemPrice_head";
            this.lbl_totalItemPrice_head.Size = new System.Drawing.Size(121, 33);
            this.lbl_totalItemPrice_head.TabIndex = 0;
            this.lbl_totalItemPrice_head.Text = "Total";
            this.lbl_totalItemPrice_head.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.lbl_qty_head);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(645, 0);
            this.panel9.Margin = new System.Windows.Forms.Padding(4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(61, 33);
            this.panel9.TabIndex = 11;
            // 
            // lbl_qty_head
            // 
            this.lbl_qty_head.AutoSize = true;
            this.lbl_qty_head.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_qty_head.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qty_head.Location = new System.Drawing.Point(0, 0);
            this.lbl_qty_head.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_qty_head.Name = "lbl_qty_head";
            this.lbl_qty_head.Size = new System.Drawing.Size(57, 31);
            this.lbl_qty_head.TabIndex = 0;
            this.lbl_qty_head.Text = "Qty";
            // 
            // panel10
            // 
            this.panel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel10.Location = new System.Drawing.Point(706, 0);
            this.panel10.Margin = new System.Windows.Forms.Padding(4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(73, 33);
            this.panel10.TabIndex = 12;
            // 
            // Functions_pnl
            // 
            this.Functions_pnl.Controls.Add(this.lbl_total);
            this.Functions_pnl.Controls.Add(this.btn_Process);
            this.Functions_pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Functions_pnl.Location = new System.Drawing.Point(13, 603);
            this.Functions_pnl.Margin = new System.Windows.Forms.Padding(4);
            this.Functions_pnl.Name = "Functions_pnl";
            this.Functions_pnl.Size = new System.Drawing.Size(781, 123);
            this.Functions_pnl.TabIndex = 3;
            // 
            // lbl_total
            // 
            this.lbl_total.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(573, 0);
            this.lbl_total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(208, 123);
            this.lbl_total.TabIndex = 1;
            this.lbl_total.Text = "Total: 0.00";
            this.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Process
            // 
            this.btn_Process.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Process.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Process.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Process.Location = new System.Drawing.Point(0, 0);
            this.btn_Process.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Process.Name = "btn_Process";
            this.btn_Process.Size = new System.Drawing.Size(136, 123);
            this.btn_Process.TabIndex = 0;
            this.btn_Process.Text = "Process";
            this.btn_Process.UseVisualStyleBackColor = false;
            this.btn_Process.Click += new System.EventHandler(this.CompleteSale);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtBx_Barcode);
            this.panel2.Controls.Add(this.ClearButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(13, 12);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(781, 47);
            this.panel2.TabIndex = 2;
            // 
            // ClearButton
            // 
            this.ClearButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ClearButton.Location = new System.Drawing.Point(681, 0);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(4);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(100, 47);
            this.ClearButton.TabIndex = 2;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            this.ClearButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BarcodeCapture);
            // 
            // Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Sale_Label);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Sale";
            this.Size = new System.Drawing.Size(807, 830);
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
            this.Functions_pnl.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pnl_items;
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
        private System.Windows.Forms.Button btn_Process;
        private System.Windows.Forms.Label lbl_total;
    }
}
