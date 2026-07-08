namespace DVLD.Analytics.Dashboard.Controls {
    partial class CtrlChart_RevenueByTestType {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                DVLD.Properties.Settings.Default.SettingsSaving -= Default_SettingsSaving;
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlChart_RevenueByTestType));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.StripLine stripLine1 = new System.Windows.Forms.DataVisualization.Charting.StripLine();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.lbl_chartIsDisabled = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.num_year = new System.Windows.Forms.NumericUpDown();
            this.btn_export = new System.Windows.Forms.Button();
            this.pb_help = new System.Windows.Forms.PictureBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.rb_totalRevenue = new System.Windows.Forms.RadioButton();
            this.rb_revenueComposition = new System.Windows.Forms.RadioButton();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.helpToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.normalToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.num_year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_help)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_chartIsDisabled
            // 
            resources.ApplyResources(this.lbl_chartIsDisabled, "lbl_chartIsDisabled");
            this.lbl_chartIsDisabled.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lbl_chartIsDisabled.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.lbl_chartIsDisabled.Name = "lbl_chartIsDisabled";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // num_year
            // 
            resources.ApplyResources(this.num_year, "num_year");
            this.num_year.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.num_year.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.num_year.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.num_year.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.num_year.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.num_year.Name = "num_year";
            this.num_year.ReadOnly = true;
            this.num_year.Value = new decimal(new int[] {
            2026,
            0,
            0,
            0});
            this.num_year.ValueChanged += new System.EventHandler(this.num_year_ValueChanged);
            this.num_year.Enter += new System.EventHandler(this.num_year_Enter);
            // 
            // btn_export
            // 
            this.btn_export.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_export, "btn_export");
            this.btn_export.Image = global::DVLD.Properties.Resources.Export_24;
            this.btn_export.Name = "btn_export";
            this.normalToolTip.SetToolTip(this.btn_export, resources.GetString("btn_export.ToolTip"));
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // pb_help
            // 
            this.pb_help.Cursor = System.Windows.Forms.Cursors.Help;
            this.pb_help.Image = global::DVLD.Properties.Resources.Help_24;
            resources.ApplyResources(this.pb_help, "pb_help");
            this.pb_help.Name = "pb_help";
            this.pb_help.TabStop = false;
            this.helpToolTip.SetToolTip(this.pb_help, resources.GetString("pb_help.ToolTip"));
            // 
            // btn_refresh
            // 
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_refresh, "btn_refresh");
            this.btn_refresh.Image = global::DVLD.Properties.Resources.Reload_24;
            this.btn_refresh.Name = "btn_refresh";
            this.normalToolTip.SetToolTip(this.btn_refresh, resources.GetString("btn_refresh.ToolTip"));
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // rb_totalRevenue
            // 
            resources.ApplyResources(this.rb_totalRevenue, "rb_totalRevenue");
            this.rb_totalRevenue.Name = "rb_totalRevenue";
            this.rb_totalRevenue.UseVisualStyleBackColor = true;
            this.rb_totalRevenue.CheckedChanged += new System.EventHandler(this.rb_totalRevenue_CheckedChanged);
            // 
            // rb_revenueComposition
            // 
            resources.ApplyResources(this.rb_revenueComposition, "rb_revenueComposition");
            this.rb_revenueComposition.Checked = true;
            this.rb_revenueComposition.Name = "rb_revenueComposition";
            this.rb_revenueComposition.TabStop = true;
            this.rb_revenueComposition.UseVisualStyleBackColor = true;
            this.rb_revenueComposition.CheckedChanged += new System.EventHandler(this.rb_revenueComposition_CheckedChanged);
            // 
            // chart1
            // 
            resources.ApplyResources(this.chart1, "chart1");
            this.chart1.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.chart1.BorderlineColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.LabelStyle.Angle = -30;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            chartArea1.AxisX.LabelStyle.Interval = 1D;
            chartArea1.AxisX.LabelStyle.IntervalOffset = 0D;
            chartArea1.AxisX.MajorGrid.Interval = 1D;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            stripLine1.BackColor = System.Drawing.Color.Gainsboro;
            stripLine1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
            stripLine1.BackSecondaryColor = System.Drawing.Color.White;
            stripLine1.BorderColor = System.Drawing.Color.Silver;
            stripLine1.IntervalOffset = -1D;
            stripLine1.StripWidth = 1D;
            chartArea1.AxisX.StripLines.Add(stripLine1);
            chartArea1.AxisX.Title = "Months";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Segoe UI", 9F);
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.LabelStyle.Format = "${N0}";
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.MinorGrid.Enabled = true;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY.MinorTickMark.Enabled = true;
            chartArea1.AxisY.MinorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.Title = "Revenue";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Segoe UI", 9F);
            chartArea1.AxisY2.IsLabelAutoFit = false;
            chartArea1.AxisY2.LabelStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY2.MinorGrid.Enabled = true;
            chartArea1.AxisY2.MinorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY2.MinorTickMark.Enabled = true;
            chartArea1.AxisY2.MinorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY2.Title = "Average Attempts";
            chartArea1.AxisY2.TitleFont = new System.Drawing.Font("Segoe UI", 9F);
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 52F;
            chartArea1.Position.Width = 92F;
            chartArea1.Position.X = 3F;
            chartArea1.Position.Y = 10.58358F;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.Title = "Test Result";
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Segoe UI", 9F);
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisY.Title = "Total Tests";
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Segoe UI", 9F);
            chartArea2.AxisY2.IsLabelAutoFit = false;
            chartArea2.AxisY2.LabelStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            chartArea2.AxisY2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            chartArea2.AxisY2.MajorGrid.Enabled = false;
            chartArea2.AxisY2.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            chartArea2.Name = "ChartArea2";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 28F;
            chartArea2.Position.Width = 45F;
            chartArea2.Position.X = 8F;
            chartArea2.Position.Y = 64F;
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.DataBindings.Add(new System.Windows.Forms.Binding("BorderlineColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chart1.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            legend1.BackColor = System.Drawing.Color.WhiteSmoke;
            legend1.BorderColor = System.Drawing.Color.Gainsboro;
            legend1.DockedToChartArea = "ChartArea2";
            legend1.Font = new System.Drawing.Font("Segoe UI", 8F);
            legend1.IsDockedInsideChartArea = false;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(10)))));
            series1.Legend = "Legend1";
            series1.LegendText = "Driving Tests";
            series1.Name = "drivingTests";
            series1.ToolTip = "[#LEGENDTEXT]\\n#VAL{C2} total revenue";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            series2.Legend = "Legend1";
            series2.LegendText = "Written Tests";
            series2.Name = "writtenTests";
            series2.ToolTip = "[#LEGENDTEXT]\\n#VAL{C2} total revenue";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series3.Legend = "Legend1";
            series3.LegendText = "Vision Tests";
            series3.Name = "visionTests";
            series3.ToolTip = "[#LEGENDTEXT]\\n#VAL{C2} total revenue";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series4.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
            series4.BackSecondaryColor = System.Drawing.Color.White;
            series4.BorderColor = System.Drawing.Color.Black;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(11)))), ((int)(((byte)(244)))));
            series4.Legend = "Legend1";
            series4.LegendText = "Total Revenue";
            series4.MarkerBorderWidth = 0;
            series4.MarkerColor = System.Drawing.Color.Black;
            series4.MarkerSize = 6;
            series4.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series4.Name = "perMonthTotalRevenue";
            series4.ToolTip = "#VAL{C2} grand total";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series5.ChartArea = "ChartArea2";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series5.IsVisibleInLegend = false;
            series5.Legend = "Legend1";
            series5.Name = "allTimeTotalRevenue";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            title1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Revenue By Test Type";
            title2.DockedToChartArea = "ChartArea2";
            title2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.IsDockedInsideChartArea = false;
            title2.Name = "Title2";
            title2.Text = "All Time";
            this.chart1.Titles.Add(title1);
            this.chart1.Titles.Add(title2);
            this.chart1.EnabledChanged += new System.EventHandler(this.chart1_EnabledChanged);
            // 
            // helpToolTip
            // 
            this.helpToolTip.IsBalloon = true;
            this.helpToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.helpToolTip.ToolTipTitle = "Help";
            // 
            // CtrlChart_RevenueByTestType
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.lbl_chartIsDisabled);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.num_year);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.pb_help);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.rb_revenueComposition);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.rb_totalRevenue);
            resources.ApplyResources(this, "$this");
            this.Name = "CtrlChart_RevenueByTestType";
            this.Load += new System.EventHandler(this.CtrlChart_RevenueByTestType_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CtrlChart_RevenueByTestType_Paint);
            this.Resize += new System.EventHandler(this.CtrlChart_RevenueByTestType_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.num_year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_help)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_chartIsDisabled;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num_year;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.ToolTip helpToolTip;
        private System.Windows.Forms.ToolTip normalToolTip;
        private System.Windows.Forms.PictureBox pb_help;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.RadioButton rb_totalRevenue;
        private System.Windows.Forms.RadioButton rb_revenueComposition;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
