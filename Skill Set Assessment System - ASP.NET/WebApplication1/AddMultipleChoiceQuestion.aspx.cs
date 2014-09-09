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
    public partial class AddMultipleChoiceQuestion : System.Web.UI.Page
    {
        QuestionsBS ed = new QuestionsBS();

        protected void Page_Load(object sender, EventArgs e)
        {
            //Loads Marks
            for (int j = 0; j <= 5; j++)
            {
                marksCombo.Items.Add(j + 1+"");
            }
            marksCombo.SelectedIndex = 0;

            //Displays Format
            formatText.Text = "MCQ (Multiple Answers)";

            //Loads Exam Types
            Exam_TypeBS em = new Exam_TypeBS();
            int i = em.getCount();
            string[] abc = new string[i];
            abc = em.loadExamType(i);
            for (int j = 0; j < i; j++)
            {
                examTypeCombo.Items.Add(abc[j]);
            }
            examTypeCombo.SelectedIndex = 0;

            //Loads Sections

            int k = ed.getSectionCount();
            if (k > 0)
            {
                string[] bcd = new string[k];
                bcd = ed.loadSection(k);

                for (int j = 0; j < k; j++)
                {
                    sectioncomboBox.Items.Add(bcd[j]);
                }
                sectioncomboBox.SelectedIndex = 0;
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
        //On click of Add button, validates, adds question, displays assigned Quesetion ID
        //
        protected void add_Click(object sender, EventArgs e)
        {
            if ((marksCombo.SelectedIndex == -1) || (examTypeCombo.SelectedIndex == -1))
                System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('Please select a valid entry')</SCRIPT>");
                //MessageBox.Show("Please select a valid entry", "Error");
            else
            {
                Questions que = new Questions();
                que.exam_Type = examTypeCombo.Text.ToString();
                que.question = questionText.Text.ToString();
                que.format = formatText.Text.ToString();
                que.option1 = option1Text.Text.ToString();
                que.option2 = option2Text.Text.ToString();
                que.option3 = option3Text.Text.ToString();
                que.option4 = option4Text.Text.ToString();
                string t = marksCombo.Text.ToString();
                if (t == "")
                    que.marks = 0;
                else
                    que.marks = Convert.ToInt32(t);

                if (sectioncomboBox.SelectedIndex != -1)
                    que.section = sectioncomboBox.SelectedItem.ToString();
                else if (sectioncomboBox.Text != "")
                    que.section = sectioncomboBox.Text.ToString();
                else
                    System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('Enter Section')</SCRIPT>");
                //MessageBox.Show("Enter Section");

                string sol = "";

                if (option1Check.Checked)
                    sol = sol + "1";
                if (option2Check.Checked)
                    sol = sol + "2";
                if (option3Check.Checked)
                    sol = sol + "3";
                if (option4Check.Checked)
                    sol = sol + "4";
                que.solution = sol;
                string feedback = ed.addQuestion(que);
                if (feedback.Contains("successfully"))
                {
                    option1Check.Checked = option2Check.Checked = option3Check.Checked = option4Check.Checked = false;
                    examTypeCombo.SelectedIndex = marksCombo.SelectedIndex = 0;
                    questionText.Text = option1Text.Text = option2Text.Text = option3Text.Text = option4Text.Text = "";
                }
                System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert(feedback)</SCRIPT>");
            }
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        
    }
}