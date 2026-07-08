namespace DVLD.Permissions {
    partial class Frm_ApplicationSettingsAccess {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ApplicationSettingsAccess));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_changeTheme = new System.Windows.Forms.CheckBox();
            this.chk_deleteTheme = new System.Windows.Forms.CheckBox();
            this.chk_renameTheme = new System.Windows.Forms.CheckBox();
            this.chk_editThemeValues = new System.Windows.Forms.CheckBox();
            this.chk_createNewTheme = new System.Windows.Forms.CheckBox();
            this.chk_changeColorMode = new System.Windows.Forms.CheckBox();
            this.chk_changeLanguage = new System.Windows.Forms.CheckBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.chk_changeTheme);
            this.groupBox1.Controls.Add(this.chk_deleteTheme);
            this.groupBox1.Controls.Add(this.chk_renameTheme);
            this.groupBox1.Controls.Add(this.chk_editThemeValues);
            this.groupBox1.Controls.Add(this.chk_createNewTheme);
            this.groupBox1.Controls.Add(this.chk_changeColorMode);
            this.groupBox1.Controls.Add(this.chk_changeLanguage);
            this.groupBox1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupBox1.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // chk_changeTheme
            // 
            resources.ApplyResources(this.chk_changeTheme, "chk_changeTheme");
            this.chk_changeTheme.Name = "chk_changeTheme";
            this.chk_changeTheme.UseVisualStyleBackColor = true;
            this.chk_changeTheme.CheckedChanged += new System.EventHandler(this.chk_changeTheme_CheckedChanged);
            // 
            // chk_deleteTheme
            // 
            resources.ApplyResources(this.chk_deleteTheme, "chk_deleteTheme");
            this.chk_deleteTheme.Name = "chk_deleteTheme";
            this.chk_deleteTheme.UseVisualStyleBackColor = true;
            this.chk_deleteTheme.CheckedChanged += new System.EventHandler(this.chk_deleteTheme_CheckedChanged);
            // 
            // chk_renameTheme
            // 
            resources.ApplyResources(this.chk_renameTheme, "chk_renameTheme");
            this.chk_renameTheme.Name = "chk_renameTheme";
            this.chk_renameTheme.UseVisualStyleBackColor = true;
            this.chk_renameTheme.CheckedChanged += new System.EventHandler(this.chk_renameTheme_CheckedChanged);
            // 
            // chk_editThemeValues
            // 
            resources.ApplyResources(this.chk_editThemeValues, "chk_editThemeValues");
            this.chk_editThemeValues.Name = "chk_editThemeValues";
            this.chk_editThemeValues.UseVisualStyleBackColor = true;
            this.chk_editThemeValues.CheckedChanged += new System.EventHandler(this.chk_editThemeValues_CheckedChanged);
            // 
            // chk_createNewTheme
            // 
            resources.ApplyResources(this.chk_createNewTheme, "chk_createNewTheme");
            this.chk_createNewTheme.Name = "chk_createNewTheme";
            this.chk_createNewTheme.UseVisualStyleBackColor = true;
            this.chk_createNewTheme.CheckedChanged += new System.EventHandler(this.chk_createNewTheme_CheckedChanged);
            // 
            // chk_changeColorMode
            // 
            resources.ApplyResources(this.chk_changeColorMode, "chk_changeColorMode");
            this.chk_changeColorMode.Name = "chk_changeColorMode";
            this.chk_changeColorMode.UseVisualStyleBackColor = true;
            this.chk_changeColorMode.CheckedChanged += new System.EventHandler(this.chk_changeColorMode_CheckedChanged);
            // 
            // chk_changeLanguage
            // 
            resources.ApplyResources(this.chk_changeLanguage, "chk_changeLanguage");
            this.chk_changeLanguage.Name = "chk_changeLanguage";
            this.chk_changeLanguage.UseVisualStyleBackColor = true;
            this.chk_changeLanguage.CheckedChanged += new System.EventHandler(this.chk_changeLanguage_CheckedChanged);
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
            // Frm_ApplicationSettingsAccess
            // 
            this.AcceptButton = this.btn_ok;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.groupBox1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("TitleBarColorMode", global::DVLD.Properties.Settings.Default, "TitleBarColorMode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ApplicationSettingsAccess";
            this.TitleBarColorMode = global::DVLD.Properties.Settings.Default.TitleBarColorMode;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.CheckBox chk_changeLanguage;
        private System.Windows.Forms.CheckBox chk_editThemeValues;
        private System.Windows.Forms.CheckBox chk_createNewTheme;
        private System.Windows.Forms.CheckBox chk_changeColorMode;
        private System.Windows.Forms.CheckBox chk_renameTheme;
        private System.Windows.Forms.CheckBox chk_deleteTheme;
        private System.Windows.Forms.CheckBox chk_changeTheme;
    }
}