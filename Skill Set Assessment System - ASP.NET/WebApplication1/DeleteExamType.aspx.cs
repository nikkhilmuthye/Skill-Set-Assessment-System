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
    public partial class Delete_Exam_Type : System.Web.UI.Page
    {
        Exam_TypeBS ed = new Exam_TypeBS();

        protected void Page_Load(object sender, EventArgs e)
        {
            examTypeCombo.Items.Clear();
            int i = ed.getCount();
            if (i > 0)
            {
                string[] abc = new string[i];
                abc = ed.loadExamType(i);
                for (int j = 0; j < i; j++)
                {
                    examTypeCombo.Items.Add(abc[j]);
                }
            }
            else
            System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('No Data.')</SCRIPT>");
            //MessageBox.Show("No Data");
            examTypeCombo.SelectedIndex = 0;
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
            if (examTypeCombo.SelectedIndex != -1)
            {
                //DialogResult result = MessageBox.Show("Are you sure you want delete " + examTypeCombo.SelectedItem.ToString() + "?", "Delete Exam Type", MessageBoxButtons.YesNo);
                //if (result == DialogResult.Yes)
                
                    Exam_Types r = new Exam_Types();
                    r.exam_Type = examTypeCombo.SelectedItem.ToString();
                    string feedback = ed.deleteExamType(r);
                    System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert(feedback)</SCRIPT>");
                    //MessageBox.Show(feedback);
                
            }
            else
                System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('Please select a valid Exam ID.')</SCRIPT>");
            //MessageBox.Show("Please select a valid Exam Type.");

            this.Page_Load(sender, e);
        }
    }
}