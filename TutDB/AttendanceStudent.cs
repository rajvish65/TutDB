using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;

namespace TutDB
{
    public partial class AttendanceStudent : Form
    {
        TutDBEntities db = CommonUtilities.getConnection();
        static Int32 SessionActivityId;
        static bool hasComeFromSessionTrack = false;
        static bool HasSessionActivityAlreadyPresent = false;
        int cLeft = 0;
        int count = 1;

        public AttendanceStudent()
        {
            InitializeComponent();
        }

        internal static void setSessionActivityId(int selectedSessionActivityId)
        {
            SessionActivityId = selectedSessionActivityId;
        }

        internal static void setHasComeFromSessionTrack(bool hasCome)
        {
            hasComeFromSessionTrack = hasCome;
        }

        internal static void setHasSessionActivityAlreadyPresent(bool alreadyPresent)
        {
            HasSessionActivityAlreadyPresent = alreadyPresent;
        }

        private void AttendanceStudent_Load(object sender, EventArgs e)
        {
            //var sessionActivityAlreadyPresent = (from attendance in db.tblStudentAttendances
            //                                    where attendance.SessionActivityId == SessionActivityId
            //                                    select attendance);
            //if (sessionActivityAlreadyPresent.ToList().Count !=0 )
            //{
            //    setHasSessionActivityAlreadyPresent(true);
            //}

            //var sessionDetails = from sessionAvtivity in db.tblSessionActivities
            //                      join sessionMaster in db.tblSessionMasters
            //                          on sessionAvtivity.SessionId equals sessionMaster.SessionId
            //                      join employee in db.tblEmployeeDetails on sessionMaster.SessionOwnerId equals employee.EmployeeId
            //                      join subject in db.tblSubjectMasters on sessionAvtivity.SubjectId equals subject.SubjectId
            //                      join course in db.tblCourseMasters on sessionAvtivity.CourseId equals course.CourseId
            //                      join batch in db.tblBatchMasters on sessionAvtivity.BatchId equals batch.BatchId
            //                      join location in db.tblLocationMasters on sessionAvtivity.LocationId equals location.LocationId
            //                      join room in db.tblRoomMasters on sessionAvtivity.RoomId equals room.RoomId
            //                      join task in db.tblTaskMasters on sessionAvtivity.TaskId equals task.TaskId
            //                      where sessionAvtivity.SessionActivityId == SessionActivityId
            //                      select new
            //                      {
            //                          sessionMaster.SessionCode,
            //                          employee.EmployeeCode,
            //                          employee.FirstName,
            //                          employee.LastName,
            //                          subject.SubjectName,
            //                          course.CourseCode,
            //                          course.CourseName,
            //                          batch.BatchCode,
            //                          batch.BatchName,
            //                          task.TaskName,
            //                          sessionAvtivity.SessionDate,
            //                          sessionAvtivity.StartTime,
            //                          sessionAvtivity.EndTime,
            //                          sessionAvtivity.SessionDuration,
            //                          sessionAvtivity.isCompleted,
            //                          sessionAvtivity.SessionActivityId,
            //                          sessionAvtivity.Comments
            //                      };
            //sessionDetails.ToList();
            

            //foreach(var item in sessionDetails)
            //{
            //    label_courseBatch.Text = item.CourseName.ToString() + "/" + item.BatchName.ToString();
            //    label_date.Text = item.SessionDate.ToString().Substring(0, 10);
            //    label_time.Text = item.StartTime.ToString() + "  to  " + item.EndTime.ToString();
            //    label_subject.Text = item.SubjectName.ToString();
            //    label_task.Text = item.TaskName.ToString();
            //    label_sesionOwner.Text = item.FirstName.ToString() + " " + item.LastName.ToString() + "(" + item.EmployeeCode.ToString() + ")";
            //    if (item.isCompleted == 1)
            //    {
            //        checkBox_completed.CheckState = CheckState.Checked;
            //        checkBox_completed.Enabled = false;
            //    }
            //}



            //if (!HasSessionActivityAlreadyPresent)
            //{
            //    var studentDetails = from sessionActvities in db.tblSessionActivities
            //                         join student in db.tblStudentDetails
            //                             on sessionActvities.CourseId equals student.CourseId
            //                         where sessionActvities.SessionActivityId == SessionActivityId && sessionActvities.isActive == 1 && student.isActive == 1 && student.BatchId == sessionActvities.BatchId
            //                         orderby student.FirstName, student.LastName
            //                         select new
            //                         {
            //                             student.StudentId,
            //                             student.StudentCode,
            //                             student.FirstName,
            //                             student.LastName,
            //                         };
            //    studentDetails.ToList();
            //    cLeft = 7;

            //    count = 1;
            //    foreach (var item in studentDetails)
            //    {
            //        System.Windows.Forms.Label label_studentNo = new System.Windows.Forms.Label();
            //        this.Controls.Add(label_studentNo);
            //        label_studentNo.Top = cLeft * 22;
            //        label_studentNo.Left = 40;
            //        label_studentNo.Size = new System.Drawing.Size(20, 15);
            //        label_studentNo.Text = count.ToString();

            //        System.Windows.Forms.Label label_studentId = new System.Windows.Forms.Label();
            //        this.Controls.Add(label_studentId);
            //        label_studentId.Top = cLeft * 22;
            //        label_studentId.Left = 40;
            //        label_studentId.Visible = false;
            //        label_studentId.Text = item.StudentId.ToString();

            //        System.Windows.Forms.Label label_studentName = new System.Windows.Forms.Label();
            //        this.Controls.Add(label_studentName);
            //        label_studentName.Top = cLeft * 22;
            //        label_studentName.Left = 100;
            //        label_studentName.Size = new System.Drawing.Size(100, 13);
            //        label_studentName.Text = item.FirstName.ToString() + " " + item.LastName.ToString();

            //        System.Windows.Forms.CheckBox check_student = new System.Windows.Forms.CheckBox();
            //        this.Controls.Add(check_student);
            //        check_student.Top = cLeft * 22;
            //        check_student.Left = 300;
            //        check_student.Size = new System.Drawing.Size(13, 13);
            //        check_student.CheckState = CheckState.Checked;
            //        check_student.CheckedChanged += new System.EventHandler(this.check_student_CheckedChanged);

            //        System.Windows.Forms.ComboBox combobox_reason = new System.Windows.Forms.ComboBox();
            //        this.Controls.Add(combobox_reason);
            //        combobox_reason.Top = cLeft * 22;
            //        combobox_reason.Left = 410;
            //        combobox_reason.Visible = false;
            //        combobox_reason.Size = new System.Drawing.Size(150, 20);
            //        combobox_reason.Text = "";
            //        CommonUtilities.populateLeaveReason(combobox_reason);
            //        combobox_reason.SelectedIndex = 1;

            //        cLeft = cLeft + 1;
            //        count++;
            //    }

            //    cLeft += 2;

            //    System.Windows.Forms.Label label_comment = new System.Windows.Forms.Label();
            //    this.Controls.Add(label_comment);
            //    label_comment.Top = cLeft * 22;
            //    label_comment.Left = 40;
            //    label_comment.Size = new System.Drawing.Size(60, 15);
            //    label_comment.Text = "Comments:";

            //    System.Windows.Forms.RichTextBox richtextbox_comment = new System.Windows.Forms.RichTextBox();
            //    this.Controls.Add(richtextbox_comment);
            //    richtextbox_comment.Top = cLeft * 22;
            //    richtextbox_comment.Left = 125;
            //    richtextbox_comment.Size = new System.Drawing.Size(120, 50);
                

            //    cLeft += 4;


            //    System.Windows.Forms.Button button_submit = new Button();
            //    this.Controls.Add(button_submit);
            //    button_submit.Top = cLeft * 22;
            //    button_submit.Left = 200;
            //    button_submit.Size = new System.Drawing.Size(100, 23);
            //    button_submit.Text = "Submit";
            //    button_submit.Click += new EventHandler(button_submit_Click);
            //}
           

            //if (HasSessionActivityAlreadyPresent)
            //{
            //    var alreadyPresentAttendanceDetails = from session in  db.tblSessionActivities join attendance in db.tblStudentAttendances
            //                                          on session.SessionActivityId equals attendance.SessionActivityId
            //                                          join student in db.tblStudentDetails
            //                                          on attendance.StudentId equals student.StudentId
            //                                          where attendance.SessionActivityId == SessionActivityId && student.isActive == 1
            //                                          orderby student.FirstName, student.LastName
            //                                          select new
            //                                          {
            //                                              student.StudentId,
            //                                              student.StudentCode,
            //                                              student.FirstName,
            //                                              student.LastName,
            //                                              attendance.isPresent,
            //                                              attendance.LeaveReason
            //                                          };
            //    alreadyPresentAttendanceDetails.ToList();
            //    cLeft = 7;

            //    count = 1;
            //    foreach (var item in alreadyPresentAttendanceDetails)
            //    {
            //        System.Windows.Forms.Label label_studentNo = new System.Windows.Forms.Label();
            //        this.Controls.Add(label_studentNo);
            //        label_studentNo.Top = cLeft * 22;
            //        label_studentNo.Left = 40;
            //        label_studentNo.Size = new System.Drawing.Size(20, 15);
            //        label_studentNo.Text = count.ToString();

            //        System.Windows.Forms.Label label_studentId = new System.Windows.Forms.Label();
            //        this.Controls.Add(label_studentId);
            //        label_studentId.Top = cLeft * 22;
            //        label_studentId.Left = 40;
            //        label_studentId.Visible = false;
            //        label_studentId.Text = item.StudentId.ToString();

            //        System.Windows.Forms.Label label_studentName = new System.Windows.Forms.Label();
            //        this.Controls.Add(label_studentName);
            //        label_studentName.Top = cLeft * 22;
            //        label_studentName.Left = 100;
            //        label_studentName.Size = new System.Drawing.Size(100, 13);
            //        label_studentName.Text = item.FirstName.ToString() + " " + item.LastName.ToString();

            //        System.Windows.Forms.CheckBox check_student = new System.Windows.Forms.CheckBox();
            //        this.Controls.Add(check_student);
            //        check_student.Top = cLeft * 22;
            //        check_student.Left = 300;
            //        check_student.Size = new System.Drawing.Size(13, 13);
            //        if (item.isPresent == 1)
            //            check_student.CheckState = CheckState.Checked;
            //        else
            //            check_student.CheckState = CheckState.Unchecked;
            //        check_student.CheckedChanged += new System.EventHandler(this.check_student_CheckedChanged);

            //        System.Windows.Forms.ComboBox combobox_reason = new System.Windows.Forms.ComboBox();
            //        this.Controls.Add(combobox_reason);
            //        combobox_reason.Top = cLeft * 22;
            //        combobox_reason.Left = 410;
            //        combobox_reason.Visible = false;
            //        combobox_reason.Size = new System.Drawing.Size(120, 20);
            //        CommonUtilities.populateLeaveReason(combobox_reason);
            //        combobox_reason.SelectedIndex = 1;

            //        if (check_student.CheckState == CheckState.Unchecked)
            //        {
            //            combobox_reason.Text = item.LeaveReason.ToString();
            //            combobox_reason.Visible = true;
            //        }

            //        cLeft = cLeft + 1;
            //        count++;
            //    }

            //    cLeft += 2;

            //    System.Windows.Forms.Label label_comment = new System.Windows.Forms.Label();
            //    this.Controls.Add(label_comment);
            //    label_comment.Top = cLeft * 22;
            //    label_comment.Left = 40;
            //    label_comment.Size = new System.Drawing.Size(60, 15);
            //    label_comment.Text = "Comments:";

            //    System.Windows.Forms.RichTextBox richtextbox_comment = new System.Windows.Forms.RichTextBox();
            //    this.Controls.Add(richtextbox_comment);
            //    richtextbox_comment.Top = cLeft * 22;
            //    richtextbox_comment.Left = 125;
            //    richtextbox_comment.Size = new System.Drawing.Size(150, 50);

            //    tblSessionActivity sessionComments = new tblSessionActivity();
            //    sessionComments = (from sa in db.tblSessionActivities
            //                       where sa.SessionActivityId == SessionActivityId
            //                       select sa).First();
            //    if (sessionComments != null)
            //    {
            //        richtextbox_comment.Text = sessionComments.Comments.ToString();
            //    }
                
            //    cLeft += 4;

            //    System.Windows.Forms.Button button_update = new Button();
            //    this.Controls.Add(button_update);
            //    button_update.Top = cLeft * 22;
            //    button_update.Left = 200;
            //    button_update.Size = new System.Drawing.Size(100, 23);
            //    button_update.Text = "Update";
            //    button_update.Click += new EventHandler(button_update_Click);
            //}
                 
            //System.Windows.Forms.Button button_cancel = new Button();
            //this.Controls.Add(button_cancel);
            //button_cancel.Top = cLeft * 22;
            //button_cancel.Left = 300;
            //button_cancel.Size = new System.Drawing.Size(100, 23);
            //button_cancel.Text = "Cancel";
            //button_cancel.Click += new EventHandler(button_cancel_Click);
            //cLeft++;
            //cLeft++;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            //int studentId = 0;
            //int attended = -1;
            //String reason = null;
            //String comments = null;

            //bool exceptionOccured = false;
            //try
            //{
            //    bool success = false;
            //    using (TransactionScope transaction = new TransactionScope())
            //    {
            //        try
            //        {
            //            for (int i = 18; i < this.Controls.Count; i++)
            //            {
            //                if (this.Controls[i] is Label)
            //                {
            //                    Label label_StudentId = (Label)this.Controls[i];
            //                    if (label_StudentId.Visible == false)
            //                    {
            //                        studentId = Int32.Parse(label_StudentId.Text.ToString());
            //                    }
            //                }
            //                if (this.Controls[i] is CheckBox)
            //                {
            //                    CheckBox chk = (CheckBox)this.Controls[i];
            //                    if (chk.CheckState == CheckState.Checked)
            //                        attended = 1;
            //                    else
            //                    {
            //                        attended = 0;
            //                        if (this.Controls[i + 1] is ComboBox)
            //                        {
            //                            ComboBox combobox_reason = (ComboBox)this.Controls[i + 1];
            //                            reason = (combobox_reason.SelectedItem as tblBasicMaster).Value.ToString();
            //                            i += 1;
            //                        }
            //                    }
            //                }

            //                if (this.Controls[i] is RichTextBox)
            //                {
            //                    RichTextBox richtextbox_comments = (RichTextBox)this.Controls[i];
            //                    comments = richtextbox_comments.Text.ToString();
            //                }

            //                if (studentId != 0 && attended != -1)
            //                {
            //                    tblStudentAttendance attendance = new tblStudentAttendance();
            //                    attendance = (from sa in db.tblStudentAttendances
            //                                       where sa.SessionActivityId == SessionActivityId && sa.StudentId == studentId
            //                                       select sa).First();
            //                    if (attendance != null)
            //                    {
            //                        attendance.SessionActivityId = SessionActivityId;
            //                        attendance.StudentId = studentId;
            //                        attendance.EnteredDate = DateTime.Now;
            //                        attendance.AttendanceDate = DateTime.Now;
            //                        attendance.isPresent = attended;
            //                        attendance.LeaveReason = reason;
            //                        attendance.UpdatedDate = DateTime.Today;

            //                        db.SaveChanges();
            //                    }

            //                    studentId = 0;
            //                    attended = -1;
            //                    reason = null;
            //                }
            //            }

            //            db.SaveChanges();
            //            tblSessionActivity sessionActivity = new tblSessionActivity();
            //            sessionActivity = (from sa in db.tblSessionActivities
            //                               where sa.SessionActivityId == SessionActivityId
            //                               select sa).First();
            //            if (sessionActivity != null)
            //            {
            //                sessionActivity.AttendanceRecorded = 1;
            //                sessionActivity.Comments = comments;
            //                db.SaveChanges();
            //            }


            //            transaction.Complete();
            //            success = true;
            //        }
            //        catch (Exception ex)
            //        {
            //            success = false;
            //        }
            //    }
            //    if (success)
            //    {
            //        //db.AcceptAllChanges(); //Transaction was successful, commit all changes.
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.StackTrace);
            //    exceptionOccured = true;
            //}

