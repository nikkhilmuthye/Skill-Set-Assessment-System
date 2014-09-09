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
    public partial class AddExamType : System.Web.UI.Page
    {

        //
        //On click of Back button, navigates to Admin Home
        //
        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminHome.aspx");
        }


        //
        //On click of Add button, validates, adds exam type, displays assigned exam type
        //
        protected void add_Click(object sender, EventArgs e)
        {
            int j;
            if ((levelCombo.SelectedIndex == -1 )|| (noOfAttemptsCombo.SelectedIndex == -1))
                //MessageBox.Show("Please select a valid entry.");
                j = 0;
            else
            {
                Exam_Types em = new Exam_Types();
                Exam_TypeBS cs = new Exam_TypeBS();

                em.subject = subjectText.Text.ToString();
                string temp = levelCombo.Text.ToString();
                em.level_Number = Convert.ToInt32(levelCombo.SelectedValue);
                em.no_Of_Attempts = Convert.ToInt32(noOfAttemptsCombo.SelectedValue);
                //Call to BLL to validate and add Exam Type
                string feedback = cs.addExamType(em);
                //MessageBox.Show(feedback, "Add Exam Type");


                subjectText.Text = "";
                levelCombo.SelectedIndex = 0;
                noOfAttemptsCombo.SelectedIndex = 0;
            }   
        }


        //
        //Of Loading of Form, loads Level and No Of Attempts
        //
        protected void Page_Load(object sender, EventArgs e)
        {
            for (int j = 0; j < 5; j++)
            {
                levelCombo.Items.Add(j+1+"");
                noOfAttemptsCombo.Items.Add((j + 1) + "");
            }
            levelCombo.SelectedIndex = 0;
            noOfAttemptsCombo.SelectedIndex = 0;
        }
    }
}