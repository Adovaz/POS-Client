
namespace POS
{
    partial class SaleContents
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
            this.pml_header = new System.Windows.Forms.Panel();
            this.lbl_qty = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.pnl_contents = new System.Windows.Forms.Panel();
            this.pml_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // pml_header
            // 
            this.pml_header.Controls.Add(this.lbl_qty);
            this.pml_header.Controls.Add(this.lbl_name);
            this.pml_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pml_header.Location = new System.Drawing.Point(0, 0);
            this.pml_header.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pml_header.Name = "pml_header";
            this.pml_header.Size = new System.Drawing.Size(512, 50);
            this.pml_header.TabIndex = 0;
            // 
            // lbl_qty
            // 
            this.lbl_qty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qty.Location = new System.Drawing.Point(436, 0);
            this.lbl_qty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_qty.Name = "lbl_qty";
            this.lbl_qty.Size = new System.Drawing.Size(76, 50);
            this.lbl_qty.TabIndex = 1;
            this.lbl_qty.Text = "Qty";
            this.lbl_qty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_name
            // 
            this.lbl_name.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(0, 0);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(436, 50);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_contents
            // 
            this.pnl_contents.AutoScroll = true;
            this.pnl_contents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_contents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_contents.Location = new System.Drawing.Point(0, 50);
            this.pnl_contents.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_contents.Name = "pnl_contents";
            this.pnl_contents.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.pnl_contents.Size = new System.Drawing.Size(512, 408);
            this.pnl_contents.TabIndex = 1;
            // 
            // SaleContents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 458);
            this.Controls.Add(this.pnl_contents);
            this.Controls.Add(this.pml_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SaleContents";
            this.Text = "Sale Contents";
            this.TopMost = true;
            this.pml_header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pml_header;
        private System.Windows.Forms.Label lbl_qty;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Panel pnl_contents;
    }
}