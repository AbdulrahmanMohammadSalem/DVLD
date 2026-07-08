namespace DVLD.Permissions {
    partial class Frm_TestsManagement {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_TestsManagement));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_vision_seeTestResult = new System.Windows.Forms.CheckBox();
            this.chk_vision_takeTest = new System.Windows.Forms.CheckBox();
            this.chk_vision_updateAppointInfo = new System.Windows.Forms.CheckBox();
            this.chk_vision_exportAppointsData = new System.Windows.Forms.CheckBox();
            this.chk_vision_createNewAppoint = new System.Windows.Forms.CheckBox();
            this.chk_vision_seeAllAppoints = new System.Windows.Forms.CheckBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chk_written_seeTestResult = new System.Windows.Forms.CheckBox();
            this.chk_written_takeTest = new System.Windows.Forms.CheckBox();
            this.chk_written_updateAppointInfo = new System.Windows.Forms.CheckBox();
            this.chk_written_exportAppointsData = new System.Windows.Forms.CheckBox();
            this.chk_written_createNewAppoint = new System.Windows.Forms.CheckBox();
            this.chk_written_seeAllAppoints = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chk_driving_seeTestResult = new System.Windows.Forms.CheckBox();
            this.chk_driving_takeTest = new System.Windows.Forms.CheckBox();
            this.chk_driving_updateAppointInfo = new System.Windows.Forms.CheckBox();
            this.chk_driving_exportAppointsData = new System.Windows.Forms.CheckBox();
            this.chk_driving_createNewAppoint = new System.Windows.Forms.CheckBox();
            this.chk_driving_seeAllAppoints = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.chk_vision_seeTestResult);
            this.groupBox1.Controls.Add(this.chk_vision_takeTest);
            this.groupBox1.Controls.Add(this.chk_vision_updateAppointInfo);
            this.groupBox1.Controls.Add(this.chk_vision_exportAppointsData);
            this.groupBox1.Controls.Add(this.chk_vision_createNewAppoint);
            this.groupBox1.Controls.Add(this.chk_vision_seeAllAppoints);
            this.groupBox1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupBox1.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // chk_vision_seeTestResult
            // 
            resources.ApplyResources(this.chk_vision_seeTestResult, "chk_vision_seeTestResult");
            this.chk_vision_seeTestResult.Name = "chk_vision_seeTestResult";
            this.chk_vision_seeTestResult.UseVisualStyleBackColor = true;
            this.chk_vision_seeTestResult.CheckedChanged += new System.EventHandler(this.chk_vision_seeTestResult_CheckedChanged);
            // 
            // chk_vision_takeTest
            // 
            resources.ApplyResources(this.chk_vision_takeTest, "chk_vision_takeTest");
            this.chk_vision_takeTest.Name = "chk_vision_takeTest";
            this.chk_vision_takeTest.UseVisualStyleBackColor = true;
            this.chk_vision_takeTest.CheckedChanged += new System.EventHandler(this.chk_vision_takeTest_CheckedChanged);
            // 
            // chk_vision_updateAppointInfo
            // 
            resources.ApplyResources(this.chk_vision_updateAppointInfo, "chk_vision_updateAppointInfo");
            this.chk_vision_updateAppointInfo.Name = "chk_vision_updateAppointInfo";
            this.chk_vision_updateAppointInfo.UseVisualStyleBackColor = true;
            this.chk_vision_updateAppointInfo.CheckedChanged += new System.EventHandler(this.chk_vision_updateAppointInfo_CheckedChanged);
            // 
            // chk_vision_exportAppointsData
            // 
            resources.ApplyResources(this.chk_vision_exportAppointsData, "chk_vision_exportAppointsData");
            this.chk_vision_exportAppointsData.Name = "chk_vision_exportAppointsData";
            this.chk_vision_exportAppointsData.UseVisualStyleBackColor = true;
            this.chk_vision_exportAppointsData.CheckedChanged += new System.EventHandler(this.chk_vision_exportAppointsData_CheckedChanged);
            // 
            // chk_vision_createNewAppoint
            // 
            resources.ApplyResources(this.chk_vision_createNewAppoint, "chk_vision_createNewAppoint");
            this.chk_vision_createNewAppoint.Name = "chk_vision_createNewAppoint";
            this.chk_vision_createNewAppoint.UseVisualStyleBackColor = true;
            this.chk_vision_createNewAppoint.CheckedChanged += new System.EventHandler(this.chk_vision_createNewAppoint_CheckedChanged);
            // 
            // chk_vision_seeAllAppoints
            // 
            resources.ApplyResources(this.chk_vision_seeAllAppoints, "chk_vision_seeAllAppoints");
            this.chk_vision_seeAllAppoints.Name = "chk_vision_seeAllAppoints";
            this.chk_vision_seeAllAppoints.UseVisualStyleBackColor = true;
            this.chk_vision_seeAllAppoints.CheckedChanged += new System.EventHandler(this.chk_vision_seeAllAppoints_CheckedChanged);
            // 
            // btn_ok
            // 
            resources.ApplyResources(this.btn_ok, "btn_ok");
            this.btn_ok.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.btn_ok.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.chk_written_seeTestResult);
            this.groupBox2.Controls.Add(this.chk_written_takeTest);
            this.groupBox2.Controls.Add(this.chk_written_updateAppointInfo);
            this.groupBox2.Controls.Add(this.chk_written_exportAppointsData);
            this.groupBox2.Controls.Add(this.chk_written_createNewAppoint);
            this.groupBox2.Controls.Add(this.chk_written_seeAllAppoints);
            this.groupBox2.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupBox2.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // chk_written_seeTestResult
            // 
            resources.ApplyResources(this.chk_written_seeTestResult, "chk_written_seeTestResult");
            this.chk_written_seeTestResult.Name = "chk_written_seeTestResult";
            this.chk_written_seeTestResult.UseVisualStyleBackColor = true;
            this.chk_written_seeTestResult.CheckedChanged += new System.EventHandler(this.chk_written_seeTestResult_CheckedChanged);
            // 
            // chk_written_takeTest
            // 
            resources.ApplyResources(this.chk_written_takeTest, "chk_written_takeTest");
            this.chk_written_takeTest.Name = "chk_written_takeTest";
            this.chk_written_takeTest.UseVisualStyleBackColor = true;
            this.chk_written_takeTest.CheckedChanged += new System.EventHandler(this.chk_written_takeTest_CheckedChanged);
            // 
            // chk_written_updateAppointInfo
            // 
            resources.ApplyResources(this.chk_written_updateAppointInfo, "chk_written_updateAppointInfo");
            this.chk_written_updateAppointInfo.Name = "chk_written_updateAppointInfo";
            this.chk_written_updateAppointInfo.UseVisualStyleBackColor = true;
            this.chk_written_updateAppointInfo.CheckedChanged += new System.EventHandler(this.chk_written_updateAppointInfo_CheckedChanged);
            // 
            // chk_written_exportAppointsData
            // 
            resources.ApplyResources(this.chk_written_exportAppointsData, "chk_written_exportAppointsData");
            this.chk_written_exportAppointsData.Name = "chk_written_exportAppointsData";
            this.chk_written_exportAppointsData.UseVisualStyleBackColor = true;
            this.chk_written_exportAppointsData.CheckedChanged += new System.EventHandler(this.chk_written_exportAppointsData_CheckedChanged);
            // 
            // chk_written_createNewAppoint
            // 
            resources.ApplyResources(this.chk_written_createNewAppoint, "chk_written_createNewAppoint");
            this.chk_written_createNewAppoint.Name = "chk_written_createNewAppoint";
            this.chk_written_createNewAppoint.UseVisualStyleBackColor = true;
            this.chk_written_createNewAppoint.CheckedChanged += new System.EventHandler(this.chk_written_createNewAppoint_CheckedChanged);
            // 
            // chk_written_seeAllAppoints
            // 
            resources.ApplyResources(this.chk_written_seeAllAppoints, "chk_written_seeAllAppoints");
            this.chk_written_seeAllAppoints.Name = "chk_written_seeAllAppoints";
            this.chk_written_seeAllAppoints.UseVisualStyleBackColor = true;
            this.chk_written_seeAllAppoints.CheckedChanged += new System.EventHandler(this.chk_written_seeAllAppoints_CheckedChanged);
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.chk_driving_seeTestResult);
            this.groupBox3.Controls.Add(this.chk_driving_takeTest);
            this.groupBox3.Controls.Add(this.chk_driving_updateAppointInfo);
            this.groupBox3.Controls.Add(this.chk_driving_exportAppointsData);
            this.groupBox3.Controls.Add(this.chk_driving_createNewAppoint);
            this.groupBox3.Controls.Add(this.chk_driving_seeAllAppoints);
            this.groupBox3.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupBox3.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // chk_driving_seeTestResult
            // 
            resources.ApplyResources(this.chk_driving_seeTestResult, "chk_driving_seeTestResult");
            this.chk_driving_seeTestResult.Name = "chk_driving_seeTestResult";
            this.chk_driving_seeTestResult.UseVisualStyleBackColor = true;
            this.chk_driving_seeTestResult.CheckedChanged += new System.EventHandler(this.chk_driving_seeTestResult_CheckedChanged);
            // 
            // chk_driving_takeTest
            // 
            resources.ApplyResources(this.chk_driving_takeTest, "chk_driving_takeTest");
            this.chk_driving_takeTest.Name = "chk_driving_takeTest";
            this.chk_driving_takeTest.UseVisualStyleBackColor = true;
            this.chk_driving_takeTest.CheckedChanged += new System.EventHandler(this.chk_driving_takeTest_CheckedChanged);
            // 
            // chk_driving_updateAppointInfo
            // 
            resources.ApplyResources(this.chk_driving_updateAppointInfo, "chk_driving_updateAppointInfo");
            this.chk_driving_updateAppointInfo.Name = "chk_driving_updateAppointInfo";
            this.chk_driving_updateAppointInfo.UseVisualStyleBackColor = true;
            this.chk_driving_updateAppointInfo.CheckedChanged += new System.EventHandler(this.chk_driving_updateAppointInfo_CheckedChanged);
            // 
            // chk_driving_exportAppointsData
            // 
            resources.ApplyResources(this.chk_driving_exportAppointsData, "chk_driving_exportAppointsData");
            this.chk_driving_exportAppointsData.Name = "chk_driving_exportAppointsData";
            this.chk_driving_exportAppointsData.UseVisualStyleBackColor = true;
            this.chk_driving_exportAppointsData.CheckedChanged += new System.EventHandler(this.chk_driving_exportAppointsData_CheckedChanged);
            // 
            // chk_driving_createNewAppoint
            // 
            resources.ApplyResources(this.chk_driving_createNewAppoint, "chk_driving_createNewAppoint");
            this.chk_driving_createNewAppoint.Name = "chk_driving_createNewAppoint";
            this.chk_driving_createNewAppoint.UseVisualStyleBackColor = true;
            this.chk_driving_createNewAppoint.CheckedChanged += new System.EventHandler(this.chk_driving_createNewAppoint_CheckedChanged);
            // 
            // chk_driving_seeAllAppoints
            // 
            resources.ApplyResources(this.chk_driving_seeAllAppoints, "chk_driving_seeAllAppoints");
            this.chk_driving_seeAllAppoints.Name = "chk_driving_seeAllAppoints";
            this.chk_driving_seeAllAppoints.UseVisualStyleBackColor = true;
            this.chk_driving_seeAllAppoints.CheckedChanged += new System.EventHandler(this.chk_driving_seeAllAppoints_CheckedChanged);
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupBox4.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // Frm_TestsManagement
            // 
            this.AcceptButton = this.btn_ok;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btn_ok);
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("TitleBarColorMode", global::DVLD.Properties.Settings.Default, "TitleBarColorMode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_TestsManagement";
            this.TitleBarColorMode = global::DVLD.Properties.Settings.Default.TitleBarColorMode;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.CheckBox chk_vision_seeAllAppoints;
        private System.Windows.Forms.CheckBox chk_vision_takeTest;
        private System.Windows.Forms.CheckBox chk_vision_updateAppointInfo;
        private System.Windows.Forms.CheckBox chk_vision_exportAppointsData;
        private System.Windows.Forms.CheckBox chk_vision_createNewAppoint;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chk_written_takeTest;
        private System.Windows.Forms.CheckBox chk_written_updateAppointInfo;
        private System.Windows.Forms.CheckBox chk_written_exportAppointsData;
        private System.Windows.Forms.CheckBox chk_written_createNewAppoint;
        private System.Windows.Forms.CheckBox chk_written_seeAllAppoints;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chk_driving_takeTest;
        private System.Windows.Forms.CheckBox chk_driving_updateAppointInfo;
        private System.Windows.Forms.CheckBox chk_driving_exportAppointsData;
        private System.Windows.Forms.CheckBox chk_driving_createNewAppoint;
        private System.Windows.Forms.CheckBox chk_driving_seeAllAppoints;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chk_vision_seeTestResult;
        private System.Windows.Forms.CheckBox chk_written_seeTestResult;
        private System.Windows.Forms.CheckBox chk_driving_seeTestResult;
    }
}