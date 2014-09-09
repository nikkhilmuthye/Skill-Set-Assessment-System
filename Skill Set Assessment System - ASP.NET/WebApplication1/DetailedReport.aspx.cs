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
    public partial class DetailedReport : System.Web.UI.Page
    {
        Results r = new Results();
        ResultsBS p = new ResultsBS();
        DetailedReportsBS re = new DetailedReportsBS();

        protected void Page_Load(object sender, EventArgs e)
        {
            r = (Results)Session["exam_ID"];
            examIDTextBox.Text = r.exam_ID;
            int count = re.getResultCountForDetailedReport(r);

            DataTable dt = new DataTable();
            dt.Columns.Add("Employee_ID", Type.GetType("System.String"));
            dt.Columns.Add("Exam_ID", Type.GetType("System.String"));
            dt.Columns.Add("Section", Type.GetType("System.String"));
            dt.Columns.Add("Percentage", Type.GetType("System.Double"));

            if (count > 0)
            {
                DetailedReports[] arr = new DetailedReports[count];
                arr = re.getDetailedReports(r, count);
                for (int i = 0; i < count; i++)
                {
                    dt.Rows.Add();
                    dt.Rows[dt.Rows.Count - 1]["Employee_ID"] = arr[i].employee_ID;
                    dt.Rows[dt.Rows.Count - 1]["Exam_ID"] = arr[i].exam_ID;
                    dt.Rows[dt.Rows.Count - 1]["Section"] = arr[i].section;
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