namespace DVLD.Analytics.Dashboard.Controls {
    partial class Ctrl_SystemWideRevenue {
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
                _latinModernMath.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ctrl_SystemWideRevenue));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_title = new System.Windows.Forms.Label();
            this.dgv_revenue = new System.Windows.Forms.DataGridView();
            this.RowNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.dt_date = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_sourceType = new Salem.Controls.SalDropDownList();
            this.cb_source = new Salem.Controls.SalDropDownList();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_registeredBy = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lbl_noDataAvailable = new System.Windows.Forms.Label();
            this.ll_exportData = new System.Windows.Forms.LinkLabel();
            this.ll_refreshData = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_revenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_date.Calendar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_registeredBy)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            resources.ApplyResources(this.lbl_title, "lbl_title");
            this.lbl_title.Name = "lbl_title";
            // 
            // dgv_revenue
            // 
            this.dgv_revenue.AllowUserToAddRows = false;
            this.dgv_revenue.AllowUserToDeleteRows = false;
            this.dgv_revenue.AllowUserToOrderColumns = true;
            this.dgv_revenue.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            this.dgv_revenue.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            resources.ApplyResources(this.dgv_revenue, "dgv_revenue");
            this.dgv_revenue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_revenue.BackgroundColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.dgv_revenue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_revenue.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_revenue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_revenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_revenue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowNum});
            this.dgv_revenue.DataBindings.Add(new System.Windows.Forms.Binding("GridColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dgv_revenue.DataBindings.Add(new System.Windows.Forms.Binding("BackgroundColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dgv_revenue.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_revenue.EnableHeadersVisualStyles = false;
            this.dgv_revenue.GridColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.dgv_revenue.MultiSelect = false;
            this.dgv_revenue.Name = "dgv_revenue";
            this.dgv_revenue.ReadOnly = true;
            this.dgv_revenue.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_revenue.RowHeadersVisible = false;
            this.dgv_revenue.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Readex Pro", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_revenue.RowTemplate.Height = 26;
            this.dgv_revenue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_revenue.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_revenue_CellFormatting);
            this.dgv_revenue.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgv_revenue_CellPainting);
            // 
            // RowNum
            // 
            resources.ApplyResources(this.RowNum, "RowNum");
            this.RowNum.Name = "RowNum";
            this.RowNum.ReadOnly = true;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // dt_date
            // 
            this.dt_date.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.dt_date.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.dt_date.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.dt_date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // 
            // 
            this.dt_date.Calendar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dt_date.Calendar.BottomHeight = 6;
            this.dt_date.Calendar.DayNamesColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.dt_date.Calendar.DayNamesFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dt_date.Calendar.DaysColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dt_date.Calendar.Font = ((System.Drawing.Font)(resources.GetObject("dt_date.Calendar.Font")));
            this.dt_date.Calendar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dt_date.Calendar.GridBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dt_date.Calendar.GridLines = Syncfusion.Windows.Forms.Grid.GridBorderStyle.None;
            this.dt_date.Calendar.HeaderFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.dt_date.Calendar.HeaderStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dt_date.Calendar.HeadForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dt_date.Calendar.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.dt_date.Calendar.InactiveMonthColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dt_date.Calendar.Location = ((System.Drawing.Point)(resources.GetObject("dt_date.Calendar.Location")));
            this.dt_date.Calendar.Name = "monthCalendar";
            this.dt_date.Calendar.ScrollButtonSize = new System.Drawing.Size(24, 24);
            this.dt_date.Calendar.Size = ((System.Drawing.Size)(resources.GetObject("dt_date.Calendar.Size")));
            this.dt_date.Calendar.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.dt_date.Calendar.TabIndex = ((int)(resources.GetObject("dt_date.Calendar.TabIndex")));
            // 
            // 
            // 
            this.dt_date.Calendar.NoneButton.AutoSize = ((bool)(resources.GetObject("dt_date.Calendar.NoneButton.AutoSize")));
            this.dt_date.Calendar.NoneButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dt_date.Calendar.NoneButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("dt_date.Calendar.NoneButton.ImeMode")));
            this.dt_date.Calendar.NoneButton.KeepFocusRectangle = false;
            this.dt_date.Calendar.NoneButton.Location = ((System.Drawing.Point)(resources.GetObject("dt_date.Calendar.NoneButton.Location")));
            this.dt_date.Calendar.NoneButton.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("dt_date.Calendar.NoneButton.Margin")));
            this.dt_date.Calendar.NoneButton.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dt_date.Calendar.NoneButton.ThemeName = "Metro";
            // 
            // 
            // 
            this.dt_date.Calendar.TodayButton.AutoSize = ((bool)(resources.GetObject("dt_date.Calendar.TodayButton.AutoSize")));
            this.dt_date.Calendar.TodayButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dt_date.Calendar.TodayButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("dt_date.Calendar.TodayButton.ImeMode")));
            this.dt_date.Calendar.TodayButton.KeepFocusRectangle = false;
            this.dt_date.Calendar.TodayButton.Location = ((System.Drawing.Point)(resources.GetObject("dt_date.Calendar.TodayButton.Location")));
            this.dt_date.Calendar.TodayButton.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("dt_date.Calendar.TodayButton.Margin")));
            this.dt_date.Calendar.TodayButton.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dt_date.Calendar.TodayButton.ThemeName = "Metro";
            this.dt_date.CalendarForeColor = System.Drawing.SystemColors.WindowText;
            this.dt_date.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dt_date.CalendarSize = new System.Drawing.Size(189, 176);
            this.dt_date.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dt_date.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dt_date.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dt_date.Checked = false;
            this.dt_date.CustomFormat = "ddd, dd/MM/yyyy";
            this.dt_date.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dt_date.DataBindings.Add(new System.Windows.Forms.Binding("Style", global::DVLD.Properties.Settings.Default, "DateTimePickerStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dt_date.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dt_date.DropDownImage = null;
            this.dt_date.DropDownNormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.dt_date, "dt_date");
            this.dt_date.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.dt_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_date.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.dt_date.MinValue = new System.DateTime(((long)(0)));
            this.dt_date.Name = "dt_date";
            this.dt_date.NoneButtonVisible = false;
            this.dt_date.Style = global::DVLD.Properties.Settings.Default.DateTimePickerStyle;
            this.dt_date.Value = new System.DateTime(2026, 5, 3, 1, 22, 21, 253);
            this.dt_date.CheckBoxCheckedChanged += new System.EventHandler(this.dt_date_CheckBoxCheckedChanged);
            this.dt_date.ValueChanged += new System.EventHandler(this.dt_date_ValueChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // cb_sourceType
            // 
            this.cb_sourceType.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.cb_sourceType.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.cb_sourceType.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_sourceType.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_sourceType.DataBindings.Add(new System.Windows.Forms.Binding("DropDownArrowColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_sourceType.DataBindings.Add(new System.Windows.Forms.Binding("MouseOverBackColor", global::DVLD.Properties.Settings.Default, "SurfaceHoverColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_sourceType.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_sourceType.DropDownArrowColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            resources.ApplyResources(this.cb_sourceType, "cb_sourceType");
            this.cb_sourceType.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.cb_sourceType.Items.AddRange(new object[] {
            resources.GetString("cb_sourceType.Items"),
            resources.GetString("cb_sourceType.Items1"),
            resources.GetString("cb_sourceType.Items2"),
            resources.GetString("cb_sourceType.Items3"),
            resources.GetString("cb_sourceType.Items4")});
            this.cb_sourceType.MouseOverBackColor = global::DVLD.Properties.Settings.Default.SurfaceHoverColor;
            this.cb_sourceType.Name = "cb_sourceType";
            this.cb_sourceType.SelectedIndex = 0;
            this.cb_sourceType.TabStop = false;
            this.cb_sourceType.SelectedIndexChanged += new System.EventHandler(this.cb_sourceType_SelectedIndexChanged);
            // 
            // cb_source
            // 
            resources.ApplyResources(this.cb_source, "cb_source");
            this.cb_source.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.cb_source.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.cb_source.DataBindings.Add(new System.Windows.Forms.Binding("DropDownArrowColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_source.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_source.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_source.DataBindings.Add(new System.Windows.Forms.Binding("MouseOverBackColor", global::DVLD.Properties.Settings.Default, "SurfaceHoverColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_source.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_source.DropDownArrowColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.cb_source.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.cb_source.Items.AddRange(new object[] {
            resources.GetString("cb_source.Items")});
            this.cb_source.MouseOverBackColor = global::DVLD.Properties.Settings.Default.SurfaceHoverColor;
            this.cb_source.Name = "cb_source";
            this.cb_source.SelectedIndex = 0;
            this.cb_source.TabStop = false;
            this.cb_source.SelectedIndexChanged += new System.EventHandler(this.cb_source_SelectedIndexChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txt_registeredBy
            // 
            resources.ApplyResources(this.txt_registeredBy, "txt_registeredBy");
            this.txt_registeredBy.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.txt_registeredBy.BeforeTouchSize = new System.Drawing.Size(297, 30);
            this.txt_registeredBy.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.txt_registeredBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_registeredBy.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_registeredBy.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_registeredBy.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_registeredBy.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.txt_registeredBy.Name = "txt_registeredBy";
            this.txt_registeredBy.TextChanged += new System.EventHandler(this.txt_registeredBy_TextChanged);
            // 
            // lbl_noDataAvailable
            // 
            resources.ApplyResources(this.lbl_noDataAvailable, "lbl_noDataAvailable");
            this.lbl_noDataAvailable.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "InactiveForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lbl_noDataAvailable.ForeColor = global::DVLD.Properties.Settings.Default.InactiveForeColor;
            this.lbl_noDataAvailable.Name = "lbl_noDataAvailable";
            // 
            // ll_exportData
            // 
            resources.ApplyResources(this.ll_exportData, "ll_exportData");
            this.ll_exportData.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ll_exportData.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ll_exportData.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.ll_exportData.Name = "ll_exportData";
            this.ll_exportData.TabStop = true;
            this.ll_exportData.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_exportData_LinkClicked);
            // 
            // ll_refreshData
            // 
            resources.ApplyResources(this.ll_refreshData, "ll_refreshData");
            this.ll_refreshData.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ll_refreshData.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ll_refreshData.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.ll_refreshData.Name = "ll_refreshData";
            this.ll_refreshData.TabStop = true;
            this.ll_refreshData.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_refreshData_LinkClicked);
            // 
            // Ctrl_SystemWideRevenue
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ll_exportData);
            this.Controls.Add(this.ll_refreshData);
            this.Controls.Add(this.lbl_noDataAvailable);
            this.Controls.Add(this.txt_registeredBy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_source);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_sourceType);
            this.Controls.Add(this.dt_date);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv_revenue);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            resources.ApplyResources(this, "$this");
            this.Name = "Ctrl_SystemWideRevenue";
            this.Load += new System.EventHandler(this.Ctrl_SystemWideRevenue_Load);
            this.EnabledChanged += new System.EventHandler(this.Ctrl_SystemWideRevenue_EnabledChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Ctrl_SystemWideRevenue_Paint);
            this.Resize += new System.EventHandler(this.Ctrl_SystemWideRevenue_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_revenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_date.Calendar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_registeredBy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.DataGridView dgv_revenue;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNum;
        private System.Windows.Forms.Label label5;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv dt_date;
        private System.Windows.Forms.Label label2;
        private Salem.Controls.SalDropDownList cb_sourceType;
        private Salem.Controls.SalDropDownList cb_source;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txt_registeredBy;
        private System.Windows.Forms.Label lbl_noDataAvailable;
        private System.Windows.Forms.LinkLabel ll_exportData;
        private System.Windows.Forms.LinkLabel ll_refreshData;
    }
}
