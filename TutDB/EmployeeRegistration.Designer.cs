namespace TutDB
{
    partial class EmployeeRegistration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNoImage = new System.Windows.Forms.Label();
            this.linkLabel_deleteEmployee = new System.Windows.Forms.LinkLabel();
            this.linkLabel_editEmployee = new System.Windows.Forms.LinkLabel();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtResiContacts = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblContacs = new System.Windows.Forms.Label();
            this.lblRseContacts = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cmbQualification = new System.Windows.Forms.ComboBox();
            this.dtpDob = new System.Windows.Forms.DateTimePicker();
            this.dtpJoiningDate = new System.Windows.Forms.DateTimePicker();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblJoiningDate = new System.Windows.Forms.Label();
            this.lblQualification = new System.Windows.Forms.Label();
            this.tblCity = new System.Windows.Forms.Label();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblDob = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblFatherName = new System.Windows.Forms.Label();
            this.lblMotherName = new System.Windows.Forms.Label();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.txtMotherName = new System.Windows.Forms.TextBox();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.cmbDesignation = new System.Windows.Forms.ComboBox();
            this.checkedListBox_subjects = new System.Windows.Forms.CheckedListBox();
            this.lblSubjects = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNoImage
            // 
            this.lblNoImage.AutoSize = true;
            this.lblNoImage.Location = new System.Drawing.Point(738, 110);
            this.lblNoImage.Name = "lblNoImage";
            this.lblNoImage.Size = new System.Drawing.Size(53, 13);
            this.lblNoImage.TabIndex = 111;
            this.lblNoImage.Text = "No Image";
            // 
            // linkLabel_deleteEmployee
            // 
            this.linkLabel_deleteEmployee.AutoSize = true;
            this.linkLabel_deleteEmployee.Location = new System.Drawing.Point(671, 426);
            this.linkLabel_deleteEmployee.Name = "linkLabel_deleteEmployee";
            this.linkLabel_deleteEmployee.Size = new System.Drawing.Size(38, 13);
            this.linkLabel_deleteEmployee.TabIndex = 110;
            this.linkLabel_deleteEmployee.TabStop = true;
            this.linkLabel_deleteEmployee.Text = "Delete";
            this.linkLabel_deleteEmployee.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_deleteEmployee_LinkClicked);
            // 
            // linkLabel_editEmployee
            // 
            this.linkLabel_editEmployee.AutoSize = true;
            this.linkLabel_editEmployee.Location = new System.Drawing.Point(636, 425);
            this.linkLabel_editEmployee.Name = "linkLabel_editEmployee";
            this.linkLabel_editEmployee.Size = new System.Drawing.Size(25, 13);
            this.linkLabel_editEmployee.TabIndex = 109;
            this.linkLabel_editEmployee.TabStop = true;
            this.linkLabel_editEmployee.Text = "Edit";
            this.linkLabel_editEmployee.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_editEmployee_LinkClicked);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(760, 198);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 106;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // picBox
            // 
            this.picBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox.Location = new System.Drawing.Point(691, 44);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(144, 141);
            this.picBox.TabIndex = 105;
            this.picBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 104;
            this.label1.Text = "Name";
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(434, 168);
            this.txtMobile.MaxLength = 11;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(159, 20);
            this.txtMobile.TabIndex = 102;
            // 
            // txtResiContacts
            // 
            this.txtResiContacts.Location = new System.Drawing.Point(434, 325);
            this.txtResiContacts.MaxLength = 10;
            this.txtResiContacts.Name = "txtResiContacts";
            this.txtResiContacts.Size = new System.Drawing.Size(159, 20);
            this.txtResiContacts.TabIndex = 101;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(123, 234);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(470, 20);
            this.txtEmail.TabIndex = 100;
            // 
            // lblContacs
            // 
            this.lblContacs.AutoSize = true;
            this.lblContacs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContacs.Location = new System.Drawing.Point(330, 172);
            this.lblContacs.Name = "lblContacs";
            this.lblContacs.Size = new System.Drawing.Size(44, 13);
            this.lblContacs.TabIndex = 99;
            this.lblContacs.Text = "Mobile";
            // 
            // lblRseContacts
            // 
            this.lblRseContacts.AutoSize = true;
            this.lblRseContacts.Location = new System.Drawing.Point(330, 332);
            this.lblRseContacts.Name = "lblRseContacts";
            this.lblRseContacts.Size = new System.Drawing.Size(73, 13);
            this.lblRseContacts.TabIndex = 98;
            this.lblRseContacts.Text = "Resi Contacts";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(37, 237);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 97;
            this.lblEmail.Text = "Email";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(760, 421);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 88;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cmbQualification
            // 
            this.cmbQualification.FormattingEnabled = true;
            this.cmbQualification.Items.AddRange(new object[] {
            "Xth S.S.C.",
            "Xth H.S.C"});
            this.cmbQualification.Location = new System.Drawing.Point(434, 358);
            this.cmbQualification.Name = "cmbQualification";
            this.cmbQualification.Size = new System.Drawing.Size(159, 21);
            this.cmbQualification.TabIndex = 87;
            // 
            // dtpDob
            // 
            this.dtpDob.Location = new System.Drawing.Point(123, 168);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(185, 20);
            this.dtpDob.TabIndex = 86;
            // 
            // dtpJoiningDate
            // 
            this.dtpJoiningDate.Location = new System.Drawing.Point(437, 397);
            this.dtpJoiningDate.Name = "dtpJoiningDate";
            this.dtpJoiningDate.Size = new System.Drawing.Size(159, 20);
            this.dtpJoiningDate.TabIndex = 85;
            // 
            // cmbCity
            // 
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Items.AddRange(new object[] {
            "Select"});
            this.cmbCity.Location = new System.Drawing.Point(123, 329);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(185, 21);
            this.cmbCity.TabIndex = 82;
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Select"});
            this.cmbGender.Location = new System.Drawing.Point(123, 201);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(185, 21);
            this.cmbGender.TabIndex = 81;
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(123, 299);
            this.txtAddress2.MaxLength = 100;
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(470, 20);
            this.txtAddress2.TabIndex = 79;
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(123, 267);
            this.txtAddress1.MaxLength = 100;
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(470, 20);
            this.txtAddress1.TabIndex = 78;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(434, 44);
            this.txtLastName.MaxLength = 30;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(159, 20);
            this.txtLastName.TabIndex = 75;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(270, 44);
            this.txtMiddleName.MaxLength = 30;
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(158, 20);
            this.txtMiddleName.TabIndex = 74;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(123, 44);
            this.txtFirstName.MaxLength = 30;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(141, 20);
            this.txtFirstName.TabIndex = 73;
            // 
            // lblJoiningDate
            // 
            this.lblJoiningDate.AutoSize = true;
            this.lblJoiningDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoiningDate.Location = new System.Drawing.Point(336, 403);
            this.lblJoiningDate.Name = "lblJoiningDate";
            this.lblJoiningDate.Size = new System.Drawing.Size(78, 13);
            this.lblJoiningDate.TabIndex = 71;
            this.lblJoiningDate.Text = "Joining Date";
            // 
            // lblQualification
            // 
            this.lblQualification.AutoSize = true;
            this.lblQualification.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQualification.Location = new System.Drawing.Point(330, 361);
            this.lblQualification.Name = "lblQualification";
            this.lblQualification.Size = new System.Drawing.Size(78, 13);
            this.lblQualification.TabIndex = 69;
            this.lblQualification.Text = "Qualification";
            // 
            // tblCity
            // 
            this.tblCity.AutoSize = true;
            this.tblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblCity.Location = new System.Drawing.Point(37, 332);
            this.tblCity.Name = "tblCity";
            this.tblCity.Size = new System.Drawing.Size(28, 13);
            this.tblCity.TabIndex = 66;
            this.tblCity.Text = "City";
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Location = new System.Drawing.Point(37, 303);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(51, 13);
            this.lblAddress2.TabIndex = 65;
            this.lblAddress2.Text = "Address2";
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress1.Location = new System.Drawing.Point(37, 270);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(59, 13);
            this.lblAddress1.TabIndex = 64;
            this.lblAddress1.Text = "Address1";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(37, 205);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(48, 13);
            this.lblGender.TabIndex = 63;
            this.lblGender.Text = "Gender";
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDob.Location = new System.Drawing.Point(39, 168);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(29, 17);
            this.lblDob.TabIndex = 62;
            this.lblDob.Text = "DOB";
            this.lblDob.UseCompatibleTextRendering = true;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(478, 67);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(63, 13);
            this.lblLastName.TabIndex = 59;
            this.lblLastName.Text = "LastName";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(305, 67);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(69, 13);
            this.lblMiddleName.TabIndex = 58;
            this.lblMiddleName.Text = "Middle Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(160, 67);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(67, 13);
            this.lblFirstName.TabIndex = 57;
            this.lblFirstName.Text = "First Name";
            // 
            // lblFatherName
            // 
            this.lblFatherName.AutoSize = true;
            this.lblFatherName.Location = new System.Drawing.Point(33, 97);
            this.lblFatherName.Name = "lblFatherName";
            this.lblFatherName.Size = new System.Drawing.Size(75, 13);
            this.lblFatherName.TabIndex = 60;
            this.lblFatherName.Text = "Father\'s Name";
            // 
            // lblMotherName
            // 
            this.lblMotherName.AutoSize = true;
            this.lblMotherName.Location = new System.Drawing.Point(36, 135);
            this.lblMotherName.Name = "lblMotherName";
            this.lblMotherName.Size = new System.Drawing.Size(81, 13);
            this.lblMotherName.TabIndex = 61;
            this.lblMotherName.Text = "Mother\'s  Name";
            // 
            // txtFatherName
            // 
            this.txtFatherName.Location = new System.Drawing.Point(123, 94);
            this.txtFatherName.MaxLength = 50;
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(185, 20);
            this.txtFatherName.TabIndex = 76;
            // 
            // txtMotherName
            // 
            this.txtMotherName.Location = new System.Drawing.Point(123, 128);
            this.txtMotherName.MaxLength = 50;
            this.txtMotherName.Name = "txtMotherName";
            this.txtMotherName.Size = new System.Drawing.Size(185, 20);
            this.txtMotherName.TabIndex = 77;
            // 
            // lblDesignation
            // 
            this.lblDesignation.AllowDrop = true;
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesignation.Location = new System.Drawing.Point(36, 361);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(74, 13);
            this.lblDesignation.TabIndex = 67;
            this.lblDesignation.Text = "Designation";
            // 
            // cmbDesignation
            // 
            this.cmbDesignation.AllowDrop = true;
            this.cmbDesignation.FormattingEnabled = true;
            this.cmbDesignation.Location = new System.Drawing.Point(123, 361);
            this.cmbDesignation.Name = "cmbDesignation";
            this.cmbDesignation.Size = new System.Drawing.Size(185, 21);
            this.cmbDesignation.TabIndex = 83;
            this.cmbDesignation.SelectedIndexChanged += new System.EventHandler(this.cmbDesignation_SelectedIndexChanged);
            // 
            // checkedListBox_subjects
            // 
            this.checkedListBox_subjects.CheckOnClick = true;
            this.checkedListBox_subjects.FormattingEnabled = true;
            this.checkedListBox_subjects.Location = new System.Drawing.Point(671, 288);
            this.checkedListBox_subjects.Name = "checkedListBox_subjects";
            this.checkedListBox_subjects.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox_subjects.TabIndex = 112;
            this.checkedListBox_subjects.Visible = false;
            // 
            // lblSubjects
            // 
            this.lblSubjects.AutoSize = true;
            this.lblSubjects.Location = new System.Drawing.Point(668, 267);
            this.lblSubjects.Name = "lblSubjects";
            this.lblSubjects.Size = new System.Drawing.Size(48, 13);
            this.lblSubjects.TabIndex = 113;
            this.lblSubjects.Text = "Subjects";
            this.lblSubjects.Visible = false;
            // 
            // EmployeeRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 480);
            this.Controls.Add(this.lblSubjects);
            this.Controls.Add(this.checkedListBox_subjects);
            this.Controls.Add(this.lblNoImage);
            this.Controls.Add(this.linkLabel_deleteEmployee);
            this.Controls.Add(this.linkLabel_editEmployee);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.txtResiContacts);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblContacs);
            this.Controls.Add(this.lblRseContacts);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cmbQualification);
            this.Controls.Add(this.dtpDob);
            this.Controls.Add(this.dtpJoiningDate);
            this.Controls.Add(this.cmbDesignation);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.txtAddress2);
            this.Controls.Add(this.txtAddress1);
            this.Controls.Add(this.txtMotherName);
            this.Controls.Add(this.txtFatherName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblJoiningDate);
            this.Controls.Add(this.lblQualification);
            this.Controls.Add(this.lblDesignation);
            this.Controls.Add(this.tblCity);
            this.Controls.Add(this.lblAddress2);
            this.Controls.Add(this.lblAddress1);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblDob);
            this.Controls.Add(this.lblMotherName);
            this.Controls.Add(this.lblFatherName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblMiddleName);
            this.Controls.Add(this.lblFirstName);
            this.Name = "EmployeeRegistration";
            this.Text = "EmployeeRegistration";
            this.Load += new System.EventHandler(this.EmployeeRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNoImage;
        private System.Windows.Forms.LinkLabel linkLabel_deleteEmployee;
        private System.Windows.Forms.LinkLabel linkLabel_editEmployee;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtResiContacts;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblContacs;
        private System.Windows.Forms.Label lblRseContacts;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cmbQualification;
        private System.Windows.Forms.DateTimePicker dtpDob;
        private System.Windows.Forms.DateTimePicker dtpJoiningDate;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblJoiningDate;
        private System.Windows.Forms.Label lblQualification;
        private System.Windows.Forms.Label tblCity;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblFatherName;
        private System.Windows.Forms.Label lblMotherName;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.TextBox txtMotherName;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.ComboBox cmbDesignation;
        private System.Windows.Forms.CheckedListBox checkedListBox_subjects;
        private System.Windows.Forms.Label lblSubjects;
    }
}