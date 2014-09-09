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
    public partial class Delete_Question : System.Web.UI.Page
    {
        QuestionsBS ed = new QuestionsBS();

        protected void Page_Load(object sender, EventArgs e)
        {
            questionIDCombo.Items.Clear();
            int i = ed.getCount();
            if (i > 0)
            {
                string[] abc = new string[i];
                abc = ed.loadQuestion(i);
                for (int j = 0; j < i; j++)
                {
                    questionIDCombo.Items.Add(abc[j]);
                }
            }
            else
                System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('No Data.')</SCRIPT>");
               // MessageBox.Show("No Data");
            questionIDCombo.SelectedIndex = 0;
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
            if (questionIDCombo.SelectedIndex != -1)
            {
                //DialogResult result = MessageBox.Show("Are you sure you want delete " + questionIDCombo.SelectedItem.ToString() + "?", "Delete Question", MessageBoxButtons.YesNo);
                //if (result == DialogResult.Yes)
                
                    Questions q = new Questions();
                    string temp = questionIDCombo.SelectedItem.ToString();
                    int index = temp.IndexOf(":");
                    q.question_ID = temp.Substring(0, index - 1);
                    string feed = ed.deleteQuestion(q);
                    System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('Succesfully deleted.')</SCRIPT>");
                    //MessageBox.Show(feed);
                
            }
            else
                System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('SPlease select a valid Question ID.')</SCRIPT>");
                //MessageBox.Show("Please select a valid Question ID.");

            this.Page_Load(sender, e);
        }
    }
}