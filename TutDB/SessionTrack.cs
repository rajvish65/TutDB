using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TutDB
{
    public partial class SessionTrack : Form
    {
        TutDBEntities db = CommonUtilities.getConnection();
        int cLeft = 1;
        

        public SessionTrack()
        {
            InitializeComponent();
        }

        private void SessionTrack_Load(object sender, EventArgs e)
        {
            var sessionList=db.tblSessionMasters.OrderBy(x => x.SessionOwnerId).ToList();
            foreach (var item in sessionList)
            {
                System.Windows.Forms.Button txt = new System.Windows.Forms.Button();
                panel_sessionList.Controls.Add(txt);
                txt.Top = cLeft * 22;
                txt.Left = 10;
                txt.Text = item.SessionOwnerId.ToString()+" - "+ this.cLeft.ToString();
                cLeft = cLeft + 1;
            }
            PopulateTreeViewControl();
            //populateGridView();

            formLoad();
  
        }

        public void formLoad()
        {
            int colSpacing = Int32.Parse(db.tblBasicMasters.Where(x => x.Description.Equals("Columns")).Single().Value);


            List<RowColIndex> list = new List<RowColIndex>();
            list = populateGridView();
            list.Count();

            //Hashtable hash = new Hashtable();
            //merge for 1st Row(startCell,spacingCount)
            mergeCell(1, colSpacing, 1, 0);
            //merge for 2nd Row(startCell,spcingCount)
            mergeCell(1, 4, (colSpacing / 4), 1);

            int rowIndex = 0;
            int startColIndex = 0;
            int endColIndex = 0;
            foreach (var itemList in list)
            {
                RowColIndex rowCol = new RowColIndex();
                rowCol = itemList;

                rowIndex = rowCol.rowIndex;
                startColIndex = rowCol.startColIndex;
                endColIndex = rowCol.endColIndex;

                mergeCell(startColIndex, endColIndex - startColIndex, 1, rowIndex + 1);
            }
        }

        //nOffset=Start Point to merge
        //mergeCount=Spacing Count to merge
        //rowIndex=Row index in DataGridView
        public void mergeCell(int nOffset,int mergeSpacing,int mergeCount,int rowIndex)
        {
            MergeCells pCell;

            for (int i = 0; i < mergeCount; i++)
            {
                for (int j = nOffset; j < (nOffset + mergeSpacing); j++)
                {
                    dataGridView1.Rows[rowIndex].Cells[j] = new MergeCells();
                    pCell = (MergeCells)dataGridView1.Rows[rowIndex].Cells[j];
                    pCell.LeftColumn = nOffset;
                    pCell.RightColumn = nOffset + (mergeSpacing - 1);
                }
                nOffset += mergeSpacing;
            }
        } 

        private void PopulateTreeViewControl()
        {
            var locationList=db.tblLocationMasters.OrderBy(x=>x.LocationName).Select(y => new {y.LocationId,y.LocationName}).ToList(); 

            TreeNode parentNode = null;
            //parentNode.Nodes.Clear();

            foreach (var location in locationList)
            {
                parentNode = new TreeNode();

                parentNode.Text = location.LocationName; 
                parentNode.Expand();
                //parentNode.ToolTipText = "Select Location";

                treeView_locationView.Nodes.Add(parentNode);
                FillChild(parentNode);
            }
        }

        public void FillChild(TreeNode parent)
        {

            var locationRoomList = from location in db.tblLocationMasters
                                   join locationRoom in db.tblLocationRoomMappings on location.LocationId equals locationRoom.LocationId
                                   join room in db.tblRoomMasters on locationRoom.RoomId equals room.RoomId
                                   where location.LocationName.Equals(parent.Text)
                                   orderby room.RoomName
                                   select new { location.LocationId, room.RoomId, room.RoomName };
            locationRoomList.ToList();
            parent.Nodes.Clear();

            foreach (var dr in locationRoomList)
            {
                TreeNode childNode = new TreeNode();
                childNode.Text = dr.RoomName;

                if (childNode.Nodes.Count == 0)
                {
                    //child. = true;
                }
                childNode.Collapse();
                //childNode.ToolTipText = "Select Room";
                parent.Nodes.Add(childNode);
            }
        }

        public List<RowColIndex> populateGridView()
        {
            DateTime sessionDate = dateTimePicker_sessionTrackDate.Value.Date;
            List<RowColIndex> list = new List<RowColIndex>();
           
            //dataGridView1.Height = this.Height - 100;
            //dataGridView1.Dock = DockStyle.Top;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.RowHeadersVisible = false;
            //this.dataGridView1.Paint += new PaintEventHandler(dataGrid_Paint);

            int rows = Int32.Parse(db.tblBasicMasters.Where(x => x.Description.Equals("Columns")).Single().Value);
            
            DataTable dt = new DataTable();
            DataRow drDate = null;
            dt.Columns.Add(new DataColumn("RowNumber", typeof(string)));
            for (int col = 1; col <= rows; col++)
            {
                dt.Columns.Add(new DataColumn("Col"+col, typeof(string)));
            }
            drDate = dt.NewRow();
            drDate["RowNumber"] = "Date";
            drDate["Col1"] = sessionDate;
            dt.Rows.Add(drDate);
            
            DataRow drHours = null;
            drHours = dt.NewRow();
            drHours["RowNumber"] = "Hours";
            int startHrs = Int32.Parse(db.tblBasicMasters.Where(x => x.Description.Equals("StartHrs")).Single().Value);
            int endHrs = Int32.Parse(db.tblBasicMasters.Where(x => x.Description.Equals("EndHrs")).Single().Value);
            int hrsCount = 1;
            for (int i = 1; i < rows; i++)
            {
                    if (startHrs <= endHrs && (hrsCount+3) % 4 != 0)
                    {
                        drHours["Col" + i] = "";
                    }
                    else
                        if (startHrs <= endHrs && (hrsCount + 3) % 4 == 0)
                    {
                        drHours["Col" + i] = startHrs.ToString();
                        startHrs++;
                    }
                    hrsCount++;
            }
            dt.Rows.Add(drHours);
            
            DataRow drMinutes = null;
            drMinutes = dt.NewRow();
            drMinutes["RowNumber"] = "Minutes";
            int hrs = 0;
            for (int i = 1; i <= rows; i++)
            {
                if (hrs == 0)
                    drMinutes["Col" + i] = "00";
                if (hrs == 15)
                    drMinutes["Col" + i] = "15";
                if (hrs == 30)
                    drMinutes["Col" + i] = "30";
                if (hrs == 45)
                    drMinutes["Col" + i] = "45";
                                 hrs += 15;
                if (hrs >= 60)
                {
                    hrs = 0;
                }
            }             
            dt.Rows.Add(drMinutes);


            //DateTime datetime = DateTime.ParseExact(date, "yyyy-MM-dd 00:00:00", null);

            var sessions = from sessionAvtivity in db.tblSessionActivities join sessionMaster in db.tblSessionMasters
                           on sessionAvtivity.SessionId equals sessionMaster.SessionId
                           join employee in db.tblEmployeeDetails on sessionMaster.SessionOwnerId equals employee.EmployeeId
                           join subject in db.tblSubjectMasters on sessionAvtivity.SubjectId equals subject.SubjectId
                           join course in db.tblCourseMasters on sessionAvtivity.CourseId equals course.CourseId
                           join batch in db.tblBatchMasters on sessionAvtivity.BatchId equals batch.BatchId
                           join location in db.tblLocationMasters on sessionAvtivity.LocationId equals location.LocationId
                           join room in db.tblRoomMasters on sessionAvtivity.RoomId equals room.RoomId
                           join task in db.tblTaskMasters on sessionAvtivity.TaskId equals task.TaskId
                           where sessionAvtivity.SessionDate == sessionDate
                           orderby employee.FirstName
                           select new
                           {
                               sessionMaster.SessionCode,
                               employee.EmployeeCode,
                               employee.FirstName,
                               employee.LastName,
                               subject.SubjectName,
                               course.CourseCode,
                               course.CourseName,
                               batch.BatchCode,
                               batch.BatchName,
                               task.TaskName,
                               sessionAvtivity.SessionDate,
                               sessionAvtivity.StartTime,
                               sessionAvtivity.EndTime,
                               sessionAvtivity.SessionDuration,
                               sessionAvtivity.isActive,
                               sessionAvtivity.isCompleted,
                               sessionAvtivity.SessionActivityId
                           };
            sessions.ToList();


            int Count = 0;
            int rowCount = 0;
            int alreadyPresentRowIndex = 0;
            bool alreadyPresentRow = false;
            foreach (var session in sessions)
            {
                TimeSpan start = session.StartTime.Value;
                TimeSpan end = session.EndTime.Value;

                int startHrsRowIndex = 0;
                int startHrsColIndex=0;
                int endHrsRowIndex = 0;
                int endHrsColIndex = 0; 
                int startMinRowIndex = 0;
                int startMinColIndex = 0;
                int endMinRowIndex = 0;
                int endMinColIndex = 0;
                Count = 0;
                alreadyPresentRow = false;

                foreach(DataRow rowCheck in dt.Rows)
                {
                    String a =rowCheck["RowNumber"].ToString();
                    int r = dt.Rows.IndexOf(rowCheck);
                    if (rowCheck["RowNumber"].ToString() == session.FirstName + " " + session.LastName && dt.Rows.IndexOf(rowCheck) > 2)
                    {
                        alreadyPresentRowIndex = dt.Rows.IndexOf(rowCheck);
                        alreadyPresentRow = true;
                    }     
                }

                if (!alreadyPresentRow)
                {
                    DataRow drSession = null;
                    drSession = dt.NewRow();
                    drSession["RowNumber"] = session.FirstName + " " + session.LastName;
                    dt.Rows.Add(drSession);
                    rowCount++;
                }

                foreach (DataRow row in dt.Rows)
                {
                    if (dt.Rows.IndexOf(row) > 0)
                    {
                        foreach (DataColumn col in dt.Columns)
                        {
                            if (dt.Columns.IndexOf(col) > 0)
                            {
                                String cellText = row[col].ToString();

                                if (row[col].ToString().Equals(session.StartTime.Value.Hours.ToString()) && Count == 0)
                                {
                                    startHrsRowIndex = dt.Rows.IndexOf(row);
                                    startHrsColIndex = dt.Columns.IndexOf(col);
                                    int Value1 = session.StartTime.Value.Hours;
                                    for (int subColIndex = startHrsColIndex; subColIndex <= startHrsColIndex + 3; subColIndex++)
                                    {
                                        if (Convert.ToInt32(dt.Rows[startHrsRowIndex + 1][subColIndex].ToString()) == Convert.ToInt32(session.StartTime.Value.Minutes.ToString()))
                                        {
                                            startMinRowIndex = startHrsRowIndex + rowCount;
                                            startMinColIndex = subColIndex;     
                                        }
                                    }
                                    Count++;
                                }
                                if (row[col].ToString().Equals(session.EndTime.Value.Hours.ToString()) && Count == 1)
                                {
                                    endHrsRowIndex = dt.Rows.IndexOf(row);
                                    endHrsColIndex = dt.Columns.IndexOf(col);
                                    int Value2 = session.EndTime.Value.Hours;
                                    for (int subColIndex = endHrsColIndex; subColIndex <= endHrsColIndex + 3; subColIndex++)
                                    {
                                        if (Convert.ToInt32(dt.Rows[endHrsRowIndex + 1][subColIndex].ToString()) == Convert.ToInt32(session.EndTime.Value.Minutes.ToString()))
                                        {
                                            endMinRowIndex = endHrsRowIndex + rowCount;
                                            endMinColIndex = subColIndex;          
                                        }
                                    }
                                    Count++;
                                }    
                            }
                        }
                    }
                }
                if (Count == 2)
                {
                    int paintRowIndex = startMinRowIndex + 1;
                    for (int paintColIndex = startMinColIndex; paintColIndex < endMinColIndex; paintColIndex++)
                    {
                        if (alreadyPresentRow)
                        {
                            paintRowIndex = alreadyPresentRowIndex;
                        }
                        String display = session.CourseCode.ToString() + "/" + session.BatchCode.ToString() + " - " + session.SubjectName.ToString() + "/" + session.TaskName.ToString()+"("+session.SessionActivityId.ToString()+")";

                        dt.Rows[paintRowIndex][paintColIndex] = display;
                    }
                    RowColIndex rowColIndex = new RowColIndex();
                    rowColIndex.rowIndex = startMinRowIndex;
                    rowColIndex.startColIndex = startMinColIndex;
                    rowColIndex.endColIndex = endMinColIndex;
                    list.Add(rowColIndex);
                    
                }  
            }
            dataGridView1.DataSource = dt;

            return list;
       }

        public System.Windows.Forms.Button AddNewButton()
        { 
            System.Windows.Forms.Button txt = new System.Windows.Forms.Button();
            panel_sessionList.Controls.Add(txt);
            txt.Top = cLeft * 25;
            txt.Left = 5;
            txt.Text = "TextBox " + this.cLeft.ToString();
            cLeft = cLeft + 1;
            return txt;
        }

        private void button_createSession_Click(object sender, EventArgs e)
        {
            CreateSession createSession = new CreateSession();
            createSession.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 3 || e.RowIndex >= dataGridView1.Rows.Count || e.ColumnIndex < 1 || e.ColumnIndex >= dataGridView1.Columns.Count)
                return;
            else
            {
                String cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                
                int sessionActivityId = Int32.Parse(cell.Substring(cell.IndexOf("(")+1, 1));

                AttendanceStudent.setSessionActivityId(sessionActivityId);
                AttendanceStudent.setHasComeFromSessionTrack(true);

                //If this user has been deleted in another window, display error message.
                tblSessionActivity selectedSessionActivity = db.tblSessionActivities.Where(x => x.SessionActivityId == sessionActivityId && x.isActive == 1).FirstOrDefault();
                if (selectedSessionActivity == null)
                {
                    MessageBox.Show("Session not found. It may have been deleted.", "Error");
                    return;
                }

                //Invoke the UserDetails form.
                AttendanceStudent attendanceStudent = new AttendanceStudent();
                attendanceStudent.Show();
            }
            
        }

        private void dateTimePicker_sessionTrackDate_ValueChanged(object sender, EventArgs e)
        {
            formLoad();
        }       
    }

}