namespace TutDB
{
    partial class StudentRegistration
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
            this.components = new System.ComponentModel.Container();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFatherName = new System.Windows.Forms.Label();
            this.lblMotherName = new System.Windows.Forms.Label();
            this.lblDob = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.tblCity = new System.Windows.Forms.Label();
            this.tblCourse = new System.Windows.Forms.Label();
            this.lblBatch = new System.Windows.Forms.Label();
            this.lblLastQualification = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblAdmitdate = new System.Windows.Forms.Label();
            this.lblFees = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.txtMotherName = new System.Windows.Forms.TextBox();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.txtFees = new System.Windows.Forms.TextBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.cmbBatch = new System.Windows.Forms.ComboBox();
            this.dtpAdmitDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDob = new System.Windows.Forms.DateTimePicker();
            this.cmbLastQualification = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.lblFatherContacts = new System.Windows.Forms.Label();
            this.lblMontherContacts = new System.Windows.Forms.Label();
            this.txtMotherContacts = new System.Windows.Forms.TextBox();
            this.txtFatherContacts = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblRseContacts = new System.Windows.Forms.Label();
            this.lblContacs = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtResiContacts = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.cmbLastQualificationScore = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblActualFees = new System.Windows.Forms.Label();
            this.txtActualFees = new System.Windows.Forms.TextBox();
            this.linkLabel_editStudent = new System.Windows.Forms.LinkLabel();
            this.linkLabel_deleteStudent = new System.Windows.Forms.LinkLabel();
            this.lblNoImage = new System.Windows.Forms.Label();
            this.dataGridView_studentAllocation = new System.Windows.Forms.DataGridView();
            this.comboBox_isStudentActive = new System.Windows.Forms.ComboBox();
            this.label_isStudentActive = new System.Windows.Forms.Label();
            this.linkLabel_AddNewAllocation = new System.Windows.Forms.LinkLabel();
            this.tblGenderMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCityMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCourseMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblBatchMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.linkLabel_viewAllocation = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_studentAllocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGenderMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCityMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCourseMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBatchMasterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(148, 64);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(67, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(293, 64);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(69, 13);
            this.lblMiddleName.TabIndex = 1;
            this.lblMiddleName.Text = "Middle Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(466, 64);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(63, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "LastName";
            // 
            // lblFatherName
            // 
            this.lblFatherName.AutoSize = true;
            this.lblFatherName.Location = new System.Drawing.Point(21, 94);
            this.lblFatherName.Name = "lblFatherName";
            this.lblFatherName.Size = new System.Drawing.Size(75, 13);
            this.lblFatherName.TabIndex = 3;
            this.lblFatherName.Text = "Father\'s Name";
            // 
            // lblMotherName
            // 
            this.lblMotherName.AutoSize = true;
            this.lblMotherName.Location = new System.Drawing.Point(24, 132);
            this.lblMotherName.Name = "lblMotherName";
            this.lblMotherName.Size = new System.Drawing.Size(81, 13);
            this.lblMotherName.TabIndex = 4;
            this.lblMotherName.Text = "Mother\'s  Name";
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDob.Location = new System.Drawing.Point(27, 165);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(29, 17);
            this.lblDob.TabIndex = 5;
            this.lblDob.Text = "DOB";
            this.lblDob.UseCompatibleTextRendering = true;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(25, 202);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(48, 13);
            this.lblGender.TabIndex = 6;
            this.lblGender.Text = "Gender";
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress1.Location = new System.Drawing.Point(25, 272);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(59, 13);
            this.lblAddress1.TabIndex = 7;
            this.lblAddress1.Text = "Address1";
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Location = new System.Drawing.Point(25, 299);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(51, 13);
            this.lblAddress2.TabIndex = 8;
            this.lblAddress2.Text = "Address2";
            // 
            // tblCity
            // 
            this.tblCity.AutoSize = true;
            this.tblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblCity.Location = new System.Drawing.Point(25, 328);
            this.tblCity.Name = "tblCity";
            this.tblCity.Size = new System.Drawing.Size(28, 13);
            this.tblCity.TabIndex = 9;
            this.tblCity.Text = "City";
            // 
            // tblCourse
            // 
            this.tblCourse.AutoSize = true;
            this.tblCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblCourse.Location = new System.Drawing.Point(24, 358);
            this.tblCourse.Name = "tblCourse";
            this.tblCourse.Size = new System.Drawing.Size(46, 13);
            this.tblCourse.TabIndex = 10;
            this.tblCourse.Text = "Course";
            // 
            // lblBatch
            // 
            this.lblBatch.AutoSize = true;
            this.lblBatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatch.Location = new System.Drawing.Point(25, 393);
            this.lblBatch.Name = "lblBatch";
            this.lblBatch.Size = new System.Drawing.Size(40, 13);
            this.lblBatch.TabIndex = 11;
            this.lblBatch.Text = "Batch";
            // 
            // lblLastQualification
            // 
            this.lblLastQualification.AutoSize = true;
            this.lblLastQualification.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastQualification.Location = new System.Drawing.Point(318, 354);
            this.lblLastQualification.Name = "lblLastQualification";
            this.lblLastQualification.Size = new System.Drawing.Size(106, 13);
            this.lblLastQualification.TabIndex = 12;
            this.lblLastQualification.Text = "Last Qualification";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(321, 393);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(35, 13);
            this.lblScore.TabIndex = 13;
            this.lblScore.Text = "Score";
            // 
            // lblAdmitdate
            // 
            this.lblAdmitdate.AutoSize = true;
            this.lblAdmitdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmitdate.Location = new System.Drawing.Point(321, 428);
            this.lblAdmitdate.Name = "lblAdmitdate";
            this.lblAdmitdate.Size = new System.Drawing.Size(69, 13);
            this.lblAdmitdate.TabIndex = 14;
            this.lblAdmitdate.Text = "Admit Date";
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Location = new System.Drawing.Point(648, 298);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(30, 13);
            this.lblFees.TabIndex = 15;
            this.lblFees.Text = "Fees";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(111, 41);
            this.txtFirstName.MaxLength = 30;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(141, 20);
            this.txtFirstName.TabIndex = 16;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(258, 41);
            this.txtMiddleName.MaxLength = 30;
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(158, 20);
            this.txtMiddleName.TabIndex = 17;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(422, 41);
            this.txtLastName.MaxLength = 30;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(159, 20);
            this.txtLastName.TabIndex = 18;
            // 
            // txtFatherName
            // 
            this.txtFatherName.Location = new System.Drawing.Point(111, 91);
            this.txtFatherName.MaxLength = 50;
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(185, 20);
            this.txtFatherName.TabIndex = 19;
            // 
            // txtMotherName
            // 
            this.txtMotherName.Location = new System.Drawing.Point(111, 125);
            this.txtMotherName.MaxLength = 50;
            this.txtMotherName.Name = "txtMotherName";
            this.txtMotherName.Size = new System.Drawing.Size(185, 20);
            this.txtMotherName.TabIndex = 20;
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(111, 269);
            this.txtAddress1.MaxLength = 100;
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(470, 20);
            this.txtAddress1.TabIndex = 22;
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(111, 295);
            this.txtAddress2.MaxLength = 100;
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(470, 20);
            this.txtAddress2.TabIndex = 23;
            // 
            // txtFees
            // 
            this.txtFees.Location = new System.Drawing.Point(729, 293);
            this.txtFees.MaxLength = 10;
            this.txtFees.Name = "txtFees";
            this.txtFees.Size = new System.Drawing.Size(121, 20);
            this.txtFees.TabIndex = 24;
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Select"});
            this.cmbGender.Location = new System.Drawing.Point(111, 198);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(185, 21);
            this.cmbGender.TabIndex = 26;
            // 
            // cmbCity
            // 
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Items.AddRange(new object[] {
            "Select"});
            this.cmbCity.Location = new System.Drawing.Point(111, 325);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(185, 21);
            this.cmbCity.TabIndex = 27;
            // 
            // cmbCourse
            // 
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Location = new System.Drawing.Point(111, 358);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(185, 21);
            this.cmbCourse.TabIndex = 28;
            // 
            // cmbBatch
            // 
            this.cmbBatch.FormattingEnabled = true;
            this.cmbBatch.Location = new System.Drawing.Point(111, 390);
            this.cmbBatch.Name = "cmbBatch";
            this.cmbBatch.Size = new System.Drawing.Size(185, 21);
            this.cmbBatch.TabIndex = 29;
            // 
            // dtpAdmitDate
            // 
            this.dtpAdmitDate.Location = new System.Drawing.Point(422, 422);
            this.dtpAdmitDate.Name = "dtpAdmitDate";
            this.dtpAdmitDate.Size = new System.Drawing.Size(159, 20);
            this.dtpAdmitDate.TabIndex = 30;
            // 
            // dtpDob
            // 
            this.dtpDob.Location = new System.Drawing.Point(111, 165);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(185, 20);
            this.dtpDob.TabIndex = 31;
            // 
            // cmbLastQualification
            // 
            this.cmbLastQualification.FormattingEnabled = true;
            this.cmbLastQualification.Items.AddRange(new object[] {
            "Xth S.S.C.",
            "Xth H.S.C"});
            this.cmbLastQualification.Location = new System.Drawing.Point(422, 351);
            this.cmbLastQualification.Name = "cmbLastQualification";
            this.cmbLastQualification.Size = new System.Drawing.Size(159, 21);
            this.cmbLastQualification.TabIndex = 32;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(775, 418);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 33;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(648, 332);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(49, 13);
            this.lblDiscount.TabIndex = 34;
            this.lblDiscount.Text = "Discount";
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Location = new System.Drawing.Point(648, 398);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(43, 13);
            this.lblDeposit.TabIndex = 35;
            this.lblDeposit.Text = "Deposit";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(729, 329);
            this.txtDiscount.MaxLength = 10;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(121, 20);
            this.txtDiscount.TabIndex = 36;
            this.txtDiscount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_KeyDown);
            // 
            // txtDeposit
            // 
            this.txtDeposit.Location = new System.Drawing.Point(729, 393);
            this.txtDeposit.MaxLength = 10;
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(121, 20);
            this.txtDeposit.TabIndex = 37;
            // 
            // lblFatherContacts
            // 
            this.lblFatherContacts.AutoSize = true;
            this.lblFatherContacts.Location = new System.Drawing.Point(321, 94);
            this.lblFatherContacts.Name = "lblFatherContacts";
            this.lblFatherContacts.Size = new System.Drawing.Size(49, 13);
            this.lblFatherContacts.TabIndex = 38;
            this.lblFatherContacts.Text = "Contacts";
            // 
            // lblMontherContacts
            // 
            this.lblMontherContacts.AutoSize = true;
            this.lblMontherContacts.Location = new System.Drawing.Point(321, 128);
            this.lblMontherContacts.Name = "lblMontherContacts";
            this.lblMontherContacts.Size = new System.Drawing.Size(49, 13);
            this.lblMontherContacts.TabIndex = 39;
            this.lblMontherContacts.Text = "Contacts";
            // 
            // txtMotherContacts
            // 
            this.txtMotherContacts.Location = new System.Drawing.Point(422, 125);
            this.txtMotherContacts.MaxLength = 11;
            this.txtMotherContacts.Name = "txtMotherContacts";
            this.txtMotherContacts.Size = new System.Drawing.Size(159, 20);
            this.txtMotherContacts.TabIndex = 40;
            // 
            // txtFatherContacts
            // 
            this.txtFatherContacts.Location = new System.Drawing.Point(422, 91);
            this.txtFatherContacts.MaxLength = 11;
            this.txtFatherContacts.Name = "txtFatherContacts";
            this.txtFatherContacts.Size = new System.Drawing.Size(159, 20);
            this.txtFatherContacts.TabIndex = 41;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(24, 230);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 42;
            this.lblEmail.Text = "Email";
            // 
            // lblRseContacts
            // 
            this.lblRseContacts.AutoSize = true;
            this.lblRseContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRseContacts.Location = new System.Drawing.Point(318, 328);
            this.lblRseContacts.Name = "lblRseContacts";
            this.lblRseContacts.Size = new System.Drawing.Size(86, 13);
            this.lblRseContacts.TabIndex = 43;
            this.lblRseContacts.Text = "Resi Contacts";
            // 
            // lblContacs
            // 
            this.lblContacs.AutoSize = true;
            this.lblContacs.Location = new System.Drawing.Point(321, 165);
            this.lblContacs.Name = "lblContacs";
            this.lblContacs.Size = new System.Drawing.Size(38, 13);
            this.lblContacs.TabIndex = 44;
            this.lblContacs.Text = "Mobile";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(111, 230);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(470, 20);
            this.txtEmail.TabIndex = 45;
            // 
            // txtResiContacts
            // 
            this.txtResiContacts.Location = new System.Drawing.Point(422, 321);
            this.txtResiContacts.MaxLength = 11;
            this.txtResiContacts.Name = "txtResiContacts";
            this.txtResiContacts.Size = new System.Drawing.Size(159, 20);
            this.txtResiContacts.TabIndex = 46;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(422, 165);
            this.txtMobile.MaxLength = 11;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(159, 20);
            this.txtMobile.TabIndex = 47;
            // 
            // cmbLastQualificationScore
            // 
            this.cmbLastQualificationScore.FormattingEnabled = true;
            this.cmbLastQualificationScore.Items.AddRange(new object[] {
            "0% - 10%",
            "11% - 20%",
            "21% - 30%",
            "31% - 40%",
            "41% - 50%",
            "51% - 60%",
            "61% - 70%",
            "71% - 80%",
            "81% - 90%",
            "91% - 10%"});
            this.cmbLastQualificationScore.Location = new System.Drawing.Point(422, 388);
            this.cmbLastQualificationScore.Name = "cmbLastQualificationScore";
            this.cmbLastQualificationScore.Size = new System.Drawing.Size(159, 21);
            this.cmbLastQualificationScore.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Name";
            // 
            // picBox
            // 
            this.picBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox.Location = new System.Drawing.Point(706, 41);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(144, 141);
            this.picBox.TabIndex = 50;
            this.picBox.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(775, 195);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 51;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblActualFees
            // 
            this.lblActualFees.AutoSize = true;
            this.lblActualFees.Location = new System.Drawing.Point(648, 366);
            this.lblActualFees.Name = "lblActualFees";
            this.lblActualFees.Size = new System.Drawing.Size(63, 13);
            this.lblActualFees.TabIndex = 52;
            this.lblActualFees.Text = "Actual Fees";
            // 
            // txtActualFees
            // 
            this.txtActualFees.Location = new System.Drawing.Point(729, 363);
            this.txtActualFees.MaxLength = 10;
            this.txtActualFees.Name = "txtActualFees";
            this.txtActualFees.Size = new System.Drawing.Size(121, 20);
            this.txtActualFees.TabIndex = 53;
            // 
            // linkLabel_editStudent
            // 
            this.linkLabel_editStudent.AutoSize = true;
            this.linkLabel_editStudent.Location = new System.Drawing.Point(651, 422);
            this.linkLabel_editStudent.Name = "linkLabel_editStudent";
            this.linkLabel_editStudent.Size = new System.Drawing.Size(25, 13);
            this.linkLabel_editStudent.TabIndex = 54;
            this.linkLabel_editStudent.TabStop = true;
            this.linkLabel_editStudent.Text = "Edit";
            this.linkLabel_editStudent.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_editStudent_LinkClicked);
            // 
            // linkLabel_deleteStudent
            // 
            this.linkLabel_deleteStudent.AutoSize = true;
            this.linkLabel_deleteStudent.Location = new System.Drawing.Point(686, 423);
            this.linkLabel_deleteStudent.Name = "linkLabel_deleteStudent";
            this.linkLabel_deleteStudent.Size = new System.Drawing.Size(38, 13);
            this.linkLabel_deleteStudent.TabIndex = 55;
            this.linkLabel_deleteStudent.TabStop = true;
            this.linkLabel_deleteStudent.Text = "Delete";
            this.linkLabel_deleteStudent.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_deleteStudent_LinkClicked);
            // 
            // lblNoImage
            // 
            this.lblNoImage.AutoSize = true;
            this.lblNoImage.Location = new System.Drawing.Point(753, 107);
            this.lblNoImage.Name = "lblNoImage";
            this.lblNoImage.Size = new System.Drawing.Size(53, 13);
            this.lblNoImage.TabIndex = 56;
            this.lblNoImage.Text = "No Image";
            // 
            // dataGridView_studentAllocation
            // 
            this.dataGridView_studentAllocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_studentAllocation.Location = new System.Drawing.Point(28, 517);
            this.dataGridView_studentAllocation.Name = "dataGridView_studentAllocation";
            this.dataGridView_studentAllocation.Size = new System.Drawing.Size(553, 107);
            this.dataGridView_studentAllocation.TabIndex = 57;
            // 
            // comboBox_isStudentActive
            // 
            this.comboBox_isStudentActive.FormattingEnabled = true;
            this.comboBox_isStudentActive.Location = new System.Drawing.Point(133, 478);
            this.comboBox_isStudentActive.Name = "comboBox_isStudentActive";
            this.comboBox_isStudentActive.Size = new System.Drawing.Size(121, 21);
            this.comboBox_isStudentActive.TabIndex = 59;
            this.comboBox_isStudentActive.SelectedIndexChanged += new System.EventHandler(this.comboBox_isStudentActive_SelectedIndexChanged);
            // 
            // label_isStudentActive
            // 
            this.label_isStudentActive.AutoSize = true;
            this.label_isStudentActive.Location = new System.Drawing.Point(25, 481);
            this.label_isStudentActive.Name = "label_isStudentActive";
            this.label_isStudentActive.Size = new System.Drawing.Size(88, 13);
            this.label_isStudentActive.TabIndex = 61;
            this.label_isStudentActive.Text = "Is Student Active";
            // 
            // linkLabel_AddNewAllocation
            // 
            this.linkLabel_AddNewAllocation.AutoSize = true;
            this.linkLabel_AddNewAllocation.Location = new System.Drawing.Point(481, 486);
            this.linkLabel_AddNewAllocation.Name = "linkLabel_AddNewAllocation";
            this.linkLabel_AddNewAllocation.Size = new System.Drawing.Size(100, 13);
            this.linkLabel_AddNewAllocation.TabIndex = 62;
            this.linkLabel_AddNewAllocation.TabStop = true;
            this.linkLabel_AddNewAllocation.Text = "Add New Allocation";
            this.linkLabel_AddNewAllocation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_AddNewAllocation_LinkClicked);
            // 
            // tblGenderMasterBindingSource
            // 
            this.tblGenderMasterBindingSource.DataMember = "tblGenderMaster";
            // 
            // tblCityMasterBindingSource
            // 
            this.tblCityMasterBindingSource.DataMember = "tblCityMaster";
            // 
            // tblCourseMasterBindingSource
            // 
            this.tblCourseMasterBindingSource.DataMember = "tblCourseMaster";
            // 
            // tblBatchMasterBindingSource
            // 
            this.tblBatchMasterBindingSource.DataMember = "tblBatchMaster";
            // 
            // linkLabel_viewAllocation
            // 
            this.linkLabel_viewAllocation.AutoSize = true;
            this.linkLabel_viewAllocation.Location = new System.Drawing.Point(396, 486);
            this.linkLabel_viewAllocation.Name = "linkLabel_viewAllocation";
            this.linkLabel_viewAllocation.Size = new System.Drawing.Size(79, 13);
            this.linkLabel_viewAllocation.TabIndex = 63;
            this.linkLabel_viewAllocation.TabStop = true;
            this.linkLabel_viewAllocation.Text = "View Allocation";
            this.linkLabel_viewAllocation.Visible = false;
            this.linkLabel_viewAllocation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_viewAllocation_LinkClicked);
            // 
            // StudentRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 636);
            this.Controls.Add(this.linkLabel_viewAllocation);
            this.Controls.Add(this.linkLabel_AddNewAllocation);
            this.Controls.Add(this.label_isStudentActive);
            this.Controls.Add(this.comboBox_isStudentActive);
            this.Controls.Add(this.dataGridView_studentAllocation);
            this.Controls.Add(this.lblNoImage);
            this.Controls.Add(this.linkLabel_deleteStudent);
            this.Controls.Add(this.linkLabel_editStudent);
            this.Controls.Add(this.txtActualFees);
            this.Controls.Add(this.lblActualFees);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbLastQualificationScore);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.txtResiContacts);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblContacs);
            this.Controls.Add(this.lblRseContacts);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtFatherContacts);
            this.Controls.Add(this.txtMotherContacts);
            this.Controls.Add(this.lblMontherContacts);
            this.Controls.Add(this.lblFatherContacts);
            this.Controls.Add(this.txtDeposit);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.lblDeposit);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cmbLastQualification);
            this.Controls.Add(this.dtpDob);
            this.Controls.Add(this.dtpAdmitDate);
            this.Controls.Add(this.cmbBatch);
            this.Controls.Add(this.cmbCourse);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.txtFees);
            this.Controls.Add(this.txtAddress2);
            this.Controls.Add(this.txtAddress1);
            this.Controls.Add(this.txtMotherName);
            this.Controls.Add(this.txtFatherName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFees);
            this.Controls.Add(this.lblAdmitdate);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblLastQualification);
            this.Controls.Add(this.lblBatch);
            this.Controls.Add(this.tblCourse);
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
            this.Name = "StudentRegistration";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.StudentRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_studentAllocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGenderMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCityMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCourseMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBatchMasterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFatherName;
        private System.Windows.Forms.Label lblMotherName;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.Label tblCity;
        private System.Windows.Forms.Label tblCourse;
        private System.Windows.Forms.Label lblBatch;
        private System.Windows.Forms.Label lblLastQualification;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblAdmitdate;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.TextBox txtMotherName;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.TextBox txtFees;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.ComboBox cmbBatch;
        private System.Windows.Forms.DateTimePicker dtpAdmitDate;
        private System.Windows.Forms.DateTimePicker dtpDob;
        private System.Windows.Forms.ComboBox cmbLastQualification;
        private System.Windows.Forms.Button btnSubmit;

        private System.Windows.Forms.BindingSource tblGenderMasterBindingSource;

        private System.Windows.Forms.BindingSource tblCityMasterBindingSource;

        private System.Windows.Forms.BindingSource tblCourseMasterBindingSource;

        private System.Windows.Forms.BindingSource tblBatchMasterBindingSource;

        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.Label lblFatherContacts;
        private System.Windows.Forms.Label lblMontherContacts;
        private System.Windows.Forms.TextBox txtMotherContacts;
        private System.Windows.Forms.TextBox txtFatherContacts;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblRseContacts;
        private System.Windows.Forms.Label lblContacs;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtResiContacts;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.ComboBox cmbLastQualificationScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblActualFees;
        private System.Windows.Forms.TextBox txtActualFees;
        private System.Windows.Forms.LinkLabel linkLabel_editStudent;
        private System.Windows.Forms.LinkLabel linkLabel_deleteStudent;
        private System.Windows.Forms.Label lblNoImage;
        private System.Windows.Forms.DataGridView dataGridView_studentAllocation;
        private System.Windows.Forms.ComboBox comboBox_isStudentActive;
        private System.Windows.Forms.Label label_isStudentActive;
        private System.Windows.Forms.LinkLabel linkLabel_AddNewAllocation;
        private System.Windows.Forms.LinkLabel linkLabel_viewAllocation;
    }
}

