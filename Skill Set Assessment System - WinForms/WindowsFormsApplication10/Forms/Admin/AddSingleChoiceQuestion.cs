/*
 comments
 naming
 related DAL
 minimization
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entities2;
using Business1;

namespace WindowsFormsApplication10
{
    public partial class AddSingleChoiceQuestion : Form
    {
        QuestionsBS ed = new QuestionsBS();

        public AddSingleChoiceQuestion()
        {
            InitializeComponent();
        }


        //
        //On Loading of Form, loads Marks, Exam Types and displays Format
        //
        private void AddSingleChoiceQuestion_Load(object sender, EventArgs e)
        {   
            
            // to allign the Legend(Group Box) to
            // the center of form
		    int centerForm;
            int centerGroup;
            int groupStartPosition;

            centerForm = this.Width / 2;
            centerGroup = AddSingleChoiceLegend.Width / 2;
            groupStartPosition = centerForm - centerGroup;
            AddSingleChoiceLegend.Left = groupStartPosition; 
    
            //Loads Marks
            for (int j = 0; j <= 5; j++)
            {
                marksCombo.Items.Add(j + 1);
            }
            marksCombo.SelectedIndex = 0;

            //Displays Format
            formatText.Text = "MCQ (Single Answer)";

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
        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        //
        //On click of Add button, validates, adds question, displays assigned Quesetion ID
        //
        private void add_Click(object sender, EventArgs e)
        {
            if ((marksCombo.SelectedIndex == -1) || (examTypeCombo.SelectedIndex == -1))
                MessageBox.Show("Please select a valid entry","Error");
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
                    MessageBox.Show("Enter Section");

                string sol = "";
                if (option1Radio.Checked)
                    sol = "1";
                if (option2Radio.Checked)
                    sol = "2";
                if (option3Radio.Checked)
                    sol = "3";
                if (option4Radio.Checked)
                    sol = "4";
                que.solution = sol;

                string feedback = ed.addQuestion(que);
                if (feedback.Contains("successfully"))
                {
                    option1Radio.Checked = option2Radio.Checked = option3Radio.Checked = option4Radio.Checked = false;
                    examTypeCombo.SelectedIndex = marksCombo.SelectedIndex = 0;
                    questionText.Text = formatText.Text = option1Text.Text = option2Text.Text = option3Text.Text = option4Text.Text = "";

                }
                MessageBox.Show(feedback, "Add Question");
            }
        }

        private void marksCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddSingleChoiceLegend_Enter(object sender, EventArgs e)
        {

        }
    }
}
