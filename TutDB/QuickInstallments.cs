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
    public partial class QuickInstallments : Form
    {
        TutDBEntities db = CommonUtilities.getConnection();

        static Int32 StudentId;
        static bool hasComeFromInstallment = false;
        int maxInstallmentNo = 0;
        int feeAmount = 0;
        int remainingAmount = 0;


        public QuickInstallments()
        {
            InitializeComponent();
        }

        internal static void setStudentId(int selectedStudentId)
        {
            StudentId = selectedStudentId;
        }

        internal static void setHasComeFromInstallment(bool hasCome)
        {
            hasComeFromInstallment = hasCome;
        }

        private void QuickInstallments_Load(object sender, EventArgs e)
        {
            //feeAmount = Convert.ToInt32(db.tblStudentDetails.Where(x => x.StudentId == StudentId).Single().tblCourseMaster.tblFeesMasters.Single().Amount);
            //textBox_FeeAmount.Text = feeAmount.ToString();
            
            //int maxInstallmentNo=0;
            //maxInstallmentNo = db.tblFeeStructures.Where(x => x.StudentId == StudentId).Max(x => x.InstallmentNo).Value;
            //remainingAmount = (int)(Decimal.Parse(db.tblFeeStructures.Where(x => x.StudentId == StudentId && x.InstallmentNo == maxInstallmentNo).Single().AmountRemaining.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture));
            //textBox_remainingAmount.Text = remainingAmount.ToString();

            //List<String> occurances = new List<string>();
            //occurances.Add("Select");
            //occurances.Add("Month");
            //occurances.Add("Day");
            //occurances.Add("Year");
            //comboBox_Occurances.DataSource = occurances;

            //textBox_FeeAmount.ReadOnly = true;
            //textBox_Amount.ReadOnly = true;
            //textBox_Occurance.ReadOnly = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_CustomizedAmount.CheckState == CheckState.Checked)
            {
                textBox_Amount.ReadOnly = false;
            }
            else
                if (checkBox_CustomizedAmount.CheckState == CheckState.Unchecked)
                {
                    textBox_Amount.ReadOnly = true;
                }     
        }

        private void button_QuickInstallmentSubmit_Click(object sender, EventArgs e)
        {
            //if (validateQuickInstallment())
            //    return; //Validation fails.
            ////Validation successful.
            //else
                
            //{
            //    int installmentNo = Int32.Parse(textBox_NoOfInstallment.Text.ToString());
            //    DateTime installmentDate = dateTimePicker_InstallmentDate.Value;

            //    int payPattern = 0;
            //    if (comboBox_Occurances.SelectedItem.ToString() == "Month")
            //    {
            //        payPattern = 1;
            //    }
            //    else
            //        if (comboBox_Occurances.SelectedItem.ToString() == "Day")
            //        {
            //            payPattern = 2;
            //        }
            //        else
            //            if (comboBox_Occurances.SelectedItem.ToString() == "Year")
            //            {
            //                payPattern = 3;
            //            }

            //    int payInterval = Int32.Parse(textBox_Occurance.Text.ToString());
            //    int installmentAmount = 0;
            //    if (checkBox_CustomizedAmount.CheckState == CheckState.Checked)
            //    {
            //        installmentAmount = Int32.Parse(textBox_Amount.Text.ToString());
            //    }


            //    db.sp_createInstallment(StudentId, installmentNo, payPattern, payInterval, installmentDate, installmentAmount);

            //    bool exceptionOccured = false;
            //    try
            //    {
            //        bool success = false;

            //        using (TransactionScope transaction = new TransactionScope())
            //        {
            //            try
            //            {
            //                //db.sp_createInstallment(StudentId, installmentNo, payPattern, payInterval, installmentDate, installmentAmount);
            //                transaction.Complete();
            //                success = true;
            //            }
            //            catch (Exception ex)
            //            {
            //                success = false;
            //            }
            //        }
            //        if (success)
            //        {
            //            //db.AcceptAllChanges(); //Transaction was successful, commit all changes.
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.StackTrace);
            //        exceptionOccured = true;
            //    }

            //    if (!exceptionOccured)
            //    {
            //        MessageBox.Show("Installment created successfully.", "Success");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Something went wrong.", "Error");
            //    }

            //    this.Close();



            //FeeStructure.setStudentId(StudentId);
            //FeeStructure.setHasComeFromSearch(true);

            ////If this user has been deleted in another window, display error message.
            //tblStudentDetail selectedStudent = db.tblStudentDetails.Where(x => x.StudentId == StudentId && x.isActive == 1).FirstOrDefault();
            //if (selectedStudent == null)
            //{
            //    MessageBox.Show("Student not found. He/She may have been deleted.", "Error");
            //    return;
            //}

            ////Invoke the UserDetails form.
            //FeeStructure feeStructure = new FeeStructure();
            //feeStructure.Show();
            //}
        }

        private void button_QuickInstallmentCancel_Click(object sender, EventArgs e)
        {
            QuickInstallments quickInstallment = new QuickInstallments();
            this.Close();
        }

        private void comboBox_Occurances_SelectedIndexChanged(object sender, EventArgs e)
        {
            //String a = comboBox_Occurances.SelectedItem.ToString();
            if (comboBox_Occurances.SelectedItem.ToString() != "Select")
            {
                textBox_Occurance.Text = "";
                textBox_Occurance.ReadOnly = false;
            }
            else
            {
                textBox_Occurance.Text = "";
                textBox_Occurance.ReadOnly = true;
            }
        }


        //private bool validateQuickInstallment()
        //{
        //    bool errorOccurred = false;
        //    String errorMessage = "";

        //    if (textBox_NoOfInstallment.Text.Trim().Equals(""))
        //    {
        //        errorOccurred = true;
        //        errorMessage += "-> Please enter No of Installments \n";
        //    }

        //    if (comboBox_Occurances.SelectedItem.ToString() != "Select" && textBox_Occurance.Text.Trim().Equals(""))
        //    {
        //        errorOccurred = true;
        //        errorMessage += "-> Please enter No of Occurances \n";
        //    }

        //    if (checkBox_CustomizedAmount.CheckState == CheckState.Checked && textBox_Amount.Text.Trim().Equals(""))
        //    {
        //        errorOccurred = true;
        //        errorMessage += "-> Please enter Installment Amount \n";
        //    }

        //    maxInstallmentNo = Convert.ToInt32(db.tblFeeStructures.Where(x => x.StudentId == StudentId).Max(x => x.InstallmentNo));

        //    if (db.tblFeeStructures.Where(x => x.StudentId == StudentId).ToList().Count() > 0)
        //    {
        //        //int maxInstallmentNo=Convert.ToInt32(db.tblFeeStructures.Where(x => x.StudentId == StudentId).Max(y => y.InstallmentNo));
        //        DateTime installmentDate = db.tblFeeStructures.Where(x => x.StudentId == StudentId && x.InstallmentNo == maxInstallmentNo).Single().InstallmentDate.Value;

        //        if (Convert.ToDateTime(dateTimePicker_InstallmentDate.Value.Date) == installmentDate || Convert.ToDateTime(dateTimePicker_InstallmentDate.Value.Date) < installmentDate)
        //        {
        //            errorOccurred = true;
        //            errorMessage += "->Installment date should be ahead of previous installment date.. \n";
        //        }

        //        //int amountRemaining=Convert.ToInt32(db.tblFeeStructures.Where(x=>x.StudentId==StudentId && x.InstallmentNo==maxInstallmentNo).Single().AmountRemaining);

        //        //if (Convert.ToInt32(txtInstallmentAmount.Text) > amountRemaining)
        //        //{
        //        //    errorOccurred = true;
        //        //    errorMessage += "->Amount should be less than Remaining Amount.. \n";
        //        //}

        //    }

        //    if (errorOccurred)
        //    {
        //        MessageBox.Show(errorMessage, "Error");
        //    }
        //    return errorOccurred;
        //}
    }
}
