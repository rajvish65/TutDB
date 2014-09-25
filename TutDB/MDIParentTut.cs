using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TutDB
{
    public partial class MDIParentTut : Form
    {
        TutDBEntities db = CommonUtilities.getConnection();
        private int childFormNumber = 0;

        public MDIParentTut()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void PopulateTreeViewControl()
        {
            //var locationList = db.tblLocationMasters.OrderBy(x => x.LocationName).Select(y => new { y.LocationId, y.LocationName }).ToList();

            TreeNode parentNode = null;
            //parentNode.Nodes.Clear();
            List<String> parentList = new List<string>();
            parentList.Add("Dashboard");
            parentList.Add("Student");
            parentList.Add("Employee");
            parentList.Add("Fees");
            parentList.Add("Session");
            parentList.Add("Attendance");
            parentList.Add("Masters");


            foreach (var parent in parentList)
            {
                parentNode = new TreeNode();

                parentNode.Text =parent;
                parentNode.Expand();
                //parentNode.ToolTipText = "Select Location";

                treeView1.Nodes.Add(parentNode);
                FillChild(parentNode);
            }
        }
        public void FillChild(TreeNode parent)
        {
            List<String> child = new List<string>();
            if (parent.Text.ToString().Equals("Student"))
            {
                child.Add("View Student");
                child.Add("Add Student");
            }
            if (parent.Text.ToString().Equals("Employee"))
            {
                child.Add("View Employee");
                child.Add("Add Employee");
            }
            if (parent.Text.ToString().Equals("Fees"))
            {

            }
            if (parent.Text.ToString().Equals("Sessions"))
            {

            }
            if (parent.Text.ToString().Equals("Attendance"))
            {

            }
            if (parent.Text.ToString().Equals("Masters"))
            {

            }

            parent.Nodes.Clear();

            foreach (var dr in child)
            {
                TreeNode childNode = new TreeNode();
                childNode.Text = dr;

                if (childNode.Nodes.Count == 0)
                {
                    //child. = true;
                }
                childNode.Collapse();
                //childNode.ToolTipText = "Select Room";
                parent.Nodes.Add(childNode);
            }
        }

        private void MDIParentTut_Load(object sender, EventArgs e)
        {
            Rectangle screen = Screen.PrimaryScreen.WorkingArea;
            int w = Width >= screen.Width ? screen.Width : (screen.Width + Width) / 2;
            int h = Height >= screen.Height ? screen.Height : (screen.Height + Height) / 2;
            this.Location = new Point((screen.Width - w) / 2, (screen.Height - h) / 2);
            this.Size = new Size(w, h);
            //this.WindowState = FormWindowState.Maximized;
            PopulateTreeViewControl();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Text.Equals("Add Student"))
            {
                StudentRegistration stdreg = new StudentRegistration();
                stdreg.TopLevel = false;
                stdreg.AutoScroll = true;
                stdreg.FormBorderStyle = FormBorderStyle.None;
                panel_window.Controls.Clear();
                panel_window.Controls.Add(stdreg);
                stdreg.Show();
            }

            if (treeView1.SelectedNode.Text.Equals("Add Employee"))
            {
                EmployeeRegistration empreg = new EmployeeRegistration();
                empreg.TopLevel = false;
                empreg.AutoScroll = true;
                empreg.FormBorderStyle = FormBorderStyle.None;
                panel_window.Controls.Clear();
                panel_window.Controls.Add(empreg);
                empreg.Show();
            }

        }

    }
}
