
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
            this.txt_barcodeInput = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Panel6 = new System.Windows.Forms.Panel();
            this.pnl_items = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_name = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_barcode = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbl_price = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lbl_totalPrice = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.pnl_functions = new System.Windows.Forms.Panel();
            this.lbl_total = new System.Windows.Forms.Label();
            this.btn_Process = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_clear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.Panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.pnl_functions.SuspendLayout();
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
            // txt_barcodeInput
            // 
            this.txt_barcodeInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_barcodeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_barcodeInput.Location = new System.Drawing.Point(0, 0);
            this.txt_barcodeInput.Name = "txt_barcodeInput";
            this.txt_barcodeInput.Size = new System.Drawing.Size(510, 38);
            this.txt_barcodeInput.TabIndex = 1;
            this.txt_barcodeInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BarcodeCapture);
            this.txt_barcodeInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnterKeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Panel6);
            this.panel1.Controls.Add(this.pnl_functions);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 75);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.panel1.Size = new System.Drawing.Size(605, 599);
            this.panel1.TabIndex = 2;
            // 
            // Panel6
            // 
            this.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel6.Controls.Add(this.pnl_items);
            this.Panel6.Controls.Add(this.panel3);
            this.Panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel6.Location = new System.Drawing.Point(10, 48);
            this.Panel6.Name = "Panel6";
            this.Panel6.Size = new System.Drawing.Size(585, 441);
            this.Panel6.TabIndex = 4;
            // 
            // pnl_items
            // 
            this.pnl_items.AutoScroll = true;
            this.pnl_items.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_items.Location = new System.Drawing.Point(0, 27);
            this.pnl_items.Name = "pnl_items";
            this.pnl_items.Size = new System.Drawing.Size(583, 412);
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
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(583, 27);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbl_name);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(171, 27);
            this.panel4.TabIndex = 7;
            // 
            // lbl_name
            // 
            this.lbl_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(0, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(171, 27);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lbl_barcode);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(171, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(139, 27);
            this.panel5.TabIndex = 8;
            // 
            // lbl_barcode
            // 
            this.lbl_barcode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_barcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_barcode.Location = new System.Drawing.Point(0, 0);
            this.lbl_barcode.Name = "lbl_barcode";
            this.lbl_barcode.Size = new System.Drawing.Size(139, 27);
            this.lbl_barcode.TabIndex = 0;
            this.lbl_barcode.Text = "Description";
            this.lbl_barcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lbl_price);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(310, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(81, 27);
            this.panel7.TabIndex = 9;
            // 
            // lbl_price
            // 
            this.lbl_price.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(0, 0);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(81, 27);
            this.lbl_price.TabIndex = 0;
            this.lbl_price.Text = "Price";
            this.lbl_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.lbl_totalPrice);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(391, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(91, 27);
            this.panel8.TabIndex = 10;
            // 
            // lbl_totalPrice
            // 
            this.lbl_totalPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_totalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalPrice.Location = new System.Drawing.Point(0, 0);
            this.lbl_totalPrice.Name = "lbl_totalPrice";
            this.lbl_totalPrice.Size = new System.Drawing.Size(91, 27);
            this.lbl_totalPrice.TabIndex = 0;
            this.lbl_totalPrice.Text = "Total";
            this.lbl_totalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.lbl_quantity);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(482, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(46, 27);
            this.panel9.TabIndex = 11;
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantity.Location = new System.Drawing.Point(0, 0);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(45, 25);
            this.lbl_quantity.TabIndex = 0;
            this.lbl_quantity.Text = "Qty";
            // 
            // panel10
            // 
            this.panel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel10.Location = new System.Drawing.Point(528, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(55, 27);
            this.panel10.TabIndex = 12;
            // 
            // pnl_functions
            // 
            this.pnl_functions.Controls.Add(this.lbl_total);
            this.pnl_functions.Controls.Add(this.btn_Process);
            this.pnl_functions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_functions.Location = new System.Drawing.Point(10, 489);
            this.pnl_functions.Name = "pnl_functions";
            this.pnl_functions.Size = new System.Drawing.Size(585, 100);
            this.pnl_functions.TabIndex = 3;
            // 
            // lbl_total
            // 
            this.lbl_total.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(429, 0);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(156, 100);
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
            this.btn_Process.Name = "btn_Process";
            this.btn_Process.Size = new System.Drawing.Size(102, 100);
            this.btn_Process.TabIndex = 0;
            this.btn_Process.Text = "Process";
            this.btn_Process.UseVisualStyleBackColor = false;
            this.btn_Process.Click += new System.EventHandler(this.TakePayment);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_barcodeInput);
            this.panel2.Controls.Add(this.btn_clear);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(585, 38);
            this.panel2.TabIndex = 2;
            // 
            // btn_clear
            // 
            this.btn_clear.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_clear.Location = new System.Drawing.Point(510, 0);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 38);
            this.btn_clear.TabIndex = 2;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.ClearButton_Click);
            this.btn_clear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BarcodeCapture);
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
            this.pnl_functions.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Sale_Label;
        private System.Windows.Forms.TextBox txt_barcodeInput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Panel Panel6;
        private System.Windows.Forms.Panel pnl_functions;
        private System.Windows.Forms.Panel pnl_items;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbl_barcode;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lbl_totalPrice;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.Button btn_Process;
        private System.Windows.Forms.Label lbl_total;
    }
}
