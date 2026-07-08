namespace DVLD.Detain_Licenses.Controls {
    partial class Ctrl_LicenseDetainInfo {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ctrl_LicenseDetainInfo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_licenseID = new Salem.Controls.SalSelectableLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_createdBy = new Salem.Controls.SalSelectableLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_detainID = new Salem.Controls.SalSelectableLabel();
            this.lbl_detainDate = new Salem.Controls.SalSelectableLabel();
            this.salSelectableLabel1 = new Salem.Controls.SalSelectableLabel();
            this.salSelectableLabel2 = new Salem.Controls.SalSelectableLabel();
            this.salSelectableLabel3 = new Salem.Controls.SalSelectableLabel();
            this.salSelectableLabel4 = new Salem.Controls.SalSelectableLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.salSelectableLabel3);
            this.groupBox1.Controls.Add(this.salSelectableLabel4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.salSelectableLabel2);
            this.groupBox1.Controls.Add(this.salSelectableLabel1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbl_licenseID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lbl_createdBy);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbl_detainID);
            this.groupBox1.Controls.Add(this.lbl_detainDate);
            this.groupBox1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F);
            this.groupBox1.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(15, 15, 20, 0);
            this.groupBox1.Size = new System.Drawing.Size(780, 214);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detain Info";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Image = global::DVLD.Properties.Resources.money_32;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(423, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 30);
            this.label4.TabIndex = 103;
            this.label4.Text = "Fine Fees:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_licenseID
            // 
            this.lbl_licenseID.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_licenseID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_licenseID.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F);
            this.lbl_licenseID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_licenseID.Location = new System.Drawing.Point(585, 41);
            this.lbl_licenseID.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lbl_licenseID.Multiline = true;
            this.lbl_licenseID.Name = "lbl_licenseID";
            this.lbl_licenseID.ReadOnly = true;
            this.lbl_licenseID.Size = new System.Drawing.Size(172, 30);
            this.lbl_licenseID.TabIndex = 100;
            this.lbl_licenseID.TabStop = false;
            this.lbl_licenseID.Text = "[???]";
            this.lbl_licenseID.WordWrap = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Image = global::DVLD.Properties.Resources.money_32;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(15, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 30);
            this.label3.TabIndex = 98;
            this.label3.Text = "Application Fees:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Image = global::DVLD.Properties.Resources.Number_32;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(15, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 30);
            this.label1.TabIndex = 94;
            this.label1.Text = "Detain ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Image = global::DVLD.Properties.Resources.LocalDriving_License;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(423, 38);
            this.label10.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 30);
            this.label10.TabIndex = 99;
            this.label10.Text = "L. License ID:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Image = global::DVLD.Properties.Resources.User_32__2;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(423, 75);
            this.label8.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 30);
            this.label8.TabIndex = 101;
            this.label8.Text = "Created By:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_createdBy
            // 
            this.lbl_createdBy.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_createdBy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_createdBy.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_createdBy.Location = new System.Drawing.Point(585, 79);
            this.lbl_createdBy.Multiline = true;
            this.lbl_createdBy.Name = "lbl_createdBy";
            this.lbl_createdBy.ReadOnly = true;
            this.lbl_createdBy.Size = new System.Drawing.Size(172, 30);
            this.lbl_createdBy.TabIndex = 102;
            this.lbl_createdBy.TabStop = false;
            this.lbl_createdBy.Text = "[???]";
            this.lbl_createdBy.WordWrap = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(15, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 30);
            this.label2.TabIndex = 96;
            this.label2.Text = "Detain Date:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_detainID
            // 
            this.lbl_detainID.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_detainID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_detainID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_detainID.Location = new System.Drawing.Point(192, 41);
            this.lbl_detainID.Multiline = true;
            this.lbl_detainID.Name = "lbl_detainID";
            this.lbl_detainID.ReadOnly = true;
            this.lbl_detainID.Size = new System.Drawing.Size(231, 30);
            this.lbl_detainID.TabIndex = 95;
            this.lbl_detainID.TabStop = false;
            this.lbl_detainID.Text = "[???]";
            this.lbl_detainID.WordWrap = false;
            // 
            // lbl_detainDate
            // 
            this.lbl_detainDate.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_detainDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_detainDate.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F);
            this.lbl_detainDate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_detainDate.Location = new System.Drawing.Point(192, 78);
            this.lbl_detainDate.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lbl_detainDate.Multiline = true;
            this.lbl_detainDate.Name = "lbl_detainDate";
            this.lbl_detainDate.ReadOnly = true;
            this.lbl_detainDate.Size = new System.Drawing.Size(231, 30);
            this.lbl_detainDate.TabIndex = 97;
            this.lbl_detainDate.TabStop = false;
            this.lbl_detainDate.Text = "[???]";
            this.lbl_detainDate.WordWrap = false;
            // 
            // salSelectableLabel1
            // 
            this.salSelectableLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.salSelectableLabel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.salSelectableLabel1.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F);
            this.salSelectableLabel1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.salSelectableLabel1.Location = new System.Drawing.Point(192, 115);
            this.salSelectableLabel1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.salSelectableLabel1.Multiline = true;
            this.salSelectableLabel1.Name = "salSelectableLabel1";
            this.salSelectableLabel1.ReadOnly = true;
            this.salSelectableLabel1.Size = new System.Drawing.Size(231, 30);
            this.salSelectableLabel1.TabIndex = 104;
            this.salSelectableLabel1.TabStop = false;
            this.salSelectableLabel1.Text = "[???]";
            this.salSelectableLabel1.WordWrap = false;
            // 
            // salSelectableLabel2
            // 
            this.salSelectableLabel2.BackColor = System.Drawing.SystemColors.Control;
            this.salSelectableLabel2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.salSelectableLabel2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.salSelectableLabel2.Location = new System.Drawing.Point(585, 115);
            this.salSelectableLabel2.Multiline = true;
            this.salSelectableLabel2.Name = "salSelectableLabel2";
            this.salSelectableLabel2.ReadOnly = true;
            this.salSelectableLabel2.Size = new System.Drawing.Size(172, 30);
            this.salSelectableLabel2.TabIndex = 105;
            this.salSelectableLabel2.TabStop = false;
            this.salSelectableLabel2.Text = "[???]";
            this.salSelectableLabel2.WordWrap = false;
            // 
            // salSelectableLabel3
            // 
            this.salSelectableLabel3.BackColor = System.Drawing.SystemColors.Control;
            this.salSelectableLabel3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.salSelectableLabel3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.salSelectableLabel3.Location = new System.Drawing.Point(585, 151);
            this.salSelectableLabel3.Multiline = true;
            this.salSelectableLabel3.Name = "salSelectableLabel3";
            this.salSelectableLabel3.ReadOnly = true;
            this.salSelectableLabel3.Size = new System.Drawing.Size(172, 30);
            this.salSelectableLabel3.TabIndex = 109;
            this.salSelectableLabel3.TabStop = false;
            this.salSelectableLabel3.Text = "[???]";
            this.salSelectableLabel3.WordWrap = false;
            // 
            // salSelectableLabel4
            // 
            this.salSelectableLabel4.BackColor = System.Drawing.SystemColors.Control;
            this.salSelectableLabel4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.salSelectableLabel4.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F);
            this.salSelectableLabel4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.salSelectableLabel4.Location = new System.Drawing.Point(192, 151);
            this.salSelectableLabel4.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.salSelectableLabel4.Multiline = true;
            this.salSelectableLabel4.Name = "salSelectableLabel4";
            this.salSelectableLabel4.ReadOnly = true;
            this.salSelectableLabel4.Size = new System.Drawing.Size(231, 30);
            this.salSelectableLabel4.TabIndex = 108;
            this.salSelectableLabel4.TabStop = false;
            this.salSelectableLabel4.Text = "[???]";
            this.salSelectableLabel4.WordWrap = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Image = global::DVLD.Properties.Resources.money_32;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(423, 148);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 30);
            this.label5.TabIndex = 107;
            this.label5.Text = "Fine Fees:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Image = global::DVLD.Properties.Resources.money_32;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(15, 148);
            this.label6.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 30);
            this.label6.TabIndex = 106;
            this.label6.Text = "Total Fees:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Ctrl_LicenseDetainInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.groupBox1);
            this.Name = "Ctrl_LicenseDetainInfo";
            this.Size = new System.Drawing.Size(780, 214);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private Salem.Controls.SalSelectableLabel lbl_licenseID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private Salem.Controls.SalSelectableLabel lbl_createdBy;
        private System.Windows.Forms.Label label2;
        private Salem.Controls.SalSelectableLabel lbl_detainID;
        private Salem.Controls.SalSelectableLabel lbl_detainDate;
        private Salem.Controls.SalSelectableLabel salSelectableLabel3;
        private Salem.Controls.SalSelectableLabel salSelectableLabel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Salem.Controls.SalSelectableLabel salSelectableLabel2;
        private Salem.Controls.SalSelectableLabel salSelectableLabel1;
    }
}
