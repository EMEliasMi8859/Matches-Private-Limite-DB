namespace MatchesFirmDataBase
{
    partial class Main_GUI
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
            System.Windows.Forms.DataVisualization.Charting.LineAnnotation lineAnnotation1 = new System.Windows.Forms.DataVisualization.Charting.LineAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.LineAnnotation lineAnnotation2 = new System.Windows.Forms.DataVisualization.Charting.LineAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_GUI));
            this.Main_TabController = new System.Windows.Forms.TabControl();
            this.Statistics = new System.Windows.Forms.TabPage();
            this.StatisticsTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.Stocks = new System.Windows.Forms.TabPage();
            this.Sales = new System.Windows.Forms.TabPage();
            this.Purchases = new System.Windows.Forms.TabPage();
            this.Settings = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Main_TabController.SuspendLayout();
            this.Statistics.SuspendLayout();
            this.StatisticsTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // Main_TabController
            // 
            this.Main_TabController.Controls.Add(this.Statistics);
            this.Main_TabController.Controls.Add(this.Stocks);
            this.Main_TabController.Controls.Add(this.Sales);
            this.Main_TabController.Controls.Add(this.Purchases);
            this.Main_TabController.Controls.Add(this.Settings);
            this.Main_TabController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_TabController.Font = new System.Drawing.Font("Microsoft Tai Le", 11F);
            this.Main_TabController.ItemSize = new System.Drawing.Size(76, 26);
            this.Main_TabController.Location = new System.Drawing.Point(0, 0);
            this.Main_TabController.Name = "Main_TabController";
            this.Main_TabController.Padding = new System.Drawing.Point(16, 6);
            this.Main_TabController.SelectedIndex = 0;
            this.Main_TabController.Size = new System.Drawing.Size(1200, 627);
            this.Main_TabController.TabIndex = 1;
            // 
            // Statistics
            // 
            this.Statistics.Controls.Add(this.StatisticsTabs);
            this.Statistics.Location = new System.Drawing.Point(4, 30);
            this.Statistics.Name = "Statistics";
            this.Statistics.Padding = new System.Windows.Forms.Padding(3);
            this.Statistics.Size = new System.Drawing.Size(1192, 593);
            this.Statistics.TabIndex = 4;
            this.Statistics.Text = "Statistics";
            this.Statistics.UseVisualStyleBackColor = true;
            this.Statistics.Click += new System.EventHandler(this.Statistics_Click);
            // 
            // StatisticsTabs
            // 
            this.StatisticsTabs.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.StatisticsTabs.Controls.Add(this.tabPage1);
            this.StatisticsTabs.Controls.Add(this.tabPage2);
            this.StatisticsTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatisticsTabs.Location = new System.Drawing.Point(3, 3);
            this.StatisticsTabs.Name = "StatisticsTabs";
            this.StatisticsTabs.SelectedIndex = 0;
            this.StatisticsTabs.Size = new System.Drawing.Size(1186, 587);
            this.StatisticsTabs.TabIndex = 1;
            this.StatisticsTabs.SelectedIndexChanged += new System.EventHandler(this.StatisticsTabs_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1178, 555);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chart2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1178, 555);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(522, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // Stocks
            // 
            this.Stocks.Location = new System.Drawing.Point(4, 30);
            this.Stocks.Name = "Stocks";
            this.Stocks.Padding = new System.Windows.Forms.Padding(3);
            this.Stocks.Size = new System.Drawing.Size(1192, 593);
            this.Stocks.TabIndex = 5;
            this.Stocks.Text = "Stocks";
            this.Stocks.UseVisualStyleBackColor = true;
            // 
            // Sales
            // 
            this.Sales.Location = new System.Drawing.Point(4, 30);
            this.Sales.Name = "Sales";
            this.Sales.Padding = new System.Windows.Forms.Padding(3);
            this.Sales.Size = new System.Drawing.Size(1192, 593);
            this.Sales.TabIndex = 6;
            this.Sales.Text = "Sales";
            this.Sales.UseVisualStyleBackColor = true;
            // 
            // Purchases
            // 
            this.Purchases.Location = new System.Drawing.Point(4, 30);
            this.Purchases.Name = "Purchases";
            this.Purchases.Padding = new System.Windows.Forms.Padding(3);
            this.Purchases.Size = new System.Drawing.Size(1192, 593);
            this.Purchases.TabIndex = 7;
            this.Purchases.Text = "Purchases";
            this.Purchases.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.Settings.Location = new System.Drawing.Point(4, 30);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(3);
            this.Settings.Size = new System.Drawing.Size(1192, 593);
            this.Settings.TabIndex = 8;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            lineAnnotation1.Name = "LineAnnotation1";
            this.chart1.Annotations.Add(lineAnnotation1);
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(109, 87);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(675, 462);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.Name = "Products";
            this.chart1.Titles.Add(title1);
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // chart2
            // 
            lineAnnotation2.Name = "LineAnnotation1";
            this.chart2.Annotations.Add(lineAnnotation2);
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(252, 46);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series2";
            this.chart2.Series.Add(series3);
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(675, 462);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            title2.Name = "Products";
            this.chart2.Titles.Add(title2);
            // 
            // Main_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1200, 627);
            this.Controls.Add(this.Main_TabController);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1216, 666);
            this.Name = "Main_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Name Private Limited";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.Main_GUI_Resize);
            this.Main_TabController.ResumeLayout(false);
            this.Statistics.ResumeLayout(false);
            this.StatisticsTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Main_TabController;
        private System.Windows.Forms.TabPage Statistics;
        private System.Windows.Forms.TabPage Stocks;
        private System.Windows.Forms.TabPage Sales;
        private System.Windows.Forms.TabPage Purchases;
        private System.Windows.Forms.TabPage Settings;
        private System.Windows.Forms.TabControl StatisticsTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}

