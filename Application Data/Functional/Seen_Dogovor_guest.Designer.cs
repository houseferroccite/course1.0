namespace course1._0.Application_Data.Functional
{
    partial class Seen_Dogovor_guest
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.data_seen_guest = new System.Windows.Forms.DataGridView();
            this.combo_dog_zak = new System.Windows.Forms.ComboBox();
            this.тДоговораАрхивBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.myCreatePO_projectDataSet3 = new course1._0.myCreatePO_projectDataSet3();
            this.тДоговораАрхивBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myCreatePO_projectDataSet = new course1._0.myCreatePO_projectDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.т_Договора_АрхивTableAdapter = new course1._0.myCreatePO_projectDataSetTableAdapters.Т_Договора_АрхивTableAdapter();
            this.panel_decor_seen_dog_guest = new System.Windows.Forms.Panel();
            this.myCreatePO_projectDataSet2 = new course1._0.myCreatePO_projectDataSet2();
            this.тДоговораАрхивBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.т_Договора_АрхивTableAdapter1 = new course1._0.myCreatePO_projectDataSet2TableAdapters.Т_Договора_АрхивTableAdapter();
            this.т_Договора_АрхивTableAdapter2 = new course1._0.myCreatePO_projectDataSet3TableAdapters.Т_Договора_АрхивTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.data_seen_guest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.тДоговораАрхивBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCreatePO_projectDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.тДоговораАрхивBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCreatePO_projectDataSet)).BeginInit();
            this.panel_decor_seen_dog_guest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myCreatePO_projectDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.тДоговораАрхивBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(92, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(771, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Информация о ранее заключенных договорах";
            // 
            // data_seen_guest
            // 
            this.data_seen_guest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_seen_guest.Location = new System.Drawing.Point(1, 191);
            this.data_seen_guest.Name = "data_seen_guest";
            this.data_seen_guest.RowHeadersWidth = 51;
            this.data_seen_guest.RowTemplate.Height = 27;
            this.data_seen_guest.Size = new System.Drawing.Size(930, 186);
            this.data_seen_guest.TabIndex = 1;
            // 
            // combo_dog_zak
            // 
            this.combo_dog_zak.DataSource = this.тДоговораАрхивBindingSource2;
            this.combo_dog_zak.DisplayMember = "Название_договора";
            this.combo_dog_zak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_dog_zak.FormattingEnabled = true;
            this.combo_dog_zak.Location = new System.Drawing.Point(308, 147);
            this.combo_dog_zak.Name = "combo_dog_zak";
            this.combo_dog_zak.Size = new System.Drawing.Size(290, 25);
            this.combo_dog_zak.TabIndex = 3;
            this.combo_dog_zak.ValueMember = "№_Договора";
            // 
            // тДоговораАрхивBindingSource2
            // 
            this.тДоговораАрхивBindingSource2.DataMember = "Т_Договора Архив";
            this.тДоговораАрхивBindingSource2.DataSource = this.myCreatePO_projectDataSet3;
            // 
            // myCreatePO_projectDataSet3
            // 
            this.myCreatePO_projectDataSet3.DataSetName = "myCreatePO_projectDataSet3";
            this.myCreatePO_projectDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // тДоговораАрхивBindingSource
            // 
            this.тДоговораАрхивBindingSource.DataMember = "Т_Договора Архив";
            this.тДоговораАрхивBindingSource.DataSource = this.myCreatePO_projectDataSet;
            // 
            // myCreatePO_projectDataSet
            // 
            this.myCreatePO_projectDataSet.DataSetName = "myCreatePO_projectDataSet";
            this.myCreatePO_projectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(308, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 46);
            this.label2.TabIndex = 4;
            this.label2.Text = "Выберите интересующий договор \r\nв списке:";
            // 
            // т_Договора_АрхивTableAdapter
            // 
            this.т_Договора_АрхивTableAdapter.ClearBeforeFill = true;
            // 
            // panel_decor_seen_dog_guest
            // 
            this.panel_decor_seen_dog_guest.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel_decor_seen_dog_guest.Controls.Add(this.label1);
            this.panel_decor_seen_dog_guest.Location = new System.Drawing.Point(1, 0);
            this.panel_decor_seen_dog_guest.Name = "panel_decor_seen_dog_guest";
            this.panel_decor_seen_dog_guest.Size = new System.Drawing.Size(930, 84);
            this.panel_decor_seen_dog_guest.TabIndex = 5;
            // 
            // myCreatePO_projectDataSet2
            // 
            this.myCreatePO_projectDataSet2.DataSetName = "myCreatePO_projectDataSet2";
            this.myCreatePO_projectDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // тДоговораАрхивBindingSource1
            // 
            this.тДоговораАрхивBindingSource1.DataMember = "Т_Договора Архив";
            this.тДоговораАрхивBindingSource1.DataSource = this.myCreatePO_projectDataSet2;
            // 
            // т_Договора_АрхивTableAdapter1
            // 
            this.т_Договора_АрхивTableAdapter1.ClearBeforeFill = true;
            // 
            // т_Договора_АрхивTableAdapter2
            // 
            this.т_Договора_АрхивTableAdapter2.ClearBeforeFill = true;
            // 
            // Seen_Dogovor_guest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 377);
            this.Controls.Add(this.panel_decor_seen_dog_guest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combo_dog_zak);
            this.Controls.Add(this.data_seen_guest);
            this.MaximizeBox = false;
            this.Name = "Seen_Dogovor_guest";
            this.Text = "Информация ";
            this.Load += new System.EventHandler(this.Seen_Dogovor_guest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_seen_guest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.тДоговораАрхивBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCreatePO_projectDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.тДоговораАрхивBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCreatePO_projectDataSet)).EndInit();
            this.panel_decor_seen_dog_guest.ResumeLayout(false);
            this.panel_decor_seen_dog_guest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myCreatePO_projectDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.тДоговораАрхивBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView data_seen_guest;
        private System.Windows.Forms.ComboBox combo_dog_zak;
        private myCreatePO_projectDataSet myCreatePO_projectDataSet;
        private System.Windows.Forms.BindingSource тДоговораАрхивBindingSource;
        private myCreatePO_projectDataSetTableAdapters.Т_Договора_АрхивTableAdapter т_Договора_АрхивTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_decor_seen_dog_guest;
        private myCreatePO_projectDataSet2 myCreatePO_projectDataSet2;
        private System.Windows.Forms.BindingSource тДоговораАрхивBindingSource1;
        private myCreatePO_projectDataSet2TableAdapters.Т_Договора_АрхивTableAdapter т_Договора_АрхивTableAdapter1;
        private myCreatePO_projectDataSet3 myCreatePO_projectDataSet3;
        private System.Windows.Forms.BindingSource тДоговораАрхивBindingSource2;
        private myCreatePO_projectDataSet3TableAdapters.Т_Договора_АрхивTableAdapter т_Договора_АрхивTableAdapter2;
    }
}