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
            this.status_info = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pic_client)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_img_KL)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.status_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 25F);
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(195, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(698, 57);
            this.label4.TabIndex = 14;
            this.label4.Text = "Подробная информация о клиенте:\r\n";
            // 
            // button_add_new_KL
            // 
            this.button_add_new_KL.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_add_new_KL.FlatAppearance.BorderSize = 2;
            this.button_add_new_KL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add_new_KL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_add_new_KL.Location = new System.Drawing.Point(685, 416);
            this.button_add_new_KL.Name = "button_add_new_KL";
            this.button_add_new_KL.Size = new System.Drawing.Size(184, 49);
            this.button_add_new_KL.TabIndex = 12;
            this.button_add_new_KL.Text = "Добавть новую запись";
            this.button_add_new_KL.UseVisualStyleBackColor = true;
            this.button_add_new_KL.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_save_inform_KL
            // 
            this.button_save_inform_KL.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_save_inform_KL.FlatAppearance.BorderSize = 2;
            this.button_save_inform_KL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save_inform_KL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_save_inform_KL.Location = new System.Drawing.Point(497, 416);
            this.button_save_inform_KL.Name = "button_save_inform_KL";
            this.button_save_inform_KL.Size = new System.Drawing.Size(182, 49);
            this.button_save_inform_KL.TabIndex = 13;
            this.button_save_inform_KL.Text = "Сохранить измнение";
            this.button_save_inform_KL.UseVisualStyleBackColor = true;
            this.button_save_inform_KL.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.label3.Location = new System.Drawing.Point(492, 261);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Номер счета карты:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.label2.Location = new System.Drawing.Point(492, 182);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Адрес:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.label1.Location = new System.Drawing.Point(492, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "ФИО";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // text_rec
            // 
            this.text_rec.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.text_rec.Location = new System.Drawing.Point(497, 290);
            this.text_rec.Margin = new System.Windows.Forms.Padding(4);
            this.text_rec.Name = "text_rec";
            this.text_rec.Size = new System.Drawing.Size(372, 32);
            this.text_rec.TabIndex = 6;
            // 
            // text_adres
            // 
            this.text_adres.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.text_adres.Location = new System.Drawing.Point(497, 211);
            this.text_adres.Margin = new System.Windows.Forms.Padding(4);
            this.text_adres.Name = "text_adres";
            this.text_adres.Size = new System.Drawing.Size(372, 32);
            this.text_adres.TabIndex = 7;
            // 
            // text_fio
            // 
            this.text_fio.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.text_fio.Location = new System.Drawing.Point(497, 146);
            this.text_fio.Margin = new System.Windows.Forms.Padding(4);
            this.text_fio.Name = "text_fio";
            this.text_fio.Size = new System.Drawing.Size(372, 32);
            this.text_fio.TabIndex = 8;
            // 
            // pic_client
            // 
            this.pic_client.Location = new System.Drawing.Point(113, 90);
            this.pic_client.Margin = new System.Windows.Forms.Padding(4);
            this.pic_client.Name = "pic_client";
            this.pic_client.Size = new System.Drawing.Size(328, 375);
            this.pic_client.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_client.TabIndex = 5;
            this.pic_client.TabStop = false;
            this.pic_client.DoubleClick += new System.EventHandler(this.pic_client_DoubleClick);
            // 
            // pictureBox_img_KL
            // 
            this.pictureBox_img_KL.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_img_KL.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_img_KL.Image")));
            this.pictureBox_img_KL.Location = new System.Drawing.Point(4, 108);
            this.pictureBox_img_KL.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_img_KL.Name = "pictureBox_img_KL";
            this.pictureBox_img_KL.Size = new System.Drawing.Size(101, 73);
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(926, 70);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.pictureBox_img_KL);
            this.panel2.Location = new System.Drawing.Point(0, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(109, 399);
            this.panel2.TabIndex = 16;
            // 
            // status_info
            // 
            this.status_info.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.status_info.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.status_info.Location = new System.Drawing.Point(0, 469);
            this.status_info.Name = "status_info";
            this.status_info.Size = new System.Drawing.Size(926, 25);
            this.status_info.TabIndex = 17;
            this.status_info.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Inform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 494);
            this.Controls.Add(this.status_info);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_add_new_KL);
            this.Controls.Add(this.button_save_inform_KL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_rec);
            this.Controls.Add(this.text_adres);
            this.Controls.Add(this.text_fio);
            this.Controls.Add(this.pic_client);
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
            this.status_info.ResumeLayout(false);
            this.status_info.PerformLayout();
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
        private System.Windows.Forms.StatusStrip status_info;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}