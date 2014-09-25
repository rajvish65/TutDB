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
    public partial class StaffAttendance : Form
    {
        TutDBEntities db = CommonUtilities.getConnection();
        static bool HasStaffAttendanceAlreadyPresent = false;
        int cLeft = 0;
        int count = 1;

        public StaffAttendance()
        {
            InitializeComponent();
        }

        internal static void setHasStaffAttendanceAlreadyPresent(bool alreadyPresent)
        {
            HasStaffAttendanceAlreadyPresent = alreadyPresent;
        }

        private void StaffAttendance_Load(object sender, EventArgs e)
        {
            this.comboBox_designation.SelectedIndexChanged -= new System.EventHandler(this.comboBox_designation_SelectedIndexChanged);
            CommonUtilities.populateDesignation(comboBox_designation);
            this.comboBox_designation.SelectedIndexChanged += new System.EventHandler(this.comboBox_designation_SelectedIndexChanged);
            onFormLoad();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void onFormLoad()
        {
            var AlreadyStaffAttendancePresent = from employee in db.tblEmployeeDetails
                                                join staffAttendance in db.tblStaffAttendances
                                                on employee.EmployeeId equals staffAttendance.EmployeeId
                                                where staffAttendance.AttendanceDate == dateTimePicker_staffAttendance.Value.Date
                                                orderby employee.FirstName, employee.LastName
                                                select new
                                                {
                                                    employee.EmployeeId,
                                                    employee.EmployeeCode,
                                                    employee.FirstName,
                                                    employee.LastName,
                                                    employee.Designation,
                                                    staffAttendance.isPresent,
                                                    staffAttendance.LeaveReason
                                                };
            AlreadyStaffAttendancePresent.ToList();
            int a = AlreadyStaffAttendancePresent.Count();

            if (AlreadyStaffAttendancePresent.ToList().Count != 0)
            {
                setHasStaffAttendanceAlreadyPresent(true);
            }

            if (!HasStaffAttendanceAlreadyPresent)
            {
                var EmployeeDetails = from employee in db.tblEmployeeDetails
                                      orderby employee.FirstName, employee.LastName
                                      select new
                                      {
                                          employee.EmployeeId,
                                          employee.EmployeeCode,
                                          employee.FirstName,
                                          employee.LastName,
                                          employee.Designation
                                      };
                EmployeeDetails.ToList();

                cLeft = 7;

                count = 1;
                foreach (var item in EmployeeDetails)
                {
                    System.Windows.Forms.Label label_employeeNo = new System.Windows.Forms.Label();
                    this.Controls.Add(label_employeeNo);
                    label_employeeNo.Top = cLeft * 22;
                    label_employeeNo.Left = 40;
                    label_employeeNo.Size = new System.Drawing.Size(20, 15);
                    label_employeeNo.Text = count.ToString();

                    System.Windows.Forms.Label label_employeeId = new System.Windows.Forms.Label();
                    this.Controls.Add(label_employeeId);
                    label_employeeId.Top = cLeft * 22;
                    label_employeeId.Left = 40;
                    label_employeeId.Visible = false;
                    label_employeeId.Text = item.EmployeeId.ToString();

                    System.Windows.Forms.Label label_employeeName = new System.Windows.Forms.Label();
                    this.Controls.Add(label_employeeName);
                    label_employeeName.Top = cLeft * 22;
                    label_employeeName.Left = 100;
                    label_employeeName.Size = new System.Drawing.Size(100, 13);
                    label_employeeName.Text = item.FirstName.ToString() + " " + item.LastName.ToString();

                    System.Windows.Forms.Label label_employeeDesignation = new System.Windows.Forms.Label();
                    this.Controls.Add(label_employeeDesignation);
                    label_employeeDesignation.Top = cLeft * 22;
                    label_employeeDesignation.Left = 250;
                    label_employeeDesignation.Size = new System.Drawing.Size(50, 13);
                    label_employeeDesignation.Text = item.Designation.ToString();

                    System.Windows.Forms.CheckBox check_employee = new System.Windows.Forms.CheckBox();
                    this.Controls.Add(check_employee);
                    check_employee.Top = cLeft * 22;
                    check_employee.Left = 350;
                    check_employee.Size = new System.Drawing.Size(13, 13);
                    check_employee.CheckState = CheckState.Checked;
                    check_employee.CheckedChanged += new System.EventHandler(this.check_employee_CheckedChanged);

                    System.Windows.Forms.ComboBox combobox_reason = new System.Windows.Forms.ComboBox();
                    this.Controls.Add(combobox_reason);
                    combobox_reason.Top = cLeft * 22;
                    combobox_reason.Left = 400;
                    combobox_reason.Visible = false;
                    combobox_reason.Size = new System.Drawing.Size(120, 15);
                    combobox_reason.Text = "";
                    CommonUtilities.populateLeaveReason(combobox_reason);
                    combobox_reason.SelectedIndex = 1;

                    cLeft = cLeft + 1;
                    count++;
                }

                cLeft += 3;


                System.Windows.Forms.Button button_submit = new Button();
                this.Controls.Add(button_submit);
                button_submit.Top = cLeft * 22;
                button_submit.Left = 200;
                button_submit.Size = new System.Drawing.Size(100, 23);
                button_submit.Text = "Submit";
                button_submit.Click += new EventHandler(button_submit_Click);
            }


            if (HasStaffAttendanceAlreadyPresent)
            {
                cLeft = 7;

                count = 1;
                foreach (var item in AlreadyStaffAttendancePresent)
                {
                    System.Windows.Forms.Label label_employeeNo = new System.Windows.Forms.Label();
                    this.Controls.Add(label_employeeNo);
                    label_employeeNo.Top = cLeft * 22;
                    label_employeeNo.Left = 40;
                    label_employeeNo.Size = new System.Drawing.Size(20, 15);
                    label_employeeNo.Text = count.ToString();

                    System.Windows.Forms.Label label_employeeId = new System.Windows.Forms.Label();
                    this.Controls.Add(label_employeeId);
                    label_employeeId.Top = cLeft * 22;
                    label_employeeId.Left = 40;
                    label_employeeId.Visible = false;
                    label_employeeId.Text = item.EmployeeId.ToString();

                    System.Windows.Forms.Label label_employeeName = new System.Windows.Forms.Label();
                    this.Controls.Add(label_employeeName);
                    label_employeeName.Top = cLeft * 22;
                    label_employeeName.Left = 100;
                    label_employeeName.Size = new System.Drawing.Size(100, 13);
                    label_employeeName.Text = item.FirstName.ToString() + " " + item.LastName.ToString();

                    System.Windows.Forms.Label label_employeeDesignation = new System.Windows.Forms.Label();
                    this.Controls.Add(label_employeeDesignation);
                    label_employeeDesignation.Top = cLeft * 22;
                    label_employeeDesignation.Left = 250;
                    label_employeeDesignation.Size = new System.Drawing.Size(50, 13);
                    label_employeeDesignation.Text = item.Designation.ToString();

                    System.Windows.Forms.CheckBox check_employee = new System.Windows.Forms.CheckBox();
                    this.Controls.Add(check_employee);
                    check_employee.Top = cLeft * 22;
                    check_employee.Left = 350;
                    check_employee.Size = new System.Drawing.Size(13, 13);
                    if (item.isPresent == 1)
                        check_employee.CheckState = CheckState.Checked;
                    else
                        check_employee.CheckState = CheckState.Unchecked;
                    check_employee.CheckedChanged += new System.EventHandler(this.check_employee_CheckedChanged);

                    System.Windows.Forms.ComboBox combobox_reason = new System.Windows.Forms.ComboBox();
                    this.Controls.Add(combobox_reason);
                    combobox_reason.Top = cLeft * 22;
                    combobox_reason.Left = 400;
                    combobox_reason.Visible = false;
                    combobox_reason.Size = new System.Drawing.Size(120, 20);
                    CommonUtilities.populateLeaveReason(combobox_reason);
                    combobox_reason.SelectedIndex = 1;

                    if (check_employee.CheckState == CheckState.Unchecked)
                    {
                        combobox_reason.Text = item.LeaveReason.ToString();
                        combobox_reason.Visible = true;
                    }

                    cLeft = cLeft + 1;
                    count++;
                }

                cLeft += 3;

                System.Windows.Forms.Button button_update = new Button();
                this.Controls.Add(button_update);
                button_update.Top = cLeft * 22;
                button_update.Left = 200;
                button_update.Size = new System.Drawing.Size(100, 23);
                button_update.Text = "Update";
                button_update.Click += new EventHandler(button_update_Click);

            }

            System.Windows.Forms.Button button_cancel = new Button();
            this.Controls.Add(button_cancel);
            button_cancel.Top = cLeft * 22;
            button_cancel.Left = 300;
            button_cancel.Size = new System.Drawing.Size(100, 23);
            button_cancel.Text = "Cancel";
            button_cancel.Click += new EventHandler(button_cancel_Click);
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            int employeeId = 0;
            int attended = -1;
            String reason = null;
          
            bool exceptionOccured = false;
            try
            {
                bool success = false;
                using (TransactionScope transaction = new TransactionScope())
                {
                    try
                    {
                        for (int i = 6; i < this.Controls.Count; i++)
                        {
                            if (this.Controls[i] is Label)
                            {
                                Label label_EmployeeId = (Label)this.Controls[i];
                                if (label_EmployeeId.Visible == false)
                                {
                                    employeeId = Int32.Parse(label_EmployeeId.Text.ToString());
                                }
                            }
                            if (this.Controls[i] is CheckBox)
                            {
                                CheckBox chk = (CheckBox)this.Controls[i];
                                if (chk.CheckState == CheckState.Checked)
                                    attended = 1;
                                else
                                {
                                    attended = 0;
                                    if (this.Controls[i + 1] is ComboBox)
                                    {
                                        ComboBox combobox_reason = (ComboBox)this.Controls[i + 1];
                                        reason = (combobox_reason.SelectedItem as tblBasicMaster).Value.ToString();
                                        i += 1;
                                    }
                                }
                            }

                            if (employeeId != 0 && attended != -1)
                            {
                                tblStaffAttendance staffAttendance = new tblStaffAttendance();
                                staffAttendance = (from sa in db.tblStaffAttendances
                                              where sa.EmployeeId == employeeId && sa.AttendanceDate == dateTimePicker_staffAttendance.Value.Date
                                              select sa).First();
                                if (staffAttendance != null)
                                {
                                    staffAttendance.EmployeeId = employeeId;
                                    staffAttendance.EnteredDate = DateTime.Now;
                                    staffAttendance.AttendanceDate = dateTimePicker_staffAttendance.Value.Date;
                                    staffAttendance.isPresent = attended;
                                    staffAttendance.LeaveReason = reason;
                                    staffAttendance.UpdatedDate = DateTime.Today;
                                    db.SaveChanges();
                                }
                                employeeId = 0;
                                attended = -1;
                                reason = null;
                            }
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
                MessageBox.Show("Attendance updated successfully.", "Success");
            }
            else
            {
                MessageBox.Show("Something went wrong.", "Error");
            }
        }

        private void check_employee_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 6; i < this.Controls.Count; i++)
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


        private void button_submit_Click(object sender, EventArgs e)
        {
            int EmployeeId = 0;
            int attended = -1;
            String reason = null;

            bool exceptionOccured = false;
            try
            {
                bool success = false;


                using (TransactionScope transaction = new TransactionScope())
                {
                    try
                    {

                        for (int i = 6; i < this.Controls.Count; i++)
                        {
                            if (this.Controls[i] is Label)
                            {
                                Label label_EmployeeId = (Label)this.Controls[i];
                                if (label_EmployeeId.Visible == false)
                                {
                                    EmployeeId = Int32.Parse(label_EmployeeId.Text.ToString());
                                }
                            }

                            if (this.Controls[i] is CheckBox)
                            {
                                CheckBox chk = (CheckBox)this.Controls[i];
                                if (chk.CheckState == CheckState.Checked)
                                    attended = 1;
                                else
                                {
                                    attended = 0;
                                    if (this.Controls[i + 1] is ComboBox)
                                    {
                                        ComboBox combobox_reason = (ComboBox)this.Controls[i + 1];
                                        reason = (combobox_reason.SelectedItem as tblBasicMaster).Value.ToString();
                                        i += 1;
                                    }
                                }
                            }

                            if (EmployeeId != 0 && attended != -1)
                            {
                                tblStaffAttendance staffattendance = new tblStaffAttendance();
                                staffattendance.EmployeeId = EmployeeId;
                                staffattendance.EnteredDate = dateTimePicker_staffAttendance.Value;
                                staffattendance.AttendanceDate = DateTime.Now;
                                staffattendance.isPresent = attended;
                                staffattendance.LeaveReason = reason;
                                staffattendance.CreatedDate = DateTime.Today;
                                db.tblStaffAttendances.Add(staffattendance);

                                EmployeeId = 0;
                                attended = -1;
                                reason = null;
                            }
                        }

                        db.SaveChanges();

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
                MessageBox.Show("Attendance recorded successfully.", "Success");
            }
            else
            {
                MessageBox.Show("Something went wrong.", "Error");
            }
        }

       

        private void comboBox_designation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((comboBox_designation.SelectedItem as tblBasicMaster).Value.ToString().Equals("Select"))
            {
                HasStaffAttendanceAlreadyPresent = false;
                clearFormControls();
                onFormLoad();
            }
            else
            {
                onChangeFormLoad();
            }
        }

        public void clearFormControls()
        {
            for (int i = this.Controls.Count - 1; i > 5; i--)
            {
                this.Controls[i].Dispose();
            }
        }

        private void dateTimePicker_staffAttendance_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker_staffAttendance.Value.Date > DateTime.Now)
            {
                String date = dateTimePicker_staffAttendance.Value.Date.ToString().Substring(1, dateTimePicker_staffAttendance.Value.Date.ToString().IndexOf(" "));
                dateTimePicker_staffAttendance.Value = DateTime.Now;
                MessageBox.Show("Attendance for " + date + " cannot be recorded before");
            }
            else
            {
                if ((comboBox_designation.SelectedItem as tblBasicMaster).Value.ToString().Equals("Select"))
                {
                    HasStaffAttendanceAlreadyPresent = false;
                    clearFormControls();
                    onFormLoad();
                }
                else
                {
                    onChangeFormLoad();
                }
            }
        }

        public void onChangeFormLoad()
        {
            HasStaffAttendanceAlreadyPresent = false;
            clearFormControls();

            String designation = (comboBox_designation.SelectedItem as tblBasicMaster).Value.ToString();

            var AlreadyStaffAttendancePresent = from employee in db.tblEmployeeDetails
                                                join staffAttendance in db.tblStaffAttendances
                                                on employee.EmployeeId equals staffAttendance.EmployeeId
                                                where staffAttendance.AttendanceDate == dateTimePicker_staffAttendance.Value.Date && employee.Designation == designation
                                                orderby employee.FirstName, employee.LastName
                                                select new
                                                {
                                                    employee.EmployeeId,
                                                    employee.EmployeeCode,
                                                    employee.FirstName,
                                                    employee.LastName,
                                                    employee.Designation,
                                                    staffAttendance.isPresent,
                                                    staffAttendance.LeaveReason
                                                };
            AlreadyStaffAttendancePresent.ToList();

            if (AlreadyStaffAttendancePresent.ToList().Count != 0)
            {
                setHasStaffAttendanceAlreadyPresent(true);
            }

            if (!HasStaffAttendanceAlreadyPresent)
            {
                var EmployeeDetails = from employee in db.tblEmployeeDetails
                                      where employee.Designation == designation
                                      orderby employee.FirstName, employee.LastName
                                      select new
                                      {
                                          employee.EmployeeId,
                                          employee.EmployeeCode,
                                          employee.FirstName,
                                          employee.LastName,
                                          employee.Designation
                                      };
                EmployeeDetails.ToList();

                cLeft = 7;

                count = 1;
                foreach (var item in EmployeeDetails)
                {
                    System.Windows.Forms.Label label_employeeNo = new System.Windows.Forms.Label();
                    this.Controls.Add(label_employeeNo);
                    label_employeeNo.Top = cLeft * 22;
                    label_employeeNo.Left = 40;
                    label_employeeNo.Size = new System.Drawing.Size(20, 15);
                    label_employeeNo.Text = count.ToString();

                    System.Windows.Forms.Label label_employeeId = new System.Windows.Forms.Label();
                    this.Controls.Add(label_employeeId);
                    label_employeeId.Top = cLeft * 22;
                    label_employeeId.Left = 40;
                    label_employeeId.Visible = false;
                    label_employeeId.Text = item.EmployeeId.ToString();

                    System.Windows.Forms.Label label_employeeName = new System.Windows.Forms.Label();
                    this.Controls.Add(label_employeeName);
                    label_employeeName.Top = cLeft * 22;
                    label_employeeName.Left = 100;
                    label_employeeName.Size = new System.Drawing.Size(100, 13);
                    label_employeeName.Text = item.FirstName.ToString() + " " + item.LastName.ToString();

                    System.Windows.Forms.Label label_employeeDesignation = new System.Windows.Forms.Label();
                    this.Controls.Add(label_employeeDesignation);
                    label_employeeDesignation.Top = cLeft * 22;
                    label_employeeDesignation.Left = 250;
                    label_employeeDesignation.Size = new System.Drawing.Size(50, 13);
                    label_employeeDesignation.Text = item.Designation.ToString();

                    System.Windows.Forms.CheckBox check_employee = new System.Windows.Forms.CheckBox();
                    this.Controls.Add(check_employee);
                    check_employee.Top = cLeft * 22;
                    check_employee.Left = 350;
                    check_employee.Size = new System.Drawing.Size(13, 13);
                    check_employee.CheckState = CheckState.Checked;
                    check_employee.CheckedChanged += new System.EventHandler(this.check_employee_CheckedChanged);

                    System.Windows.Forms.ComboBox combobox_reason = new System.Windows.Forms.ComboBox();
                    this.Controls.Add(combobox_reason);
                    combobox_reason.Top = cLeft * 22;
                    combobox_reason.Left = 400;
                    combobox_reason.Visible = false;
                    combobox_reason.Size = new System.Drawing.Size(120, 15);
                    combobox_reason.Text = "";
                    CommonUtilities.populateLeaveReason(combobox_reason);
                    combobox_reason.SelectedIndex = 1;

                    cLeft = cLeft + 1;
                    count++;
                }

                cLeft += 3;

                if (EmployeeDetails.Count() > 0)
                {
                    System.Windows.Forms.Button button_submit = new Button();
                    this.Controls.Add(button_submit);
                    button_submit.Top = cLeft * 22;
                    button_submit.Left = 200;
                    button_submit.Size = new System.Drawing.Size(100, 23);
                    button_submit.Text = "Submit";
                    button_submit.Click += new EventHandler(button_submit_Click);

                    System.Windows.Forms.Button button_cancel = new Button();
                    this.Controls.Add(button_cancel);
                    button_cancel.Top = cLeft * 22;
                    button_cancel.Left = 300;
                    button_cancel.Size = new System.Drawing.Size(100, 23);
                    button_cancel.Text = "Cancel";
                    button_cancel.Click += new EventHandler(button_cancel_Click);
                }
            }

            if (HasStaffAttendanceAlreadyPresent)
            {
                cLeft = 7;

                count = 1;
                foreach (var item in AlreadyStaffAttendancePresent)
                {
                    System.Windows.Forms.Label label_employeeNo = new System.Windows.Forms.Label();
                    this.Controls.Add(label_employeeNo);
                    label_employeeNo.Top = cLeft * 22;
                    label_employeeNo.Left = 40;
                    label_employeeNo.Size = new System.Drawing.Size(20, 15);
                    label_employeeNo.Text = count.ToString();

                    System.Windows.Forms.Label label_employeeId = new System.Windows.Forms.Label();
                    this.Controls.Add(label_employeeId);
                    label_employeeId.Top = cLeft * 22;
                    label_employeeId.Left = 40;
                    label_employeeId.Visible = false;
                    label_employeeId.Text = item.EmployeeId.ToString();

                    System.Windows.Forms.Label label_employeeName = new System.Windows.Forms.Label();
                    this.Controls.Add(label_employeeName);
                    label_employeeName.Top = cLeft * 22;
                    label_employeeName.Left = 100;
                    label_employeeName.Size = new System.Drawing.Size(100, 13);
                    label_employeeName.Text = item.FirstName.ToString() + " " + item.LastName.ToString();

                    System.Windows.Forms.Label label_employeeDesignation = new System.Windows.Forms.Label();
                    this.Controls.Add(label_employeeDesignation);
                    label_employeeDesignation.Top = cLeft * 22;
                    label_employeeDesignation.Left = 250;
                    label_employeeDesignation.Size = new System.Drawing.Size(50, 13);
                    label_employeeDesignation.Text = item.Designation.ToString();

                    System.Windows.Forms.CheckBox check_employee = new System.Windows.Forms.CheckBox();
                    this.Controls.Add(check_employee);
                    check_employee.Top = cLeft * 22;
                    check_employee.Left = 350;
                    check_employee.Size = new System.Drawing.Size(13, 13);
                    if (item.isPresent == 1)
                        check_employee.CheckState = CheckState.Checked;
                    else
                        check_employee.CheckState = CheckState.Unchecked;
                    check_employee.CheckedChanged += new System.EventHandler(this.check_employee_CheckedChanged);

                    System.Windows.Forms.ComboBox combobox_reason = new System.Windows.Forms.ComboBox();
                    this.Controls.Add(combobox_reason);
                    combobox_reason.Top = cLeft * 22;
                    combobox_reason.Left = 400;
                    combobox_reason.Visible = false;
                    combobox_reason.Size = new System.Drawing.Size(120, 20);
                    CommonUtilities.populateLeaveReason(combobox_reason);
                    combobox_reason.SelectedIndex = 1;

                    if (check_employee.CheckState == CheckState.Unchecked)
                    {
                        combobox_reason.Text = item.LeaveReason.ToString();
                        combobox_reason.Visible = true;
                    }

                    cLeft = cLeft + 1;
                    count++;
                }

                cLeft += 3;

                if (AlreadyStaffAttendancePresent.Count() > 0)
                {
                    System.Windows.Forms.Button button_update = new Button();
                    this.Controls.Add(button_update);
                    button_update.Top = cLeft * 22;
                    button_update.Left = 200;
                    button_update.Size = new System.Drawing.Size(100, 23);
                    button_update.Text = "Update";
                    button_update.Click += new EventHandler(button_update_Click);

                    System.Windows.Forms.Button button_cancel = new Button();
                    this.Controls.Add(button_cancel);
                    button_cancel.Top = cLeft * 22;
                    button_cancel.Left = 300;
                    button_cancel.Size = new System.Drawing.Size(100, 23);
                    button_cancel.Text = "Cancel";
                    button_cancel.Click += new EventHandler(button_cancel_Click);
                }
            }
        } 
    }
}
