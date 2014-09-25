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


namespace TutDB
{
    public partial class Form2 : Form
    {
        TutDBEntities db = CommonUtilities.getConnection();
        int cLeft = 1;
        String picLoc;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files(*.jpg)|*.jpg|GIF Files(*.gif)|*.gif|All Files(*.*)|*.*";
                dlg.Title = "Select Employee Picture.";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    picLoc = dlg.FileName.ToString();
                    //picBox.ImageLocation = picLoc;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            tblStudentDetail studentDetails = new tblStudentDetail();
            int lastInsertedStudentCode = db.tblStudentDetails.Count();
            studentDetails.StudentCode = 'S' + lastInsertedStudentCode + 1.ToString();
            //customerDetail.CustomerId = lastInsertedCustomerId + 1; //New Customer's id.

            

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
                        byte[] img = null;
                        FileStream fs = new FileStream(picLoc, FileMode.Open, FileAccess.Read);
                        BinaryReader br = new BinaryReader(fs);
                        img = br.ReadBytes((int)fs.Length);
                        studentDetails.Dpic = img;
                        db.tblStudentDetails.Add(studentDetails);

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
                MessageBox.Show("User added successfully.", "Success");
            }
            else
            {
                MessageBox.Show("Something went wrong.", "Error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddNewButton();
        }

        public System.Windows.Forms.Button AddNewButton()
        {
            System.Windows.Forms.Button txt = new System.Windows.Forms.Button();
            this.Controls.Add(txt);
            txt.Top = cLeft * 25;
            txt.Left = 100;
            txt.Text = "TextBox " + this.cLeft.ToString();
            cLeft = cLeft + 1;
            return txt;
        }

        private void picBox_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            ListView board = new ListView();
            board.Bounds = new Rectangle(new Point(0, 0), new Size(this.Width, this.Height));
            board.View = View.Details;
            board.LabelEdit = false;
            board.AllowColumnReorder = false;
            board.GridLines = true;

            int rows=  Int32.Parse(db.tblBasicMasters.Where(x => x.Description.Equals("Columns")).Single().Value);
            for (int col = 1; col <= rows; col++)
            {
                board.Columns.Add(col.ToString(), -10, HorizontalAlignment.Center);
            }
               

            ListViewItem minListRow = new ListViewItem("Hours", 0);
            int startHrs = Int32.Parse(db.tblBasicMasters.Where(x => x.Description.Equals("StartHrs")).Single().Value);
            int endHrs = Int32.Parse(db.tblBasicMasters.Where(x => x.Description.Equals("EndHrs")).Single().Value);
            int count = 0;
            for (int i = 0; i < rows; i++)
            {
                if (i < 3)
                {
                    minListRow.SubItems.Add("  ");
                }
                else
                {
                if (startHrs <= endHrs && count % 4 != 0)
                {
                    minListRow.SubItems.Add("");
                    
                    count++;
                }
                if (startHrs <= endHrs && count%4==0)
                {
                    minListRow.SubItems.Add(startHrs.ToString());
                    startHrs++;
                    count++;
                }
                    }
            }


            ListViewItem hrsListRow = new ListViewItem("Minutes", 0);
            int hrs = 0;
            for (int i = 0; i < rows; i++)
            {
                if (i < 3)
                {
                    hrsListRow.SubItems.Add("  ");
                }
                else
                {
                    if (hrs == 0)
                        hrsListRow.SubItems.Add("00");
                    if (hrs == 15)
                        hrsListRow.SubItems.Add("15");
                    if (hrs == 30)
                        hrsListRow.SubItems.Add("30");
                    if (hrs == 45)
                        hrsListRow.SubItems.Add("45");

                    hrs += 15;
                    if (hrs >= 60)
                    {
                        hrs = 0;
                    }
                }

            }


            ListViewItem item3 = new ListViewItem("Wednesday", 0);
            for (int i = 0; i < 11; i++)
            {
                item3.SubItems.Add("      c      ");
            }

            ListViewItem item4 = new ListViewItem("Thursday", 0);
            for (int i = 0; i < 11; i++)
            {
                item4.SubItems.Add("    d        ");
            }

            ListViewItem item5 = new ListViewItem("Friday", 0);
            for (int i = 0; i < 11; i++)
            {
                item5.SubItems.Add("    e        ");
            }

            board.Items.Add(minListRow);
            board.Items.Add(hrsListRow);
            board.Items.Add(item3);
            board.Items.Add(item4);
            board.Items.Add(item5);

            this.Controls.Add(board);

        }


        //public static void MergeRows(ListView listView)
        //{
        //    for (int colIndex = 3; colIndex <= listView.Columns.Count; colIndex++ )
        //    {
                
                  
                
        //    }
        //}

    }
}
