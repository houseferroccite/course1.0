namespace course1._0.Forms
{
    partial class Add_user
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_user));
            this.label3 = new System.Windows.Forms.Label();
            this.text_Add_password = new System.Windows.Forms.TextBox();
            this.text_Add_login = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_add_user = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.check_see_password = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(185, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(488, 46);
            this.label3.TabIndex = 9;
            this.label3.Text = "Добавление нового сотрудника\r\n";
            // 
            // text_Add_password
            // 
            this.text_Add_password.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.text_Add_password.Location = new System.Drawing.Point(357, 298);
            this.text_Add_password.Name = "text_Add_password";
            this.text_Add_password.Size = new System.Drawing.Size(480, 32);
            this.text_Add_password.TabIndex = 7;
            this.text_Add_password.UseSystemPasswordChar = true;
            // 
            // text_Add_login
            // 
            this.text_Add_login.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.text_Add_login.Location = new System.Drawing.Point(357, 200);
            this.text_Add_login.Name = "text_Add_login";
            this.text_Add_login.Size = new System.Drawing.Size(480, 32);
            this.text_Add_login.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 11F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(354, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Придумайте пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(352, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Введите логин";
            // 
            // button_add_user
            // 
            this.button_add_user.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add_user.Location = new System.Drawing.Point(311, 389);
            this.button_add_user.Name = "button_add_user";
            this.button_add_user.Size = new System.Drawing.Size(549, 62);
            this.button_add_user.TabIndex = 4;
            this.button_add_user.Text = "Добавить";
            this.button_add_user.UseVisualStyleBackColor = true;
            this.button_add_user.Click += new System.EventHandler(this.button_add_user_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(858, 100);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(1, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(312, 351);
            this.panel2.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(70, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // check_see_password
            // 
            this.check_see_password.BackColor = System.Drawing.Color.Transparent;
            this.check_see_password.ForeColor = System.Drawing.Color.Black;
            this.check_see_password.Location = new System.Drawing.Point(693, 302);
            this.check_see_password.Name = "check_see_password";
            this.check_see_password.Size = new System.Drawing.Size(139, 25);
            this.check_see_password.TabIndex = 12;
            this.check_see_password.Text = "Показать пароль";
            this.check_see_password.UseVisualStyleBackColor = false;
            this.check_see_password.CheckedChanged += new System.EventHandler(this.Check_see_password_CheckedChanged);
            // 
            // Add_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 451);
            this.Controls.Add(this.check_see_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.text_Add_password);
            this.Controls.Add(this.text_Add_login);
            this.Controls.Add(this.button_add_user);
            this.MaximizeBox = false;
            this.Name = "Add_user";
            this.Text = "Форма добавления пользователя";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_Add_password;
        private System.Windows.Forms.TextBox text_Add_login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_add_user;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox check_see_password;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}