namespace course1._0.Application_Data.Form_s_for_acces_rights
{
    partial class Results_info
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
            this.flowLayoutPan_info = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPan_button = new System.Windows.Forms.TableLayoutPanel();
            this.button_exit = new System.Windows.Forms.Button();
            this.grid_for_all = new System.Windows.Forms.DataGridView();
            this.flowLayoutPan_info.SuspendLayout();
            this.tableLayoutPan_button.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_for_all)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPan_info
            // 
            this.flowLayoutPan_info.AutoSize = true;
            this.flowLayoutPan_info.Controls.Add(this.grid_for_all);
            this.flowLayoutPan_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPan_info.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPan_info.Name = "flowLayoutPan_info";
            this.flowLayoutPan_info.Size = new System.Drawing.Size(751, 263);
            this.flowLayoutPan_info.TabIndex = 0;
            this.flowLayoutPan_info.WrapContents = false;
            this.flowLayoutPan_info.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // tableLayoutPan_button
            // 
            this.tableLayoutPan_button.AutoSize = true;
            this.tableLayoutPan_button.ColumnCount = 1;
            this.tableLayoutPan_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPan_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPan_button.Controls.Add(this.button_exit, 0, 0);
            this.tableLayoutPan_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPan_button.Location = new System.Drawing.Point(0, 228);
            this.tableLayoutPan_button.Name = "tableLayoutPan_button";
            this.tableLayoutPan_button.RowCount = 1;
            this.tableLayoutPan_button.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPan_button.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPan_button.Size = new System.Drawing.Size(751, 35);
            this.tableLayoutPan_button.TabIndex = 1;
            // 
            // button_exit
            // 
            this.button_exit.AutoSize = true;
            this.button_exit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Location = new System.Drawing.Point(0, 4);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(751, 33);
            this.button_exit.TabIndex = 0;
            this.button_exit.Text = "Назад";
            this.button_exit.UseVisualStyleBackColor = true;
            // 
            // grid_for_all
            // 
            this.grid_for_all.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_for_all.Location = new System.Drawing.Point(3, 3);
            this.grid_for_all.Name = "grid_for_all";
            this.grid_for_all.RowHeadersWidth = 51;
            this.grid_for_all.RowTemplate.Height = 24;
            this.grid_for_all.Size = new System.Drawing.Size(748, 223);
            this.grid_for_all.TabIndex = 0;
            // 
            // Results_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 263);
            this.Controls.Add(this.tableLayoutPan_button);
            this.Controls.Add(this.flowLayoutPan_info);
            this.MaximumSize = new System.Drawing.Size(769, 310);
            this.MinimumSize = new System.Drawing.Size(769, 310);
            this.Name = "Results_info";
            this.Text = "Результат";
            this.Load += new System.EventHandler(this.Results_info_Load);
            this.flowLayoutPan_info.ResumeLayout(false);
            this.tableLayoutPan_button.ResumeLayout(false);
            this.tableLayoutPan_button.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_for_all)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPan_info;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPan_button;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.DataGridView grid_for_all;
    }
}