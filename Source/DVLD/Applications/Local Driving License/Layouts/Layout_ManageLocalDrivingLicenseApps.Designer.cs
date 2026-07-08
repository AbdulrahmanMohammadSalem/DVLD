namespace DVLD.Applications.Local_Driving_License.Layouts {
    partial class Layout_ManageLocalDrivingLicenseApps {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Layout_ManageLocalDrivingLicenseApps));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ll_refreshData = new System.Windows.Forms.LinkLabel();
            this.label_numOfRecords = new Salem.Controls.SalSelectableLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_localDrivingLicenseApps = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showApplicationDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.newApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.cancelApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.scheduleTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visionTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writtenTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drivingTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.issueDrivingLicenseFirstTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iceToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonTestsHistoryToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cb_inputFilterBy = new System.Windows.Forms.ComboBox();
            this.cb_filterBy = new Salem.Controls.SalDropDownList();
            this.lbl_filterBy = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_addNewLocalDrivingLicenseApp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ll_exportData = new System.Windows.Forms.LinkLabel();
            this.lbl_noDataAvailable = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_localDrivingLicenseApps)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ll_refreshData
            // 
            resources.ApplyResources(this.ll_refreshData, "ll_refreshData");
            this.ll_refreshData.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ll_refreshData.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ll_refreshData.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.ll_refreshData.Name = "ll_refreshData";
            this.ll_refreshData.TabStop = true;
            this.toolTip1.SetToolTip(this.ll_refreshData, resources.GetString("ll_refreshData.ToolTip"));
            this.ll_refreshData.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_refreshData_LinkClicked);
            // 
            // label_numOfRecords
            // 
            resources.ApplyResources(this.label_numOfRecords, "label_numOfRecords");
            this.label_numOfRecords.BackColor = System.Drawing.SystemColors.Control;
            this.label_numOfRecords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_numOfRecords.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label_numOfRecords.Name = "label_numOfRecords";
            this.label_numOfRecords.ReadOnly = true;
            this.label_numOfRecords.TabStop = false;
            this.toolTip1.SetToolTip(this.label_numOfRecords, resources.GetString("label_numOfRecords.ToolTip"));
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.toolTip1.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
            // 
            // dgv_localDrivingLicenseApps
            // 
            resources.ApplyResources(this.dgv_localDrivingLicenseApps, "dgv_localDrivingLicenseApps");
            this.dgv_localDrivingLicenseApps.AllowUserToAddRows = false;
            this.dgv_localDrivingLicenseApps.AllowUserToDeleteRows = false;
            this.dgv_localDrivingLicenseApps.AllowUserToOrderColumns = true;
            this.dgv_localDrivingLicenseApps.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            this.dgv_localDrivingLicenseApps.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_localDrivingLicenseApps.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_localDrivingLicenseApps.BackgroundColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.dgv_localDrivingLicenseApps.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_localDrivingLicenseApps.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_localDrivingLicenseApps.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_localDrivingLicenseApps.DataBindings.Add(new System.Windows.Forms.Binding("BackgroundColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.NullValue = "[???]";
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_localDrivingLicenseApps.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_localDrivingLicenseApps.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_localDrivingLicenseApps.EnableHeadersVisualStyles = false;
            this.dgv_localDrivingLicenseApps.MultiSelect = false;
            this.dgv_localDrivingLicenseApps.Name = "dgv_localDrivingLicenseApps";
            this.dgv_localDrivingLicenseApps.ReadOnly = true;
            this.dgv_localDrivingLicenseApps.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_localDrivingLicenseApps.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Readex Pro", 7.8F);
            this.dgv_localDrivingLicenseApps.RowTemplate.Height = 26;
            this.dgv_localDrivingLicenseApps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.toolTip1.SetToolTip(this.dgv_localDrivingLicenseApps, resources.GetString("dgv_localDrivingLicenseApps.ToolTip"));
            this.dgv_localDrivingLicenseApps.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_localDrivingLicenseApps_CellDoubleClick);
            this.dgv_localDrivingLicenseApps.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_localDrivingLicenseApps_CellFormatting);
            // 
            // contextMenuStrip1
            // 
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.contextMenuStrip1.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.contextMenuStrip1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.contextMenuStrip1.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showApplicationDetailsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.newApplicationToolStripMenuItem,
            this.editApplicationToolStripMenuItem,
            this.deleteApplicationToolStripMenuItem,
            this.toolStripMenuItem2,
            this.cancelApplicationToolStripMenuItem,
            this.toolStripMenuItem3,
            this.scheduleTestToolStripMenuItem,
            this.toolStripMenuItem4,
            this.issueDrivingLicenseFirstTimeToolStripMenuItem,
            this.toolStripMenuItem5,
            this.showLicenseToolStripMenuItem,
            this.iceToolStripMenuItem,
            this.showPersonLicenseHistoryToolStripMenuItem,
            this.showPersonTestsHistoryToolStripMenuItem6,
            this.toolStripSeparator1,
            this.refreshToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolTip1.SetToolTip(this.contextMenuStrip1, resources.GetString("contextMenuStrip1.ToolTip"));
            this.contextMenuStrip1.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.contextMenuStrip1_Closed);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // showApplicationDetailsToolStripMenuItem
            // 
            resources.ApplyResources(this.showApplicationDetailsToolStripMenuItem, "showApplicationDetailsToolStripMenuItem");
            this.showApplicationDetailsToolStripMenuItem.Image = global::DVLD.Properties.Resources.PersonDetails_32;
            this.showApplicationDetailsToolStripMenuItem.Name = "showApplicationDetailsToolStripMenuItem";
            this.showApplicationDetailsToolStripMenuItem.Click += new System.EventHandler(this.showApplicationDetailsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            // 
            // newApplicationToolStripMenuItem
            // 
            resources.ApplyResources(this.newApplicationToolStripMenuItem, "newApplicationToolStripMenuItem");
            this.newApplicationToolStripMenuItem.Image = global::DVLD.Properties.Resources.New_Application_32;
            this.newApplicationToolStripMenuItem.Name = "newApplicationToolStripMenuItem";
            this.newApplicationToolStripMenuItem.Click += new System.EventHandler(this.newApplicationToolStripMenuItem_Click);
            // 
            // editApplicationToolStripMenuItem
            // 
            resources.ApplyResources(this.editApplicationToolStripMenuItem, "editApplicationToolStripMenuItem");
            this.editApplicationToolStripMenuItem.Image = global::DVLD.Properties.Resources.edit_32;
            this.editApplicationToolStripMenuItem.Name = "editApplicationToolStripMenuItem";
            this.editApplicationToolStripMenuItem.Click += new System.EventHandler(this.editApplicationToolStripMenuItem_Click);
            // 
            // deleteApplicationToolStripMenuItem
            // 
            resources.ApplyResources(this.deleteApplicationToolStripMenuItem, "deleteApplicationToolStripMenuItem");
            this.deleteApplicationToolStripMenuItem.Image = global::DVLD.Properties.Resources.Delete_32_2;
            this.deleteApplicationToolStripMenuItem.Name = "deleteApplicationToolStripMenuItem";
            this.deleteApplicationToolStripMenuItem.Click += new System.EventHandler(this.deleteApplicationToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            this.toolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            // 
            // cancelApplicationToolStripMenuItem
            // 
            resources.ApplyResources(this.cancelApplicationToolStripMenuItem, "cancelApplicationToolStripMenuItem");
            this.cancelApplicationToolStripMenuItem.Image = global::DVLD.Properties.Resources.Delete_32;
            this.cancelApplicationToolStripMenuItem.Name = "cancelApplicationToolStripMenuItem";
            this.cancelApplicationToolStripMenuItem.Click += new System.EventHandler(this.cancelApplicationToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            this.toolStripMenuItem3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            // 
            // scheduleTestToolStripMenuItem
            // 
            resources.ApplyResources(this.scheduleTestToolStripMenuItem, "scheduleTestToolStripMenuItem");
            this.scheduleTestToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visionTestToolStripMenuItem,
            this.writtenTestToolStripMenuItem,
            this.drivingTestToolStripMenuItem});
            this.scheduleTestToolStripMenuItem.Image = global::DVLD.Properties.Resources.Schedule_Test_32;
            this.scheduleTestToolStripMenuItem.Name = "scheduleTestToolStripMenuItem";
            // 
            // visionTestToolStripMenuItem
            // 
            resources.ApplyResources(this.visionTestToolStripMenuItem, "visionTestToolStripMenuItem");
            this.visionTestToolStripMenuItem.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.visionTestToolStripMenuItem.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.visionTestToolStripMenuItem.Image = global::DVLD.Properties.Resources.Vision_Test_32;
            this.visionTestToolStripMenuItem.Name = "visionTestToolStripMenuItem";
            this.visionTestToolStripMenuItem.Tag = "1";
            this.visionTestToolStripMenuItem.Click += new System.EventHandler(this.testAppointmentToolStripMenuItem_Click);
            // 
            // writtenTestToolStripMenuItem
            // 
            resources.ApplyResources(this.writtenTestToolStripMenuItem, "writtenTestToolStripMenuItem");
            this.writtenTestToolStripMenuItem.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.writtenTestToolStripMenuItem.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.writtenTestToolStripMenuItem.Image = global::DVLD.Properties.Resources.Written_Test_32;
            this.writtenTestToolStripMenuItem.Name = "writtenTestToolStripMenuItem";
            this.writtenTestToolStripMenuItem.Tag = "2";
            this.writtenTestToolStripMenuItem.Click += new System.EventHandler(this.testAppointmentToolStripMenuItem_Click);
            // 
            // drivingTestToolStripMenuItem
            // 
            resources.ApplyResources(this.drivingTestToolStripMenuItem, "drivingTestToolStripMenuItem");
            this.drivingTestToolStripMenuItem.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.drivingTestToolStripMenuItem.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.drivingTestToolStripMenuItem.Image = global::DVLD.Properties.Resources.Street_Test_32;
            this.drivingTestToolStripMenuItem.Name = "drivingTestToolStripMenuItem";
            this.drivingTestToolStripMenuItem.Tag = "3";
            this.drivingTestToolStripMenuItem.Click += new System.EventHandler(this.testAppointmentToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            resources.ApplyResources(this.toolStripMenuItem4, "toolStripMenuItem4");
            this.toolStripMenuItem4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            // 
            // issueDrivingLicenseFirstTimeToolStripMenuItem
            // 
            resources.ApplyResources(this.issueDrivingLicenseFirstTimeToolStripMenuItem, "issueDrivingLicenseFirstTimeToolStripMenuItem");
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Image = global::DVLD.Properties.Resources.IssueDrivingLicense_32;
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Name = "issueDrivingLicenseFirstTimeToolStripMenuItem";
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Click += new System.EventHandler(this.issueDrivingLicenseFirstTimeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            resources.ApplyResources(this.toolStripMenuItem5, "toolStripMenuItem5");
            this.toolStripMenuItem5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            // 
            // showLicenseToolStripMenuItem
            // 
            resources.ApplyResources(this.showLicenseToolStripMenuItem, "showLicenseToolStripMenuItem");
            this.showLicenseToolStripMenuItem.Image = global::DVLD.Properties.Resources.License_View_32;
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Click += new System.EventHandler(this.showLicenseToolStripMenuItem_Click);
            // 
            // iceToolStripMenuItem
            // 
            resources.ApplyResources(this.iceToolStripMenuItem, "iceToolStripMenuItem");
            this.iceToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iceToolStripMenuItem.Name = "iceToolStripMenuItem";
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            resources.ApplyResources(this.showPersonLicenseHistoryToolStripMenuItem, "showPersonLicenseHistoryToolStripMenuItem");
            this.showPersonLicenseHistoryToolStripMenuItem.Image = global::DVLD.Properties.Resources.PersonLicenseHistory_32;
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // showPersonTestsHistoryToolStripMenuItem6
            // 
            resources.ApplyResources(this.showPersonTestsHistoryToolStripMenuItem6, "showPersonTestsHistoryToolStripMenuItem6");
            this.showPersonTestsHistoryToolStripMenuItem6.Image = global::DVLD.Properties.Resources.Tests_History_32;
            this.showPersonTestsHistoryToolStripMenuItem6.Name = "showPersonTestsHistoryToolStripMenuItem6";
            this.showPersonTestsHistoryToolStripMenuItem6.Click += new System.EventHandler(this.showPersonTestsHistoryToolStripMenuItem6_Click);
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // refreshToolStripMenuItem
            // 
            resources.ApplyResources(this.refreshToolStripMenuItem, "refreshToolStripMenuItem");
            this.refreshToolStripMenuItem.Image = global::DVLD.Properties.Resources.Refresh_32;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // cb_inputFilterBy
            // 
            resources.ApplyResources(this.cb_inputFilterBy, "cb_inputFilterBy");
            this.cb_inputFilterBy.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.cb_inputFilterBy.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_inputFilterBy.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_inputFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cb_inputFilterBy.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.cb_inputFilterBy.FormattingEnabled = true;
            this.cb_inputFilterBy.Name = "cb_inputFilterBy";
            this.toolTip1.SetToolTip(this.cb_inputFilterBy, resources.GetString("cb_inputFilterBy.ToolTip"));
            this.cb_inputFilterBy.TextChanged += new System.EventHandler(this.comboBox_inputFilterBy_TextChanged);
            // 
            // cb_filterBy
            // 
            resources.ApplyResources(this.cb_filterBy, "cb_filterBy");
            this.cb_filterBy.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.cb_filterBy.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.cb_filterBy.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_filterBy.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_filterBy.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_filterBy.DataBindings.Add(new System.Windows.Forms.Binding("DropDownArrowColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_filterBy.DataBindings.Add(new System.Windows.Forms.Binding("MouseOverBackColor", global::DVLD.Properties.Settings.Default, "SurfaceHoverColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_filterBy.DropDownArrowColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.cb_filterBy.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.cb_filterBy.Items.AddRange(new object[] {
            resources.GetString("cb_filterBy.Items"),
            resources.GetString("cb_filterBy.Items1"),
            resources.GetString("cb_filterBy.Items2"),
            resources.GetString("cb_filterBy.Items3"),
            resources.GetString("cb_filterBy.Items4"),
            resources.GetString("cb_filterBy.Items5"),
            resources.GetString("cb_filterBy.Items6"),
            resources.GetString("cb_filterBy.Items7")});
            this.cb_filterBy.MouseOverBackColor = global::DVLD.Properties.Settings.Default.SurfaceHoverColor;
            this.cb_filterBy.Name = "cb_filterBy";
            this.cb_filterBy.SelectedIndex = -1;
            this.cb_filterBy.TabStop = false;
            this.toolTip1.SetToolTip(this.cb_filterBy, resources.GetString("cb_filterBy.ToolTip"));
            this.cb_filterBy.SelectedIndexChanged += new System.EventHandler(this.comboBox_filterBy_SelectedIndexChanged);
            // 
            // lbl_filterBy
            // 
            resources.ApplyResources(this.lbl_filterBy, "lbl_filterBy");
            this.lbl_filterBy.Name = "lbl_filterBy";
            this.toolTip1.SetToolTip(this.lbl_filterBy, resources.GetString("lbl_filterBy.ToolTip"));
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
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "AccentForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.ForeColor = global::DVLD.Properties.Settings.Default.AccentForeColor;
            this.label1.Name = "label1";
            this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // btn_addNewLocalDrivingLicenseApp
            // 
            resources.ApplyResources(this.btn_addNewLocalDrivingLicenseApp, "btn_addNewLocalDrivingLicenseApp");
            this.btn_addNewLocalDrivingLicenseApp.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.btn_addNewLocalDrivingLicenseApp.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_addNewLocalDrivingLicenseApp.Image = global::DVLD.Properties.Resources.New_Application_40;
            this.btn_addNewLocalDrivingLicenseApp.Name = "btn_addNewLocalDrivingLicenseApp";
            this.toolTip1.SetToolTip(this.btn_addNewLocalDrivingLicenseApp, resources.GetString("btn_addNewLocalDrivingLicenseApp.ToolTip"));
            this.btn_addNewLocalDrivingLicenseApp.UseCompatibleTextRendering = true;
            this.btn_addNewLocalDrivingLicenseApp.UseVisualStyleBackColor = false;
            this.btn_addNewLocalDrivingLicenseApp.Click += new System.EventHandler(this.button_addNewLocalDrivingLicenseApp_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::DVLD.Properties.Resources.Local_Driving_License_512;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, resources.GetString("pictureBox1.ToolTip"));
            // 
            // ll_exportData
            // 
            resources.ApplyResources(this.ll_exportData, "ll_exportData");
            this.ll_exportData.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ll_exportData.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ll_exportData.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.ll_exportData.Name = "ll_exportData";
            this.ll_exportData.TabStop = true;
            this.toolTip1.SetToolTip(this.ll_exportData, resources.GetString("ll_exportData.ToolTip"));
            this.ll_exportData.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_exportData_LinkClicked);
            // 
            // lbl_noDataAvailable
            // 
            resources.ApplyResources(this.lbl_noDataAvailable, "lbl_noDataAvailable");
            this.lbl_noDataAvailable.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "InactiveForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lbl_noDataAvailable.ForeColor = global::DVLD.Properties.Settings.Default.InactiveForeColor;
            this.lbl_noDataAvailable.Name = "lbl_noDataAvailable";
            this.toolTip1.SetToolTip(this.lbl_noDataAvailable, resources.GetString("lbl_noDataAvailable.ToolTip"));
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Image = global::DVLD.Properties.Resources.Local_64;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, resources.GetString("pictureBox2.ToolTip"));
            // 
            // Layout_ManageLocalDrivingLicenseApps
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.Controls.Add(this.ll_exportData);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbl_noDataAvailable);
            this.Controls.Add(this.label_numOfRecords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_localDrivingLicenseApps);
            this.Controls.Add(this.cb_inputFilterBy);
            this.Controls.Add(this.cb_filterBy);
            this.Controls.Add(this.lbl_filterBy);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_addNewLocalDrivingLicenseApp);
            this.Controls.Add(this.ll_refreshData);
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.Name = "Layout_ManageLocalDrivingLicenseApps";
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.Load += new System.EventHandler(this.Layout_ManageLocalDrivingLicenseApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_localDrivingLicenseApps)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel ll_refreshData;
        private Salem.Controls.SalSelectableLabel label_numOfRecords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_addNewLocalDrivingLicenseApp;
        private System.Windows.Forms.DataGridView dgv_localDrivingLicenseApps;
        private System.Windows.Forms.ComboBox cb_inputFilterBy;
        private Salem.Controls.SalDropDownList cb_filterBy;
        private System.Windows.Forms.Label lbl_filterBy;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showApplicationDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cancelApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem scheduleTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visionTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writtenTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drivingTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem issueDrivingLicenseFirstTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator iceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.Label lbl_noDataAvailable;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem showPersonTestsHistoryToolStripMenuItem6;
        private System.Windows.Forms.LinkLabel ll_exportData;
    }
}
