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
    public partial class UpdateQuestion : Form
    {
        QuestionsBS bs = new QuestionsBS();

        public UpdateQuestion()
        {
            InitializeComponent();
        }


        //
        //On Form Load: Fills the Question ID ComboBox 
        //
        private void UpdateQuestion_Load(object sender, EventArgs e)
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
            
            
            
            int i = bs.getCount();
            if (i > 0)
            {
                string[] abc = new string[i];
                abc = bs.loadQuestion(i);
                for (int j = 0; j < i; j++)
                {
                    questionIDCombo.Items.Add(abc[j]);
                }
            }
            else
                MessageBox.Show("No Data");
        }


        //
        //On click of Back button, navaigtes to Admin Home
        //
        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        //
        //On click of Go button
        //
        private void go_Click(object sender, EventArgs e)
        {
            if (questionIDCombo.SelectedIndex != -1)
            {
                //Assigns the selected Question ID & gets the other fields
                Questions ed = new Questions();
                string temp = questionIDCombo.SelectedItem.ToString();
                int pos = temp.IndexOf(":");
                ed.question_ID = temp.Substring(0, pos);
                ed = bs.getQuestion(ed);
                string format = ed.format;

                //Loads the net form as per the format of the selected queseion
                switch (format)
                {
                    case "MCQ (Single Answer)":
                        UpdateSingleChoice f = new UpdateSingleChoice(ed);
                        f.MdiParent = this.MdiParent;
                        f.Dock = DockStyle.Fill;
                        this.Close();
                        f.Show();
                        break;

                    case "MCQ (Multiple Answers)":
                        UpdateMultipleChoiceQuestions f1 = new UpdateMultipleChoiceQuestions(ed);
                        f1.MdiParent = this.MdiParent;
                        f1.Dock = DockStyle.Fill;
                        this.Close();
                        f1.Show();
                        break;
                        
                    case "Match The Column":
                        UpdateMatchTheColumn f2 = new UpdateMatchTheColumn(ed);
                        f2.MdiParent = this.MdiParent;
                        f2.Dock = DockStyle.Fill;
                        this.Close();
                        f2.Show();
                        break;

                    case "Picture Question: Single Answer":
                        UpdatePictureQuestionSingleAnswer f3 = new UpdatePictureQuestionSingleAnswer(ed);
                        f3.MdiParent = this.MdiParent;
                        f3.Dock = DockStyle.Fill;
                        this.Close();
                        f3.Show();
                        break;

                    case "Picture Question: Multiple Answer":
                        UpdatePictureQuestionMultipleAnswer f4 = new UpdatePictureQuestionMultipleAnswer(ed);
                        f4.MdiParent = this.MdiParent;
                        f4.Dock = DockStyle.Fill;
                        this.Close();
                        f4.Show();
                        break;
                 }
            }
            else
                MessageBox.Show("Please select a valid Question ID.", "Error");
        }
    }
}
