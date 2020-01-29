namespace course1._0.Forms
{
    partial class Inform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inform));
            this.label4 = new System.Windows.Forms.Label();
            this.button_add_new_KL = new System.Windows.Forms.Button();
            this.button_save_inform_KL = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.text_rec = new System.Windows.Forms.TextBox();
            this.text_adres = new System.Windows.Forms.TextBox();
            this.text_fio = new System.Windows.Forms.TextBox();
            this.pic_client = new System.Windows.Forms.PictureBox();
            this.pictureBox_img_KL = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_KL = new System.Windows.Forms.TextBox();
            this.grid_KL_DOG = new System.Windows.Forms.DataGridView();
            this.radio_Visible_Dog_grid = new System.Windows.Forms.RadioButton();
            this.radioButton_not_visible_grid = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_client)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_img_KL)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_KL_DOG)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 25F);
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(93, 1);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(559, 46);
            this.label4.TabIndex = 14;
            this.label4.Text = "Подробная информация о клиенте:\r\n";
            // 
            // button_add_new_KL
            // 
            this.button_add_new_KL.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_add_new_KL.FlatAppearance.BorderSize = 2;
            this.button_add_new_KL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add_new_KL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_add_new_KL.Location = new System.Drawing.Point(533, 280);
            this.button_add_new_KL.Margin = new System.Windows.Forms.Padding(2);
            this.button_add_new_KL.Name = "button_add_new_KL";
            this.button_add_new_KL.Size = new System.Drawing.Size(138, 52);
            this.button_add_new_KL.TabIndex = 12;
            this.button_add_new_KL.Text = "Добавить нового клиента";
            this.button_add_new_KL.UseVisualStyleBackColor = true;
            this.button_add_new_KL.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_save_inform_KL
            // 
            this.button_save_inform_KL.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_save_inform_KL.FlatAppearance.BorderSize = 2;
            this.button_save_inform_KL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save_inform_KL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_save_inform_KL.Location = new System.Drawing.Point(392, 280);
            this.button_save_inform_KL.Margin = new System.Windows.Forms.Padding(2);
            this.button_save_inform_KL.Name = "button_save_inform_KL";
            this.button_save_inform_KL.Size = new System.Drawing.Size(136, 52);
            this.button_save_inform_KL.TabIndex = 13;
            this.button_save_inform_KL.Text = "Сохранить измнения";
            this.button_save_inform_KL.UseVisualStyleBackColor = true;
            this.button_save_inform_KL.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.label3.Location = new System.Drawing.Point(405, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Номер счета карты:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.label2.Location = new System.Drawing.Point(405, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Адрес:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.label1.Location = new System.Drawing.Point(408, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "ФИО";
            // 
            // text_rec
            // 
            this.text_rec.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.text_rec.Location = new System.Drawing.Point(409, 227);
            this.text_rec.Name = "text_rec";
            this.text_rec.Size = new System.Drawing.Size(239, 27);
            this.text_rec.TabIndex = 6;
            // 
            // text_adres
            // 
            this.text_adres.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.text_adres.Location = new System.Drawing.Point(409, 166);
            this.text_adres.Name = "text_adres";
            this.text_adres.Size = new System.Drawing.Size(239, 27);
            this.text_adres.TabIndex = 7;
            // 
            // text_fio
            // 
            this.text_fio.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.text_fio.Location = new System.Drawing.Point(409, 117);
            this.text_fio.Name = "text_fio";
            this.text_fio.Size = new System.Drawing.Size(239, 27);
            this.text_fio.TabIndex = 8;
            // 
            // pic_client
            // 
            this.pic_client.Location = new System.Drawing.Point(91, 63);
            this.pic_client.Name = "pic_client";
            this.pic_client.Size = new System.Drawing.Size(283, 298);
            this.pic_client.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_client.TabIndex = 5;
            this.pic_client.TabStop = false;
            this.pic_client.DoubleClick += new System.EventHandler(this.pic_client_DoubleClick);
            // 
            // pictureBox_img_KL
            // 
            this.pictureBox_img_KL.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_img_KL.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_img_KL.Image")));
            this.pictureBox_img_KL.Location = new System.Drawing.Point(3, 122);
            this.pictureBox_img_KL.Name = "pictureBox_img_KL";
            this.pictureBox_img_KL.Size = new System.Drawing.Size(76, 56);
            this.pictureBox_img_KL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_img_KL.TabIndex = 5;
            this.pictureBox_img_KL.TabStop = false;
            this.pictureBox_img_KL.DoubleClick += new System.EventHandler(this.pic_client_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 54);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.pictureBox_img_KL);
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(82, 345);
            this.panel2.TabIndex = 16;
            // 
            // textBox_KL
            // 
            this.textBox_KL.BackColor = System.Drawing.Color.White;
            this.textBox_KL.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_KL.Location = new System.Drawing.Point(631, 63);
            this.textBox_KL.Name = "textBox_KL";
            this.textBox_KL.ReadOnly = true;
            this.textBox_KL.Size = new System.Drawing.Size(51, 25);
            this.textBox_KL.TabIndex = 18;
            // 
            // grid_KL_DOG
            // 
            this.grid_KL_DOG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_KL_DOG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_KL_DOG.Location = new System.Drawing.Point(1, 397);
            this.grid_KL_DOG.Name = "grid_KL_DOG";
            this.grid_KL_DOG.RowTemplate.Height = 24;
            this.grid_KL_DOG.Size = new System.Drawing.Size(691, 99);
            this.grid_KL_DOG.TabIndex = 19;
            // 
            // radio_Visible_Dog_grid
            // 
            this.radio_Visible_Dog_grid.AutoSize = true;
            this.radio_Visible_Dog_grid.Font = new System.Drawing.Font("Segoe UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radio_Visible_Dog_grid.Location = new System.Drawing.Point(148, 366);
            this.radio_Visible_Dog_grid.Name = "radio_Visible_Dog_grid";
            this.radio_Visible_Dog_grid.Size = new System.Drawing.Size(205, 24);
            this.radio_Visible_Dog_grid.TabIndex = 20;
            this.radio_Visible_Dog_grid.TabStop = true;
            this.radio_Visible_Dog_grid.Text = "Показать договора клиента";
            this.radio_Visible_Dog_grid.UseVisualStyleBackColor = true;
            this.radio_Visible_Dog_grid.CheckedChanged += new System.EventHandler(this.Radio_Visible_Dog_grid_CheckedChanged);
            // 
            // radioButton_not_visible_grid
            // 
            this.radioButton_not_visible_grid.AutoSize = true;
            this.radioButton_not_visible_grid.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.radioButton_not_visible_grid.Location = new System.Drawing.Point(455, 366);
            this.radioButton_not_visible_grid.Name = "radioButton_not_visible_grid";
            this.radioButton_not_visible_grid.Size = new System.Drawing.Size(193, 24);
            this.radioButton_not_visible_grid.TabIndex = 21;
            this.radioButton_not_visible_grid.TabStop = true;
            this.radioButton_not_visible_grid.Text = "Скрыть договора клиента";
            this.radioButton_not_visible_grid.UseVisualStyleBackColor = true;
            this.radioButton_not_visible_grid.CheckedChanged += new System.EventHandler(this.RadioButton_not_visible_grid_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.label5.Location = new System.Drawing.Point(602, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "ID";
            // 
            // Inform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(694, 498);
            this.Controls.Add(this.radioButton_not_visible_grid);
            this.Controls.Add(this.radio_Visible_Dog_grid);
            this.Controls.Add(this.grid_KL_DOG);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_add_new_KL);
            this.Controls.Add(this.button_save_inform_KL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_rec);
            this.Controls.Add(this.text_adres);
            this.Controls.Add(this.text_fio);
            this.Controls.Add(this.pic_client);
            this.Controls.Add(this.textBox_KL);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Inform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация о клиенте";
            this.Load += new System.EventHandler(this.Inform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_client)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_img_KL)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_KL_DOG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_add_new_KL;
        private System.Windows.Forms.Button button_save_inform_KL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_rec;
        private System.Windows.Forms.TextBox text_adres;
        private System.Windows.Forms.TextBox text_fio;
        private System.Windows.Forms.PictureBox pic_client;
        private System.Windows.Forms.PictureBox pictureBox_img_KL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_KL;
        private System.Windows.Forms.DataGridView grid_KL_DOG;
        private System.Windows.Forms.RadioButton radio_Visible_Dog_grid;
        private System.Windows.Forms.RadioButton radioButton_not_visible_grid;
        private System.Windows.Forms.Label label5;
    }
}