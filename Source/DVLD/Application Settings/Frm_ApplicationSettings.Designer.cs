namespace DVLD.Application_Settings {
    partial class Frm_ApplicationSettings {
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
                _smallRegularFont.Dispose();
                _smallItalicFont.Dispose();
                _bigRegularFont.Dispose();
                _bigItalicFont.Dispose();

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ApplicationSettings));
            this.lbl_language = new System.Windows.Forms.Label();
            this.cb_language = new Salem.Controls.SalDropDownList();
            this.lbl_colorMode = new System.Windows.Forms.Label();
            this.lbl_theme = new System.Windows.Forms.Label();
            this.cb_colorMode = new Salem.Controls.SalDropDownList();
            this.cb_theme = new Salem.Controls.SalDropDownList();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_apply = new System.Windows.Forms.Button();
            this.pnl_themeValues = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_selectHue = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label21 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_menuItemHoverBorderColor = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_menuItemHoverColor = new System.Windows.Forms.Button();
            this.btn_mainMenuBackColor = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lbl_selectedTheme = new System.Windows.Forms.Label();
            this.btn_strongForeColor = new System.Windows.Forms.Button();
            this.btn_surfaceBackColor = new System.Windows.Forms.Button();
            this.btn_gridHeaderHighlightColor = new System.Windows.Forms.Button();
            this.btn_inactiveTabColor = new System.Windows.Forms.Button();
            this.btn_surfaceBorderColor = new System.Windows.Forms.Button();
            this.btn_baseLinkColor = new System.Windows.Forms.Button();
            this.btn_baseForeColor = new System.Windows.Forms.Button();
            this.btn_baseBackColor = new System.Windows.Forms.Button();
            this.btn_gridHeaderCellColor = new System.Windows.Forms.Button();
            this.btn_surfaceHoverColor = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_inactiveForeColor = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_accentForeColor = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.gb_menuItemsStyle = new System.Windows.Forms.GroupBox();
            this.rb_fixedHue = new System.Windows.Forms.RadioButton();
            this.rb_freeValues = new System.Windows.Forms.RadioButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.ll_branchIntoNewTheme = new System.Windows.Forms.LinkLabel();
            this.ll_saveChangesToSelectedTheme = new System.Windows.Forms.LinkLabel();
            this.ll_deleteSelectedTheme = new System.Windows.Forms.LinkLabel();
            this.ll_renameSelectedTheme = new System.Windows.Forms.LinkLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnl_themeValues.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.gb_menuItemsStyle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_language
            // 
            resources.ApplyResources(this.lbl_language, "lbl_language");
            this.lbl_language.Cursor = System.Windows.Forms.Cursors.Help;
            this.lbl_language.Image = global::DVLD.Properties.Resources.Language_32;
            this.lbl_language.Name = "lbl_language";
            this.toolTip1.SetToolTip(this.lbl_language, resources.GetString("lbl_language.ToolTip"));
            // 
            // cb_language
            // 
            resources.ApplyResources(this.cb_language, "cb_language");
            this.cb_language.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.cb_language.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.cb_language.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_language.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_language.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_language.DataBindings.Add(new System.Windows.Forms.Binding("MouseOverBackColor", global::DVLD.Properties.Settings.Default, "SurfaceHoverColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_language.DataBindings.Add(new System.Windows.Forms.Binding("DropDownArrowColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_language.DropDownArrowColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.cb_language.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.cb_language.Items.AddRange(new object[] {
            resources.GetString("cb_language.Items"),
            resources.GetString("cb_language.Items1")});
            this.cb_language.MouseOverBackColor = global::DVLD.Properties.Settings.Default.SurfaceHoverColor;
            this.cb_language.Name = "cb_language";
            this.cb_language.SelectedIndex = -1;
            this.cb_language.TabStop = false;
            this.toolTip1.SetToolTip(this.cb_language, resources.GetString("cb_language.ToolTip"));
            this.cb_language.SelectedIndexChanged += new System.EventHandler(this.cb_language_SelectedIndexChanged);
            // 
            // lbl_colorMode
            // 
            resources.ApplyResources(this.lbl_colorMode, "lbl_colorMode");
            this.lbl_colorMode.Image = global::DVLD.Properties.Resources.Light_32;
            this.lbl_colorMode.Name = "lbl_colorMode";
            this.toolTip1.SetToolTip(this.lbl_colorMode, resources.GetString("lbl_colorMode.ToolTip"));
            // 
            // lbl_theme
            // 
            resources.ApplyResources(this.lbl_theme, "lbl_theme");
            this.lbl_theme.Image = global::DVLD.Properties.Resources.Theme_32;
            this.lbl_theme.Name = "lbl_theme";
            this.toolTip1.SetToolTip(this.lbl_theme, resources.GetString("lbl_theme.ToolTip"));
            // 
            // cb_colorMode
            // 
            resources.ApplyResources(this.cb_colorMode, "cb_colorMode");
            this.cb_colorMode.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.cb_colorMode.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.cb_colorMode.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_colorMode.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_colorMode.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_colorMode.DataBindings.Add(new System.Windows.Forms.Binding("MouseOverBackColor", global::DVLD.Properties.Settings.Default, "SurfaceHoverColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_colorMode.DataBindings.Add(new System.Windows.Forms.Binding("DropDownArrowColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_colorMode.DropDownArrowColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.cb_colorMode.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.cb_colorMode.Items.AddRange(new object[] {
            resources.GetString("cb_colorMode.Items"),
            resources.GetString("cb_colorMode.Items1"),
            resources.GetString("cb_colorMode.Items2")});
            this.cb_colorMode.MouseOverBackColor = global::DVLD.Properties.Settings.Default.SurfaceHoverColor;
            this.cb_colorMode.Name = "cb_colorMode";
            this.cb_colorMode.SelectedIndex = -1;
            this.cb_colorMode.TabStop = false;
            this.toolTip1.SetToolTip(this.cb_colorMode, resources.GetString("cb_colorMode.ToolTip"));
            this.cb_colorMode.SelectedIndexChanged += new System.EventHandler(this.cb_colorMode_SelectedIndexChanged);
            // 
            // cb_theme
            // 
            resources.ApplyResources(this.cb_theme, "cb_theme");
            this.cb_theme.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.cb_theme.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.cb_theme.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_theme.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_theme.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_theme.DataBindings.Add(new System.Windows.Forms.Binding("MouseOverBackColor", global::DVLD.Properties.Settings.Default, "SurfaceHoverColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_theme.DataBindings.Add(new System.Windows.Forms.Binding("DropDownArrowColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_theme.DropDownArrowColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.cb_theme.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.cb_theme.MouseOverBackColor = global::DVLD.Properties.Settings.Default.SurfaceHoverColor;
            this.cb_theme.Name = "cb_theme";
            this.cb_theme.SelectedIndex = -1;
            this.cb_theme.TabStop = false;
            this.toolTip1.SetToolTip(this.cb_theme, resources.GetString("cb_theme.ToolTip"));
            this.cb_theme.SelectedIndexChanged += new System.EventHandler(this.cb_theme_SelectedIndexChanged);
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
            this.toolTip1.SetToolTip(this.btn_close, resources.GetString("btn_close.ToolTip"));
            this.btn_close.UseVisualStyleBackColor = false;
            // 
            // btn_apply
            // 
            resources.ApplyResources(this.btn_apply, "btn_apply");
            this.btn_apply.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.btn_apply.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_apply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_apply.Image = global::DVLD.Properties.Resources.Save_32;
            this.btn_apply.Name = "btn_apply";
            this.toolTip1.SetToolTip(this.btn_apply, resources.GetString("btn_apply.ToolTip"));
            this.btn_apply.UseVisualStyleBackColor = false;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // pnl_themeValues
            // 
            resources.ApplyResources(this.pnl_themeValues, "pnl_themeValues");
            this.pnl_themeValues.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_themeValues.Controls.Add(this.groupBox2);
            this.pnl_themeValues.Controls.Add(this.lbl_selectedTheme);
            this.pnl_themeValues.Controls.Add(this.btn_strongForeColor);
            this.pnl_themeValues.Controls.Add(this.btn_surfaceBackColor);
            this.pnl_themeValues.Controls.Add(this.btn_gridHeaderHighlightColor);
            this.pnl_themeValues.Controls.Add(this.btn_inactiveTabColor);
            this.pnl_themeValues.Controls.Add(this.btn_surfaceBorderColor);
            this.pnl_themeValues.Controls.Add(this.btn_baseLinkColor);
            this.pnl_themeValues.Controls.Add(this.btn_baseForeColor);
            this.pnl_themeValues.Controls.Add(this.btn_baseBackColor);
            this.pnl_themeValues.Controls.Add(this.btn_gridHeaderCellColor);
            this.pnl_themeValues.Controls.Add(this.btn_surfaceHoverColor);
            this.pnl_themeValues.Controls.Add(this.label16);
            this.pnl_themeValues.Controls.Add(this.btn_inactiveForeColor);
            this.pnl_themeValues.Controls.Add(this.label15);
            this.pnl_themeValues.Controls.Add(this.btn_accentForeColor);
            this.pnl_themeValues.Controls.Add(this.label14);
            this.pnl_themeValues.Controls.Add(this.label13);
            this.pnl_themeValues.Controls.Add(this.label12);
            this.pnl_themeValues.Controls.Add(this.label11);
            this.pnl_themeValues.Controls.Add(this.label10);
            this.pnl_themeValues.Controls.Add(this.label9);
            this.pnl_themeValues.Controls.Add(this.label8);
            this.pnl_themeValues.Controls.Add(this.label4);
            this.pnl_themeValues.Controls.Add(this.label3);
            this.pnl_themeValues.Controls.Add(this.label18);
            this.pnl_themeValues.Controls.Add(this.label17);
            this.pnl_themeValues.Name = "pnl_themeValues";
            this.toolTip1.SetToolTip(this.pnl_themeValues, resources.GetString("pnl_themeValues.ToolTip"));
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.btn_selectHue);
            this.groupBox2.Controls.Add(this.trackBar1);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btn_menuItemHoverBorderColor);
            this.groupBox2.Controls.Add(this.btn_menuItemHoverColor);
            this.groupBox2.Controls.Add(this.btn_mainMenuBackColor);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupBox2.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox2, resources.GetString("groupBox2.ToolTip"));
            // 
            // btn_selectHue
            // 
            resources.ApplyResources(this.btn_selectHue, "btn_selectHue");
            this.btn_selectHue.BackColor = System.Drawing.Color.Red;
            this.btn_selectHue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_selectHue.FlatAppearance.BorderSize = 0;
            this.btn_selectHue.ForeColor = System.Drawing.Color.Black;
            this.btn_selectHue.Name = "btn_selectHue";
            this.btn_selectHue.Tag = "10";
            this.toolTip1.SetToolTip(this.btn_selectHue, resources.GetString("btn_selectHue.ToolTip"));
            this.btn_selectHue.UseVisualStyleBackColor = false;
            this.btn_selectHue.Click += new System.EventHandler(this.btn_selectHue_Click);
            // 
            // trackBar1
            // 
            resources.ApplyResources(this.trackBar1, "trackBar1");
            this.trackBar1.Maximum = 360;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.toolTip1.SetToolTip(this.trackBar1, resources.GetString("trackBar1.ToolTip"));
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // label21
            // 
            resources.ApplyResources(this.label21, "label21");
            this.label21.Name = "label21";
            this.toolTip1.SetToolTip(this.label21, resources.GetString("label21.ToolTip"));
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            this.toolTip1.SetToolTip(this.label6, resources.GetString("label6.ToolTip"));
            // 
            // btn_menuItemHoverBorderColor
            // 
            resources.ApplyResources(this.btn_menuItemHoverBorderColor, "btn_menuItemHoverBorderColor");
            this.btn_menuItemHoverBorderColor.BackColor = System.Drawing.Color.Black;
            this.btn_menuItemHoverBorderColor.ContextMenuStrip = this.contextMenuStrip1;
            this.btn_menuItemHoverBorderColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_menuItemHoverBorderColor.FlatAppearance.BorderSize = 0;
            this.btn_menuItemHoverBorderColor.ForeColor = System.Drawing.Color.White;
            this.btn_menuItemHoverBorderColor.Name = "btn_menuItemHoverBorderColor";
            this.btn_menuItemHoverBorderColor.Tag = "14";
            this.toolTip1.SetToolTip(this.btn_menuItemHoverBorderColor, resources.GetString("btn_menuItemHoverBorderColor.ToolTip"));
            this.btn_menuItemHoverBorderColor.UseVisualStyleBackColor = false;
            this.btn_menuItemHoverBorderColor.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // contextMenuStrip1
            // 
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.toolTip1.SetToolTip(this.contextMenuStrip1, resources.GetString("contextMenuStrip1.ToolTip"));
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // resetToolStripMenuItem
            // 
            resources.ApplyResources(this.resetToolStripMenuItem, "resetToolStripMenuItem");
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // btn_menuItemHoverColor
            // 
            resources.ApplyResources(this.btn_menuItemHoverColor, "btn_menuItemHoverColor");
            this.btn_menuItemHoverColor.BackColor = System.Drawing.Color.Black;
            this.btn_menuItemHoverColor.ContextMenuStrip = this.contextMenuStrip1;
            this.btn_menuItemHoverColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_menuItemHoverColor.FlatAppearance.BorderSize = 0;
            this.btn_menuItemHoverColor.ForeColor = System.Drawing.Color.White;
            this.btn_menuItemHoverColor.Name = "btn_menuItemHoverColor";
            this.btn_menuItemHoverColor.Tag = "13";
            this.toolTip1.SetToolTip(this.btn_menuItemHoverColor, resources.GetString("btn_menuItemHoverColor.ToolTip"));
            this.btn_menuItemHoverColor.UseVisualStyleBackColor = false;
            this.btn_menuItemHoverColor.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // btn_mainMenuBackColor
            // 
            resources.ApplyResources(this.btn_mainMenuBackColor, "btn_mainMenuBackColor");
            this.btn_mainMenuBackColor.BackColor = System.Drawing.Color.Black;
            this.btn_mainMenuBackColor.ContextMenuStrip = this.contextMenuStrip1;
            this.btn_mainMenuBackColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mainMenuBackColor.FlatAppearance.BorderSize = 0;
            this.btn_mainMenuBackColor.ForeColor = System.Drawing.Color.White;
            this.btn_mainMenuBackColor.Name = "btn_mainMenuBackColor";
            this.btn_mainMenuBackColor.Tag = "12";
            this.toolTip1.SetToolTip(this.btn_mainMenuBackColor, resources.GetString("btn_mainMenuBackColor.ToolTip"));
            this.btn_mainMenuBackColor.UseVisualStyleBackColor = false;
            this.btn_mainMenuBackColor.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            this.toolTip1.SetToolTip(this.label19, resources.GetString("label19.ToolTip"));
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.Name = "label20";
            this.toolTip1.SetToolTip(this.label20, resources.GetString("label20.ToolTip"));
            // 
            // lbl_selectedTheme
            // 
            resources.ApplyResources(this.lbl_selectedTheme, "lbl_selectedTheme");
            this.lbl_selectedTheme.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "InactiveForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lbl_selectedTheme.ForeColor = global::DVLD.Properties.Settings.Default.InactiveForeColor;
            this.lbl_selectedTheme.Name = "lbl_selectedTheme";
            this.toolTip1.SetToolTip(this.lbl_selectedTheme, resources.GetString("lbl_selectedTheme.ToolTip"));
            // 
            // btn_strongForeColor
            // 
            resources.ApplyResources(this.btn_strongForeColor, "btn_strongForeColor");
            this.btn_strongForeColor.BackColor = System.Drawing.Color.Black;
            this.btn_strongForeColor.ContextMenuStrip = this.contextMenuStrip1;
            this.btn_strongForeColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_strongForeColor.FlatAppearance.BorderSize = 0;
            this.btn_strongForeColor.ForeColor = System.Drawing.Color.White;
            this.btn_strongForeColor.Name = "btn_strongForeColor";
            this.btn_strongForeColor.Tag = "3";
            this.toolTip1.SetToolTip(this.btn_strongForeColor, resources.GetString("btn_strongForeColor.ToolTip"));
            this.btn_strongForeColor.UseVisualStyleBackColor = false;
            this.btn_strongForeColor.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // btn_surfaceBackColor
            // 
            resources.ApplyResources(this.btn_surfaceBackColor, "btn_surfaceBackColor");
            this.btn_surfaceBackColor.BackColor = System.Drawing.Color.Black;
            this.btn_surfaceBackColor.ContextMenuStrip = this.contextMenuStrip1;
            this.btn_surfaceBackColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_surfaceBackColor.FlatAppearance.BorderSize = 0;
            this.btn_surfaceBackColor.ForeColor = System.Drawing.Color.White;
            this.btn_surfaceBackColor.Name = "btn_surfaceBackColor";
            this.btn_surfaceBackColor.Tag = "1";
            this.toolTip1.SetToolTip(this.btn_surfaceBackColor, resources.GetString("btn_surfaceBackColor.ToolTip"));
            this.btn_surfaceBackColor.UseVisualStyleBackColor = false;
            this.btn_surfaceBackColor.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // btn_gridHeaderHighlightColor
            // 
            resources.ApplyResources(this.btn_gridHeaderHighlightColor, "btn_gridHeaderHighlightColor");
            this.btn_gridHeaderHighlightColor.BackColor = System.Drawing.Color.Black;
            this.btn_gridHeaderHighlightColor.ContextMenuStrip = this.contextMenuStrip1;
            this.btn_gridHeaderHighlightColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_gridHeaderHighlightColor.FlatAppearance.BorderSize = 0;
            this.btn_gridHeaderHighlightColor.ForeColor = System.Drawing.Color.White;
            this.btn_gridHeaderHighlightColor.Name = "btn_gridHeaderHighlightColor";
            this.btn_gridHeaderHighlightColor.Tag = "11";
            this.toolTip1.SetToolTip(this.btn_gridHeaderHighlightColor, resources.GetString("btn_gridHeaderHighlightColor.ToolTip"));
            this.btn_gridHeaderHighlightColor.UseVisualStyleBackColor = false;
            this.btn_gridHeaderHighlightColor.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // btn_inactiveTabColor
            // 
            resources.ApplyResources(this.btn_inactiveTabColor, "btn_inactiveTabColor");
            this.btn_inactiveTabColor.BackColor = System.Drawing.Color.Black;
            this.btn_inactiveTabColor.ContextMenuStrip = this.contextMenuStrip1;
            this.btn_inactiveTabColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inactiveTabColor.FlatAppearance.BorderSize = 0;
            this.btn_inactiveTabColor.ForeColor = System.Drawing.Color.White;
            this.btn_inactiveTabColor.Name = "btn_inactiveTabColor";
            this.btn_inactiveTabColor.Tag = "9";
            this.toolTip1.SetToolTip(this.btn_inactiveTabColor, resources.GetString("btn_inactiveTabColor.ToolTip"));
            this.btn_inactiveTabColor.UseVisualStyleBackColor = false;
            this.btn_inactiveTabColor.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // btn_surfaceBorderColor
            // 
            resources.ApplyResources(this.btn_surfaceBorderColor, "btn_surfaceBorderColor");
            this.btn_surfaceBorderColor.BackColor = System.Drawing.Color.Black;
            this.btn_surfaceBorderColor.ContextMenuStrip = this.contextMenuStrip1;
            this.btn_surfaceBorderColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_surfaceBorderColor.FlatAppearance.BorderSize = 0;
            this.btn_surfaceBorderColor.ForeColor = System.Drawing.Color.White;
            this.btn_surfaceBorderColor.Name = "btn_surfaceBorderColor";
            this.btn_surfaceBorderColor.Tag = "7";
            this.toolTip1.SetToolTip(this.btn_surfaceBorderColor, resources.GetString("btn_surfaceBorderColor.ToolTip"));
            this.btn_surfaceBorderColor.UseVisualStyleBackColor = false;
            this.btn_surfaceBorderColor.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // btn_baseLinkColor
            // 
            resources.ApplyResources(this.btn_baseLinkColor, "btn_baseLinkColor");
            this.btn_baseLinkColor.BackColor = System.Drawing.Color.Black;
            this.btn_baseLinkColor.ContextMenuStrip = this.contextMenuStrip1;
            this.btn_baseLinkColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_baseLinkColor.FlatAppearance.BorderSize = 0;
            this.btn_baseLinkColor.ForeColor = System.Drawing.Color.White;
            this.btn_baseLinkColor.Name = "btn_baseLinkColor";
            this.btn_baseLinkColor.Tag = "5";
            this.toolTip1.SetToolTip(this.btn_baseLinkColor, resources.GetString("btn_baseLinkColor.ToolTip"));
            this.btn_baseLinkColor.UseVisualStyleBackColor = false;
            this.btn_baseLinkColor.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // btn_baseForeColor
            // 
            resources.ApplyResources(this.btn_baseForeColor, "btn_baseForeColor");
            this.btn_baseForeColor.BackColor = System.Drawing.Color.Black;
            this.btn_baseForeColor.ContextMenuStrip = this.contextMenuStrip1;
            this.btn_baseForeColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_baseForeColor.FlatAppearance.BorderSize = 0;
            this.btn_baseForeColor.ForeColor = System.Drawing.Color.White;
            this.btn_baseForeColor.Name = "btn_baseForeColor";
            this.btn_baseForeColor.Tag = "2";
            this.toolTip1.SetToolTip(this.btn_baseForeColor, resources.GetString("btn_baseForeColor.ToolTip"));
            this.btn_baseForeColor.UseVisualStyleBackColor = false;
            this.btn_baseForeColor.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // btn_baseBackColor
            // 
            resources.ApplyResources(this.btn_baseBackColor, "btn_baseBackColor");
            this.btn_baseBackColor.BackColor = System.Drawing.Color.Black;
            this.btn_baseBackColor.ContextMenuStrip = this.contextMenuStrip1;
            this.btn_baseBackColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_baseBackColor.FlatAppearance.BorderSize = 0;
            this.btn_baseBackColor.ForeColor = System.Drawing.Color.White;
            this.btn_baseBackColor.Name = "btn_baseBackColor";
            this.btn_baseBackColor.Tag = "0";
            this.toolTip1.SetToolTip(this.btn_baseBackColor, resources.GetString("btn_baseBackColor.ToolTip"));
            this.btn_baseBackColor.UseVisualStyleBackColor = false;
            this.btn_baseBackColor.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // btn_gridHeaderCellColor
            // 
            resources.ApplyResources(this.btn_gridHeaderCellColor, "btn_gridHeaderCellColor");
            this.btn_gridHeaderCellColor.BackColor = System.Drawing.Color.Black;
            this.btn_gridHeaderCellColor.ContextMenuStrip = this.contextMenuStrip1;
            this.btn_gridHeaderCellColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_gridHeaderCellColor.FlatAppearance.BorderSize = 0;
            this.btn_gridHeaderCellColor.ForeColor = System.Drawing.Color.White;
            this.btn_gridHeaderCellColor.Name = "btn_gridHeaderCellColor";
            this.btn_gridHeaderCellColor.Tag = "10";
            this.toolTip1.SetToolTip(this.btn_gridHeaderCellColor, resources.GetString("btn_gridHeaderCellColor.ToolTip"));
            this.btn_gridHeaderCellColor.UseVisualStyleBackColor = false;
            this.btn_gridHeaderCellColor.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // btn_surfaceHoverColor
            // 
            resources.ApplyResources(this.btn_surfaceHoverColor, "btn_surfaceHoverColor");
            this.btn_surfaceHoverColor.BackColor = System.Drawing.Color.Black;
            this.btn_surfaceHoverColor.ContextMenuStrip = this.contextMenuStrip1;
            this.btn_surfaceHoverColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_surfaceHoverColor.FlatAppearance.BorderSize = 0;
            this.btn_surfaceHoverColor.ForeColor = System.Drawing.Color.White;
            this.btn_surfaceHoverColor.Name = "btn_surfaceHoverColor";
            this.btn_surfaceHoverColor.Tag = "8";
            this.toolTip1.SetToolTip(this.btn_surfaceHoverColor, resources.GetString("btn_surfaceHoverColor.ToolTip"));
            this.btn_surfaceHoverColor.UseVisualStyleBackColor = false;
            this.btn_surfaceHoverColor.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            this.toolTip1.SetToolTip(this.label16, resources.GetString("label16.ToolTip"));
            // 
            // btn_inactiveForeColor
            // 
            resources.ApplyResources(this.btn_inactiveForeColor, "btn_inactiveForeColor");
            this.btn_inactiveForeColor.BackColor = System.Drawing.Color.Black;
            this.btn_inactiveForeColor.ContextMenuStrip = this.contextMenuStrip1;
            this.btn_inactiveForeColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inactiveForeColor.FlatAppearance.BorderSize = 0;
            this.btn_inactiveForeColor.ForeColor = System.Drawing.Color.White;
            this.btn_inactiveForeColor.Name = "btn_inactiveForeColor";
            this.btn_inactiveForeColor.Tag = "6";
            this.toolTip1.SetToolTip(this.btn_inactiveForeColor, resources.GetString("btn_inactiveForeColor.ToolTip"));
            this.btn_inactiveForeColor.UseVisualStyleBackColor = false;
            this.btn_inactiveForeColor.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            this.toolTip1.SetToolTip(this.label15, resources.GetString("label15.ToolTip"));
            // 
            // btn_accentForeColor
            // 
            resources.ApplyResources(this.btn_accentForeColor, "btn_accentForeColor");
            this.btn_accentForeColor.BackColor = System.Drawing.Color.Black;
            this.btn_accentForeColor.ContextMenuStrip = this.contextMenuStrip1;
            this.btn_accentForeColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_accentForeColor.FlatAppearance.BorderSize = 0;
            this.btn_accentForeColor.ForeColor = System.Drawing.Color.White;
            this.btn_accentForeColor.Name = "btn_accentForeColor";
            this.btn_accentForeColor.Tag = "4";
            this.toolTip1.SetToolTip(this.btn_accentForeColor, resources.GetString("btn_accentForeColor.ToolTip"));
            this.btn_accentForeColor.UseVisualStyleBackColor = false;
            this.btn_accentForeColor.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            this.toolTip1.SetToolTip(this.label14, resources.GetString("label14.ToolTip"));
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            this.toolTip1.SetToolTip(this.label13, resources.GetString("label13.ToolTip"));
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            this.toolTip1.SetToolTip(this.label12, resources.GetString("label12.ToolTip"));
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            this.toolTip1.SetToolTip(this.label11, resources.GetString("label11.ToolTip"));
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            this.toolTip1.SetToolTip(this.label10, resources.GetString("label10.ToolTip"));
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            this.toolTip1.SetToolTip(this.label9, resources.GetString("label9.ToolTip"));
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            this.toolTip1.SetToolTip(this.label8, resources.GetString("label8.ToolTip"));
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.toolTip1.SetToolTip(this.label4, resources.GetString("label4.ToolTip"));
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "AccentForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label3.ForeColor = global::DVLD.Properties.Settings.Default.AccentForeColor;
            this.label3.Name = "label3";
            this.toolTip1.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            this.toolTip1.SetToolTip(this.label18, resources.GetString("label18.ToolTip"));
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            this.toolTip1.SetToolTip(this.label17, resources.GetString("label17.ToolTip"));
            // 
            // gb_menuItemsStyle
            // 
            resources.ApplyResources(this.gb_menuItemsStyle, "gb_menuItemsStyle");
            this.gb_menuItemsStyle.Controls.Add(this.rb_fixedHue);
            this.gb_menuItemsStyle.Controls.Add(this.rb_freeValues);
            this.gb_menuItemsStyle.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.gb_menuItemsStyle.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.gb_menuItemsStyle.Name = "gb_menuItemsStyle";
            this.gb_menuItemsStyle.TabStop = false;
            this.toolTip1.SetToolTip(this.gb_menuItemsStyle, resources.GetString("gb_menuItemsStyle.ToolTip"));
            // 
            // rb_fixedHue
            // 
            resources.ApplyResources(this.rb_fixedHue, "rb_fixedHue");
            this.rb_fixedHue.Name = "rb_fixedHue";
            this.rb_fixedHue.Tag = "1";
            this.toolTip1.SetToolTip(this.rb_fixedHue, resources.GetString("rb_fixedHue.ToolTip"));
            this.rb_fixedHue.UseVisualStyleBackColor = true;
            this.rb_fixedHue.CheckedChanged += new System.EventHandler(this.rb_MenuItemStyle_CheckedChanged);
            // 
            // rb_freeValues
            // 
            resources.ApplyResources(this.rb_freeValues, "rb_freeValues");
            this.rb_freeValues.Checked = true;
            this.rb_freeValues.Name = "rb_freeValues";
            this.rb_freeValues.TabStop = true;
            this.rb_freeValues.Tag = "0";
            this.toolTip1.SetToolTip(this.rb_freeValues, resources.GetString("rb_freeValues.ToolTip"));
            this.rb_freeValues.UseVisualStyleBackColor = true;
            this.rb_freeValues.CheckedChanged += new System.EventHandler(this.rb_MenuItemStyle_CheckedChanged);
            // 
            // colorDialog1
            // 
            this.colorDialog1.FullOpen = true;
            // 
            // ll_branchIntoNewTheme
            // 
            resources.ApplyResources(this.ll_branchIntoNewTheme, "ll_branchIntoNewTheme");
            this.ll_branchIntoNewTheme.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ll_branchIntoNewTheme.ForeColor = System.Drawing.Color.Blue;
            this.ll_branchIntoNewTheme.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.ll_branchIntoNewTheme.Name = "ll_branchIntoNewTheme";
            this.ll_branchIntoNewTheme.TabStop = true;
            this.toolTip1.SetToolTip(this.ll_branchIntoNewTheme, resources.GetString("ll_branchIntoNewTheme.ToolTip"));
            this.ll_branchIntoNewTheme.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_branchIntoNewTheme_LinkClicked);
            // 
            // ll_saveChangesToSelectedTheme
            // 
            resources.ApplyResources(this.ll_saveChangesToSelectedTheme, "ll_saveChangesToSelectedTheme");
            this.ll_saveChangesToSelectedTheme.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ll_saveChangesToSelectedTheme.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ll_saveChangesToSelectedTheme.ForeColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.ll_saveChangesToSelectedTheme.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.ll_saveChangesToSelectedTheme.Name = "ll_saveChangesToSelectedTheme";
            this.ll_saveChangesToSelectedTheme.TabStop = true;
            this.toolTip1.SetToolTip(this.ll_saveChangesToSelectedTheme, resources.GetString("ll_saveChangesToSelectedTheme.ToolTip"));
            this.ll_saveChangesToSelectedTheme.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_saveChangesToSelectedTheme_LinkClicked);
            // 
            // ll_deleteSelectedTheme
            // 
            resources.ApplyResources(this.ll_deleteSelectedTheme, "ll_deleteSelectedTheme");
            this.ll_deleteSelectedTheme.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ll_deleteSelectedTheme.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ll_deleteSelectedTheme.ForeColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.ll_deleteSelectedTheme.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.ll_deleteSelectedTheme.Name = "ll_deleteSelectedTheme";
            this.ll_deleteSelectedTheme.TabStop = true;
            this.toolTip1.SetToolTip(this.ll_deleteSelectedTheme, resources.GetString("ll_deleteSelectedTheme.ToolTip"));
            this.ll_deleteSelectedTheme.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_deleteSelectedTheme_LinkClicked);
            // 
            // ll_renameSelectedTheme
            // 
            resources.ApplyResources(this.ll_renameSelectedTheme, "ll_renameSelectedTheme");
            this.ll_renameSelectedTheme.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ll_renameSelectedTheme.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ll_renameSelectedTheme.ForeColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.ll_renameSelectedTheme.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.ll_renameSelectedTheme.Name = "ll_renameSelectedTheme";
            this.ll_renameSelectedTheme.TabStop = true;
            this.toolTip1.SetToolTip(this.ll_renameSelectedTheme, resources.GetString("ll_renameSelectedTheme.ToolTip"));
            this.ll_renameSelectedTheme.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_renameSelectedTheme_LinkClicked);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 1500;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Notice";
            // 
            // Frm_ApplicationSettings
            // 
            this.AcceptButton = this.btn_apply;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.CancelButton = this.btn_close;
            this.Controls.Add(this.ll_deleteSelectedTheme);
            this.Controls.Add(this.ll_saveChangesToSelectedTheme);
            this.Controls.Add(this.ll_branchIntoNewTheme);
            this.Controls.Add(this.gb_menuItemsStyle);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.cb_theme);
            this.Controls.Add(this.cb_colorMode);
            this.Controls.Add(this.lbl_theme);
            this.Controls.Add(this.lbl_colorMode);
            this.Controls.Add(this.cb_language);
            this.Controls.Add(this.lbl_language);
            this.Controls.Add(this.ll_renameSelectedTheme);
            this.Controls.Add(this.pnl_themeValues);
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("TitleBarColorMode", global::DVLD.Properties.Settings.Default, "TitleBarColorMode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ApplicationSettings";
            this.TitleBarColorMode = global::DVLD.Properties.Settings.Default.TitleBarColorMode;
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.Load += new System.EventHandler(this.Frm_Settings_Load);
            this.pnl_themeValues.ResumeLayout(false);
            this.pnl_themeValues.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.gb_menuItemsStyle.ResumeLayout(false);
            this.gb_menuItemsStyle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_language;
        private Salem.Controls.SalDropDownList cb_language;
        private System.Windows.Forms.Label lbl_colorMode;
        private System.Windows.Forms.Label lbl_theme;
        private Salem.Controls.SalDropDownList cb_colorMode;
        private Salem.Controls.SalDropDownList cb_theme;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.Panel pnl_themeValues;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_accentForeColor;
        private System.Windows.Forms.Button btn_baseForeColor;
        private System.Windows.Forms.Button btn_baseBackColor;
        private System.Windows.Forms.Button btn_gridHeaderCellColor;
        private System.Windows.Forms.Button btn_surfaceHoverColor;
        private System.Windows.Forms.Button btn_inactiveForeColor;
        private System.Windows.Forms.Button btn_strongForeColor;
        private System.Windows.Forms.Button btn_surfaceBackColor;
        private System.Windows.Forms.Button btn_gridHeaderHighlightColor;
        private System.Windows.Forms.Button btn_inactiveTabColor;
        private System.Windows.Forms.Button btn_surfaceBorderColor;
        private System.Windows.Forms.Button btn_baseLinkColor;
        private System.Windows.Forms.GroupBox gb_menuItemsStyle;
        private System.Windows.Forms.RadioButton rb_freeValues;
        private System.Windows.Forms.RadioButton rb_fixedHue;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lbl_selectedTheme;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_menuItemHoverBorderColor;
        private System.Windows.Forms.Button btn_menuItemHoverColor;
        private System.Windows.Forms.Button btn_mainMenuBackColor;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btn_selectHue;
        private System.Windows.Forms.LinkLabel ll_branchIntoNewTheme;
        private System.Windows.Forms.LinkLabel ll_saveChangesToSelectedTheme;
        private System.Windows.Forms.LinkLabel ll_deleteSelectedTheme;
        private System.Windows.Forms.LinkLabel ll_renameSelectedTheme;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}