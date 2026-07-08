namespace DVLD.Tests.Controls {
    partial class Ctrl_ScheduleTest {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ctrl_ScheduleTest));
            this.gb_mainContainer = new System.Windows.Forms.GroupBox();
            this.lbl_cannotUpdate = new System.Windows.Forms.Label();
            this.dtp_testTime = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.label10 = new System.Windows.Forms.Label();
            this.dtp_testDate = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.gb_retakeTestInfo = new System.Windows.Forms.GroupBox();
            this.lbl_totalFees = new Salem.Controls.SalSelectableLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_retakeTestAppFees = new Salem.Controls.SalSelectableLabel();
            this.lbl_retakeAppID = new Salem.Controls.SalSelectableLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_testFees = new Salem.Controls.SalSelectableLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_totalTrials = new Salem.Controls.SalSelectableLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_applicantName = new Salem.Controls.SalSelectableLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_lDLAppID = new Salem.Controls.SalSelectableLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_licenseClass = new Salem.Controls.SalSelectableLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_mainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_testTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_testTime.Calendar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_testDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_testDate.Calendar)).BeginInit();
            this.gb_retakeTestInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_mainContainer
            // 
            this.gb_mainContainer.Controls.Add(this.lbl_cannotUpdate);
            this.gb_mainContainer.Controls.Add(this.dtp_testTime);
            this.gb_mainContainer.Controls.Add(this.label10);
            this.gb_mainContainer.Controls.Add(this.dtp_testDate);
            this.gb_mainContainer.Controls.Add(this.gb_retakeTestInfo);
            this.gb_mainContainer.Controls.Add(this.lbl_testFees);
            this.gb_mainContainer.Controls.Add(this.label6);
            this.gb_mainContainer.Controls.Add(this.label4);
            this.gb_mainContainer.Controls.Add(this.lbl_totalTrials);
            this.gb_mainContainer.Controls.Add(this.label3);
            this.gb_mainContainer.Controls.Add(this.lbl_applicantName);
            this.gb_mainContainer.Controls.Add(this.label2);
            this.gb_mainContainer.Controls.Add(this.lbl_lDLAppID);
            this.gb_mainContainer.Controls.Add(this.label5);
            this.gb_mainContainer.Controls.Add(this.lbl_title);
            this.gb_mainContainer.Controls.Add(this.lbl_licenseClass);
            this.gb_mainContainer.Controls.Add(this.label1);
            this.gb_mainContainer.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.gb_mainContainer, "gb_mainContainer");
            this.gb_mainContainer.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.gb_mainContainer.Name = "gb_mainContainer";
            this.gb_mainContainer.TabStop = false;
            // 
            // lbl_cannotUpdate
            // 
            resources.ApplyResources(this.lbl_cannotUpdate, "lbl_cannotUpdate");
            this.lbl_cannotUpdate.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "StrongForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lbl_cannotUpdate.ForeColor = global::DVLD.Properties.Settings.Default.StrongForeColor;
            this.lbl_cannotUpdate.Name = "lbl_cannotUpdate";
            // 
            // dtp_testTime
            // 
            this.dtp_testTime.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.dtp_testTime.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.dtp_testTime.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.dtp_testTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // 
            // 
            this.dtp_testTime.Calendar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtp_testTime.Calendar.BottomHeight = 6;
            this.dtp_testTime.Calendar.DayNamesColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.dtp_testTime.Calendar.DayNamesFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dtp_testTime.Calendar.DaysColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp_testTime.Calendar.Font = ((System.Drawing.Font)(resources.GetObject("dtp_testTime.Calendar.Font")));
            this.dtp_testTime.Calendar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp_testTime.Calendar.GridBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtp_testTime.Calendar.GridLines = Syncfusion.Windows.Forms.Grid.GridBorderStyle.None;
            this.dtp_testTime.Calendar.HeaderFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.dtp_testTime.Calendar.HeaderStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dtp_testTime.Calendar.HeadForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp_testTime.Calendar.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.dtp_testTime.Calendar.InactiveMonthColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp_testTime.Calendar.Location = ((System.Drawing.Point)(resources.GetObject("dtp_testTime.Calendar.Location")));
            this.dtp_testTime.Calendar.Name = "monthCalendar";
            this.dtp_testTime.Calendar.ScrollButtonSize = new System.Drawing.Size(24, 24);
            this.dtp_testTime.Calendar.Size = ((System.Drawing.Size)(resources.GetObject("dtp_testTime.Calendar.Size")));
            this.dtp_testTime.Calendar.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.dtp_testTime.Calendar.TabIndex = ((int)(resources.GetObject("dtp_testTime.Calendar.TabIndex")));
            // 
            // 
            // 
            this.dtp_testTime.Calendar.NoneButton.AutoSize = ((bool)(resources.GetObject("dtp_testTime.Calendar.NoneButton.AutoSize")));
            this.dtp_testTime.Calendar.NoneButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp_testTime.Calendar.NoneButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("dtp_testTime.Calendar.NoneButton.ImeMode")));
            this.dtp_testTime.Calendar.NoneButton.KeepFocusRectangle = false;
            this.dtp_testTime.Calendar.NoneButton.Location = ((System.Drawing.Point)(resources.GetObject("dtp_testTime.Calendar.NoneButton.Location")));
            this.dtp_testTime.Calendar.NoneButton.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("dtp_testTime.Calendar.NoneButton.Margin")));
            this.dtp_testTime.Calendar.NoneButton.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtp_testTime.Calendar.NoneButton.ThemeName = "Metro";
            // 
            // 
            // 
            this.dtp_testTime.Calendar.TodayButton.AutoSize = ((bool)(resources.GetObject("dtp_testTime.Calendar.TodayButton.AutoSize")));
            this.dtp_testTime.Calendar.TodayButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp_testTime.Calendar.TodayButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("dtp_testTime.Calendar.TodayButton.ImeMode")));
            this.dtp_testTime.Calendar.TodayButton.KeepFocusRectangle = false;
            this.dtp_testTime.Calendar.TodayButton.Location = ((System.Drawing.Point)(resources.GetObject("dtp_testTime.Calendar.TodayButton.Location")));
            this.dtp_testTime.Calendar.TodayButton.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("dtp_testTime.Calendar.TodayButton.Margin")));
            this.dtp_testTime.Calendar.TodayButton.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtp_testTime.Calendar.TodayButton.ThemeName = "Metro";
            this.dtp_testTime.CalendarFont = new System.Drawing.Font("Tahoma", 8F);
            this.dtp_testTime.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtp_testTime.CalendarSize = new System.Drawing.Size(189, 176);
            this.dtp_testTime.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dtp_testTime.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp_testTime.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp_testTime.CustomFormat = "h:mm tt";
            this.dtp_testTime.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dtp_testTime.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dtp_testTime.DataBindings.Add(new System.Windows.Forms.Binding("Style", global::DVLD.Properties.Settings.Default, "DateTimePickerStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dtp_testTime.DropDownImage = null;
            this.dtp_testTime.DropDownNormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.dtp_testTime, "dtp_testTime");
            this.dtp_testTime.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.dtp_testTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_testTime.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.dtp_testTime.MinValue = new System.DateTime(((long)(0)));
            this.dtp_testTime.Name = "dtp_testTime";
            this.dtp_testTime.ShowCheckBox = false;
            this.dtp_testTime.ShowDropButton = false;
            this.dtp_testTime.ShowUpDown = true;
            this.dtp_testTime.Style = global::DVLD.Properties.Settings.Default.DateTimePickerStyle;
            this.dtp_testTime.Value = new System.DateTime(2026, 5, 3, 1, 22, 20, 331);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Image = global::DVLD.Properties.Resources.Time_32;
            this.label10.Name = "label10";
            // 
            // dtp_testDate
            // 
            this.dtp_testDate.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.dtp_testDate.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.dtp_testDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.dtp_testDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // 
            // 
            this.dtp_testDate.Calendar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtp_testDate.Calendar.BottomHeight = 6;
            this.dtp_testDate.Calendar.DayNamesColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.dtp_testDate.Calendar.DayNamesFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dtp_testDate.Calendar.DaysColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp_testDate.Calendar.Font = ((System.Drawing.Font)(resources.GetObject("dtp_testDate.Calendar.Font")));
            this.dtp_testDate.Calendar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dtp_testDate.Calendar.GridBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtp_testDate.Calendar.GridLines = Syncfusion.Windows.Forms.Grid.GridBorderStyle.None;
            this.dtp_testDate.Calendar.HeaderFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.dtp_testDate.Calendar.HeaderStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dtp_testDate.Calendar.HeadForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp_testDate.Calendar.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.dtp_testDate.Calendar.InactiveMonthColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp_testDate.Calendar.Location = ((System.Drawing.Point)(resources.GetObject("dtp_testDate.Calendar.Location")));
            this.dtp_testDate.Calendar.Name = "monthCalendar";
            this.dtp_testDate.Calendar.ScrollButtonSize = new System.Drawing.Size(24, 24);
            this.dtp_testDate.Calendar.Size = ((System.Drawing.Size)(resources.GetObject("dtp_testDate.Calendar.Size")));
            this.dtp_testDate.Calendar.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.dtp_testDate.Calendar.TabIndex = ((int)(resources.GetObject("dtp_testDate.Calendar.TabIndex")));
            // 
            // 
            // 
            this.dtp_testDate.Calendar.NoneButton.AutoSize = ((bool)(resources.GetObject("dtp_testDate.Calendar.NoneButton.AutoSize")));
            this.dtp_testDate.Calendar.NoneButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp_testDate.Calendar.NoneButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("dtp_testDate.Calendar.NoneButton.ImeMode")));
            this.dtp_testDate.Calendar.NoneButton.KeepFocusRectangle = false;
            this.dtp_testDate.Calendar.NoneButton.Location = ((System.Drawing.Point)(resources.GetObject("dtp_testDate.Calendar.NoneButton.Location")));
            this.dtp_testDate.Calendar.NoneButton.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("dtp_testDate.Calendar.NoneButton.Margin")));
            this.dtp_testDate.Calendar.NoneButton.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtp_testDate.Calendar.NoneButton.ThemeName = "Metro";
            // 
            // 
            // 
            this.dtp_testDate.Calendar.TodayButton.AutoSize = ((bool)(resources.GetObject("dtp_testDate.Calendar.TodayButton.AutoSize")));
            this.dtp_testDate.Calendar.TodayButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp_testDate.Calendar.TodayButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("dtp_testDate.Calendar.TodayButton.ImeMode")));
            this.dtp_testDate.Calendar.TodayButton.KeepFocusRectangle = false;
            this.dtp_testDate.Calendar.TodayButton.Location = ((System.Drawing.Point)(resources.GetObject("dtp_testDate.Calendar.TodayButton.Location")));
            this.dtp_testDate.Calendar.TodayButton.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("dtp_testDate.Calendar.TodayButton.Margin")));
            this.dtp_testDate.Calendar.TodayButton.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtp_testDate.Calendar.TodayButton.ThemeName = "Metro";
            this.dtp_testDate.CalendarFont = new System.Drawing.Font("Tahoma", 8F);
            this.dtp_testDate.CalendarForeColor = System.Drawing.SystemColors.WindowText;
            this.dtp_testDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtp_testDate.CalendarSize = new System.Drawing.Size(189, 176);
            this.dtp_testDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dtp_testDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp_testDate.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp_testDate.CustomFormat = "ddd, dd/MM/yyyy";
            this.dtp_testDate.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dtp_testDate.DataBindings.Add(new System.Windows.Forms.Binding("Style", global::DVLD.Properties.Settings.Default, "DateTimePickerStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dtp_testDate.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dtp_testDate.DropDownImage = null;
            this.dtp_testDate.DropDownNormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.dtp_testDate, "dtp_testDate");
            this.dtp_testDate.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.dtp_testDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_testDate.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.dtp_testDate.MinValue = new System.DateTime(((long)(0)));
            this.dtp_testDate.Name = "dtp_testDate";
            this.dtp_testDate.NoneButtonVisible = false;
            this.dtp_testDate.ShowCheckBox = false;
            this.dtp_testDate.Style = global::DVLD.Properties.Settings.Default.DateTimePickerStyle;
            this.dtp_testDate.Value = new System.DateTime(2026, 5, 3, 1, 22, 21, 253);
            // 
            // gb_retakeTestInfo
            // 
            resources.ApplyResources(this.gb_retakeTestInfo, "gb_retakeTestInfo");
            this.gb_retakeTestInfo.Controls.Add(this.lbl_totalFees);
            this.gb_retakeTestInfo.Controls.Add(this.label9);
            this.gb_retakeTestInfo.Controls.Add(this.lbl_retakeTestAppFees);
            this.gb_retakeTestInfo.Controls.Add(this.lbl_retakeAppID);
            this.gb_retakeTestInfo.Controls.Add(this.label7);
            this.gb_retakeTestInfo.Controls.Add(this.label8);
            this.gb_retakeTestInfo.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.gb_retakeTestInfo.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.gb_retakeTestInfo.Name = "gb_retakeTestInfo";
            this.gb_retakeTestInfo.TabStop = false;
            // 
            // lbl_totalFees
            // 
            resources.ApplyResources(this.lbl_totalFees, "lbl_totalFees");
            this.lbl_totalFees.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_totalFees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_totalFees.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_totalFees.Name = "lbl_totalFees";
            this.lbl_totalFees.ReadOnly = true;
            this.lbl_totalFees.TabStop = false;
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Image = global::DVLD.Properties.Resources.money_32;
            this.label9.Name = "label9";
            // 
            // lbl_retakeTestAppFees
            // 
            resources.ApplyResources(this.lbl_retakeTestAppFees, "lbl_retakeTestAppFees");
            this.lbl_retakeTestAppFees.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_retakeTestAppFees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_retakeTestAppFees.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_retakeTestAppFees.Name = "lbl_retakeTestAppFees";
            this.lbl_retakeTestAppFees.ReadOnly = true;
            this.lbl_retakeTestAppFees.TabStop = false;
            // 
            // lbl_retakeAppID
            // 
            resources.ApplyResources(this.lbl_retakeAppID, "lbl_retakeAppID");
            this.lbl_retakeAppID.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_retakeAppID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_retakeAppID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_retakeAppID.Name = "lbl_retakeAppID";
            this.lbl_retakeAppID.ReadOnly = true;
            this.lbl_retakeAppID.TabStop = false;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Image = global::DVLD.Properties.Resources.Number_32;
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Image = global::DVLD.Properties.Resources.money_32;
            this.label8.Name = "label8";
            // 
            // lbl_testFees
            // 
            resources.ApplyResources(this.lbl_testFees, "lbl_testFees");
            this.lbl_testFees.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_testFees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_testFees.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_testFees.Name = "lbl_testFees";
            this.lbl_testFees.ReadOnly = true;
            this.lbl_testFees.TabStop = false;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Image = global::DVLD.Properties.Resources.money_32;
            this.label6.Name = "label6";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Image = global::DVLD.Properties.Resources.Calendar_32;
            this.label4.Name = "label4";
            // 
            // lbl_totalTrials
            // 
            resources.ApplyResources(this.lbl_totalTrials, "lbl_totalTrials");
            this.lbl_totalTrials.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_totalTrials.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_totalTrials.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_totalTrials.Name = "lbl_totalTrials";
            this.lbl_totalTrials.ReadOnly = true;
            this.lbl_totalTrials.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Image = global::DVLD.Properties.Resources.Count_32;
            this.label3.Name = "label3";
            // 
            // lbl_applicantName
            // 
            resources.ApplyResources(this.lbl_applicantName, "lbl_applicantName");
            this.lbl_applicantName.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_applicantName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_applicantName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_applicantName.Name = "lbl_applicantName";
            this.lbl_applicantName.ReadOnly = true;
            this.lbl_applicantName.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Image = global::DVLD.Properties.Resources.Person_32;
            this.label2.Name = "label2";
            // 
            // lbl_lDLAppID
            // 
            resources.ApplyResources(this.lbl_lDLAppID, "lbl_lDLAppID");
            this.lbl_lDLAppID.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_lDLAppID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_lDLAppID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_lDLAppID.Name = "lbl_lDLAppID";
            this.lbl_lDLAppID.ReadOnly = true;
            this.lbl_lDLAppID.TabStop = false;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Image = global::DVLD.Properties.Resources.Number_32;
            this.label5.Name = "label5";
            // 
            // lbl_title
            // 
            this.lbl_title.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "AccentForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.lbl_title, "lbl_title");
            this.lbl_title.ForeColor = global::DVLD.Properties.Settings.Default.AccentForeColor;
            this.lbl_title.Image = global::DVLD.Properties.Resources.Question_70;
            this.lbl_title.Name = "lbl_title";
            // 
            // lbl_licenseClass
            // 
            resources.ApplyResources(this.lbl_licenseClass, "lbl_licenseClass");
            this.lbl_licenseClass.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_licenseClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_licenseClass.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_licenseClass.Name = "lbl_licenseClass";
            this.lbl_licenseClass.ReadOnly = true;
            this.lbl_licenseClass.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Image = global::DVLD.Properties.Resources.License_Type_32;
            this.label1.Name = "label1";
            // 
            // Ctrl_ScheduleTest
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gb_mainContainer);
            this.Name = "Ctrl_ScheduleTest";
            this.gb_mainContainer.ResumeLayout(false);
            this.gb_mainContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_testTime.Calendar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_testTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_testDate.Calendar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_testDate)).EndInit();
            this.gb_retakeTestInfo.ResumeLayout(false);
            this.gb_retakeTestInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_mainContainer;
        private System.Windows.Forms.Label lbl_cannotUpdate;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv dtp_testTime;
        private System.Windows.Forms.Label label10;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv dtp_testDate;
        private System.Windows.Forms.GroupBox gb_retakeTestInfo;
        private Salem.Controls.SalSelectableLabel lbl_totalFees;
        private System.Windows.Forms.Label label9;
        private Salem.Controls.SalSelectableLabel lbl_retakeTestAppFees;
        private System.Windows.Forms.Label label8;
        private Salem.Controls.SalSelectableLabel lbl_retakeAppID;
        private System.Windows.Forms.Label label7;
        private Salem.Controls.SalSelectableLabel lbl_testFees;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private Salem.Controls.SalSelectableLabel lbl_totalTrials;
        private System.Windows.Forms.Label label3;
        private Salem.Controls.SalSelectableLabel lbl_applicantName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Salem.Controls.SalSelectableLabel lbl_lDLAppID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_title;
        private Salem.Controls.SalSelectableLabel lbl_licenseClass;
    }
}
