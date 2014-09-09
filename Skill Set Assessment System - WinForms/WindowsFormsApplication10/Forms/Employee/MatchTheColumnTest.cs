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
    public partial class MatchTheColumnTest : Form
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
        
        //
        //Accepts and assigns Question, Answers, Bookmark array, index, time left, Employee and Exam Details
        //
        public MatchTheColumnTest(Questions[] que, Answers[] ans, Bookmark[] b1, int ind, int timeleft1, Employee e, Exam_Details exd)
        {
            InitializeComponent();
            q = que;
            a = ans;
            index = ind;
            b = b1;
            timeLeft = timeleft1;
            emp = e;
            ed = exd;
        }


        //
        //On form Load: Displays timer, employee name, exam ID, question, question No, options, previous answer, if any, bookmark Grid, current question cell, and correctly enabled/disabled Next, Previous, Bookmark and Remove Bookmark buttons
        //
        private void MatchTheColumnTest_Load(object sender, EventArgs e)
        {
            //Displays timer, employee name, exam ID, question, question no, options
            Timer.Start();
            employeeNameLabel.Text = emp.first_Name + " " + emp.last_Name;
            examIDLabel.Text += ed.exam_ID;
            questionNoLabel.Text = (index + 1) + ".";
            
            string temp="";
            int pos;
            temp= q[index].question;

            temp = temp.Substring(1);
            pos  = temp.IndexOf(".");
            aOption1Label.Text = temp.Substring(0,pos);
           
            temp = temp.Substring(pos+1);
            pos = temp.IndexOf(".");
            aOption2Label.Text = temp.Substring(0, pos);

            temp = temp.Substring(pos+1);
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
            string ans = a[index].answer;
            orderTextBox.Text = ans;

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
            bookMarkGrid.Rows.Add(q.Length - 1);
            DataGridViewRow drow;
            for (int i = 0; i < q.Length; i++)
            {
                drow = bookMarkGrid.Rows[i];
                drow.Cells[0].Value = (i + 1);
                drow.Cells[1].Value = b[i].status;
            }
            drow = bookMarkGrid.Rows[index];
            bookMarkGrid.CurrentCell = drow.Cells[0];
        }

        //
        //On click on Bookmark button: sets the bookmark for the question, enables Remove Bookmark button & disables Bookmark button
        //
        private void bookmark_Click(object sender, EventArgs e)
        {
            //Sets the bookmark
            b[index].status = true;
            DataGridViewRow drow = bookMarkGrid.Rows[index];
            drow.Cells[1].Value = true;

            //Enables Remove Bookmark button & disables Bookmark button
            bookmark.Enabled = false;
            removeBookmark.Enabled = true;
        }


        //
        //On click on Remove Bookmark button: resets the bookmark for the question, disables Bookmark button & enables Remove Bookmark button
        //
        private void removeBookmark_Click(object sender, EventArgs e)
        {
            //Resets the bookmark
            b[index].status = false;
            DataGridViewRow drow = bookMarkGrid.Rows[index];
            drow.Cells[1].Value = false;

            //Disables Remove Bookmark button & enables Bookmark button
            bookmark.Enabled = true;
            removeBookmark.Enabled = false;
        }


        //
        //On click of Next button: Stores the selected answer and navigates to the next question
        //
        private void next_Click(object sender, EventArgs e)
        {
            //Stores the selected answer
            ans = (string)orderTextBox.Text;
            ab.storeAnswer(a, index, ans);
            
            //Navigates to the next question
            index++;
            string next = q[index].format;
            switch (next)
            {
                case "Match The Column":
                    MatchTheColumnTest mc = new MatchTheColumnTest(q, a, b, index, timeLeft, emp, ed);
                    mc.MdiParent = this.MdiParent;
                    mc.Dock = DockStyle.Fill;
                    this.Close();
                    mc.Show();
                    break;


                case "MCQ (Single Answer)":
                    SingleAnswerTest mb = new SingleAnswerTest(q, a, b, index, timeLeft, emp, ed);
                    mb.MdiParent = this.MdiParent;
                    mb.Dock = DockStyle.Fill;
                    this.Close();
                    mb.Show();
                    break;


                case "MCQ (Multiple Answers)":
                    MultipleAnswerTest ma = new MultipleAnswerTest(q, a, b, index, timeLeft, emp, ed);
                    ma.MdiParent = this.MdiParent;
                    ma.Dock = DockStyle.Fill;
                    this.Close();
                    ma.Show();
                    break;

                case "Picture Question: Single Answer":
                    PictureQuestionSingleAns mp = new PictureQuestionSingleAns(q, a, b, index, timeLeft, emp, ed);
                    mp.MdiParent = this.MdiParent;
                    mp.Dock = DockStyle.Fill;
                    this.Close();
                    mp.Show();
                    break;

                case "Picture Question: Multiple Answer":
                    PictureQuestionMultipleAnswer mm = new PictureQuestionMultipleAnswer(q, a, b, index, timeLeft, emp, ed);
                    mm.MdiParent = this.MdiParent;
                    mm.Dock = DockStyle.Fill;
                    this.Close();
                    mm.Show();
                    break;
            }
        }


        //
        //On click of Previous button: Stores the selected answer and navigates to the previous question
        //
        private void previous_Click(object sender, EventArgs e)
        {
            //Stores the selected answer
            ans = (string)orderTextBox.Text;
            ab.storeAnswer(a, index, ans);
            
            //Navigates to the previous question
            index--;
            string prev = q[index].format;
            switch (prev)
            {
                case "Match The Column":
                    MatchTheColumnTest mc = new MatchTheColumnTest(q, a, b, index, timeLeft, emp, ed);
                    mc.MdiParent = this.MdiParent;
                    mc.Dock = DockStyle.Fill;
                    this.Close();
                    mc.Show();
                    break;


                case "MCQ (Single Answer)":
                    SingleAnswerTest mb = new SingleAnswerTest(q, a, b, index, timeLeft, emp, ed);
                    mb.MdiParent = this.MdiParent;
                    mb.Dock = DockStyle.Fill;
                    this.Close();
                    mb.Show();
                    break;


                case "MCQ (Multiple Answers)":
                    MultipleAnswerTest ma = new MultipleAnswerTest(q, a, b, index, timeLeft, emp, ed);
                    ma.MdiParent = this.MdiParent;
                    ma.Dock = DockStyle.Fill;
                    this.Close();
                    ma.Show();
                    break;

                case "Picture Question: Single Answer":
                    PictureQuestionSingleAns mp = new PictureQuestionSingleAns(q, a, b, index, timeLeft, emp, ed);
                    mp.MdiParent = this.MdiParent;
                    mp.Dock = DockStyle.Fill;
                    this.Close();
                    mp.Show();
                    break;

                case "Picture Question: Multiple Answer":
                    PictureQuestionMultipleAnswer mm = new PictureQuestionMultipleAnswer(q, a, b, index, timeLeft, emp, ed);
                    mm.MdiParent = this.MdiParent;
                    mm.Dock = DockStyle.Fill;
                    this.Close();
                    mm.Show();
                    break;
            }
        }


        //
        //On click of another question in Boomark Grid: Stores the selected ans, gets the clicked questions and navigates to it
        //
        private void bookmarkGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Stores the selected ans
            ans = (string)orderTextBox.Text;
            ab.storeAnswer(a, index, ans);
            
            //Gets the clicked questions and navigates to it
            Point p = bookMarkGrid.CurrentCellAddress;
            index = p.Y;
            switch (q[index].format)
            {
                case "Match The Column":
                    MatchTheColumnTest mc = new MatchTheColumnTest(q, a, b, index, timeLeft, emp, ed);
                    mc.MdiParent = this.MdiParent;
                    mc.Dock = DockStyle.Fill;
                    this.Close();
                    mc.Show();
                    break;


                case "MCQ (Single Answer)":
                    SingleAnswerTest mb = new SingleAnswerTest(q, a, b, index, timeLeft, emp, ed);
                    mb.MdiParent = this.MdiParent;
                    mb.Dock = DockStyle.Fill;
                    this.Close();
                    mb.Show();
                    break;


                case "MCQ (Multiple Answers)":
                    MultipleAnswerTest ma = new MultipleAnswerTest(q, a, b, index, timeLeft, emp, ed);
                    ma.MdiParent = this.MdiParent;
                    ma.Dock = DockStyle.Fill;
                    this.Close();
                    ma.Show();
                    break;

                case "Picture Question: Single Answer":
                    PictureQuestionSingleAns mp = new PictureQuestionSingleAns(q, a, b, index, timeLeft, emp, ed);
                    mp.MdiParent = this.MdiParent;
                    mp.Dock = DockStyle.Fill;
                    this.Close();
                    mp.Show();
                    break;

                case "Picture Question: Multiple Answer":
                    PictureQuestionMultipleAnswer mm = new PictureQuestionMultipleAnswer(q, a, b, index, timeLeft, emp, ed);
                    mm.MdiParent = this.MdiParent;
                    mm.Dock = DockStyle.Fill;
                    this.Close();
                    mm.Show();
                    break;
            }
        }


        //
        //On click on Submit button: Stores the selected answer, Confirms choice to submit, submits and navigates to Result Form
        //
        private void submit_Click(object sender, EventArgs e)
        {   
            //Stores the selected answer
            ans = (string)orderTextBox.Text;
            ab.storeAnswer(a, index, ans);
            
            //Confirms choice to submit 
            DialogResult r = MessageBox.Show("Are you sure you want to submit?", "Submit Test", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                //Calculates score, stores answers, and result 
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

                    //Navigates to Results Form
                    Result rs = new Result(emp, ed, q, a);
                    rs.MdiParent = this.MdiParent;
                    rs.Dock = DockStyle.Fill;
                    this.Close();
                    rs.Show();
                }
                else
                    MessageBox.Show("Some error occured. Sorry for the inconvenience.", "Error");
            }
        }


        //
        //Updates & displays time. On time up, submits the paper
        //
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                // Updates & Display the new time left
                timeLeft = timeLeft - 1;
                min = timeLeft / 60;
                sec = timeLeft - 60 * min;
                timerLabel.Text = min + " minutes: " + sec + " seconds";
            }
            else
            {
                //If the user runs out of time, stops the timer, shows a MessageBox
                Timer.Stop();
                timerLabel.Text = "Time's up!";
                MessageBox.Show("You have run out of time! You didn't finish in time. Sorry.", "Time up !", MessageBoxButtons.OK);

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

                    //Navigates to Results Form
                    Result rs = new Result(emp, ed, q, a);
                    rs.MdiParent = this.MdiParent;
                    rs.Dock = DockStyle.Fill;
                    this.Close();
                    rs.Show();
                }
                else
                    MessageBox.Show("Some error occured. Sorry for the inconvenience.", "Error");
            }
        }
    }
}
