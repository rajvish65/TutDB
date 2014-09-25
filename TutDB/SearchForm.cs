using System;
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
    public partial class SearchForm : Form
    {
        TutDBEntities db = CommonUtilities.getConnection();

        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            CommonUtilities.populateCourse(combo_course);
            CommonUtilities.populateBatch(combo_batch);
        }

        /// <summary>
        /// Called when a cell in the DataGridView (which is displaying search results) is clicked. It is used to open the UserDetail form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void studentDetails(object sender, DataGridViewCellEventArgs e)
        {
            //Getting the value of clicked row
            DataGridView button = sender as DataGridView;
            DataGridViewCellCollection selectedUser = button.CurrentRow.Cells as DataGridViewCellCollection;

            //Returns the selected customer ID
            int selectedStudentId = Int32.Parse(selectedUser["StudentId"].Value.ToString());

            //UserDetails.setUserId(selectedStudentId);
            //UserDetails.setIsStudent(true);

            //If this user has been deleted in another window, display error message.
            tblStudentDetail selectedStudent = db.tblStudentDetails.Where(x => x.StudentId == selectedStudentId && x.isActive==1).FirstOrDefault();
            if (selectedStudent == null)
            {
                MessageBox.Show("User not found. He/She may have been deleted.", "Error");                
                return;
            }

            //Invoke the UserDetails form.
            //UserDetails userDetail = new UserDetails();
            //userDetail.Show();            
        }


        /// <summary>
        /// Called when a cell in the DataGridView (which is displaying search results) is clicked. It is used to open the UserDetail form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void employeeDetails(object sender, DataGridViewCellEventArgs e)
        {
            //Getting the value of clicked row
            DataGridView button = sender as DataGridView;
            DataGridViewCellCollection selectedUser = button.CurrentRow.Cells as DataGridViewCellCollection;

            //Returns the selected customer ID
            int selectedEmployeeId = Int32.Parse(selectedUser["EmployeeId"].Value.ToString());

            //UserDetails.setUserId(selectedEmployeeId);
            //UserDetails.setIsEmployee(true);


            //If this user has been deleted in another window, display error message.
            tblEmployeeDetail selectedEmployee = db.tblEmployeeDetails.Where(x => x.EmployeeId == selectedEmployeeId && x.isActive==1).FirstOrDefault();
            if (selectedEmployee == null)
            {
                MessageBox.Show("User not found. He/She may have been deleted.", "Error");                
                return;
            }

            //Invoke the UserDetails form.
            //UserDetails userDetail = new UserDetails();
            //userDetail.Show();            
        }  
      
        private void button_Search_StudentDetails_Click(object sender, EventArgs e)
        {
            ////Get hold of all form-fields.
            //String firstName = textBox_studentFirstName.Text.ToLower();
            //String lastName = textBox_studentLastName.Text.ToLower();
            //String course = (combo_course.SelectedItem as tblCourseMaster).CourseName.ToString() == "Select" ? "" : (combo_course.SelectedItem as tblCourseMaster).CourseName.ToString();
            //String batch = (combo_batch.SelectedItem as tblBatchMaster).BatchName.ToString() == "Select" ? "" : (combo_batch.SelectedItem as tblBatchMaster).BatchName.ToString();
            
            ////Query for retrieving users from the DB
            //var student = db.tblStudentDetails.Where(x => x.FirstName.Contains(firstName) && x.LastName.Contains(lastName) && x.isActive==1 && x.tblCourseMaster.CourseName.Contains(course) && x.tblBatchMaster.BatchName.Contains(batch) )
            //                            .Select(x => new { x.StudentId,x.StudentCode, x.FirstName, x.LastName,x.tblCourseMaster.CourseName,x.tblBatchMaster.BatchName,x.DOB,x.AdmitDate,x.Deposit }).OrderBy(x => x.FirstName);
            //student.ToList();
            //dataGridView_studentSearchResults.DataSource = student.ToList();

            ////Hide the extra column.
            //dataGridView_studentSearchResults.Columns["StudentId"].Visible = false;

            ////Registering an event handler when a particular row is clicked.
            //dataGridView_studentSearchResults.CellClick -= studentDetails;
            //dataGridView_studentSearchResults.CellClick += studentDetails;
        }

        private void button_Search_EmployeeDetails_Click(object sender, EventArgs e)
        {
            String firstName = textBox_studentFirstName.Text.ToLower();
            String lastName = textBox_studentLastName.Text.ToLower();
            
            var employee = db.tblEmployeeDetails.Where(x => x.FirstName.Contains(firstName) && x.LastName.Contains(lastName) && x.isActive == 1)
                             .Select(x => new { x.EmployeeId, x.EmployeeCode, x.FirstName, x.LastName,x.DOB,x.Designation,x.Contacts,x.Email,x.JoiningDate }).OrderBy(x => x.FirstName);
            employee.ToList();
            dataGridView_searchEmployeeResult.DataSource = employee.ToList();
            //Hide the extra column.
            dataGridView_searchEmployeeResult.Columns["EmployeeId"].Visible = false;

            dataGridView_searchEmployeeResult.CellClick -= employeeDetails;
            dataGridView_searchEmployeeResult.CellClick += employeeDetails;
        }
       
    }
}
