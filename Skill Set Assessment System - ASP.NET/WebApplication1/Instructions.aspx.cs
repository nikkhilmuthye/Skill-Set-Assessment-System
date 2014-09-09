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
    public partial class Instructions : System.Web.UI.Page
    {
        Employee emp = new Employee();
        Exam_Details ed = new Exam_Details();
        Questions[] q;
        Answers[] a;
        Bookmark[] b1;

        protected void Page_Load(object sender, EventArgs e)
        {
            emp = (Employee)Session["employee"];
            ed = (Exam_Details)Session["exam"];
            nameLabel.Text = emp.first_Name + " " + emp.last_Name;
            examIDLabel.Text = "Exam ID:" + ed.exam_ID;
        }

        //
        //On click of Back button: Navigates to Tutorials Form
        //
        protected void back_Click(object sender, EventArgs e)
        {
            Session["employee"] = emp;
            Session["exam"] = ed;
            Response.Redirect("~/Tutorial.aspx");
        }

        //
        //On click of Back button: Navigates to Tutorials Form
        //
        protected void home_Click(object sender, EventArgs e)
        {
            Session["employee"] = emp;
            Response.Redirect("~/EmpHome.aspx");
        }

        //
        //On click Of Start Button
        //
        protected void startTest_Click(object sender, EventArgs e)
        {
            //DialogResult r = MessageBox.Show("Are you sure you want to start the test?", "Start the Test", MessageBoxButtons.OKCancel);
            string confirmValue = Request.Form["confirm_value"];
            if (confirmValue == "Yes")
            {
                //Gets the Set Paper Details for the Exam
                Paper s = new Paper();
                s.exam_ID = ed.exam_ID;
                PaperBS p = new PaperBS();
                int scount = p.getRowCountForExam(s);
                Paper[] arr = new Paper[scount];
                arr = p.viewPaperDetails(s, scount);


                //Timer duration
                int timeLeft = ed.duration * 60;

                //Gets the questions according to the set paper details after random selection and shuffling
                int qcount = p.getAddedQuestionCount(s);
                q = new Questions[qcount];
                QuestionsBS b = new QuestionsBS();
                q = b.getQuestionPaper(arr, q, ed);

                //Initializes the Answers array and Bookmark array
                AnswerBS ab = new AnswerBS();
                a = new Answers[qcount];
                a = ab.initializeAnswersArray(a, q, ed, emp);
                b1 = new Bookmark[qcount];
                b1 = ab.initializeBookmarksArray(b1);


                //Swap Options
                Questions[] qnew = b.swapOptions(q);
                Int32 n = 0;
                Session["noOfQues"] = q.Count();
                Session["questions"] = qnew;
                Session["answers"] = a;
                Session["bookmark"] = b1;
                Session["ind"] = n;
                Session["time"] = timeLeft;
                Session["employee"] = emp;
                Session["exam"] = ed;
                Session["timeout"] = DateTime.Now.AddMinutes(ed.duration).ToString();

                //Chooses the first from according to the format of first question
                string first = qnew[0].format;
                switch (first)
                {
                    case "Match The Column":
                        Response.Redirect("~/MatchTheColumnTest.aspx");
                        break;

                    case "MCQ (Single Answer)":
                        Response.Redirect("~/SingleAnswerTest.aspx");
                        break;

                    case "MCQ (Multiple Answers)":
                        Response.Redirect("~/MultipleAnswerTest.aspx");
                        break;

                    case "Picture Question: Single Answer":
                        Response.Redirect("~/PictureQuestionSingleAns.aspx");
                        break;

                    case "Picture Question: Multiple Answer":
                        Response.Redirect("~/PictureQuestionMultipleAnswer.aspx");
                        break;
                }
            }
        }

        public Answers[] GetAnswers
        {
            get { return a; }
        }
    }
}