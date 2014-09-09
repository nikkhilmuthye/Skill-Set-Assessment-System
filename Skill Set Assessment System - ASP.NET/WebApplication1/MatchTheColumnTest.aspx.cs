using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entities2;
using Business1;
using System.Data;
using System.Drawing;


namespace WebApplication1
{
    public partial class MatchTheColumnTest : System.Web.UI.Page
    {
        Questions[] q;
        Answers[] a;
        Bookmark[] b;
        int index;
        int timeLeft, min, sec;
        Employee emp = new Employee();
        Exam_Details ed = new Exam_Details();
        AnswerBS ab = new AnswerBS();
        Exam_DetailsBS eed = new Exam_DetailsBS();
        string ans;


        protected void Page_Load(object sender, EventArgs e)
        {
            q = (Questions[])Session["questions"];
            a = (Answers[])Session["answers"];
            b = (Bookmark[])Session["bookmark"];
            index = (int)Session["ind"];
            timeLeft = (int)Session["time"];
            emp = (Employee)Session["employee"];
            ed = (Exam_Details)Session["exam"];

            
            
            //Session["answers"] = null;
            //Session.Remove("answers");
            //if (!SM1.IsInAsyncPostBack)
              //  Session["timeout"] = DateTime.Now.AddMinutes(ed.duration).ToString();

            //Displays timer, employee name, exam ID, question, question no, options
            employeeNameLabel.Text = emp.first_Name + " " + emp.last_Name;
            examIDLabel.Text = "Exam ID:" + ed.exam_ID;
            questionNoLabel.Text = (index + 1) + ".";

            string temp = "";
            int pos;
            temp = q[index].question;

            temp = temp.Substring(1);
            pos = temp.IndexOf(".");
            aOption1Label.Text = temp.Substring(0, pos);

            temp = temp.Substring(pos + 1);
            pos = temp.IndexOf(".");
            aOption2Label.Text = temp.Substring(0, pos);

            temp = temp.Substring(pos + 1);
            pos = temp.IndexOf(".");
            aOption3Label.Text = temp.Substring(0, pos);

            temp = temp.Substring(pos + 1);
            pos = temp.IndexOf(".");
            aOption4Label.Text = temp.Substring(0, pos);

            bOption1Label.Text = q[index].option1;
            bOption2Label.Text = q[index].option2;
            bOption3Label.Text = q[index].option3;
            bOption4Label.Text = q[index].option4;

            //Displays previous answer, if any
            if (Page.IsPostBack)
            {
                //string ans = a[index].answer;
                orderTextBox.Text = a[index].answer;
            }
            else
            {
                string hi = "Enter Answer..";
                orderTextBox.Text = hi;
            }
            
            //Displays correctly enabled/disabled Next, Previous, Bookmark and Remove Bookmark buttons
            if (index == q.Length - 1)
                next.Enabled = false;
            else
                next.Enabled = true;

            if (index == 0)
                previous.Enabled = false;
            else
                previous.Enabled = true;

            if (b[index].status == true)
            {
                bookmark.Enabled = false;
                removeBookmark.Enabled = true;
            }
            else
            {
                bookmark.Enabled = true;
                removeBookmark.Enabled = false;
            }

            //Displays bookmark Grid and current question cell
            DataTable dt = new DataTable();
            dt.Columns.Add("Question", Type.GetType("System.Int32"));

            if (q.Length > 0)
            {
                for (int i = 0; i < q.Length; i++)
                {
                    dt.Rows.Add();
                    dt.Rows[dt.Rows.Count - 1]["Question"] = (i + 1);
                }
                bookmarkGridView.DataSource = dt;
                //bookmarkGridView.Enabled = false;
                bookmarkGridView.DataBind();
            }
        }

        public Answers[] GetAnswers
        {
            get { return a; }
        }

        //
        //On click on Bookmark button: sets the bookmark for the question, enables Remove Bookmark button & disables Bookmark button
        //
        protected void bookmark_Click(object sender, EventArgs e)
        {
            //Sets the bookmark
            b[index].status = true;
            GridViewRow drow = bookmarkGridView.Rows[index];
            drow.BackColor = ColorTranslator.FromHtml("#A1DCF2");

            //Enables Remove Bookmark button & disables Bookmark button
            bookmark.Enabled = false;
            removeBookmark.Enabled = true;
        }


        //
        //On click on Remove Bookmark button: resets the bookmark for the question, disables Bookmark button & enables Remove Bookmark button
        //
        protected void removeBookmark_Click(object sender, EventArgs e)
        {
            //Resets the bookmark
            b[index].status = false;
            GridViewRow drow = bookmarkGridView.Rows[index];
            drow.BackColor = ColorTranslator.FromHtml("lemonchiffon");

            //Disables Remove Bookmark button & enables Bookmark button
            bookmark.Enabled = true;
            removeBookmark.Enabled = false;
        }


