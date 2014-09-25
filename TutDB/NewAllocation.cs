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
using System.IO;
using System.Globalization;

namespace TutDB
{
    public partial class NewAllocation : Form
    {
        TutDBEntities db = CommonUtilities.getConnection();
        static Int32 StudentId;
        static Int32 AllocationId;
        static bool hasComeFromStudentDetail = false;

        public NewAllocation()
        {
            InitializeComponent();
        }
        internal static void setStudentId(int selectedStudentId)
        {
            StudentId = selectedStudentId;
        }
        internal static void setAllocationId(int selectedAllocationId)
        {
            AllocationId = selectedAllocationId;
        }
        internal static void setHasComeFromStudentDetail(bool hasCome)
        {
            hasComeFromStudentDetail = hasCome;
        }

        private void NewAllocation_Load(object sender, EventArgs e)
        {
            if (hasComeFromStudentDetail == false)
            {
                this.comboBox_courseAllocate.SelectedIndexChanged -= new System.EventHandler(this.comboBox_courseAllocate_SelectedIndexChanged);
                CommonUtilities.populateCourse(comboBox_courseAllocate);
                this.comboBox_courseAllocate.SelectedIndexChanged += new System.EventHandler(this.comboBox_courseAllocate_SelectedIndexChanged);
            }
            else
            {
                tblStudentAllocation studentAllocation = null;

                try
                {
                    studentAllocation = db.tblStudentAllocations.Where(x => x.StudentId == StudentId && x.AllocationId == AllocationId).Single();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("User not found. He/She may have been deleted.", "Error");
                    this.Close();
                    return;
                }

                button_AddAllocation.Visible = false;

                //Set values of all textboxes
                txtFees.Text = studentAllocation.Fees.ToString();
                txtDiscount.Text = studentAllocation.Discount.ToString();  
                txtDeposit.Text = studentAllocation.Deposit.ToString();
                txtActualFees.Text = studentAllocation.ActualFees.ToString();

                comboBox_courseAllocate.Text = studentAllocation.tblCourseMaster.CourseName;
                comboBox_batchAllocate.Text = studentAllocation.tblBatchMaster.BatchName;
                combobox_lastQualificationAllocate.Text = studentAllocation.LastQualification;
                if (studentAllocation.LastQualificationScore.ToString() != null)
                {
                    cmbLastQualificationScore.Text = studentAllocation.LastQualificationScore;
                }
                
                txtFees.Enabled = false;
                txtDiscount.Enabled = false;
                txtDeposit.Enabled = false;
                txtActualFees.Enabled = false;
                comboBox_courseAllocate.Enabled = false;
                comboBox_batchAllocate.Enabled = false;
                combobox_lastQualificationAllocate.Enabled = false;
                cmbLastQualificationScore.Enabled = false;
                dateTimePicker_startDateAllocate.Enabled = false;
                dateTimePicker_endDateAllocate.Enabled = false;
            }

        }

        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                int fees = 0;
                String fee = txtFees.Text.ToString();

                fees = Convert.ToInt32(fee.Substring(0, fee.Length - 3));
                int discount = Convert.ToInt32(txtDiscount.Text.ToString());
                int actualfees = fees - discount;

