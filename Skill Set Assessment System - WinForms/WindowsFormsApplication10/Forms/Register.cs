/*
 comments
 naming
 related DAL
 minimization
*/
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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }


        //
        //On click of Back button, navigates to Admin Home
        //
        private void back_Click(object sender, EventArgs e)
        {
            Home f = new Home();
            f.MdiParent = this.MdiParent;
            f.Dock = DockStyle.Fill;
            this.Close();
            f.Show();
        }


        //
        //On click of Add button, validates, adds Employee & displays assigned Employee ID
        //
        private void register_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.first_Name = firstNameText.Text.ToString();
            emp.last_Name = lastNameText.Text.ToString();
            emp.birthdate = birthdatePicker.Value;
            emp.hire_Date = hireDatePicker.Value;
            emp.address = addressText.Text.ToString();
            emp.city = cityText.Text.ToString();
            emp.region = regionText.Text;
            string temp = emp.birthdate + "";
            emp.password = temp.Substring(0, 10);
            if (postalCodeText.TextLength == 0)
                emp.postalCode = 9999999;
            else
                emp.postalCode = Convert.ToInt32(postalCodeText.Text);
            emp.country = countryText.Text.ToString();
            emp.mobile_Number = mobileText.Text.ToString();
            emp.password = passwordText.Text.ToString();
            string confirm = confirmPasswordText.Text.ToString();
            emp.type = 2;
            EmployeeBS cs = new EmployeeBS();
            string feedback = cs.addEmployee(emp,confirm);
            if (feedback.Contains("successfully"))
            {
                DialogResult result = MessageBox.Show(feedback + "   Click Ok to go to Home Page. Click Cancel to Logout", "Add Employee", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                //    EmpHome f = new EmpHome(emp);
                //    this.Close();
                //    f.Show();
                    ParentForm f = new ParentForm(emp);
                    this.Close();
                    f.Show();
                }
                else if (result == DialogResult.Cancel)
                {
                    Application.Exit();
                }
            }
            else
                MessageBox.Show(feedback,"Error",MessageBoxButtons.OK);
                
        }
    }
}
