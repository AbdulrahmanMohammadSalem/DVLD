namespace DVLD.Tests {
    partial class Frm_TakeTest {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_TakeTest));
            this.button_close = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.rb_pass = new System.Windows.Forms.RadioButton();
            this.rb_fail = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBx_notes = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.ctrl_ScehduledTest1 = new DVLD.Tests.Controls.Ctrl_ScehduledTest();
            ((System.ComponentModel.ISupportInitialize)(this.txtBx_notes)).BeginInit();
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
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Image = global::DVLD.Properties.Resources.Result_32;
            this.label8.Name = "label8";
            // 
            // rb_pass
            // 
            this.rb_pass.Checked = true;
            resources.ApplyResources(this.rb_pass, "rb_pass");
            this.rb_pass.Name = "rb_pass";
            this.rb_pass.TabStop = true;
            this.rb_pass.UseVisualStyleBackColor = true;
            // 
            // rb_fail
            // 
            resources.ApplyResources(this.rb_fail, "rb_fail");
            this.rb_fail.Name = "rb_fail";
            this.rb_fail.TabStop = true;
            this.rb_fail.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Image = global::DVLD.Properties.Resources.Notes_32;
            this.label9.Name = "label9";
            // 
            // txtBx_notes
            // 
            this.txtBx_notes.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.txtBx_notes.BeforeTouchSize = new System.Drawing.Size(379, 103);
            this.txtBx_notes.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.txtBx_notes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBx_notes.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtBx_notes.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtBx_notes.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.txtBx_notes, "txtBx_notes");
            this.txtBx_notes.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.txtBx_notes.Name = "txtBx_notes";
            // 
            // ctrl_ScehduledTest1
            // 
            resources.ApplyResources(this.ctrl_ScehduledTest1, "ctrl_ScehduledTest1");
            this.ctrl_ScehduledTest1.Name = "ctrl_ScehduledTest1";
            this.ctrl_ScehduledTest1.TestAppointmentID = -1;
            this.ctrl_ScehduledTest1.CloseRequested += new System.Action(this.ctrl_ScehduledTest1_CloseRequested);
            // 
            // Frm_TakeTest
            // 
            this.AcceptButton = this.button_save;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.CancelButton = this.button_close;
            this.Controls.Add(this.ctrl_ScehduledTest1);
            this.Controls.Add(this.txtBx_notes);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rb_fail);
            this.Controls.Add(this.rb_pass);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_save);
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("TitleBarColorMode", global::DVLD.Properties.Settings.Default, "TitleBarColorMode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_TakeTest";
            this.TitleBarColorMode = global::DVLD.Properties.Settings.Default.TitleBarColorMode;
            this.Load += new System.EventHandler(this.Frm_TakeTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtBx_notes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rb_pass;
        private System.Windows.Forms.RadioButton rb_fail;
        private System.Windows.Forms.Label label9;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtBx_notes;
        private Controls.Ctrl_ScehduledTest ctrl_ScehduledTest1;
    }
}