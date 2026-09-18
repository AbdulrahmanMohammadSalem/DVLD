namespace DVLD.Analytics.Reports {
    partial class Frm_LicenseDetentionReport {
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
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_LicenseDetentionReport));
            this.label_title = new System.Windows.Forms.Label();
            this.ctrl_LocalLicenseInfoCardWithFilter1 = new DVLD.Licenses.Controls.Ctrl_LocalLicenseInfoCardWithFilter();
            this.ctrl_DocumentExportSettings1 = new DVLD.Analytics.Reports.Controls.Ctrl_DocumentExportSettings();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_allTime = new System.Windows.Forms.RadioButton();
            this.rb_customRange = new System.Windows.Forms.RadioButton();
            this.gb_dateRange = new System.Windows.Forms.GroupBox();
            this.dt_endDate = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.dt_startDate = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.label13 = new System.Windows.Forms.Label();
            this.chk_includeDetentionHistory = new System.Windows.Forms.CheckBox();
            this.chk_includeLicenseInfo = new System.Windows.Forms.CheckBox();
            this.chk_includeDriverInfo = new System.Windows.Forms.CheckBox();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_export = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gb_dateRange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_endDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_endDate.Calendar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_startDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_startDate.Calendar)).BeginInit();
            this.SuspendLayout();
            // 
            // label_title
            // 
            resources.ApplyResources(this.label_title, "label_title");
            this.label_title.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "AccentForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label_title.ForeColor = global::DVLD.Properties.Settings.Default.AccentForeColor;
            this.label_title.Name = "label_title";
            // 
            // ctrl_LocalLicenseInfoCardWithFilter1
            // 
            resources.ApplyResources(this.ctrl_LocalLicenseInfoCardWithFilter1, "ctrl_LocalLicenseInfoCardWithFilter1");
            this.ctrl_LocalLicenseInfoCardWithFilter1.EnableFiltering = true;
            this.ctrl_LocalLicenseInfoCardWithFilter1.Name = "ctrl_LocalLicenseInfoCardWithFilter1";
            this.ctrl_LocalLicenseInfoCardWithFilter1.LicenseFound += new System.Action<bool>(this.ctrl_LocalLicenseInfoCardWithFilter1_LicenseFound);
            this.ctrl_LocalLicenseInfoCardWithFilter1.LicenseNotFound += new System.Action(this.ctrl_LocalLicenseInfoCardWithFilter1_LicenseNotFound);
            this.ctrl_LocalLicenseInfoCardWithFilter1.PersonSaved += new System.Action<int>(this.ctrl_LocalLicenseInfoCardWithFilter1_PersonSaved);
            // 
            // ctrl_DocumentExportSettings1
            // 
            resources.ApplyResources(this.ctrl_DocumentExportSettings1, "ctrl_DocumentExportSettings1");
            this.ctrl_DocumentExportSettings1.Name = "ctrl_DocumentExportSettings1";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.rb_allTime);
            this.groupBox1.Controls.Add(this.rb_customRange);
            this.groupBox1.Controls.Add(this.gb_dateRange);
            this.groupBox1.Controls.Add(this.chk_includeDetentionHistory);
            this.groupBox1.Controls.Add(this.chk_includeLicenseInfo);
            this.groupBox1.Controls.Add(this.chk_includeDriverInfo);
            this.groupBox1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupBox1.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // rb_allTime
            // 
            resources.ApplyResources(this.rb_allTime, "rb_allTime");
            this.rb_allTime.Checked = true;
            this.rb_allTime.Name = "rb_allTime";
            this.rb_allTime.TabStop = true;
            this.rb_allTime.UseVisualStyleBackColor = true;
            // 
            // rb_customRange
            // 
            resources.ApplyResources(this.rb_customRange, "rb_customRange");
            this.rb_customRange.Name = "rb_customRange";
            this.rb_customRange.UseVisualStyleBackColor = true;
            this.rb_customRange.CheckedChanged += new System.EventHandler(this.rb_customRange_CheckedChanged);
            // 
            // gb_dateRange
            // 
            resources.ApplyResources(this.gb_dateRange, "gb_dateRange");
            this.gb_dateRange.Controls.Add(this.dt_endDate);
            this.gb_dateRange.Controls.Add(this.label1);
            this.gb_dateRange.Controls.Add(this.dt_startDate);
            this.gb_dateRange.Controls.Add(this.label13);
            this.gb_dateRange.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.gb_dateRange.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.gb_dateRange.Name = "gb_dateRange";
            this.gb_dateRange.TabStop = false;
            // 
            // dt_endDate
            // 
            resources.ApplyResources(this.dt_endDate, "dt_endDate");
            this.dt_endDate.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.dt_endDate.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.dt_endDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.dt_endDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // 
            // 
            this.dt_endDate.Calendar.AccessibleDescription = resources.GetString("dt_endDate.Calendar.AccessibleDescription");
            this.dt_endDate.Calendar.AccessibleName = resources.GetString("dt_endDate.Calendar.AccessibleName");
            this.dt_endDate.Calendar.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("dt_endDate.Calendar.Anchor")));
            this.dt_endDate.Calendar.AutoScroll = ((bool)(resources.GetObject("dt_endDate.Calendar.AutoScroll")));
            this.dt_endDate.Calendar.AutoSize = ((bool)(resources.GetObject("dt_endDate.Calendar.AutoSize")));
            this.dt_endDate.Calendar.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("dt_endDate.Calendar.AutoSizeMode")));
            this.dt_endDate.Calendar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dt_endDate.Calendar.BottomHeight = 6;
            this.dt_endDate.Calendar.DayNamesColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.dt_endDate.Calendar.DaysColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dt_endDate.Calendar.DaysFont = new System.Drawing.Font("Tahoma", 8F);
            this.dt_endDate.Calendar.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("dt_endDate.Calendar.Dock")));
            this.dt_endDate.Calendar.Font = ((System.Drawing.Font)(resources.GetObject("dt_endDate.Calendar.Font")));
            this.dt_endDate.Calendar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dt_endDate.Calendar.GridBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dt_endDate.Calendar.GridLines = Syncfusion.Windows.Forms.Grid.GridBorderStyle.None;
            this.dt_endDate.Calendar.HeaderFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_endDate.Calendar.HeaderStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dt_endDate.Calendar.HeadForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dt_endDate.Calendar.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.dt_endDate.Calendar.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("dt_endDate.Calendar.ImeMode")));
            this.dt_endDate.Calendar.InactiveMonthColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dt_endDate.Calendar.Location = ((System.Drawing.Point)(resources.GetObject("dt_endDate.Calendar.Location")));
            this.dt_endDate.Calendar.MaximumSize = ((System.Drawing.Size)(resources.GetObject("dt_endDate.Calendar.MaximumSize")));
            this.dt_endDate.Calendar.Name = "monthCalendar";
            this.dt_endDate.Calendar.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("dt_endDate.Calendar.RightToLeft")));
            this.dt_endDate.Calendar.ScrollButtonSize = new System.Drawing.Size(21, 23);
            this.dt_endDate.Calendar.Size = ((System.Drawing.Size)(resources.GetObject("dt_endDate.Calendar.Size")));
            this.dt_endDate.Calendar.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.dt_endDate.Calendar.TabIndex = ((int)(resources.GetObject("dt_endDate.Calendar.TabIndex")));
            // 
            // 
            // 
            this.dt_endDate.Calendar.NoneButton.AccessibleDescription = resources.GetString("dt_endDate.Calendar.NoneButton.AccessibleDescription");
            this.dt_endDate.Calendar.NoneButton.AccessibleName = resources.GetString("dt_endDate.Calendar.NoneButton.AccessibleName");
            this.dt_endDate.Calendar.NoneButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("dt_endDate.Calendar.NoneButton.Anchor")));
            this.dt_endDate.Calendar.NoneButton.AutoSize = ((bool)(resources.GetObject("dt_endDate.Calendar.NoneButton.AutoSize")));
            this.dt_endDate.Calendar.NoneButton.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("dt_endDate.Calendar.NoneButton.AutoSizeMode")));
            this.dt_endDate.Calendar.NoneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.dt_endDate.Calendar.NoneButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dt_endDate.Calendar.NoneButton.BackgroundImage")));
            this.dt_endDate.Calendar.NoneButton.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("dt_endDate.Calendar.NoneButton.BackgroundImageLayout")));
            this.dt_endDate.Calendar.NoneButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("dt_endDate.Calendar.NoneButton.Dock")));
            this.dt_endDate.Calendar.NoneButton.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("dt_endDate.Calendar.NoneButton.FlatStyle")));
            this.dt_endDate.Calendar.NoneButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dt_endDate.Calendar.NoneButton.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("dt_endDate.Calendar.NoneButton.ImageAlign")));
            this.dt_endDate.Calendar.NoneButton.ImageIndex = ((int)(resources.GetObject("dt_endDate.Calendar.NoneButton.ImageIndex")));
            this.dt_endDate.Calendar.NoneButton.ImageKey = resources.GetString("dt_endDate.Calendar.NoneButton.ImageKey");
            this.dt_endDate.Calendar.NoneButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("dt_endDate.Calendar.NoneButton.ImeMode")));
            this.dt_endDate.Calendar.NoneButton.KeepFocusRectangle = false;
            this.dt_endDate.Calendar.NoneButton.Location = ((System.Drawing.Point)(resources.GetObject("dt_endDate.Calendar.NoneButton.Location")));
            this.dt_endDate.Calendar.NoneButton.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("dt_endDate.Calendar.NoneButton.Margin")));
            this.dt_endDate.Calendar.NoneButton.MaximumSize = ((System.Drawing.Size)(resources.GetObject("dt_endDate.Calendar.NoneButton.MaximumSize")));
            this.dt_endDate.Calendar.NoneButton.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dt_endDate.Calendar.NoneButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("dt_endDate.Calendar.NoneButton.RightToLeft")));
            this.dt_endDate.Calendar.NoneButton.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("dt_endDate.Calendar.NoneButton.TextAlign")));
            this.dt_endDate.Calendar.NoneButton.TextImageRelation = ((System.Windows.Forms.TextImageRelation)(resources.GetObject("dt_endDate.Calendar.NoneButton.TextImageRelation")));
            this.dt_endDate.Calendar.NoneButton.ThemeName = "Metro";
            // 
            // 
            // 
            this.dt_endDate.Calendar.TodayButton.AccessibleDescription = resources.GetString("dt_endDate.Calendar.TodayButton.AccessibleDescription");
            this.dt_endDate.Calendar.TodayButton.AccessibleName = resources.GetString("dt_endDate.Calendar.TodayButton.AccessibleName");
            this.dt_endDate.Calendar.TodayButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("dt_endDate.Calendar.TodayButton.Anchor")));
            this.dt_endDate.Calendar.TodayButton.AutoSize = ((bool)(resources.GetObject("dt_endDate.Calendar.TodayButton.AutoSize")));
            this.dt_endDate.Calendar.TodayButton.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("dt_endDate.Calendar.TodayButton.AutoSizeMode")));
            this.dt_endDate.Calendar.TodayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.dt_endDate.Calendar.TodayButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dt_endDate.Calendar.TodayButton.BackgroundImage")));
            this.dt_endDate.Calendar.TodayButton.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("dt_endDate.Calendar.TodayButton.BackgroundImageLayout")));
            this.dt_endDate.Calendar.TodayButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("dt_endDate.Calendar.TodayButton.Dock")));
            this.dt_endDate.Calendar.TodayButton.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("dt_endDate.Calendar.TodayButton.FlatStyle")));
            this.dt_endDate.Calendar.TodayButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dt_endDate.Calendar.TodayButton.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("dt_endDate.Calendar.TodayButton.ImageAlign")));
            this.dt_endDate.Calendar.TodayButton.ImageIndex = ((int)(resources.GetObject("dt_endDate.Calendar.TodayButton.ImageIndex")));
            this.dt_endDate.Calendar.TodayButton.ImageKey = resources.GetString("dt_endDate.Calendar.TodayButton.ImageKey");
            this.dt_endDate.Calendar.TodayButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("dt_endDate.Calendar.TodayButton.ImeMode")));
            this.dt_endDate.Calendar.TodayButton.KeepFocusRectangle = false;
            this.dt_endDate.Calendar.TodayButton.Location = ((System.Drawing.Point)(resources.GetObject("dt_endDate.Calendar.TodayButton.Location")));
            this.dt_endDate.Calendar.TodayButton.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("dt_endDate.Calendar.TodayButton.Margin")));
            this.dt_endDate.Calendar.TodayButton.MaximumSize = ((System.Drawing.Size)(resources.GetObject("dt_endDate.Calendar.TodayButton.MaximumSize")));
            this.dt_endDate.Calendar.TodayButton.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dt_endDate.Calendar.TodayButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("dt_endDate.Calendar.TodayButton.RightToLeft")));
            this.dt_endDate.Calendar.TodayButton.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("dt_endDate.Calendar.TodayButton.TextAlign")));
            this.dt_endDate.Calendar.TodayButton.TextImageRelation = ((System.Windows.Forms.TextImageRelation)(resources.GetObject("dt_endDate.Calendar.TodayButton.TextImageRelation")));
            this.dt_endDate.Calendar.TodayButton.ThemeName = "Metro";
            this.dt_endDate.CalendarFont = new System.Drawing.Font("Tahoma", 8F);
            this.dt_endDate.CalendarForeColor = System.Drawing.SystemColors.WindowText;
            this.dt_endDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dt_endDate.CalendarSize = new System.Drawing.Size(189, 176);
            this.dt_endDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dt_endDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dt_endDate.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dt_endDate.CustomFormat = "ddd, dd/MM/yyyy";
            this.dt_endDate.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dt_endDate.DataBindings.Add(new System.Windows.Forms.Binding("Style", global::DVLD.Properties.Settings.Default, "DateTimePickerStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dt_endDate.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dt_endDate.DropDownImage = null;
            this.dt_endDate.DropDownNormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dt_endDate.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.dt_endDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_endDate.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.dt_endDate.MinValue = new System.DateTime(((long)(0)));
            this.dt_endDate.Name = "dt_endDate";
            this.dt_endDate.NoneButtonVisible = false;
            this.dt_endDate.ShowCheckBox = false;
            this.dt_endDate.Value = new System.DateTime(2026, 5, 3, 1, 22, 21, 253);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // dt_startDate
            // 
            resources.ApplyResources(this.dt_startDate, "dt_startDate");
            this.dt_startDate.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.dt_startDate.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.dt_startDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.dt_startDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // 
            // 
            this.dt_startDate.Calendar.AccessibleDescription = resources.GetString("dt_startDate.Calendar.AccessibleDescription");
            this.dt_startDate.Calendar.AccessibleName = resources.GetString("dt_startDate.Calendar.AccessibleName");
            this.dt_startDate.Calendar.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("dt_startDate.Calendar.Anchor")));
            this.dt_startDate.Calendar.AutoScroll = ((bool)(resources.GetObject("dt_startDate.Calendar.AutoScroll")));
            this.dt_startDate.Calendar.AutoSize = ((bool)(resources.GetObject("dt_startDate.Calendar.AutoSize")));
            this.dt_startDate.Calendar.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("dt_startDate.Calendar.AutoSizeMode")));
            this.dt_startDate.Calendar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dt_startDate.Calendar.BottomHeight = 6;
            this.dt_startDate.Calendar.DayNamesColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.dt_startDate.Calendar.DaysColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dt_startDate.Calendar.DaysFont = new System.Drawing.Font("Tahoma", 8F);
            this.dt_startDate.Calendar.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("dt_startDate.Calendar.Dock")));
            this.dt_startDate.Calendar.Font = ((System.Drawing.Font)(resources.GetObject("dt_startDate.Calendar.Font")));
            this.dt_startDate.Calendar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dt_startDate.Calendar.GridBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dt_startDate.Calendar.GridLines = Syncfusion.Windows.Forms.Grid.GridBorderStyle.None;
            this.dt_startDate.Calendar.HeaderFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_startDate.Calendar.HeaderStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dt_startDate.Calendar.HeadForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dt_startDate.Calendar.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.dt_startDate.Calendar.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("dt_startDate.Calendar.ImeMode")));
            this.dt_startDate.Calendar.InactiveMonthColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dt_startDate.Calendar.Location = ((System.Drawing.Point)(resources.GetObject("dt_startDate.Calendar.Location")));
            this.dt_startDate.Calendar.MaximumSize = ((System.Drawing.Size)(resources.GetObject("dt_startDate.Calendar.MaximumSize")));
            this.dt_startDate.Calendar.Name = "monthCalendar";
            this.dt_startDate.Calendar.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("dt_startDate.Calendar.RightToLeft")));
            this.dt_startDate.Calendar.ScrollButtonSize = new System.Drawing.Size(21, 23);
            this.dt_startDate.Calendar.Size = ((System.Drawing.Size)(resources.GetObject("dt_startDate.Calendar.Size")));
            this.dt_startDate.Calendar.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.dt_startDate.Calendar.TabIndex = ((int)(resources.GetObject("dt_startDate.Calendar.TabIndex")));
            // 
            // 
            // 
            this.dt_startDate.Calendar.NoneButton.AccessibleDescription = resources.GetString("dt_startDate.Calendar.NoneButton.AccessibleDescription");
            this.dt_startDate.Calendar.NoneButton.AccessibleName = resources.GetString("dt_startDate.Calendar.NoneButton.AccessibleName");
            this.dt_startDate.Calendar.NoneButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("dt_startDate.Calendar.NoneButton.Anchor")));
            this.dt_startDate.Calendar.NoneButton.AutoSize = ((bool)(resources.GetObject("dt_startDate.Calendar.NoneButton.AutoSize")));
            this.dt_startDate.Calendar.NoneButton.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("dt_startDate.Calendar.NoneButton.AutoSizeMode")));
            this.dt_startDate.Calendar.NoneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.dt_startDate.Calendar.NoneButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dt_startDate.Calendar.NoneButton.BackgroundImage")));
            this.dt_startDate.Calendar.NoneButton.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("dt_startDate.Calendar.NoneButton.BackgroundImageLayout")));
            this.dt_startDate.Calendar.NoneButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("dt_startDate.Calendar.NoneButton.Dock")));
            this.dt_startDate.Calendar.NoneButton.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("dt_startDate.Calendar.NoneButton.FlatStyle")));
            this.dt_startDate.Calendar.NoneButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dt_startDate.Calendar.NoneButton.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("dt_startDate.Calendar.NoneButton.ImageAlign")));
            this.dt_startDate.Calendar.NoneButton.ImageIndex = ((int)(resources.GetObject("dt_startDate.Calendar.NoneButton.ImageIndex")));
            this.dt_startDate.Calendar.NoneButton.ImageKey = resources.GetString("dt_startDate.Calendar.NoneButton.ImageKey");
            this.dt_startDate.Calendar.NoneButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("dt_startDate.Calendar.NoneButton.ImeMode")));
            this.dt_startDate.Calendar.NoneButton.KeepFocusRectangle = false;
            this.dt_startDate.Calendar.NoneButton.Location = ((System.Drawing.Point)(resources.GetObject("dt_startDate.Calendar.NoneButton.Location")));
            this.dt_startDate.Calendar.NoneButton.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("dt_startDate.Calendar.NoneButton.Margin")));
            this.dt_startDate.Calendar.NoneButton.MaximumSize = ((System.Drawing.Size)(resources.GetObject("dt_startDate.Calendar.NoneButton.MaximumSize")));
            this.dt_startDate.Calendar.NoneButton.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dt_startDate.Calendar.NoneButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("dt_startDate.Calendar.NoneButton.RightToLeft")));
            this.dt_startDate.Calendar.NoneButton.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("dt_startDate.Calendar.NoneButton.TextAlign")));
            this.dt_startDate.Calendar.NoneButton.TextImageRelation = ((System.Windows.Forms.TextImageRelation)(resources.GetObject("dt_startDate.Calendar.NoneButton.TextImageRelation")));
            this.dt_startDate.Calendar.NoneButton.ThemeName = "Metro";
            // 
            // 
            // 
            this.dt_startDate.Calendar.TodayButton.AccessibleDescription = resources.GetString("dt_startDate.Calendar.TodayButton.AccessibleDescription");
            this.dt_startDate.Calendar.TodayButton.AccessibleName = resources.GetString("dt_startDate.Calendar.TodayButton.AccessibleName");
            this.dt_startDate.Calendar.TodayButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("dt_startDate.Calendar.TodayButton.Anchor")));
            this.dt_startDate.Calendar.TodayButton.AutoSize = ((bool)(resources.GetObject("dt_startDate.Calendar.TodayButton.AutoSize")));
            this.dt_startDate.Calendar.TodayButton.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("dt_startDate.Calendar.TodayButton.AutoSizeMode")));
            this.dt_startDate.Calendar.TodayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.dt_startDate.Calendar.TodayButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dt_startDate.Calendar.TodayButton.BackgroundImage")));
            this.dt_startDate.Calendar.TodayButton.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("dt_startDate.Calendar.TodayButton.BackgroundImageLayout")));
            this.dt_startDate.Calendar.TodayButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("dt_startDate.Calendar.TodayButton.Dock")));
            this.dt_startDate.Calendar.TodayButton.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("dt_startDate.Calendar.TodayButton.FlatStyle")));
            this.dt_startDate.Calendar.TodayButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dt_startDate.Calendar.TodayButton.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("dt_startDate.Calendar.TodayButton.ImageAlign")));
            this.dt_startDate.Calendar.TodayButton.ImageIndex = ((int)(resources.GetObject("dt_startDate.Calendar.TodayButton.ImageIndex")));
            this.dt_startDate.Calendar.TodayButton.ImageKey = resources.GetString("dt_startDate.Calendar.TodayButton.ImageKey");
            this.dt_startDate.Calendar.TodayButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("dt_startDate.Calendar.TodayButton.ImeMode")));
            this.dt_startDate.Calendar.TodayButton.KeepFocusRectangle = false;
            this.dt_startDate.Calendar.TodayButton.Location = ((System.Drawing.Point)(resources.GetObject("dt_startDate.Calendar.TodayButton.Location")));
            this.dt_startDate.Calendar.TodayButton.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("dt_startDate.Calendar.TodayButton.Margin")));
            this.dt_startDate.Calendar.TodayButton.MaximumSize = ((System.Drawing.Size)(resources.GetObject("dt_startDate.Calendar.TodayButton.MaximumSize")));
            this.dt_startDate.Calendar.TodayButton.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dt_startDate.Calendar.TodayButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("dt_startDate.Calendar.TodayButton.RightToLeft")));
            this.dt_startDate.Calendar.TodayButton.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("dt_startDate.Calendar.TodayButton.TextAlign")));
            this.dt_startDate.Calendar.TodayButton.TextImageRelation = ((System.Windows.Forms.TextImageRelation)(resources.GetObject("dt_startDate.Calendar.TodayButton.TextImageRelation")));
            this.dt_startDate.Calendar.TodayButton.ThemeName = "Metro";
            this.dt_startDate.CalendarFont = new System.Drawing.Font("Tahoma", 8F);
            this.dt_startDate.CalendarForeColor = System.Drawing.SystemColors.WindowText;
            this.dt_startDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dt_startDate.CalendarSize = new System.Drawing.Size(189, 176);
            this.dt_startDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dt_startDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dt_startDate.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dt_startDate.CustomFormat = "ddd, dd/MM/yyyy";
            this.dt_startDate.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dt_startDate.DataBindings.Add(new System.Windows.Forms.Binding("Style", global::DVLD.Properties.Settings.Default, "DateTimePickerStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dt_startDate.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dt_startDate.DropDownImage = null;
            this.dt_startDate.DropDownNormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dt_startDate.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.dt_startDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_startDate.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.dt_startDate.MinValue = new System.DateTime(((long)(0)));
            this.dt_startDate.Name = "dt_startDate";
            this.dt_startDate.NoneButtonVisible = false;
            this.dt_startDate.ShowCheckBox = false;
            this.dt_startDate.Value = new System.DateTime(2026, 5, 3, 1, 22, 21, 253);
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // chk_includeDetentionHistory
            // 
            resources.ApplyResources(this.chk_includeDetentionHistory, "chk_includeDetentionHistory");
            this.chk_includeDetentionHistory.Checked = true;
            this.chk_includeDetentionHistory.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_includeDetentionHistory.Name = "chk_includeDetentionHistory";
            this.chk_includeDetentionHistory.UseVisualStyleBackColor = true;
            this.chk_includeDetentionHistory.CheckedChanged += new System.EventHandler(this.chk_includeDetentionHistory_CheckedChanged);
            // 
            // chk_includeLicenseInfo
            // 
            resources.ApplyResources(this.chk_includeLicenseInfo, "chk_includeLicenseInfo");
            this.chk_includeLicenseInfo.Checked = true;
            this.chk_includeLicenseInfo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_includeLicenseInfo.Name = "chk_includeLicenseInfo";
            this.chk_includeLicenseInfo.UseVisualStyleBackColor = true;
            this.chk_includeLicenseInfo.CheckedChanged += new System.EventHandler(this.chk_includeLicenseInfo_CheckedChanged);
            // 
            // chk_includeDriverInfo
            // 
            resources.ApplyResources(this.chk_includeDriverInfo, "chk_includeDriverInfo");
            this.chk_includeDriverInfo.Checked = true;
            this.chk_includeDriverInfo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_includeDriverInfo.Name = "chk_includeDriverInfo";
            this.chk_includeDriverInfo.UseVisualStyleBackColor = true;
            this.chk_includeDriverInfo.CheckedChanged += new System.EventHandler(this.chk_includeDriverInfo_CheckedChanged);
            // 
            // btn_print
            // 
            resources.ApplyResources(this.btn_print, "btn_print");
            this.btn_print.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.btn_print.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_print.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_print.Image = global::DVLD.Properties.Resources.Print_32;
            this.btn_print.Name = "btn_print";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_close
            // 
            resources.ApplyResources(this.btn_close, "btn_close");
            this.btn_close.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.btn_close.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btn_close.Image = global::DVLD.Properties.Resources.Close_32;
            this.btn_close.Name = "btn_close";
            this.btn_close.UseVisualStyleBackColor = false;
            // 
            // btn_export
            // 
            resources.ApplyResources(this.btn_export, "btn_export");
            this.btn_export.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.btn_export.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_export.FlatAppearance.BorderSize = 2;
            this.btn_export.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_export.Image = global::DVLD.Properties.Resources.Export_PDF_32;
            this.btn_export.Name = "btn_export";
            this.btn_export.UseVisualStyleBackColor = false;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // Frm_LicenseDetentionReport
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctrl_DocumentExportSettings1);
            this.Controls.Add(this.ctrl_LocalLicenseInfoCardWithFilter1);
            this.Controls.Add(this.label_title);
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("TitleBarColorMode", global::DVLD.Properties.Settings.Default, "TitleBarColorMode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_LicenseDetentionReport";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_dateRange.ResumeLayout(false);
            this.gb_dateRange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_endDate.Calendar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_endDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_startDate.Calendar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_startDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private Licenses.Controls.Ctrl_LocalLicenseInfoCardWithFilter ctrl_LocalLicenseInfoCardWithFilter1;
        private Controls.Ctrl_DocumentExportSettings ctrl_DocumentExportSettings1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_allTime;
        private System.Windows.Forms.RadioButton rb_customRange;
        private System.Windows.Forms.GroupBox gb_dateRange;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv dt_endDate;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv dt_startDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox chk_includeDetentionHistory;
        private System.Windows.Forms.CheckBox chk_includeLicenseInfo;
        private System.Windows.Forms.CheckBox chk_includeDriverInfo;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_export;
    }
}