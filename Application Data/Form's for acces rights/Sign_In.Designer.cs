namespace course1._0
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_login = new System.Windows.Forms.ComboBox();
            this.text_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel_Registration = new System.Windows.Forms.LinkLabel();
            this.linkLabel_Help_in_signing = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(12, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(289, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Войти";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.label1.Location = new System.Drawing.Point(7, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите пользователя";
            // 
            // combo_login
            // 
            this.combo_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_login.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.combo_login.FormattingEnabled = true;
            this.combo_login.Location = new System.Drawing.Point(12, 216);
            this.combo_login.Name = "combo_login";
            this.combo_login.Size = new System.Drawing.Size(289, 33);
            this.combo_login.TabIndex = 2;
            // 
            // text_password
            // 
            this.text_password.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.text_password.Location = new System.Drawing.Point(12, 289);
            this.text_password.Name = "text_password";
            this.text_password.Size = new System.Drawing.Size(289, 32);
            this.text_password.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.label2.Location = new System.Drawing.Point(9, 270);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите пароль";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel_Registration
            // 
            this.linkLabel_Registration.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.linkLabel_Registration.AutoSize = true;
            this.linkLabel_Registration.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel_Registration.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_Registration.ForeColor = System.Drawing.SystemColors.ControlText;
            this.linkLabel_Registration.LinkArea = new System.Windows.Forms.LinkArea(10, 0);
            this.linkLabel_Registration.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel_Registration.Location = new System.Drawing.Point(108, 515);
            this.linkLabel_Registration.Name = "linkLabel_Registration";
            this.linkLabel_Registration.Size = new System.Drawing.Size(89, 23);
            this.linkLabel_Registration.TabIndex = 5;
            this.linkLabel_Registration.Text = "Регистрация";
            this.linkLabel_Registration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel_Registration.UseCompatibleTextRendering = true;
            this.linkLabel_Registration.Click += new System.EventHandler(this.LinkLabel_Registration_Click);
            // 
            // linkLabel_Help_in_signing
            // 
            this.linkLabel_Help_in_signing.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.linkLabel_Help_in_signing.AutoSize = true;
            this.linkLabel_Help_in_signing.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel_Help_in_signing.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_Help_in_signing.ForeColor = System.Drawing.SystemColors.ControlText;
            this.linkLabel_Help_in_signing.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkLabel_Help_in_signing.LinkArea = new System.Windows.Forms.LinkArea(10, 0);
            this.linkLabel_Help_in_signing.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel_Help_in_signing.Location = new System.Drawing.Point(94, 551);
            this.linkLabel_Help_in_signing.Name = "linkLabel_Help_in_signing";
            this.linkLabel_Help_in_signing.Size = new System.Drawing.Size(131, 23);
            this.linkLabel_Help_in_signing.TabIndex = 5;
            this.linkLabel_Help_in_signing.Text = "Не удается войти ?";
            this.linkLabel_Help_in_signing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel_Help_in_signing.UseCompatibleTextRendering = true;
            this.linkLabel_Help_in_signing.Click += new System.EventHandler(this.LinkLabel_Help_in_signing_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(313, 583);
            this.Controls.Add(this.linkLabel_Help_in_signing);
            this.Controls.Add(this.linkLabel_Registration);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.text_password);
            this.Controls.Add(this.combo_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_login;
        private System.Windows.Forms.TextBox text_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel_Registration;
        private System.Windows.Forms.LinkLabel linkLabel_Help_in_signing;
    }
}

