
namespace POS
{
    partial class PaymentMethod
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
            this.btn_method = new System.Windows.Forms.Button();
            this.txt_payed = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_method
            // 
            this.btn_method.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_method.Location = new System.Drawing.Point(0, 0);
            this.btn_method.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_method.Name = "btn_method";
            this.btn_method.Size = new System.Drawing.Size(230, 50);
            this.btn_method.TabIndex = 0;
            this.btn_method.Text = "method";
            this.btn_method.UseVisualStyleBackColor = true;
            this.btn_method.Click += new System.EventHandler(this.btn_method_Click);
            // 
            // txt_payed
            // 
            this.txt_payed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_payed.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_payed.Location = new System.Drawing.Point(230, 0);
            this.txt_payed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_payed.Name = "txt_payed";
            this.txt_payed.Size = new System.Drawing.Size(223, 61);
            this.txt_payed.TabIndex = 1;
            this.txt_payed.TextChanged += new System.EventHandler(this.txtBx_payment_method_TextChanged);
            this.txt_payed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBx_payment_method_KeyPress);
            // 
            // PaymentMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_payed);
            this.Controls.Add(this.btn_method);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PaymentMethod";
            this.Size = new System.Drawing.Size(453, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_method;
        private System.Windows.Forms.TextBox txt_payed;
    }
}
