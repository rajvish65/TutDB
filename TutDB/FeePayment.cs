using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Transactions;
using System.Globalization;

namespace TutDB
{
    public partial class FeePayment : Form
    {
        TutDBEntities db = CommonUtilities.getConnection();

        static Int32 StudentId;
        static Int32 InstallmentId;
        static bool hasComeFromInstallmentToPayment = false;
        int amountToBePaid = 0;
        int amountPaid = 0;
        int totalAmountToBePaid = 0;
        int balanceAmount = 0;
        int advanceAmount = 0;

        int feeAmount = 0;

        internal static void setStudentId(int selectedStudentId)
        {
            StudentId = selectedStudentId;
        }

        internal static void setInstallmentId(int selectedInstallmentId)
        {
            InstallmentId = selectedInstallmentId;
        }

        internal static void setHasComeFromInstallmentToPayment(bool hasCome)
        {
            hasComeFromInstallmentToPayment = hasCome;
        }

        public FeePayment()
        {
            InitializeComponent();
        }

        private void FeePayment_Load(object sender, EventArgs e)
        {
            var studentDetails = db.tblStudentDetails.Where(x => x.StudentId == StudentId).FirstOrDefault();
            if (studentDetails != null)
            {
                textBox_studentCode.Text = studentDetails.StudentCode.ToString();
                textBox_studentName.Text = studentDetails.FirstName.ToString() + studentDetails.LastName.ToString();
                dateTimePicker_joiningDate.Value = studentDetails.AdmitDate.Value;
                //                textBox_course.Text = db.tblCourseMasters.Where(x => x.CourseId == studentDetails.CourseId).Single().CourseName.ToString();
                //                textBox_batch.Text = db.tblBatchMasters.Where(x => x.BatchId == studentDetails.BatchId).Single().BatchName.ToString();

                //                String feeReceiptNo =db.tblFeesDetails.Where(y=>y.StudentId==StudentId && y.isActive==1).Max(y=>y.FeeReceiptNo).ToString();
                //                var feeDetail = db.tblFeesDetails.Where(x => x.StudentId == StudentId && x.isActive == 1 && x.FeeReceiptNo.Equals(feeReceiptNo)).Single();


                //               textBox_balance.Text = String.Format("{0:#,##0.00}", feeDetail.Balance);
                //                textBox_advance.Text = String.Format("{0:#,##0.00}", feeDetail.Advance);


                label_installmentNo.Text = InstallmentId.ToString();

                String lastReceiptNo = db.tblFeesDetails.Take(1).OrderByDescending(x => x.RecordId).First().FeeReceiptNo.ToString();
                lastReceiptNo = (Int32.Parse(lastReceiptNo) + 1).ToString();
                label_receiptNo.Text = lastReceiptNo;


                //                String amount = db.tblFeeStructures.Where(x => x.StudentId == StudentId && x.InstallmentNo==InstallmentId).First().InstallmentAmount.ToString();
                //                if (amount.Contains("."))
                //                    amountToBePaid = Int32.Parse(amount.Substring(0, amount.LastIndexOf(".")));
                //               }
                textBox_amountToBePaid.Text = String.Format("{0:#,##0.00}", amountToBePaid);
                //int a = Convert.ToInt32(amount);
                CommonUtilities.calculateTaxes(amountToBePaid, textBox_serviceTaxToBePaid, textBox_otherTaxToBePaid, textBox_tuitionFeeToBePaid);
                //                if(feeDetail.Balance!=0)
                {
                    //                    String balance = feeDetail.Balance.ToString();
                    //                    if (balance.Contains("."))
                    //                   {
                    //                        balanceAmount = Int32.Parse(balance.Substring(0, balance.LastIndexOf(".")));
                    //                    }
                    label_customBalAdv.Text = "Balance";
                    textBox_coustomBalAdv.Text = String.Format("{0:#,##0.00}", balanceAmount);
                    totalAmountToBePaid = balanceAmount + amountToBePaid;
                    textBox_totalAmount.Text = String.Format("{0:#,##0.00}", totalAmountToBePaid);
                }
                //                    else
                //                    if(feeDetail.Advance!=0)
                {
                    //                        String advance = feeDetail.Advance.ToString();
                    //                        if (advance.Contains("."))
                    {
                        //                            advanceAmount = Int32.Parse(advance.Substring(0, advance.LastIndexOf(".")));
                    }
                    label_customBalAdv.Text = "Advance";
                    textBox_coustomBalAdv.Text = String.Format("{0:#,##0.00}", advanceAmount);

                    if (amountToBePaid > advanceAmount)
                    {
                        totalAmountToBePaid = amountToBePaid - advanceAmount;
                        textBox_totalAmount.Text = String.Format("{0:#,##0.00}", totalAmountToBePaid);
                    }
                    //                    }
                    //                   else
                    {
                        label_customBalAdv.Text = "Arrears";
                        textBox_coustomBalAdv.Text = String.Format("{0:#,##0.00}", 0);
                        totalAmountToBePaid = amountToBePaid;
                        textBox_totalAmount.Text = String.Format("{0:#,##0.00}", totalAmountToBePaid);
                    }


                    CommonUtilities.populatePaymentMethod(comboBox_paymentMethod);

                    //                var installment = db.tblFeeStructures.Where(x => x.StudentId == StudentId)
                    //                                       .Select(x => new { x.StudentId, x.InstallmentNo, x.InstallmentAmount, x.InstallmentDate, x.PaidStatus, x.PaidDate }).OrderBy(x => x.InstallmentNo);
                    // users.ToList();
                    //                dataGridView_paymentInstallment.DataSource = installment.ToList();
                    //Hide the extra column.
                    dataGridView_paymentInstallment.Columns["StudentId"].Visible = false;



                    //               var paymentHistory = db.tblFeesDetails.Where(x => x.StudentId == StudentId).Select(x => new { x.FeeReceiptNo, x.AmountToBePaid, x.AmountPaid, x.PaidTimeStamp }).OrderBy(x => new { x.FeeReceiptNo, x.PaidTimeStamp });
                    //               dataGridView_PaymentHistory.DataSource = paymentHistory.ToList();
                    //Hide the extra column.
                    //dataGridView_PaymentHistory.Columns["StudentId"].Visible = false;
                }
            }
        }

        

        

