namespace course1._0.Application_Data.Functional
{
    partial class Notification_registration_form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_Date = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_Time = new System.Windows.Forms.ToolStripStatusLabel();
            this.label_notifer_message = new System.Windows.Forms.Label();
            this.label_notifer_date = new System.Windows.Forms.Label();
            this.label_notifer_context = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.label_notifer_message);
            this.panel1.Controls.Add(this.label_notifer_date);
            this.panel1.Controls.Add(this.label_notifer_context);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 149);
            this.panel1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_Date,
            this.toolStripStatusLabel_Time});
            this.statusStrip1.Location = new System.Drawing.Point(0, 124);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(426, 25);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_Date
            // 
            this.toolStripStatusLabel_Date.Name = "toolStripStatusLabel_Date";
            this.toolStripStatusLabel_Date.Size = new System.Drawing.Size(52, 20);
            this.toolStripStatusLabel_Date.Text = "Дата: ";
            // 
            // toolStripStatusLabel_Time
            // 
            this.toolStripStatusLabel_Time.Name = "toolStripStatusLabel_Time";
            this.toolStripStatusLabel_Time.Size = new System.Drawing.Size(61, 20);
            this.toolStripStatusLabel_Time.Text = "Время:";
            // 
            // label_notifer_message
            // 
            this.label_notifer_message.AutoSize = true;
            this.label_notifer_message.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_notifer_message.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_notifer_message.Location = new System.Drawing.Point(3, 8);
            this.label_notifer_message.Name = "label_notifer_message";
            this.label_notifer_message.Size = new System.Drawing.Size(87, 19);
            this.label_notifer_message.TabIndex = 2;
            this.label_notifer_message.Text = "Сообщение:";
            // 
            // label_notifer_date
            // 
            this.label_notifer_date.AutoSize = true;
            this.label_notifer_date.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_notifer_date.Location = new System.Drawing.Point(294, 119);
            this.label_notifer_date.Name = "label_notifer_date";
            this.label_notifer_date.Size = new System.Drawing.Size(42, 19);
            this.label_notifer_date.TabIndex = 1;
            this.label_notifer_date.Text = "Дата:";
            // 
            // label_notifer_context
            // 
            this.label_notifer_context.AutoSize = true;
            this.label_notifer_context.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_notifer_context.Location = new System.Drawing.Point(20, 61);
            this.label_notifer_context.Name = "label_notifer_context";
            this.label_notifer_context.Size = new System.Drawing.Size(0, 35);
            this.label_notifer_context.TabIndex = 0;
            // 
            // Notification_registration_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 148);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Notification_registration_form";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Уведомление";
            this.Load += new System.EventHandler(this.Notification_registration_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Date;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Time;
        private System.Windows.Forms.Label label_notifer_message;
        private System.Windows.Forms.Label label_notifer_date;
        private System.Windows.Forms.Label label_notifer_context;
    }
}