/*
 Naming
 related DAL
 minimization
 comments
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
    public partial class UpdateSingleChoice : Form
    {
        public Questions q;
        QuestionsBS cs = new QuestionsBS();

        public UpdateSingleChoice(Questions que)
        {
            InitializeComponent();
            q = que;
        }


        //
        //On click of Back button, navaigtes to Admin Home
        //
        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //
        //On click of Update button
        //
        private void update_Click(object sender, EventArgs e)
        {
            q.exam_Type = examTypeCombo.Text;
            q.question = questionText.Text.ToString();
            q.option1 = option1Text.Text.ToString();
            q.option2 = option2Text.Text.ToString();
            q.option3 = option3Text.Text.ToString();
            q.option4 = option4Text.Text.ToString();
            string sol = "";
            if (option1Radio.Checked)
                sol = "1";
            if (option2Radio.Checked)
                sol = "2";
            if (option3Radio.Checked)
                sol = "3";
            if (option4Radio.Checked)
                sol = "4";
            q.solution = sol;

            string temp = marksCombo.Text.ToString();
            if (temp == "")
                q.marks = 0;
            else
                q.marks = Convert.ToInt32(temp);
            if (sectioncomboBox.SelectedIndex != -1)
                q.section = sectioncomboBox.SelectedItem.ToString();
            else if (sectioncomboBox.Text != "")
                q.section = sectioncomboBox.Text.ToString();
            else
                MessageBox.Show("Enter Section");
            string feedback = cs.updateQuestion(q);
            if (feedback.Contains("successfully"))
            {
                option1Radio.Checked = option2Radio.Checked = option3Radio.Checked = option4Radio.Checked = false;
                examTypeCombo.SelectedIndex = marksCombo.SelectedIndex = 0;
                questionText.Text = formatText.Text = option1Text.Text = option2Text.Text = option3Text.Text = option4Text.Text = "";
            }
            MessageBox.Show(feedback ,"Update Question");
        }


        //
        //On Form Load: Loads the fields of the selected question 
        //
        private void UpdateSingleChoiceQuestion_Load(object sender, EventArgs e)
        {
            
        	// to allign the Legend(Group Box) to
            // the center of form
		    int centerForm;
            int centerGroup;
            int groupStartPosition;

            centerForm = this.Width / 2;
            centerGroup = updateQuestionLegend.Width / 2;
            groupStartPosition = centerForm - centerGroup;
            updateQuestionLegend.Left = groupStartPosition;     
                
                
            Exam_TypeBS em = new Exam_TypeBS();
            int m = em.getCount();
            if (m > 0)
            {
                //Question ID
                questionIDText.Text = q.question_ID;

                //Exam Type

                string[] abc1 = new string[m];
                abc1 = em.loadExamType(m);
                for (int j = 0; j < m; j++)
                {
                    examTypeCombo.Items.Add(abc1[j]);
                }
                examTypeCombo.SelectedItem = q.exam_Type;

                //Question 
                questionText.Text = q.question;

                //Format
                formatText.Text = q.format;

                //Options
                option1Text.Text = q.option1;
                option2Text.Text = q.option2;
                option3Text.Text = q.option3;
                option4Text.Text = q.option4;

                //Solution
                switch (q.solution)
                {
                    case "1":
                        option1Radio.Checked = true;
                        break;
                    case "2":
                        option2Radio.Checked = true;
                        break;
                    case "3":
                        option3Radio.Checked = true;
                        break;
                    case "4":
                        option1Radio.Checked = true;
                        break;
                }

                //Marks
                for (int j = 0; j < 8; j++)
                {
                    marksCombo.Items.Add(j + 1);
                }
                marksCombo.SelectedItem = q.marks;

                //Loads Sections

                int k = cs.getSectionCount();
                if (k > 0)
                {
                    string[] bcd = new string[k];
                    bcd = cs.loadSection(k);

                    for (int j = 0; j < k; j++)
                    {
                        sectioncomboBox.Items.Add(bcd[j]);
                    }
                    sectioncomboBox.SelectedIndex = 0;
                }

                //Section
                sectioncomboBox.Text = q.section;

            }
            else
                MessageBox.Show("No Exam Types present in the database.","Error",MessageBoxButtons.OK);
         }

    }
}