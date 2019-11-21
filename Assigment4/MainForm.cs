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
    public partial class MainForm : Form
    {
        Task currTask;
        public MainForm()
        {
            InitializeComponent();
            InitilaizeGui();
        }

        private void InitilaizeGui()
        {
            this.Text = "To Do Reminder" + " Charif";
            currTask = new Task(DateTime.Now);

            cmbBoxPriority.Items.Clear();

           
            cmbBoxPriority.Items.AddRange(Enum.GetNames(typeof(PriorityTypes)));
           cmbBoxPriority.SelectedIndex = (int)PriorityTypes.Normal;

            lstbox.Items.Clear();
            lblClock.Text = String.Empty;
            timer1.Start();

            txtToDo.Text = String.Empty;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd    HH:mm";

            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ReadInput();
            lstbox.Items.Add(currTask.ToString());

        }

        private void ReadInput()
        {
            currTask.Priority = (PriorityTypes)cmbBoxPriority.SelectedIndex;
        }
    }
}
