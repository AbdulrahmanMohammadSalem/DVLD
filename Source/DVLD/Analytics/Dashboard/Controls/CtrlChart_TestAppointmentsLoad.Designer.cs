namespace DVLD.Analytics.Dashboard.Controls {
    partial class CtrlChart_TestAppointmentsLoad {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlChart_TestAppointmentsLoad));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.StripLine stripLine1 = new System.Windows.Forms.DataVisualization.Charting.StripLine();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pb_help = new System.Windows.Forms.PictureBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.num_year = new System.Windows.Forms.NumericUpDown();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.helpToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btn_export = new System.Windows.Forms.Button();
            this.lbl_noDataAvailable = new System.Windows.Forms.Label();
            this.lbl_chartIsDisabled = new System.Windows.Forms.Label();
            this.dgv_appointments = new System.Windows.Forms.DataGridView();
            this.RowNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestTypeImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb_help)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_appointments)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            chartArea1.AxisX.MajorGrid.Enabled = false;
            stripLine1.BackColor = System.Drawing.Color.Gainsboro;
            stripLine1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
            stripLine1.BackSecondaryColor = System.Drawing.Color.White;
            stripLine1.BorderColor = System.Drawing.Color.Silver;
            stripLine1.StripWidth = 1D;
            chartArea1.AxisX.StripLines.Add(stripLine1);
            chartArea1.AxisX.Title = "Months";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Segoe UI", 9F);
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.Title = "Appointments";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Segoe UI", 9F);
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataBindings.Add(new System.Windows.Forms.Binding("BorderlineColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chart1.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BackColor = System.Drawing.Color.WhiteSmoke;
            legend1.BorderColor = System.Drawing.Color.Gainsboro;
            legend1.DockedToChartArea = "ChartArea1";
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Font = new System.Drawing.Font("Segoe UI", 8F);
            legend1.IsDockedInsideChartArea = false;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            series1.Legend = "Legend1";
            series1.LegendText = "Vision Test Appointments";
            series1.Name = "totalVisionAppointments";
            series1.ToolTip = "[#LEGENDTEXT]\\n#VAL total appointments";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            series2.Legend = "Legend1";
            series2.LegendText = "Written Test Appointments";
            series2.Name = "totalWrittenAppointments";
            series2.ToolTip = "[#LEGENDTEXT]\\n#VAL total appointments";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            series3.Legend = "Legend1";
            series3.LegendText = "Driving Test Appointments";
            series3.Name = "totalDrivingAppointments";
            series3.ToolTip = "[#LEGENDTEXT]\\n#VAL total appointments";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            title1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            title1.Name = "Title1";
            title1.Text = "Test Appointments Load";
            this.chart1.Titles.Add(title1);
            this.chart1.EnabledChanged += new System.EventHandler(this.chart1_EnabledChanged);
            this.chart1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseClick);
            this.chart1.MouseLeave += new System.EventHandler(this.chart1_MouseLeave);
            this.chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseMove);
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
            // lbl_noDataAvailable
            // 
            resources.ApplyResources(this.lbl_noDataAvailable, "lbl_noDataAvailable");
            this.lbl_noDataAvailable.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "InactiveForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lbl_noDataAvailable.ForeColor = global::DVLD.Properties.Settings.Default.InactiveForeColor;
            this.lbl_noDataAvailable.Name = "lbl_noDataAvailable";
            // 
            // lbl_chartIsDisabled
            // 
            resources.ApplyResources(this.lbl_chartIsDisabled, "lbl_chartIsDisabled");
            this.lbl_chartIsDisabled.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lbl_chartIsDisabled.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.lbl_chartIsDisabled.Name = "lbl_chartIsDisabled";
            // 
            // dgv_appointments
            // 
            this.dgv_appointments.AllowUserToAddRows = false;
            this.dgv_appointments.AllowUserToDeleteRows = false;
            this.dgv_appointments.AllowUserToOrderColumns = true;
            this.dgv_appointments.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            this.dgv_appointments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.dgv_appointments, "dgv_appointments");
            this.dgv_appointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_appointments.BackgroundColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.dgv_appointments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_appointments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_appointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_appointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_appointments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowNum,
            this.TestTypeImage});
            this.dgv_appointments.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_appointments.DataBindings.Add(new System.Windows.Forms.Binding("GridColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dgv_appointments.DataBindings.Add(new System.Windows.Forms.Binding("BackgroundColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dgv_appointments.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_appointments.EnableHeadersVisualStyles = false;
            this.dgv_appointments.GridColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.dgv_appointments.MultiSelect = false;
            this.dgv_appointments.Name = "dgv_appointments";
            this.dgv_appointments.ReadOnly = true;
            this.dgv_appointments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_appointments.RowHeadersVisible = false;
            this.dgv_appointments.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Readex Pro", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_appointments.RowTemplate.Height = 26;
            this.dgv_appointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_appointments.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_appointments_CellDoubleClick);
            this.dgv_appointments.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_appointments_CellFormatting);
            this.dgv_appointments.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgv_appointments_CellPainting);
            // 
            // RowNum
            // 
            dataGridViewCellStyle3.NullValue = "koko";
            this.RowNum.DefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(this.RowNum, "RowNum");
            this.RowNum.Name = "RowNum";
            this.RowNum.ReadOnly = true;
            // 
            // TestTypeImage
            // 
            resources.ApplyResources(this.TestTypeImage, "TestTypeImage");
            this.TestTypeImage.Name = "TestTypeImage";
            this.TestTypeImage.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.contextMenuStrip1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.contextMenuStrip1.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.takeTestToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::DVLD.Properties.Resources.edit_32;
            resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.Image = global::DVLD.Properties.Resources.Test_32;
            resources.ApplyResources(this.takeTestToolStripMenuItem, "takeTestToolStripMenuItem");
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CtrlChart_TestAppointmentsLoad
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.lbl_chartIsDisabled);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.pb_help);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.num_year);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lbl_noDataAvailable);
            this.Controls.Add(this.dgv_appointments);
            resources.ApplyResources(this, "$this");
            this.Name = "CtrlChart_TestAppointmentsLoad";
            this.Load += new System.EventHandler(this.CtrlChart_TestAppointmentsLoad_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CtrlChart_TestAppointmentsLoad_Paint);
            this.Resize += new System.EventHandler(this.CtrlChart_TestAppointmentsLoad_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pb_help)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_appointments)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_help;
        private System.Windows.Forms.ToolTip helpToolTip;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.ToolTip normalToolTip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num_year;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Label lbl_noDataAvailable;
        private System.Windows.Forms.Label lbl_chartIsDisabled;
        private System.Windows.Forms.DataGridView dgv_appointments;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNum;
        private System.Windows.Forms.DataGridViewImageColumn TestTypeImage;
    }
}
