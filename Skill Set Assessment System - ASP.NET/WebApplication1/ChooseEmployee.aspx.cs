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
    public partial class ChooseEmployee : System.Web.UI.Page
    {
        ResultsBS r = new ResultsBS();
        EmployeeBS ed = new EmployeeBS();

        protected void Page_Load(object sender, EventArgs e)
        {
            int i = ed.getCount();
            if (i > 0)
            {
                string[] abc = new string[i];
                abc = ed.loadEmployee(i);
                for (int j = 0; j < i; j++)
                {
                    employeeIDCombo.Items.Add(abc[j]);
                }
            }
            else
                System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('No Employees present in the database')</SCRIPT>");
        }

        //
        //On click on Check button: Validates selection & Naviagtes to Check Employee Result Form
        //
        protected void check_Click(object sender, EventArgs e)
        {
            if (employeeIDCombo.SelectedIndex != -1)
            {
                string temp;
                Results ro = new Results();
                temp = employeeIDCombo.SelectedItem.ToString();
                ro.employee_ID = temp.Substring(0, 4);
                Session["employee_ID"] = ro.employee_ID;
                Response.Redirect("~/CheckEmployeeResult.aspx");
            }
            else
                System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('Please select a valid Employee ID.')</SCRIPT>");
        }

        //
        //On click of Back button, navigates to Admin Home
        //
        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AdminHome.aspx");
        }
    }
}