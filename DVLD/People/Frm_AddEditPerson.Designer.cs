namespace DVLD.People {
    partial class Frm_AddEditPerson {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AddEditPerson));
            this.label_title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_personID = new Salem.Controls.SalSelectableLabel();
            this.button_save = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel_clearImage = new System.Windows.Forms.LinkLabel();
            this.linkLabel_setImage = new System.Windows.Forms.LinkLabel();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox_nationality = new Salem.Controls.SalDropDownEdit();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_email = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox_image = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stretchImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_phone = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButton_female = new System.Windows.Forms.RadioButton();
            this.radioButton_male = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker_dateOfBirth = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_nationalNum = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_lastName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.textBox_thirdName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.textBox_secondName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.textBox_firstName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_address = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_email)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_phone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePicker_dateOfBirth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePicker_dateOfBirth.Calendar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_nationalNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_lastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_thirdName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_secondName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_firstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_address)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "AccentForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.label_title, "label_title");
            this.label_title.ForeColor = global::DVLD.Properties.Settings.Default.AccentForeColor;
            this.label_title.Name = "label_title";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Image = global::DVLD.Properties.Resources.Number_32;
            this.label2.Name = "label2";
            // 
            // label_personID
            // 
            this.label_personID.BackColor = System.Drawing.SystemColors.Control;
            this.label_personID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.label_personID, "label_personID");
            this.label_personID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label_personID.Name = "label_personID";
            this.label_personID.ReadOnly = true;
            this.label_personID.TabStop = false;
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
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.linkLabel_clearImage);
            this.panel1.Controls.Add(this.linkLabel_setImage);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.comboBox_nationality);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.textBox_email);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.pictureBox_image);
            this.panel1.Controls.Add(this.textBox_phone);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.radioButton_female);
            this.panel1.Controls.Add(this.radioButton_male);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dateTimePicker_dateOfBirth);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox_nationalNum);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_lastName);
            this.panel1.Controls.Add(this.textBox_thirdName);
            this.panel1.Controls.Add(this.textBox_secondName);
            this.panel1.Controls.Add(this.textBox_firstName);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.textBox_address);
            this.panel1.Name = "panel1";
            // 
            // linkLabel_clearImage
            // 
            resources.ApplyResources(this.linkLabel_clearImage, "linkLabel_clearImage");
            this.linkLabel_clearImage.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.linkLabel_clearImage.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.linkLabel_clearImage.Name = "linkLabel_clearImage";
            this.linkLabel_clearImage.TabStop = true;
            this.linkLabel_clearImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_clearImage_LinkClicked);
            // 
            // linkLabel_setImage
            // 
            resources.ApplyResources(this.linkLabel_setImage, "linkLabel_setImage");
            this.linkLabel_setImage.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.linkLabel_setImage.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.linkLabel_setImage.Name = "linkLabel_setImage";
            this.linkLabel_setImage.TabStop = true;
            this.linkLabel_setImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_setImage_LinkClicked);
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Image = global::DVLD.Properties.Resources.Address_32;
            this.label12.Name = "label12";
            // 
            // comboBox_nationality
            // 
            this.comboBox_nationality.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_nationality.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_nationality.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.comboBox_nationality.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.comboBox_nationality.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboBox_nationality.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboBox_nationality.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboBox_nationality.DataBindings.Add(new System.Windows.Forms.Binding("DropDownArrowColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboBox_nationality.DataBindings.Add(new System.Windows.Forms.Binding("DropDownMouseOverBackColor", global::DVLD.Properties.Settings.Default, "SurfaceHoverColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboBox_nationality.DropDownArrowColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            resources.ApplyResources(this.comboBox_nationality, "comboBox_nationality");
            this.comboBox_nationality.DropDownMouseOverBackColor = global::DVLD.Properties.Settings.Default.SurfaceHoverColor;
            this.comboBox_nationality.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.comboBox_nationality.FormattingEnabled = true;
            this.errorProvider1.SetIconPadding(this.comboBox_nationality, ((int)(resources.GetObject("comboBox_nationality.IconPadding"))));
            this.comboBox_nationality.Name = "comboBox_nationality";
            this.comboBox_nationality.Sorted = true;
            this.comboBox_nationality.TabStop = false;
            this.comboBox_nationality.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox_nationality_Validating);
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Image = global::DVLD.Properties.Resources.Country_32;
            this.label11.Name = "label11";
            // 
            // textBox_email
            // 
            this.textBox_email.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.textBox_email.BeforeTouchSize = new System.Drawing.Size(552, 109);
            this.textBox_email.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.textBox_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_email.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_email.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_email.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_email.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetIconPadding(this.textBox_email, ((int)(resources.GetObject("textBox_email.IconPadding"))));
            resources.ApplyResources(this.textBox_email, "textBox_email");
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.TextChanged += new System.EventHandler(this.textBox_trim_clearError_TextChanged);
            this.textBox_email.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_email_Validating);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Image = global::DVLD.Properties.Resources.Email_32;
            this.label10.Name = "label10";
            // 
            // pictureBox_image
            // 
            this.pictureBox_image.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.pictureBox_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_image.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox_image.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pictureBox_image.Image = global::DVLD.Properties.Resources.Male_512;
            resources.ApplyResources(this.pictureBox_image, "pictureBox_image");
            this.pictureBox_image.Name = "pictureBox_image";
            this.pictureBox_image.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stretchImageToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowCheckMargin = true;
            this.contextMenuStrip1.ShowImageMargin = false;
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // stretchImageToolStripMenuItem
            // 
            this.stretchImageToolStripMenuItem.CheckOnClick = true;
            resources.ApplyResources(this.stretchImageToolStripMenuItem, "stretchImageToolStripMenuItem");
            this.stretchImageToolStripMenuItem.Name = "stretchImageToolStripMenuItem";
            this.stretchImageToolStripMenuItem.CheckedChanged += new System.EventHandler(this.stretchImageToolStripMenuItem_CheckedChanged);
            // 
            // textBox_phone
            // 
            this.textBox_phone.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.textBox_phone.BeforeTouchSize = new System.Drawing.Size(552, 109);
            this.textBox_phone.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.textBox_phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_phone.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_phone.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_phone.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_phone.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetIconPadding(this.textBox_phone, ((int)(resources.GetObject("textBox_phone.IconPadding"))));
            resources.ApplyResources(this.textBox_phone, "textBox_phone");
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.TextChanged += new System.EventHandler(this.textBox_trim_clearError_TextChanged);
            this.textBox_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_digitsOnly_KeyPress);
            this.textBox_phone.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_normalRequiredField_Validating);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Image = global::DVLD.Properties.Resources.Phone_32;
            this.label9.Name = "label9";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.Woman_32;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // radioButton_female
            // 
            resources.ApplyResources(this.radioButton_female, "radioButton_female");
            this.radioButton_female.Name = "radioButton_female";
            this.radioButton_female.UseVisualStyleBackColor = true;
            this.radioButton_female.CheckedChanged += new System.EventHandler(this.radioButton_gender_CheckedChanged);
            // 
            // radioButton_male
            // 
            resources.ApplyResources(this.radioButton_male, "radioButton_male");
            this.radioButton_male.Checked = true;
            this.radioButton_male.Name = "radioButton_male";
            this.radioButton_male.TabStop = true;
            this.radioButton_male.UseVisualStyleBackColor = true;
            this.radioButton_male.CheckedChanged += new System.EventHandler(this.radioButton_gender_CheckedChanged);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Image = global::DVLD.Properties.Resources.Man_32;
            this.label8.Name = "label8";
            // 
            // dateTimePicker_dateOfBirth
            // 
            this.dateTimePicker_dateOfBirth.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.dateTimePicker_dateOfBirth.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.dateTimePicker_dateOfBirth.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.dateTimePicker_dateOfBirth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // 
            // 
            this.dateTimePicker_dateOfBirth.Calendar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateTimePicker_dateOfBirth.Calendar.BottomHeight = 6;
            this.dateTimePicker_dateOfBirth.Calendar.DayNamesColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.dateTimePicker_dateOfBirth.Calendar.DayNamesFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dateTimePicker_dateOfBirth.Calendar.DaysColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dateTimePicker_dateOfBirth.Calendar.Font = ((System.Drawing.Font)(resources.GetObject("dateTimePicker_dateOfBirth.Calendar.Font")));
            this.dateTimePicker_dateOfBirth.Calendar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dateTimePicker_dateOfBirth.Calendar.GridBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dateTimePicker_dateOfBirth.Calendar.GridLines = Syncfusion.Windows.Forms.Grid.GridBorderStyle.None;
            this.dateTimePicker_dateOfBirth.Calendar.HeaderFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker_dateOfBirth.Calendar.HeaderStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dateTimePicker_dateOfBirth.Calendar.HeadForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dateTimePicker_dateOfBirth.Calendar.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.dateTimePicker_dateOfBirth.Calendar.InactiveMonthColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dateTimePicker_dateOfBirth.Calendar.Location = ((System.Drawing.Point)(resources.GetObject("dateTimePicker_dateOfBirth.Calendar.Location")));
            this.dateTimePicker_dateOfBirth.Calendar.Name = "monthCalendar";
            this.dateTimePicker_dateOfBirth.Calendar.ScrollButtonSize = new System.Drawing.Size(24, 24);
            this.dateTimePicker_dateOfBirth.Calendar.Size = ((System.Drawing.Size)(resources.GetObject("dateTimePicker_dateOfBirth.Calendar.Size")));
            this.dateTimePicker_dateOfBirth.Calendar.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            this.dateTimePicker_dateOfBirth.Calendar.TabIndex = ((int)(resources.GetObject("dateTimePicker_dateOfBirth.Calendar.TabIndex")));
            // 
            // 
            // 
            this.dateTimePicker_dateOfBirth.Calendar.NoneButton.AutoSize = ((bool)(resources.GetObject("dateTimePicker_dateOfBirth.Calendar.NoneButton.AutoSize")));
            this.dateTimePicker_dateOfBirth.Calendar.NoneButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dateTimePicker_dateOfBirth.Calendar.NoneButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("dateTimePicker_dateOfBirth.Calendar.NoneButton.ImeMode")));
            this.dateTimePicker_dateOfBirth.Calendar.NoneButton.KeepFocusRectangle = false;
            this.dateTimePicker_dateOfBirth.Calendar.NoneButton.Location = ((System.Drawing.Point)(resources.GetObject("dateTimePicker_dateOfBirth.Calendar.NoneButton.Location")));
            this.dateTimePicker_dateOfBirth.Calendar.NoneButton.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("dateTimePicker_dateOfBirth.Calendar.NoneButton.Margin")));
            this.dateTimePicker_dateOfBirth.Calendar.NoneButton.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dateTimePicker_dateOfBirth.Calendar.NoneButton.ThemeName = "Metro";
            // 
            // 
            // 
            this.dateTimePicker_dateOfBirth.Calendar.TodayButton.AutoSize = ((bool)(resources.GetObject("dateTimePicker_dateOfBirth.Calendar.TodayButton.AutoSize")));
            this.dateTimePicker_dateOfBirth.Calendar.TodayButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dateTimePicker_dateOfBirth.Calendar.TodayButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("dateTimePicker_dateOfBirth.Calendar.TodayButton.ImeMode")));
            this.dateTimePicker_dateOfBirth.Calendar.TodayButton.KeepFocusRectangle = false;
            this.dateTimePicker_dateOfBirth.Calendar.TodayButton.Location = ((System.Drawing.Point)(resources.GetObject("dateTimePicker_dateOfBirth.Calendar.TodayButton.Location")));
            this.dateTimePicker_dateOfBirth.Calendar.TodayButton.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("dateTimePicker_dateOfBirth.Calendar.TodayButton.Margin")));
            this.dateTimePicker_dateOfBirth.Calendar.TodayButton.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dateTimePicker_dateOfBirth.Calendar.TodayButton.ThemeName = "Metro";
            this.dateTimePicker_dateOfBirth.CalendarFont = new System.Drawing.Font("Tahoma", 8F);
            this.dateTimePicker_dateOfBirth.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dateTimePicker_dateOfBirth.CalendarSize = new System.Drawing.Size(189, 176);
            this.dateTimePicker_dateOfBirth.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dateTimePicker_dateOfBirth.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dateTimePicker_dateOfBirth.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dateTimePicker_dateOfBirth.CustomFormat = "ddd, dd/MM/yyyy";
            this.dateTimePicker_dateOfBirth.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dateTimePicker_dateOfBirth.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dateTimePicker_dateOfBirth.DataBindings.Add(new System.Windows.Forms.Binding("Style", global::DVLD.Properties.Settings.Default, "DateTimePickerStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dateTimePicker_dateOfBirth.DataBindings.Add(new System.Windows.Forms.Binding("DropDownSelectedColor", global::DVLD.Properties.Settings.Default, "SurfaceHoverColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dateTimePicker_dateOfBirth.DropDownImage = null;
            this.dateTimePicker_dateOfBirth.DropDownNormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dateTimePicker_dateOfBirth.DropDownPressedColor = System.Drawing.Color.Gray;
            this.dateTimePicker_dateOfBirth.DropDownSelectedColor = global::DVLD.Properties.Settings.Default.SurfaceHoverColor;
            resources.ApplyResources(this.dateTimePicker_dateOfBirth, "dateTimePicker_dateOfBirth");
            this.dateTimePicker_dateOfBirth.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.dateTimePicker_dateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_dateOfBirth.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.dateTimePicker_dateOfBirth.MinValue = new System.DateTime(((long)(0)));
            this.dateTimePicker_dateOfBirth.Name = "dateTimePicker_dateOfBirth";
            this.dateTimePicker_dateOfBirth.NoneButtonVisible = false;
            this.dateTimePicker_dateOfBirth.ShowCheckBox = false;
            this.dateTimePicker_dateOfBirth.Style = global::DVLD.Properties.Settings.Default.DateTimePickerStyle;
            this.dateTimePicker_dateOfBirth.Value = new System.DateTime(2026, 5, 2, 15, 37, 2, 613);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Image = global::DVLD.Properties.Resources.Calendar_32;
            this.label7.Name = "label7";
            // 
            // textBox_nationalNum
            // 
            this.textBox_nationalNum.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.textBox_nationalNum.BeforeTouchSize = new System.Drawing.Size(552, 109);
            this.textBox_nationalNum.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.textBox_nationalNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_nationalNum.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_nationalNum.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_nationalNum.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_nationalNum.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetIconPadding(this.textBox_nationalNum, ((int)(resources.GetObject("textBox_nationalNum.IconPadding"))));
            resources.ApplyResources(this.textBox_nationalNum, "textBox_nationalNum");
            this.textBox_nationalNum.Name = "textBox_nationalNum";
            this.textBox_nationalNum.TextChanged += new System.EventHandler(this.textBox_trim_clearError_TextChanged);
            this.textBox_nationalNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_digitsOnly_KeyPress);
            this.textBox_nationalNum.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_nationalNum_Validating);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Image = global::DVLD.Properties.Resources.Number_32;
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // textBox_lastName
            // 
            this.textBox_lastName.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.textBox_lastName.BeforeTouchSize = new System.Drawing.Size(552, 109);
            this.textBox_lastName.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.textBox_lastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_lastName.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_lastName.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_lastName.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_lastName.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetIconPadding(this.textBox_lastName, ((int)(resources.GetObject("textBox_lastName.IconPadding"))));
            resources.ApplyResources(this.textBox_lastName, "textBox_lastName");
            this.textBox_lastName.Name = "textBox_lastName";
            this.textBox_lastName.TextChanged += new System.EventHandler(this.textBox_trim_clearError_TextChanged);
            this.textBox_lastName.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_normalRequiredField_Validating);
            // 
            // textBox_thirdName
            // 
            this.textBox_thirdName.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.textBox_thirdName.BeforeTouchSize = new System.Drawing.Size(552, 109);
            this.textBox_thirdName.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.textBox_thirdName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_thirdName.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_thirdName.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_thirdName.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_thirdName.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            resources.ApplyResources(this.textBox_thirdName, "textBox_thirdName");
            this.textBox_thirdName.Name = "textBox_thirdName";
            // 
            // textBox_secondName
            // 
            this.textBox_secondName.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.textBox_secondName.BeforeTouchSize = new System.Drawing.Size(552, 109);
            this.textBox_secondName.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.textBox_secondName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_secondName.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_secondName.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_secondName.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_secondName.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetIconPadding(this.textBox_secondName, ((int)(resources.GetObject("textBox_secondName.IconPadding"))));
            resources.ApplyResources(this.textBox_secondName, "textBox_secondName");
            this.textBox_secondName.Name = "textBox_secondName";
            this.textBox_secondName.TextChanged += new System.EventHandler(this.textBox_trim_clearError_TextChanged);
            this.textBox_secondName.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_normalRequiredField_Validating);
            // 
            // textBox_firstName
            // 
            this.textBox_firstName.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.textBox_firstName.BeforeTouchSize = new System.Drawing.Size(552, 109);
            this.textBox_firstName.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.textBox_firstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_firstName.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_firstName.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_firstName.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_firstName.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetIconPadding(this.textBox_firstName, ((int)(resources.GetObject("textBox_firstName.IconPadding"))));
            resources.ApplyResources(this.textBox_firstName, "textBox_firstName");
            this.textBox_firstName.Name = "textBox_firstName";
            this.textBox_firstName.TextChanged += new System.EventHandler(this.textBox_trim_clearError_TextChanged);
            this.textBox_firstName.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_normalRequiredField_Validating);
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Image = global::DVLD.Properties.Resources.Person_32;
            this.label13.Name = "label13";
            // 
            // textBox_address
            // 
            this.textBox_address.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.textBox_address.BeforeTouchSize = new System.Drawing.Size(552, 109);
            this.textBox_address.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.textBox_address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_address.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_address.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_address.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_address.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetIconPadding(this.textBox_address, ((int)(resources.GetObject("textBox_address.IconPadding"))));
            resources.ApplyResources(this.textBox_address, "textBox_address");
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.TextChanged += new System.EventHandler(this.textBox_trim_clearError_TextChanged);
            this.textBox_address.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_normalRequiredField_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
            // 
            // Frm_AddEditPerson
            // 
            this.AcceptButton = this.button_save;
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.CancelButton = this.button_close;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.label_personID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_title);
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("TitleBarColorMode", global::DVLD.Properties.Settings.Default, "TitleBarColorMode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_AddEditPerson";
            this.TitleBarColorMode = global::DVLD.Properties.Settings.Default.TitleBarColorMode;
            this.Load += new System.EventHandler(this.Frm_AddEditPerson_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Frm_AddEditPerson_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Frm_AddEditPerson_DragEnter);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_email)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textBox_phone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePicker_dateOfBirth.Calendar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePicker_dateOfBirth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_nationalNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_lastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_thirdName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_secondName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_firstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_address)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label2;
        private Salem.Controls.SalSelectableLabel label_personID;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel_clearImage;
        private System.Windows.Forms.LinkLabel linkLabel_setImage;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBox_address;
        private System.Windows.Forms.Label label12;
        private Salem.Controls.SalDropDownEdit comboBox_nationality;
        private System.Windows.Forms.Label label11;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBox_email;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox_image;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBox_phone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButton_female;
        private System.Windows.Forms.RadioButton radioButton_male;
        private System.Windows.Forms.Label label8;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv dateTimePicker_dateOfBirth;
        private System.Windows.Forms.Label label7;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBox_nationalNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBox_lastName;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBox_thirdName;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBox_secondName;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBox_firstName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stretchImageToolStripMenuItem;
    }
}