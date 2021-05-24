
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
            this.txtBx_payment_method = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_method
            // 
            this.btn_method.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_method.Location = new System.Drawing.Point(0, 0);
            this.btn_method.Name = "btn_method";
            this.btn_method.Size = new System.Drawing.Size(306, 62);
            this.btn_method.TabIndex = 0;
            this.btn_method.Text = "method";
            this.btn_method.UseVisualStyleBackColor = true;
            // 
            // txtBx_payment_method
            // 
            this.txtBx_payment_method.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBx_payment_method.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBx_payment_method.Location = new System.Drawing.Point(306, 0);
            this.txtBx_payment_method.Name = "txtBx_payment_method";
            this.txtBx_payment_method.Size = new System.Drawing.Size(298, 61);
            this.txtBx_payment_method.TabIndex = 1;
            // 
            // PaymentMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtBx_payment_method);
            this.Controls.Add(this.btn_method);
            this.Name = "PaymentMethod";
            this.Size = new System.Drawing.Size(604, 62);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_method;
        private System.Windows.Forms.TextBox txtBx_payment_method;
    }
}
