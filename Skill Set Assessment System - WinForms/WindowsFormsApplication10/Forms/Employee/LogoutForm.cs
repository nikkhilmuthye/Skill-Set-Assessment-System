using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business1;
using Entities2;

namespace WindowsFormsApplication10
{
    public partial class LogoutForm : Form
    {
        public Employee emp = new Employee();
        public Exam_Details ed = new Exam_Details();

        public LogoutForm(Employee e, Exam_Details exd)
        {
            InitializeComponent();
            emp = e;
            ed = exd;
        }


        //
        //On click of Logout button: Exits application
        //
        private void logout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //
        //On form Load: Displays employee name and exam ID
        //
        private void LogoutForm_Load(object sender, EventArgs e)
        {
            employeeNameLabel.Text = emp.first_Name + " " + emp.last_Name;
            examIDLabel.Text += ed.exam_ID;
        }
    }
}
