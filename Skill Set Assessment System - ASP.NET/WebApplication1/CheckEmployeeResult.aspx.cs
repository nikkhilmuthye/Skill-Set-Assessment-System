using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entities2;
using Business1;
using System.Collections;
using System.Data;

namespace WebApplication1
{
    public partial class CheckEmployeeResult : System.Web.UI.Page
    {
        Results ed = new Results();
        ResultsBS p = new ResultsBS();

        protected void Page_Load(object sender, EventArgs e)
        {
            ed.employee_ID = (String)Session["employee_ID"];
            employeeIDText.Text = ed.employee_ID;
            int count = p.getResultCountForEmployee(ed);

            DataTable dt = new DataTable();
            dt.Columns.Add("Employee_ID", Type.GetType("System.String"));
            dt.Columns.Add("Exam_ID", Type.GetType("System.String"));
            dt.Columns.Add("Score", Type.GetType("System.Int32"));
            dt.Columns.Add("Percentage", Type.GetType("System.Double")); 

            if (count > 0)
            {
                Results[] arr = new Results[count];
                arr = p.viewResultForEmployee(ed, count);
                for (int i = 0; i < count; i++)
                {
                    dt.Rows.Add();
                    dt.Rows[dt.Rows.Count - 1]["Employee_ID"] = arr[i].employee_ID;
                    dt.Rows[dt.Rows.Count - 1]["Exam_ID"] = arr[i].exam_ID;
                    dt.Rows[dt.Rows.Count - 1]["Score"] = arr[i].score;
                    dt.Rows[dt.Rows.Count - 1]["Percentage"] = arr[i].percentage;
                }
                GridView1.DataSource = dt;
                GridView1.Enabled = false;
                GridView1.DataBind();
            }
            else
                System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('No Results present in the database.')</SCRIPT>");
                //MessageBox.Show("No Results present in the database.", "Error");
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