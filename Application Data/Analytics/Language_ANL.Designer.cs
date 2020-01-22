namespace course1._0.Application_Data.Analytics
{
    partial class Language_ANL
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Diag_language = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Diag_language)).BeginInit();
            this.SuspendLayout();
            // 
            // Diag_language
            // 
            chartArea1.Name = "ChartArea1";
            this.Diag_language.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.TitleFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Diag_language.Legends.Add(legend1);
            this.Diag_language.Location = new System.Drawing.Point(161, 47);
            this.Diag_language.Name = "Diag_language";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Т_Языки_прог";
            this.Diag_language.Series.Add(series1);
            this.Diag_language.Size = new System.Drawing.Size(300, 300);
            this.Diag_language.TabIndex = 0;
            this.Diag_language.Text = "chart1";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(486, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Просчитать востребованность";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Language_ANL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Diag_language);
            this.MaximizeBox = false;
            this.Name = "Language_ANL";
            this.Text = "Language_ANL";
            ((System.ComponentModel.ISupportInitialize)(this.Diag_language)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Diag_language;
        private System.Windows.Forms.Button button1;
    }
}