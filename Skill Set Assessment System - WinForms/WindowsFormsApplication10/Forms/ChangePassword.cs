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
    public partial class ChangePassword : Form
    {
        Employee emp;


        //
        //Accepts passed Employee entity 
        //
        public ChangePassword(Employee e)
        {
            InitializeComponent();
            emp = e;
        }


        //
        //On click og Change button: validates the old password, verifies new password and changes the password
        //
        private void change_Click(object sender, EventArgs e)
        {
            String oldpassword = initialText.Text.ToString();
            String newpassword = newText.Text.ToString();
            String verifypassword = verifyText.Text.ToString();
            EmployeeBS eb=new EmployeeBS();
            string feed = eb.validatePassword(oldpassword, newpassword, verifypassword, emp);
            MessageBox.Show(feed,"Change Password");
        }


        //
        //Navigates to Admin home or Employee home as per the emp type
        //
        private void back_Click(object sender, EventArgs e)
        {
            if (emp.type == 2)
            {
                EmpHome fm4 = new EmpHome(emp);
                fm4.MdiParent = this.MdiParent;
                fm4.Dock = DockStyle.Fill;
                this.Close();
                fm4.Show();
            }
            else
                this.Close();
        }
    }
}
