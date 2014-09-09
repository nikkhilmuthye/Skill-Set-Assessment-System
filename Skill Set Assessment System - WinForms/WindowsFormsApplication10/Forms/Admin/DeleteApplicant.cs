/*
 naming
 minimization
 related DAL
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
    public partial class DeleteApplicant : Form
    {
        ResultsBS em = new ResultsBS();

        public DeleteApplicant()
        {
            InitializeComponent();
        }


        //
        //Deletes the selected Exam & pops up a Success or Error message
        //
        private void delete_Click(object sender, EventArgs e)
        {
            if(empIDexamIDcombo.SelectedIndex != -1)
            {
                DialogResult result = MessageBox.Show("Are you sure you want delete " + empIDexamIDcombo.SelectedItem.ToString()+ "?", "Delete Applciant", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //Results Object
                    Results r = new Results();
                    string temp = empIDexamIDcombo.SelectedItem.ToString();
                    int pos = temp.IndexOf(":");
                    r.employee_ID = temp.Substring(0, pos);
                    r.exam_ID = temp.Substring(pos+1);

                    //Gets Exam type
                    Exam_Details ed = new Exam_Details();
                    ed.exam_ID = r.exam_ID;
                    Exam_DetailsBS edb = new Exam_DetailsBS();
                    ed = edb.getExamDetails(ed);

                    //ResultStatus object
                    ResultStatus rs = new ResultStatus();
                    rs.employee_ID = r.employee_ID;
                    rs.exam_Type = ed.exam_Type;

                    //Gets Attempt No
                    ResultStatusBS rsb = new ResultStatusBS();
                    rs= rsb.getResultStatus(rs);

                    if (rs.attempt_No == 1)
                    {
                        //First Timer
                        string feedback = em.deleteResults(r);
                        if(feedback !="Error")
                        {
                            rsb.deleteResultStatus(rs);
                            MessageBox.Show("Succesfully deleted.", "Delete Applicant", MessageBoxButtons.OK);
                        }
                        else
                            MessageBox.Show("Unsuccessful attempt. Sorry for the inconvenience.", "Error", MessageBoxButtons.OK);
                    }
                    else
                    {
                        //Repeater
                        rs.attempt_No--;
                        string feedback = em.deleteResults(r);
                        if (feedback != "Error")
                        {
                            rsb.updateResultStatus(rs);
                            MessageBox.Show("Succesfully deleted.", "Delete Applicant",MessageBoxButtons.OK);
                        }
                        else
                            MessageBox.Show("Unsuccessful attempt. Sorry for the inconvenience.","Error",MessageBoxButtons.OK);
                    }
                }
            }
            else
                MessageBox.Show("Please select a valid entry.", "Error");
            this.DeleteApplicant_Load(sender, e);
        }


        //
        //Navigates back to the Admin home
        //
        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //
        //Loads present applicants for deletion
        //
        private void DeleteApplicant_Load(object sender, EventArgs e)
        {
            

            // to allign the Legend(Group Box) to
            // the center of form
		    int centerForm;
            int centerGroup;
            int groupStartPosition;

            centerForm = this.Width / 2;
            centerGroup = deleteApplicantLegend.Width / 2;
            groupStartPosition = centerForm - centerGroup;
            deleteApplicantLegend.Left = groupStartPosition; 
            empIDexamIDcombo.Items.Clear();
            int i = em.getCount();
            if (i > 0)
            {
                string[] abc = new string[i];
                abc = em.loadApplicants(i);
                for (int m = 0; m < i; m++)
                {
                    empIDexamIDcombo.Items.Add(abc[m]);
                }
            }
            else
                MessageBox.Show("No Applicants present in the datavase.");
            empIDexamIDcombo.SelectedIndex = 0;
        }
    }
}
