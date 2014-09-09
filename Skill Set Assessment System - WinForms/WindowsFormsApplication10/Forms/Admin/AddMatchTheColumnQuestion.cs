﻿/*
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
    public partial class AddMatchTheColumnQuestion : Form
    {
        QuestionsBS ed = new QuestionsBS();

        public AddMatchTheColumnQuestion()
        {
            InitializeComponent();
        }


        //
        //On Loading of Form, loads Marks, Exam Types and displays Format
        //
        private void AddMatchTheColumnQuestion_Load(object sender, EventArgs e)
        {
            // to allign the Legend(Group Box) to
            // the center of form
            int centerForm;
            int centerGroup;
            int groupStartPosition;

            centerForm = this.Width / 2;
            centerGroup = AddMTCQuestionLegend.Width / 2;
            groupStartPosition = centerForm - centerGroup;
            AddMTCQuestionLegend.Left = groupStartPosition; 
            
            //Loads Marks
            for (int j = 0; j <= 5; j++)
            {
                marksCombo.Items.Add(j + 1);
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
                MessageBox.Show("Please select a valid entry", "Error");
            else
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
                else
                    MessageBox.Show("Enter Section");
                que.solution = solutionText.Text.ToString();
                que.option1 = oneText.Text.ToString();
                que.option2 = twoText.Text.ToString();
                que.option3 = threeText.Text.ToString();
                que.option4 = fourText.Text.ToString();

                string feedback = ed.addQuestion(que);
                MessageBox.Show(feedback);
                if(feedback.Contains("successfully"))
                {
                    examTypeCombo.SelectedIndex = sectioncomboBox.SelectedIndex = marksCombo.SelectedIndex = 0;
                    aText.Text = bText.Text = cText.Text = dText.Text = formatText.Text = solutionText.Text = oneText.Text = twoText.Text = threeText.Text = fourText.Text = "";
                }
            }
        }

        //
        //On Click of Help: Displays a message indicating how to enter solution order
        //
        private void helpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("If the correct order of matching the Column B with the Column B is Option 3, Option 2, Option 1, Option 4 then enter 3214 in the Solution Order textbox.", "Help");
        }
    }
}