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
    public partial class FeeStructure : Form
    {
        TutDBEntities db = CommonUtilities.getConnection();

        static Int32 StudentId;
        static bool hasComeFromSearchDetail = false;
        static bool installmentPrepared = false;
        int remainingAmount = 0;
        int maxInstallmentNo = 0;
        int feeAmount = 0;
        int buttonEnbaledCount = 1;

        

        public FeeStructure()
        {
            InitializeComponent();
        }

        internal static void setStudentId(int selectedStudentId)
        {
            StudentId = selectedStudentId;
        }

        internal static void setHasComeFromSearch(bool hasCome)
        {
            hasComeFromSearchDetail = hasCome;
        }


        public void Clear()
        {
            txtInstallmentNo.Text = "";
            txtInstallmentAmount.Text = "";
            dateTimePicker_installmentDate.Value = DateTime.Today;
        }


        

        private void FeeStructure_Load(object sender, EventArgs e)
        {
            ////Query for retrieving users from the DB
            //var fees = db.tblFeeStructures.Where(x => x.StudentId == StudentId)
            //                            .Select(x => new { x.StudentId, x.InstallmentNo, x.InstallmentAmount, x.InstallmentDate, x.PaidStatus, x.PaidDate }).OrderBy(x => x.InstallmentNo);

            //dataGridView_feeStructure.DataSource = fees.ToList();

            ////Hide the extra column.
            //dataGridView_feeStructure.Columns["StudentId"].Visible = false;
            ////----------------------------
            //DataGridViewDisableButtonColumn columnPaymnet = new DataGridViewDisableButtonColumn();
            //columnPaymnet.Name = "Payment";
            //dataGridView_feeStructure.Columns.Add(columnPaymnet);
            //dataGridView_feeStructure.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //// Set the text for each button.
            //for (int i = 0; i < dataGridView_feeStructure.RowCount; i++)
            //{
            //    dataGridView_feeStructure.Rows[i].Cells["Payment"].Value = "Pay Now";
            //}

            //dataGridView_feeStructure.CellClick += new DataGridViewCellEventHandler(dataGridView_feeStructure_CellClick);

            //DataGridViewCheckBoxColumn chkInstallment = new DataGridViewCheckBoxColumn();
            //chkInstallment.HeaderText = "";
            //chkInstallment.Name = "check";
            //chkInstallment.FalseValue = "0";
            //chkInstallment.TrueValue = "1";
            //chkInstallment.Width = 40;
            //dataGridView_feeStructure.Columns.Insert(0, chkInstallment);

            //Int32 rowIndex = dataGridView_feeStructure.Rows.Count;
            //Int32 colIndex = dataGridView_feeStructure.Columns.Count;

            //if (dataGridView_feeStructure.RowCount > 0)
            //{
            //    foreach (DataGridViewRow row in dataGridView_feeStructure.Rows)
            //    {
            //        if (row.Index != rowIndex)
            //        {
            //            DataGridViewDisableButtonCell buttonCell = (DataGridViewDisableButtonCell)row.Cells["Payment"];
                        
            //            if (row.Cells["PaidStatus"].Value == null || row.Cells["PaidStatus"].Value == DBNull.Value)
            //            {
            //                if (row.Index != rowIndex - 1)
            //                {
            //                    row.Cells["check"].ReadOnly = true;
            //                }
            //                if (buttonEnbaledCount != 1)
            //                {
            //                    buttonCell.Enabled = false;
            //                }
            //                else
            //                {
            //                    buttonCell.Enabled = true;
            //                    buttonEnbaledCount += 1;
            //                }
            //            }
            //            else
            //            {
            //                buttonCell.Enabled = false;
            //                row.Cells["check"].ReadOnly = true;
            //            }
            //            dataGridView_feeStructure.Invalidate();
            //        }
            //    }
            //    //re-initialized
            //    buttonEnbaledCount = 1;
            //}
           

            ////Registering an event handler when a particular row is clicked.
            ////dataGridView_student.CellClick -= displayDetailsUser;
            ////dataGridView_student.CellClick += displayDetailsUser;
            ////String feesAmount = db.tblStudentDetails.Where(x => x.StudentId == StudentId).Single().tblCourseMaster.tblFeesMasters.Single().Amount.ToString();
            ////lblFeesAmount.Text= feesAmount.Substring(0, feesAmount.Length - 2);

            //feeAmount = Convert.ToInt32(db.tblStudentDetails.Where(x => x.StudentId == StudentId).Single().tblCourseMaster.tblFeesMasters.Single().Amount);
            //maxInstallmentNo = Convert.ToInt32(db.tblFeeStructures.Where(x => x.StudentId == StudentId).Max(x => x.InstallmentNo));

            //if (maxInstallmentNo != 0)
            //{
            //    remainingAmount = (int)(Decimal.Parse(db.tblFeeStructures.Where(x => x.StudentId == StudentId && x.InstallmentNo == maxInstallmentNo).First().AmountRemaining.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture));
            //}


            ////remainingAmount =Convert.ToInt32(db.tblFeeStructures.Where(x => x.StudentId == StudentId && x.InstallmentNo == Convert.ToInt32(db.tblFeeStructures.Where(z => z.StudentId == StudentId).Max(y => y.InstallmentNo))).Single().AmountRemaining);
            //if (remainingAmount == 0 && maxInstallmentNo!=0)
            //{
            //    installmentPrepared = true;
            //    installmentPrep(installmentPrepared);
            //}

            //lblFeesAmount.Enabled = false;
            //lblFeeAmountRemaining.Enabled = false;
            //label_InstallmentAmount.Enabled = false;
            //label_InstallmentNo.Enabled = false;
            //label_LastDate.Enabled = false;
            //label_remaningFees.Enabled = false;
            //label_totalFees.Enabled = false;
            //txtInstallmentAmount.Enabled = false;
            //txtInstallmentNo.Enabled = false;
            //dateTimePicker_installmentDate.Enabled = false;
            //linkLabel_feeStructCancel.Enabled = false;
            //linkLabel_feeStructEdit.Enabled = false;

            //if (installmentPrepared == true)
            //    linkLabel_feeStructNew.Enabled = false;

            //else
            //    linkLabel_feeStructNew.Enabled = true;
            ////linkLabel_feeStructNew.Enabled = true;
            //linkLabel_feeStructUpdate.Enabled = false;
            //linkLabel_feeStructAdd.Enabled = false;
        }


    
        // If the user clicks on an enabled button cell, this event handler  
        // reports that the button is enabled.
        void dataGridView_feeStructure_CellClick(object sender,DataGridViewCellEventArgs e)
        {
             if(e.RowIndex < 0 || e.RowIndex >= dataGridView_feeStructure.Rows.Count || e.ColumnIndex < 0 || e.ColumnIndex >= dataGridView_feeStructure.Columns.Count) 
                 return;

             if (dataGridView_feeStructure.Columns[e.ColumnIndex].Name == "Payment")
             {
                DataGridViewDisableButtonCell paymentCell = (DataGridViewDisableButtonCell)dataGridView_feeStructure.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (paymentCell.Enabled == true)
                {
                    DataGridViewTextBoxCell installmentCell = (DataGridViewTextBoxCell)dataGridView_feeStructure.Rows[paymentCell.RowIndex].Cells[2];

                    int installmentNo = Convert.ToInt32(((System.Windows.Forms.DataGridView)(sender)).Rows[installmentCell.RowIndex].Cells[installmentCell.ColumnIndex].Value.ToString());


                    FeePayment.setStudentId(StudentId);
                    FeePayment.setHasComeFromInstallmentToPayment(true);
                    FeePayment.setInstallmentId(installmentNo);

                    //If this user has been deleted in another window, display error message.
                    tblStudentDetail selectedStudent = db.tblStudentDetails.Where(x => x.StudentId == StudentId && x.isActive == 1).FirstOrDefault();
                    if (selectedStudent == null)
                    {
                        MessageBox.Show("Student not found. He/She may have been deleted.", "Error");
                        return;
                    }

                    //Invoke the UserDetails form.
                    FeePayment feePayment = new FeePayment();
                    feePayment.Show();
                }
                       
            }
        }
        //public void form_loadAfterDelete()
        //{
        //    var fees = db.tblFeeStructures.Where(x => x.StudentId == StudentId)
        //                                .Select(x => new { x.StudentId, x.InstallmentNo, x.InstallmentAmount, x.InstallmentDate, x.PaidStatus, x.PaidDate }).OrderBy(x => x.InstallmentNo);
        //    // users.ToList();
        //    dataGridView_feeStructure.DataSource = fees.ToList();

        //    //Hide the extra column.
        //    dataGridView_feeStructure.Columns["StudentId"].Visible = false;

        //    Int32 index = dataGridView_feeStructure.Rows.Count;

        //    foreach (DataGridViewRow row in dataGridView_feeStructure.Rows)
        //    {
        //        if (row.Index != index - 1)
        //        {
        //            row.Cells["check"].ReadOnly = true;
        //        }
        //    }
        //    lblFeesAmount.Enabled = false;
        //    lblFeeAmountRemaining.Enabled = false;
        //    label_InstallmentAmount.Enabled = false;
        //    label_InstallmentNo.Enabled = false;
        //    label_LastDate.Enabled = false;
        //    label_remaningFees.Enabled = false;
        //    label_totalFees.Enabled = false;
        //    txtInstallmentAmount.Enabled = false;
        //    txtInstallmentNo.Enabled = false;
        //    txtInstallmentNo.ReadOnly = false;
        //    dateTimePicker_installmentDate.Enabled = false;
        //    linkLabel_feeStructCancel.Enabled = false;
        //    linkLabel_feeStructEdit.Enabled = false;
        //    linkLabel_feeStructNew.Enabled = true;
        //    linkLabel_feeStructUpdate.Enabled = false;
        //    linkLabel_feeStructAdd.Enabled = false;
        //}

        public void form_load()
        {
            ////bool hasComeFromDelete = false;
            //var fees = db.tblFeeStructures.Where(x => x.StudentId == StudentId)
            //                            .Select(x => new { x.StudentId, x.InstallmentNo, x.InstallmentAmount, x.InstallmentDate, x.PaidStatus, x.PaidDate }).OrderBy(x => x.InstallmentNo);
            //// users.ToList();
            //dataGridView_feeStructure.DataSource = fees.ToList();

            ////Hide the extra column.
            //dataGridView_feeStructure.Columns["StudentId"].Visible = false;
            //////----------------------------
            ////DataGridViewDisableButtonColumn columnPaymnet = new DataGridViewDisableButtonColumn();
            ////columnPaymnet.Name = "Payment";
            ////dataGridView_feeStructure.Columns.Add(columnPaymnet);
            ////dataGridView_feeStructure.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //// Set the text for each button.
            //for (int i = 0; i < dataGridView_feeStructure.RowCount; i++)
            //{
            //    dataGridView_feeStructure.Rows[i].Cells["Payment"].Value = "Pay Now";
            //}

            //Int32 rowIndex = dataGridView_feeStructure.Rows.Count;

            //if (dataGridView_feeStructure.RowCount > 0)
            //{
            //    foreach (DataGridViewRow row in dataGridView_feeStructure.Rows)
            //    {
            //        if (row.Index != rowIndex)
            //        {
            //            DataGridViewDisableButtonCell buttonCell = (DataGridViewDisableButtonCell)row.Cells["Payment"];

            //            if (row.Cells["PaidStatus"].Value == null || row.Cells["PaidStatus"].Value == DBNull.Value)
            //            {
            //                if (row.Index != rowIndex - 1)
            //                {
            //                    row.Cells["check"].ReadOnly = true;
            //                }
            //                if (buttonEnbaledCount != 1)
            //                {
            //                    buttonCell.Enabled = false;
            //                }
            //                else
            //                {
            //                    buttonCell.Enabled = true;
            //                    buttonEnbaledCount += 1;
            //                }
            //            }
            //            else
            //            {
            //                buttonCell.Enabled = false;
            //                row.Cells["check"].ReadOnly = true;
            //            }
            //            dataGridView_feeStructure.Invalidate();
            //        }
            //    }
            //    //re-initialized
            //    buttonEnbaledCount = 1;
            //}

            ////int feesAmount = 0;
            ////int amountRemaining = 0;
            ////int installmentNo = 0;
            
            //lblFeesAmount.Text = feeAmount.ToString() + ".00";

            //maxInstallmentNo = Convert.ToInt32(db.tblFeeStructures.Where(x => x.StudentId == StudentId).Max(x => x.InstallmentNo));

            //if (maxInstallmentNo != 0)
            //{
            //    remainingAmount = (int)(Decimal.Parse(db.tblFeeStructures.Where(x => x.StudentId == StudentId && x.InstallmentNo == maxInstallmentNo).First().AmountRemaining.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture));
            //    //remainingAmount = Int32.Parse(db.tblFeeStructures.Where(x => x.StudentId == StudentId && x.InstallmentNo == maxInstallmentNo).Select(x=>x.AmountRemaining).Single().ToString());
            //    //feesAmount - Convert.ToInt32(db.tblFeeStructures.Where(x => x.StudentId == StudentId).Sum(y => y.InstallmentAmount));  
            //}

            //if (maxInstallmentNo > 0 && remainingAmount != 0)
            //{
            //    lblFeeAmountRemaining.Text = remainingAmount.ToString() + ".00";
            //    txtInstallmentNo.Text = (maxInstallmentNo + 1).ToString();
            //    txtInstallmentNo.ReadOnly = true;
            //    installmentPrepared = false;
            //    installmentPrep(installmentPrepared);
            //}
            //if (maxInstallmentNo != 0 && remainingAmount == 0 )
            //{
            //    //txtInstallmentAmount.ReadOnly = true;
            //    txtInstallmentNo.ReadOnly = true;
            //    txtInstallmentAmount.Enabled = true;
            //    txtInstallmentNo.Enabled = true;
            //    dateTimePicker_installmentDate.Enabled = false;
            //    label_InstallmentNotification.Enabled = true;
            //    installmentPrepared = true;
            //    installmentPrep(installmentPrepared);
            //    //MessageBox.Show("Installment is already prepared..");
            //}
            //if (maxInstallmentNo == 0)
            //{
            //    lblFeeAmountRemaining.Text = feeAmount.ToString();
            //    txtInstallmentNo.Text = (maxInstallmentNo + 1).ToString();
            //    txtInstallmentNo.ReadOnly = true;
            //    //installmentPrepared = true;
            //    //installmentPrep(installmentPrepared);
            //}
            //if (installmentPrepared == true)
            //{
            //    linkLabel_feeStructNew.Enabled = false;
            //}
            //else
            //    linkLabel_feeStructNew.Enabled = true;

            
        }

        public void installmentPrep(bool installment)
        {
            if (installment == true)
            {
                label_InstallmentNotification.Text = "Installment Prepared!!";
            }
            else
            {
                label_InstallmentNotification.Text = "";
            }
        }

        private void linkLabel_feeStructNew_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            form_load();
            lblFeesAmount.Enabled = true;
            lblFeeAmountRemaining.Enabled = true;
            label_InstallmentAmount.Enabled = true;
            label_InstallmentNo.Enabled = true;
            label_LastDate.Enabled = true;
            label_remaningFees.Enabled = true;
            label_totalFees.Enabled = true;
            txtInstallmentAmount.Enabled = true;
            txtInstallmentNo.Enabled = true;
            txtInstallmentNo.ReadOnly = true;
            dateTimePicker_installmentDate.Enabled = true;
            linkLabel_feeStructCancel.Enabled = true;
            linkLabel_feeStructEdit.Enabled = false;
            linkLabel_feeStructNew.Enabled = false;
            linkLabel_feeStructUpdate.Enabled = false;
            linkLabel_feeStructAdd.Enabled = true;

            //String feesAmount = db.tblStudentDetails.Where(x => x.StudentId == StudentId).Single().tblCourseMaster.tblFeesMasters.Single().Amount.ToString();
            //lblFeesAmount.Text = feesAmount.Substring(0, feesAmount.Length - 2);
           
        }

        private void linkLabel_feeStructAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //if (validateFeeStructure())
            //return; //Validation fails.

            ////Validation successful.


            //bool exceptionOccured = false;
            //try
            //{
            //    bool success = false;


            //    using (TransactionScope transaction = new TransactionScope())
            //    {
            //        try
            //        {
            //            tblFeeStructure feeStructure = new tblFeeStructure();

            //            int installmentNo = 0;
            //            Int32.TryParse(txtInstallmentNo.Text.Trim(), out installmentNo);
            //            feeStructure.InstallmentNo = installmentNo;

            //            int installmentAmount = 0;
            //            Int32.TryParse(txtInstallmentAmount.Text.Trim(), out installmentAmount);
            //            feeStructure.InstallmentAmount = installmentAmount;

            //            feeStructure.StudentId = StudentId;
            //            feeStructure.InstallmentDate = Convert.ToDateTime(dateTimePicker_installmentDate.Value.Date.ToString("yyyy-MMM-dd"));
            //            //dateTimePicker_installmentDate.Value;
            //            feeStructure.CreatedDate = DateTime.Today;
            //            if (installmentNo != 0)
            //            {
            //                if (installmentNo == 1)
            //                {
            //                    feeStructure.AmountRemaining = Convert.ToInt32(db.tblStudentDetails.Where(x => x.StudentId == StudentId).Single().tblCourseMaster.tblFeesMasters.Single().Amount) - installmentAmount;
            //                }
            //                else if (installmentNo > 1)
            //                {
            //                    //int maxInstallmentNo = Convert.ToInt32(db.tblFeeStructures.Where(x => x.StudentId == StudentId).Max(y => y.InstallmentNo));
            //                    feeStructure.AmountRemaining = remainingAmount - installmentAmount;
            //                }
            //            }
            //            db.tblFeeStructures.Add(feeStructure);
            //            db.SaveChanges();


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
            //    Clear();
            //    form_load();
            //    lblFeesAmount.Enabled = false;
            //    lblFeeAmountRemaining.Enabled = false;
            //    label_InstallmentAmount.Enabled = false;
            //    label_InstallmentNo.Enabled = false;
            //    label_LastDate.Enabled = false;
            //    label_remaningFees.Enabled = false;
            //    label_totalFees.Enabled = false;
            //    txtInstallmentAmount.Enabled = false;
            //    txtInstallmentNo.Enabled = false;
            //    dateTimePicker_installmentDate.Enabled = false;
            //    linkLabel_feeStructCancel.Enabled = false;
            //    linkLabel_feeStructEdit.Enabled = false;
            //    //linkLabel_feeStructNew.Enabled = false;
            //    linkLabel_feeStructUpdate.Enabled = false;
            //    linkLabel_feeStructAdd.Enabled = false;
            //    MessageBox.Show("Installment added successfully.", "Success");
            //}

            //else
            //{
            //    MessageBox.Show("Something went wrong.", "Error");
            //}


        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            List<Int32> installmentNumbers = new List<Int32>();

            foreach (DataGridViewRow row in dataGridView_feeStructure.Rows)
            {
                int output = 0;

                if (null != row.Cells["check"].Value)
                {
                    if (Int32.TryParse(row.Cells["check"].Value.ToString(), out output))
                    {
                        if (output == 1)
                            installmentNumbers.Add(Int32.Parse(row.Cells["InstallmentNo"].Value.ToString()));
                    }
                }
            }
            installmentNumbers.Count();

            foreach (var item in installmentNumbers)
            {
                bool exceptionOccured = false;
                try
                {
                    bool success = false;


                    using (TransactionScope transaction = new TransactionScope())
                    {
                        try
                        {
                            //var result = db.tblFeeStructures.Where(x => x.StudentId == StudentId && x.InstallmentNo == item).Single();
                            //db.tblFeeStructures.Remove(result);
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
                    lblFeesAmount.Enabled = false;
                    lblFeeAmountRemaining.Enabled = false;
                    label_InstallmentAmount.Enabled = false;
                    label_InstallmentNo.Enabled = false;
                    label_LastDate.Enabled = false;
                    label_remaningFees.Enabled = false;
                    label_totalFees.Enabled = false;
                    txtInstallmentAmount.Enabled = false;
                    txtInstallmentNo.Enabled = false;
                    dateTimePicker_installmentDate.Enabled = false;
                    linkLabel_feeStructCancel.Enabled = false;
                    linkLabel_feeStructEdit.Enabled = false;
                    //linkLabel_feeStructNew.Enabled = false;
                    linkLabel_feeStructUpdate.Enabled = false;
                    linkLabel_feeStructAdd.Enabled = false;
                    MessageBox.Show("Installment deleted successfully.", "Success");

                }

                else
                {
                    MessageBox.Show("Something went wrong.", "Error");
                }

            }
        }




        private bool validateFeeStructure()
        {
            bool errorOccurred = false;
            String errorMessage = "";

            if (txtInstallmentAmount.Text.Trim().Equals(""))
            {
                errorOccurred = true;
                errorMessage += "-> Please enter Amount \n";
            }

            //int a = Convert.ToInt32(txtInstallmentAmount.Text.ToString());
            //int b = Convert.ToInt32(lblFeeAmountRemaining.Text.ToString());

            int amount = 0;
          
            if (lblFeeAmountRemaining.Text.Contains("."))
            {
                amount = Int32.Parse(lblFeeAmountRemaining.Text.Substring(0, lblFeeAmountRemaining.Text.LastIndexOf(".") ));
            }

            if (Convert.ToInt32(txtInstallmentAmount.Text.ToString()) > amount )
            {
                errorOccurred = true;
                errorMessage += "->Amount should be less than Remaining Amount.. \n";
            }

            //if (db.tblFeeStructures.Where(x => x.StudentId == StudentId).ToList().Count() > 0)
            //{
            //    //int maxInstallmentNo=Convert.ToInt32(db.tblFeeStructures.Where(x => x.StudentId == StudentId).Max(y => y.InstallmentNo));
            //    DateTime installmentDate = db.tblFeeStructures.Where(x => x.StudentId == StudentId && x.InstallmentNo == maxInstallmentNo).Single().InstallmentDate.Value;

            //    if (Convert.ToDateTime(dateTimePicker_installmentDate.Value.Date) == installmentDate || Convert.ToDateTime(dateTimePicker_installmentDate.Value.Date) < installmentDate)
            //    {
            //        errorOccurred = true;
            //        errorMessage += "->Installment date should be ahead of previous installment date.. \n";
            //    }

            //    //int amountRemaining=Convert.ToInt32(db.tblFeeStructures.Where(x=>x.StudentId==StudentId && x.InstallmentNo==maxInstallmentNo).Single().AmountRemaining);
                
            //    //if (Convert.ToInt32(txtInstallmentAmount.Text) > amountRemaining)
            //    //{
            //    //    errorOccurred = true;
            //    //    errorMessage += "->Amount should be less than Remaining Amount.. \n";
            //    //}
                
            //}
            if (errorOccurred)
            {
                MessageBox.Show(errorMessage, "Error");
            }

            return errorOccurred;
        }

        

        private void linkLabel_feeStructCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clear();
            lblFeesAmount.Enabled = false;
            lblFeeAmountRemaining.Enabled = false;
            label_InstallmentAmount.Enabled = false;
            label_InstallmentNo.Enabled = false;
            label_LastDate.Enabled = false;
            label_remaningFees.Enabled = false;
            label_totalFees.Enabled = false;
            txtInstallmentAmount.Enabled = false;
            txtInstallmentNo.Enabled = false;
            txtInstallmentNo.ReadOnly = false;
            dateTimePicker_installmentDate.Enabled = false;
            linkLabel_feeStructCancel.Enabled = false;
            linkLabel_feeStructEdit.Enabled = false;
            linkLabel_feeStructNew.Enabled = true;
            linkLabel_feeStructUpdate.Enabled = false;
            linkLabel_feeStructAdd.Enabled = false;
        }

        private void button_QuickInstallment_Click(object sender, EventArgs e)
        {
            QuickInstallments.setStudentId(StudentId);
            QuickInstallments.setHasComeFromInstallment(true);

            //If this user has been deleted in another window, display error message.
            tblStudentDetail selectedStudent = db.tblStudentDetails.Where(x => x.StudentId == StudentId && x.isActive == 1).FirstOrDefault();
            if (selectedStudent == null)
            {
                MessageBox.Show("Student not found. He/She may have been deleted.", "Error");
                return;
            }

            //Invoke the UserDetails form.
            QuickInstallments quickInstallment = new QuickInstallments();
            quickInstallment.Show();
        }


        public class DataGridViewDisableButtonColumn : DataGridViewButtonColumn
        {
            public DataGridViewDisableButtonColumn()
            {
                this.CellTemplate = new DataGridViewDisableButtonCell();
            }
        }
    }
}
