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
    public partial class Result : Form
    {
        Questions [] q;
        Answers[] a;
        Employee emp = new Employee();
        Exam_Details ed = new Exam_Details();
        ResultsBS r = new ResultsBS();
        QuestionsBS qbs = new QuestionsBS();
            
            
        public Result(Employee e1, Exam_Details e2,Questions[] q1, Answers[] a1)
        {
            InitializeComponent();
            emp = e1;
            ed = e2;
            a = a1;
            q = q1;
        }


        //
        //On form load: Displays the employee name and his result
        //
        private void Result_Load(object sender, EventArgs e)
        {
            employeeNameLabel.Text = emp.first_Name + " " + emp.last_Name;
            
            Results re = new Results();
            re.Employee_ID = emp.employee_Id;
            re.exam_ID = ed.exam_ID;
            re = r.getResult(re);

            ResultStatus rs = new ResultStatus();
            rs.employee_ID = emp.employee_Id;
            rs.exam_Type = ed.exam_Type;
            ResultStatusBS rsb = new ResultStatusBS();
            rs = rsb.getResultStatus(rs);

            Exam_Types m = new Exam_Types();
            m.exam_Type = ed.exam_Type;
            Exam_TypeBS exd = new Exam_TypeBS();
            m = exd.getExamType(m);

            examLabel.Text = "Exam ID: " + ed.exam_ID + " Exam Type: " + ed.exam_Type + " Subject: " + m.subject + " Level: " + m.level_Number + " Attempt No: " + rs.attempt_No; 

            if (rs.status == "Passed")
                congratulationsLabel.Text = "Congratulations ! You have passed! Your score is"+re.score+". Percentage: "+re.percentage+"%";
            else
            {
                if (rs.attempt_No == m.no_Of_Attempts)
                {
                    congratulationsLabel.Text = "Sorry, You have Failed in this Examination . Your score is" + re.score + ". Percentage: " + re.percentage + "%. You have no more attempts left for this exam";

                }
                congratulationsLabel.Text = "Sorry , You have Failed in this Examination . Your score is"+re.score+". Percentage: "+re.percentage+"%. You have got " +(m.no_Of_Attempts-rs.attempt_No)  + " attempts left for this exam";
            }
        }


        //
        //On click of Proceed: Navigates to Feedback form
        //
        private void proceed_Click(object sender, EventArgs e)
        {
            //Gets the exam configuration
            Exam_DetailsBS edb = new Exam_DetailsBS();
            ed = edb.getExamDetails(ed);
            if (ed.answer_Config == "Yes")
            {
                //Navigates to Check Solution Form
                CheckSolution f = new CheckSolution(q, a, emp, ed);
                f.MdiParent = this.MdiParent;
                f.Dock = DockStyle.Fill;
                this.Close();
                f.Show();
            }
            else if (ed.answer_Config == "No")
            {
                //Navigates to Feedback Form
                FeedbackForm fm8 = new FeedbackForm(emp, ed);
                fm8.MdiParent = this.MdiParent;
                fm8.Dock = DockStyle.Fill;
                this.Close();
                fm8.Show();
            }
        }
    }
}
