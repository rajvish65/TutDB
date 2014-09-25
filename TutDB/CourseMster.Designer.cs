namespace TutDB
{
    partial class CourseMaster
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
            this.groupBox_CourseDetails = new System.Windows.Forms.GroupBox();
            this.checkBox_selectAll = new System.Windows.Forms.CheckBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.lblBatch = new System.Windows.Forms.Label();
            this.linkLabel_courseEdit = new System.Windows.Forms.LinkLabel();
            this.linkLabel_courseNew = new System.Windows.Forms.LinkLabel();
            this.lblCourseIsActive = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblCourseCode = new System.Windows.Forms.Label();
            this.linkLabel_courseCancel = new System.Windows.Forms.LinkLabel();
            this.linkLabel_courseUpdate = new System.Windows.Forms.LinkLabel();
            this.linkLabel_courseAdd = new System.Windows.Forms.LinkLabel();
            this.linkLabel_CourseActivate = new System.Windows.Forms.LinkLabel();
            this.txtCourseIsActive = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtCourseCode = new System.Windows.Forms.TextBox();
            this.groupBox_Course = new System.Windows.Forms.GroupBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.linkLabel_courseMasterClose = new System.Windows.Forms.LinkLabel();
            this.cmbCourseMaster = new System.Windows.Forms.ComboBox();
            this.groupBox_CourseDetails.SuspendLayout();
            this.groupBox_Course.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_CourseDetails
            // 
            this.groupBox_CourseDetails.Controls.Add(this.checkBox_selectAll);
            this.groupBox_CourseDetails.Controls.Add(this.checkedListBox1);
            this.groupBox_CourseDetails.Controls.Add(this.lblBatch);
            this.groupBox_CourseDetails.Controls.Add(this.linkLabel_courseEdit);
            this.groupBox_CourseDetails.Controls.Add(this.linkLabel_courseNew);
            this.groupBox_CourseDetails.Controls.Add(this.lblCourseIsActive);
            this.groupBox_CourseDetails.Controls.Add(this.lblCourseName);
            this.groupBox_CourseDetails.Controls.Add(this.lblCourseCode);
            this.groupBox_CourseDetails.Controls.Add(this.linkLabel_courseCancel);
            this.groupBox_CourseDetails.Controls.Add(this.linkLabel_courseUpdate);
            this.groupBox_CourseDetails.Controls.Add(this.linkLabel_courseAdd);
            this.groupBox_CourseDetails.Controls.Add(this.linkLabel_CourseActivate);
            this.groupBox_CourseDetails.Controls.Add(this.txtCourseIsActive);
            this.groupBox_CourseDetails.Controls.Add(this.txtCourseName);
            this.groupBox_CourseDetails.Controls.Add(this.txtCourseCode);
            this.groupBox_CourseDetails.Location = new System.Drawing.Point(12, 147);
            this.groupBox_CourseDetails.Name = "groupBox_CourseDetails";
            this.groupBox_CourseDetails.Size = new System.Drawing.Size(471, 267);
            this.groupBox_CourseDetails.TabIndex = 3;
            this.groupBox_CourseDetails.TabStop = false;
            this.groupBox_CourseDetails.Text = "Details";
            // 
            // checkBox_selectAll
            // 
            this.checkBox_selectAll.AutoSize = true;
            this.checkBox_selectAll.Location = new System.Drawing.Point(167, 129);
            this.checkBox_selectAll.Name = "checkBox_selectAll";
            this.checkBox_selectAll.Size = new System.Drawing.Size(70, 17);
            this.checkBox_selectAll.TabIndex = 16;
            this.checkBox_selectAll.Text = "Select All";
            this.checkBox_selectAll.UseVisualStyleBackColor = true;
            this.checkBox_selectAll.CheckedChanged += new System.EventHandler(this.checkBox_selectAll_CheckedChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(167, 151);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 14;
            // 
            // lblBatch
            // 
            this.lblBatch.AutoSize = true;
            this.lblBatch.Location = new System.Drawing.Point(88, 133);
            this.lblBatch.Name = "lblBatch";
            this.lblBatch.Size = new System.Drawing.Size(35, 13);
            this.lblBatch.TabIndex = 12;
            this.lblBatch.Text = "Batch";
            // 
            // linkLabel_courseEdit
            // 
            this.linkLabel_courseEdit.AutoSize = true;
            this.linkLabel_courseEdit.Location = new System.Drawing.Point(320, 16);
            this.linkLabel_courseEdit.Name = "linkLabel_courseEdit";
            this.linkLabel_courseEdit.Size = new System.Drawing.Size(25, 13);
            this.linkLabel_courseEdit.TabIndex = 11;
            this.linkLabel_courseEdit.TabStop = true;
            this.linkLabel_courseEdit.Text = "Edit";
            this.linkLabel_courseEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_courseEdit_LinkClicked);
            // 
            // linkLabel_courseNew
            // 
            this.linkLabel_courseNew.AutoSize = true;
            this.linkLabel_courseNew.Location = new System.Drawing.Point(288, 16);
            this.linkLabel_courseNew.Name = "linkLabel_courseNew";
            this.linkLabel_courseNew.Size = new System.Drawing.Size(29, 13);
            this.linkLabel_courseNew.TabIndex = 10;
            this.linkLabel_courseNew.TabStop = true;
            this.linkLabel_courseNew.Text = "New";
            this.linkLabel_courseNew.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_courseNew_LinkClicked);
            // 
            // lblCourseIsActive
            // 
            this.lblCourseIsActive.AutoSize = true;
            this.lblCourseIsActive.Location = new System.Drawing.Point(89, 105);
            this.lblCourseIsActive.Name = "lblCourseIsActive";
            this.lblCourseIsActive.Size = new System.Drawing.Size(37, 13);
            this.lblCourseIsActive.TabIndex = 9;
            this.lblCourseIsActive.Text = "Active";
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(89, 83);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(40, 13);
            this.lblCourseName.TabIndex = 8;
            this.lblCourseName.Text = "Course";
            // 
            // lblCourseCode
            // 
            this.lblCourseCode.AutoSize = true;
            this.lblCourseCode.Location = new System.Drawing.Point(89, 57);
            this.lblCourseCode.Name = "lblCourseCode";
            this.lblCourseCode.Size = new System.Drawing.Size(32, 13);
            this.lblCourseCode.TabIndex = 7;
            this.lblCourseCode.Text = "Code";
            // 
            // linkLabel_courseCancel
            // 
            this.linkLabel_courseCancel.AutoSize = true;
            this.linkLabel_courseCancel.Location = new System.Drawing.Point(432, 16);
            this.linkLabel_courseCancel.Name = "linkLabel_courseCancel";
            this.linkLabel_courseCancel.Size = new System.Drawing.Size(40, 13);
            this.linkLabel_courseCancel.TabIndex = 6;
            this.linkLabel_courseCancel.TabStop = true;
            this.linkLabel_courseCancel.Text = "Cancel";
            this.linkLabel_courseCancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_courseCancel_LinkClicked);
            // 
            // linkLabel_courseUpdate
            // 
            this.linkLabel_courseUpdate.AutoSize = true;
            this.linkLabel_courseUpdate.Location = new System.Drawing.Point(384, 16);
            this.linkLabel_courseUpdate.Name = "linkLabel_courseUpdate";
            this.linkLabel_courseUpdate.Size = new System.Drawing.Size(42, 13);
            this.linkLabel_courseUpdate.TabIndex = 5;
            this.linkLabel_courseUpdate.TabStop = true;
            this.linkLabel_courseUpdate.Text = "Update";
            this.linkLabel_courseUpdate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_courseUpdate_LinkClicked);
            // 
            // linkLabel_courseAdd
            // 
            this.linkLabel_courseAdd.AutoSize = true;
            this.linkLabel_courseAdd.Location = new System.Drawing.Point(352, 16);
            this.linkLabel_courseAdd.Name = "linkLabel_courseAdd";
            this.linkLabel_courseAdd.Size = new System.Drawing.Size(26, 13);
            this.linkLabel_courseAdd.TabIndex = 4;
            this.linkLabel_courseAdd.TabStop = true;
            this.linkLabel_courseAdd.Text = "Add";
            this.linkLabel_courseAdd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_courseAdd_LinkClicked);
            // 
            // linkLabel_CourseActivate
            // 
            this.linkLabel_CourseActivate.AutoSize = true;
            this.linkLabel_CourseActivate.Location = new System.Drawing.Point(234, 105);
            this.linkLabel_CourseActivate.Name = "linkLabel_CourseActivate";
            this.linkLabel_CourseActivate.Size = new System.Drawing.Size(46, 13);
            this.linkLabel_CourseActivate.TabIndex = 3;
            this.linkLabel_CourseActivate.TabStop = true;
            this.linkLabel_CourseActivate.Text = "Activate";
            this.linkLabel_CourseActivate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_CourseActivate_LinkClicked);
            // 
            // txtCourseIsActive
            // 
            this.txtCourseIsActive.Location = new System.Drawing.Point(167, 102);
            this.txtCourseIsActive.Name = "txtCourseIsActive";
            this.txtCourseIsActive.Size = new System.Drawing.Size(61, 20);
            this.txtCourseIsActive.TabIndex = 2;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(167, 76);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(140, 20);
            this.txtCourseName.TabIndex = 1;
            // 
            // txtCourseCode
            // 
            this.txtCourseCode.Location = new System.Drawing.Point(167, 50);
            this.txtCourseCode.Name = "txtCourseCode";
            this.txtCourseCode.Size = new System.Drawing.Size(100, 20);
            this.txtCourseCode.TabIndex = 0;
            // 
            // groupBox_Course
            // 
            this.groupBox_Course.Controls.Add(this.lblCourse);
            this.groupBox_Course.Controls.Add(this.linkLabel_courseMasterClose);
            this.groupBox_Course.Controls.Add(this.cmbCourseMaster);
            this.groupBox_Course.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Course.Name = "groupBox_Course";
            this.groupBox_Course.Size = new System.Drawing.Size(471, 117);
            this.groupBox_Course.TabIndex = 2;
            this.groupBox_Course.TabStop = false;
            this.groupBox_Course.Text = "Course";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(88, 50);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(40, 13);
            this.lblCourse.TabIndex = 5;
            this.lblCourse.Text = "Course";
            // 
            // linkLabel_courseMasterClose
            // 
            this.linkLabel_courseMasterClose.AutoSize = true;
            this.linkLabel_courseMasterClose.Location = new System.Drawing.Point(432, 16);
            this.linkLabel_courseMasterClose.Name = "linkLabel_courseMasterClose";
            this.linkLabel_courseMasterClose.Size = new System.Drawing.Size(33, 13);
            this.linkLabel_courseMasterClose.TabIndex = 4;
            this.linkLabel_courseMasterClose.TabStop = true;
            this.linkLabel_courseMasterClose.Text = "Close";
            this.linkLabel_courseMasterClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_courseMasterClose_LinkClicked);
            // 
            // cmbCourseMaster
            // 
            this.cmbCourseMaster.FormattingEnabled = true;
            this.cmbCourseMaster.Location = new System.Drawing.Point(166, 47);
            this.cmbCourseMaster.Name = "cmbCourseMaster";
            this.cmbCourseMaster.Size = new System.Drawing.Size(121, 21);
            this.cmbCourseMaster.TabIndex = 0;

            this.cmbCourseMaster.SelectedIndexChanged += new System.EventHandler(this.cmbCourseMaster_SelectedIndexChanged);
            // 
            // CourseMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 426);
            this.Controls.Add(this.groupBox_CourseDetails);
            this.Controls.Add(this.groupBox_Course);
            this.Name = "CourseMaster";
            this.Text = "CourseMaster";
            this.Load += new System.EventHandler(this.CourseMaster_Load);
            this.groupBox_CourseDetails.ResumeLayout(false);
            this.groupBox_CourseDetails.PerformLayout();
            this.groupBox_Course.ResumeLayout(false);
            this.groupBox_Course.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_CourseDetails;
        private System.Windows.Forms.Label lblCourseIsActive;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblCourseCode;
        private System.Windows.Forms.LinkLabel linkLabel_courseCancel;
        private System.Windows.Forms.LinkLabel linkLabel_courseUpdate;
        private System.Windows.Forms.LinkLabel linkLabel_courseAdd;
        private System.Windows.Forms.LinkLabel linkLabel_CourseActivate;
        private System.Windows.Forms.TextBox txtCourseIsActive;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtCourseCode;
        private System.Windows.Forms.GroupBox groupBox_Course;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.LinkLabel linkLabel_courseMasterClose;
        private System.Windows.Forms.ComboBox cmbCourseMaster;
        private System.Windows.Forms.LinkLabel linkLabel_courseEdit;
        private System.Windows.Forms.LinkLabel linkLabel_courseNew;
        private System.Windows.Forms.Label lblBatch;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckBox checkBox_selectAll;
    }
}