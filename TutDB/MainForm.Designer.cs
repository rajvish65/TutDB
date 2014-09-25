namespace TutDB
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_refresh = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.linkLabel_addNewCourse = new System.Windows.Forms.LinkLabel();
            this.button_Search = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.groupBox_searchParameters = new System.Windows.Forms.GroupBox();
            this.linkLabel_addNewBatch = new System.Windows.Forms.LinkLabel();
            this.cmbBatch = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox_users = new System.Windows.Forms.GroupBox();
            this.dataGridView_student = new System.Windows.Forms.DataGridView();
            this.groupBox_StudentDetails = new System.Windows.Forms.GroupBox();
            this.linkLabel_feeStructure = new System.Windows.Forms.LinkLabel();
            this.linkLabel_thisUsersDetails = new System.Windows.Forms.LinkLabel();
            this.lblStdBatchName = new System.Windows.Forms.Label();
            this.lblStdBatch = new System.Windows.Forms.Label();
            this.lblStdCourseName = new System.Windows.Forms.Label();
            this.lblStdFullName = new System.Windows.Forms.Label();
            this.lblStdCourse = new System.Windows.Forms.Label();
            this.lblStdName = new System.Windows.Forms.Label();
            this.groupBox_PaymentDetails = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_paymnetLogs = new System.Windows.Forms.DataGridView();
            this.dataGridView_installmentLogs = new System.Windows.Forms.DataGridView();
            this.linkLabel_addStudent = new System.Windows.Forms.LinkLabel();
            this.linkLabel_addEmployee = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel_goToMasters = new System.Windows.Forms.LinkLabel();
            this.groupBox_searchParameters.SuspendLayout();
            this.groupBox_users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_student)).BeginInit();
            this.groupBox_StudentDetails.SuspendLayout();
            this.groupBox_PaymentDetails.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_paymnetLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_installmentLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(422, 21);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(75, 22);
            this.button_refresh.TabIndex = 1;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(222, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 76;
            this.label7.Text = "Batch";
            // 
            // linkLabel_addNewCourse
            // 
            this.linkLabel_addNewCourse.AutoSize = true;
            this.linkLabel_addNewCourse.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel_addNewCourse.Location = new System.Drawing.Point(16, 68);
            this.linkLabel_addNewCourse.Name = "linkLabel_addNewCourse";
            this.linkLabel_addNewCourse.Size = new System.Drawing.Size(57, 13);
            this.linkLabel_addNewCourse.TabIndex = 75;
            this.linkLabel_addNewCourse.TabStop = true;
            this.linkLabel_addNewCourse.Text = "Add New..";
            this.linkLabel_addNewCourse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_addNewCourse_LinkClicked);
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(422, 45);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(75, 23);
            this.button_Search.TabIndex = 5;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(289, 19);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // cmbCourse
            // 
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Location = new System.Drawing.Point(79, 52);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(121, 21);
            this.cmbCourse.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(79, 19);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(121, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // groupBox_searchParameters
            // 
            this.groupBox_searchParameters.Controls.Add(this.linkLabel_addNewBatch);
            this.groupBox_searchParameters.Controls.Add(this.cmbBatch);
            this.groupBox_searchParameters.Controls.Add(this.button_refresh);
            this.groupBox_searchParameters.Controls.Add(this.label7);
            this.groupBox_searchParameters.Controls.Add(this.linkLabel_addNewCourse);
            this.groupBox_searchParameters.Controls.Add(this.button_Search);
            this.groupBox_searchParameters.Controls.Add(this.label3);
            this.groupBox_searchParameters.Controls.Add(this.txtLastName);
            this.groupBox_searchParameters.Controls.Add(this.cmbCourse);
            this.groupBox_searchParameters.Controls.Add(this.label2);
            this.groupBox_searchParameters.Controls.Add(this.label1);
            this.groupBox_searchParameters.Controls.Add(this.txtFirstName);
            this.groupBox_searchParameters.Location = new System.Drawing.Point(12, 12);
            this.groupBox_searchParameters.Name = "groupBox_searchParameters";
            this.groupBox_searchParameters.Size = new System.Drawing.Size(516, 93);
            this.groupBox_searchParameters.TabIndex = 1;
            this.groupBox_searchParameters.TabStop = false;
            this.groupBox_searchParameters.Text = "Search Parameters";
            // 
            // linkLabel_addNewBatch
            // 
            this.linkLabel_addNewBatch.AutoSize = true;
            this.linkLabel_addNewBatch.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel_addNewBatch.Location = new System.Drawing.Point(206, 68);
            this.linkLabel_addNewBatch.Name = "linkLabel_addNewBatch";
            this.linkLabel_addNewBatch.Size = new System.Drawing.Size(57, 13);
            this.linkLabel_addNewBatch.TabIndex = 80;
            this.linkLabel_addNewBatch.TabStop = true;
            this.linkLabel_addNewBatch.Text = "Add New..";
            this.linkLabel_addNewBatch.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_addNewBatch_LinkClicked);
            // 
            // cmbBatch
            // 
            this.cmbBatch.FormattingEnabled = true;
            this.cmbBatch.Location = new System.Drawing.Point(289, 52);
            this.cmbBatch.Name = "cmbBatch";
            this.cmbBatch.Size = new System.Drawing.Size(100, 21);
            this.cmbBatch.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Course";
            // 
            // groupBox_users
            // 
            this.groupBox_users.Controls.Add(this.dataGridView_student);
            this.groupBox_users.Location = new System.Drawing.Point(10, 115);
            this.groupBox_users.Name = "groupBox_users";
            this.groupBox_users.Size = new System.Drawing.Size(518, 467);
            this.groupBox_users.TabIndex = 2;
            this.groupBox_users.TabStop = false;
            this.groupBox_users.Text = "Students";
            // 
            // dataGridView_student
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView_student.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_student.Location = new System.Drawing.Point(6, 19);
            this.dataGridView_student.Name = "dataGridView_student";
            this.dataGridView_student.RowHeadersVisible = false;
            this.dataGridView_student.Size = new System.Drawing.Size(503, 434);
            this.dataGridView_student.TabIndex = 0;
            // 
            // groupBox_StudentDetails
            // 
            this.groupBox_StudentDetails.Controls.Add(this.linkLabel_feeStructure);
            this.groupBox_StudentDetails.Controls.Add(this.linkLabel_thisUsersDetails);
            this.groupBox_StudentDetails.Controls.Add(this.lblStdBatchName);
            this.groupBox_StudentDetails.Controls.Add(this.lblStdBatch);
            this.groupBox_StudentDetails.Controls.Add(this.lblStdCourseName);
            this.groupBox_StudentDetails.Controls.Add(this.lblStdFullName);
            this.groupBox_StudentDetails.Controls.Add(this.lblStdCourse);
            this.groupBox_StudentDetails.Controls.Add(this.lblStdName);
            this.groupBox_StudentDetails.Enabled = false;
            this.groupBox_StudentDetails.Location = new System.Drawing.Point(534, 13);
            this.groupBox_StudentDetails.Name = "groupBox_StudentDetails";
            this.groupBox_StudentDetails.Size = new System.Drawing.Size(431, 92);
            this.groupBox_StudentDetails.TabIndex = 3;
            this.groupBox_StudentDetails.TabStop = false;
            this.groupBox_StudentDetails.Text = "Student Details";
            // 
            // linkLabel_feeStructure
            // 
            this.linkLabel_feeStructure.AutoSize = true;
            this.linkLabel_feeStructure.Enabled = false;
            this.linkLabel_feeStructure.Location = new System.Drawing.Point(131, 67);
            this.linkLabel_feeStructure.Name = "linkLabel_feeStructure";
            this.linkLabel_feeStructure.Size = new System.Drawing.Size(76, 13);
            this.linkLabel_feeStructure.TabIndex = 24;
            this.linkLabel_feeStructure.TabStop = true;
            this.linkLabel_feeStructure.Text = "Fees Structure";
            this.linkLabel_feeStructure.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_feeStructure_LinkClicked);
            // 
            // linkLabel_thisUsersDetails
            // 
            this.linkLabel_thisUsersDetails.AutoSize = true;
            this.linkLabel_thisUsersDetails.Enabled = false;
            this.linkLabel_thisUsersDetails.Location = new System.Drawing.Point(9, 67);
            this.linkLabel_thisUsersDetails.Name = "linkLabel_thisUsersDetails";
            this.linkLabel_thisUsersDetails.Size = new System.Drawing.Size(62, 13);
            this.linkLabel_thisUsersDetails.TabIndex = 23;
            this.linkLabel_thisUsersDetails.TabStop = true;
            this.linkLabel_thisUsersDetails.Text = "View Profile";
            this.linkLabel_thisUsersDetails.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_thisUsersDetails_LinkClicked);
            // 
            // lblStdBatchName
            // 
            this.lblStdBatchName.AutoSize = true;
            this.lblStdBatchName.Enabled = false;
            this.lblStdBatchName.Location = new System.Drawing.Point(217, 43);
            this.lblStdBatchName.Name = "lblStdBatchName";
            this.lblStdBatchName.Size = new System.Drawing.Size(35, 13);
            this.lblStdBatchName.TabIndex = 6;
            this.lblStdBatchName.Text = "Batch";
            // 
            // lblStdBatch
            // 
            this.lblStdBatch.AutoSize = true;
            this.lblStdBatch.Enabled = false;
            this.lblStdBatch.Location = new System.Drawing.Point(158, 43);
            this.lblStdBatch.Name = "lblStdBatch";
            this.lblStdBatch.Size = new System.Drawing.Size(35, 13);
            this.lblStdBatch.TabIndex = 5;
            this.lblStdBatch.Text = "Batch";
            // 
            // lblStdCourseName
            // 
            this.lblStdCourseName.AutoSize = true;
            this.lblStdCourseName.Enabled = false;
            this.lblStdCourseName.Location = new System.Drawing.Point(80, 44);
            this.lblStdCourseName.Name = "lblStdCourseName";
            this.lblStdCourseName.Size = new System.Drawing.Size(40, 13);
            this.lblStdCourseName.TabIndex = 4;
            this.lblStdCourseName.Text = "Course";
            // 
            // lblStdFullName
            // 
            this.lblStdFullName.AutoSize = true;
            this.lblStdFullName.Enabled = false;
            this.lblStdFullName.Location = new System.Drawing.Point(80, 21);
            this.lblStdFullName.Name = "lblStdFullName";
            this.lblStdFullName.Size = new System.Drawing.Size(48, 13);
            this.lblStdFullName.TabIndex = 3;
            this.lblStdFullName.Text = "fullName";
            // 
            // lblStdCourse
            // 
            this.lblStdCourse.AutoSize = true;
            this.lblStdCourse.Enabled = false;
            this.lblStdCourse.Location = new System.Drawing.Point(9, 44);
            this.lblStdCourse.Name = "lblStdCourse";
            this.lblStdCourse.Size = new System.Drawing.Size(40, 13);
            this.lblStdCourse.TabIndex = 1;
            this.lblStdCourse.Text = "Course";
            // 
            // lblStdName
            // 
            this.lblStdName.AutoSize = true;
            this.lblStdName.Enabled = false;
            this.lblStdName.Location = new System.Drawing.Point(6, 21);
            this.lblStdName.Name = "lblStdName";
            this.lblStdName.Size = new System.Drawing.Size(35, 13);
            this.lblStdName.TabIndex = 0;
            this.lblStdName.Text = "Name";
            // 
            // groupBox_PaymentDetails
            // 
            this.groupBox_PaymentDetails.Controls.Add(this.panel1);
            this.groupBox_PaymentDetails.Enabled = false;
            this.groupBox_PaymentDetails.Location = new System.Drawing.Point(534, 115);
            this.groupBox_PaymentDetails.Name = "groupBox_PaymentDetails";
            this.groupBox_PaymentDetails.Size = new System.Drawing.Size(431, 467);
            this.groupBox_PaymentDetails.TabIndex = 4;
            this.groupBox_PaymentDetails.TabStop = false;
            this.groupBox_PaymentDetails.Text = "PaymentDetails";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.dataGridView_paymnetLogs);
            this.panel1.Controls.Add(this.dataGridView_installmentLogs);
            this.panel1.Location = new System.Drawing.Point(0, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 433);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView_paymnetLogs
            // 
            this.dataGridView_paymnetLogs.AllowUserToAddRows = false;
            this.dataGridView_paymnetLogs.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView_paymnetLogs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_paymnetLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_paymnetLogs.Enabled = false;
            this.dataGridView_paymnetLogs.Location = new System.Drawing.Point(6, 197);
            this.dataGridView_paymnetLogs.Name = "dataGridView_paymnetLogs";
            this.dataGridView_paymnetLogs.RowHeadersVisible = false;
            this.dataGridView_paymnetLogs.Size = new System.Drawing.Size(416, 233);
            this.dataGridView_paymnetLogs.TabIndex = 31;
            // 
            // dataGridView_installmentLogs
            // 
            this.dataGridView_installmentLogs.AllowUserToAddRows = false;
            this.dataGridView_installmentLogs.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView_installmentLogs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_installmentLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_installmentLogs.Enabled = false;
            this.dataGridView_installmentLogs.Location = new System.Drawing.Point(6, 0);
            this.dataGridView_installmentLogs.Name = "dataGridView_installmentLogs";
            this.dataGridView_installmentLogs.RowHeadersVisible = false;
            this.dataGridView_installmentLogs.Size = new System.Drawing.Size(416, 191);
            this.dataGridView_installmentLogs.TabIndex = 30;
            // 
            // linkLabel_addStudent
            // 
            this.linkLabel_addStudent.AutoSize = true;
            this.linkLabel_addStudent.Location = new System.Drawing.Point(1019, 135);
            this.linkLabel_addStudent.Name = "linkLabel_addStudent";
            this.linkLabel_addStudent.Size = new System.Drawing.Size(66, 13);
            this.linkLabel_addStudent.TabIndex = 5;
            this.linkLabel_addStudent.TabStop = true;
            this.linkLabel_addStudent.Text = "Add Student";
            this.linkLabel_addStudent.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_addStudent_LinkClicked);
            // 
            // linkLabel_addEmployee
            // 
            this.linkLabel_addEmployee.AutoSize = true;
            this.linkLabel_addEmployee.Location = new System.Drawing.Point(1022, 180);
            this.linkLabel_addEmployee.Name = "linkLabel_addEmployee";
            this.linkLabel_addEmployee.Size = new System.Drawing.Size(75, 13);
            this.linkLabel_addEmployee.TabIndex = 6;
            this.linkLabel_addEmployee.TabStop = true;
            this.linkLabel_addEmployee.Text = "Add Employee";
            this.linkLabel_addEmployee.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_addEmployee_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(1001, 220);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(132, 13);
            this.linkLabel3.TabIndex = 7;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Search Employee/Student";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel_goToMasters
            // 
            this.linkLabel_goToMasters.AutoSize = true;
            this.linkLabel_goToMasters.Location = new System.Drawing.Point(1022, 31);
            this.linkLabel_goToMasters.Name = "linkLabel_goToMasters";
            this.linkLabel_goToMasters.Size = new System.Drawing.Size(73, 13);
            this.linkLabel_goToMasters.TabIndex = 8;
            this.linkLabel_goToMasters.TabStop = true;
            this.linkLabel_goToMasters.Text = "Go to Masters";
            this.linkLabel_goToMasters.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_goToMasters_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 596);
            this.Controls.Add(this.linkLabel_goToMasters);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel_addEmployee);
            this.Controls.Add(this.linkLabel_addStudent);
            this.Controls.Add(this.groupBox_PaymentDetails);
            this.Controls.Add(this.groupBox_StudentDetails);
            this.Controls.Add(this.groupBox_users);
            this.Controls.Add(this.groupBox_searchParameters);
            this.Name = "MainForm";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox_searchParameters.ResumeLayout(false);
            this.groupBox_searchParameters.PerformLayout();
            this.groupBox_users.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_student)).EndInit();
            this.groupBox_StudentDetails.ResumeLayout(false);
            this.groupBox_StudentDetails.PerformLayout();
            this.groupBox_PaymentDetails.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_paymnetLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_installmentLogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLabel_addNewCourse;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.GroupBox groupBox_searchParameters;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox_users;
        private System.Windows.Forms.ComboBox cmbBatch;
        private System.Windows.Forms.DataGridView dataGridView_student;
        private System.Windows.Forms.GroupBox groupBox_StudentDetails;
        private System.Windows.Forms.Label lblStdName;
        private System.Windows.Forms.Label lblStdCourse;
        private System.Windows.Forms.Label lblStdFullName;
        private System.Windows.Forms.Label lblStdBatchName;
        private System.Windows.Forms.Label lblStdBatch;
        private System.Windows.Forms.Label lblStdCourseName;
        private System.Windows.Forms.LinkLabel linkLabel_thisUsersDetails;
        private System.Windows.Forms.LinkLabel linkLabel_addNewBatch;
        private System.Windows.Forms.LinkLabel linkLabel_feeStructure;
        private System.Windows.Forms.GroupBox groupBox_PaymentDetails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_paymnetLogs;
        private System.Windows.Forms.DataGridView dataGridView_installmentLogs;
        private System.Windows.Forms.LinkLabel linkLabel_addStudent;
        private System.Windows.Forms.LinkLabel linkLabel_addEmployee;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel_goToMasters;

    }
}