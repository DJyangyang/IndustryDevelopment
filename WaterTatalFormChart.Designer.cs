namespace ChartMenuBar
{
    partial class WaterTatalFormChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart5 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart5)).BeginInit();
            this.SuspendLayout();
            // 
            // chart5
            // 
            chartArea5.AxisX.MajorGrid.Enabled = false;
            chartArea5.AxisY.MajorGrid.Enabled = false;
            chartArea5.Name = "ChartArea1";
            this.chart5.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart5.Legends.Add(legend5);
            this.chart5.Location = new System.Drawing.Point(-1, 4);
            this.chart5.Name = "chart5";
            series17.ChartArea = "ChartArea1";
            series17.Legend = "Legend1";
            series17.Name = "Series1";
            series18.ChartArea = "ChartArea1";
            series18.Legend = "Legend1";
            series18.Name = "Series2";
            series19.ChartArea = "ChartArea1";
            series19.Legend = "Legend1";
            series19.Name = "Series3";
            series20.ChartArea = "ChartArea1";
            series20.Legend = "Legend1";
            series20.Name = "Series4";
            series20.YValuesPerPoint = 2;
            this.chart5.Series.Add(series17);
            this.chart5.Series.Add(series18);
            this.chart5.Series.Add(series19);
            this.chart5.Series.Add(series20);
            this.chart5.Size = new System.Drawing.Size(798, 489);
            this.chart5.TabIndex = 0;
            this.chart5.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(553, 513);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "导出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(659, 513);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "关闭";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // WaterTatalFormChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 548);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart5);
            this.Name = "WaterTatalFormChart";
            this.Text = "WaterTatalFormChart";
            this.Load += new System.EventHandler(this.WaterTatalFormChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}