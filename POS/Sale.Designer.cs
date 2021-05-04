
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
            this.Items_pnl = new System.Windows.Forms.Panel();
            this.Functions_pnl = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ClearButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            this.panel1.Controls.Add(this.Items_pnl);
            this.panel1.Controls.Add(this.Functions_pnl);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 75);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(605, 599);
            this.panel1.TabIndex = 2;
            // 
            // Items_pnl
            // 
            this.Items_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Items_pnl.Location = new System.Drawing.Point(10, 48);
            this.Items_pnl.Name = "Items_pnl";
            this.Items_pnl.Size = new System.Drawing.Size(585, 441);
            this.Items_pnl.TabIndex = 4;
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
        private System.Windows.Forms.Panel Items_pnl;
        private System.Windows.Forms.Panel Functions_pnl;
    }
}
