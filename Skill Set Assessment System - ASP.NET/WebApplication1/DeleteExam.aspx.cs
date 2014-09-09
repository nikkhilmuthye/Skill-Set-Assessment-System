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
    public partial class Delete_Exam : System.Web.UI.Page
    {
        Exam_DetailsBS ed = new Exam_DetailsBS();

        protected void Page_Load(object sender, EventArgs e)
        {
            examIDCombo.Items.Clear();
            int i = ed.getCount();
            if (i > 0)
            {
                string[] abc = new string[i];
                abc = ed.loadExamDetail(i);
                for (int j = 0; j < i; j++)
                {
                    examIDCombo.Items.Add(abc[j]);
                }
            }
            else
                System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('No Data')</SCRIPT>");
                //MessageBox.Show("No Data");
            examIDCombo.SelectedIndex = 0;
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
            if (examIDCombo.SelectedIndex != -1)
            {
                //DialogResult result = MessageBox.Show("Are you sure you want delete exam " + examIDCombo.SelectedItem.ToString() + "?", "Delete Exam", MessageBoxButtons.YesNo);
                //if (result == DialogResult.Yes)
                
                    Exam_Details r = new Exam_Details();
                    r.exam_ID = examIDCombo.SelectedItem.ToString();
                    string feedback = ed.deleteExamDetails(r);
                    System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('Succesfully deleted.')</SCRIPT>");
                    //MessageBox.Show(feedback);
                
            }
            else
                System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('Please select a valid entry.')</SCRIPT>");
            //MessageBox.Show("Please select a valid entry.", "Error");

            this.Page_Load(sender, e);
        }
    }
}