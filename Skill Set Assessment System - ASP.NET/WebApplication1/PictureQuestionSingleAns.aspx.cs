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
using System.IO;

namespace WebApplication1
{
    public partial class PictureQuestionSingleAns : System.Web.UI.Page
    {
        Questions[] q;
        Employee emp = new Employee();
        Exam_Details ed = new Exam_Details();
        Answers[] a;
        Bookmark[] b;
        int index;
        int timeLeft, min, sec;
        AnswerBS ab = new AnswerBS();
        QuestionsBS qb = new QuestionsBS();
        Exam_DetailsBS eed = new Exam_DetailsBS();


        protected void Page_Load(object sender, EventArgs e)
        {
            q = (Questions[])Session["questions"];
            a = (Answers[])Session["answers"];
            b = (Bookmark[])Session["bookmark"];
            index = (int)Session["ind"];
            timeLeft = (int)Session["time"];
            emp = (Employee)Session["employee"];
            ed = (Exam_Details)Session["exam"];

            if (!SM1.IsInAsyncPostBack)
                Session["timeout"] = DateTime.Now.AddMinutes(ed.duration).ToString();

            //Displays timer, employee name, exam ID, question, question no, options
            employeeNameLabel.Text = emp.first_Name + " " + emp.last_Name;
            examIDLabel.Text = "Exam ID:" + ed.exam_ID;
            questionNoLabel.Text = (index + 1) + ".";
            questionLabel.Text = q[index].question;
            option1RadioButton.Text = q[index].option1;
            option2RadioButton.Text = q[index].option2;
            option3RadioButton.Text = q[index].option3;
            option4RadioButon.Text = q[index].option4;

            //Displays previous answer, if any
            string ans = a[index].answer;
            if (ans.Equals("1"))
                option1RadioButton.Checked = true;
            else if (ans.Equals("2"))
                option2RadioButton.Checked = true;
            else if (ans.Equals("3"))
                option3RadioButton.Checked = true;
            else if (ans.Equals("4"))
                option4RadioButon.Checked = true;
            else
            {
                option1RadioButton.Checked = false;
                option2RadioButton.Checked = false;
                option3RadioButton.Checked = false;
                option4RadioButon.Checked = false;
            }

            //Displays correctly enabled/disabled Next, Previous, Bookmark, Remove Bookmark buttons
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

            ///Displays bookmark Grid and current question cell
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

            //Displays the picture
            byte[] image = qb.getImage(q[index]);
            /*
            string s = Convert.ToString(DateTime.Now.ToFileTime());
            FileStream fs1 = new FileStream(s, FileMode.CreateNew, FileAccess.Write);
            fs1.Write(image, 0, image.Length);
            fs1.Flush();
            fs1.Close();*/

            string base64String = Convert.ToBase64String(image, 0, image.Length);
            pictureBox.ImageUrl = "data:image/png;base64," + base64String;
            pictureBox.Visible = true;
            
            //pictureBox. = System.Drawing.Image.FromFile(s);
        }

        protected void next_Click(object sender, EventArgs e)
        {
            //Stores the selected ans
            string ans = "";
            if (option1RadioButton.Checked)
                ans = "1";
            else if (option2RadioButton.Checked)
                ans = "2";
            else if (option3RadioButton.Checked)
                ans = "3";
            else if (option4RadioButon.Checked)
                ans = "4";
            ab.storeAnswer(a, index, ans);

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

                //Stores the selected ans
                string ans = "";
                if (option1RadioButton.Checked)
                    ans = "1";
                else if (option2RadioButton.Checked)
                    ans = "2";
                else if (option3RadioButton.Checked)
                    ans = "3";
                else if (option4RadioButon.Checked)
                    ans = "4";
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
                }
            }
        }

        protected void previous_Click(object sender, EventArgs e)
        {
            //Stores the selected ans
            string ans = "";
            if (option1RadioButton.Checked)
                ans = "1";
            else if (option2RadioButton.Checked)
                ans = "2";
            else if (option3RadioButton.Checked)
                ans = "3";
            else if (option4RadioButon.Checked)
                ans = "4";
            ab.storeAnswer(a, index, ans);

            //Navigates to the next question
            index--;
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

        protected void submit_Click(object sender, EventArgs e)
        {
            //Stores the selected ans
            string ans = "";
            if (option1RadioButton.Checked)
                ans = "1";
            else if (option2RadioButton.Checked)
                ans = "2";
            else if (option3RadioButton.Checked)
                ans = "3";
            else if (option4RadioButon.Checked)
                ans = "4";
            ab.storeAnswer(a, index, ans);


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

        protected void OnRowDataBound(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(bookmarkGridView, "Select$" + e.Row.RowIndex);
                e.Row.ToolTip = "Click to select this row.";
            }
        }

        protected void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow row in bookmarkGridView.Rows)
            {
                if (row.RowIndex == bookmarkGridView.SelectedIndex)
                {
                    //Stores the selected ans
                    string ans = "";
                    if (option1RadioButton.Checked)
                        ans = "1";
                    else if (option2RadioButton.Checked)
                        ans = "2";
                    else if (option3RadioButton.Checked)
                        ans = "3";
                    else if (option4RadioButon.Checked)
                        ans = "4";
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
    }
}