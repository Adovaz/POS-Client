
namespace POS
{
    partial class SaleHistoryItem
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
            this.lbl_staff_id = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.btn_contents = new System.Windows.Forms.Button();
            this.lbl_time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_staff_id
            // 
            this.lbl_staff_id.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_staff_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F);
            this.lbl_staff_id.Location = new System.Drawing.Point(0, 0);
            this.lbl_staff_id.Name = "lbl_staff_id";
            this.lbl_staff_id.Size = new System.Drawing.Size(132, 47);
            this.lbl_staff_id.TabIndex = 0;
            this.lbl_staff_id.Text = "Staff_ID";
            this.lbl_staff_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_total
            // 
            this.lbl_total.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F);
            this.lbl_total.Location = new System.Drawing.Point(132, 0);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(174, 47);
            this.lbl_total.TabIndex = 1;
            this.lbl_total.Text = "Total";
            this.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_contents
            // 
            this.btn_contents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_contents.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F);
            this.btn_contents.Location = new System.Drawing.Point(679, 0);
            this.btn_contents.Name = "btn_contents";
            this.btn_contents.Size = new System.Drawing.Size(297, 47);
            this.btn_contents.TabIndex = 3;
            this.btn_contents.Text = "Contents";
            this.btn_contents.UseVisualStyleBackColor = true;
            // 
            // lbl_time
            // 
            this.lbl_time.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F);
            this.lbl_time.Location = new System.Drawing.Point(306, 0);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(373, 47);
            this.lbl_time.TabIndex = 4;
            this.lbl_time.Text = "Time";
            this.lbl_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaleHistoryItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btn_contents);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_staff_id);
            this.Name = "SaleHistoryItem";
            this.Size = new System.Drawing.Size(976, 47);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_staff_id;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Button btn_contents;
        private System.Windows.Forms.Label lbl_time;
    }
}
