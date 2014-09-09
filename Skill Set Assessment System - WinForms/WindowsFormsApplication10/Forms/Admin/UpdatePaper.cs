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
using Business1;
using Entities2;

namespace WindowsFormsApplication10
{
    public partial class UpdatePaper : Form
    {
        Exam_Details ed = new Exam_Details();
        Exam_DetailsBS b = new Exam_DetailsBS();
        PaperBS p = new PaperBS();
        QuestionsBS qb = new QuestionsBS();
                  

        //
        //Recieves the selected Exam Detail and displays the Exam ID
        //
        public UpdatePaper(Exam_Details e)
        {
            InitializeComponent();
            ed = e;
            examTypeText.Text = ed.exam_Type;
        }


        //
        //On Form Load: Displays No of Added Question, Disables controls & Loads Section ComboBox
        //
        private void UpdatePaper_Load(object sender, EventArgs e)
        {
            
        	// to allign the Legend(Group Box) to
            // the center of form
		    int centerForm;
            int centerGroup;
            int groupStartPosition;

            centerForm = this.Width / 2;
            centerGroup = updatePaperLegend.Width / 2;
            groupStartPosition = centerForm - centerGroup;
            updatePaperLegend.Left = groupStartPosition;     
                
            //Displays No of Added Questions
            Paper pq = new Paper();
            pq.exam_ID = ed.exam_ID;
            noOfQuestionsText.Text = p.getAddedQuestionCount(pq) + "";

            //Diables controls
            sectionCombo.Enabled = false;
            formatCombo.Enabled = false;
            noOfQuestionsCombo.Enabled = false;
            update.Enabled = false;

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
                MessageBox.Show("No Questions present in the database for the Exam Type of the selected Exam.", "Error");
        }


        //
        //On changing the Section ComboBox: Resets & Disables controls, Loads Format ComboBox
        //
        private void sectionCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Resets & Disables controls
            formatCombo.Items.Clear();
            formatCombo.ResetText();
            noOfQuestionsCombo.Items.Clear();
            noOfQuestionsCombo.ResetText();
            noOfQuestionsCombo.Enabled = false;
            update.Enabled = false;

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
        //On click of Back button, navigates to Select Update Paper Form
        //
        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //
        //On click of Update: Validates selection, Updates it, and updates No Of Quesions Added
        //
        private void update_Click(object sender, EventArgs e)
        {
            //Validates selection and adds it
            if ((sectionCombo.SelectedIndex == -1) || (formatCombo.SelectedIndex == -1) || (noOfQuestionsCombo.SelectedIndex == -1))
                MessageBox.Show("Please select a valid entry", "Error");
            else
            {
                Paper s = new Paper();
                s.exam_ID = ed.exam_ID;
                s.section = sectionCombo.SelectedItem.ToString();
                s.format = formatCombo.SelectedItem.ToString();
                s.no_Of_Questions = Convert.ToInt32(noOfQuestionsCombo.SelectedItem);
                string feed = p.updateSectionFormat(s);
                MessageBox.Show(feed, "Update Paper");
            }

            //Updates No Of Quesions Added
            Paper pq = new Paper();
            pq.exam_ID = ed.exam_ID;
            noOfQuestionsText.Text = p.getAddedQuestionCount(pq) + "";
        }


        //
        //On changing the Format ComboBox: Resets & Disables controls, Loads No Of Question ComboBox, gets and sets the value of No of Questions
        //
        private void formatCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Resets & Disables controls
            noOfQuestionsCombo.Items.Clear();
            noOfQuestionsCombo.ResetText();

            //Loads No Of Question ComboBox
            Questions q = new Questions();
            q.exam_Type = examTypeText.Text;
            q.section = sectionCombo.SelectedItem.ToString();
            q.format = formatCombo.SelectedItem.ToString();
            int i = qb.getQuestionNoCount(q);
            for (int j = 0; j <= i; j++)
            {
                noOfQuestionsCombo.Items.Add(j);
            }
            noOfQuestionsCombo.Enabled = true;
            update.Enabled = true;

            //Gets and sets the value of No of Questions
            Paper s = new Paper();
            s.exam_ID = ed.exam_ID;
            s.section = sectionCombo.SelectedItem.ToString();
            s.format = formatCombo.SelectedItem.ToString();
            int no = p.getNoOfQuestions(s);
            noOfQuestionsCombo.SelectedItem = no;
        }
    }
}
