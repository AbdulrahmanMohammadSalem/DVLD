namespace DVLD.Users {
    partial class Frm_AddEditUser {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AddEditUser));
            this.label_title = new System.Windows.Forms.Label();
            this.tabControl1 = new Manina.Windows.Forms.TabControl();
            this.tab_personalInfo = new Manina.Windows.Forms.Tab();
            this.ctrl_PersonCardWithFilter1 = new DVLD.People.Controls.Ctrl_PersonInfoCardWithFilter();
            this.button_next = new System.Windows.Forms.Button();
            this.tab_permissions = new Manina.Windows.Forms.Tab();
            this.pnl_permissions = new System.Windows.Forms.TableLayoutPanel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.ll_applicationSettingsAccess = new System.Windows.Forms.LinkLabel();
            this.cb_applicationSettingsAccess = new Salem.Controls.SalDropDownList();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.ll_lookupTablesManagement = new System.Windows.Forms.LinkLabel();
            this.cb_lookupTablesManagement = new Salem.Controls.SalDropDownList();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.ll_reportsAccess = new System.Windows.Forms.LinkLabel();
            this.cb_reportsAccess = new Salem.Controls.SalDropDownList();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.ll_dashboardAccess = new System.Windows.Forms.LinkLabel();
            this.cb_dashboardAccess = new Salem.Controls.SalDropDownList();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.ll_licenseDetentionManagement = new System.Windows.Forms.LinkLabel();
            this.cb_licenseDetentionManagement = new Salem.Controls.SalDropDownList();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.ll_licensesManagement = new System.Windows.Forms.LinkLabel();
            this.cb_licensesManagement = new Salem.Controls.SalDropDownList();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.ll_testsManagement = new System.Windows.Forms.LinkLabel();
            this.cb_testsManagement = new Salem.Controls.SalDropDownList();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.ll_interLicenseAppsManagement = new System.Windows.Forms.LinkLabel();
            this.cb_interLicenseAppsManagement = new Salem.Controls.SalDropDownList();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.ll_localLicenseAppsManagement = new System.Windows.Forms.LinkLabel();
            this.cb_localLicenseAppsManagement = new Salem.Controls.SalDropDownList();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.ll_driversManagement = new System.Windows.Forms.LinkLabel();
            this.cb_driversManagement = new Salem.Controls.SalDropDownList();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.ll_usersManagement = new System.Windows.Forms.LinkLabel();
            this.cb_usersManagement = new Salem.Controls.SalDropDownList();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ll_peopleManagement = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_peopleManagement = new Salem.Controls.SalDropDownList();
            this.tab_loginInfo = new Manina.Windows.Forms.Tab();
            this.pnl_loginInfoFields = new System.Windows.Forms.Panel();
            this.chk_isActive = new System.Windows.Forms.CheckBox();
            this.lbl_userID = new Salem.Controls.SalSelectableLabel();
            this.txt_username = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lbl_username = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_password = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.textBox_confirmPassword = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_close = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tab_personalInfo.SuspendLayout();
            this.tab_permissions.SuspendLayout();
            this.pnl_permissions.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tab_loginInfo.SuspendLayout();
            this.pnl_loginInfoFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_confirmPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_title
            // 
            resources.ApplyResources(this.label_title, "label_title");
            this.label_title.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "AccentForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.label_title, resources.GetString("label_title.Error"));
            this.label_title.ForeColor = global::DVLD.Properties.Settings.Default.AccentForeColor;
            this.errorProvider1.SetIconAlignment(this.label_title, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_title.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label_title, ((int)(resources.GetObject("label_title.IconPadding"))));
            this.label_title.Name = "label_title";
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tab_personalInfo);
            this.tabControl1.Controls.Add(this.tab_permissions);
            this.tabControl1.Controls.Add(this.tab_loginInfo);
            this.errorProvider1.SetError(this.tabControl1, resources.GetString("tabControl1.Error"));
            this.errorProvider1.SetIconAlignment(this.tabControl1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tabControl1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.tabControl1, ((int)(resources.GetObject("tabControl1.IconPadding"))));
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Tabs.Add(this.tab_personalInfo);
            this.tabControl1.Tabs.Add(this.tab_permissions);
            this.tabControl1.Tabs.Add(this.tab_loginInfo);
            this.tabControl1.PageChanged += new System.EventHandler<Manina.Windows.Forms.PageChangedEventArgs>(this.tabControl1_PageChanged);
            // 
            // tab_personalInfo
            // 
            resources.ApplyResources(this.tab_personalInfo, "tab_personalInfo");
            this.tab_personalInfo.BackColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.tab_personalInfo.Controls.Add(this.ctrl_PersonCardWithFilter1);
            this.tab_personalInfo.Controls.Add(this.button_next);
            this.tab_personalInfo.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.tab_personalInfo, resources.GetString("tab_personalInfo.Error"));
            this.errorProvider1.SetIconAlignment(this.tab_personalInfo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tab_personalInfo.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.tab_personalInfo, ((int)(resources.GetObject("tab_personalInfo.IconPadding"))));
            this.tab_personalInfo.Name = "tab_personalInfo";
            // 
            // ctrl_PersonCardWithFilter1
            // 
            resources.ApplyResources(this.ctrl_PersonCardWithFilter1, "ctrl_PersonCardWithFilter1");
            this.ctrl_PersonCardWithFilter1.EnableAddingNewPerson = true;
            this.ctrl_PersonCardWithFilter1.EnableEditingPersonInfo = true;
            this.ctrl_PersonCardWithFilter1.EnableFiltering = true;
            this.errorProvider1.SetError(this.ctrl_PersonCardWithFilter1, resources.GetString("ctrl_PersonCardWithFilter1.Error"));
            this.errorProvider1.SetIconAlignment(this.ctrl_PersonCardWithFilter1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("ctrl_PersonCardWithFilter1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.ctrl_PersonCardWithFilter1, ((int)(resources.GetObject("ctrl_PersonCardWithFilter1.IconPadding"))));
            this.ctrl_PersonCardWithFilter1.Name = "ctrl_PersonCardWithFilter1";
            this.ctrl_PersonCardWithFilter1.PersonFound += new System.Action<int>(this.ctrl_PersonCardWithFilter1_PersonFound);
            this.ctrl_PersonCardWithFilter1.PersonNotFound += new System.Action(this.ctrl_PersonCardWithFilter1_PersonNotFound);
            this.ctrl_PersonCardWithFilter1.PersonSaved += new System.Action<int>(this.ctrl_PersonCardWithFilter1_PersonSaved);
            // 
            // button_next
            // 
            resources.ApplyResources(this.button_next, "button_next");
            this.button_next.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.button_next.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.button_next, resources.GetString("button_next.Error"));
            this.button_next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.errorProvider1.SetIconAlignment(this.button_next, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("button_next.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.button_next, ((int)(resources.GetObject("button_next.IconPadding"))));
            this.button_next.Image = global::DVLD.Properties.Resources.Prev_32;
            this.button_next.Name = "button_next";
            this.button_next.UseVisualStyleBackColor = false;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // tab_permissions
            // 
            resources.ApplyResources(this.tab_permissions, "tab_permissions");
            this.tab_permissions.BackColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.tab_permissions.Controls.Add(this.pnl_permissions);
            this.tab_permissions.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.tab_permissions, resources.GetString("tab_permissions.Error"));
            this.errorProvider1.SetIconAlignment(this.tab_permissions, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tab_permissions.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.tab_permissions, ((int)(resources.GetObject("tab_permissions.IconPadding"))));
            this.tab_permissions.Name = "tab_permissions";
            // 
            // pnl_permissions
            // 
            resources.ApplyResources(this.pnl_permissions, "pnl_permissions");
            this.pnl_permissions.Controls.Add(this.panel12, 1, 5);
            this.pnl_permissions.Controls.Add(this.panel11, 0, 5);
            this.pnl_permissions.Controls.Add(this.panel10, 1, 4);
            this.pnl_permissions.Controls.Add(this.panel9, 0, 4);
            this.pnl_permissions.Controls.Add(this.panel8, 1, 3);
            this.pnl_permissions.Controls.Add(this.panel7, 0, 3);
            this.pnl_permissions.Controls.Add(this.panel6, 1, 2);
            this.pnl_permissions.Controls.Add(this.panel5, 0, 2);
            this.pnl_permissions.Controls.Add(this.panel4, 1, 1);
            this.pnl_permissions.Controls.Add(this.panel3, 0, 1);
            this.pnl_permissions.Controls.Add(this.panel2, 1, 0);
            this.pnl_permissions.Controls.Add(this.panel1, 0, 0);
            this.errorProvider1.SetError(this.pnl_permissions, resources.GetString("pnl_permissions.Error"));
            this.errorProvider1.SetIconAlignment(this.pnl_permissions, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pnl_permissions.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.pnl_permissions, ((int)(resources.GetObject("pnl_permissions.IconPadding"))));
            this.pnl_permissions.Name = "pnl_permissions";
            // 
            // panel12
            // 
            resources.ApplyResources(this.panel12, "panel12");
            this.panel12.Controls.Add(this.label16);
            this.panel12.Controls.Add(this.ll_applicationSettingsAccess);
            this.panel12.Controls.Add(this.cb_applicationSettingsAccess);
            this.errorProvider1.SetError(this.panel12, resources.GetString("panel12.Error"));
            this.errorProvider1.SetIconAlignment(this.panel12, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel12.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.panel12, ((int)(resources.GetObject("panel12.IconPadding"))));
            this.panel12.Name = "panel12";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.errorProvider1.SetError(this.label16, resources.GetString("label16.Error"));
            this.errorProvider1.SetIconAlignment(this.label16, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label16.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label16, ((int)(resources.GetObject("label16.IconPadding"))));
            this.label16.Name = "label16";
            // 
            // ll_applicationSettingsAccess
            // 
            resources.ApplyResources(this.ll_applicationSettingsAccess, "ll_applicationSettingsAccess");
            this.ll_applicationSettingsAccess.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.ll_applicationSettingsAccess, resources.GetString("ll_applicationSettingsAccess.Error"));
            this.ll_applicationSettingsAccess.ForeColor = System.Drawing.Color.Blue;
            this.errorProvider1.SetIconAlignment(this.ll_applicationSettingsAccess, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("ll_applicationSettingsAccess.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.ll_applicationSettingsAccess, ((int)(resources.GetObject("ll_applicationSettingsAccess.IconPadding"))));
            this.ll_applicationSettingsAccess.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ll_applicationSettingsAccess.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.ll_applicationSettingsAccess.Name = "ll_applicationSettingsAccess";
            this.ll_applicationSettingsAccess.TabStop = true;
            this.ll_applicationSettingsAccess.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_applicationSettingsAccess_LinkClicked);
            // 
            // cb_applicationSettingsAccess
            // 
            resources.ApplyResources(this.cb_applicationSettingsAccess, "cb_applicationSettingsAccess");
            this.cb_applicationSettingsAccess.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.cb_applicationSettingsAccess.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.cb_applicationSettingsAccess.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_applicationSettingsAccess.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_applicationSettingsAccess.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_applicationSettingsAccess.DataBindings.Add(new System.Windows.Forms.Binding("MouseOverBackColor", global::DVLD.Properties.Settings.Default, "SurfaceHoverColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_applicationSettingsAccess.DataBindings.Add(new System.Windows.Forms.Binding("DropDownArrowColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_applicationSettingsAccess.DropDownArrowColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetError(this.cb_applicationSettingsAccess, resources.GetString("cb_applicationSettingsAccess.Error"));
            this.cb_applicationSettingsAccess.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetIconAlignment(this.cb_applicationSettingsAccess, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cb_applicationSettingsAccess.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.cb_applicationSettingsAccess, ((int)(resources.GetObject("cb_applicationSettingsAccess.IconPadding"))));
            this.cb_applicationSettingsAccess.Items.AddRange(new object[] {
            resources.GetString("cb_applicationSettingsAccess.Items"),
            resources.GetString("cb_applicationSettingsAccess.Items1"),
            resources.GetString("cb_applicationSettingsAccess.Items2")});
            this.cb_applicationSettingsAccess.MouseOverBackColor = global::DVLD.Properties.Settings.Default.SurfaceHoverColor;
            this.cb_applicationSettingsAccess.Name = "cb_applicationSettingsAccess";
            this.cb_applicationSettingsAccess.SelectedIndex = 0;
            this.cb_applicationSettingsAccess.TabStop = false;
            this.cb_applicationSettingsAccess.SelectedIndexChanged += new System.EventHandler(this.cb_applicationSettingsAccess_SelectedIndexChanged);
            // 
            // panel11
            // 
            resources.ApplyResources(this.panel11, "panel11");
            this.panel11.Controls.Add(this.label15);
            this.panel11.Controls.Add(this.ll_lookupTablesManagement);
            this.panel11.Controls.Add(this.cb_lookupTablesManagement);
            this.errorProvider1.SetError(this.panel11, resources.GetString("panel11.Error"));
            this.errorProvider1.SetIconAlignment(this.panel11, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel11.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.panel11, ((int)(resources.GetObject("panel11.IconPadding"))));
            this.panel11.Name = "panel11";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.errorProvider1.SetError(this.label15, resources.GetString("label15.Error"));
            this.errorProvider1.SetIconAlignment(this.label15, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label15.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label15, ((int)(resources.GetObject("label15.IconPadding"))));
            this.label15.Name = "label15";
            // 
            // ll_lookupTablesManagement
            // 
            resources.ApplyResources(this.ll_lookupTablesManagement, "ll_lookupTablesManagement");
            this.ll_lookupTablesManagement.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.ll_lookupTablesManagement, resources.GetString("ll_lookupTablesManagement.Error"));
            this.ll_lookupTablesManagement.ForeColor = System.Drawing.Color.Blue;
            this.errorProvider1.SetIconAlignment(this.ll_lookupTablesManagement, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("ll_lookupTablesManagement.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.ll_lookupTablesManagement, ((int)(resources.GetObject("ll_lookupTablesManagement.IconPadding"))));
            this.ll_lookupTablesManagement.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ll_lookupTablesManagement.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.ll_lookupTablesManagement.Name = "ll_lookupTablesManagement";
            this.ll_lookupTablesManagement.TabStop = true;
            this.ll_lookupTablesManagement.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_lookupTablesManagement_LinkClicked);
            // 
            // cb_lookupTablesManagement
            // 
            resources.ApplyResources(this.cb_lookupTablesManagement, "cb_lookupTablesManagement");
            this.cb_lookupTablesManagement.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.cb_lookupTablesManagement.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.cb_lookupTablesManagement.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_lookupTablesManagement.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_lookupTablesManagement.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_lookupTablesManagement.DataBindings.Add(new System.Windows.Forms.Binding("MouseOverBackColor", global::DVLD.Properties.Settings.Default, "SurfaceHoverColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_lookupTablesManagement.DataBindings.Add(new System.Windows.Forms.Binding("DropDownArrowColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_lookupTablesManagement.DropDownArrowColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetError(this.cb_lookupTablesManagement, resources.GetString("cb_lookupTablesManagement.Error"));
            this.cb_lookupTablesManagement.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetIconAlignment(this.cb_lookupTablesManagement, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cb_lookupTablesManagement.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.cb_lookupTablesManagement, ((int)(resources.GetObject("cb_lookupTablesManagement.IconPadding"))));
            this.cb_lookupTablesManagement.Items.AddRange(new object[] {
            resources.GetString("cb_lookupTablesManagement.Items"),
            resources.GetString("cb_lookupTablesManagement.Items1"),
            resources.GetString("cb_lookupTablesManagement.Items2")});
            this.cb_lookupTablesManagement.MouseOverBackColor = global::DVLD.Properties.Settings.Default.SurfaceHoverColor;
            this.cb_lookupTablesManagement.Name = "cb_lookupTablesManagement";
            this.cb_lookupTablesManagement.SelectedIndex = 0;
            this.cb_lookupTablesManagement.TabStop = false;
            this.cb_lookupTablesManagement.SelectedIndexChanged += new System.EventHandler(this.cb_lookupTablesManagement_SelectedIndexChanged);
            // 
            // panel10
            // 
            resources.ApplyResources(this.panel10, "panel10");
            this.panel10.Controls.Add(this.label14);
            this.panel10.Controls.Add(this.ll_reportsAccess);
            this.panel10.Controls.Add(this.cb_reportsAccess);
            this.errorProvider1.SetError(this.panel10, resources.GetString("panel10.Error"));
            this.errorProvider1.SetIconAlignment(this.panel10, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel10.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.panel10, ((int)(resources.GetObject("panel10.IconPadding"))));
            this.panel10.Name = "panel10";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.errorProvider1.SetError(this.label14, resources.GetString("label14.Error"));
            this.errorProvider1.SetIconAlignment(this.label14, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label14.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label14, ((int)(resources.GetObject("label14.IconPadding"))));
            this.label14.Name = "label14";
            // 
            // ll_reportsAccess
            // 
            resources.ApplyResources(this.ll_reportsAccess, "ll_reportsAccess");
            this.ll_reportsAccess.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.ll_reportsAccess, resources.GetString("ll_reportsAccess.Error"));
            this.ll_reportsAccess.ForeColor = System.Drawing.Color.Blue;
            this.errorProvider1.SetIconAlignment(this.ll_reportsAccess, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("ll_reportsAccess.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.ll_reportsAccess, ((int)(resources.GetObject("ll_reportsAccess.IconPadding"))));
            this.ll_reportsAccess.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ll_reportsAccess.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.ll_reportsAccess.Name = "ll_reportsAccess";
            this.ll_reportsAccess.TabStop = true;
            this.ll_reportsAccess.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_reportsAccess_LinkClicked);
            // 
            // cb_reportsAccess
            // 
            resources.ApplyResources(this.cb_reportsAccess, "cb_reportsAccess");
            this.cb_reportsAccess.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.cb_reportsAccess.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.cb_reportsAccess.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_reportsAccess.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_reportsAccess.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_reportsAccess.DataBindings.Add(new System.Windows.Forms.Binding("MouseOverBackColor", global::DVLD.Properties.Settings.Default, "SurfaceHoverColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_reportsAccess.DataBindings.Add(new System.Windows.Forms.Binding("DropDownArrowColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_reportsAccess.DropDownArrowColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetError(this.cb_reportsAccess, resources.GetString("cb_reportsAccess.Error"));
            this.cb_reportsAccess.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetIconAlignment(this.cb_reportsAccess, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cb_reportsAccess.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.cb_reportsAccess, ((int)(resources.GetObject("cb_reportsAccess.IconPadding"))));
            this.cb_reportsAccess.Items.AddRange(new object[] {
            resources.GetString("cb_reportsAccess.Items"),
            resources.GetString("cb_reportsAccess.Items1"),
            resources.GetString("cb_reportsAccess.Items2")});
            this.cb_reportsAccess.MouseOverBackColor = global::DVLD.Properties.Settings.Default.SurfaceHoverColor;
            this.cb_reportsAccess.Name = "cb_reportsAccess";
            this.cb_reportsAccess.SelectedIndex = 0;
            this.cb_reportsAccess.TabStop = false;
            this.cb_reportsAccess.SelectedIndexChanged += new System.EventHandler(this.cb_reportsAccess_SelectedIndexChanged);
            // 
            // panel9
            // 
            resources.ApplyResources(this.panel9, "panel9");
            this.panel9.Controls.Add(this.label13);
            this.panel9.Controls.Add(this.ll_dashboardAccess);
            this.panel9.Controls.Add(this.cb_dashboardAccess);
            this.errorProvider1.SetError(this.panel9, resources.GetString("panel9.Error"));
            this.errorProvider1.SetIconAlignment(this.panel9, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel9.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.panel9, ((int)(resources.GetObject("panel9.IconPadding"))));
            this.panel9.Name = "panel9";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.errorProvider1.SetError(this.label13, resources.GetString("label13.Error"));
            this.errorProvider1.SetIconAlignment(this.label13, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label13.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label13, ((int)(resources.GetObject("label13.IconPadding"))));
            this.label13.Name = "label13";
            // 
            // ll_dashboardAccess
            // 
            resources.ApplyResources(this.ll_dashboardAccess, "ll_dashboardAccess");
            this.ll_dashboardAccess.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.ll_dashboardAccess, resources.GetString("ll_dashboardAccess.Error"));
            this.ll_dashboardAccess.ForeColor = System.Drawing.Color.Blue;
            this.errorProvider1.SetIconAlignment(this.ll_dashboardAccess, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("ll_dashboardAccess.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.ll_dashboardAccess, ((int)(resources.GetObject("ll_dashboardAccess.IconPadding"))));
            this.ll_dashboardAccess.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ll_dashboardAccess.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.ll_dashboardAccess.Name = "ll_dashboardAccess";
            this.ll_dashboardAccess.TabStop = true;
            this.ll_dashboardAccess.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_dashboardAccess_LinkClicked);
            // 
            // cb_dashboardAccess
            // 
            resources.ApplyResources(this.cb_dashboardAccess, "cb_dashboardAccess");
            this.cb_dashboardAccess.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.cb_dashboardAccess.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.cb_dashboardAccess.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_dashboardAccess.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_dashboardAccess.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_dashboardAccess.DataBindings.Add(new System.Windows.Forms.Binding("MouseOverBackColor", global::DVLD.Properties.Settings.Default, "SurfaceHoverColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_dashboardAccess.DataBindings.Add(new System.Windows.Forms.Binding("DropDownArrowColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_dashboardAccess.DropDownArrowColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetError(this.cb_dashboardAccess, resources.GetString("cb_dashboardAccess.Error"));
            this.cb_dashboardAccess.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetIconAlignment(this.cb_dashboardAccess, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cb_dashboardAccess.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.cb_dashboardAccess, ((int)(resources.GetObject("cb_dashboardAccess.IconPadding"))));
            this.cb_dashboardAccess.Items.AddRange(new object[] {
            resources.GetString("cb_dashboardAccess.Items"),
            resources.GetString("cb_dashboardAccess.Items1"),
            resources.GetString("cb_dashboardAccess.Items2")});
            this.cb_dashboardAccess.MouseOverBackColor = global::DVLD.Properties.Settings.Default.SurfaceHoverColor;
            this.cb_dashboardAccess.Name = "cb_dashboardAccess";
            this.cb_dashboardAccess.SelectedIndex = 0;
            this.cb_dashboardAccess.TabStop = false;
            this.cb_dashboardAccess.SelectedIndexChanged += new System.EventHandler(this.cb_dashboardAccess_SelectedIndexChanged);
            // 
            // panel8
            // 
            resources.ApplyResources(this.panel8, "panel8");
            this.panel8.Controls.Add(this.label12);
            this.panel8.Controls.Add(this.ll_licenseDetentionManagement);
            this.panel8.Controls.Add(this.cb_licenseDetentionManagement);
            this.errorProvider1.SetError(this.panel8, resources.GetString("panel8.Error"));
            this.errorProvider1.SetIconAlignment(this.panel8, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel8.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.panel8, ((int)(resources.GetObject("panel8.IconPadding"))));
            this.panel8.Name = "panel8";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.errorProvider1.SetError(this.label12, resources.GetString("label12.Error"));
            this.errorProvider1.SetIconAlignment(this.label12, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label12.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label12, ((int)(resources.GetObject("label12.IconPadding"))));
            this.label12.Name = "label12";
            // 
            // ll_licenseDetentionManagement
            // 
            resources.ApplyResources(this.ll_licenseDetentionManagement, "ll_licenseDetentionManagement");
            this.ll_licenseDetentionManagement.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.ll_licenseDetentionManagement, resources.GetString("ll_licenseDetentionManagement.Error"));
            this.ll_licenseDetentionManagement.ForeColor = System.Drawing.Color.Blue;
            this.errorProvider1.SetIconAlignment(this.ll_licenseDetentionManagement, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("ll_licenseDetentionManagement.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.ll_licenseDetentionManagement, ((int)(resources.GetObject("ll_licenseDetentionManagement.IconPadding"))));
            this.ll_licenseDetentionManagement.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ll_licenseDetentionManagement.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.ll_licenseDetentionManagement.Name = "ll_licenseDetentionManagement";
            this.ll_licenseDetentionManagement.TabStop = true;
            this.ll_licenseDetentionManagement.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_licenseDetentionManagement_LinkClicked);
            // 
            // cb_licenseDetentionManagement
            // 
            resources.ApplyResources(this.cb_licenseDetentionManagement, "cb_licenseDetentionManagement");
            this.cb_licenseDetentionManagement.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.cb_licenseDetentionManagement.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.cb_licenseDetentionManagement.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_licenseDetentionManagement.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_licenseDetentionManagement.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_licenseDetentionManagement.DataBindings.Add(new System.Windows.Forms.Binding("MouseOverBackColor", global::DVLD.Properties.Settings.Default, "SurfaceHoverColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_licenseDetentionManagement.DataBindings.Add(new System.Windows.Forms.Binding("DropDownArrowColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_licenseDetentionManagement.DropDownArrowColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetError(this.cb_licenseDetentionManagement, resources.GetString("cb_licenseDetentionManagement.Error"));
            this.cb_licenseDetentionManagement.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetIconAlignment(this.cb_licenseDetentionManagement, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cb_licenseDetentionManagement.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.cb_licenseDetentionManagement, ((int)(resources.GetObject("cb_licenseDetentionManagement.IconPadding"))));
            this.cb_licenseDetentionManagement.Items.AddRange(new object[] {
            resources.GetString("cb_licenseDetentionManagement.Items"),
            resources.GetString("cb_licenseDetentionManagement.Items1"),
            resources.GetString("cb_licenseDetentionManagement.Items2")});
            this.cb_licenseDetentionManagement.MouseOverBackColor = global::DVLD.Properties.Settings.Default.SurfaceHoverColor;
            this.cb_licenseDetentionManagement.Name = "cb_licenseDetentionManagement";
            this.cb_licenseDetentionManagement.SelectedIndex = 0;
            this.cb_licenseDetentionManagement.TabStop = false;
            this.cb_licenseDetentionManagement.SelectedIndexChanged += new System.EventHandler(this.cb_licenseDetentionManagement_SelectedIndexChanged);
            // 
            // panel7
            // 
            resources.ApplyResources(this.panel7, "panel7");
            this.panel7.Controls.Add(this.label11);
            this.panel7.Controls.Add(this.ll_licensesManagement);
            this.panel7.Controls.Add(this.cb_licensesManagement);
            this.errorProvider1.SetError(this.panel7, resources.GetString("panel7.Error"));
            this.errorProvider1.SetIconAlignment(this.panel7, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel7.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.panel7, ((int)(resources.GetObject("panel7.IconPadding"))));
            this.panel7.Name = "panel7";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.errorProvider1.SetError(this.label11, resources.GetString("label11.Error"));
            this.errorProvider1.SetIconAlignment(this.label11, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label11.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label11, ((int)(resources.GetObject("label11.IconPadding"))));
            this.label11.Name = "label11";
            // 
            // ll_licensesManagement
            // 
            resources.ApplyResources(this.ll_licensesManagement, "ll_licensesManagement");
            this.ll_licensesManagement.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.ll_licensesManagement, resources.GetString("ll_licensesManagement.Error"));
            this.ll_licensesManagement.ForeColor = System.Drawing.Color.Blue;
            this.errorProvider1.SetIconAlignment(this.ll_licensesManagement, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("ll_licensesManagement.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.ll_licensesManagement, ((int)(resources.GetObject("ll_licensesManagement.IconPadding"))));
            this.ll_licensesManagement.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ll_licensesManagement.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.ll_licensesManagement.Name = "ll_licensesManagement";
            this.ll_licensesManagement.TabStop = true;
            this.ll_licensesManagement.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_licensesManagement_LinkClicked);
            // 
            // cb_licensesManagement
            // 
            resources.ApplyResources(this.cb_licensesManagement, "cb_licensesManagement");
            this.cb_licensesManagement.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.cb_licensesManagement.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.cb_licensesManagement.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_licensesManagement.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_licensesManagement.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_licensesManagement.DataBindings.Add(new System.Windows.Forms.Binding("MouseOverBackColor", global::DVLD.Properties.Settings.Default, "SurfaceHoverColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_licensesManagement.DataBindings.Add(new System.Windows.Forms.Binding("DropDownArrowColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_licensesManagement.DropDownArrowColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetError(this.cb_licensesManagement, resources.GetString("cb_licensesManagement.Error"));
            this.cb_licensesManagement.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetIconAlignment(this.cb_licensesManagement, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cb_licensesManagement.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.cb_licensesManagement, ((int)(resources.GetObject("cb_licensesManagement.IconPadding"))));
            this.cb_licensesManagement.Items.AddRange(new object[] {
            resources.GetString("cb_licensesManagement.Items"),
            resources.GetString("cb_licensesManagement.Items1"),
            resources.GetString("cb_licensesManagement.Items2")});
            this.cb_licensesManagement.MouseOverBackColor = global::DVLD.Properties.Settings.Default.SurfaceHoverColor;
            this.cb_licensesManagement.Name = "cb_licensesManagement";
            this.cb_licensesManagement.SelectedIndex = 0;
            this.cb_licensesManagement.TabStop = false;
            this.cb_licensesManagement.SelectedIndexChanged += new System.EventHandler(this.cb_licensesManagement_SelectedIndexChanged);
            // 
            // panel6
            // 
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.ll_testsManagement);
            this.panel6.Controls.Add(this.cb_testsManagement);
            this.errorProvider1.SetError(this.panel6, resources.GetString("panel6.Error"));
            this.errorProvider1.SetIconAlignment(this.panel6, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel6.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.panel6, ((int)(resources.GetObject("panel6.IconPadding"))));
            this.panel6.Name = "panel6";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.errorProvider1.SetError(this.label10, resources.GetString("label10.Error"));
            this.errorProvider1.SetIconAlignment(this.label10, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label10.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label10, ((int)(resources.GetObject("label10.IconPadding"))));
            this.label10.Name = "label10";
            // 
            // ll_testsManagement
            // 
            resources.ApplyResources(this.ll_testsManagement, "ll_testsManagement");
            this.ll_testsManagement.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.ll_testsManagement, resources.GetString("ll_testsManagement.Error"));
            this.ll_testsManagement.ForeColor = System.Drawing.Color.Blue;
            this.errorProvider1.SetIconAlignment(this.ll_testsManagement, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("ll_testsManagement.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.ll_testsManagement, ((int)(resources.GetObject("ll_testsManagement.IconPadding"))));
            this.ll_testsManagement.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ll_testsManagement.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.ll_testsManagement.Name = "ll_testsManagement";
            this.ll_testsManagement.TabStop = true;
            this.ll_testsManagement.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_testsManagement_LinkClicked);
            // 
            // cb_testsManagement
            // 
            resources.ApplyResources(this.cb_testsManagement, "cb_testsManagement");
            this.cb_testsManagement.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.cb_testsManagement.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.cb_testsManagement.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_testsManagement.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_testsManagement.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_testsManagement.DataBindings.Add(new System.Windows.Forms.Binding("MouseOverBackColor", global::DVLD.Properties.Settings.Default, "SurfaceHoverColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_testsManagement.DataBindings.Add(new System.Windows.Forms.Binding("DropDownArrowColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_testsManagement.DropDownArrowColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetError(this.cb_testsManagement, resources.GetString("cb_testsManagement.Error"));
            this.cb_testsManagement.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetIconAlignment(this.cb_testsManagement, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cb_testsManagement.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.cb_testsManagement, ((int)(resources.GetObject("cb_testsManagement.IconPadding"))));
            this.cb_testsManagement.Items.AddRange(new object[] {
            resources.GetString("cb_testsManagement.Items"),
            resources.GetString("cb_testsManagement.Items1"),
            resources.GetString("cb_testsManagement.Items2")});
            this.cb_testsManagement.MouseOverBackColor = global::DVLD.Properties.Settings.Default.SurfaceHoverColor;
            this.cb_testsManagement.Name = "cb_testsManagement";
            this.cb_testsManagement.SelectedIndex = 0;
            this.cb_testsManagement.TabStop = false;
            this.cb_testsManagement.SelectedIndexChanged += new System.EventHandler(this.cb_testsManagement_SelectedIndexChanged);
            // 
            // panel5
            // 
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.ll_interLicenseAppsManagement);
            this.panel5.Controls.Add(this.cb_interLicenseAppsManagement);
            this.errorProvider1.SetError(this.panel5, resources.GetString("panel5.Error"));
            this.errorProvider1.SetIconAlignment(this.panel5, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel5.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.panel5, ((int)(resources.GetObject("panel5.IconPadding"))));
            this.panel5.Name = "panel5";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.errorProvider1.SetError(this.label9, resources.GetString("label9.Error"));
            this.errorProvider1.SetIconAlignment(this.label9, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label9.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label9, ((int)(resources.GetObject("label9.IconPadding"))));
            this.label9.Name = "label9";
            // 
            // ll_interLicenseAppsManagement
            // 
            resources.ApplyResources(this.ll_interLicenseAppsManagement, "ll_interLicenseAppsManagement");
            this.ll_interLicenseAppsManagement.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.ll_interLicenseAppsManagement, resources.GetString("ll_interLicenseAppsManagement.Error"));
            this.ll_interLicenseAppsManagement.ForeColor = System.Drawing.Color.Blue;
            this.errorProvider1.SetIconAlignment(this.ll_interLicenseAppsManagement, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("ll_interLicenseAppsManagement.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.ll_interLicenseAppsManagement, ((int)(resources.GetObject("ll_interLicenseAppsManagement.IconPadding"))));
            this.ll_interLicenseAppsManagement.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ll_interLicenseAppsManagement.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.ll_interLicenseAppsManagement.Name = "ll_interLicenseAppsManagement";
            this.ll_interLicenseAppsManagement.TabStop = true;
            this.ll_interLicenseAppsManagement.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_interLicenseAppsManagement_LinkClicked);
            // 
            // cb_interLicenseAppsManagement
            // 
            resources.ApplyResources(this.cb_interLicenseAppsManagement, "cb_interLicenseAppsManagement");
            this.cb_interLicenseAppsManagement.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.cb_interLicenseAppsManagement.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.cb_interLicenseAppsManagement.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_interLicenseAppsManagement.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_interLicenseAppsManagement.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_interLicenseAppsManagement.DataBindings.Add(new System.Windows.Forms.Binding("MouseOverBackColor", global::DVLD.Properties.Settings.Default, "SurfaceHoverColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_interLicenseAppsManagement.DataBindings.Add(new System.Windows.Forms.Binding("DropDownArrowColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_interLicenseAppsManagement.DropDownArrowColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetError(this.cb_interLicenseAppsManagement, resources.GetString("cb_interLicenseAppsManagement.Error"));
            this.cb_interLicenseAppsManagement.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetIconAlignment(this.cb_interLicenseAppsManagement, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cb_interLicenseAppsManagement.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.cb_interLicenseAppsManagement, ((int)(resources.GetObject("cb_interLicenseAppsManagement.IconPadding"))));
            this.cb_interLicenseAppsManagement.Items.AddRange(new object[] {
            resources.GetString("cb_interLicenseAppsManagement.Items"),
            resources.GetString("cb_interLicenseAppsManagement.Items1"),
            resources.GetString("cb_interLicenseAppsManagement.Items2")});
            this.cb_interLicenseAppsManagement.MouseOverBackColor = global::DVLD.Properties.Settings.Default.SurfaceHoverColor;
            this.cb_interLicenseAppsManagement.Name = "cb_interLicenseAppsManagement";
            this.cb_interLicenseAppsManagement.SelectedIndex = 0;
            this.cb_interLicenseAppsManagement.TabStop = false;
            this.cb_interLicenseAppsManagement.SelectedIndexChanged += new System.EventHandler(this.cb_interLicenseAppsManagement_SelectedIndexChanged_1);
            // 
            // panel4
            // 
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.ll_localLicenseAppsManagement);
            this.panel4.Controls.Add(this.cb_localLicenseAppsManagement);
            this.errorProvider1.SetError(this.panel4, resources.GetString("panel4.Error"));
            this.errorProvider1.SetIconAlignment(this.panel4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel4.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.panel4, ((int)(resources.GetObject("panel4.IconPadding"))));
            this.panel4.Name = "panel4";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.errorProvider1.SetError(this.label8, resources.GetString("label8.Error"));
            this.errorProvider1.SetIconAlignment(this.label8, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label8.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label8, ((int)(resources.GetObject("label8.IconPadding"))));
            this.label8.Name = "label8";
            // 
            // ll_localLicenseAppsManagement
            // 
            resources.ApplyResources(this.ll_localLicenseAppsManagement, "ll_localLicenseAppsManagement");
            this.ll_localLicenseAppsManagement.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.ll_localLicenseAppsManagement, resources.GetString("ll_localLicenseAppsManagement.Error"));
            this.ll_localLicenseAppsManagement.ForeColor = System.Drawing.Color.Blue;
            this.errorProvider1.SetIconAlignment(this.ll_localLicenseAppsManagement, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("ll_localLicenseAppsManagement.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.ll_localLicenseAppsManagement, ((int)(resources.GetObject("ll_localLicenseAppsManagement.IconPadding"))));
            this.ll_localLicenseAppsManagement.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ll_localLicenseAppsManagement.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.ll_localLicenseAppsManagement.Name = "ll_localLicenseAppsManagement";
            this.ll_localLicenseAppsManagement.TabStop = true;
            this.ll_localLicenseAppsManagement.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_localLicenseAppsManagement_LinkClicked);
            // 
            // cb_localLicenseAppsManagement
            // 
            resources.ApplyResources(this.cb_localLicenseAppsManagement, "cb_localLicenseAppsManagement");
            this.cb_localLicenseAppsManagement.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.cb_localLicenseAppsManagement.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.cb_localLicenseAppsManagement.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_localLicenseAppsManagement.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_localLicenseAppsManagement.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_localLicenseAppsManagement.DataBindings.Add(new System.Windows.Forms.Binding("MouseOverBackColor", global::DVLD.Properties.Settings.Default, "SurfaceHoverColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_localLicenseAppsManagement.DataBindings.Add(new System.Windows.Forms.Binding("DropDownArrowColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_localLicenseAppsManagement.DropDownArrowColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetError(this.cb_localLicenseAppsManagement, resources.GetString("cb_localLicenseAppsManagement.Error"));
            this.cb_localLicenseAppsManagement.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetIconAlignment(this.cb_localLicenseAppsManagement, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cb_localLicenseAppsManagement.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.cb_localLicenseAppsManagement, ((int)(resources.GetObject("cb_localLicenseAppsManagement.IconPadding"))));
            this.cb_localLicenseAppsManagement.Items.AddRange(new object[] {
            resources.GetString("cb_localLicenseAppsManagement.Items"),
            resources.GetString("cb_localLicenseAppsManagement.Items1"),
            resources.GetString("cb_localLicenseAppsManagement.Items2")});
            this.cb_localLicenseAppsManagement.MouseOverBackColor = global::DVLD.Properties.Settings.Default.SurfaceHoverColor;
            this.cb_localLicenseAppsManagement.Name = "cb_localLicenseAppsManagement";
            this.cb_localLicenseAppsManagement.SelectedIndex = 0;
            this.cb_localLicenseAppsManagement.TabStop = false;
            this.cb_localLicenseAppsManagement.SelectedIndexChanged += new System.EventHandler(this.cb_localLicenseAppsManagement_SelectedIndexChanged);
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.ll_driversManagement);
            this.panel3.Controls.Add(this.cb_driversManagement);
            this.errorProvider1.SetError(this.panel3, resources.GetString("panel3.Error"));
            this.errorProvider1.SetIconAlignment(this.panel3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel3.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.panel3, ((int)(resources.GetObject("panel3.IconPadding"))));
            this.panel3.Name = "panel3";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.errorProvider1.SetError(this.label7, resources.GetString("label7.Error"));
            this.errorProvider1.SetIconAlignment(this.label7, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label7.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label7, ((int)(resources.GetObject("label7.IconPadding"))));
            this.label7.Name = "label7";
            // 
            // ll_driversManagement
            // 
            resources.ApplyResources(this.ll_driversManagement, "ll_driversManagement");
            this.ll_driversManagement.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.ll_driversManagement, resources.GetString("ll_driversManagement.Error"));
            this.ll_driversManagement.ForeColor = System.Drawing.Color.Blue;
            this.errorProvider1.SetIconAlignment(this.ll_driversManagement, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("ll_driversManagement.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.ll_driversManagement, ((int)(resources.GetObject("ll_driversManagement.IconPadding"))));
            this.ll_driversManagement.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ll_driversManagement.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.ll_driversManagement.Name = "ll_driversManagement";
            this.ll_driversManagement.TabStop = true;
            this.ll_driversManagement.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_driversManagement_LinkClicked);
            // 
            // cb_driversManagement
            // 
            resources.ApplyResources(this.cb_driversManagement, "cb_driversManagement");
            this.cb_driversManagement.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.cb_driversManagement.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.cb_driversManagement.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_driversManagement.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_driversManagement.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_driversManagement.DataBindings.Add(new System.Windows.Forms.Binding("MouseOverBackColor", global::DVLD.Properties.Settings.Default, "SurfaceHoverColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_driversManagement.DataBindings.Add(new System.Windows.Forms.Binding("DropDownArrowColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_driversManagement.DropDownArrowColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetError(this.cb_driversManagement, resources.GetString("cb_driversManagement.Error"));
            this.cb_driversManagement.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetIconAlignment(this.cb_driversManagement, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cb_driversManagement.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.cb_driversManagement, ((int)(resources.GetObject("cb_driversManagement.IconPadding"))));
            this.cb_driversManagement.Items.AddRange(new object[] {
            resources.GetString("cb_driversManagement.Items"),
            resources.GetString("cb_driversManagement.Items1"),
            resources.GetString("cb_driversManagement.Items2")});
            this.cb_driversManagement.MouseOverBackColor = global::DVLD.Properties.Settings.Default.SurfaceHoverColor;
            this.cb_driversManagement.Name = "cb_driversManagement";
            this.cb_driversManagement.SelectedIndex = 0;
            this.cb_driversManagement.TabStop = false;
            this.cb_driversManagement.SelectedIndexChanged += new System.EventHandler(this.cb_driversManagement_SelectedIndexChanged);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.ll_usersManagement);
            this.panel2.Controls.Add(this.cb_usersManagement);
            this.errorProvider1.SetError(this.panel2, resources.GetString("panel2.Error"));
            this.errorProvider1.SetIconAlignment(this.panel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel2.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.panel2, ((int)(resources.GetObject("panel2.IconPadding"))));
            this.panel2.Name = "panel2";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.errorProvider1.SetError(this.label6, resources.GetString("label6.Error"));
            this.errorProvider1.SetIconAlignment(this.label6, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label6.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label6, ((int)(resources.GetObject("label6.IconPadding"))));
            this.label6.Name = "label6";
            // 
            // ll_usersManagement
            // 
            resources.ApplyResources(this.ll_usersManagement, "ll_usersManagement");
            this.ll_usersManagement.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.ll_usersManagement, resources.GetString("ll_usersManagement.Error"));
            this.ll_usersManagement.ForeColor = System.Drawing.Color.Blue;
            this.errorProvider1.SetIconAlignment(this.ll_usersManagement, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("ll_usersManagement.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.ll_usersManagement, ((int)(resources.GetObject("ll_usersManagement.IconPadding"))));
            this.ll_usersManagement.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ll_usersManagement.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.ll_usersManagement.Name = "ll_usersManagement";
            this.ll_usersManagement.TabStop = true;
            this.ll_usersManagement.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_usersManagement_LinkClicked);
            // 
            // cb_usersManagement
            // 
            resources.ApplyResources(this.cb_usersManagement, "cb_usersManagement");
            this.cb_usersManagement.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.cb_usersManagement.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.cb_usersManagement.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_usersManagement.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_usersManagement.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_usersManagement.DataBindings.Add(new System.Windows.Forms.Binding("MouseOverBackColor", global::DVLD.Properties.Settings.Default, "SurfaceHoverColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_usersManagement.DataBindings.Add(new System.Windows.Forms.Binding("DropDownArrowColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_usersManagement.DropDownArrowColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetError(this.cb_usersManagement, resources.GetString("cb_usersManagement.Error"));
            this.cb_usersManagement.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetIconAlignment(this.cb_usersManagement, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cb_usersManagement.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.cb_usersManagement, ((int)(resources.GetObject("cb_usersManagement.IconPadding"))));
            this.cb_usersManagement.Items.AddRange(new object[] {
            resources.GetString("cb_usersManagement.Items"),
            resources.GetString("cb_usersManagement.Items1"),
            resources.GetString("cb_usersManagement.Items2")});
            this.cb_usersManagement.MouseOverBackColor = global::DVLD.Properties.Settings.Default.SurfaceHoverColor;
            this.cb_usersManagement.Name = "cb_usersManagement";
            this.cb_usersManagement.SelectedIndex = 0;
            this.cb_usersManagement.TabStop = false;
            this.cb_usersManagement.SelectedIndexChanged += new System.EventHandler(this.cb_usersManagement_SelectedIndexChanged);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.ll_peopleManagement);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cb_peopleManagement);
            this.errorProvider1.SetError(this.panel1, resources.GetString("panel1.Error"));
            this.errorProvider1.SetIconAlignment(this.panel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.panel1, ((int)(resources.GetObject("panel1.IconPadding"))));
            this.panel1.Name = "panel1";
            // 
            // ll_peopleManagement
            // 
            resources.ApplyResources(this.ll_peopleManagement, "ll_peopleManagement");
            this.ll_peopleManagement.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.ll_peopleManagement, resources.GetString("ll_peopleManagement.Error"));
            this.ll_peopleManagement.ForeColor = System.Drawing.Color.Blue;
            this.errorProvider1.SetIconAlignment(this.ll_peopleManagement, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("ll_peopleManagement.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.ll_peopleManagement, ((int)(resources.GetObject("ll_peopleManagement.IconPadding"))));
            this.ll_peopleManagement.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ll_peopleManagement.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.ll_peopleManagement.Name = "ll_peopleManagement";
            this.ll_peopleManagement.TabStop = true;
            this.ll_peopleManagement.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_peopleManagement_LinkClicked);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.errorProvider1.SetError(this.label5, resources.GetString("label5.Error"));
            this.errorProvider1.SetIconAlignment(this.label5, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label5.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label5, ((int)(resources.GetObject("label5.IconPadding"))));
            this.label5.Name = "label5";
            // 
            // cb_peopleManagement
            // 
            resources.ApplyResources(this.cb_peopleManagement, "cb_peopleManagement");
            this.cb_peopleManagement.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.cb_peopleManagement.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.cb_peopleManagement.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_peopleManagement.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_peopleManagement.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_peopleManagement.DataBindings.Add(new System.Windows.Forms.Binding("MouseOverBackColor", global::DVLD.Properties.Settings.Default, "SurfaceHoverColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_peopleManagement.DataBindings.Add(new System.Windows.Forms.Binding("DropDownArrowColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_peopleManagement.DropDownArrowColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetError(this.cb_peopleManagement, resources.GetString("cb_peopleManagement.Error"));
            this.cb_peopleManagement.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetIconAlignment(this.cb_peopleManagement, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cb_peopleManagement.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.cb_peopleManagement, ((int)(resources.GetObject("cb_peopleManagement.IconPadding"))));
            this.cb_peopleManagement.Items.AddRange(new object[] {
            resources.GetString("cb_peopleManagement.Items"),
            resources.GetString("cb_peopleManagement.Items1"),
            resources.GetString("cb_peopleManagement.Items2")});
            this.cb_peopleManagement.MouseOverBackColor = global::DVLD.Properties.Settings.Default.SurfaceHoverColor;
            this.cb_peopleManagement.Name = "cb_peopleManagement";
            this.cb_peopleManagement.SelectedIndex = 0;
            this.cb_peopleManagement.TabStop = false;
            this.cb_peopleManagement.SelectedIndexChanged += new System.EventHandler(this.cb_peopleManagement_SelectedIndexChanged);
            // 
            // tab_loginInfo
            // 
            resources.ApplyResources(this.tab_loginInfo, "tab_loginInfo");
            this.tab_loginInfo.BackColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.tab_loginInfo.Controls.Add(this.pnl_loginInfoFields);
            this.tab_loginInfo.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.tab_loginInfo, resources.GetString("tab_loginInfo.Error"));
            this.errorProvider1.SetIconAlignment(this.tab_loginInfo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tab_loginInfo.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.tab_loginInfo, ((int)(resources.GetObject("tab_loginInfo.IconPadding"))));
            this.tab_loginInfo.Name = "tab_loginInfo";
            // 
            // pnl_loginInfoFields
            // 
            resources.ApplyResources(this.pnl_loginInfoFields, "pnl_loginInfoFields");
            this.pnl_loginInfoFields.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_loginInfoFields.Controls.Add(this.chk_isActive);
            this.pnl_loginInfoFields.Controls.Add(this.lbl_userID);
            this.pnl_loginInfoFields.Controls.Add(this.txt_username);
            this.pnl_loginInfoFields.Controls.Add(this.lbl_username);
            this.pnl_loginInfoFields.Controls.Add(this.label3);
            this.pnl_loginInfoFields.Controls.Add(this.textBox_password);
            this.pnl_loginInfoFields.Controls.Add(this.textBox_confirmPassword);
            this.pnl_loginInfoFields.Controls.Add(this.label2);
            this.pnl_loginInfoFields.Controls.Add(this.label4);
            this.errorProvider1.SetError(this.pnl_loginInfoFields, resources.GetString("pnl_loginInfoFields.Error"));
            this.errorProvider1.SetIconAlignment(this.pnl_loginInfoFields, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pnl_loginInfoFields.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.pnl_loginInfoFields, ((int)(resources.GetObject("pnl_loginInfoFields.IconPadding"))));
            this.pnl_loginInfoFields.Name = "pnl_loginInfoFields";
            // 
            // checkBox_isActive
            // 
            resources.ApplyResources(this.chk_isActive, "checkBox_isActive");
            this.chk_isActive.Checked = true;
            this.chk_isActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.errorProvider1.SetError(this.chk_isActive, resources.GetString("checkBox_isActive.Error"));
            this.errorProvider1.SetIconAlignment(this.chk_isActive, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("checkBox_isActive.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.chk_isActive, ((int)(resources.GetObject("checkBox_isActive.IconPadding"))));
            this.chk_isActive.Name = "checkBox_isActive";
            this.chk_isActive.UseVisualStyleBackColor = true;
            // 
            // lbl_userID
            // 
            resources.ApplyResources(this.lbl_userID, "lbl_userID");
            this.lbl_userID.BackColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.lbl_userID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_userID.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.lbl_userID, resources.GetString("lbl_userID.Error"));
            this.lbl_userID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.errorProvider1.SetIconAlignment(this.lbl_userID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lbl_userID.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lbl_userID, ((int)(resources.GetObject("lbl_userID.IconPadding"))));
            this.lbl_userID.Name = "lbl_userID";
            this.lbl_userID.ReadOnly = true;
            this.lbl_userID.TabStop = false;
            // 
            // textBox_username
            // 
            resources.ApplyResources(this.txt_username, "textBox_username");
            this.txt_username.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.txt_username.BeforeTouchSize = new System.Drawing.Size(217, 26);
            this.txt_username.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_username.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_username.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_username.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.txt_username, resources.GetString("textBox_username.Error"));
            this.txt_username.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetIconAlignment(this.txt_username, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_username.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txt_username, ((int)(resources.GetObject("textBox_username.IconPadding"))));
            this.txt_username.Name = "textBox_username";
            this.txt_username.TextChanged += new System.EventHandler(this.textBox_toClearError_TextChanged);
            this.txt_username.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_username_Validating);
            // 
            // label1
            // 
            resources.ApplyResources(this.lbl_username, "label1");
            this.errorProvider1.SetError(this.lbl_username, resources.GetString("label1.Error"));
            this.errorProvider1.SetIconAlignment(this.lbl_username, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lbl_username, ((int)(resources.GetObject("label1.IconPadding"))));
            this.lbl_username.Image = global::DVLD.Properties.Resources.Person_32;
            this.lbl_username.Name = "label1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.errorProvider1.SetError(this.label3, resources.GetString("label3.Error"));
            this.errorProvider1.SetIconAlignment(this.label3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label3.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label3, ((int)(resources.GetObject("label3.IconPadding"))));
            this.label3.Image = global::DVLD.Properties.Resources.Number_32;
            this.label3.Name = "label3";
            // 
            // textBox_password
            // 
            resources.ApplyResources(this.textBox_password, "textBox_password");
            this.textBox_password.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.textBox_password.BeforeTouchSize = new System.Drawing.Size(217, 26);
            this.textBox_password.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.textBox_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_password.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_password.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_password.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.textBox_password, resources.GetString("textBox_password.Error"));
            this.textBox_password.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetIconAlignment(this.textBox_password, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_password.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.textBox_password, ((int)(resources.GetObject("textBox_password.IconPadding"))));
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.TextChanged += new System.EventHandler(this.textBox_toClearError_TextChanged);
            this.textBox_password.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_password_Validating);
            // 
            // textBox_confirmPassword
            // 
            resources.ApplyResources(this.textBox_confirmPassword, "textBox_confirmPassword");
            this.textBox_confirmPassword.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.textBox_confirmPassword.BeforeTouchSize = new System.Drawing.Size(217, 26);
            this.textBox_confirmPassword.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.textBox_confirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_confirmPassword.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_confirmPassword.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_confirmPassword.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.textBox_confirmPassword, resources.GetString("textBox_confirmPassword.Error"));
            this.textBox_confirmPassword.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetIconAlignment(this.textBox_confirmPassword, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_confirmPassword.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.textBox_confirmPassword, ((int)(resources.GetObject("textBox_confirmPassword.IconPadding"))));
            this.textBox_confirmPassword.Name = "textBox_confirmPassword";
            this.textBox_confirmPassword.TextChanged += new System.EventHandler(this.textBox_toClearError_TextChanged);
            this.textBox_confirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_confirmPassword_Validating);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.errorProvider1.SetError(this.label2, resources.GetString("label2.Error"));
            this.errorProvider1.SetIconAlignment(this.label2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label2.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label2, ((int)(resources.GetObject("label2.IconPadding"))));
            this.label2.Image = global::DVLD.Properties.Resources.Number_32;
            this.label2.Name = "label2";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.errorProvider1.SetError(this.label4, resources.GetString("label4.Error"));
            this.errorProvider1.SetIconAlignment(this.label4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label4.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label4, ((int)(resources.GetObject("label4.IconPadding"))));
            this.label4.Image = global::DVLD.Properties.Resources.Number_32;
            this.label4.Name = "label4";
            // 
            // button_close
            // 
            resources.ApplyResources(this.button_close, "button_close");
            this.button_close.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.button_close.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.errorProvider1.SetError(this.button_close, resources.GetString("button_close.Error"));
            this.button_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.errorProvider1.SetIconAlignment(this.button_close, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("button_close.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.button_close, ((int)(resources.GetObject("button_close.IconPadding"))));
            this.button_close.Image = global::DVLD.Properties.Resources.Close_32;
            this.button_close.Name = "button_close";
            this.button_close.UseVisualStyleBackColor = false;
            // 
            // btn_save
            // 
            resources.ApplyResources(this.btn_save, "btn_save");
            this.btn_save.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.btn_save.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.btn_save, resources.GetString("btn_save.Error"));
            this.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.errorProvider1.SetIconAlignment(this.btn_save, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btn_save.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.btn_save, ((int)(resources.GetObject("btn_save.IconPadding"))));
            this.btn_save.Image = global::DVLD.Properties.Resources.Save_32;
            this.btn_save.Name = "btn_save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            resources.ApplyResources(this.errorProvider1, "errorProvider1");
            // 
            // Frm_AddEditUser
            // 
            this.AcceptButton = this.button_next;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.CancelButton = this.button_close;
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label_title);
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("TitleBarColorMode", global::DVLD.Properties.Settings.Default, "TitleBarColorMode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_AddEditUser";
            this.TitleBarColorMode = global::DVLD.Properties.Settings.Default.TitleBarColorMode;
            this.Activated += new System.EventHandler(this.Frm_AddEditUser_Activated);
            this.Load += new System.EventHandler(this.Frm_AddEditUser_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_personalInfo.ResumeLayout(false);
            this.tab_personalInfo.PerformLayout();
            this.tab_permissions.ResumeLayout(false);
            this.pnl_permissions.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tab_loginInfo.ResumeLayout(false);
            this.tab_loginInfo.PerformLayout();
            this.pnl_loginInfoFields.ResumeLayout(false);
            this.pnl_loginInfoFields.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_confirmPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private Manina.Windows.Forms.TabControl tabControl1;
        private Manina.Windows.Forms.Tab tab_personalInfo;
        private Manina.Windows.Forms.Tab tab_loginInfo;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBox_confirmPassword;
        private System.Windows.Forms.Label label2;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBox_password;
        private System.Windows.Forms.Label lbl_username;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txt_username;
        private Salem.Controls.SalSelectableLabel lbl_userID;
        private System.Windows.Forms.Panel pnl_loginInfoFields;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox chk_isActive;
        private People.Controls.Ctrl_PersonInfoCardWithFilter ctrl_PersonCardWithFilter1;
        private Manina.Windows.Forms.Tab tab_permissions;
        private System.Windows.Forms.TableLayoutPanel pnl_permissions;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.LinkLabel ll_applicationSettingsAccess;
        private Salem.Controls.SalDropDownList cb_applicationSettingsAccess;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.LinkLabel ll_lookupTablesManagement;
        private Salem.Controls.SalDropDownList cb_lookupTablesManagement;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.LinkLabel ll_reportsAccess;
        private Salem.Controls.SalDropDownList cb_reportsAccess;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.LinkLabel ll_dashboardAccess;
        private Salem.Controls.SalDropDownList cb_dashboardAccess;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.LinkLabel ll_licenseDetentionManagement;
        private Salem.Controls.SalDropDownList cb_licenseDetentionManagement;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.LinkLabel ll_licensesManagement;
        private Salem.Controls.SalDropDownList cb_licensesManagement;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.LinkLabel ll_testsManagement;
        private Salem.Controls.SalDropDownList cb_testsManagement;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel ll_interLicenseAppsManagement;
        private Salem.Controls.SalDropDownList cb_interLicenseAppsManagement;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel ll_localLicenseAppsManagement;
        private Salem.Controls.SalDropDownList cb_localLicenseAppsManagement;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel ll_driversManagement;
        private Salem.Controls.SalDropDownList cb_driversManagement;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel ll_usersManagement;
        private Salem.Controls.SalDropDownList cb_usersManagement;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel ll_peopleManagement;
        private Salem.Controls.SalDropDownList cb_peopleManagement;
    }
}