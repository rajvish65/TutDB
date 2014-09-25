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
    public partial class AddNewMaster : Form
    {
        TutDBEntities db = CommonUtilities.getConnection();

        public String clickedLinkName; 

        public AddNewMaster()
        {
            InitializeComponent();
        }

        private void button_addNew_Click(object sender, EventArgs e)
        {
            
            //If the linklabel which led us to this form was for adding a new value for the Area master table.
            if (clickedLinkName.Contains("paymentMethod"))
            {
                //Validation
                if (textBox_addNewMaster.Text.Length == 0)
                {
                    MessageBox.Show("Please enter a value.", "Error");
                    return;
                }
                int textValue;
                if (Int32.TryParse(textBox_addNewMaster.Text.Trim(), out textValue))
                {
                    MessageBox.Show("Please enter a valid value.", "Error");
                    return;
                }
                if (db.tblBasicMasters.Where(x => x.Description.Equals("PaymentMethod")).Select(x=>x.Value).Contains(textBox_addNewMaster.Text))
                {
                    MessageBox.Show("This value already exists.", "Error");
                    return;
                }

                tblBasicMaster basicMaster = new tblBasicMaster();
                basicMaster.Description = "PaymentMethod";
                basicMaster.Value = textBox_addNewMaster.Text.ToString();
                basicMaster.isActive = 1;
                basicMaster.CreatedDate = DateTime.Now;
                db.tblBasicMasters.Add(basicMaster);
            }
            //
            if (clickedLinkName.Contains("leaveReason"))
            {
                //Validation
                if (textBox_addNewMaster.Text.Length == 0)
                {
                    MessageBox.Show("Please enter a value.", "Error");
                    return;
                }
                int textValue;
                if (Int32.TryParse(textBox_addNewMaster.Text.Trim(), out textValue))
                {
                    MessageBox.Show("Please enter a valid value.", "Error");
                    return;
                }
                if (db.tblBasicMasters.Where(x => x.Description.Equals("LeaveReason")).Select(x => x.Value).Contains(textBox_addNewMaster.Text))
                {
                    MessageBox.Show("This value already exists.", "Error");
                    return;
                }

                tblBasicMaster basicMaster = new tblBasicMaster();
                basicMaster.Description = "LeaveReason";
                basicMaster.Value = textBox_addNewMaster.Text.ToString();
                basicMaster.isActive = 1;
                basicMaster.CreatedDate = DateTime.Now;
                db.tblBasicMasters.Add(basicMaster);
            }
            //
            if (clickedLinkName.Contains("designation"))
            {
                //Validation
                if (textBox_addNewMaster.Text.Length == 0)
                {
                    MessageBox.Show("Please enter a value.", "Error");
                    return;
                }
                int textValue;
                if (Int32.TryParse(textBox_addNewMaster.Text.Trim(), out textValue))
                {
                    MessageBox.Show("Please enter a valid value.", "Error");
                    return;
                }
                if (db.tblBasicMasters.Where(x => x.Description.Equals("Designation")).Select(x => x.Value).Contains(textBox_addNewMaster.Text))
                {
                    MessageBox.Show("This value already exists.", "Error");
                    return;
                }

                tblBasicMaster basicMaster = new tblBasicMaster();
                basicMaster.Description = "Designation";
                basicMaster.Value = textBox_addNewMaster.Text.ToString();
                basicMaster.isActive = 1;
                basicMaster.CreatedDate = DateTime.Now;
                db.tblBasicMasters.Add(basicMaster);
            }
            //
            if (clickedLinkName.Contains("status"))
            {
                //Validation
                if (textBox_addNewMaster.Text.Length == 0)
                {
                    MessageBox.Show("Please enter a value.", "Error");
                    return;
                }
                int textValue;
                if (Int32.TryParse(textBox_addNewMaster.Text.Trim(), out textValue))
                {
                    MessageBox.Show("Please enter a valid value.", "Error");
                    return;
                }
                if (db.tblBasicMasters.Where(x => x.Description.Equals("Status")).Select(x => x.Value).Contains(textBox_addNewMaster.Text))
                {
                    MessageBox.Show("This value already exists.", "Error");
                    return;
                }

                tblBasicMaster basicMaster = new tblBasicMaster();
                basicMaster.Description = "Status";
                basicMaster.Value = textBox_addNewMaster.Text.ToString();
                basicMaster.isActive = 1;
                basicMaster.CreatedDate = DateTime.Now;
                db.tblBasicMasters.Add(basicMaster);
            }

            db.SaveChanges();
            MessageBox.Show("Added Successfully.", "Success");
            this.Close(); //close the window.
        }

        private void AddNewMaster_Load(object sender, EventArgs e)
        {
            //Initialize the value of the label.
            if (clickedLinkName.Contains("paymentMethod"))
            {
                label_whichMaster.Text = "New Payment Method";
            }

            if (clickedLinkName.Contains("leaveReason"))
            {
                label_whichMaster.Text = "New Leave Reason";
            }

            if (clickedLinkName.Contains("designation"))
            {
                label_whichMaster.Text = "New Designation";
            }

            if (clickedLinkName.Contains("status"))
            {
                label_whichMaster.Text = "New Status";
            }
        }
    }
}
