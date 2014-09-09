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
    public partial class Home : Form
    {
        EmployeeBS b = new EmployeeBS();
                
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            loginGroupBox.ForeColor = Color.White;
        }
        

        //
        //Ong click on Login: Validates Employee ID, password,type and navigates to appropriate Home page
        //
        private void login_Click(object sender, EventArgs e)
        {
            Employee l = new Employee();
            l.employee_Id = userNameText.Text.ToString();
            l.password = passwordText.Text.ToString();

            if (adminRadioButton.Checked)
            {
                l.type = 1;
                string feed = b.validateLogin(l);
                if (feed.Equals("true"))
                {
                    AdminHome f = new AdminHome(l);
                    this.MdiParent.Hide();
                    this.Close();
                    f.Show();
                }
                else
                {
                    MessageBox.Show(feed,"Login Error");
                }
            }
            else if (employeeRadioButton.Checked)
            {
                l.type = 2;
                string feed = b.validateLogin(l);
                if (feed.Equals("true"))
                {
                    ParentForm f2 = new ParentForm(l);
                    this.MdiParent.Hide();
                    this.Close();
                    f2.Show();
                }
                else
                {
                    MessageBox.Show(feed, "Login Error");
                }
            }
        }


        //
        //Pops of a dialog box, confirming choice to exit, and then closes the application
        //
        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Are you sure you want to Exit?", "Exit", MessageBoxButtons.YesNo);
            if (r.Equals(DialogResult.Yes))
            {
                Application.Exit();
            }
        }


        //
        //Naviagtes to Register Home 
        //
        private void register_Click(object sender, EventArgs e)
        {   
            AddEmployee f = new AddEmployee();
            f.MdiParent = this.MdiParent;
            f.Dock = DockStyle.Fill;
            this.Close(); 
            f.Show();
        }
    }
}
