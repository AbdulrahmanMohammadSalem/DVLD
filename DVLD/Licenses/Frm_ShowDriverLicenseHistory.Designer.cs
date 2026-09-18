namespace DVLD.Licenses {
    partial class Frm_ShowDriverLicenseHistory {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ShowDriverLicenseHistory));
            this.label_title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_close = new System.Windows.Forms.Button();
            this.ctrl_DriverLicenseHistoryCard1 = new DVLD.Licenses.Controls.Ctrl_DriverLicenseHistoryCard();
            this.ctrl_PersonInfoCardWithFilter1 = new DVLD.People.Controls.Ctrl_PersonInfoCardWithFilter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "AccentForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.label_title, "label_title");
            this.label_title.ForeColor = global::DVLD.Properties.Settings.Default.AccentForeColor;
            this.label_title.Name = "label_title";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BackColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pictureBox1.Image = global::DVLD.Properties.Resources.PersonLicenseHistory_512;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
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
            // ctrl_DriverLicenseHistoryCard1
            // 
            resources.ApplyResources(this.ctrl_DriverLicenseHistoryCard1, "ctrl_DriverLicenseHistoryCard1");
            this.ctrl_DriverLicenseHistoryCard1.Name = "ctrl_DriverLicenseHistoryCard1";
            this.ctrl_DriverLicenseHistoryCard1.DataSaved += new System.Action(this.ctrl_DriverLicenseHistoryCard1_PersonSaved);
            this.ctrl_DriverLicenseHistoryCard1.ForceExit += new System.Action(this.ctrl_DriverLicenseHistoryCard1_ForceExit);
            // 
            // ctrl_PersonInfoCardWithFilter1
            // 
            resources.ApplyResources(this.ctrl_PersonInfoCardWithFilter1, "ctrl_PersonInfoCardWithFilter1");
            this.ctrl_PersonInfoCardWithFilter1.EnableAddingNewPerson = true;
            this.ctrl_PersonInfoCardWithFilter1.EnableEditingPersonInfo = true;
            this.ctrl_PersonInfoCardWithFilter1.EnableFiltering = false;
            this.ctrl_PersonInfoCardWithFilter1.Name = "ctrl_PersonInfoCardWithFilter1";
            this.ctrl_PersonInfoCardWithFilter1.PersonSaved += new System.Action<int>(this.ctrl_PersonInfoCardWithFilter1_PersonSaved);
            // 
            // Frm_ShowDriverLicenseHistory
            // 
            this.AcceptButton = this.button_close;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.CancelButton = this.button_close;
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.ctrl_DriverLicenseHistoryCard1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ctrl_PersonInfoCardWithFilter1);
            this.Controls.Add(this.label_title);
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("TitleBarColorMode", global::DVLD.Properties.Settings.Default, "TitleBarColorMode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.MinimizeBox = false;
            this.Name = "Frm_ShowDriverLicenseHistory";
            this.TitleBarColorMode = global::DVLD.Properties.Settings.Default.TitleBarColorMode;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private People.Controls.Ctrl_PersonInfoCardWithFilter ctrl_PersonInfoCardWithFilter1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Controls.Ctrl_DriverLicenseHistoryCard ctrl_DriverLicenseHistoryCard1;
        private System.Windows.Forms.Button button_close;
    }
}