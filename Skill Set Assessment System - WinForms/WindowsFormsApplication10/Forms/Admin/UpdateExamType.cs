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
    public partial class UpdateExamType : Form
    {
        public int index;
        public string[] abc;
        public UpdateExamType()
        {
            InitializeComponent();
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
            if ((examTypeCombo.SelectedIndex == -1) || (levelCombo.SelectedIndex == -1) || (noOfAttemptsCombo.SelectedIndex == -1))
                MessageBox.Show("Please select a valid entry", "Error");
            else
            {
                //Getting the input
                Exam_TypeBS js = new Exam_TypeBS();
                Exam_Types em = new Exam_Types();
                em.exam_Type = examTypeCombo.SelectedItem.ToString();
                em.subject = subjectText.Text.ToString();
                em.level_Number = (Convert.ToInt32(levelCombo.Text));
                em.no_Of_Attempts = (Convert.ToInt32(noOfAttemptsCombo.Text));
                
                //Business logic call, forwarded to DAL
                string feedback = js.updateExamType(em);
                MessageBox.Show(feedback, "Update Exam");

                examTypeCombo.SelectedIndex = 0;
                subjectText.Text = "";
                levelCombo.SelectedIndex = 0;
                noOfAttemptsCombo.SelectedIndex = 0;
            }   
        }


        //
        //On Form Load
        //
        private void UpdateExamType_Load(object sender, EventArgs e)
        {
            
        	// to allign the Legend(Group Box) to
            // the center of form
		    int centerForm;
            int centerGroup;
            int groupStartPosition;

            centerForm = this.Width / 2;
            centerGroup = updateExamTypeLegend.Width / 2;
            groupStartPosition = centerForm - centerGroup;
            updateExamTypeLegend.Left = groupStartPosition;     
                
            // Filling the Exam Type ComboBox 
            Exam_TypeBS ed = new Exam_TypeBS();
            int i = ed.getCount();
            if (i > 0)
            {
                abc = new string[i];
                abc = ed.loadExamType(i);
                for (int j = 0; j < i; j++)
                {
                    examTypeCombo.Items.Add(abc[j]);
                }
            }
            else
                MessageBox.Show("No Data");

            //Disabling the other controls
            subjectText.Text = "";
            subjectText.Enabled = false;
            levelCombo.Enabled = false;
            noOfAttemptsCombo.Enabled = false;
            update.Enabled = false;

            //Loads the Level and No Of Attempts
            for (int j = 0; j <= 5; j++)
            {
                levelCombo.Items.Add(j);
                noOfAttemptsCombo.Items.Add(j);
            }
        }


        //
        //On changing the Exam Type
        //
        private void examTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Resets the other controls on change of Exam Type, also disables then in case of an invalid selection
            levelCombo.Enabled = false;
            noOfAttemptsCombo.Enabled = false;
            subjectText.Text = "";
            subjectText.Enabled = false;
            update.Enabled = false;

            if (examTypeCombo.SelectedIndex != -1)
            {
                //Gets the details of the selected Exam Type
                Exam_Types et = new Exam_Types();
                Exam_TypeBS cs = new Exam_TypeBS();
                et.exam_Type = examTypeCombo.SelectedItem.ToString();
                et = cs.getExamType(et);

                //Enables the other controls
                levelCombo.Enabled = true;
                noOfAttemptsCombo.Enabled = true;
                subjectText.Enabled = true;
                update.Enabled = true;

                //Loads the Exam Type
                subjectText.Text = et.subject;
                levelCombo.SelectedItem = et.level_Number;
                noOfAttemptsCombo.SelectedItem = et.no_Of_Attempts;
            }
            else
                MessageBox.Show("Please select a valid Exam Type.");  
        }
    }
}
