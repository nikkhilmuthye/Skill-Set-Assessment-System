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
    public partial class SetPaper : System.Web.UI.Page
    {

        Exam_Details ed = new Exam_Details();
        Exam_DetailsBS d = new Exam_DetailsBS();
        PaperBS p = new PaperBS();
        QuestionsBS qb = new QuestionsBS();

        protected void Page_Load(object sender, EventArgs e)
        {
            ed.exam_ID = (String)Session["exam_ID"];
            ed = d.getExamDetails(ed);
            examTypeText.Text = ed.exam_Type;

            //ro.employee_ID = temp.Sub
            // Displays No of Added Questions
            Paper pq = new Paper();
            pq.exam_ID = ed.exam_ID;
            noOfQuestionsText.Text = p.getAddedQuestionCount(pq) + "";

            //Diables controls
            sectionCombo.Enabled = false;
            formatCombo.Enabled = false;
            noOfQuestionsCombo.Enabled = false;
            add.Enabled = false;

            //Loads Section ComboBox
            Questions q = new Questions();
            q.exam_Type = ed.exam_Type;
            int i = qb.getSectionCount(q);
            if (i > 0)
            {
                string[] abc = new string[i];
                abc = qb.loadSection(q, i);
                for (int j = 0; j < i; j++)
                {
                   sectionCombo.Items.Add(abc[j]);
                }
                sectionCombo.Enabled = true;
            }
            else
                System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('No Questions present in the database for the Exam Type of the selected Exam.')</SCRIPT>");
                //MessageBox.Show("No Questions present in the database for the Exam Type of the selected Exam.", "Error");
        }

        //
        //On click of Back button, navigates to Admin Home
        //
        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AdminHome.aspx");
        }

        //
        //On changing the Section ComboBox: Resets & Disables controls, Loads Format ComboBox
        //
        private void sectionCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Resets & Disables controls
            formatCombo.Items.Clear();
            formatCombo.SelectedIndex = -1;
            //formatCombo.ResetText();
            noOfQuestionsCombo.Items.Clear();
            noOfQuestionsCombo.SelectedIndex = -1;
            //noOfQuestionsCombo.ResetText();
            noOfQuestionsCombo.Enabled = false;
            add.Enabled = false;

            //Loads Format ComboBox
            Questions q = new Questions();
            q.exam_Type = ed.exam_Type;
            q.section = sectionCombo.SelectedItem.ToString();
            int i = qb.getFormatCount(q);
            string[] abc = new string[i];
            abc = qb.loadFormat(q, i);
            for (int j = 0; j < i; j++)
            {
                formatCombo.Items.Add(abc[j]);
            }
            formatCombo.Enabled = true;
        }

        //
        //On changing the Format ComboBox: Resets & Disables controls, Loads No Of Question ComboBox
        //
        protected void formatCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Resets & Disables controls
            noOfQuestionsCombo.Items.Clear();
            noOfQuestionsCombo.SelectedIndex = -1;
            //noOfQuestionsCombo.ResetText();

            //Loads No Of Question ComboBox
            Questions q = new Questions();
            q.exam_Type = examTypeText.Text;
            q.section = sectionCombo.SelectedItem.ToString();
            q.format = formatCombo.SelectedItem.ToString();
            int i = qb.getQuestionNoCount(q);
            for (int j = 1; j <= i; j++)
            {
                noOfQuestionsCombo.Items.Add(j+"");
            }
            noOfQuestionsCombo.SelectedIndex = 0;
            noOfQuestionsCombo.Enabled = true;
            add.Enabled = true;
        }


        //
        //On click of Add: Validates selection, Adds it, and updates No Of Quesions Added
        //
        protected void add_Click(object sender, EventArgs e)
        {
            //Validates selection and adds it
            if ((sectionCombo.SelectedIndex == -1) || (formatCombo.SelectedIndex == -1) || (noOfQuestionsCombo.SelectedIndex == -1))
                System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('Please select a valid entry')</SCRIPT>");
                //MessageBox.Show("Please select a valid entry", "Error");
            else
            {
                Paper s = new Paper();
                s.exam_ID = ed.exam_ID;
                s.section = sectionCombo.SelectedItem.ToString();
                s.format = formatCombo.SelectedItem.ToString();
                s.no_Of_Questions = Convert.ToInt32(noOfQuestionsCombo.SelectedItem);
                string feed = p.addSectionFormat(s);
                System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('Successfully')</SCRIPT>");
                //MessageBox.Show(feed, "Set Paper");
            }

            //Updates No Of Quesions Added
            Paper pq = new Paper();
            pq.exam_ID = ed.exam_ID;
            noOfQuestionsText.Text = p.getAddedQuestionCount(pq) + "";
        }
    }
}