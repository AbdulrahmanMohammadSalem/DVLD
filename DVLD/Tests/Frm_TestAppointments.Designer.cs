namespace DVLD.Tests {
    partial class Frm_TestAppointments {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_TestAppointments));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.dgv_appointments = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeTest_showTestResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_addNewAppointment = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lbl_appointments = new System.Windows.Forms.Label();
            this.label_numOfRecords = new Salem.Controls.SalSelectableLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel_refreshData = new System.Windows.Forms.LinkLabel();
            this.button_close = new System.Windows.Forms.Button();
            this.lbl_noDataAvailable = new System.Windows.Forms.Label();
            this.ctrl_LocalDrivingLicenseAppInfoCard1 = new DVLD.Applications.Local_Driving_License.Controls.Ctrl_LocalDrivingLicenseAppInfoCard();
            this.ll_exportData = new System.Windows.Forms.LinkLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_appointments)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::DVLD.Properties.Resources.Question_500;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // lbl_title
            // 
            this.lbl_title.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "AccentForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.lbl_title, "lbl_title");
            this.lbl_title.ForeColor = global::DVLD.Properties.Settings.Default.AccentForeColor;
            this.lbl_title.Name = "lbl_title";
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
            this.dgv_appointments.BackgroundColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.dgv_appointments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_appointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_appointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_appointments.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_appointments.DataBindings.Add(new System.Windows.Forms.Binding("BackgroundColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.NullValue = "[???]";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_appointments.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_appointments.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_appointments.EnableHeadersVisualStyles = false;
            this.dgv_appointments.MultiSelect = false;
            this.dgv_appointments.Name = "dgv_appointments";
            this.dgv_appointments.ReadOnly = true;
            this.dgv_appointments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_appointments.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Readex Pro", 7.8F);
            this.dgv_appointments.RowTemplate.Height = 26;
            this.dgv_appointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_appointments.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_appointments_CellDoubleClick);
            this.dgv_appointments.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_appointments_CellFormatting);
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
            this.takeTest_showTestResultToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.contextMenuStrip1_Closed);
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
            this.takeTest_showTestResultToolStripMenuItem.Image = global::DVLD.Properties.Resources.Test_32;
            resources.ApplyResources(this.takeTest_showTestResultToolStripMenuItem, "takeTestToolStripMenuItem");
            this.takeTest_showTestResultToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTest_showTestResultToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
            // 
            // button_addNewAppointment
            // 
            resources.ApplyResources(this.btn_addNewAppointment, "button_addNewAppointment");
            this.btn_addNewAppointment.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.btn_addNewAppointment.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_addNewAppointment.Image = global::DVLD.Properties.Resources.AddAppointment_32;
            this.btn_addNewAppointment.Name = "button_addNewAppointment";
            this.toolTip1.SetToolTip(this.btn_addNewAppointment, resources.GetString("button_addNewAppointment.ToolTip"));
            this.btn_addNewAppointment.UseVisualStyleBackColor = false;
            this.btn_addNewAppointment.Click += new System.EventHandler(this.button_addNewAppointment_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.lbl_appointments, "label4");
            this.lbl_appointments.Name = "label4";
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
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // linkLabel_refreshData
            // 
            resources.ApplyResources(this.linkLabel_refreshData, "linkLabel_refreshData");
            this.linkLabel_refreshData.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.linkLabel_refreshData.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel_refreshData.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.linkLabel_refreshData.Name = "linkLabel_refreshData";
            this.linkLabel_refreshData.TabStop = true;
            this.linkLabel_refreshData.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_refreshData_LinkClicked);
            // 
            // button_close
            // 
            resources.ApplyResources(this.button_close, "button_close");
            this.button_close.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.button_close.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.button_close.Image = global::DVLD.Properties.Resources.Close_32;
            this.button_close.Name = "button_close";
            this.button_close.UseVisualStyleBackColor = false;
            // 
            // label_noDataAvailable
            // 
            resources.ApplyResources(this.lbl_noDataAvailable, "label_noDataAvailable");
            this.lbl_noDataAvailable.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "InactiveForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lbl_noDataAvailable.ForeColor = global::DVLD.Properties.Settings.Default.InactiveForeColor;
            this.lbl_noDataAvailable.Name = "label_noDataAvailable";
            // 
            // ctrl_LocalDrivingLicenseAppInfoCard1
            // 
            resources.ApplyResources(this.ctrl_LocalDrivingLicenseAppInfoCard1, "ctrl_LocalDrivingLicenseAppInfoCard1");
            this.ctrl_LocalDrivingLicenseAppInfoCard1.LocalDrivingLicenseAppID = -1;
            this.ctrl_LocalDrivingLicenseAppInfoCard1.Name = "ctrl_LocalDrivingLicenseAppInfoCard1";
            this.ctrl_LocalDrivingLicenseAppInfoCard1.PersonSaved += new System.Action<int>(this.ctrl_LocalDrivingLicenseAppInfoCard1_PersonSaved);
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
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frm_TestAppointments
            // 
            this.AcceptButton = this.btn_addNewAppointment;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.CancelButton = this.button_close;
            this.Controls.Add(this.ll_exportData);
            this.Controls.Add(this.lbl_noDataAvailable);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.label_numOfRecords);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.linkLabel_refreshData);
            this.Controls.Add(this.lbl_appointments);
            this.Controls.Add(this.btn_addNewAppointment);
            this.Controls.Add(this.dgv_appointments);
            this.Controls.Add(this.ctrl_LocalDrivingLicenseAppInfoCard1);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.pictureBox1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("TitleBarColorMode", global::DVLD.Properties.Settings.Default, "TitleBarColorMode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_TestAppointments";
            this.TitleBarColorMode = global::DVLD.Properties.Settings.Default.TitleBarColorMode;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_TestAppointments_FormClosed);
            this.Load += new System.EventHandler(this.Frm_TestAppointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_appointments)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_title;
        private Applications.Local_Driving_License.Controls.Ctrl_LocalDrivingLicenseAppInfoCard ctrl_LocalDrivingLicenseAppInfoCard1;
        private System.Windows.Forms.DataGridView dgv_appointments;
        private System.Windows.Forms.Button btn_addNewAppointment;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lbl_appointments;
        private Salem.Controls.SalSelectableLabel label_numOfRecords;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel_refreshData;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Label lbl_noDataAvailable;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeTest_showTestResultToolStripMenuItem;
        private System.Windows.Forms.LinkLabel ll_exportData;
        private System.Windows.Forms.Timer timer1;
    }
}