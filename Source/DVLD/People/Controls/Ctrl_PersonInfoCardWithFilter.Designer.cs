namespace DVLD.People.Controls {
    partial class Ctrl_PersonInfoCardWithFilter {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ctrl_PersonInfoCardWithFilter));
            this.groupBox_filter = new System.Windows.Forms.GroupBox();
            this.button_addNewPerson = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.txt_filterInput = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.comboBox_filterOptions = new Salem.Controls.SalDropDownList();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ctrl_PersonCard1 = new DVLD.People.Ctrl_PersonInfoCard();
            this.groupBox_filter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_filterInput)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_filter
            // 
            this.groupBox_filter.Controls.Add(this.button_addNewPerson);
            this.groupBox_filter.Controls.Add(this.button_search);
            this.groupBox_filter.Controls.Add(this.txt_filterInput);
            this.groupBox_filter.Controls.Add(this.comboBox_filterOptions);
            this.groupBox_filter.Controls.Add(this.label5);
            this.groupBox_filter.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.groupBox_filter, "groupBox_filter");
            this.groupBox_filter.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.groupBox_filter.Name = "groupBox_filter";
            this.groupBox_filter.TabStop = false;
            // 
            // button_addNewPerson
            // 
            resources.ApplyResources(this.button_addNewPerson, "button_addNewPerson");
            this.button_addNewPerson.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.button_addNewPerson.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button_addNewPerson.Image = global::DVLD.Properties.Resources.AddPerson_32;
            this.button_addNewPerson.Name = "button_addNewPerson";
            this.toolTip1.SetToolTip(this.button_addNewPerson, resources.GetString("button_addNewPerson.ToolTip"));
            this.button_addNewPerson.UseVisualStyleBackColor = false;
            this.button_addNewPerson.Click += new System.EventHandler(this.button_addNewPerson_Click);
            // 
            // button_search
            // 
            resources.ApplyResources(this.button_search, "button_search");
            this.button_search.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.button_search.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button_search.Image = global::DVLD.Properties.Resources.SearchPerson;
            this.button_search.Name = "button_search";
            this.toolTip1.SetToolTip(this.button_search, resources.GetString("button_search.ToolTip"));
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // textBox_filterInput
            // 
            resources.ApplyResources(this.txt_filterInput, "textBox_filterInput");
            this.txt_filterInput.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.txt_filterInput.BeforeTouchSize = new System.Drawing.Size(210, 30);
            this.txt_filterInput.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.txt_filterInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_filterInput.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_filterInput.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_filterInput.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_filterInput.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.txt_filterInput.Name = "textBox_filterInput";
            this.txt_filterInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_filterInput_KeyPress);
            // 
            // comboBox_filterOptions
            // 
            resources.ApplyResources(this.comboBox_filterOptions, "comboBox_filterOptions");
            this.comboBox_filterOptions.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.comboBox_filterOptions.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.comboBox_filterOptions.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboBox_filterOptions.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboBox_filterOptions.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboBox_filterOptions.DataBindings.Add(new System.Windows.Forms.Binding("MouseOverBackColor", global::DVLD.Properties.Settings.Default, "SurfaceHoverColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboBox_filterOptions.DataBindings.Add(new System.Windows.Forms.Binding("DropDownArrowColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboBox_filterOptions.DropDownArrowColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.comboBox_filterOptions.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.comboBox_filterOptions.Items.AddRange(new object[] {
            resources.GetString("comboBox_filterOptions.Items"),
            resources.GetString("comboBox_filterOptions.Items1")});
            this.comboBox_filterOptions.MouseOverBackColor = global::DVLD.Properties.Settings.Default.SurfaceHoverColor;
            this.comboBox_filterOptions.Name = "comboBox_filterOptions";
            this.comboBox_filterOptions.SelectedIndex = -1;
            this.comboBox_filterOptions.TabStop = false;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // ctrl_PersonCard1
            // 
            resources.ApplyResources(this.ctrl_PersonCard1, "ctrl_PersonCard1");
            this.ctrl_PersonCard1.EnableEditingPersonInfo = true;
            this.ctrl_PersonCard1.Name = "ctrl_PersonCard1";
            this.ctrl_PersonCard1.PersonSaved += new System.Action<int>(this._frmAddPerson_PersonSaved);
            // 
            // Ctrl_PersonInfoCardWithFilter
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrl_PersonCard1);
            this.Controls.Add(this.groupBox_filter);
            this.Name = "Ctrl_PersonInfoCardWithFilter";
            this.Load += new System.EventHandler(this.Ctrl_PersonCardWithFilter_Load);
            this.groupBox_filter.ResumeLayout(false);
            this.groupBox_filter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_filterInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_filter;
        private System.Windows.Forms.Label label5;
        private Salem.Controls.SalDropDownList comboBox_filterOptions;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txt_filterInput;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_addNewPerson;
        private System.Windows.Forms.ToolTip toolTip1;
        private Ctrl_PersonInfoCard ctrl_PersonCard1;
    }
}
