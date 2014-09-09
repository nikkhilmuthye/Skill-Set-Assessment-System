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
    public partial class DeletePaper : System.Web.UI.Page
    {
        PaperBS ed = new PaperBS();

        protected void Page_Load(object sender, EventArgs e)
        {
            examIDCombo.Items.Clear();
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
                System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('No data')</SCRIPT>");
                //MessageBox.Show("There are no exams in the database for which paper have been set.", "Error");
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
                Paper b = new Paper();
                b.exam_ID = examIDCombo.SelectedItem.ToString();
                //DialogResult result = MessageBox.Show("Are you sure you want delete " + examIDCombo.SelectedItem.ToString() + "?", "Delete Exam Type", MessageBoxButtons.YesNo);
                //if (result == DialogResult.Yes)
               
                    string abc = ed.deletePaper(b);
                    System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert(abc)</SCRIPT>");
                    //MessageBox.Show(abc, "Delete Paper");
                
            }
            else
                System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('Please select a valid Exam ID.')</SCRIPT>");
                //MessageBox.Show("Please select a valid Exam ID.", "Error");

            this.Page_Load(sender, e);
        }
    }
}