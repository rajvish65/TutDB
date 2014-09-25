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
    public partial class MainForm : Form
    {
        TutDBEntities db = CommonUtilities.getConnection();

        int selectedStudentId = -1;
        public MainForm()
        {
            InitializeComponent();
        }

       
        private void button_Search_Click(object sender, EventArgs e)
        {
            

            //Get hold of all form-fields.
            String firstName = txtFirstName.Text.ToLower();
            String lastName = txtLastName.Text.ToLower();
            String course = (cmbCourse.SelectedItem as tblCourseMaster).CourseName.ToString() == "Select" ? "" : (cmbCourse.SelectedItem as tblCourseMaster).CourseName.ToString();
            String batch = (cmbBatch.SelectedItem as tblBatchMaster).BatchName.ToString() == "Select" ? "" : (cmbBatch.SelectedItem as tblBatchMaster).BatchName.ToString();


            var users = from details in db.tblStudentDetails
                        join allocation in db.tblStudentAllocations on details.StudentId equals allocation.StudentId
                        join courses in db.tblCourseMasters on allocation.CourseId equals courses.CourseId
                        join batches in db.tblBatchMasters on allocation.BatchId equals batches.BatchId
                        where details.FirstName.Contains(firstName) && details.LastName.Contains(lastName) && courses.CourseName.Contains(course) && batches.BatchName.Contains(batch) && allocation.isActive==1
                        orderby details.FirstName, details.LastName
                        select new
                        {
                            details.StudentId,
                            details.StudentCode,
                            details.FirstName,
                            details.LastName,
                            courses.CourseName,
                            batches.BatchName,
                        };

            users.ToList();
            dataGridView_student.DataSource = users.ToList();

            //Hide the extra column.
            dataGridView_student.Columns["StudentId"].Visible = false;

            //var user = db.tblEmployeeDetails.Where(x => x.FirstName.Contains(firstName) && x.LastName.Contains(lastName) && x.isActive == 1).Select(x => new { x.EmployeeId, x.EmployeeCode, x.FirstName, x.LastName }).OrderBy(x => x.FirstName);
            //user.ToList();
            //dataGridView_student.DataSource = user.ToList();
            ////Hide the extra column.
            //dataGridView_student.Columns["EmployeeId"].Visible = false;

            //Registering an event handler when a particular row is clicked.
            dataGridView_student.CellClick -= displayDetailsUser;
            dataGridView_student.CellClick += displayDetailsUser;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            CommonUtilities.populateCourse(cmbCourse);
            CommonUtilities.populateBatch(cmbBatch);
        }

        /// <summary>
        /// Fetch/Generate the monthly bill of the selected user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void displayDetailsUser(object sender, DataGridViewCellEventArgs e)
        {
            //Enable the Monthly Bill gridview, which is disabled by default
            groupBox_StudentDetails.Enabled = true;
            lblStdName.Enabled = true;
            lblStdFullName.Enabled = true;
            lblStdCourse.Enabled = true;
            lblStdCourseName.Enabled = true;
            lblStdBatch.Enabled = true;
            lblStdBatchName.Enabled = true;
            linkLabel_thisUsersDetails.Enabled = true;
            linkLabel_feeStructure.Enabled = true;
            groupBox_PaymentDetails.Enabled = true;
            dataGridView_installmentLogs.Enabled = true;
            dataGridView_paymnetLogs.Enabled = true;
            //dataGridView_billForThisMonth.Visible = true;

            //Getting the value of clicked row
            DataGridView button = sender as DataGridView;
            DataGridViewCellCollection selectedUser = button.CurrentRow.Cells as DataGridViewCellCollection;

            //Returns the selected customer ID
            selectedStudentId = Int32.Parse(selectedUser["StudentId"].Value.ToString());

            String name = db.tblStudentDetails.Where(x => x.StudentId == selectedStudentId).FirstOrDefault().FirstName + db.tblStudentDetails.Where(x => x.StudentId == selectedStudentId).FirstOrDefault().LastName;
//            String course = db.tblStudentDetails.Where(x => x.StudentId == selectedStudentId).FirstOrDefault().tblCourseMaster.CourseName;
//            String batch = db.tblStudentDetails.Where(x => x.StudentId == selectedStudentId).FirstOrDefault().tblBatchMaster.BatchName;
 //           lblStdFullName.Text = name;
 //           lblStdCourseName.Text = course;
 //           lblStdBatchName.Text = batch;
            //Change text on button.
            //button_generateBill.Text = "Export " + db.CustomerDetails.Where(x => x.CustomerId == selectedCustomerId).Single().FirstName + "'s " + " Bill";

            //int month = currentMonth.TodayDate.Month;
            //int year = currentMonth.TodayDate.Year;
            //int noOfDays = DateTime.DaysInMonth(year, month);

            //DateTime startDate = new DateTime(year, month, 1);
            //DateTime endDate = new DateTime(year, month, noOfDays);

            //Initialize Month to current month in the combo-box.
            //comboBox_month.SelectedIndex = currentMonth.TodayDate.Month - 1; //Combo box index starts from 0

            //Change the text on the link label which points to user details, to the user's name.
            linkLabel_thisUsersDetails.Text = db.tblStudentDetails.Where(x => x.StudentId == selectedStudentId).FirstOrDefault().FirstName + "'s details";
            linkLabel_feeStructure.Text = db.tblStudentDetails.Where(x => x.StudentId == selectedStudentId).FirstOrDefault().FirstName + "'s fee details";
            //createMonthlyBill(startDate, endDate);


 //           var installment = db.tblFeeStructures.Where(x => x.StudentId == selectedStudentId)
 //                                       .Select(x => new { x.StudentId, x.InstallmentNo, x.InstallmentAmount, x.InstallmentDate, x.PaidStatus, x.PaidDate }).OrderBy(x => x.InstallmentNo);
            // users.ToList();
 //           dataGridView_installmentLogs.DataSource = installment.ToList();
            //Hide the extra column.
 //           dataGridView_installmentLogs.Columns["StudentId"].Visible = false;


//            var paymentHistory = db.tblFeesDetails.Where(x => x.StudentId == selectedStudentId).Select(x => new { x.FeeReceiptNo, x.AmountToBePaid, x.AmountPaid, x.PaidTimeStamp }).OrderBy(x => new { x.FeeReceiptNo, x.PaidTimeStamp });
 //           dataGridView_paymnetLogs.DataSource = paymentHistory.ToList();


        }

        

        private void linkLabel_thisUsersDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Form1 form = new Form1();
            //form.Show();

            StudentRegistration.setStudentId(selectedStudentId);
            StudentRegistration.setHasComeFromSearch(true);

            //If this user has been deleted in another window, display error message.
            tblStudentDetail selectedStudent = db.tblStudentDetails.Where(x => x.StudentId == selectedStudentId && x.isActive==1).FirstOrDefault();
            if (selectedStudent == null)
            {
                MessageBox.Show("Student not found. He/She may have been deleted.", "Error");
                return;
            }

            //Invoke the UserDetails form.
            StudentRegistration studentDetail = new StudentRegistration();
            studentDetail.Show();
        }

        private void linkLabel_addNewCourse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CourseMaster courseMaster = new CourseMaster();
            courseMaster.Show();
        }

        private void linkLabel_addNewBatch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BatchMaster batchMaster = new BatchMaster();
            batchMaster.Show();
        }

        private void linkLabel_feeStructure_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            FeeStructure.setStudentId(selectedStudentId);
            FeeStructure.setHasComeFromSearch(true);

            //If this user has been deleted in another window, display error message.
            tblStudentDetail selectedStudent = db.tblStudentDetails.Where(x => x.StudentId == selectedStudentId && x.isActive == 1).FirstOrDefault();
            if (selectedStudent == null)
            {
                MessageBox.Show("Student not found. He/She may have been deleted.", "Error");
                return;
            }

            //Invoke the UserDetails form.
            FeeStructure feeStructure = new FeeStructure();
            feeStructure.Show();
        }

        private void linkLabel_addStudent_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StudentRegistration studentRegistration = new StudentRegistration();
            studentRegistration.Show();
        }

        private void linkLabel_addEmployee_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EmployeeRegistration employeeRegistration = new EmployeeRegistration();
            employeeRegistration.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.Show();
        }

        private void linkLabel_goToMasters_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Masters master = new Masters();
            master.Show();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {

        }

      
    }
}
