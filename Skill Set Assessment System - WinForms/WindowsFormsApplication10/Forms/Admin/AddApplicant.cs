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
    public partial class AddApplicant : Form
    {
        ResultsBS js = new ResultsBS();
        Exam_DetailsBS edb = new Exam_DetailsBS();
        Exam_TypeBS etbs = new Exam_TypeBS();

        public AddApplicant()
        {
            InitializeComponent();
        }


        //
        //Of Loading of Form, loads Exam IDs and Employee IDs
        //
        private void AddApplicant_Load(object sender, EventArgs e)
        {
            // to allign the Legend(Group Box) to
            // the center of form
            int centerForm;
            int centerGroup;
            int groupStartPosition;

            centerForm = this.Width / 2;
            centerGroup = addApplicantLegend.Width / 2;
            groupStartPosition = centerForm - centerGroup;
            addApplicantLegend.Left = groupStartPosition; 
            
            //Exam IDs
            Exam_DetailsBS em = new Exam_DetailsBS();
            int i = em.getCount();
            if(i>0)
            {
                string[] abc = new string[i];
                abc = em.loadExamDetail(i);
                for (int m = 0; m < i; m++)
                {
                    examIDCombo.Items.Add(abc[m]);
                }
                examIDCombo.SelectedIndex = 0;
            }
            else
                MessageBox.Show("No Exams present in the databse.", "Error");
            
            //Employee IDs
            EmployeeBS emp = new EmployeeBS();
            int j = emp.getCount();
            if(j>0)
            {
                string[] abcd = new string[j];
                abcd = emp.loadEmployee(j);
                for (int k = 0; k < j; k++)
                {
                    employeeIDCombo.Items.Add(abcd[k]);
                }
                employeeIDCombo.SelectedIndex = 0;
            }
            else
                MessageBox.Show("No Employees present in the databse.", "Error");
        }


        //
        //On click of Back button, navigates to Admin Home
        //
        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //
        //On click of Add button, validates and adds applicants
        //
        private void add_Click(object sender, EventArgs e)
        {
            if (employeeIDCombo.SelectedIndex == -1 || examIDCombo.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a valid entry.", "Error");
            }
            else
            {   
                //Creates Results objects
                Results r = new Results();
                string id = employeeIDCombo.Text.ToString();
                int pos = id.IndexOf(":");
                r.employee_ID = id.Substring(0, pos);
                r.exam_ID = examIDCombo.Text.ToString();
                
                //Gets exam type of exam ID
                Exam_Details ed = new Exam_Details();
                ed.exam_ID = r.exam_ID;
                ed = edb.getExamDetails(ed);

                //Gets number of attempts for exam type
                Exam_Types et = new Exam_Types();
                Exam_TypeBS etb = new Exam_TypeBS();
                et.exam_Type = ed.exam_Type;
                et = etb.getExamType(et);

                //Creates ResultStatus objects
                ResultStatus rs = new ResultStatus();
                rs.employee_ID = r.employee_ID;
                rs.exam_Type = ed.exam_Type;

                //Gets the attempts_no and status
                ResultStatusBS rsb = new ResultStatusBS();
                rs = rsb.getResultStatus(rs);

                ResultsBS rb = new ResultsBS();

                //Unscheduled
                if (rs.status == "Unscheduled")
                {
                    rs.attempt_No = 1;
                    rs.status = "Scheduled";
                    string feedback = rsb.addResultStatus(rs);
                    if (feedback == "Error")
                    {
                        MessageBox.Show("Some error occured. Sorry for the inconvenience.");
                    }
                    else
                    {
                        string feed = rb.addApplicant(r);
                        if (feed == "Error")
                        {
                            MessageBox.Show("Some error occured. Sorry for the inconvenience.");
                            rsb.deleteResultStatus(rs);
                        }
                        else
                        {
                            //Succesfully scheduled
                            MessageBox.Show(feed + feedback, "Scheduled", MessageBoxButtons.OK);
                            examIDCombo.SelectedIndex = employeeIDCombo.SelectedIndex = 0;
                        }
                    }
                }
                //Scheduled
                else if (rs.status == "Scheduled")
                {
                    MessageBox.Show("Employee " + rs.employee_ID + " already has an exam scheduled for exam type " + rs.exam_Type + ".", "Already Scheduled", MessageBoxButtons.OK);
                }
                //Passed
                else if (rs.status == "Passsed")
                {
                    MessageBox.Show("Employee " + rs.employee_ID + " has passed an exam of exam type " + rs.exam_Type + ".", "Passed", MessageBoxButtons.OK);
                }
                //Failed
                else if (rs.status == "Failed")
                {
                    ///Exhausted Attempts
                    if (rs.attempt_No == et.no_Of_Attempts)
                    {
                        MessageBox.Show("Employee " + rs.employee_ID + " has used up the maximum number of attempts for exam type " + rs.exam_Type + ".", "Exhausted Attempts", MessageBoxButtons.OK);
                    }
                    //Attempts left
                    else
                    {
                        rs.Attempt_No++;
                        rs.status = "Scheduled";

                        string feedback = rsb.updateResultStatus(rs);
                        if (feedback == "Error")
                        {
                            MessageBox.Show("Some error occured. Sorry for the inconvenience.");
                        }
                        else
                        {
                            string feed = rb.addApplicant(r);
                            if (feed == "Error")
                            {
                                MessageBox.Show("Some error occured. Sorry for the inconvenience.");
                                rs.attempt_No--;
                                rsb.updateResultStatus(rs);
                            }
                            else
                            {
                                //Succesfully scheduled
                                MessageBox.Show(feed + feedback, "Scheduled", MessageBoxButtons.OK);
                                examIDCombo.SelectedIndex = employeeIDCombo.SelectedIndex = 0;
                            }
                        }
                    }
                }
            }
        }
    }
}