                txtActualFees.Text = actualfees.ToString() + ".00";
                txtActualFees.ReadOnly = true;
            }
        }


        private void comboBox_courseAllocate_SelectedIndexChanged(object sender, EventArgs e)
        {
            CommonUtilities.loadBatchCombo(comboBox_batchAllocate, comboBox_courseAllocate.SelectedIndex);
            CommonUtilities.loadCourseFees(txtFees, comboBox_courseAllocate.SelectedIndex);
        }

        /// <summary>
        /// Validates the form-fields before insertion into the DB.
        /// </summary>
        /// <returns></returns>
        private bool validate()
        {
            bool errorOccurred = false;
            String errorMessage = "";

            if (comboBox_courseAllocate.Text.Trim().Equals("") || comboBox_courseAllocate.Text.Trim().Equals("Select"))
            {
                errorOccurred = true;
                errorMessage += "-> Please select Course \n";
            }
            if (comboBox_batchAllocate.Text.Trim().Equals("") || comboBox_batchAllocate.Text.Trim().Equals("Select"))
            {
                errorOccurred = true;
                errorMessage += "-> Please select Batch \n";
            }
            if (combobox_lastQualificationAllocate.Text.Trim().Equals("") || combobox_lastQualificationAllocate.Text.Trim().Equals("Select"))
            {
                errorOccurred = true;
                errorMessage += "-> Please select Qualification \n";
            }

            if (dateTimePicker_startDateAllocate.Value < dateTimePicker_endDateAllocate.Value)
            {
                errorOccurred = true;
                errorMessage += "-> Please Enter Valid Dates \n";
            }
            int fee;
            if (txtFees.Text.Trim().Length != 0)
            {
                String Currentfee = Convert.ToString((int)(Decimal.Parse(txtFees.Text, NumberStyles.Float, CultureInfo.InvariantCulture)));
                if (!Int32.TryParse(Currentfee, out fee))
                {
                    errorOccurred = true;
                    errorMessage += "-> Fee Cannot be Empty,Please select course \n";
                }
            }
            int deposit;
            if (txtDeposit.Text.Trim().Length != 0)
            {
                if (!Int32.TryParse(txtDeposit.Text, out deposit))
                {
                    errorOccurred = true;
                    errorMessage += "-> Please Enter a Valid Deposit \n";
                }
            }

            if (errorOccurred)
            {
                MessageBox.Show(errorMessage, "Error");
            }

            return errorOccurred;
        }


        private void fetchAllocationValues(tblStudentAllocation studentAllocation)
        {
            //if (hasComeFromSearchDetail == true)
            //{
            //    studentDetails = db.tblStudentAllocations.Where(x => x.AllocationId == AllocationId && x.isActive == 1).Single();
            //}

            studentAllocation.isActive = 1;
            studentAllocation.AdmitDate = dateTimePicker_startDateAllocate.Value;
            studentAllocation.StartDate = dateTimePicker_startDateAllocate.Value;
            studentAllocation.EndDate = dateTimePicker_endDateAllocate.Value;
            studentAllocation.CreatedDate = DateTime.Today;

            String selectedCourse = (comboBox_courseAllocate.SelectedItem as tblCourseMaster).CourseName.ToString();
            int courseId = Convert.ToInt32(db.tblCourseMasters.Where(x => x.CourseName.Equals(selectedCourse)).First().CourseId);
            studentAllocation.CourseId = courseId;

            String selectedBatch = (comboBox_batchAllocate.SelectedItem as tblBatchMaster).BatchName.ToString();
            int batchId = Convert.ToInt32(db.tblBatchMasters.Where(x => x.BatchName.Equals(selectedBatch)).First().BatchId);
            studentAllocation.BatchId = batchId;

            String selectedQualification = combobox_lastQualificationAllocate.SelectedItem.ToString();
            studentAllocation.LastQualification = selectedQualification;

            String selectedQualificationScore = cmbLastQualificationScore.SelectedItem.ToString();
            studentAllocation.LastQualificationScore = selectedQualificationScore;

            int payableFees = 0;
            String fees = txtFees.Text.ToString();
            payableFees = Convert.ToInt32(fees.Substring(0, fees.Length - 3));
            //Int32.TryParse(txtFees.Text.Trim(), out payableFees);
            studentAllocation.Fees = payableFees;

            int discountAmount = 0;
            Int32.TryParse(txtDiscount.Text.Trim(), out discountAmount);
            studentAllocation.Discount = discountAmount;

            int depositAmount = 0;
            Int32.TryParse(txtDeposit.Text.Trim(), out depositAmount);
            studentAllocation.Deposit = depositAmount;

            int actualAmount = 0;
            actualAmount = payableFees - discountAmount;
            txtActualFees.Text = actualAmount.ToString();
            studentAllocation.ActualFees = depositAmount;

        }

        private void button_AddAllocation_Click(object sender, EventArgs e)
        {
            if (validate())
                return; //Validation fails.

            //Validation successful.

            tblStudentAllocation allocationDetailsNew = new tblStudentAllocation();
            tblStudentAllocation allocationDetailsOld = new tblStudentAllocation();


            bool exceptionOccured = false;
            try
            {
                bool success = false;

                /* For every new Customer inserted into the DB, entries are made in 2 tables - CustomerDetails and CustomerDues.
                 * Hence a transaction is required. */
                using (TransactionScope transaction = new TransactionScope())
                {
                    try
                    {
                        int allocationId = Convert.ToInt32(db.tblStudentAllocations.Where(x => x.StudentId == StudentId).Max(x => x.AllocationId).ToString());
                        allocationDetailsOld = db.tblStudentAllocations.Where(x => x.AllocationId == allocationId && x.StudentId == StudentId).Single();
                        allocationDetailsOld.isActive = 0;
                        allocationDetailsOld.isOver = 1;
                        db.SaveChanges();

                        allocationDetailsNew.StudentId = StudentId;
                        fetchAllocationValues(allocationDetailsNew);
                        if (hasComeFromStudentDetail == false)
                        {
                            db.tblStudentAllocations.Add(allocationDetailsNew);
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

            if (!exceptionOccured && hasComeFromStudentDetail == false)
            {
                MessageBox.Show("Allocation added successfully.", "Success");
            }
            else
            {
                MessageBox.Show("Something went wrong.", "Error");
            }
        }
    }
}
