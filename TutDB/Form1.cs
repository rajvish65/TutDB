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
    public partial class Form1 : Form
    {
      

        private DataGridView dataGridView1 = new DataGridView();


        public Form1()
        {
            this.AutoSize = true;
            this.Load += new EventHandler(Form1_Load);
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            DataGridViewCheckBoxColumn column0 =new DataGridViewCheckBoxColumn();
            DataGridViewDisableButtonColumn column1 =new DataGridViewDisableButtonColumn();
            column0.Name = "CheckBoxes";
            column1.Name = "Buttons";
            dataGridView1.Columns.Add(column0);
            dataGridView1.Columns.Add(column1);
            dataGridView1.RowCount = 8;
            dataGridView1.AutoSize = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Set the text for each button.
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Cells["Buttons"].Value = "Button " + i.ToString();
            }

            dataGridView1.CellValueChanged += new DataGridViewCellEventHandler(dataGridView1_CellValueChanged);
            dataGridView1.CurrentCellDirtyStateChanged += new EventHandler(dataGridView1_CurrentCellDirtyStateChanged);
            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);

            this.Controls.Add(dataGridView1);
        }

        // This event handler manually raises the CellValueChanged event
        // by calling the CommitEdit method.
        void dataGridView1_CurrentCellDirtyStateChanged(object sender,
            EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        // If a check box cell is clicked, this event handler disables  
        // or enables the button in the same row as the clicked cell.
        public void dataGridView1_CellValueChanged(object sender,
            DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "CheckBoxes")
            {
                DataGridViewDisableButtonCell buttonCell = (DataGridViewDisableButtonCell)dataGridView1.Rows[e.RowIndex].Cells["Buttons"];

                DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)dataGridView1.Rows[e.RowIndex].Cells["CheckBoxes"];
                buttonCell.Enabled = !(Boolean)checkCell.Value;

                dataGridView1.Invalidate();
            }
        }

        // If the user clicks on an enabled button cell, this event handler  
        // reports that the button is enabled.
        void dataGridView1_CellClick(object sender,
            DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Buttons")
            {
                DataGridViewDisableButtonCell buttonCell = (DataGridViewDisableButtonCell)dataGridView1.Rows[e.RowIndex].Cells["Buttons"];

                if (buttonCell.Enabled)
                {
                    MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() + " is enabled");
                }
            }
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
