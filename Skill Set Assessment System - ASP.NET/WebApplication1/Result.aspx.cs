using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entities2;
using Business1;

namespace WebApplication1
{
    public partial class Result : System.Web.UI.Page
    {
        Questions[] q;
        Answers[] a;
        Employee emp = new Employee();
        Exam_Details ed = new Exam_Details();
        ResultsBS r = new ResultsBS();
        QuestionsBS qbs = new QuestionsBS();


        protected void Page_Load(object sender, EventArgs e)
        {
            q = (Questions[])Session["questions"];
            a = (Answers[])Session["answers"];
            emp = (Employee)Session["employee"];
            ed = (Exam_Details)Session["exam"];

            

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
                congratulationsLabel.Text = "Congratulations ! You have passed! Your score is" + re.score + ". Percentage: " + re.percentage + "%";
            else
            {
                if (rs.attempt_No == m.no_Of_Attempts)
                {
                    congratulationsLabel.Text = "Sorry, You have Failed in this Examination . Your score is" + re.score + ". Percentage: " + re.percentage + "%. You have no more attempts left for this exam";

                }
                congratulationsLabel.Text = "Sorry , You have Failed in this Examination . Your score is" + re.score + ". Percentage: " + re.percentage + "%. You have got " + (m.no_Of_Attempts - rs.attempt_No) + " attempts left for this exam";
            }
        }

        
        //On click of Proceed: Navigates to Feedback form
        //
        protected void proceed_Click(object sender, EventArgs e)
        {
            //Gets the exam configuration
            Exam_DetailsBS edb = new Exam_DetailsBS();
            ed = edb.getExamDetails(ed);

            Session["questions"] = q;
            Session["answers"] = a;
            Session["employee"] = emp;
            Session["exam"] = ed;

            if (ed.answer_Config == "Yes")
            {
                Response.Redirect("~/CheckSolution.aspx");
                /*Navigates to Check Solution Form
                CheckSolution f = new CheckSolution(q, a, emp, ed);
                f.MdiParent = this.MdiParent;
                f.Dock = DockStyle.Fill;
                this.Close();
                f.Show();*/
            }
            else if (ed.answer_Config == "No")
            {
                Response.Redirect("~/FeedbackForm.aspx");
                /*Navigates to Feedback Form
                FeedbackForm fm8 = new FeedbackForm(emp, ed);
                fm8.MdiParent = this.MdiParent;
                fm8.Dock = DockStyle.Fill;
                this.Close();
                fm8.Show();*/
            }
        }
    }
}