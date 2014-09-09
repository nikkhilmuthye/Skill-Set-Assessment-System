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
    public partial class UpdateExamDetail : Form
    {
        public UpdateExamDetail()
        {
            InitializeComponent();
        }

        //
        //On click of Update button
        //
        private void update_Click(object sender, EventArgs e)
        {   
            if (examIDCombo.SelectedIndex == -1 || examTypeCombo.SelectedIndex == -1)
                MessageBox.Show("Please select a valid entry", "Error");
            else
            {
                string config = "";
                if (yesConfigRadio.Checked)
                    config = "Yes";
                else if (noConfigRadio.Checked)
                    config = "No";

                Exam_DetailsBS js = new Exam_DetailsBS();
                Exam_Details em = new Exam_Details();
                em.exam_ID = examIDCombo.SelectedItem.ToString();
                em.exam_Type = (string)examTypeCombo.SelectedItem;
                em.datetime = datePicker.Value;
                
                if (durationTextBox.TextLength == 0)
                    em.duration = 0;
                else
                    em.duration = Convert.ToInt32(durationTextBox.Text);
                
                //Business logic call, forwarded to DAL
                string feedback = js.updateExamDetail(em,config);
                MessageBox.Show(feedback, "Update Exam");


                examIDCombo.SelectedIndex = 0;
                examTypeCombo.SelectedIndex = 0;
                datePicker.Value = DateTime.Today;
                yesConfigRadio.Checked = false;
                noConfigRadio.Checked = false;
            }  
        }

       
        //
        //On Form Load
        //
        private void UpdateExamDetail_Load(object sender, EventArgs e)
        {
            
        	// to allign the Legend(Group Box) to
            // the center of form
		    int centerForm;
            int centerGroup;
            int groupStartPosition;

            centerForm = this.Width / 2;
            centerGroup = updateExamLegend.Width / 2;
            groupStartPosition = centerForm - centerGroup;
            updateExamLegend.Left = groupStartPosition;     
                
            // Filling the ExamID ComboBox 
            Exam_DetailsBS ed = new Exam_DetailsBS();
            int i = ed.getCount();
            if (i > 0)
            {
                string[] abc = new string[i];
                abc = ed.loadExamDetail(i);
                for (int j = 0; j < i; j++)
                {
                    examIDCombo.Items.Add(abc[j]);
                }
            }
            //Disabling the other controls
            examTypeCombo.Enabled = false;
            datePicker.Enabled = false;
            update.Enabled = false;
        }


        //
        // On click of Back button, navaigtes to Admin Home
        //
        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        //
        //On changing the Exam ID
        //
        private void examIDcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Resets the other controls on change of ExamID, also disables then in case of an invalid selection
            examTypeCombo.ResetText();
            examTypeCombo.Items.Clear();
            examTypeCombo.Enabled = false;
            datePicker.Enabled = false;
            update.Enabled = false;

            if (examIDCombo.SelectedIndex != -1)
            {
                //Gets the details of the selected Exam ID
                Exam_Details et = new Exam_Details();
                Exam_DetailsBS cs = new Exam_DetailsBS();
                et.exam_ID = examIDCombo.SelectedItem.ToString();
                et = cs.getExamDetails(et);

                //Enables the other controls
                examTypeCombo.Enabled = true;
                datePicker.Enabled = true;
                update.Enabled = true;

                //Loads the Exam Types
                Exam_TypeBS em = new Exam_TypeBS();
                int i = em.getCount();
                if (i > 0)
                {
                    string[] abc = new string[i];
                    abc = em.loadExamType(i);
                    for (int j = 0; j < i; j++)
                    {
                        examTypeCombo.Items.Add(abc[j]);
                    }
                }
                else
                    MessageBox.Show("No Data");

                //Loads the Exam Details
                examTypeCombo.SelectedItem = et.exam_Type;
                datePicker.Value = et.datetime;
            }
            else
                MessageBox.Show("Please select a valid Exam ID.");   
        }
    }
}
