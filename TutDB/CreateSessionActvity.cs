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
using System.Globalization;

namespace TutDB
{
    public partial class CreateSessionActvity : Form
    {
        TutDBEntities db = CommonUtilities.getConnection();

        int sessionDuration = 0;
        int durationCounter = 0;
        DataTable dt;
        int sessionId = 0;
        int courseId = 0;
        int subjectId = 0;
        int locationId = 0;
        TimeSpan startTime;
        TimeSpan endTime;
        

        public CreateSessionActvity()
        {
            InitializeComponent();
        }

        private void CreateSessionActvity_Load(object sender, EventArgs e)
        {

            this.comboBox_course.SelectedIndexChanged -= new System.EventHandler(this.comboBox_course_SelectedIndexChanged);
            CommonUtilities.populateCourse(comboBox_course);
            this.comboBox_course.SelectedIndexChanged += new System.EventHandler(this.comboBox_course_SelectedIndexChanged);

            this.comboBox_startHours.SelectedIndexChanged -= new System.EventHandler(this.comboBox_startHours_SelectedIndexChanged);
            CommonUtilities.populateHours(comboBox_startHours);
            this.comboBox_startHours.SelectedIndexChanged += new System.EventHandler(this.comboBox_startHours_SelectedIndexChanged);
            CommonUtilities.populateHours(comboBox_endHours);

            this.comboBox_startMinutes.SelectedIndexChanged -= new System.EventHandler(this.comboBox_startMinutes_SelectedIndexChanged);
            CommonUtilities.populateMinutes(comboBox_startMinutes);
            this.comboBox_startMinutes.SelectedIndexChanged += new System.EventHandler(this.comboBox_startMinutes_SelectedIndexChanged);
            CommonUtilities.populateMinutes(comboBox_endMinutes);
           
            this.comboBox_location.SelectedIndexChanged -= new System.EventHandler(this.comboBox_location_SelectedIndexChanged);
            CommonUtilities.populateLocation(comboBox_location);
            this.comboBox_location.SelectedIndexChanged += new System.EventHandler(this.comboBox_location_SelectedIndexChanged);



            dataGridView_createSessionActivity.ReadOnly = true;
            dataGridView_createSessionActivity.AllowUserToAddRows = false;
            dataGridView_createSessionActivity.AllowUserToResizeRows = false;
            dataGridView_createSessionActivity.RowHeadersVisible = false;
            //this.dataGridView1.Paint += new PaintEventHandler(dataGrid_Paint);

            dt = new DataTable();

            dt.Columns.Add(new DataColumn("StartDate", typeof(string)));
            dt.Columns.Add(new DataColumn("EndDate", typeof(string)));
            dt.Columns.Add(new DataColumn("StartTime", typeof(string)));
            dt.Columns.Add(new DataColumn("EndTime", typeof(string)));
            dt.Columns.Add(new DataColumn("Duration", typeof(string)));
            dt.Columns.Add(new DataColumn("Occurance", typeof(string)));

            dataGridView_createSessionActivity.DataSource = dt;



            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.HeaderText = "";
            chk.Name = "check";
            chk.FalseValue = "0";
            chk.TrueValue = "1";
            chk.Width = 40;
            dataGridView_createSessionActivity.Columns.Insert(6, chk);
        }

        private void comboBox_course_SelectedIndexChanged(object sender, EventArgs e)
        {
            courseId = Int32.Parse((comboBox_course.SelectedItem as tblCourseMaster).CourseId.ToString());

            this.comboBox_subject.SelectedIndexChanged -= new System.EventHandler(this.comboBox_subject_SelectedIndexChanged);
            CommonUtilities.populateSubjectOnSelectCourse(comboBox_subject, courseId);
            this.comboBox_subject.SelectedIndexChanged += new System.EventHandler(this.comboBox_subject_SelectedIndexChanged);

            CommonUtilities.loadBatchCombo(comboBox_batch, courseId);
        }

