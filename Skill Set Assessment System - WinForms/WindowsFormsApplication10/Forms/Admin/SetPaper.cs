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
    
    public partial class SetPaper : Form
    {
        Exam_Details ed = new Exam_Details();
        PaperBS p = new PaperBS();
        QuestionsBS qb = new QuestionsBS();
            
        
        //
        //Recieves the selected Exam Detail and displays the Exam ID
        //
        public SetPaper(Exam_Details e)
        {
            InitializeComponent();
            ed = e;
            examTypeText.Text = e.exam_Type;
        }


        //
        //On Form Load: Displays No of Added Question, Disables controls & Loads Section ComboBox
        //  
        private void SetPaper_Load(object sender, EventArgs e)
        {
            
        	// to allign the Legend(Group Box) to
            // the center of form
		    int centerForm;
            int centerGroup;
            int groupStartPosition;

            centerForm = this.Width / 2;
            centerGroup = setPaperRegion.Width / 2;
            groupStartPosition = centerForm - centerGroup;
            setPaperRegion.Left = groupStartPosition;     
                
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
                MessageBox.Show("No Questions present in the database for the Exam Type of the selected Exam.", "Error");
        }


        //
        //On click of Back button, navigates to Select Set Paper Form
        //
        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
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
            for (int j = 1; j <= i; j++)
            {
                noOfQuestionsCombo.Items.Add(j);
            }
            noOfQuestionsCombo.SelectedIndex = 0;
            noOfQuestionsCombo.Enabled = true;
            add.Enabled = true;
        }


        //
        //On click of Add: Validates selection, Adds it, and updates No Of Quesions Added
        //
        private void add_Click(object sender, EventArgs e)
        {   
            //Validates selection and adds it
            if ((sectionCombo.SelectedIndex == -1 )|| (formatCombo.SelectedIndex == -1) || (noOfQuestionsCombo.SelectedIndex == -1))
                MessageBox.Show("Please select a valid entry","Error");
            else
            {
                Paper s = new Paper();
                s.exam_ID = ed.exam_ID;
                s.section = sectionCombo.SelectedItem.ToString();
                s.format = formatCombo.SelectedItem.ToString();
                s.no_Of_Questions = Convert.ToInt32(noOfQuestionsCombo.SelectedItem);
                string feed = p.addSectionFormat(s);
                MessageBox.Show(feed, "Set Paper");
            }

            //Updates No Of Quesions Added
            Paper pq = new Paper();
            pq.exam_ID = ed.exam_ID;
            noOfQuestionsText.Text = p.getAddedQuestionCount(pq)+"";
        }

    }
}