        private void textBox_amountToBePaid_MouseHover(object sender, EventArgs e)
        { 
            if (groupBox_amountToBePaidDetails.Visible==false)
            {
                groupBox_amountToBePaidDetails.Visible = true;
            }    
        }

        private void textBox_amountToBePaid_MouseLeave(object sender, EventArgs e)
        {
            if (groupBox_amountToBePaidDetails.Visible == true)
            {
                groupBox_amountToBePaidDetails.Visible = false;

            }
        }

        private void textBox_amountPaid_TextChanged(object sender, EventArgs e)
        {
            if (textBox_amountPaid.Text != "")
            {
                amountPaid = Convert.ToInt32(textBox_amountPaid.Text.ToString());
                CommonUtilities.calculateTaxes(amountPaid, textBox_serviceTax, textBox_otherTax, textBox_tuitionFee);
            }
        }


        private bool validatePayment()
        {
            bool errorOccurred = false;
            String errorMessage = "";

            if (textBox_amountPaid.Text.Trim().Equals("") || amountPaid== 0)
            {
                errorOccurred = true;
                errorMessage += "-> Amount cannot be 0 or Empty \n";
            }

            if ((comboBox_paymentMethod.SelectedValue as tblBasicMaster).Value.ToString().Equals("Select") || (comboBox_paymentMethod.SelectedValue as tblBasicMaster).Value.ToString().Equals(""))
            {
                errorOccurred = true;
                errorMessage += "-> Select Mode of Payment";
            }

            if (dateTimePicker_paidOn.Value.Equals(""))
            {
                errorOccurred = true;
                errorMessage += "-> Select valid Date";
            }

            if (errorOccurred)
            {
                MessageBox.Show(errorMessage, "Error");
            }

            return errorOccurred;
        }

