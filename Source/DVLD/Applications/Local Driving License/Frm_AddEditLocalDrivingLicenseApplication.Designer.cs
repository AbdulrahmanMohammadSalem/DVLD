namespace DVLD.Applications.Local_Driving_License {
    partial class Frm_AddEditLocalDrivingLicenseApplication {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AddEditLocalDrivingLicenseApplication));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button_close = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.label_LDLAppID = new Salem.Controls.SalSelectableLabel();
            this.panel_applicationInfoFields = new System.Windows.Forms.Panel();
            this.comboBox_licenseClass = new Salem.Controls.SalDropDownList();
            this.label_applicationFees = new Salem.Controls.SalSelectableLabel();
            this.label_applicationDate = new Salem.Controls.SalSelectableLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_createdBy = new Salem.Controls.SalSelectableLabel();
            this.button_next = new System.Windows.Forms.Button();
            this.tabPage1 = new Manina.Windows.Forms.Tab();
            this.ctrl_PersonCardWithFilter1 = new DVLD.People.Controls.Ctrl_PersonInfoCardWithFilter();
            this.tabControl1 = new Manina.Windows.Forms.TabControl();
            this.tabPage2 = new Manina.Windows.Forms.Tab();
            this.label_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel_applicationInfoFields.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            // label_LDLAppID
            // 
            this.label_LDLAppID.BackColor = System.Drawing.SystemColors.Control;
            this.label_LDLAppID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.label_LDLAppID, "label_LDLAppID");
            this.label_LDLAppID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label_LDLAppID.Name = "label_LDLAppID";
            this.label_LDLAppID.ReadOnly = true;
            this.label_LDLAppID.TabStop = false;
            // 
            // panel_applicationInfoFields
            // 
            resources.ApplyResources(this.panel_applicationInfoFields, "panel_applicationInfoFields");
            this.panel_applicationInfoFields.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_applicationInfoFields.Controls.Add(this.comboBox_licenseClass);
            this.panel_applicationInfoFields.Controls.Add(this.label_applicationFees);
            this.panel_applicationInfoFields.Controls.Add(this.label_applicationDate);
            this.panel_applicationInfoFields.Controls.Add(this.label5);
            this.panel_applicationInfoFields.Controls.Add(this.label1);
            this.panel_applicationInfoFields.Controls.Add(this.label3);
            this.panel_applicationInfoFields.Controls.Add(this.label2);
            this.panel_applicationInfoFields.Controls.Add(this.label4);
            this.panel_applicationInfoFields.Controls.Add(this.label_LDLAppID);
            this.panel_applicationInfoFields.Controls.Add(this.label_createdBy);
            this.panel_applicationInfoFields.Name = "panel_applicationInfoFields";
            // 
            // comboBox_licenseClass
            // 
            this.comboBox_licenseClass.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.comboBox_licenseClass.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.comboBox_licenseClass.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboBox_licenseClass.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboBox_licenseClass.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboBox_licenseClass.DataBindings.Add(new System.Windows.Forms.Binding("DropDownArrowColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboBox_licenseClass.DataBindings.Add(new System.Windows.Forms.Binding("MouseOverBackColor", global::DVLD.Properties.Settings.Default, "SurfaceHoverColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboBox_licenseClass.DropDownArrowColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            resources.ApplyResources(this.comboBox_licenseClass, "comboBox_licenseClass");
            this.comboBox_licenseClass.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.comboBox_licenseClass.MouseOverBackColor = global::DVLD.Properties.Settings.Default.SurfaceHoverColor;
            this.comboBox_licenseClass.Name = "comboBox_licenseClass";
            this.comboBox_licenseClass.SelectedIndex = -1;
            this.comboBox_licenseClass.TabStop = false;
            // 
            // label_applicationFees
            // 
            this.label_applicationFees.BackColor = System.Drawing.SystemColors.Control;
            this.label_applicationFees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.label_applicationFees, "label_applicationFees");
            this.label_applicationFees.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label_applicationFees.Name = "label_applicationFees";
            this.label_applicationFees.ReadOnly = true;
            this.label_applicationFees.TabStop = false;
            // 
            // label_applicationDate
            // 
            this.label_applicationDate.BackColor = System.Drawing.SystemColors.Control;
            this.label_applicationDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.label_applicationDate, "label_applicationDate");
            this.label_applicationDate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label_applicationDate.Name = "label_applicationDate";
            this.label_applicationDate.ReadOnly = true;
            this.label_applicationDate.TabStop = false;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Image = global::DVLD.Properties.Resources.User_32__2;
            this.label5.Name = "label5";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Image = global::DVLD.Properties.Resources.Calendar_32;
            this.label1.Name = "label1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Image = global::DVLD.Properties.Resources.money_32;
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Image = global::DVLD.Properties.Resources.ApplicationTitle;
            this.label2.Name = "label2";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Image = global::DVLD.Properties.Resources.Number_32;
            this.label4.Name = "label4";
            // 
            // label_createdBy
            // 
            this.label_createdBy.BackColor = System.Drawing.SystemColors.Control;
            this.label_createdBy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.label_createdBy, "label_createdBy");
            this.label_createdBy.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label_createdBy.Name = "label_createdBy";
            this.label_createdBy.ReadOnly = true;
            this.label_createdBy.TabStop = false;
            // 
            // button_next
            // 
            resources.ApplyResources(this.button_next, "button_next");
            this.button_next.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.button_next.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button_next.FlatAppearance.BorderSize = 2;
            this.button_next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.button_next.Image = global::DVLD.Properties.Resources.Next_32;
            this.button_next.Name = "button_next";
            this.button_next.UseVisualStyleBackColor = false;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.tabPage1.Controls.Add(this.ctrl_PersonCardWithFilter1);
            this.tabPage1.Controls.Add(this.button_next);
            this.tabPage1.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            // 
            // ctrl_PersonCardWithFilter1
            // 
            resources.ApplyResources(this.ctrl_PersonCardWithFilter1, "ctrl_PersonCardWithFilter1");
            this.ctrl_PersonCardWithFilter1.EnableAddingNewPerson = true;
            this.ctrl_PersonCardWithFilter1.EnableEditingPersonInfo = true;
            this.ctrl_PersonCardWithFilter1.EnableFiltering = true;
            this.ctrl_PersonCardWithFilter1.Name = "ctrl_PersonCardWithFilter1";
            this.ctrl_PersonCardWithFilter1.PersonFound += new System.Action<int>(this.ctrl_PersonCardWithFilter1_PersonFound);
            this.ctrl_PersonCardWithFilter1.PersonNotFound += new System.Action(this.ctrl_PersonCardWithFilter1_PersonNotFound);
            this.ctrl_PersonCardWithFilter1.PersonSaved += new System.Action<int>(this.ctrl_PersonCardWithFilter1_PersonSaved);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Tabs.Add(this.tabPage1);
            this.tabControl1.Tabs.Add(this.tabPage2);
            this.tabControl1.PageChanged += new System.EventHandler<Manina.Windows.Forms.PageChangedEventArgs>(this.tabControl1_PageChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.tabPage2.Controls.Add(this.panel_applicationInfoFields);
            this.tabPage2.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            // 
            // label_title
            // 
            this.label_title.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "AccentForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.label_title, "label_title");
            this.label_title.ForeColor = global::DVLD.Properties.Settings.Default.AccentForeColor;
            this.label_title.Name = "label_title";
            // 
            // Frm_AddEditLocalDrivingLicenseApplication
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.CancelButton = this.button_close;
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label_title);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("TitleBarColorMode", global::DVLD.Properties.Settings.Default, "TitleBarColorMode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_AddEditLocalDrivingLicenseApplication";
            this.TitleBarColorMode = global::DVLD.Properties.Settings.Default.TitleBarColorMode;
            this.Activated += new System.EventHandler(this.Frm_AddEditLocalDrivingLicenseApplication_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_AddEditLocalDrivingLicenseApplication_FormClosed);
            this.Load += new System.EventHandler(this.Frm_AddEditLocalDrivingLicenseApplication_Load);
            this.Shown += new System.EventHandler(this.Frm_AddEditLocalDrivingLicenseApplication_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel_applicationInfoFields.ResumeLayout(false);
            this.panel_applicationInfoFields.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_save;
        private Manina.Windows.Forms.TabControl tabControl1;
        private Manina.Windows.Forms.Tab tabPage1;
        private People.Controls.Ctrl_PersonInfoCardWithFilter ctrl_PersonCardWithFilter1;
        private System.Windows.Forms.Button button_next;
        private Manina.Windows.Forms.Tab tabPage2;
        private System.Windows.Forms.Panel panel_applicationInfoFields;
        private Salem.Controls.SalSelectableLabel label_LDLAppID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_title;
        private Salem.Controls.SalSelectableLabel label_createdBy;
        private System.Windows.Forms.Label label5;
        private Salem.Controls.SalDropDownList comboBox_licenseClass;
        private Salem.Controls.SalSelectableLabel label_applicationFees;
        private Salem.Controls.SalSelectableLabel label_applicationDate;
    }
}