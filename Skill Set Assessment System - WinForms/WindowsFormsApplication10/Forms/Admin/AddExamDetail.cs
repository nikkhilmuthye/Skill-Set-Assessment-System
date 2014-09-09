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
    public partial class AddExam : Form
    {
        public AddExam()
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
        //On click of Add button, validates, adds Exam & displays assigned Exam ID
        //
        private void add_Click(object sender, EventArgs e)
        {
            bool a = false;
            bool b = false;
            if (yesConfigRadio.Checked == false && noConfigRadio.Checked == false)
            {
                MessageBox.Show("Kindly select an option to allow employee to see the answers after exam or not to");
            }

            else a = true;

            if (examTypeCombo.SelectedIndex != -1)
            {
                b = true;
            }
            else
                MessageBox.Show("Please select a valid Exam ID.", "Error");
            string config = "";
            if (yesConfigRadio.Checked)
                config = "Yes";
            else if (noConfigRadio.Checked)
                config = "No";

            if (a == true && b == true)
            {
                Exam_Details em = new Exam_Details();
                Exam_DetailsBS js = new Exam_DetailsBS();
                em.exam_Type = examTypeCombo.SelectedItem.ToString();
                em.datetime = datePicker.Value;
                if (durationTextBox.TextLength == 0)
                    em.duration = 0;
                else
                    em.duration = Convert.ToInt32(durationTextBox.Text);
                
                //Call to BLL to validate and add Exam
                string feed = js.addExamDetail(em,config);
                MessageBox.Show(feed, "Add Exam");


                examTypeCombo.SelectedIndex = 0;
                datePicker.Value = DateTime.Today;
                durationTextBox.Text = "";
                yesConfigRadio.Checked = false;
                noConfigRadio.Checked = false;
            }
            else
                MessageBox.Show("Please select a valid Exam Type.");
        }


        //
        //Of Loading of Form, loads Exam Types
        //
        private void AddExam_Load(object sender, EventArgs e)
        {
            // to allign the Legend(Group Box) to
            // the center of form
            int centerForm;
            int centerGroup;
            int groupStartPosition;

            centerForm = this.Width / 2;
            centerGroup = addExamDetailsLegend.Width / 2;
            groupStartPosition = centerForm - centerGroup;
            addExamDetailsLegend.Left = groupStartPosition; 
            
            
            Exam_TypeBS em = new Exam_TypeBS();
            int i = em.getCount();
            if(i>0)
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
            examTypeCombo.SelectedIndex = 0;
        }
    }
}
