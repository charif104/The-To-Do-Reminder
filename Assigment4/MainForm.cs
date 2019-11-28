using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assigment4
{
    public partial class 
        
         MainForm : Form
    {
        Task currTask;
        public MainForm()
        {
            InitializeComponent();
            InitilaizeGui();
        }

        #region Initialize Gui 
        private void InitilaizeGui()
        {
            this.Text = "To Do Reminder" + " Charif";

            currTask = new Task(DateTime.Now);

            cmbBoxPriority.Items.Clear();    
            cmbBoxPriority.Items.AddRange(Enum.GetNames(typeof(PriorityTypes)));
            cmbBoxPriority.SelectedIndex = (int)PriorityTypes.Normal;

            lstbox.Items.Clear();
            lblClock.Text = string.Empty;
            timer1.Start();
            txtToDo.Text = string.Empty;

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd    HH:mm";

            toolTip1.ShowAlways = true;

            menuFileNew.Enabled = true;
            menuFileSave.Enabled = true;
            menuFileOpen.Enabled = true;

            btnAdd.Enabled = false;
                 
        }
        #endregion

        #region Buttons 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ReadInput();
            lstbox.Items.Add(currTask.ToString());
            txtToDo.Text = string.Empty;
         
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            int index = lstbox.SelectedIndex;
            if (index >= 0)
            {
                ReadInput();
                lstbox.Items.RemoveAt(index);
                lstbox.Items.Insert(index, currTask.ToString());
            }
            else
                MessageBox.Show("Select an item from the listbox to edit");
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            int index = lstbox.SelectedIndex;
            if (index >= 0)
            {
                DialogResult dlg = MessageBox.Show("Sure to Delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dlg == DialogResult.Yes)
                {

                    lstbox.Items.RemoveAt(index);
                }
            }
            else
                MessageBox.Show("Select an item from the listbox to edit");
        }


        #endregion

        #region Help Metoder
        private void ReadInput()
        {
            currTask.Priority = (PriorityTypes)cmbBoxPriority.SelectedIndex;
            currTask.Description = txtToDo.Text;
        }
  
        #endregion


        #region Text and labels properties

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToLongTimeString();
        }

        private void txtToDo_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtToDo.Text)){
                btnAdd.Enabled = true;
            }
            
        }
        #endregion

        private void menuFileNew_Click(object sender, EventArgs e)
        {
            InitilaizeGui();
        }

        private void btnDelete_ControlAdded(object sender, ControlEventArgs e)
        {
           
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 dlgAbout = new AboutBox1();
            dlgAbout.ShowDialog();
        }

        public void SaveListBoxToFile()
        {

        }
    }

}
