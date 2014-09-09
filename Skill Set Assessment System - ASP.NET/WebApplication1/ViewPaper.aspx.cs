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
    public partial class ViewPaper : System.Web.UI.Page
    {
        PaperBS ed = new PaperBS();

        protected void Page_Load(object sender, EventArgs e)
        {
            int i = ed.getSetPaperCount();
            if (i > 0)
            {
                string[] abc = new string[i];
                abc = ed.loadSetExamID(i);
                for (int j = 0; j < i; j++)
                {
                    examIDCombo.Items.Add(abc[j]);
                }
                examIDCombo.SelectedIndex = 0;
            }
            else
            {
                System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('No set papers are present in the database.')</SCRIPT>");
                //MessageBox.Show("No set papers are present in the database.", "Error");
                examIDCombo.Enabled = false;
                view.Enabled = false;
            }
        }

        //
        //On click of Back button, navigates to Admin Home
        //
        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AdminHome.aspx");
        }

        //
        //On click on View button: Opens the ViewPaperDetails Form, displaying the Paper
        //
        protected void view_Click(object sender, EventArgs e)
        {
            if (examIDCombo.SelectedIndex != -1)
            {
                Paper p = new Paper();
                p.exam_ID = examIDCombo.SelectedItem.ToString();
                Session["exam_ID"] = p.exam_ID;
                Response.Redirect("");
            }
            else
                System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('Please select a valid Exam ID.')</SCRIPT>");
                //MessageBox.Show("Please select a valid Exam ID.", "Error");
        }
    }
}