        //
        //On click of Next button: Stores the selected answer and navigates to the next question
        //
        protected void next_Click(object sender, EventArgs e)
        {
            //Stores the selected answer
            ans = (string)orderTextBox.Text;
            //a[index].answer = ans;
            Session.Clear();
            a = ab.storeAnswer(a, index, ans);

            //Session.Remove("answers");
            //Navigates to the next question
            index++;
            string next = q[index].format;
            Session["questions"] = q;

            Session["answers"] = a;
            Session["bookmark"] = b;
            Session["ind"] = index;
            Session["time"] = timeLeft;
            Session["employee"] = emp;
            Session["exam"] = ed;

            switch (next)
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


        //
        //On click of Previous button: Stores the selected answer and navigates to the previous question
        //
        protected void previous_Click(object sender, EventArgs e)
        {
            //Stores the selected answer
            ans = (string)orderTextBox.Text;
            a[index].answer = ans;
            //a = ab.storeAnswer(a, index, ans);
            Session.Clear();
            //Session.Remove("answers");

            //Navigates to the previous question
            index--;
            string prev = q[index].format;
            Session["questions"] = q;
            Session["answers"] = a;
            Session["bookmark"] = b;
            Session["ind"] = index;
            Session["time"] = timeLeft;
            Session["employee"] = emp;
            Session["exam"] = ed;

            switch (prev)
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


        protected void bookmarkgrid_OnRowDataBound(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("GoTo"))
            {
                // Convert the row index stored in the CommandArgument
                // property to an Integer.
                int ind = Convert.ToInt32(e.CommandArgument);

                // Get the last name of the selected author from the appropriate
                // cell in the GridView control.
                GridViewRow selectedRow = bookmarkGridView.Rows[ind];
                TableCell ques_no = selectedRow.Cells[1];
                index = Convert.ToInt32(ques_no.Text.ToString());
  

            }
        }

        protected void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow row in bookmarkGridView.Rows)
            {
                if (row.RowIndex == bookmarkGridView.SelectedIndex)
                {
                    //Stores the selected ans
                    ans = (string)orderTextBox.Text;
                    ab.storeAnswer(a, index, ans);

                    index = Convert.ToInt32(row.Cells[1].ToString());

                    switch (q[index].format)
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
                else
                {
                    row.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                    row.ToolTip = "Click to select this row.";
                }
            }
        }


        //
        //On click on Submit button: Stores the selected answer, Confirms choice to submit, submits and navigates to Result Form
        //
        protected void submit_Click(object sender, EventArgs e)
        {
            answ.Text = orderTextBox.Text;

            /*
            //Stores the selected answer
            String answe = orderTextBox.Text;
            a[index].answer = answe;
            a = ab.storeAnswer(a, index, answe);
            Session.Clear();
            //Session.Remove("answers");

            //Confirms choice to submit 
            string confirmValue = Request.Form["confirm_value"];
            if (confirmValue == "Yes")
            {

                Session["questions"] = q;
                Session["answers"] = a;
                Session["employee"] = emp;
                Session["exam"] = ed;

                bool feed = ab.submit(a, q, emp, ed);
                if (feed == true)
                {
                    //Add Detailed Result
                    Results re = new Results();
                    DetailedReports dr = new DetailedReports();
                    re.employee_ID = emp.employee_Id;
                    re.exam_ID = ed.exam_ID;
                    //re.score = score;
                    ResultsBS rb = new ResultsBS();
                    bool flag = rb.calculateResult(a, q, re, emp);


                    answ.Text = orderTextBox.Text;
                    /*Navigates to Results Form
                    Result rs = new Result(emp, ed, q, a);
                    rs.MdiParent = this.MdiParent;
                    rs.Dock = DockStyle.Fill;
                    this.Close();
                    rs.Show();*

                    //Response.Redirect("~/Result.aspx");
                }
                else
                    System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('Some error occured. Sorry for the inconvenience.')</SCRIPT>");
                //MessageBox.Show("Some error occured. Sorry for the inconvenience.", "Error");
            }*/
        }


        //  
        //Updates & displays time. On time up, submits the paper
        //
        protected void timer1_tick(object sender, EventArgs e)
        {
            if (0 > DateTime.Compare(DateTime.Now, DateTime.Parse(Session["timeout"].ToString())))
            {
                timerLabel.Text = string.Format("Time Left: 00:{0}:{1}", ((Int32)DateTime.Parse(Session["timeout"].ToString()).Subtract(DateTime.Now).TotalMinutes).ToString(), ((Int32)DateTime.Parse(Session["timeout"].ToString()).Subtract(DateTime.Now).Seconds).ToString());
            }
            else
            {
                //If the user runs out of time, stops the timer, shows a MessageBox
                //Timer.Stop();
                timerLabel.Text = "Time's up!";
                //MessageBox.Show("You have run out of time! You didn't finish in time. Sorry.", "Time up !", MessageBoxButtons.OK);
                System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('You have run out of time! You didn't finish in time. Sorry.')</SCRIPT>");

                //Stores the answer
                ans = (string)orderTextBox.Text;
                ab.storeAnswer(a, index, ans);

                //Calculates score, stores answers and result in database
                bool feed = ab.submit(a, q, emp, ed);
                if (feed == true)
                {

                    //Add Detailed Result
                    Results re = new Results();
                    DetailedReports dr = new DetailedReports();
                    re.employee_ID = emp.employee_Id;
                    re.exam_ID = ed.exam_ID;
                    //re.score = score;
                    ResultsBS rb = new ResultsBS();
                    bool flag = rb.calculateResult(a, q, re, emp);

                    /*Navigates to Results Form
                    Result rs = new Result(emp, ed, q, a);
                    rs.MdiParent = this.MdiParent;
                    rs.Dock = DockStyle.Fill;
                    this.Close();
                    rs.Show();*/

                    Response.Redirect("~/Result.aspx");
                }
                else
                    System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('Some error occured. Sorry for the inconvenience.')</SCRIPT>");
                //MessageBox.Show("Some error occured. Sorry for the inconvenience.", "Error");
            }
        }
    }
}