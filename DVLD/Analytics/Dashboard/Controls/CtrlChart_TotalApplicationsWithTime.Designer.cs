using DVLD.Properties;

namespace DVLD.Analytics.Dashboard.Controls {
    partial class CtrlChart_TotalApplicationsWithTime {
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
                Settings.Default.SettingsSaving -= Default_SettingsSaving;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlChart_TotalApplicationsWithTime));
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
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.helpToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pb_help = new System.Windows.Forms.PictureBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_export = new System.Windows.Forms.Button();
            this.ll_prevQuarter = new System.Windows.Forms.LinkLabel();
            this.ll_nextQuarter = new System.Windows.Forms.LinkLabel();
            this.chk_retakeFailedTest = new System.Windows.Forms.CheckBox();
            this.chk_replaceDamagedLicense = new System.Windows.Forms.CheckBox();
            this.cb_appStatus = new Salem.Controls.SalDropDownList();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.num_year = new System.Windows.Forms.NumericUpDown();
            this.chk_overallTotal = new System.Windows.Forms.CheckBox();
            this.chk_releaseDetainedLicense = new System.Windows.Forms.CheckBox();
            this.chk_renewLicense = new System.Windows.Forms.CheckBox();
            this.chk_replaceLostLicense = new System.Windows.Forms.CheckBox();
            this.chk_newInterLicense = new System.Windows.Forms.CheckBox();
            this.chk_newLocalLicense = new System.Windows.Forms.CheckBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl_chartIsDisabled = new System.Windows.Forms.Label();
            this.normalToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb_help)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // helpToolTip
            // 
            this.helpToolTip.IsBalloon = true;
            this.helpToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.helpToolTip.ToolTipTitle = "Help";
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
            // ll_prevQuarter
            // 
            resources.ApplyResources(this.ll_prevQuarter, "ll_prevQuarter");
            this.ll_prevQuarter.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ll_prevQuarter.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ll_prevQuarter.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.ll_prevQuarter.Name = "ll_prevQuarter";
            this.ll_prevQuarter.TabStop = true;
            this.ll_prevQuarter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_appTypesPerMonths_prevQuarter_LinkClicked);
            // 
            // ll_nextQuarter
            // 
            resources.ApplyResources(this.ll_nextQuarter, "ll_nextQuarter");
            this.ll_nextQuarter.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ll_nextQuarter.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ll_nextQuarter.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.ll_nextQuarter.Name = "ll_nextQuarter";
            this.ll_nextQuarter.TabStop = true;
            this.ll_nextQuarter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_appTypesPerMonths_nextQuarter_LinkClicked);
            // 
            // chk_retakeFailedTest
            // 
            resources.ApplyResources(this.chk_retakeFailedTest, "chk_retakeFailedTest");
            this.chk_retakeFailedTest.Checked = true;
            this.chk_retakeFailedTest.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_retakeFailedTest.Name = "chk_retakeFailedTest";
            this.chk_retakeFailedTest.UseVisualStyleBackColor = true;
            this.chk_retakeFailedTest.CheckedChanged += new System.EventHandler(this.chk_retakeFailedTest_CheckedChanged);
            // 
            // chk_replaceDamagedLicense
            // 
            resources.ApplyResources(this.chk_replaceDamagedLicense, "chk_replaceDamagedLicense");
            this.chk_replaceDamagedLicense.Checked = true;
            this.chk_replaceDamagedLicense.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_replaceDamagedLicense.Name = "chk_replaceDamagedLicense";
            this.chk_replaceDamagedLicense.UseVisualStyleBackColor = true;
            this.chk_replaceDamagedLicense.CheckedChanged += new System.EventHandler(this.chk_replaceDamagedLicense_CheckedChanged);
            // 
            // cb_appStatus
            // 
            resources.ApplyResources(this.cb_appStatus, "cb_appStatus");
            this.cb_appStatus.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.cb_appStatus.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.cb_appStatus.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_appStatus.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_appStatus.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_appStatus.DataBindings.Add(new System.Windows.Forms.Binding("MouseOverBackColor", global::DVLD.Properties.Settings.Default, "SurfaceHoverColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_appStatus.DataBindings.Add(new System.Windows.Forms.Binding("DropDownArrowColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_appStatus.DropDownArrowColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.cb_appStatus.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.cb_appStatus.Items.AddRange(new object[] {
            resources.GetString("cb_appStatus.Items"),
            resources.GetString("cb_appStatus.Items1")});
            this.cb_appStatus.MouseOverBackColor = global::DVLD.Properties.Settings.Default.SurfaceHoverColor;
            this.cb_appStatus.Name = "cb_appStatus";
            this.cb_appStatus.SelectedIndex = 0;
            this.cb_appStatus.TabStop = false;
            this.cb_appStatus.SelectedIndexChanged += new System.EventHandler(this.cb_appStatus_SelectedIndexChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
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
            this.num_year.ValueChanged += new System.EventHandler(this.num_appYear_ValueChanged);
            this.num_year.Enter += new System.EventHandler(this.num_appYear_Enter);
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
            // chk_releaseDetainedLicense
            // 
            resources.ApplyResources(this.chk_releaseDetainedLicense, "chk_releaseDetainedLicense");
            this.chk_releaseDetainedLicense.Checked = true;
            this.chk_releaseDetainedLicense.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_releaseDetainedLicense.Name = "chk_releaseDetainedLicense";
            this.chk_releaseDetainedLicense.UseVisualStyleBackColor = true;
            this.chk_releaseDetainedLicense.CheckedChanged += new System.EventHandler(this.chk_releaseDetainedLicense_CheckedChanged);
            // 
            // chk_renewLicense
            // 
            resources.ApplyResources(this.chk_renewLicense, "chk_renewLicense");
            this.chk_renewLicense.Checked = true;
            this.chk_renewLicense.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_renewLicense.Name = "chk_renewLicense";
            this.chk_renewLicense.UseVisualStyleBackColor = true;
            this.chk_renewLicense.CheckedChanged += new System.EventHandler(this.chk_renewLicense_CheckedChanged);
            // 
            // chk_replaceLostLicense
            // 
            resources.ApplyResources(this.chk_replaceLostLicense, "chk_replaceLostLicense");
            this.chk_replaceLostLicense.Checked = true;
            this.chk_replaceLostLicense.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_replaceLostLicense.Name = "chk_replaceLostLicense";
            this.chk_replaceLostLicense.UseVisualStyleBackColor = true;
            this.chk_replaceLostLicense.CheckedChanged += new System.EventHandler(this.chk_replaceLostLicense_CheckedChanged);
            // 
            // chk_newInterLicense
            // 
            resources.ApplyResources(this.chk_newInterLicense, "chk_newInterLicense");
            this.chk_newInterLicense.Checked = true;
            this.chk_newInterLicense.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_newInterLicense.Name = "chk_newInterLicense";
            this.chk_newInterLicense.UseVisualStyleBackColor = true;
            this.chk_newInterLicense.CheckedChanged += new System.EventHandler(this.chk_newInterLicense_CheckedChanged);
            // 
            // chk_newLocalLicense
            // 
            resources.ApplyResources(this.chk_newLocalLicense, "chk_newLocalLicense");
            this.chk_newLocalLicense.Checked = true;
            this.chk_newLocalLicense.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_newLocalLicense.Name = "chk_newLocalLicense";
            this.chk_newLocalLicense.UseVisualStyleBackColor = true;
            this.chk_newLocalLicense.CheckedChanged += new System.EventHandler(this.chk_newLocalLicense_CheckedChanged);
            // 
            // chart1
            // 
            resources.ApplyResources(this.chart1, "chart1");
            this.chart1.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.chart1.BorderlineColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelAutoFitMinFontSize = 10;
            chartArea1.AxisX.LabelAutoFitStyle = System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep45;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            chartArea1.AxisX.LabelStyle.Interval = 1D;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.ScaleView.Position = 1D;
            chartArea1.AxisX.ScaleView.Size = 2D;
            chartArea1.AxisX.ScrollBar.Enabled = false;
            stripLine1.BackColor = System.Drawing.Color.Gainsboro;
            stripLine1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
            stripLine1.BackSecondaryColor = System.Drawing.Color.White;
            stripLine1.BorderColor = System.Drawing.Color.Silver;
            stripLine1.IntervalOffset = -1D;
            stripLine1.StripWidth = 1D;
            chartArea1.AxisX.StripLines.Add(stripLine1);
            chartArea1.AxisX.Title = "Months";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.Title = "Total Applications";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY2.IsLabelAutoFit = false;
            chartArea1.AxisY2.LabelStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            chartArea1.AxisY2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.AxisY2.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            chartArea1.AxisY2.Title = "Overall Total";
            chartArea1.AxisY2.TitleFont = new System.Drawing.Font("Segoe UI", 9F);
            chartArea1.AxisY2.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 40F;
            chartArea1.Position.Width = 73.13988F;
            chartArea1.Position.X = 2.5F;
            chartArea1.Position.Y = 10.3948F;
            chartArea2.AxisX.Interval = 1D;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.IsMarginVisible = false;
            chartArea2.AxisX.LabelStyle.Angle = -45;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisX.Title = "Days";
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Segoe UI", 9F);
            chartArea2.AxisX2.IsLabelAutoFit = false;
            chartArea2.AxisX2.LabelStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisY.Title = "Total Applications";
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Segoe UI", 9F);
            chartArea2.AxisY2.IsLabelAutoFit = false;
            chartArea2.AxisY2.LabelStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            chartArea2.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            chartArea2.AxisY2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            chartArea2.AxisY2.MajorGrid.Enabled = false;
            chartArea2.AxisY2.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            chartArea2.AxisY2.Title = "Overall Total";
            chartArea2.AxisY2.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY2.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            chartArea2.Name = "ChartArea2";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 49.5F;
            chartArea2.Position.Width = 81.5F;
            chartArea2.Position.X = 2.5F;
            chartArea2.Position.Y = 50F;
            chartArea3.Name = "ChartArea3";
            chartArea3.Position.Auto = false;
            chartArea3.Position.Height = 23.5F;
            chartArea3.Position.Width = 13F;
            chartArea3.Position.X = 85.5F;
            chartArea3.Position.Y = 55F;
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.DataBindings.Add(new System.Windows.Forms.Binding("BorderlineColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chart1.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            legend1.BackColor = System.Drawing.Color.WhiteSmoke;
            legend1.BorderColor = System.Drawing.Color.Gainsboro;
            legend1.DockedToChartArea = "ChartArea1";
            legend1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsDockedInsideChartArea = false;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.LegendText = "New Local License";
            series1.Name = "newLocalLicense";
            series1.ToolTip = "[#LEGENDTEXT]\\n#VAL total applications";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.LegendText = "Renew License";
            series2.Name = "renewLicense";
            series2.ToolTip = "[#LEGENDTEXT]\\n#VAL total applications";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.LegendText = "Replace Lost License";
            series3.Name = "replaceLostLicense";
            series3.ToolTip = "[#LEGENDTEXT]\\n#VAL total applications";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.LegendText = "Replace Damaged License";
            series4.Name = "replaceDamagedLicense";
            series4.ToolTip = "[#LEGENDTEXT]\\n#VAL total applications";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series5.ChartArea = "ChartArea1";
            series5.Color = System.Drawing.Color.Gray;
            series5.Legend = "Legend1";
            series5.LegendText = "Release Detained License";
            series5.Name = "releaseDetainedLicense";
            series5.ToolTip = "[#LEGENDTEXT]\\n#VAL total applications";
            series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series6.ChartArea = "ChartArea1";
            series6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series6.Legend = "Legend1";
            series6.LegendText = "New International License";
            series6.Name = "newInterLicense";
            series6.ToolTip = "[#LEGENDTEXT]\\n#VAL total applications";
            series6.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series7.ChartArea = "ChartArea1";
            series7.Color = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(195)))), ((int)(((byte)(9)))));
            series7.Legend = "Legend1";
            series7.LegendText = "Retake Failed Test";
            series7.Name = "retakeFailedTest";
            series7.ToolTip = "[#LEGENDTEXT]\\n#VAL total applications";
            series7.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series8.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
            series8.ChartArea = "ChartArea1";
            series8.Color = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(11)))), ((int)(((byte)(244)))));
            series8.Legend = "Legend1";
            series8.LegendText = "Overall Total";
            series8.Name = "overallTotal";
            series8.ToolTip = "[#LEGENDTEXT]\\n#VAL overall";
            series8.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series8.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series9.BorderWidth = 2;
            series9.ChartArea = "ChartArea2";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.Color = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series9.IsVisibleInLegend = false;
            series9.Legend = "Legend1";
            series9.LegendText = "New Local License";
            series9.MarkerSize = 6;
            series9.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series9.Name = "newLocalLicenseDays";
            series9.ToolTip = "[#LEGENDTEXT]\\n#VAL total applications";
            series9.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series10.BorderWidth = 2;
            series10.ChartArea = "ChartArea2";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series10.Color = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            series10.IsVisibleInLegend = false;
            series10.Legend = "Legend1";
            series10.LegendText = "Renew License";
            series10.MarkerSize = 6;
            series10.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series10.Name = "renewLicenseDays";
            series10.ToolTip = "[#LEGENDTEXT]\\n#VAL total applications";
            series10.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series11.BorderWidth = 2;
            series11.ChartArea = "ChartArea2";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series11.Color = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(10)))));
            series11.IsVisibleInLegend = false;
            series11.Legend = "Legend1";
            series11.LegendText = "Replace Lost License";
            series11.MarkerSize = 6;
            series11.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series11.Name = "replaceLostLicenseDays";
            series11.ToolTip = "[#LEGENDTEXT]\\n#VAL total applications";
            series11.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series12.BorderWidth = 2;
            series12.ChartArea = "ChartArea2";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series12.Color = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(100)))), ((int)(((byte)(146)))));
            series12.IsVisibleInLegend = false;
            series12.Legend = "Legend1";
            series12.LegendText = "Replace Damaged License";
            series12.MarkerSize = 6;
            series12.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series12.Name = "replaceDamagedLicenseDays";
            series12.ToolTip = "[#LEGENDTEXT]\\n#VAL total applications";
            series12.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series13.BorderWidth = 2;
            series13.ChartArea = "ChartArea2";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series13.Color = System.Drawing.Color.Gray;
            series13.IsVisibleInLegend = false;
            series13.Legend = "Legend1";
            series13.LegendText = "Release Detained License";
            series13.MarkerSize = 6;
            series13.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series13.Name = "releaseDetainedLicenseDays";
            series13.ToolTip = "[#LEGENDTEXT]\\n#VAL total applications";
            series13.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series14.BorderWidth = 2;
            series14.ChartArea = "ChartArea2";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series14.Color = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series14.IsVisibleInLegend = false;
            series14.Legend = "Legend1";
            series14.LegendText = "New International License";
            series14.MarkerSize = 6;
            series14.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series14.Name = "newInterLicenseDays";
            series14.ToolTip = "[#LEGENDTEXT]\\n#VAL total applications";
            series14.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series15.BorderWidth = 2;
            series15.ChartArea = "ChartArea2";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series15.Color = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(195)))), ((int)(((byte)(9)))));
            series15.IsVisibleInLegend = false;
            series15.Legend = "Legend1";
            series15.LegendText = "Retake Failed Test";
            series15.MarkerSize = 6;
            series15.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series15.Name = "retakeFailedTestDays";
            series15.ToolTip = "[#LEGENDTEXT]\\n#VAL total applications";
            series15.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series16.BorderWidth = 3;
            series16.ChartArea = "ChartArea2";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series16.Color = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(11)))), ((int)(((byte)(244)))));
            series16.IsVisibleInLegend = false;
            series16.Legend = "Legend1";
            series16.LegendText = "Overall Total";
            series16.MarkerSize = 6;
            series16.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series16.Name = "overallTotalDays";
            series16.ToolTip = "[#LEGENDTEXT]\\n#VAL overall";
            series16.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series16.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series17.ChartArea = "ChartArea3";
            series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series17.Font = new System.Drawing.Font("Segoe UI", 8F);
            series17.IsVisibleInLegend = false;
            series17.LabelForeColor = System.Drawing.Color.White;
            series17.Legend = "Legend1";
            series17.Name = "totalAppsAllTime";
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
            this.chart1.Series.Add(series17);
            title1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.IsDockedInsideChartArea = false;
            title1.Name = "Title1";
            title1.Text = "Total Applications Over Time";
            title2.DockedToChartArea = "ChartArea3";
            title2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.IsDockedInsideChartArea = false;
            title2.Name = "Title2";
            title2.Text = "All Time";
            this.chart1.Titles.Add(title1);
            this.chart1.Titles.Add(title2);
            this.chart1.EnabledChanged += new System.EventHandler(this.chrt_appTypesPerMonths_EnabledChanged);
            this.chart1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseClick);
            this.chart1.MouseLeave += new System.EventHandler(this.chrt_appTypesPerMonths_MouseLeave);
            this.chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chrt_appTypesPerMonths_MouseMove);
            // 
            // lbl_chartIsDisabled
            // 
            resources.ApplyResources(this.lbl_chartIsDisabled, "lbl_chartIsDisabled");
            this.lbl_chartIsDisabled.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lbl_chartIsDisabled.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.lbl_chartIsDisabled.Name = "lbl_chartIsDisabled";
            // 
            // CtrlChart_TotalApplicationsWithTime
            // 
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.lbl_chartIsDisabled);
            this.Controls.Add(this.pb_help);
            this.Controls.Add(this.ll_prevQuarter);
            this.Controls.Add(this.ll_nextQuarter);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.chk_replaceDamagedLicense);
            this.Controls.Add(this.cb_appStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.num_year);
            this.Controls.Add(this.chk_overallTotal);
            this.Controls.Add(this.chk_releaseDetainedLicense);
            this.Controls.Add(this.chk_renewLicense);
            this.Controls.Add(this.chk_replaceLostLicense);
            this.Controls.Add(this.chk_newInterLicense);
            this.Controls.Add(this.chk_newLocalLicense);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.chk_retakeFailedTest);
            resources.ApplyResources(this, "$this");
            this.Name = "CtrlChart_TotalApplicationsWithTime";
            this.Load += new System.EventHandler(this.CtrlChart_TotalApplicationsWithTime_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CtrlChart_TotalApplicationsWithTime_Paint);
            this.Resize += new System.EventHandler(this.CtrlChart_TotalApplicationsWithTime_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pb_help)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip helpToolTip;
        private System.Windows.Forms.LinkLabel ll_prevQuarter;
        private System.Windows.Forms.LinkLabel ll_nextQuarter;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.CheckBox chk_retakeFailedTest;
        private System.Windows.Forms.CheckBox chk_replaceDamagedLicense;
        private Salem.Controls.SalDropDownList cb_appStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num_year;
        private System.Windows.Forms.CheckBox chk_overallTotal;
        private System.Windows.Forms.CheckBox chk_releaseDetainedLicense;
        private System.Windows.Forms.CheckBox chk_renewLicense;
        private System.Windows.Forms.CheckBox chk_replaceLostLicense;
        private System.Windows.Forms.CheckBox chk_newInterLicense;
        private System.Windows.Forms.CheckBox chk_newLocalLicense;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.PictureBox pb_help;
        private System.Windows.Forms.ToolTip normalToolTip;
        private System.Windows.Forms.Label lbl_chartIsDisabled;
        private System.Windows.Forms.Button btn_export;
    }
}
