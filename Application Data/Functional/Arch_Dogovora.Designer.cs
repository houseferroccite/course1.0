namespace course1._0.Application_Data.Functional
{
    partial class Arch_Dogovora
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
            this.button_seen_arch_ended = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.grid_Arch_Status = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Arch_Status)).BeginInit();
            this.SuspendLayout();
            // 
            // button_seen_arch_ended
            // 
            this.button_seen_arch_ended.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_seen_arch_ended.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_seen_arch_ended.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.button_seen_arch_ended.Location = new System.Drawing.Point(0, 276);
            this.button_seen_arch_ended.Name = "button_seen_arch_ended";
            this.button_seen_arch_ended.Size = new System.Drawing.Size(706, 95);
            this.button_seen_arch_ended.TabIndex = 1;
            this.button_seen_arch_ended.Text = "Открыть архив договоров";
            this.button_seen_arch_ended.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grid_Arch_Status);
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 173);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(706, 100);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(84, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(543, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Изменение статуса договора и сдача в архив";
            // 
            // grid_Arch_Status
            // 
            this.grid_Arch_Status.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Arch_Status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_Arch_Status.Location = new System.Drawing.Point(0, 0);
            this.grid_Arch_Status.Name = "grid_Arch_Status";
            this.grid_Arch_Status.RowTemplate.Height = 24;
            this.grid_Arch_Status.Size = new System.Drawing.Size(706, 173);
            this.grid_Arch_Status.TabIndex = 0;
            this.grid_Arch_Status.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Arch_Status_CellClick);
            // 
            // Arch_Dogovora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 373);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_seen_arch_ended);
            this.Name = "Arch_Dogovora";
            this.Text = "Подтверждение статуса и сдача в архив";
            this.Load += new System.EventHandler(this.Arch_Dogovora_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Arch_Status)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_seen_arch_ended;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grid_Arch_Status;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}