
namespace POS
{
    partial class SaleHistory
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
            this.lbl_sale_history = new System.Windows.Forms.Label();
            this.pnl_history_parent = new System.Windows.Forms.Panel();
            this.pnl_history_main = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_contents = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_staff_id = new System.Windows.Forms.Label();
            this.pnl_history_parent.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_sale_history
            // 
            this.lbl_sale_history.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_sale_history.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sale_history.Location = new System.Drawing.Point(0, 0);
            this.lbl_sale_history.Name = "lbl_sale_history";
            this.lbl_sale_history.Size = new System.Drawing.Size(807, 92);
            this.lbl_sale_history.TabIndex = 0;
            this.lbl_sale_history.Text = "History";
            this.lbl_sale_history.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnl_history_parent
            // 
            this.pnl_history_parent.Controls.Add(this.pnl_history_main);
            this.pnl_history_parent.Controls.Add(this.panel1);
            this.pnl_history_parent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_history_parent.Location = new System.Drawing.Point(0, 92);
            this.pnl_history_parent.Name = "pnl_history_parent";
            this.pnl_history_parent.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.pnl_history_parent.Size = new System.Drawing.Size(807, 738);
            this.pnl_history_parent.TabIndex = 1;
            // 
            // pnl_history_main
            // 
            this.pnl_history_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_history_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_history_main.Location = new System.Drawing.Point(13, 55);
            this.pnl_history_main.Name = "pnl_history_main";
            this.pnl_history_main.Size = new System.Drawing.Size(781, 671);
            this.pnl_history_main.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_contents);
            this.panel1.Controls.Add(this.lbl_time);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbl_total);
            this.panel1.Controls.Add(this.lbl_staff_id);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 43);
            this.panel1.TabIndex = 0;
            // 
            // lbl_contents
            // 
            this.lbl_contents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_contents.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F);
            this.lbl_contents.Location = new System.Drawing.Point(525, 0);
            this.lbl_contents.Name = "lbl_contents";
            this.lbl_contents.Size = new System.Drawing.Size(256, 43);
            this.lbl_contents.TabIndex = 7;
            this.lbl_contents.Text = "Contents";
            this.lbl_contents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_time
            // 
            this.lbl_time.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F);
            this.lbl_time.Location = new System.Drawing.Point(325, 0);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(200, 43);
            this.lbl_time.TabIndex = 9;
            this.lbl_time.Text = "Time";
            this.lbl_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(631, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 8;
            // 
            // lbl_total
            // 
            this.lbl_total.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F);
            this.lbl_total.Location = new System.Drawing.Point(135, 0);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(190, 43);
            this.lbl_total.TabIndex = 5;
            this.lbl_total.Text = "Total";
            this.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_staff_id
            // 
            this.lbl_staff_id.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_staff_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.7F);
            this.lbl_staff_id.Location = new System.Drawing.Point(0, 0);
            this.lbl_staff_id.Name = "lbl_staff_id";
            this.lbl_staff_id.Size = new System.Drawing.Size(135, 43);
            this.lbl_staff_id.TabIndex = 4;
            this.lbl_staff_id.Text = "Staff_ID";
            this.lbl_staff_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaleHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_history_parent);
            this.Controls.Add(this.lbl_sale_history);
            this.Name = "SaleHistory";
            this.Size = new System.Drawing.Size(807, 830);
            this.pnl_history_parent.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_sale_history;
        private System.Windows.Forms.Panel pnl_history_parent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_contents;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_staff_id;
        private System.Windows.Forms.Panel pnl_history_main;
        private System.Windows.Forms.Label lbl_time;
    }
}