            //if (!exceptionOccured)
            //{
            //    MessageBox.Show("Attendance updated successfully.", "Success");
            //}
            //else
            //{
            //    MessageBox.Show("Something went wrong.", "Error");
            //}
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            //int studentId = 0;
            //int attended = -1;
            //String reason = null;
            //String comments = null;

            //bool exceptionOccured = false;
            //try
            //{
            //    bool success = false;


            //    using (TransactionScope transaction = new TransactionScope())
            //    {
            //        try
            //        {

            //            for (int i = 18; i < this.Controls.Count; i++)
            //            {
            //                if (this.Controls[i] is Label)
            //                {
            //                    Label label_StudentId = (Label)this.Controls[i];
            //                    if (label_StudentId.Visible == false)
            //                    {
            //                        studentId = Int32.Parse(label_StudentId.Text.ToString());
            //                    }
            //                }

            //                if (this.Controls[i] is CheckBox)
            //                {
            //                    CheckBox chk = (CheckBox)this.Controls[i];
            //                    if (chk.CheckState == CheckState.Checked)
            //                        attended = 1;
            //                    else
            //                    {
            //                        attended = 0;
            //                        if (this.Controls[i + 1] is ComboBox)
            //                        {
            //                            ComboBox combobox_reason = (ComboBox)this.Controls[i + 1];
            //                            reason = (combobox_reason.SelectedItem as tblBasicMaster).Value.ToString();
            //                            i += 1;
            //                        }
            //                    }
            //                }

