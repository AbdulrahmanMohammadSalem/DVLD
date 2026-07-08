namespace DVLD.Licenses.Controls {
    partial class Ctrl_LocalLicenseInfoCardWithFilter {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ctrl_LocalLicenseInfoCardWithFilter));
            this.groupBox_filter = new System.Windows.Forms.GroupBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_filterInput = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label5 = new System.Windows.Forms.Label();
            this.ctrl_LocalLicenseInfoCard1 = new DVLD.Licenses.Controls.Ctrl_LocalLicenseInfoCard();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox_filter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_filterInput)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_filter
            // 
            resources.ApplyResources(this.groupBox_filter, "groupBox_filter");
            this.groupBox_filter.Controls.Add(this.btn_search);
            this.groupBox_filter.Controls.Add(this.txt_filterInput);
            this.groupBox_filter.Controls.Add(this.label5);
            this.groupBox_filter.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupBox_filter.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.groupBox_filter.Name = "groupBox_filter";
            this.groupBox_filter.TabStop = false;
            // 
            // button_search
            // 
            resources.ApplyResources(this.btn_search, "button_search");
            this.btn_search.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.btn_search.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_search.Image = global::DVLD.Properties.Resources.License_View_32;
            this.btn_search.Name = "button_search";
            this.toolTip1.SetToolTip(this.btn_search, resources.GetString("button_search.ToolTip"));
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // textBox_filterInput
            // 
            this.txt_filterInput.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.txt_filterInput.BeforeTouchSize = new System.Drawing.Size(389, 30);
            this.txt_filterInput.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.txt_filterInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_filterInput.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_filterInput.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_filterInput.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_filterInput.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            resources.ApplyResources(this.txt_filterInput, "textBox_filterInput");
            this.txt_filterInput.Name = "textBox_filterInput";
            this.txt_filterInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_filterInput_KeyPress);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // ctrl_LocalLicenseInfoCard1
            // 
            resources.ApplyResources(this.ctrl_LocalLicenseInfoCard1, "ctrl_LocalLicenseInfoCard1");
            this.ctrl_LocalLicenseInfoCard1.Name = "ctrl_LocalLicenseInfoCard1";
            this.ctrl_LocalLicenseInfoCard1.PersonSaved += new System.Action<int>(this.ctrl_LocalLicenseInfoCard1_PersonSaved);
            // 
            // Ctrl_LocalLicenseInfoCardWithFilter
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrl_LocalLicenseInfoCard1);
            this.Controls.Add(this.groupBox_filter);
            this.Name = "Ctrl_LocalLicenseInfoCardWithFilter";
            this.groupBox_filter.ResumeLayout(false);
            this.groupBox_filter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_filterInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_filter;
        private System.Windows.Forms.Button btn_search;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txt_filterInput;
        private System.Windows.Forms.Label label5;
        private Ctrl_LocalLicenseInfoCard ctrl_LocalLicenseInfoCard1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
