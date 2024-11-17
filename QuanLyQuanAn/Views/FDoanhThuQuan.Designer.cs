namespace QuanLyQuanAn.Components
{
    partial class FDoanhThuQuan
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDoanhThuQuan));
            this.chartDTQuan = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pieDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.chartDTQuan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieDoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartDTQuan
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDTQuan.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDTQuan.Legends.Add(legend1);
            this.chartDTQuan.Location = new System.Drawing.Point(23, 122);
            this.chartDTQuan.Name = "chartDTQuan";
            this.chartDTQuan.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Food";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Soup";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Drink";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Dessert";
            this.chartDTQuan.Series.Add(series1);
            this.chartDTQuan.Series.Add(series2);
            this.chartDTQuan.Series.Add(series3);
            this.chartDTQuan.Series.Add(series4);
            this.chartDTQuan.Size = new System.Drawing.Size(871, 488);
            this.chartDTQuan.TabIndex = 0;
            this.chartDTQuan.Text = "chart1";
            // 
            // pieDoanhThu
            // 
            this.pieDoanhThu.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.pieDoanhThu.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.pieDoanhThu.Legends.Add(legend2);
            this.pieDoanhThu.Location = new System.Drawing.Point(873, 33);
            this.pieDoanhThu.Name = "pieDoanhThu";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series5.Legend = "Legend1";
            series5.Name = "DoanhThu";
            this.pieDoanhThu.Series.Add(series5);
            this.pieDoanhThu.Size = new System.Drawing.Size(325, 302);
            this.pieDoanhThu.TabIndex = 1;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("SF Mono", 18.33962F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(98)))), ((int)(((byte)(20)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(79, 33);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(105, 35);
            this.guna2HtmlLabel1.TabIndex = 20;
            this.guna2HtmlLabel1.Text = "Dainji ";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.ErrorImage = null;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.guna2PictureBox1.Location = new System.Drawing.Point(23, 20);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(50, 51);
            this.guna2PictureBox1.TabIndex = 19;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Times New Roman", 19.69811F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(267, 616);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(299, 34);
            this.guna2HtmlLabel2.TabIndex = 21;
            this.guna2HtmlLabel2.Text = "Doanh thu của các quán";
            // 
            // FDoanhThuQuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1210, 744);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.pieDoanhThu);
            this.Controls.Add(this.chartDTQuan);
            this.Name = "FDoanhThuQuan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doanh Thu Quán";
            this.Load += new System.EventHandler(this.FDoanhThuQuan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartDTQuan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieDoanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartDTQuan;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieDoanhThu;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
    }
}