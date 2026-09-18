namespace DVLD.Analytics.Dashboard {
    partial class Layout_Dashboard {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Layout_Dashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.flowLayoutPanel1 = new Salem.Controls.SmoothFlowLayoutPanel();
            this.ctrlChart_TotalApplicationsWithTime1 = new DVLD.Analytics.Dashboard.Controls.CtrlChart_TotalApplicationsWithTime();
            this.ctrlChart_NewLocalLicenseAppStatus1 = new DVLD.Analytics.Dashboard.Controls.CtrlChart_NewLocalLicenseAppStatus();
            this.ctrlChart_TestAppointmentsLoad1 = new DVLD.Analytics.Dashboard.Controls.CtrlChart_TestAppointmentsLoad();
            this.ctrlChart_TestTypesPassRates1 = new DVLD.Analytics.Dashboard.Controls.CtrlChart_TestTypesPassRates();
            this.ctrlChart_RevenueByServiceType1 = new DVLD.Analytics.Dashboard.Controls.CtrlChart_RevenueByServiceType();
            this.ctrlChart_RevenueByTestType1 = new DVLD.Analytics.Dashboard.Controls.CtrlChart_RevenueByTestType();
            this.ctrlChart_RevenueByLicenseClass1 = new DVLD.Analytics.Dashboard.Controls.CtrlChart_RevenueByLicenseClass();
            this.ctrlChart_LicenseDetentionFineFees1 = new DVLD.Analytics.Dashboard.Controls.CtrlChart_LicenseDetentionFineFees();
            this.ctrl_SystemWideRevenue1 = new DVLD.Analytics.Dashboard.Controls.Ctrl_SystemWideRevenue();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "AccentForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.ForeColor = global::DVLD.Properties.Settings.Default.AccentForeColor;
            this.label1.Name = "label1";
            this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // btn_close
            // 
            resources.ApplyResources(this.btn_close, "btn_close");
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btn_close.Name = "btn_close";
            this.toolTip1.SetToolTip(this.btn_close, resources.GetString("btn_close.ToolTip"));
            this.btn_close.UseCompatibleTextRendering = true;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Controls.Add(this.ctrlChart_TotalApplicationsWithTime1);
            this.flowLayoutPanel1.Controls.Add(this.ctrlChart_NewLocalLicenseAppStatus1);
            this.flowLayoutPanel1.Controls.Add(this.ctrlChart_TestAppointmentsLoad1);
            this.flowLayoutPanel1.Controls.Add(this.ctrlChart_TestTypesPassRates1);
            this.flowLayoutPanel1.Controls.Add(this.ctrlChart_RevenueByServiceType1);
            this.flowLayoutPanel1.Controls.Add(this.ctrlChart_RevenueByTestType1);
            this.flowLayoutPanel1.Controls.Add(this.ctrlChart_RevenueByLicenseClass1);
            this.flowLayoutPanel1.Controls.Add(this.ctrlChart_LicenseDetentionFineFees1);
            this.flowLayoutPanel1.Controls.Add(this.ctrl_SystemWideRevenue1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.toolTip1.SetToolTip(this.flowLayoutPanel1, resources.GetString("flowLayoutPanel1.ToolTip"));
            // 
            // ctrlChart_TotalApplicationsWithTime1
            // 
            resources.ApplyResources(this.ctrlChart_TotalApplicationsWithTime1, "ctrlChart_TotalApplicationsWithTime1");
            this.ctrlChart_TotalApplicationsWithTime1.BackColor = System.Drawing.SystemColors.Window;
            this.ctrlChart_TotalApplicationsWithTime1.Name = "ctrlChart_TotalApplicationsWithTime1";
            this.toolTip1.SetToolTip(this.ctrlChart_TotalApplicationsWithTime1, resources.GetString("ctrlChart_TotalApplicationsWithTime1.ToolTip"));
            // 
            // ctrlChart_NewLocalLicenseAppStatus1
            // 
            resources.ApplyResources(this.ctrlChart_NewLocalLicenseAppStatus1, "ctrlChart_NewLocalLicenseAppStatus1");
            this.ctrlChart_NewLocalLicenseAppStatus1.BackColor = System.Drawing.SystemColors.Window;
            this.ctrlChart_NewLocalLicenseAppStatus1.Name = "ctrlChart_NewLocalLicenseAppStatus1";
            this.toolTip1.SetToolTip(this.ctrlChart_NewLocalLicenseAppStatus1, resources.GetString("ctrlChart_NewLocalLicenseAppStatus1.ToolTip"));
            // 
            // ctrlChart_TestAppointmentsLoad1
            // 
            resources.ApplyResources(this.ctrlChart_TestAppointmentsLoad1, "ctrlChart_TestAppointmentsLoad1");
            this.ctrlChart_TestAppointmentsLoad1.BackColor = System.Drawing.SystemColors.Window;
            this.ctrlChart_TestAppointmentsLoad1.Name = "ctrlChart_TestAppointmentsLoad1";
            this.toolTip1.SetToolTip(this.ctrlChart_TestAppointmentsLoad1, resources.GetString("ctrlChart_TestAppointmentsLoad1.ToolTip"));
            this.ctrlChart_TestAppointmentsLoad1.DataSaved += new System.Action(this.ctrlChart_DataSaved);
            this.ctrlChart_TestAppointmentsLoad1.ForceExit += new System.Action(this.ctrlChart_ForceExit);
            // 
            // ctrlChart_TestTypesPassRates1
            // 
            resources.ApplyResources(this.ctrlChart_TestTypesPassRates1, "ctrlChart_TestTypesPassRates1");
            this.ctrlChart_TestTypesPassRates1.BackColor = System.Drawing.Color.White;
            this.ctrlChart_TestTypesPassRates1.Name = "ctrlChart_TestTypesPassRates1";
            this.toolTip1.SetToolTip(this.ctrlChart_TestTypesPassRates1, resources.GetString("ctrlChart_TestTypesPassRates1.ToolTip"));
            // 
            // ctrlChart_RevenueByServiceType1
            // 
            resources.ApplyResources(this.ctrlChart_RevenueByServiceType1, "ctrlChart_RevenueByServiceType1");
            this.ctrlChart_RevenueByServiceType1.BackColor = System.Drawing.SystemColors.Window;
            this.ctrlChart_RevenueByServiceType1.Name = "ctrlChart_RevenueByServiceType1";
            this.toolTip1.SetToolTip(this.ctrlChart_RevenueByServiceType1, resources.GetString("ctrlChart_RevenueByServiceType1.ToolTip"));
            // 
            // ctrlChart_RevenueByTestType1
            // 
            resources.ApplyResources(this.ctrlChart_RevenueByTestType1, "ctrlChart_RevenueByTestType1");
            this.ctrlChart_RevenueByTestType1.BackColor = System.Drawing.SystemColors.Window;
            this.ctrlChart_RevenueByTestType1.Name = "ctrlChart_RevenueByTestType1";
            this.toolTip1.SetToolTip(this.ctrlChart_RevenueByTestType1, resources.GetString("ctrlChart_RevenueByTestType1.ToolTip"));
            // 
            // ctrlChart_RevenueByLicenseClass1
            // 
            resources.ApplyResources(this.ctrlChart_RevenueByLicenseClass1, "ctrlChart_RevenueByLicenseClass1");
            this.ctrlChart_RevenueByLicenseClass1.BackColor = System.Drawing.SystemColors.Window;
            this.ctrlChart_RevenueByLicenseClass1.Name = "ctrlChart_RevenueByLicenseClass1";
            this.toolTip1.SetToolTip(this.ctrlChart_RevenueByLicenseClass1, resources.GetString("ctrlChart_RevenueByLicenseClass1.ToolTip"));
            // 
            // ctrlChart_LicenseDetainFineFees1
            // 
            resources.ApplyResources(this.ctrlChart_LicenseDetentionFineFees1, "ctrlChart_LicenseDetainFineFees1");
            this.ctrlChart_LicenseDetentionFineFees1.BackColor = System.Drawing.SystemColors.Window;
            this.ctrlChart_LicenseDetentionFineFees1.Name = "ctrlChart_LicenseDetainFineFees1";
            this.toolTip1.SetToolTip(this.ctrlChart_LicenseDetentionFineFees1, resources.GetString("ctrlChart_LicenseDetainFineFees1.ToolTip"));
            // 
            // ctrl_SystemWideRevenue1
            // 
            resources.ApplyResources(this.ctrl_SystemWideRevenue1, "ctrl_SystemWideRevenue1");
            this.ctrl_SystemWideRevenue1.BackColor = System.Drawing.Color.White;
            this.ctrl_SystemWideRevenue1.Name = "ctrl_SystemWideRevenue1";
            this.toolTip1.SetToolTip(this.ctrl_SystemWideRevenue1, resources.GetString("ctrl_SystemWideRevenue1.ToolTip"));
            // 
            // Layout_Dashboard
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.label1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.Name = "Layout_Dashboard";
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.Load += new System.EventHandler(this.Layout_Dashboard_Load);
            this.Resize += new System.EventHandler(this.Layout_Dashboard_Resize);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.ToolTip toolTip1;
        private Salem.Controls.SmoothFlowLayoutPanel flowLayoutPanel1;
        private Controls.CtrlChart_TotalApplicationsWithTime ctrlChart_TotalApplicationsWithTime1;
        private Controls.CtrlChart_NewLocalLicenseAppStatus ctrlChart_NewLocalLicenseAppStatus1;
        private Controls.CtrlChart_TestTypesPassRates ctrlChart_TestTypesPassRates1;
        private Controls.CtrlChart_RevenueByServiceType ctrlChart_RevenueByServiceType1;
        private Controls.CtrlChart_RevenueByLicenseClass ctrlChart_RevenueByLicenseClass1;
        private Controls.CtrlChart_RevenueByTestType ctrlChart_RevenueByTestType1;
        private Controls.CtrlChart_TestAppointmentsLoad ctrlChart_TestAppointmentsLoad1;
        private Controls.CtrlChart_LicenseDetentionFineFees ctrlChart_LicenseDetentionFineFees1;
        private Controls.Ctrl_SystemWideRevenue ctrl_SystemWideRevenue1;
    }
}
