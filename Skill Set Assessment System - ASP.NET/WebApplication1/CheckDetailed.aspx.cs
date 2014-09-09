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
    public partial class CheckDetailed : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ResultsBS r = new ResultsBS();
            int count = r.getConductedExamsCount();
            if (count > 0)
            {
                Results[] rs = new Results[count];
                rs = r.loadConductedExamID(rs);
                for (int j = 0; j < count; j++)
                {
                    examIDCombo.Items.Add(rs[j].exam_ID);
                }
            }
            else
                System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('No Exams present in the database.')</SCRIPT>");
        }

        //
        //On click of Back button, navigates to Admin Home
        //
        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AdminHome.aspx");
        }

        //
        //On click of Check: Navigates to Detaile Report Form
        //
        protected void check_Click(object sender, EventArgs e)
        {
            if (examIDCombo.SelectedIndex != -1)
            {
                Results r = new Results();
                r.exam_ID = examIDCombo.SelectedItem.ToString();
                Session["exam_ID"] = r;
                Response.Redirect("~/DetailedReport.aspx");
            }
            else
                System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('Please select a valid Exam ID.')</SCRIPT>");
                //MessageBox.Show("Please select a valid Exam ID.", "Error", MessageBoxButtons.OK);
        }
    }
}