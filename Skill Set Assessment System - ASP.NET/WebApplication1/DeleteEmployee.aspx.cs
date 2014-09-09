using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entities2;
using Business1;


namespace WebApplication1
{
    public partial class Delete_Employee : System.Web.UI.Page
    {
        EmployeeBS ed = new EmployeeBS();

        protected void Page_Load(object sender, EventArgs e)
        {
            employeeIDCombo.Items.Clear();
            int i = ed.getCount();
            if (i > 0)
            {
                string[] abc = new string[i];
                abc = ed.loadEmployee(i);
                for (int j = 0; j < i; j++)
                {
                    employeeIDCombo.Items.Add(abc[j]);
                }
                employeeIDCombo.SelectedIndex = 0;
            }
            else
                System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('No data')</SCRIPT>");
                //MessageBox.Show("No Data");
        }

        //
        //Navigates back to the Admin home
        //
        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AdminHome.aspx");
        }

        //  
        //Deletes the selected Exam & pops up a Success or Error message
        //
        protected void delete_Click(object sender, EventArgs e)
        {
            if (employeeIDCombo.SelectedIndex != -1)
            {
                //DialogResult result = MessageBox.Show("Are you sure you want delete " + employeeIDCombo.SelectedItem.ToString() + "?", "Delete Employee", MessageBoxButtons.YesNo);
                //if (result == DialogResult.Yes)
                
                    Employee r = new Employee();
                    string temp = employeeIDCombo.SelectedItem.ToString();
                    int pos = temp.IndexOf(":");
                    r.employee_Id = temp.Substring(0, pos - 1);
                    string feed = ed.deleteEmployee(r);
                    System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('Succesfully deleted.')</SCRIPT>");
                    //MessageBox.Show(feed);
            }
            else
                System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('Please select a valid Employee ID.')</SCRIPT>");
                //MessageBox.Show("Please select a valid Employee ID.");

            this.Page_Load(sender, e);
        }
    }
}