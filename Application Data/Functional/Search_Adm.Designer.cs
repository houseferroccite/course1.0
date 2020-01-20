namespace course1._0.Application_Data.Functional
{
    partial class Search_Adm
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
            this.label1 = new System.Windows.Forms.Label();
            this.combo_objectSearch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_criterion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grid_search_adm = new System.Windows.Forms.DataGridView();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.grid_search_adm)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(14, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Объект\r\nпоиска\r\n";
            // 
            // combo_objectSearch
            // 
            this.combo_objectSearch.FormattingEnabled = true;
            this.combo_objectSearch.Location = new System.Drawing.Point(77, 82);
            this.combo_objectSearch.Name = "combo_objectSearch";
            this.combo_objectSearch.Size = new System.Drawing.Size(178, 25);
            this.combo_objectSearch.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(261, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "Критерий\r\nпоиска";
            // 
            // combo_criterion
            // 
            this.combo_criterion.FormattingEnabled = true;
            this.combo_criterion.Location = new System.Drawing.Point(341, 82);
            this.combo_criterion.Name = "combo_criterion";
            this.combo_criterion.Size = new System.Drawing.Size(184, 25);
            this.combo_criterion.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(540, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Поиск";
            // 
            // grid_search_adm
            // 
            this.grid_search_adm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_search_adm.GridColor = System.Drawing.SystemColors.Info;
            this.grid_search_adm.Location = new System.Drawing.Point(1, 131);
            this.grid_search_adm.Name = "grid_search_adm";
            this.grid_search_adm.RowTemplate.Height = 27;
            this.grid_search_adm.Size = new System.Drawing.Size(799, 319);
            this.grid_search_adm.TabIndex = 2;
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(591, 82);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(197, 25);
            this.textBox_search.TabIndex = 3;
            this.textBox_search.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 60);
            this.panel1.TabIndex = 4;
            // 
            // Search_Adm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.grid_search_adm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combo_criterion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combo_objectSearch);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Search_Adm";
            this.Text = "Search_Adm";
            ((System.ComponentModel.ISupportInitialize)(this.grid_search_adm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_objectSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_criterion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView grid_search_adm;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Panel panel1;
    }
}