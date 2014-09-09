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
    public partial class UpdateMatchTheColumn : Form
    {
        public Questions q;
        QuestionsBS cs = new QuestionsBS();

        public UpdateMatchTheColumn(Questions que)
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
        //On Form Load: Loads the fields of the selected question 
        //
        private void UpdateMatchTheColumn_Load(object sender, EventArgs e)
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

                //Format
                formatText.Text = q.format;

                //Question Column
                string temp = "";
                int pos;
                temp = q.question;

                temp = temp.Substring(1);
                pos = temp.IndexOf(".");
                textBoxA.Text = temp.Substring(0, pos);

                temp = temp.Substring(pos + 1);
                pos = temp.IndexOf(".");
                textBoxB.Text = temp.Substring(0, pos);

                temp = temp.Substring(pos + 1);
                pos = temp.IndexOf(".");
                textBoxC.Text = temp.Substring(0, pos);

                temp = temp.Substring(pos + 1);
                pos = temp.IndexOf(".");
                textBoxD.Text = temp.Substring(0, pos);

                //Answer Column
                textBox1.Text = q.option1;
                textBox2.Text = q.option2;
                textBox3.Text = q.option3;
                textBox4.Text = q.option4;

                //Solution Order
                solutionText.Text = q.solution;

                //Marks
                for (int j = 0; j < 8; j++)
                {
                    marksCombo.Items.Add(j + 1);
                }
                marksCombo.SelectedItem = q.marks;

                //Section
                sectioncomboBox.Text = q.section;
            }
            else
                MessageBox.Show("No Exam Types present in the database.");
        }


        //
        //On click of Update button
        //
        private void update_Click(object sender, EventArgs e)
        {
            if ((marksCombo.SelectedIndex == -1) || (examTypeCombo.SelectedIndex == -1))
                MessageBox.Show("Please select a valid entry", "Error");
            else
            {
                q.exam_Type = examTypeCombo.Text;
                q.question = "." + textBoxA.Text.ToString() + "." + textBoxB.Text.ToString() + "." + textBoxC.Text.ToString() + "." + textBoxD.Text.ToString() + ".";
                q.option1 = textBox1.Text.ToString();
                q.option2 = textBox2.Text.ToString();
                q.option3 = textBox3.Text.ToString();
                q.option4 = textBox4.Text.ToString();
                q.solution = solutionText.Text.ToString();
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
                MessageBox.Show(feedback, "Update Question");
                if (feedback.Contains("successfuly"))
                {
                    examTypeCombo.SelectedIndex = sectioncomboBox.SelectedIndex = marksCombo.SelectedIndex = 0;
                    textBoxA.Text = textBoxB.Text = textBoxC.Text = textBoxD.Text = formatText.Text = solutionText.Text = textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
                }
            }
        }

        
        //
        //On clickin the Help link
        //
        private void helpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("If the correct order of matching the Column B with Column A is Option 3, Option 2, Option 1, Option 4 then enter 3214 in the Solution Order textbox.", "Help");
        }
    }
}