        private void comboBox_subject_SelectedIndexChanged(object sender, EventArgs e)
        {
            subjectId = Int32.Parse((comboBox_subject.SelectedItem as tblSubjectMaster).SubjectId.ToString());

            this.comboBox_sessionOwner.SelectedIndexChanged -= new System.EventHandler(this.comboBox_sessionOwner_SelectedIndexChanged);
            CommonUtilities.populateEmployeeOnSelectSubject(comboBox_sessionOwner, subjectId);
            this.comboBox_sessionOwner.SelectedIndexChanged += new System.EventHandler(this.comboBox_sessionOwner_SelectedIndexChanged);

            CommonUtilities.populateTaskOnSelectSubject(comboBox_task, subjectId);
        }

        private void comboBox_sessionOwner_SelectedIndexChanged(object sender, EventArgs e)
        {
            sessionId = Int32.Parse((comboBox_sessionOwner.SelectedItem as tblEmployeeDetail).EmployeeId.ToString());

            if ((comboBox_sessionOwner.SelectedItem as tblEmployeeDetail).FirstName != "Select")
            {
                var session = (from sessionMaster in db.tblSessionMasters join basic in db.tblBasicMasters on sessionMaster.SessionOccurances equals basic.Id
                              where sessionMaster.SessionId.Equals(sessionId) && sessionMaster.isActive == 1 && basic.isActive == 1
                              select new
                              {
                                  sessionMaster.SessionId,
                                  sessionMaster.SessionTime,
                                  sessionMaster.SessionCode,
                                  basic.Value
                              }).First();

                sessionDuration = Int32.Parse(session.SessionTime.ToString());

                if (durationCounter != 0)
                {
                    int startHours = Int32.Parse(comboBox_startHours.SelectedItem.ToString());
                    int startMinutes = Int32.Parse(comboBox_startMinutes.SelectedItem.ToString());

                    setTimeAndDuration(startHours, startMinutes, sessionDuration);
                    setDuration();
                }

                textBox_sessionCode.Text = session.SessionCode.ToString();
                textBox_sessionOccurance.Text = session.Value.ToString();
                groupBox_sessionDetails.Visible = true;
            }
            else
                groupBox_sessionDetails.Visible = false;

            
        }

        private void comboBox_startHours_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sessionDuration == 0)
            {
                MessageBox.Show("Select Course,Subject,Other Details");
                return;
            }

            if (comboBox_startMinutes.SelectedItem.ToString().Equals("Select"))
            {
                this.comboBox_startMinutes.SelectedIndexChanged -= new System.EventHandler(this.comboBox_startMinutes_SelectedIndexChanged);
                comboBox_startMinutes.SelectedIndex = 1;
                this.comboBox_startMinutes.SelectedIndexChanged += new System.EventHandler(this.comboBox_startMinutes_SelectedIndexChanged);
            }
            int startHours = Int32.Parse(comboBox_startHours.SelectedItem.ToString());
            int startMinutes = Int32.Parse(comboBox_startMinutes.SelectedItem.ToString()); 

