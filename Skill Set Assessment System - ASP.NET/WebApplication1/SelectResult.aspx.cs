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
    public partial class SelectResult : System.Web.UI.Page
    {
        ResultsBS r = new ResultsBS();

        protected void Page_Load(object sender, EventArgs e)
        {
            int count = r.getConductedExamsCount();
            if (count > 0)
            {
                Results[] rs = new Results[count];
                rs = r.loadConductedExamID(rs);
                for (int i = 0; i < count; i++)
                {
                    examIDCombo.Items.Add(rs[i].exam_ID);
                }
            }
            else
                System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('No Exams in the database')</SCRIPT>");
        
        }

        //
        //On click of Check button
        //
        protected void check_Click(object sender, EventArgs e)
        {
            if (examIDCombo.SelectedIndex != -1)
            {
                Results ro = new Results();
                ro.exam_ID = examIDCombo.SelectedItem.ToString();
                Session["exam_ID"] = ro.employee_ID;
                Response.Redirect("~/CheckEmployeeResult.aspx");
            }
            else
                System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('Please select a valid Exam ID.')</SCRIPT>");
        }

        //
        //Navigates back to the Admin home
        //
        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AdminHome.aspx");
        }

    }
}