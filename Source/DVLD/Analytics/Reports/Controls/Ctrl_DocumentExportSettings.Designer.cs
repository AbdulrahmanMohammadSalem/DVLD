namespace DVLD.Analytics.Reports.Controls {
    partial class Ctrl_DocumentExportSettings {
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
                Properties.Settings.Default.SettingsSaving -= Default_SettingsSaving;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ctrl_DocumentExportSettings));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_colorful = new System.Windows.Forms.CheckBox();
            this.chk_includeDvldLogo = new System.Windows.Forms.CheckBox();
            this.chk_includeDateTime = new System.Windows.Forms.CheckBox();
            this.chk_openAfterSaving = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb_pageOrientation = new Salem.Controls.SalDropDownList();
            this.cb_vMarginUnit = new Salem.Controls.SalDropDownList();
            this.chk_useCustomPageSize = new System.Windows.Forms.CheckBox();
            this.txt_vMargin = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.cb_pageHeightUnit = new Salem.Controls.SalDropDownList();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_pageHeight = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lbl_pageHeight = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_pageSize = new Salem.Controls.SalDropDownList();
            this.txt_hMargin = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.cb_hMarginUnit = new Salem.Controls.SalDropDownList();
            this.txt_pageWidth = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.cb_pageWidthUnit = new Salem.Controls.SalDropDownList();
            this.lbl_pageWidth = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_preferredFontFamily = new Salem.Controls.SalDropDownEdit();
            this.buttonEdit3 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.btn_browseFolder = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.txt_fullPath = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_fileName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label13 = new System.Windows.Forms.Label();
            this.vistaFolderBrowserDialog1 = new Ookii.Dialogs.WinForms.VistaFolderBrowserDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_vMargin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pageHeight)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_hMargin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pageWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit3)).BeginInit();
            this.buttonEdit3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_fullPath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_fileName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.chk_colorful);
            this.groupBox1.Controls.Add(this.chk_includeDvldLogo);
            this.groupBox1.Controls.Add(this.chk_includeDateTime);
            this.groupBox1.Controls.Add(this.chk_openAfterSaving);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cb_preferredFontFamily);
            this.groupBox1.Controls.Add(this.buttonEdit3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_fileName);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.groupBox1, resources.GetString("groupBox1.Error"));
            this.groupBox1.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetIconAlignment(this.groupBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.groupBox1, ((int)(resources.GetObject("groupBox1.IconPadding"))));
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox1, resources.GetString("groupBox1.ToolTip"));
            // 
            // chk_colorful
            // 
            resources.ApplyResources(this.chk_colorful, "chk_colorful");
            this.chk_colorful.Checked = true;
            this.chk_colorful.CheckState = System.Windows.Forms.CheckState.Checked;
            this.errorProvider1.SetError(this.chk_colorful, resources.GetString("chk_colorful.Error"));
            this.errorProvider1.SetIconAlignment(this.chk_colorful, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("chk_colorful.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.chk_colorful, ((int)(resources.GetObject("chk_colorful.IconPadding"))));
            this.chk_colorful.Name = "chk_colorful";
            this.toolTip1.SetToolTip(this.chk_colorful, resources.GetString("chk_colorful.ToolTip"));
            this.chk_colorful.UseVisualStyleBackColor = true;
            // 
            // chk_includeDvldLogo
            // 
            resources.ApplyResources(this.chk_includeDvldLogo, "chk_includeDvldLogo");
            this.chk_includeDvldLogo.Checked = true;
            this.chk_includeDvldLogo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.errorProvider1.SetError(this.chk_includeDvldLogo, resources.GetString("chk_includeDvldLogo.Error"));
            this.errorProvider1.SetIconAlignment(this.chk_includeDvldLogo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("chk_includeDvldLogo.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.chk_includeDvldLogo, ((int)(resources.GetObject("chk_includeDvldLogo.IconPadding"))));
            this.chk_includeDvldLogo.Name = "chk_includeDvldLogo";
            this.toolTip1.SetToolTip(this.chk_includeDvldLogo, resources.GetString("chk_includeDvldLogo.ToolTip"));
            this.chk_includeDvldLogo.UseVisualStyleBackColor = true;
            // 
            // chk_includeDateTime
            // 
            resources.ApplyResources(this.chk_includeDateTime, "chk_includeDateTime");
            this.chk_includeDateTime.Checked = true;
            this.chk_includeDateTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.errorProvider1.SetError(this.chk_includeDateTime, resources.GetString("chk_includeDateTime.Error"));
            this.errorProvider1.SetIconAlignment(this.chk_includeDateTime, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("chk_includeDateTime.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.chk_includeDateTime, ((int)(resources.GetObject("chk_includeDateTime.IconPadding"))));
            this.chk_includeDateTime.Name = "chk_includeDateTime";
            this.toolTip1.SetToolTip(this.chk_includeDateTime, resources.GetString("chk_includeDateTime.ToolTip"));
            this.chk_includeDateTime.UseVisualStyleBackColor = true;
            // 
            // chk_openAfterSaving
            // 
            resources.ApplyResources(this.chk_openAfterSaving, "chk_openAfterSaving");
            this.chk_openAfterSaving.Checked = true;
            this.chk_openAfterSaving.CheckState = System.Windows.Forms.CheckState.Checked;
            this.errorProvider1.SetError(this.chk_openAfterSaving, resources.GetString("chk_openAfterSaving.Error"));
            this.errorProvider1.SetIconAlignment(this.chk_openAfterSaving, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("chk_openAfterSaving.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.chk_openAfterSaving, ((int)(resources.GetObject("chk_openAfterSaving.IconPadding"))));
            this.chk_openAfterSaving.Name = "chk_openAfterSaving";
            this.toolTip1.SetToolTip(this.chk_openAfterSaving, resources.GetString("chk_openAfterSaving.ToolTip"));
            this.chk_openAfterSaving.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.groupBox2, resources.GetString("groupBox2.Error"));
            this.groupBox2.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetIconAlignment(this.groupBox2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox2.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.groupBox2, ((int)(resources.GetObject("groupBox2.IconPadding"))));
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox2, resources.GetString("groupBox2.ToolTip"));
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.errorProvider1.SetError(this.tableLayoutPanel1, resources.GetString("tableLayoutPanel1.Error"));
            this.errorProvider1.SetIconAlignment(this.tableLayoutPanel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tableLayoutPanel1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.tableLayoutPanel1, ((int)(resources.GetObject("tableLayoutPanel1.IconPadding"))));
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.toolTip1.SetToolTip(this.tableLayoutPanel1, resources.GetString("tableLayoutPanel1.ToolTip"));
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.cb_pageOrientation);
            this.panel2.Controls.Add(this.cb_vMarginUnit);
            this.panel2.Controls.Add(this.chk_useCustomPageSize);
            this.panel2.Controls.Add(this.txt_vMargin);
            this.panel2.Controls.Add(this.cb_pageHeightUnit);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_pageHeight);
            this.panel2.Controls.Add(this.lbl_pageHeight);
            this.errorProvider1.SetError(this.panel2, resources.GetString("panel2.Error"));
            this.errorProvider1.SetIconAlignment(this.panel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel2.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.panel2, ((int)(resources.GetObject("panel2.IconPadding"))));
            this.panel2.Name = "panel2";
            this.toolTip1.SetToolTip(this.panel2, resources.GetString("panel2.ToolTip"));
            // 
            // cb_pageOrientation
            // 
            resources.ApplyResources(this.cb_pageOrientation, "cb_pageOrientation");
            this.cb_pageOrientation.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.cb_pageOrientation.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.cb_pageOrientation.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_pageOrientation.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_pageOrientation.DataBindings.Add(new System.Windows.Forms.Binding("DropDownArrowColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_pageOrientation.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_pageOrientation.DataBindings.Add(new System.Windows.Forms.Binding("MouseOverBackColor", global::DVLD.Properties.Settings.Default, "SurfaceHoverColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_pageOrientation.DropDownArrowColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetError(this.cb_pageOrientation, resources.GetString("cb_pageOrientation.Error"));
            this.cb_pageOrientation.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetIconAlignment(this.cb_pageOrientation, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cb_pageOrientation.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.cb_pageOrientation, ((int)(resources.GetObject("cb_pageOrientation.IconPadding"))));
            this.cb_pageOrientation.Items.AddRange(new object[] {
            resources.GetString("cb_pageOrientation.Items"),
            resources.GetString("cb_pageOrientation.Items1")});
            this.cb_pageOrientation.MouseOverBackColor = global::DVLD.Properties.Settings.Default.SurfaceHoverColor;
            this.cb_pageOrientation.Name = "cb_pageOrientation";
            this.cb_pageOrientation.SelectedIndex = 0;
            this.cb_pageOrientation.TabStop = false;
            this.toolTip1.SetToolTip(this.cb_pageOrientation, resources.GetString("cb_pageOrientation.ToolTip"));
            this.cb_pageOrientation.SelectedIndexChanged += new System.EventHandler(this.cb_pageOrientation_SelectedIndexChanged);
            // 
            // cb_vMarginUnit
            // 
            resources.ApplyResources(this.cb_vMarginUnit, "cb_vMarginUnit");
            this.cb_vMarginUnit.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.cb_vMarginUnit.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.cb_vMarginUnit.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_vMarginUnit.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_vMarginUnit.DataBindings.Add(new System.Windows.Forms.Binding("DropDownArrowColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_vMarginUnit.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_vMarginUnit.DataBindings.Add(new System.Windows.Forms.Binding("MouseOverBackColor", global::DVLD.Properties.Settings.Default, "SurfaceHoverColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_vMarginUnit.DropDownArrowColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetError(this.cb_vMarginUnit, resources.GetString("cb_vMarginUnit.Error"));
            this.cb_vMarginUnit.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetIconAlignment(this.cb_vMarginUnit, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cb_vMarginUnit.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.cb_vMarginUnit, ((int)(resources.GetObject("cb_vMarginUnit.IconPadding"))));
            this.cb_vMarginUnit.Items.AddRange(new object[] {
            resources.GetString("cb_vMarginUnit.Items"),
            resources.GetString("cb_vMarginUnit.Items1"),
            resources.GetString("cb_vMarginUnit.Items2")});
            this.cb_vMarginUnit.MouseOverBackColor = global::DVLD.Properties.Settings.Default.SurfaceHoverColor;
            this.cb_vMarginUnit.Name = "cb_vMarginUnit";
            this.cb_vMarginUnit.SelectedIndex = 0;
            this.cb_vMarginUnit.TabStop = false;
            this.toolTip1.SetToolTip(this.cb_vMarginUnit, resources.GetString("cb_vMarginUnit.ToolTip"));
            // 
            // chk_useCustomPageSize
            // 
            resources.ApplyResources(this.chk_useCustomPageSize, "chk_useCustomPageSize");
            this.errorProvider1.SetError(this.chk_useCustomPageSize, resources.GetString("chk_useCustomPageSize.Error"));
            this.errorProvider1.SetIconAlignment(this.chk_useCustomPageSize, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("chk_useCustomPageSize.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.chk_useCustomPageSize, ((int)(resources.GetObject("chk_useCustomPageSize.IconPadding"))));
            this.chk_useCustomPageSize.Name = "chk_useCustomPageSize";
            this.toolTip1.SetToolTip(this.chk_useCustomPageSize, resources.GetString("chk_useCustomPageSize.ToolTip"));
            this.chk_useCustomPageSize.UseVisualStyleBackColor = true;
            this.chk_useCustomPageSize.CheckedChanged += new System.EventHandler(this.chk_useCustomPageSize_CheckedChanged);
            // 
            // txt_vMargin
            // 
            resources.ApplyResources(this.txt_vMargin, "txt_vMargin");
            this.txt_vMargin.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.txt_vMargin.BeforeTouchSize = new System.Drawing.Size(210, 30);
            this.txt_vMargin.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.txt_vMargin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_vMargin.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_vMargin.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_vMargin.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.txt_vMargin, resources.GetString("txt_vMargin.Error"));
            this.txt_vMargin.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetIconAlignment(this.txt_vMargin, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txt_vMargin.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txt_vMargin, ((int)(resources.GetObject("txt_vMargin.IconPadding"))));
            this.txt_vMargin.Name = "txt_vMargin";
            this.toolTip1.SetToolTip(this.txt_vMargin, resources.GetString("txt_vMargin.ToolTip"));
            this.txt_vMargin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pageDimension_KeyPress);
            // 
            // cb_pageHeightUnit
            // 
            resources.ApplyResources(this.cb_pageHeightUnit, "cb_pageHeightUnit");
            this.cb_pageHeightUnit.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.cb_pageHeightUnit.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.cb_pageHeightUnit.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_pageHeightUnit.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_pageHeightUnit.DataBindings.Add(new System.Windows.Forms.Binding("DropDownArrowColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_pageHeightUnit.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_pageHeightUnit.DataBindings.Add(new System.Windows.Forms.Binding("MouseOverBackColor", global::DVLD.Properties.Settings.Default, "SurfaceHoverColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_pageHeightUnit.DropDownArrowColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetError(this.cb_pageHeightUnit, resources.GetString("cb_pageHeightUnit.Error"));
            this.cb_pageHeightUnit.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetIconAlignment(this.cb_pageHeightUnit, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cb_pageHeightUnit.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.cb_pageHeightUnit, ((int)(resources.GetObject("cb_pageHeightUnit.IconPadding"))));
            this.cb_pageHeightUnit.Items.AddRange(new object[] {
            resources.GetString("cb_pageHeightUnit.Items"),
            resources.GetString("cb_pageHeightUnit.Items1"),
            resources.GetString("cb_pageHeightUnit.Items2")});
            this.cb_pageHeightUnit.MouseOverBackColor = global::DVLD.Properties.Settings.Default.SurfaceHoverColor;
            this.cb_pageHeightUnit.Name = "cb_pageHeightUnit";
            this.cb_pageHeightUnit.SelectedIndex = 0;
            this.cb_pageHeightUnit.TabStop = false;
            this.toolTip1.SetToolTip(this.cb_pageHeightUnit, resources.GetString("cb_pageHeightUnit.ToolTip"));
            this.cb_pageHeightUnit.SelectedIndexChanged += new System.EventHandler(this.cb_pageDimensionUnit_SelectedIndexChanged);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.errorProvider1.SetError(this.label6, resources.GetString("label6.Error"));
            this.errorProvider1.SetIconAlignment(this.label6, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label6.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label6, ((int)(resources.GetObject("label6.IconPadding"))));
            this.label6.Image = global::DVLD.Properties.Resources.Margin_Vertical_32;
            this.label6.Name = "label6";
            this.toolTip1.SetToolTip(this.label6, resources.GetString("label6.ToolTip"));
            // 
            // txt_pageHeight
            // 
            resources.ApplyResources(this.txt_pageHeight, "txt_pageHeight");
            this.txt_pageHeight.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.txt_pageHeight.BeforeTouchSize = new System.Drawing.Size(210, 30);
            this.txt_pageHeight.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.txt_pageHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pageHeight.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_pageHeight.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_pageHeight.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.txt_pageHeight, resources.GetString("txt_pageHeight.Error"));
            this.txt_pageHeight.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetIconAlignment(this.txt_pageHeight, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txt_pageHeight.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txt_pageHeight, ((int)(resources.GetObject("txt_pageHeight.IconPadding"))));
            this.txt_pageHeight.Name = "txt_pageHeight";
            this.toolTip1.SetToolTip(this.txt_pageHeight, resources.GetString("txt_pageHeight.ToolTip"));
            this.txt_pageHeight.TextChanged += new System.EventHandler(this.txt_pageDimension_TextChanged);
            this.txt_pageHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pageDimension_KeyPress);
            // 
            // lbl_pageHeight
            // 
            resources.ApplyResources(this.lbl_pageHeight, "lbl_pageHeight");
            this.errorProvider1.SetError(this.lbl_pageHeight, resources.GetString("lbl_pageHeight.Error"));
            this.errorProvider1.SetIconAlignment(this.lbl_pageHeight, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lbl_pageHeight.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lbl_pageHeight, ((int)(resources.GetObject("lbl_pageHeight.IconPadding"))));
            this.lbl_pageHeight.Image = global::DVLD.Properties.Resources.Page_Height_32;
            this.lbl_pageHeight.Name = "lbl_pageHeight";
            this.toolTip1.SetToolTip(this.lbl_pageHeight, resources.GetString("lbl_pageHeight.ToolTip"));
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cb_pageSize);
            this.panel1.Controls.Add(this.txt_hMargin);
            this.panel1.Controls.Add(this.cb_hMarginUnit);
            this.panel1.Controls.Add(this.txt_pageWidth);
            this.panel1.Controls.Add(this.cb_pageWidthUnit);
            this.panel1.Controls.Add(this.lbl_pageWidth);
            this.panel1.Controls.Add(this.label7);
            this.errorProvider1.SetError(this.panel1, resources.GetString("panel1.Error"));
            this.errorProvider1.SetIconAlignment(this.panel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.panel1, ((int)(resources.GetObject("panel1.IconPadding"))));
            this.panel1.Name = "panel1";
            this.toolTip1.SetToolTip(this.panel1, resources.GetString("panel1.ToolTip"));
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.errorProvider1.SetError(this.label5, resources.GetString("label5.Error"));
            this.errorProvider1.SetIconAlignment(this.label5, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label5.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label5, ((int)(resources.GetObject("label5.IconPadding"))));
            this.label5.Image = global::DVLD.Properties.Resources.Page_Size_32;
            this.label5.Name = "label5";
            this.toolTip1.SetToolTip(this.label5, resources.GetString("label5.ToolTip"));
            // 
            // cb_pageSize
            // 
            resources.ApplyResources(this.cb_pageSize, "cb_pageSize");
            this.cb_pageSize.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.cb_pageSize.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.cb_pageSize.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_pageSize.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_pageSize.DataBindings.Add(new System.Windows.Forms.Binding("DropDownArrowColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_pageSize.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_pageSize.DataBindings.Add(new System.Windows.Forms.Binding("MouseOverBackColor", global::DVLD.Properties.Settings.Default, "SurfaceHoverColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_pageSize.DropDownArrowColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetError(this.cb_pageSize, resources.GetString("cb_pageSize.Error"));
            this.cb_pageSize.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetIconAlignment(this.cb_pageSize, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cb_pageSize.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.cb_pageSize, ((int)(resources.GetObject("cb_pageSize.IconPadding"))));
            this.cb_pageSize.Items.AddRange(new object[] {
            resources.GetString("cb_pageSize.Items"),
            resources.GetString("cb_pageSize.Items1"),
            resources.GetString("cb_pageSize.Items2"),
            resources.GetString("cb_pageSize.Items3"),
            resources.GetString("cb_pageSize.Items4"),
            resources.GetString("cb_pageSize.Items5"),
            resources.GetString("cb_pageSize.Items6"),
            resources.GetString("cb_pageSize.Items7"),
            resources.GetString("cb_pageSize.Items8"),
            resources.GetString("cb_pageSize.Items9"),
            resources.GetString("cb_pageSize.Items10")});
            this.cb_pageSize.MouseOverBackColor = global::DVLD.Properties.Settings.Default.SurfaceHoverColor;
            this.cb_pageSize.Name = "cb_pageSize";
            this.cb_pageSize.SelectedIndex = -1;
            this.cb_pageSize.TabStop = false;
            this.toolTip1.SetToolTip(this.cb_pageSize, resources.GetString("cb_pageSize.ToolTip"));
            this.cb_pageSize.SelectedIndexChanged += new System.EventHandler(this.cb_pageSize_SelectedIndexChanged);
            // 
            // txt_hMargin
            // 
            resources.ApplyResources(this.txt_hMargin, "txt_hMargin");
            this.txt_hMargin.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.txt_hMargin.BeforeTouchSize = new System.Drawing.Size(210, 30);
            this.txt_hMargin.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.txt_hMargin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_hMargin.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_hMargin.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_hMargin.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.txt_hMargin, resources.GetString("txt_hMargin.Error"));
            this.txt_hMargin.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetIconAlignment(this.txt_hMargin, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txt_hMargin.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txt_hMargin, ((int)(resources.GetObject("txt_hMargin.IconPadding"))));
            this.txt_hMargin.Name = "txt_hMargin";
            this.toolTip1.SetToolTip(this.txt_hMargin, resources.GetString("txt_hMargin.ToolTip"));
            this.txt_hMargin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pageDimension_KeyPress);
            // 
            // cb_hMarginUnit
            // 
            resources.ApplyResources(this.cb_hMarginUnit, "cb_hMarginUnit");
            this.cb_hMarginUnit.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.cb_hMarginUnit.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.cb_hMarginUnit.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_hMarginUnit.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_hMarginUnit.DataBindings.Add(new System.Windows.Forms.Binding("DropDownArrowColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_hMarginUnit.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_hMarginUnit.DataBindings.Add(new System.Windows.Forms.Binding("MouseOverBackColor", global::DVLD.Properties.Settings.Default, "SurfaceHoverColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_hMarginUnit.DropDownArrowColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetError(this.cb_hMarginUnit, resources.GetString("cb_hMarginUnit.Error"));
            this.cb_hMarginUnit.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetIconAlignment(this.cb_hMarginUnit, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cb_hMarginUnit.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.cb_hMarginUnit, ((int)(resources.GetObject("cb_hMarginUnit.IconPadding"))));
            this.cb_hMarginUnit.Items.AddRange(new object[] {
            resources.GetString("cb_hMarginUnit.Items"),
            resources.GetString("cb_hMarginUnit.Items1"),
            resources.GetString("cb_hMarginUnit.Items2")});
            this.cb_hMarginUnit.MouseOverBackColor = global::DVLD.Properties.Settings.Default.SurfaceHoverColor;
            this.cb_hMarginUnit.Name = "cb_hMarginUnit";
            this.cb_hMarginUnit.SelectedIndex = 0;
            this.cb_hMarginUnit.TabStop = false;
            this.toolTip1.SetToolTip(this.cb_hMarginUnit, resources.GetString("cb_hMarginUnit.ToolTip"));
            // 
            // txt_pageWidth
            // 
            resources.ApplyResources(this.txt_pageWidth, "txt_pageWidth");
            this.txt_pageWidth.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.txt_pageWidth.BeforeTouchSize = new System.Drawing.Size(210, 30);
            this.txt_pageWidth.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.txt_pageWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pageWidth.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_pageWidth.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_pageWidth.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.txt_pageWidth, resources.GetString("txt_pageWidth.Error"));
            this.txt_pageWidth.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetIconAlignment(this.txt_pageWidth, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txt_pageWidth.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txt_pageWidth, ((int)(resources.GetObject("txt_pageWidth.IconPadding"))));
            this.txt_pageWidth.Name = "txt_pageWidth";
            this.toolTip1.SetToolTip(this.txt_pageWidth, resources.GetString("txt_pageWidth.ToolTip"));
            this.txt_pageWidth.TextChanged += new System.EventHandler(this.txt_pageDimension_TextChanged);
            this.txt_pageWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pageDimension_KeyPress);
            // 
            // cb_pageWidthUnit
            // 
            resources.ApplyResources(this.cb_pageWidthUnit, "cb_pageWidthUnit");
            this.cb_pageWidthUnit.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.cb_pageWidthUnit.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.cb_pageWidthUnit.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_pageWidthUnit.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_pageWidthUnit.DataBindings.Add(new System.Windows.Forms.Binding("DropDownArrowColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_pageWidthUnit.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_pageWidthUnit.DataBindings.Add(new System.Windows.Forms.Binding("MouseOverBackColor", global::DVLD.Properties.Settings.Default, "SurfaceHoverColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_pageWidthUnit.DropDownArrowColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetError(this.cb_pageWidthUnit, resources.GetString("cb_pageWidthUnit.Error"));
            this.cb_pageWidthUnit.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetIconAlignment(this.cb_pageWidthUnit, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cb_pageWidthUnit.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.cb_pageWidthUnit, ((int)(resources.GetObject("cb_pageWidthUnit.IconPadding"))));
            this.cb_pageWidthUnit.Items.AddRange(new object[] {
            resources.GetString("cb_pageWidthUnit.Items"),
            resources.GetString("cb_pageWidthUnit.Items1"),
            resources.GetString("cb_pageWidthUnit.Items2")});
            this.cb_pageWidthUnit.MouseOverBackColor = global::DVLD.Properties.Settings.Default.SurfaceHoverColor;
            this.cb_pageWidthUnit.Name = "cb_pageWidthUnit";
            this.cb_pageWidthUnit.SelectedIndex = 0;
            this.cb_pageWidthUnit.TabStop = false;
            this.toolTip1.SetToolTip(this.cb_pageWidthUnit, resources.GetString("cb_pageWidthUnit.ToolTip"));
            this.cb_pageWidthUnit.SelectedIndexChanged += new System.EventHandler(this.cb_pageDimensionUnit_SelectedIndexChanged);
            // 
            // lbl_pageWidth
            // 
            resources.ApplyResources(this.lbl_pageWidth, "lbl_pageWidth");
            this.errorProvider1.SetError(this.lbl_pageWidth, resources.GetString("lbl_pageWidth.Error"));
            this.errorProvider1.SetIconAlignment(this.lbl_pageWidth, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lbl_pageWidth.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lbl_pageWidth, ((int)(resources.GetObject("lbl_pageWidth.IconPadding"))));
            this.lbl_pageWidth.Image = global::DVLD.Properties.Resources.Page_Width_32;
            this.lbl_pageWidth.Name = "lbl_pageWidth";
            this.toolTip1.SetToolTip(this.lbl_pageWidth, resources.GetString("lbl_pageWidth.ToolTip"));
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.errorProvider1.SetError(this.label7, resources.GetString("label7.Error"));
            this.errorProvider1.SetIconAlignment(this.label7, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label7.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label7, ((int)(resources.GetObject("label7.IconPadding"))));
            this.label7.Image = global::DVLD.Properties.Resources.Margin_Horizontal_32;
            this.label7.Name = "label7";
            this.toolTip1.SetToolTip(this.label7, resources.GetString("label7.ToolTip"));
            // 
            // cb_preferredFontFamily
            // 
            resources.ApplyResources(this.cb_preferredFontFamily, "cb_preferredFontFamily");
            this.cb_preferredFontFamily.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cb_preferredFontFamily.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_preferredFontFamily.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.cb_preferredFontFamily.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.cb_preferredFontFamily.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_preferredFontFamily.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_preferredFontFamily.DataBindings.Add(new System.Windows.Forms.Binding("DropDownArrowColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_preferredFontFamily.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_preferredFontFamily.DropDownArrowColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.cb_preferredFontFamily.DropDownMouseOverBackColor = global::DVLD.Properties.Settings.Default.SurfaceHoverColor;
            this.errorProvider1.SetError(this.cb_preferredFontFamily, resources.GetString("cb_preferredFontFamily.Error"));
            this.cb_preferredFontFamily.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.cb_preferredFontFamily.FormattingEnabled = false;
            this.errorProvider1.SetIconAlignment(this.cb_preferredFontFamily, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cb_preferredFontFamily.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.cb_preferredFontFamily, ((int)(resources.GetObject("cb_preferredFontFamily.IconPadding"))));
            this.cb_preferredFontFamily.Name = "cb_preferredFontFamily";
            this.cb_preferredFontFamily.RenderFontFamilyItems = true;
            this.cb_preferredFontFamily.TabStop = false;
            this.toolTip1.SetToolTip(this.cb_preferredFontFamily, resources.GetString("cb_preferredFontFamily.ToolTip"));
            // 
            // buttonEdit3
            // 
            resources.ApplyResources(this.buttonEdit3, "buttonEdit3");
            this.buttonEdit3.BackColor = System.Drawing.SystemColors.Control;
            this.buttonEdit3.BeforeTouchSize = new System.Drawing.Size(492, 27);
            this.buttonEdit3.Buttons.Add(this.btn_browseFolder);
            this.buttonEdit3.Controls.Add(this.btn_browseFolder);
            this.buttonEdit3.Controls.Add(this.txt_fullPath);
            this.buttonEdit3.DataBindings.Add(new System.Windows.Forms.Binding("FlatBorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.buttonEdit3, resources.GetString("buttonEdit3.Error"));
            this.buttonEdit3.FlatBorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.buttonEdit3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.errorProvider1.SetIconAlignment(this.buttonEdit3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("buttonEdit3.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.buttonEdit3, ((int)(resources.GetObject("buttonEdit3.IconPadding"))));
            this.buttonEdit3.Name = "buttonEdit3";
            this.buttonEdit3.TextBox = this.txt_fullPath;
            this.toolTip1.SetToolTip(this.buttonEdit3, resources.GetString("buttonEdit3.ToolTip"));
            // 
            // btn_browseFolder
            // 
            resources.ApplyResources(this.btn_browseFolder, "btn_browseFolder");
            this.btn_browseFolder.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.btn_browseFolder.BeforeTouchSize = new System.Drawing.Size(26, 23);
            this.btn_browseFolder.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_browseFolder.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.btn_browseFolder, resources.GetString("btn_browseFolder.Error"));
            this.btn_browseFolder.FlatAppearance.BorderSize = 0;
            this.btn_browseFolder.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetIconAlignment(this.btn_browseFolder, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btn_browseFolder.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.btn_browseFolder, ((int)(resources.GetObject("btn_browseFolder.IconPadding"))));
            this.btn_browseFolder.Name = "btn_browseFolder";
            this.btn_browseFolder.PreferredWidth = 26;
            this.btn_browseFolder.ThemeName = "WindowsXP";
            this.toolTip1.SetToolTip(this.btn_browseFolder, resources.GetString("btn_browseFolder.ToolTip"));
            this.btn_browseFolder.Click += new System.EventHandler(this.btn_browseFolder_Click);
            // 
            // txt_fullPath
            // 
            resources.ApplyResources(this.txt_fullPath, "txt_fullPath");
            this.txt_fullPath.BackColor = System.Drawing.SystemColors.Control;
            this.txt_fullPath.BeforeTouchSize = new System.Drawing.Size(210, 30);
            this.txt_fullPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_fullPath.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.txt_fullPath, resources.GetString("txt_fullPath.Error"));
            this.txt_fullPath.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetIconAlignment(this.txt_fullPath, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txt_fullPath.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txt_fullPath, ((int)(resources.GetObject("txt_fullPath.IconPadding"))));
            this.txt_fullPath.Name = "txt_fullPath";
            this.txt_fullPath.ReadOnly = true;
            this.toolTip1.SetToolTip(this.txt_fullPath, resources.GetString("txt_fullPath.ToolTip"));
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.errorProvider1.SetError(this.label2, resources.GetString("label2.Error"));
            this.errorProvider1.SetIconAlignment(this.label2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label2.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label2, ((int)(resources.GetObject("label2.IconPadding"))));
            this.label2.Image = global::DVLD.Properties.Resources.Font_32;
            this.label2.Name = "label2";
            this.toolTip1.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.errorProvider1.SetError(this.label1, resources.GetString("label1.Error"));
            this.errorProvider1.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding"))));
            this.label1.Image = global::DVLD.Properties.Resources.Full_Path_24;
            this.label1.Name = "label1";
            this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // txt_fileName
            // 
            resources.ApplyResources(this.txt_fileName, "txt_fileName");
            this.txt_fileName.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.txt_fileName.BeforeTouchSize = new System.Drawing.Size(210, 30);
            this.txt_fileName.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.txt_fileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_fileName.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_fileName.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_fileName.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.txt_fileName, resources.GetString("txt_fileName.Error"));
            this.txt_fileName.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetIconAlignment(this.txt_fileName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txt_fileName.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txt_fileName, ((int)(resources.GetObject("txt_fileName.IconPadding"))));
            this.txt_fileName.Name = "txt_fileName";
            this.toolTip1.SetToolTip(this.txt_fileName, resources.GetString("txt_fileName.ToolTip"));
            this.txt_fileName.TextChanged += new System.EventHandler(this.txt_fileName_TextChanged);
            this.txt_fileName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_fileName_KeyPress);
            this.txt_fileName.Validating += new System.ComponentModel.CancelEventHandler(this.txt_fileName_Validating);
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.errorProvider1.SetError(this.label13, resources.GetString("label13.Error"));
            this.errorProvider1.SetIconAlignment(this.label13, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label13.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label13, ((int)(resources.GetObject("label13.IconPadding"))));
            this.label13.Image = global::DVLD.Properties.Resources.File_Name_32;
            this.label13.Name = "label13";
            this.toolTip1.SetToolTip(this.label13, resources.GetString("label13.ToolTip"));
            // 
            // vistaFolderBrowserDialog1
            // 
            resources.ApplyResources(this.vistaFolderBrowserDialog1, "vistaFolderBrowserDialog1");
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            resources.ApplyResources(this.errorProvider1, "errorProvider1");
            // 
            // Ctrl_DocumentExportSettings
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.groupBox1);
            this.errorProvider1.SetError(this, resources.GetString("$this.Error"));
            this.errorProvider1.SetIconAlignment(this, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("$this.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this, ((int)(resources.GetObject("$this.IconPadding"))));
            this.Name = "Ctrl_DocumentExportSettings";
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.Load += new System.EventHandler(this.Ctrl_DocumentExportSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_vMargin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pageHeight)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_hMargin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pageWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit3)).EndInit();
            this.buttonEdit3.ResumeLayout(false);
            this.buttonEdit3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_fullPath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_fileName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txt_fileName;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txt_fullPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Syncfusion.Windows.Forms.Tools.ButtonEdit buttonEdit3;
        private Syncfusion.Windows.Forms.Tools.ButtonEditChildButton btn_browseFolder;
        private Salem.Controls.SalDropDownEdit cb_preferredFontFamily;
        private Salem.Controls.SalDropDownList cb_pageWidthUnit;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txt_pageWidth;
        private System.Windows.Forms.Label lbl_pageWidth;
        private Salem.Controls.SalDropDownList cb_pageSize;
        private System.Windows.Forms.Label label5;
        private Salem.Controls.SalDropDownList cb_pageHeightUnit;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txt_pageHeight;
        private System.Windows.Forms.Label lbl_pageHeight;
        private System.Windows.Forms.CheckBox chk_useCustomPageSize;
        private Salem.Controls.SalDropDownList cb_vMarginUnit;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txt_vMargin;
        private System.Windows.Forms.Label label6;
        private Salem.Controls.SalDropDownList cb_hMarginUnit;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txt_hMargin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chk_openAfterSaving;
        private System.Windows.Forms.CheckBox chk_includeDvldLogo;
        private System.Windows.Forms.CheckBox chk_includeDateTime;
        private Salem.Controls.SalDropDownList cb_pageOrientation;
        private Ookii.Dialogs.WinForms.VistaFolderBrowserDialog vistaFolderBrowserDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox chk_colorful;
    }
}
