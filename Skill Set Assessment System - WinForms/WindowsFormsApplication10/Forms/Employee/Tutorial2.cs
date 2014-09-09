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
    public partial class Tutorial2 : Form
    {
        public Employee emp = new Employee();
        public Exam_Details ed = new Exam_Details();

        public Tutorial2(Employee e1, Exam_Details e2)
        {
            InitializeComponent();
            emp = e1;
            ed = e2;
        }

        private void proceed_Click(object sender, EventArgs e)
        {
            Instructions fm4 = new Instructions(emp, ed);
            fm4.MdiParent = this.MdiParent;
            fm4.Dock = DockStyle.Fill;
            this.Close();
            fm4.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Tutorial m = new Tutorial(emp,ed);
            m.MdiParent = this.MdiParent;
            m.Dock = DockStyle.Fill;
            this.Close();
            m.Show();
        }

        private void Tutorial2_Load(object sender, EventArgs e)
        {
            nameLabel.Text = emp.first_Name + " " + emp.last_Name;
            examIDLabel.Text += ed.exam_ID; 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
