namespace course1._0.Application_Data.Form_s_for_acces_rights
{
    partial class Office
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.text_i = new System.Windows.Forms.TextBox();
            this.text_j = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gggg = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gggg)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(643, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Записать дату";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 31);
            this.button2.TabIndex = 1;
            this.button2.Text = "Посмотреть клиентов";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // text_i
            // 
            this.text_i.Location = new System.Drawing.Point(688, 9);
            this.text_i.Name = "text_i";
            this.text_i.Size = new System.Drawing.Size(100, 25);
            this.text_i.TabIndex = 2;
            // 
            // text_j
            // 
            this.text_j.Location = new System.Drawing.Point(688, 68);
            this.text_j.Name = "text_j";
            this.text_j.Size = new System.Drawing.Size(100, 25);
            this.text_j.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(639, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "i =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(639, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "j =";
            // 
            // gggg
            // 
            this.gggg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gggg.Location = new System.Drawing.Point(12, 49);
            this.gggg.Name = "gggg";
            this.gggg.RowHeadersWidth = 51;
            this.gggg.RowTemplate.Height = 27;
            this.gggg.Size = new System.Drawing.Size(400, 170);
            this.gggg.TabIndex = 4;
            // 
            // Office
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gggg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_j);
            this.Controls.Add(this.text_i);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Office";
            this.Text = "Office";
            this.Load += new System.EventHandler(this.Office_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gggg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox text_i;
        private System.Windows.Forms.TextBox text_j;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gggg;
    }
}