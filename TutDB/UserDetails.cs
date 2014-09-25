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
    public partial class UserDetails : Form
    {
        TutDBEntities db = CommonUtilities.getConnection();
        //CustomerId of the Customer whose details are being displayed.
        static Int32 userId;
        static bool isEmployee = false;
        static bool isStudent = false;

        //Calendar for the current month.
        MonthCalendar calendar = new MonthCalendar();

        public static void setUserId(int selectedUserId)
        {
            userId = selectedUserId;
        }

        internal static void setIsEmployee(bool isEmp)
        {
            isEmployee = isEmp;
        }
        internal static void setIsStudent(bool isStud)
        {
            isStudent = isStud;
        }

        public UserDetails()
        {
            InitializeComponent();
        }

        private void UserDetails_Load(object sender, EventArgs e)
        {
            //if (isStudent.Equals(true))
            //{
            //    tblStudentDetail studentDetail = null;

            //    try
            //    {
            //        studentDetail = db.tblStudentDetails.Where(x => x.StudentId == userId && x.isActive == 1).Single();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("User not found. He/She may have been deleted.", "Error");
            //        this.Close();
            //        return;
            //    }

            //    textBox_course.Visible = true;
            //    textBox_batch.Visible = true;
            //    textBox_deposit.Visible = true;
            //    label_course.Visible = true;
            //    label_batch.Visible = true;
            //    label_deposit.Visible = true;
            //    label_designation.Visible = false;
            //    textBox_designation.Visible = false;
            //    //Set values of all textboxes
            //    groupBox_userDetails.Text = studentDetail.FirstName + " " + studentDetail.LastName;
            //    textBox_address.Text = studentDetail.Address1 + " " + studentDetail.Address2 + " " + studentDetail.tblCityMaster.CityName;
            //    textBox_email.Text = studentDetail.Email;
            //    textBox_contact.Text = studentDetail.ResiContacts.ToString();
            //    textBox_mobile.Text = studentDetail.Contacts.ToString();
            //    textBox_course.Text = studentDetail.tblCourseMaster.CourseName;
            //    textBox_batch.Text = studentDetail.tblBatchMaster.BatchName;
            //    textBox_joiningDate.Text = studentDetail.AdmitDate.Value.Date.ToString();
            //    textBox_deposit.Text = "Rs. " + studentDetail.Deposit.ToString();

            //    //change the employee flag
            //    isEmployee = false;
            //}
            //if (isEmployee.Equals(true))
            //{
            //    tblEmployeeDetail employeeDetail = null;

            //    try
            //    {
            //        employeeDetail = db.tblEmployeeDetails.Where(x => x.EmployeeId == userId && x.isActive == 1).Single();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("User not found. He/She may have been deleted.", "Error");
            //        this.Close();
            //        return;
            //    }

            //    textBox_course.Visible = false;
            //    textBox_batch.Visible = false;
            //    textBox_deposit.Visible = false;
            //    label_course.Visible = false;
            //    label_batch.Visible = false;
            //    label_deposit.Visible = false;
            //    label_designation.Visible = true;
            //    textBox_designation.Visible = true;
            //    //Set values of all textboxes
            //    groupBox_userDetails.Text = employeeDetail.FirstName + " " + employeeDetail.LastName;
            //    textBox_address.Text = employeeDetail.Address1 + " " + employeeDetail.Address2 + " " + employeeDetail.tblCityMaster.CityName;
            //    textBox_email.Text = employeeDetail.Email;
            //    textBox_contact.Text = employeeDetail.ResiContacts.ToString();
            //    textBox_mobile.Text = employeeDetail.Contacts.ToString();
            //    textBox_joiningDate.Text = employeeDetail.JoiningDate.Value.Date.ToString();
            //    textBox_designation.Text = employeeDetail.Designation;

            //    //change the student flag
            //    isStudent = false;
            }



            ////Populate the year combo box
            //List<int> years = new List<int>();            
            //for (int year = 2012; year <= calendar.TodayDate.Year; year++)
            //{
            //    years.Add(year);
            //}
            //comboBox_year.DataSource = years;
            //comboBox_year.SelectedItem = calendar.TodayDate.Year;

            ////Prepare the Monthly Bills of this user, in order to view them in the panel.
            //displayBillForYear(calendar.TodayDate.Year);

            ////Display users balance and carryforward amount
            //long dueAmount = 0;
            //long carryforwardAmount = 0;
            //try
            //{
            //    dueAmount = db.CustomerDues.Where(x => x.CustomerId == userId).Select(x => x.DueAmount).FirstOrDefault();
            //    carryforwardAmount = db.CustomerDues.Where(x => x.CustomerId == userId).Select(x => x.CarryforwardAmount).FirstOrDefault();

            //    label_dueAmount.Text = dueAmount.ToString();
            //    label_carryForwardAmount.Text = carryforwardAmount.ToString();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.StackTrace);
            //}            
        }

        //void thisMonthsBill_Scroll(object sender, ScrollEventArgs e)
        //{
        //    flowLayoutPanel1.PerformLayout();
        //}

        
        /// <summary>
        /// Displays the user's bill history
        /// </summary>
        /// <param name="year"></param>
        //private void displayBillForYear(int year)
        //{
        //    //flowLayoutPanel1.Controls.Clear();

        //    //DateTime firstDayOfYear = new DateTime(year, 1, 1);
        //    //DateTime lastDayOfYear = new DateTime(year, 12, 31);

        //    ////Retrieve ALL bills from MonthlyBills table, for this user.
        //    //List<MonthlyBill> billsforThisUser = db.MonthlyBills.Where(x => x.CustomerId == customerId && x.DateTaken >= firstDayOfYear && x.DateTaken <= lastDayOfYear).ToList();
           
        //    //if (billsforThisUser.Count == 0) //If no bill found, don't proceed.
        //    //    return;

        //    ////Custom Controls, which will be constructed at runtime.
        //    //List<MonthlyBillCustomControl> monthlyBillControls = new List<MonthlyBillCustomControl>();

        //    ////Each month's bill in a year.
        //    //for (int month = 1; month <= 12; month++)
        //    //{
        //    //    DateTime firstDayOfMonth = new DateTime(year, month, 1);
        //    //    DateTime lastDayOfMonth = new DateTime(year, month, DateTime.DaysInMonth(year, month));

        //    //    MonthlyBillCustomControl thisMonthsBill = new MonthlyBillCustomControl();
        //    //    Label monthLabel = thisMonthsBill.Controls["label_month"] as Label;
        //    //    monthLabel.Text = firstDayOfMonth.ToShortDateString() + " - " + lastDayOfMonth.ToShortDateString();
                
        //    //    DataGridView monthlyBillGridView = thisMonthsBill.Controls["dataGridView_monthlyBill"] as DataGridView;
                
        //    //    List<MonthlyBill> thisMonth = billsforThisUser.Where(x => x.DateTaken >= firstDayOfMonth && x.DateTaken <= lastDayOfMonth).ToList();
        //    //    if (thisMonth.Count == 0) //If no bill for this month, go to the next month.
        //    //        continue;               

        //    //    monthlyBillGridView.DataSource = thisMonth;
        //    //    monthlyBillGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        //    //    monthlyBillGridView.Columns["CustomerId"].Visible = false;
        //    //    monthlyBillGridView.Columns["CustomerDetail"].Visible = false;

        //    //    //Change the HeaderText for some columns to make them more understandable.
        //    //    monthlyBillGridView.Columns["DateTaken"].HeaderText = "Date Taken";
        //    //    monthlyBillGridView.Columns["DateTaken"].DefaultCellStyle.Format = "dd-MMM-yy";
        //    //    monthlyBillGridView.Columns["LunchAmount"].HeaderText = "Lunch";
        //    //    monthlyBillGridView.Columns["DinnerAmount"].HeaderText = "Dinner";
        //    //    monthlyBillGridView.Columns["DailyPayment"].HeaderText = "Daily Payments";
                
        //    //    highlightWeekends(thisMonth, monthlyBillGridView); //NOT WORKING - BALA PLEASE CHECK!

        //    //    //Set the values for the different variables on the Custom Control.
        //    //    Label monthlyConsumptionLabel = thisMonthsBill.Controls["label_monthlyConsumption"] as Label;
        //    //    monthlyConsumptionLabel.Text = thisMonth.Sum(x => x.LunchAmount + x.DinnerAmount).ToString();
        //    //    Label dailyPayments = thisMonthsBill.Controls["label_dailyPayments"] as Label;
        //    //    dailyPayments.Text = thisMonth.Sum(x => x.DailyPayment).ToString();                
        //    //    Label dabbawalaCharges = thisMonthsBill.Controls["label_dabbawalaCharges"] as Label;
        //    //    dabbawalaCharges.Text = db.ExtraCharges.Where(x => x.CustomerId == customerId && x.MonthId == month && x.Year == year).Single().DabbawalaCharges.ToString();
        //    //    Label deliveryCharges = thisMonthsBill.Controls["label_deliveryCharges"] as Label;
        //    //    deliveryCharges.Text = db.ExtraCharges.Where(x => x.CustomerId == customerId && x.MonthId == month && x.Year == year).Single().DeliveryCharges.ToString();
        //    //    Label payableAmount = thisMonthsBill.Controls["label_payableAmount"] as Label;
        //    //    payableAmount.Text = (Int32.Parse(monthlyConsumptionLabel.Text) + Int32.Parse(dabbawalaCharges.Text) + Int32.Parse(deliveryCharges.Text) - Int32.Parse(dailyPayments.Text)).ToString();

        //    //    thisMonthsBill.Scroll += new ScrollEventHandler(thisMonthsBill_Scroll);
        //    //    flowLayoutPanel1.Controls.Add(thisMonthsBill);
        //    //}            
        //}

        /// <summary>
        /// Highlights the Weekends - Yellow for Saturdays and Red for Sundays.
        /// </summary>
        /// <param name="thisMonthsBill"></param>
        /// <param name="dataGridView_billForThisMonth"></param>
        //private void highlightWeekends(List<MonthlyBill> thisMonthsBill, DataGridView dataGridView_billForThisMonth)
        //{
        //    //Highlighting sundays and saturdays
        //    for (int dayNumber = 1; dayNumber <= thisMonthsBill.Count(); dayNumber++)
        //    {
        //        if (thisMonthsBill[dayNumber - 1].DateTaken.DayOfWeek.Equals(DayOfWeek.Sunday))
        //        {
        //            dataGridView_billForThisMonth.Rows[dayNumber - 1].DefaultCellStyle.BackColor = Color.Red;
        //        }
        //        if (thisMonthsBill[dayNumber - 1].DateTaken.DayOfWeek.Equals(DayOfWeek.Saturday))
        //        {
        //            dataGridView_billForThisMonth.Rows[dayNumber - 1].DefaultCellStyle.BackColor = Color.Yellow;
        //        }
        //    }
        //}

        //private void button_showBills_Click(object sender, EventArgs e)
        //{
        //    displayBillForYear(Int32.Parse(comboBox_year.SelectedItem.ToString()));
        //}

       
        

        /// <summary>
        /// When the View Payment History link label is clicked.
        /// </summary>
        /// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void linkLabel_paymentHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    //PaymentHistory paymentHistory = new PaymentHistory(customerId);
        //    //paymentHistory.Show();
        //}

        /// <summary>
        /// When The Customer Payment link label is Clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void linkLabel_payment_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    //UserPayment payment = new UserPayment();
            
        //    ////Loading the Page with user values
        //    //payment.selectedCustomerId = customerId;
        //    //payment.hasComeFromUserDetail = true;

        //    //payment.Show();
        //}

        //private void groupBox_userDetails_Enter(object sender, EventArgs e)
        //{

        //}

        //private void groupBox_billingHistory_Enter(object sender, EventArgs e)
        //{

        //}

        //private void button_deleteUser_Click(object sender, EventArgs e)
        //{
        //    if (isStudent.Equals(true))
        //    {
        //        //If this user has been deleted in another window, display error message.
        //        StudentRegistration.setStudentId(userId);
        //        StudentRegistration.setHasComeFromSearch(true);

        //        //If this user has been deleted in another window, display error message.
        //        tblStudentDetail selectedStudent = db.tblStudentDetails.Where(x => x.StudentId == userId && x.isActive == 1).FirstOrDefault();
        //        if (selectedStudent == null)
        //        {
        //            MessageBox.Show("Student not found. He/She may have been deleted.", "Error");
        //            this.Close();
        //            return;
        //        }

        //        DialogResult result = MessageBox.Show("Are you Sure?", "Delete User", MessageBoxButtons.YesNo);

        //        if (result == DialogResult.Yes)
        //        {
        //            try
        //            {
        //                db.tblStudentDetails.Where(x => x.StudentId == userId && x.isActive == 1).FirstOrDefault().isActive = 0;
        //                db.SaveChanges();
        //            }
        //            catch (Exception ex)
        //            {
        //                Console.Write(ex.StackTrace);
        //            }
        //            MessageBox.Show("User deleted successfully.", "Success");
        //            this.Close();
        //        }
        //    }
        //    if (isEmployee.Equals(true))
        //    {
        //        //If this user has been deleted in another window, display error message.
        //        EmployeeRegistration.setEmployeeId(userId);
        //        EmployeeRegistration.setHasComeFromSearch(true);

        //        //If this user has been deleted in another window, display error message.
        //        tblEmployeeDetail selectedEmployee = db.tblEmployeeDetails.Where(x => x.EmployeeId == userId && x.isActive == 1).FirstOrDefault();
        //        if (selectedEmployee == null)
        //        {
        //            MessageBox.Show("Employee not found. He/She may have been deleted.", "Error");
        //            this.Close();
        //            return;
        //        }

        //        DialogResult result = MessageBox.Show("Are you Sure?", "Delete User", MessageBoxButtons.YesNo);

        //        if (result == DialogResult.Yes)
        //        {
        //            try
        //            {
        //                db.tblEmployeeDetails.Where(x => x.EmployeeId == userId && x.isActive == 1).FirstOrDefault().isActive = 0;
        //                db.SaveChanges();
        //            }
        //            catch (Exception ex)
        //            {
        //                Console.Write(ex.StackTrace);
        //            }
        //            MessageBox.Show("User deleted successfully.", "Success");
        //            this.Close();
        //        }
        //    }
        //}

        private void button_editUser_Click(object sender, EventArgs e)
        {
        //    if (isStudent.Equals(true))
        //    {
        //        //If this user has been deleted in another window, display error message.
        //        StudentRegistration.setStudentId(userId);
        //        StudentRegistration.setHasComeFromSearch(true);

        //        //If this user has been deleted in another window, display error message.
        //        tblStudentDetail selectedStudent = db.tblStudentDetails.Where(x => x.StudentId == userId && x.isActive == 1).FirstOrDefault();
        //        if (selectedStudent == null)
        //        {
        //            MessageBox.Show("Student not found. He/She may have been deleted.", "Error");
        //            return;
        //        }

        //        //Invoke the UserDetails form.
        //        //StudentRegistration studentDetail = new StudentRegistration();
        //        //studentDetail.Show();
        //    }
        //    if (isEmployee.Equals(true))
        //    {
        //        //If this user has been deleted in another window, display error message.
        //        EmployeeRegistration.setEmployeeId(userId);
        //        EmployeeRegistration.setHasComeFromSearch(true);

        //        //If this user has been deleted in another window, display error message.
        //        tblEmployeeDetail selectedEmployee = db.tblEmployeeDetails.Where(x => x.EmployeeId == userId && x.isActive == 1).FirstOrDefault();
        //        if (selectedEmployee == null)
        //        {
        //            MessageBox.Show("Student not found. He/She may have been deleted.", "Error");
        //            return;
        //        }

        //        //Invoke the UserDetails form.
        //        //EmployeeRegistration employeeDetail = new EmployeeRegistration();
        //        //employeeDetail.Show();
        //    }
        }

      

       

    }
}
