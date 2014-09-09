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
    public partial class AddMatchTheColoumnQuestion : System.Web.UI.Page
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
            formatText.Text = "Match The Column";

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
            //if ((marksCombo.SelectedIndex == -1) || (examTypeCombo.SelectedIndex == -1))
                //MessageBox.Show("Please select a valid entry", "Error");
            //else
            {
                Questions que = new Questions();
                que.exam_Type = examTypeCombo.Text.ToString();
                que.question = "." + aText.Text.ToString() + "." + bText.Text.ToString() + "." + cText.Text.ToString() + "." + dText.Text.ToString() + ".";
                que.format = formatText.Text.ToString();
                que.marks = Convert.ToInt32(marksCombo.Text);
                if (sectioncomboBox.SelectedIndex != -1)
                    que.section = sectioncomboBox.SelectedItem.ToString();
                else if (sectioncomboBox.Text != "")
                    que.section = sectioncomboBox.Text.ToString();
                //else
                    //MessageBox.Show("Enter Section");
                que.solution = solutionText.Text.ToString();
                que.option1 = oneText.Text.ToString();
                que.option2 = twoText.Text.ToString();
                que.option3 = threeText.Text.ToString();
                que.option4 = fourText.Text.ToString();

                string feedback = ed.addQuestion(que);
                //MessageBox.Show(feedback);
                if (feedback.Contains("successfully"))
                {
                    System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('Successfully')</SCRIPT>");
                    examTypeCombo.SelectedIndex = sectioncomboBox.SelectedIndex = marksCombo.SelectedIndex = 0;
                    aText.Text = bText.Text = cText.Text = dText.Text = solutionText.Text = oneText.Text = twoText.Text = threeText.Text = fourText.Text = "";
                }
                else
                    System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('Not Successfully')</SCRIPT>");
            }
        }
    }
}