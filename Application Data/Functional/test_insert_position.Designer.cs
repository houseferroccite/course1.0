namespace course1._0.Forms
{
    partial class test_insert_position
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(test_insert_position));
            this.button_save = new System.Windows.Forms.Button();
            this.text_insert_posisiton = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Addnew = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_save
            // 
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.button_save.Location = new System.Drawing.Point(463, 246);
            this.button_save.Margin = new System.Windows.Forms.Padding(4);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(347, 66);
            this.button_save.TabIndex = 7;
            this.button_save.Text = "Сохранить";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // text_insert_posisiton
            // 
            this.text_insert_posisiton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.text_insert_posisiton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.text_insert_posisiton.Location = new System.Drawing.Point(213, 162);
            this.text_insert_posisiton.Margin = new System.Windows.Forms.Padding(4);
            this.text_insert_posisiton.Name = "text_insert_posisiton";
            this.text_insert_posisiton.Size = new System.Drawing.Size(525, 30);
            this.text_insert_posisiton.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(203, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Корректировка должностей";
            // 
            // button_Addnew
            // 
            this.button_Addnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Addnew.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.button_Addnew.Location = new System.Drawing.Point(155, 246);
            this.button_Addnew.Margin = new System.Windows.Forms.Padding(4);
            this.button_Addnew.Name = "button_Addnew";
            this.button_Addnew.Size = new System.Drawing.Size(305, 66);
            this.button_Addnew.TabIndex = 4;
            this.button_Addnew.Text = "Добавить запись";
            this.button_Addnew.UseVisualStyleBackColor = true;
            this.button_Addnew.Click += new System.EventHandler(this.button_Addnew_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.label2.Location = new System.Drawing.Point(207, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 35);
            this.label2.TabIndex = 8;
            this.label2.Text = "Поле для ввода:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 88);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(2, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(146, 248);
            this.panel2.TabIndex = 10;
            // 
            // test_insert_position
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 325);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.text_insert_posisiton);
            this.Controls.Add(this.button_Addnew);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "test_insert_position";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма корректировки должности вход через аккаунт - { Adm }";
            this.Load += new System.EventHandler(this.test_insert_position_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_save;
        public System.Windows.Forms.TextBox text_insert_posisiton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Addnew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}