            setTimeAndDuration(startHours, startMinutes, sessionDuration);
            setDuration();
        }

        private void comboBox_startMinutes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sessionDuration == 0)
            {
                MessageBox.Show("Select Course,Subject,Other Details");
                return; 
            }

            if (comboBox_startHours.SelectedItem.ToString().Equals("Select"))
            {
                this.comboBox_startHours.SelectedIndexChanged -= new System.EventHandler(this.comboBox_startHours_SelectedIndexChanged);
                comboBox_startMinutes.SelectedIndex = 1;
                this.comboBox_startHours.SelectedIndexChanged += new System.EventHandler(this.comboBox_startHours_SelectedIndexChanged);
            }
            int startHours = Int32.Parse(comboBox_startHours.SelectedItem.ToString());
            int startMinutes = Int32.Parse(comboBox_startMinutes.SelectedItem.ToString());

            setTimeAndDuration(startHours, startMinutes, sessionDuration);
            setDuration();
        }

        private void comboBox_location_SelectedIndexChanged(object sender, EventArgs e)
        {
            int locationId = Int32.Parse((comboBox_location.SelectedItem as tblLocationMaster).LocationId.ToString());
            CommonUtilities.populateRoomOnSelectLocation(comboBox_room, locationId);
        }

        public void setTimeAndDuration(int startHrs, int startMin, int duration)
        {
            int calculatedHrs = duration / 60;
            int calculatedMins = duration % 60;

            int moreHrs = 0;
            int moreMins = 0;
            startHrs = startHrs + calculatedHrs;
            startMin = startMin + calculatedMins;

            if (startMin >= 60)
            {
                moreHrs = startMin / 60;
                moreMins = startMin % 60;
            }

            int endHrs = startHrs + moreHrs;
            int endMins = 0;
            if ((startMin + moreMins) < 60)
            {
                endMins = startMin + moreMins;
            }
            else
            {
                endMins = moreMins; 
            }

            int a = endHrs.ToString().Length;
            int b = endMins.ToString().Length;

            if (endHrs.ToString().Length == 1)
            {
                comboBox_endHours.SelectedIndex = comboBox_endHours.Items.IndexOf("0" + endHrs.ToString());
            }
            else
            {
                comboBox_endHours.SelectedIndex = comboBox_endHours.Items.IndexOf(endHrs.ToString());
            }
            if (endMins.ToString().Length == 1)
            {
                comboBox_endMinutes.SelectedIndex = comboBox_endMinutes.Items.IndexOf("0" + endMins.ToString());
            }
            else
            {
                comboBox_endMinutes.SelectedIndex = comboBox_endMinutes.Items.IndexOf(endMins.ToString());
            }
        }

        public void setDuration()
        {
            int startHours = Int32.Parse(comboBox_startHours.SelectedItem.ToString());
            int endHours =  Int32.Parse(comboBox_endHours.SelectedItem.ToString());
            int startMinutes =  Int32.Parse(comboBox_startMinutes.SelectedItem.ToString());
            int endMinutes =  Int32.Parse(comboBox_endMinutes.SelectedItem.ToString());
             
            int durationHours = 0;
            int durationMinutes = 0;

            if (endMinutes < startMinutes)
            {
                endHours -= 1;
                endMinutes += 60;
            }

            durationHours = endHours - startHours;
            durationMinutes = endMinutes - startMinutes;
            durationMinutes = (durationHours * 60) + durationMinutes;
            textBox_computedDuration.Text = durationMinutes.ToString();

            durationCounter++;
        }

       
       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           if (e.RowIndex < 0 || e.RowIndex >= dataGridView_createSessionActivity.Rows.Count || e.ColumnIndex < 0 || e.ColumnIndex >= dataGridView_createSessionActivity.Columns.Count)
           return;

            if (e.ColumnIndex == 5)
            {
                  DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)dataGridView_createSessionActivity.Rows[e.RowIndex].Cells[e.ColumnIndex];
                  if (chk.Value == chk.FalseValue || chk.Value == null)
                  {
                      chk.Value = chk.TrueValue;
                  }
                  else
                  {
                      chk.Value = chk.FalseValue;
                  }
                dataGridView_createSessionActivity.EndEdit();
            }
            

        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView_createSessionActivity.Rows)
            {
                int rowIndex = Int32.Parse(row.Index.ToString());

                if (row.Index != dataGridView_createSessionActivity.Rows.Count)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)dataGridView_createSessionActivity.Rows[rowIndex].Cells["check"];
                    if(chk.Value == chk.TrueValue)
                    {
                         dataGridView_createSessionActivity.Rows.Remove(row);
                    }
                }
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dateTimePicker_fromDate.Value.Date;
            DateTime toDate = dateTimePicker_toDate.Value.Date;

            int startHours = Int32.Parse(comboBox_startHours.SelectedItem.ToString());
            int endHours = Int32.Parse(comboBox_endHours.SelectedItem.ToString());
            int startMinutes = Int32.Parse(comboBox_startMinutes.SelectedItem.ToString());
            int endMinutes = Int32.Parse(comboBox_endMinutes.SelectedItem.ToString());
            startTime = new TimeSpan(0, startHours, startMinutes, 0);
            endTime = new TimeSpan(0, endHours, endMinutes, 0);

            String occurances = textBox_sessionOccurance.Text.ToString();

            DataRow drRecord = null;

            drRecord = dt.NewRow();
            drRecord["StartDate"] = fromDate;
            drRecord["EndDate"] = toDate;
            drRecord["StartTime"] = startTime;
            drRecord["EndTime"] = endTime;
            drRecord["Duration"] = sessionDuration;
            drRecord["Occurance"] = occurances;

            dt.Rows.Add(drRecord);

            dataGridView_createSessionActivity.DataSource = dt;
        }

       

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            int batchId = Int32.Parse((comboBox_batch.SelectedItem as tblBatchMaster).BatchId.ToString());
            int taskId = Int32.Parse((comboBox_task.SelectedItem as tblTaskMaster).TaskId.ToString());
            int roomId = Int32.Parse((comboBox_room.SelectedItem as tblRoomMaster).RoomId.ToString());

            bool exceptionOccured = false;
            try
            {
                bool success = false;

                using (TransactionScope transaction = new TransactionScope())
                {
                    try
                   {
                         foreach (DataGridViewRow row in dataGridView_createSessionActivity.Rows)
                         {
                             DateTime fromDate = Convert.ToDateTime(dataGridView_createSessionActivity.Rows[row.Index].Cells["StartDate"].Value.ToString());
                             DateTime toDate = Convert.ToDateTime(dataGridView_createSessionActivity.Rows[row.Index].Cells["EndDate"].Value.ToString());

                             String startTime = dataGridView_createSessionActivity.Rows[row.Index].Cells["StartTime"].Value.ToString();
                             String[] start = startTime.Split(':');
                             TimeSpan startTimeSpan = new TimeSpan(0, Int32.Parse(start[0]), Int32.Parse(start[1]), 0);
                             String endTime = dataGridView_createSessionActivity.Rows[row.Index].Cells["EndTime"].Value.ToString();
                             String[] end = endTime.Split(':');
                             TimeSpan endTimeSpan = new TimeSpan(0, Int32.Parse(end[0]), Int32.Parse(end[1]), 0);

                             int duration = Convert.ToInt32(dataGridView_createSessionActivity.Rows[row.Index].Cells["Duration"].Value.ToString());
                             String occurances = dataGridView_createSessionActivity.Rows[row.Index].Cells["Occurance"].Value.ToString();
                             //call function
                             registerSession(fromDate, toDate, startTimeSpan, endTimeSpan, sessionId, courseId, batchId, subjectId, taskId, locationId, roomId, duration, occurances);
                         }
                    
                         transaction.Complete();
                         success = true;
                    }
                    catch (Exception ex)
                    {
                        success = false;
                    }
                }
                if (success)
                {
                    //db.AcceptAllChanges(); //Transaction was successful, commit all changes.
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                exceptionOccured = true;
            }
            if (!exceptionOccured)
            {
                MessageBox.Show("Session registered successfully.", "Success");
            }
            else
            {
                MessageBox.Show("Something went wrong.", "Error");
            }

        }

        public void registerSession(DateTime fromDate, DateTime toDate, TimeSpan startTime, TimeSpan endTime, int sessionId, int courseId, int batchId, int subjectId, int taskId, int locationId, int roomId, int sessionDuration, String occurances)
        {
            switch (occurances)
            {
                case "Daily":
                    db.sp_createSessionActivityDaily(fromDate, toDate, startTime, endTime, sessionId, courseId, 1, subjectId, taskId, 1, roomId, sessionDuration);
                    break;
                case "Weekly":
                    break;
                case "Monthly":
                    break;
                case "Weekly(Twice)":
                    break;
                case "Weekly(Thrice)":
                    break;
                case "Alternate(including Sundays)":
                    break;
                case "Alternate":
                    break;
                case "Mon,Wed,Fri":
                    break;
                case "Tue,Thu,Sat":
                    break;
                case "Weekends(Saturday)":
                    break;
                case "Weekends(Sundays)":
                    break;
                case "Weekends(Sat,Sun)":
                    break;
                default:
                    break;
            }



        }
    }
}

