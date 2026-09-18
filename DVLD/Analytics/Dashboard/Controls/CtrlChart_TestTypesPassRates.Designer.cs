namespace DVLD.Analytics.Dashboard.Controls {
    partial class CtrlChart_TestTypesPassRates {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlChart_TestTypesPassRates));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.StripLine stripLine1 = new System.Windows.Forms.DataVisualization.Charting.StripLine();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.num_year = new System.Windows.Forms.NumericUpDown();
            this.pb_help = new System.Windows.Forms.PictureBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.helpToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btn_export = new System.Windows.Forms.Button();
            this.chk_visionTests = new System.Windows.Forms.CheckBox();
            this.chk_writtenTests = new System.Windows.Forms.CheckBox();
            this.chk_drivingTests = new System.Windows.Forms.CheckBox();
            this.chk_overallTotal = new System.Windows.Forms.CheckBox();
            this.lbl_noDataAvailable_perMonth = new System.Windows.Forms.Label();
            this.lbl_noDataAvailable_allTime = new System.Windows.Forms.Label();
            this.lbl_chartIsDisabled = new System.Windows.Forms.Label();
            this.rb_testPassRates = new System.Windows.Forms.RadioButton();
            this.rb_avgAttempts = new System.Windows.Forms.RadioButton();
            this.normalToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_help)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            resources.ApplyResources(this.chart1, "chart1");
            this.chart1.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.chart1.BorderlineColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.IsLabelAutoFit = false;
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
            chartArea1.AxisY.LabelStyle.Format = "{0}%";
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.Maximum = 100D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY.MinorGrid.Enabled = true;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY.MinorTickMark.Enabled = true;
            chartArea1.AxisY.MinorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.Title = "Pass Rate";
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
            chartArea1.Position.Height = 50F;
            chartArea1.Position.Width = 95F;
            chartArea1.Position.X = 2.5F;
            chartArea1.Position.Y = 11.77412F;
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
            chartArea2.Position.Height = 30F;
            chartArea2.Position.Width = 40.5F;
            chartArea2.Position.X = 2.5F;
            chartArea2.Position.Y = 63F;
            chartArea3.AxisX.IsLabelAutoFit = false;
            chartArea3.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisX.Title = "Test Result";
            chartArea3.AxisX.TitleFont = new System.Drawing.Font("Segoe UI", 9F);
            chartArea3.AxisY.IsLabelAutoFit = false;
            chartArea3.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisY.Title = "Total Tests";
            chartArea3.AxisY.TitleFont = new System.Drawing.Font("Segoe UI", 9F);
            chartArea3.AxisY2.IsLabelAutoFit = false;
            chartArea3.AxisY2.LabelStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            chartArea3.AxisY2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            chartArea3.AxisY2.MajorGrid.Enabled = false;
            chartArea3.AxisY2.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            chartArea3.Name = "ChartArea3";
            chartArea3.Position.Auto = false;
            chartArea3.Position.Height = 30F;
            chartArea3.Position.Width = 40.5F;
            chartArea3.Position.X = 43.5F;
            chartArea3.Position.Y = 63F;
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.DataBindings.Add(new System.Windows.Forms.Binding("BorderlineColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chart1.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            legend1.BackColor = System.Drawing.Color.WhiteSmoke;
            legend1.BorderColor = System.Drawing.Color.Gainsboro;
            legend1.DockedToChartArea = "ChartArea3";
            legend1.Font = new System.Drawing.Font("Segoe UI", 8F);
            legend1.IsDockedInsideChartArea = false;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.LegendText = "Vision Tests";
            series1.MarkerSize = 7;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "visionTests";
            series1.ToolTip = "[#LEGENDTEXT]\\n#VAL%";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.LegendText = "Written Tests";
            series2.MarkerSize = 7;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "writtenTests";
            series2.ToolTip = "[#LEGENDTEXT]\\n#VAL%";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.LegendText = "Driving Tests";
            series3.MarkerSize = 7;
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series3.Name = "drivingTests";
            series3.ToolTip = "[#LEGENDTEXT]\\n#VAL%";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(11)))), ((int)(((byte)(244)))));
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.LegendText = "Total";
            series4.MarkerSize = 8;
            series4.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series4.Name = "overallTotal";
            series4.ToolTip = "[#LEGENDTEXT]\\n#VAL%";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series5.ChartArea = "ChartArea2";
            series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series5.IsVisibleInLegend = false;
            series5.Legend = "Legend1";
            series5.LegendText = "Vision Tests";
            series5.Name = "perMonthVisionResults";
            series5.ToolTip = "[#LEGENDTEXT - #VALX]\\n#VAL total tests";
            series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series6.ChartArea = "ChartArea2";
            series6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            series6.IsVisibleInLegend = false;
            series6.Legend = "Legend1";
            series6.LegendText = "Written Tests";
            series6.Name = "perMonthWrittenResults";
            series6.ToolTip = "[#LEGENDTEXT - #VALX]\\n#VAL total tests";
            series6.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series7.ChartArea = "ChartArea2";
            series7.Color = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(10)))));
            series7.IsVisibleInLegend = false;
            series7.Legend = "Legend1";
            series7.LegendText = "Driving Tests";
            series7.Name = "perMonthDrivingResults";
            series7.ToolTip = "[#LEGENDTEXT - #VALX]\\n#VAL total tests";
            series7.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series8.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
            series8.ChartArea = "ChartArea2";
            series8.Color = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(11)))), ((int)(((byte)(244)))));
            series8.IsVisibleInLegend = false;
            series8.Legend = "Legend1";
            series8.LegendText = "Overall Total";
            series8.Name = "perMonthOverallTotalResults";
            series8.ToolTip = "[#LEGENDTEXT - #VALX]\\n#VAL overall";
            series8.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series8.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series9.ChartArea = "ChartArea3";
            series9.Color = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series9.Legend = "Legend1";
            series9.LegendText = "Vision Tests";
            series9.Name = "allTimeVisionResults";
            series9.ToolTip = "[#LEGENDTEXT - #VALX]\\n#VAL total tests";
            series9.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series10.ChartArea = "ChartArea3";
            series10.Color = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            series10.Legend = "Legend1";
            series10.LegendText = "Written Tests";
            series10.Name = "allTimeWrittenResults";
            series10.ToolTip = "[#LEGENDTEXT - #VALX]\\n#VAL total tests";
            series10.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series11.ChartArea = "ChartArea3";
            series11.Color = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(10)))));
            series11.Legend = "Legend1";
            series11.LegendText = "Driving Tests";
            series11.Name = "allTimeDrivingResults";
            series11.ToolTip = "[#LEGENDTEXT - #VALX]\\n#VAL total tests";
            series11.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series12.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
            series12.ChartArea = "ChartArea3";
            series12.Color = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(11)))), ((int)(((byte)(244)))));
            series12.Legend = "Legend1";
            series12.LegendText = "Overall Total";
            series12.Name = "allTimeOverallTotalResults";
            series12.ToolTip = "[#LEGENDTEXT - #VALX]\\n#VAL overall";
            series12.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series12.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series13.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series13.BorderWidth = 2;
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series13.Color = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series13.IsVisibleInLegend = false;
            series13.Legend = "Legend1";
            series13.LegendText = "Average Vision Test Attempts";
            series13.MarkerSize = 7;
            series13.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series13.Name = "avgVisionAttempts";
            series13.ToolTip = "[#LEGENDTEXT]\\n#VAL attempts on average";
            series13.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series13.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series14.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series14.BorderWidth = 2;
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series14.Color = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            series14.IsVisibleInLegend = false;
            series14.Legend = "Legend1";
            series14.LegendText = "Average Written Test Attempts";
            series14.MarkerSize = 7;
            series14.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series14.Name = "avgWrittenAttempts";
            series14.ToolTip = "[#LEGENDTEXT]\\n#VAL attempts on average";
            series14.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series14.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series15.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series15.BorderWidth = 2;
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series15.Color = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(10)))));
            series15.IsVisibleInLegend = false;
            series15.Legend = "Legend1";
            series15.LegendText = "Average Driving Test Attempts";
            series15.MarkerSize = 7;
            series15.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series15.Name = "avgDrivingAttempts";
            series15.ToolTip = "[#LEGENDTEXT]\\n#VAL attempts on average";
            series15.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series15.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series16.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series16.BorderWidth = 3;
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series16.Color = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(11)))), ((int)(((byte)(244)))));
            series16.IsVisibleInLegend = false;
            series16.Legend = "Legend1";
            series16.LegendText = "Total Average Attempts";
            series16.MarkerSize = 7;
            series16.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series16.Name = "totalAvg";
            series16.ToolTip = "[#LEGENDTEXT]\\n#VAL attempts on average";
            series16.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series16.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Series.Add(series9);
            this.chart1.Series.Add(series10);
            this.chart1.Series.Add(series11);
            this.chart1.Series.Add(series12);
            this.chart1.Series.Add(series13);
            this.chart1.Series.Add(series14);
            this.chart1.Series.Add(series15);
            this.chart1.Series.Add(series16);
            title1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Test Pass Rates (Solid Line)";
            title2.DockedToChartArea = "ChartArea2";
            title2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.IsDockedInsideChartArea = false;
            title2.Name = "Title2";
            title2.Text = "-Selected Month-";
            title3.DockedToChartArea = "ChartArea3";
            title3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.IsDockedInsideChartArea = false;
            title3.Name = "Title3";
            title3.Text = "All Time";
            this.chart1.Titles.Add(title1);
            this.chart1.Titles.Add(title2);
            this.chart1.Titles.Add(title3);
            this.chart1.EnabledChanged += new System.EventHandler(this.chart1_EnabledChanged);
            this.chart1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseClick);
            this.chart1.MouseLeave += new System.EventHandler(this.chart1_MouseLeave);
            this.chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseMove);
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
            this.num_year.Enter += new System.EventHandler(this.num_appYear_Enter);
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
            // helpToolTip
            // 
            this.helpToolTip.IsBalloon = true;
            this.helpToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.helpToolTip.ToolTipTitle = "Help";
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
            // chk_visionTests
            // 
            resources.ApplyResources(this.chk_visionTests, "chk_visionTests");
            this.chk_visionTests.Checked = true;
            this.chk_visionTests.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_visionTests.Name = "chk_visionTests";
            this.chk_visionTests.UseVisualStyleBackColor = true;
            this.chk_visionTests.CheckedChanged += new System.EventHandler(this.chk_visionTests_CheckedChanged);
            // 
            // chk_writtenTests
            // 
            resources.ApplyResources(this.chk_writtenTests, "chk_writtenTests");
            this.chk_writtenTests.Checked = true;
            this.chk_writtenTests.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_writtenTests.Name = "chk_writtenTests";
            this.chk_writtenTests.UseVisualStyleBackColor = true;
            this.chk_writtenTests.CheckedChanged += new System.EventHandler(this.chk_writtenTests_CheckedChanged);
            // 
            // chk_drivingTests
            // 
            resources.ApplyResources(this.chk_drivingTests, "chk_drivingTests");
            this.chk_drivingTests.Checked = true;
            this.chk_drivingTests.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_drivingTests.Name = "chk_drivingTests";
            this.chk_drivingTests.UseVisualStyleBackColor = true;
            this.chk_drivingTests.CheckedChanged += new System.EventHandler(this.chk_drivingTests_CheckedChanged);
            // 
            // chk_overallTotal
            // 
            resources.ApplyResources(this.chk_overallTotal, "chk_overallTotal");
            this.chk_overallTotal.Checked = true;
            this.chk_overallTotal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_overallTotal.Name = "chk_overallTotal";
            this.chk_overallTotal.UseVisualStyleBackColor = true;
            this.chk_overallTotal.CheckedChanged += new System.EventHandler(this.chk_overallTotal_CheckedChanged);
            // 
            // lbl_noDataAvailable_perMonth
            // 
            resources.ApplyResources(this.lbl_noDataAvailable_perMonth, "lbl_noDataAvailable_perMonth");
            this.lbl_noDataAvailable_perMonth.Name = "lbl_noDataAvailable_perMonth";
            // 
            // lbl_noDataAvailable_allTime
            // 
            resources.ApplyResources(this.lbl_noDataAvailable_allTime, "lbl_noDataAvailable_allTime");
            this.lbl_noDataAvailable_allTime.Name = "lbl_noDataAvailable_allTime";
            // 
            // lbl_chartIsDisabled
            // 
            resources.ApplyResources(this.lbl_chartIsDisabled, "lbl_chartIsDisabled");
            this.lbl_chartIsDisabled.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lbl_chartIsDisabled.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.lbl_chartIsDisabled.Name = "lbl_chartIsDisabled";
            // 
            // rb_testPassRates
            // 
            resources.ApplyResources(this.rb_testPassRates, "rb_testPassRates");
            this.rb_testPassRates.Checked = true;
            this.rb_testPassRates.Name = "rb_testPassRates";
            this.rb_testPassRates.TabStop = true;
            this.rb_testPassRates.UseVisualStyleBackColor = true;
            this.rb_testPassRates.CheckedChanged += new System.EventHandler(this.rb_testPassRates_CheckedChanged);
            // 
            // rb_avgAttempts
            // 
            resources.ApplyResources(this.rb_avgAttempts, "rb_avgAttempts");
            this.rb_avgAttempts.Name = "rb_avgAttempts";
            this.rb_avgAttempts.UseVisualStyleBackColor = true;
            this.rb_avgAttempts.CheckedChanged += new System.EventHandler(this.rb_avgAttempts_CheckedChanged);
            // 
            // CtrlChart_TestTypesPassRates
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.rb_avgAttempts);
            this.Controls.Add(this.rb_testPassRates);
            this.Controls.Add(this.lbl_chartIsDisabled);
            this.Controls.Add(this.lbl_noDataAvailable_allTime);
            this.Controls.Add(this.lbl_noDataAvailable_perMonth);
            this.Controls.Add(this.chk_overallTotal);
            this.Controls.Add(this.chk_drivingTests);
            this.Controls.Add(this.chk_writtenTests);
            this.Controls.Add(this.chk_visionTests);
            this.Controls.Add(this.pb_help);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.num_year);
            this.Controls.Add(this.chart1);
            resources.ApplyResources(this, "$this");
            this.Name = "CtrlChart_TestTypesPassRates";
            this.Load += new System.EventHandler(this.CtrlChart_Tests_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CtrlChart_Tests_Paint);
            this.Resize += new System.EventHandler(this.CtrlChart_Tests_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_help)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num_year;
        private System.Windows.Forms.PictureBox pb_help;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.ToolTip helpToolTip;
        private System.Windows.Forms.ToolTip normalToolTip;
        private System.Windows.Forms.CheckBox chk_visionTests;
        private System.Windows.Forms.CheckBox chk_writtenTests;
        private System.Windows.Forms.CheckBox chk_drivingTests;
        private System.Windows.Forms.CheckBox chk_overallTotal;
        private System.Windows.Forms.Label lbl_noDataAvailable_perMonth;
        private System.Windows.Forms.Label lbl_noDataAvailable_allTime;
        private System.Windows.Forms.Label lbl_chartIsDisabled;
        private System.Windows.Forms.RadioButton rb_testPassRates;
        private System.Windows.Forms.RadioButton rb_avgAttempts;
        private System.Windows.Forms.Button btn_export;
    }
}
