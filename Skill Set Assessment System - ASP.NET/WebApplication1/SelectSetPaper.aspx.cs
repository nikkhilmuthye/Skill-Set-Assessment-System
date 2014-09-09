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
    public partial class SelectSetPaper : System.Web.UI.Page
    {
        Exam_DetailsBS ed = new Exam_DetailsBS();
        PaperBS p = new PaperBS();

        protected void Page_Load(object sender, EventArgs e)
        {
            int x = p.getUnsetPaperCount();
            if (x > 0)
            {
                string[] arr = new string[x];
                arr = p.loadUnsetExamID();
                for (int m = 0; m < x; m++)
                    examIDCombo.Items.Add(arr[m]);
                examIDCombo.SelectedIndex = 0;
            }
            else
                System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('No Unset Exams present in the database.')</SCRIPT>");
        }

        //
        //On click on Check button: Validates selection & Naviagtes to Check Employee Result Form
        //
        protected void check_Click(object sender, EventArgs e)
        {
            if (examIDCombo.SelectedIndex != -1)
            {
                Exam_Details d = new Exam_Details();
                d.exam_ID = examIDCombo.SelectedItem.ToString();
                //d = ed.getExamDetails(d);
                //ro.employee_ID = temp.Substring(0, 4);
                Session["exam_ID"] = d.exam_ID;
                Response.Redirect("~/SetPaper.aspx");
            }
            else
                System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('Please select a valid Exam ID.')</SCRIPT>");
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