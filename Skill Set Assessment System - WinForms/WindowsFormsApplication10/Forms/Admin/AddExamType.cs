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
    public partial class AddExamType : Form
    {
        public AddExamType()
        {
            InitializeComponent();
        }


        //
        //On click of Back button, navigates to Admin Home
        //
        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //
        //On click of Add button, validates, adds exam type, displays assigned exam type
        //
        private void add_Click(object sender, EventArgs e)
        {
            if ((levelCombo.SelectedIndex == -1 )|| (noOfAttemptsCombo.SelectedIndex == -1))
                MessageBox.Show("Please select a valid entry.");
            else
            {
                Exam_Types em = new Exam_Types();
                Exam_TypeBS cs = new Exam_TypeBS();

                em.subject = subjectText.Text.ToString();
                string temp = levelCombo.Text.ToString();
                em.level_Number = Convert.ToInt32(levelCombo.SelectedItem);
                em.no_Of_Attempts = Convert.ToInt32(noOfAttemptsCombo.SelectedItem);
                //Call to BLL to validate and add Exam Type
                string feedback = cs.addExamType(em);
                MessageBox.Show(feedback, "Add Exam Type");


                subjectText.Text = "";
                levelCombo.SelectedIndex = 0;
                noOfAttemptsCombo.SelectedIndex = 0;
            }   
        }


        //
        //Of Loading of Form, loads Level and No Of Attempts
        //
        private void AddExamType_Load(object sender, EventArgs e)
        {
            // to allign the Legend(Group Box) to
            // the center of form
            int centerForm;
            int centerGroup;
            int groupStartPosition;

            centerForm = this.Width / 2;
            centerGroup = addExamTypeLegend.Width / 2;
            groupStartPosition = centerForm - centerGroup;
            addExamTypeLegend.Left = groupStartPosition; 
            
            for (int j = 0; j < 5; j++)
            {
                levelCombo.Items.Add(j+1);
                noOfAttemptsCombo.Items.Add(j + 1);
            }
            levelCombo.SelectedIndex = 0;
            noOfAttemptsCombo.SelectedIndex = 0;
        }
    }
}
