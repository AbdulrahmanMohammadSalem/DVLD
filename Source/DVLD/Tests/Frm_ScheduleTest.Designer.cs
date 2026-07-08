namespace DVLD.Tests {
    partial class Frm_ScheduleTest {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ScheduleTest));
            this.button_close = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.ctrl_ScheduleTest1 = new DVLD.Tests.Controls.Ctrl_ScheduleTest();
            this.SuspendLayout();
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
            // button_save
            // 
            resources.ApplyResources(this.button_save, "button_save");
            this.button_save.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.button_save.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.button_save.Image = global::DVLD.Properties.Resources.Save_32;
            this.button_save.Name = "button_save";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // ctrl_ScheduleTest1
            // 
            this.ctrl_ScheduleTest1.ActiveTestType = DVLD_Business.TestTypes.Unknown;
            resources.ApplyResources(this.ctrl_ScheduleTest1, "ctrl_ScheduleTest1");
            this.ctrl_ScheduleTest1.LocalDrivingLicenseAppID = -1;
            this.ctrl_ScheduleTest1.Name = "ctrl_ScheduleTest1";
            this.ctrl_ScheduleTest1.TestAppointmentID = -1;
            this.ctrl_ScheduleTest1.SaveEnabledChanged += new System.Action(this.ctrl_ScheduleTest1_SaveEnabledChanged);
            this.ctrl_ScheduleTest1.DataSaved += new System.Action(this.ctrl_ScheduleTest1_DataSaved);
            this.ctrl_ScheduleTest1.ForceExit += new System.Action(this.ctrl_ScheduleTest1_ForceExit);
            // 
            // Frm_ScheduleTest
            // 
            this.AcceptButton = this.button_save;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.CancelButton = this.button_close;
            this.Controls.Add(this.ctrl_ScheduleTest1);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_save);
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("TitleBarColorMode", global::DVLD.Properties.Settings.Default, "TitleBarColorMode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ScheduleTest";
            this.TitleBarColorMode = global::DVLD.Properties.Settings.Default.TitleBarColorMode;
            this.Load += new System.EventHandler(this.Frm_ScheduleTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_save;
        private Controls.Ctrl_ScheduleTest ctrl_ScheduleTest1;
    }
}