        private void button_paymentSubmit_Click(object sender, EventArgs e)
        {


            if (validatePayment())
                return; //Validation fails.

            //Validation successful.

            
                else
                {
                    bool exceptionOccured = false;
                    try
                    {
                        bool success = false;


                        using (TransactionScope transaction = new TransactionScope())
                        {
                            try
                            {
                                tblFeesDetail feeDetails = new tblFeesDetail();
 //                               feeDetails.StudentId = StudentId;
                                feeDetails.AmountToBePaid = totalAmountToBePaid;

                                feeDetails.AmountPaid = amountPaid;
                                Double advance = double.Parse(textBox_tuitionFee.Text.ToString(), NumberStyles.Currency);
                                
                                feeDetails.ActualFees = (decimal)double.Parse(textBox_tuitionFee.Text.ToString(), NumberStyles.Currency);
                                feeDetails.ServiceTax =  (decimal)double.Parse(textBox_serviceTax.Text.ToString(), NumberStyles.Currency);
                                feeDetails.OtherTax = (decimal)double.Parse(textBox_otherTax.Text.ToString(), NumberStyles.Currency);
                                feeDetails.FeeReceiptNo = label_receiptNo.Text.ToString();
                                if (amountToBePaid > amountPaid)
                                {
                                    feeDetails.Balance = amountToBePaid - amountPaid;
                                    feeDetails.Advance = 0;
                                }
                                else
                                    if (totalAmountToBePaid < amountPaid)
                                    {
                                        feeDetails.Advance = amountPaid - totalAmountToBePaid;
                                        feeDetails.Balance = 0;
                                    }
                                    else
                                        if (totalAmountToBePaid == amountPaid)
                                        {
                                            feeDetails.Balance = 0;
                                            feeDetails.Advance = 0;
                                        }

                                feeDetails.PaidTimeStamp = dateTimePicker_paidOn.Value;
                                feeDetails.isActive = 1;
                                feeDetails.CreatedDate = DateTime.Now;
                                db.tblFeesDetails.Add(feeDetails);
                                db.SaveChanges();


 //                               tblFeeStructure feeStructure = db.tblFeeStructures.First(x => x.StudentId == StudentId && x.InstallmentNo == InstallmentId);
//                                feeStructure.PaidStatus = "Paid";
//                                feeStructure.PaidDate = DateTime.Now;
 //                               feeStructure.UpdatedDate = DateTime.Now;
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
                        Clear();
                        form_load();
                        groupBox_paymentDetails.Enabled = false;
                        MessageBox.Show("Payment successful...", "Success");
                    }

                    else
                    {
                        MessageBox.Show("Something went wrong...", "Error");
                    }
                }


            
        }


        public  void Clear()
        {
            textBox_amountPaid.Text = "";
            textBox_amountToBePaid.Text = "";
            textBox_coustomBalAdv.Text = "";
            textBox_otherTax.Text = "";
            textBox_serviceTax.Text = "";
            textBox_tuitionFee.Text = "";
            textBox_totalAmount.Text = "";
        }


        public void form_load()
        {
 //           String feeReceiptNo = db.tblFeesDetails.Where(y => y.StudentId == StudentId && y.isActive == 1).Max(y => y.FeeReceiptNo).ToString();
 //           var feeDetail = db.tblFeesDetails.Where(x => x.StudentId == StudentId && x.isActive == 1 && x.FeeReceiptNo.Equals(feeReceiptNo)).Single();

 //           textBox_balance.Text = String.Format("{0:#,##0.00}", feeDetail.Balance);
 //           textBox_advance.Text = String.Format("{0:#,##0.00}", feeDetail.Advance);

 //           var installment = db.tblFeeStructures.Where(x => x.StudentId == StudentId)
 //                                       .Select(x => new { x.StudentId, x.InstallmentNo, x.InstallmentAmount, x.InstallmentDate, x.PaidStatus, x.PaidDate }).OrderBy(x => x.InstallmentNo);
            // users.ToList();
//            dataGridView_paymentInstallment.DataSource = installment.ToList();
            //Hide the extra column.
            dataGridView_paymentInstallment.Columns["StudentId"].Visible = false;


 //           var paymentHistory = db.tblFeesDetails.Where(x => x.StudentId == StudentId).Select(x => new { x.FeeReceiptNo, x.AmountToBePaid, x.AmountPaid, x.PaidTimeStamp }).OrderBy(x => new { x.FeeReceiptNo, x.PaidTimeStamp });
 //           dataGridView_PaymentHistory.DataSource = paymentHistory.ToList();
        }

       

        //private void button_studentSearch_Click(object sender, EventArgs e)
        //{
        //    String firstName = textBox_firstName.Text.ToLower();
        //    String lastName = textBox_lastName.Text.ToLower();
        //    String courseName = comboBox_Course.SelectedValue == null ? "" : comboBox_Course.SelectedValue.ToString();

        //    //Search Result (List of usernames)
        //    dataGridView_searchStudent.DataSource = db.tblStudentDetails.Where(x => x.FirstName.Contains(firstName) && x.LastName.Contains(lastName) && x.isActive==1 && x.tblCourseMaster.CourseName.Contains(courseName)).OrderBy(x => x.FirstName).ToList();
        //    //hideUnnecessaryColumns(); 
        //}

       
    }
}