            //                if (this.Controls[i] is RichTextBox)
            //                {
            //                    RichTextBox richtextbox_comments = (RichTextBox)this.Controls[i];
            //                    comments = richtextbox_comments.Text.ToString();
            //                }

            //                if (studentId != 0 && attended != -1)
            //                {
            //                    tblStudentAttendance attendance = new tblStudentAttendance();
            //                    attendance.SessionActivityId = SessionActivityId;
            //                    attendance.StudentId = studentId;
            //                    attendance.EnteredDate = DateTime.Now;
            //                    attendance.AttendanceDate = DateTime.Now;
            //                    attendance.isPresent = attended;
            //                    attendance.LeaveReason = reason;
            //                    attendance.CreatedDate = DateTime.Today;
            //                    db.tblStudentAttendances.Add(attendance);

            //                    studentId = 0;
            //                    attended = -1;
            //                    reason = null;
            //                }
            //            }

            //            db.SaveChanges();
            //            tblSessionActivity sessionActivity = new tblSessionActivity();
            //            sessionActivity = (from sa in db.tblSessionActivities
            //                           where sa.SessionActivityId == SessionActivityId
            //                           select sa).First();
            //            if (sessionActivity != null)
            //            {
            //                sessionActivity.AttendanceRecorded = 1;
            //                sessionActivity.Comments = comments;
            //                db.SaveChanges();
            //            }
                        
            //            transaction.Complete();
            //            success = true;
            //        }
            //        catch (Exception ex)
            //        {
            //            success = false;
            //        }
            //    }
            //    if (success)
            //    {
            //        //db.AcceptAllChanges(); //Transaction was successful, commit all changes.
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.StackTrace);
            //    exceptionOccured = true;
            //}

            //if (!exceptionOccured)
            //{
            //    MessageBox.Show("Attendance recorded successfully.", "Success");
            //}
            //else
            //{
            //    MessageBox.Show("Something went wrong.", "Error");
            //}

            
        }

        private void check_student_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 17; i < this.Controls.Count; i++)
            {
                if (this.Controls[i] is CheckBox)
                {
                    CheckBox chk = (CheckBox)this.Controls[i];
                    if (chk.CheckState == CheckState.Unchecked && this.Controls[i + 1].Visible == false)
                    {
                        this.Controls[i + 1].Visible = true;
                    }
                }

                if (this.Controls[i] is CheckBox)
                {
                    CheckBox chk = (CheckBox)this.Controls[i];
                    if (chk.CheckState == CheckState.Checked && this.Controls[i + 1].Visible == true)
                    {
                        this.Controls[i + 1].Visible = false;
                    }
                }
            }
        }
      }
    }

