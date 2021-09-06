
namespace POS
{
    partial class POS
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
            this.pnl_main = new System.Windows.Forms.Panel();
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.btn_sale_history = new System.Windows.Forms.Button();
            this.btn_new_sale = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.pnl_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_main
            // 
            this.pnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_main.Location = new System.Drawing.Point(840, 12);
            this.pnl_main.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(815, 830);
            this.pnl_main.TabIndex = 0;
            // 
            // pnl_menu
            // 
            this.pnl_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_menu.Controls.Add(this.btn_exit);
            this.pnl_menu.Controls.Add(this.btn_sale_history);
            this.pnl_menu.Controls.Add(this.btn_new_sale);
            this.pnl_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_menu.Location = new System.Drawing.Point(13, 12);
            this.pnl_menu.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(827, 830);
            this.pnl_menu.TabIndex = 1;
            // 
            // btn_sale_history
            // 
            this.btn_sale_history.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_sale_history.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sale_history.Location = new System.Drawing.Point(0, 102);
            this.btn_sale_history.Name = "btn_sale_history";
            this.btn_sale_history.Size = new System.Drawing.Size(827, 106);
            this.btn_sale_history.TabIndex = 1;
            this.btn_sale_history.Text = "Sale History";
            this.btn_sale_history.UseVisualStyleBackColor = true;
            this.btn_sale_history.Click += new System.EventHandler(this.btn_sale_history_Click);
            // 
            // btn_new_sale
            // 
            this.btn_new_sale.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_new_sale.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new_sale.Location = new System.Drawing.Point(0, 0);
            this.btn_new_sale.Name = "btn_new_sale";
            this.btn_new_sale.Size = new System.Drawing.Size(827, 102);
            this.btn_new_sale.TabIndex = 0;
            this.btn_new_sale.Text = "Sale";
            this.btn_new_sale.UseVisualStyleBackColor = true;
            this.btn_new_sale.Click += new System.EventHandler(this.btn_new_sale_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(0, 724);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(827, 106);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1668, 854);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.pnl_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "POS";
            this.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.Text = "POS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnl_menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_menu;
        public System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Button btn_sale_history;
        private System.Windows.Forms.Button btn_new_sale;
        private System.Windows.Forms.Button btn_exit;
    }
}

