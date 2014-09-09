using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entities2;
using Business1;

namespace WindowsFormsApplication10
{
    public partial class Tutorial : Form
    {
        public Employee emp = new Employee();
        public Exam_Details ed = new Exam_Details();
        
        
        public Tutorial(Employee e1, Exam_Details e2)
        {
            InitializeComponent();
            emp = e1;
            ed = e2;
        }

        private void Tutorial_Load(object sender, EventArgs e)
        {
            nameLabel.Text = emp.first_Name + " " + emp.last_Name;
            examIDLabel.Text += ed.exam_ID; 
        }

        private void proceed_Click(object sender, EventArgs e)
        {
            Tutorial2 fm4 = new Tutorial2(emp, ed);
            fm4.MdiParent = this.MdiParent;
            fm4.Dock = DockStyle.Fill;
            this.Close();
            fm4.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            EmpHome m = new EmpHome(emp);
            m.MdiParent = this.MdiParent;
            m.Dock = DockStyle.Fill;
            this.Close();
            m.Show();
        }

        private void tutorialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void tutorialLabel_Click(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void examIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void tutorialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void tutorialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void tutorialLabel4_Click(object sender, EventArgs e)
        {

        }
    }
}
