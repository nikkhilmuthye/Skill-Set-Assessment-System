using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Entities2;
using System.IO;
using Business1;
using System.Windows.Forms;

namespace WindowsFormsApplication10
{
    public partial class PictureQuestionSingleAns : Form
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
        

        //
        //Accepts and assigns Question, Answers, Bookmark array, index, time left, Employee and Exam Details
        //
        public PictureQuestionSingleAns(Questions[] que, Answers[] ans, Bookmark[] b1, int ind, int timeleft1, Employee e, Exam_Details exd)
        {
            InitializeComponent();
            q = que;
            a = ans;
            b = b1;
            index = ind;
            timeLeft = timeleft1;
            emp = e;
            ed = exd;
        }


        //
        //On form Load: Displays timer, employee name, exam ID, question, question No, options, previous answer, if any, bookmark Grid, current question cell, correctly enabled/disabled Next, Previous, Bookmark, Remove Bookmark buttons and displays Picture
        //
        private void PictureQuestionSingleAns_Load(object sender, EventArgs e)
        {
            //Displays timer, employee name, exam ID, question, question no, options
            Timer.Start();
            employeeNameLabel.Text = emp.first_Name + " " + emp.last_Name;
            examIDLabel.Text += ed.exam_ID;
            questionNoLabel.Text = (index + 1) + ".";
            questionLabel.Text = q[index].question;
            option1Radio.Text = q[index].option1;
            option2Radio.Text = q[index].option2;
            option3Radio.Text = q[index].option3;
            option4Radio.Text = q[index].option4;

            //Displays previous answer, if any
            string ans = a[index].answer;
            if (ans.Equals("1"))
                option1Radio.Checked = true;
            else if (ans.Equals("2"))
                option2Radio.Checked = true;
            else if (ans.Equals("3"))
                option3Radio.Checked = true;
            else if (ans.Equals("4"))
                option4Radio.Checked = true;
            else
            {
                option1Radio.Checked = false;
                option2Radio.Checked = false;
                option3Radio.Checked = false;
                option4Radio.Checked = false;
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

            //Displays bookmark Grid and current question cell
            bookmarkGrid.Rows.Add(q.Length - 1);
            DataGridViewRow drow;
            for (int i = 0; i < q.Length; i++)
            {
                drow = bookmarkGrid.Rows[i];
                drow.Cells[0].Value = (i + 1);
                drow.Cells[1].Value = b[i].status;
            }
            drow = bookmarkGrid.Rows[index];
            bookmarkGrid.CurrentCell = drow.Cells[0];

            //Displays the picture
            byte[] image = qb.getImage(q[index]);
            string s = Convert.ToString(DateTime.Now.ToFileTime());
            FileStream fs1 = new FileStream(s, FileMode.CreateNew, FileAccess.Write);
            fs1.Write(image, 0, image.Length);
            fs1.Flush();
            fs1.Close();
            pictureBox.Image = Image.FromFile(s);
        }


        //
        //On click of Next button: Stores the selected answer and navigates to the next question
        //
        private void next_Click(object sender, EventArgs e)
        {
            //Stores the selected answer
            string ans = "";
            if (option1Radio.Checked)
                ans = ans + "1";
            else if (option2Radio.Checked)
                ans = ans + "2";
            else if (option3Radio.Checked)
                ans = ans + "3";
            else if (option4Radio.Checked)
                ans = ans + "4";
            ab.storeAnswer(a, index, ans);

            //Navigates to the next question
            index++;
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
        //On click of Previous button: Stores the selected answer and navigates to the previous question
        //
        private void previous_Click(object sender, EventArgs e)
        {
            //Stores the selected answer
            string ans = "";
            if (option1Radio.Checked)
                ans = ans + "1";
            else if (option2Radio.Checked)
                ans = ans + "2";
            else if (option3Radio.Checked)
                ans = ans + "3";
            else if (option4Radio.Checked)
                ans = ans + "4";
            ab.storeAnswer(a, index, ans);

            //Navigates to the previous question
            index--;
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
        //On click on Submit button: Stores the selected answer, Confirms choice to submit, submits and navigates to Results Form
        //
        private void submit_Click(object sender, EventArgs e)
        {
            //Stores the selected answer
            string ans = "";
            if (option1Radio.Checked)
                ans = ans + "1";
            else if (option2Radio.Checked)
                ans = ans + "2";
            else if (option3Radio.Checked)
                ans = ans + "3";
            else if (option4Radio.Checked)
                ans = ans + "4";
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
        //On click on Bookmark button: sets the bookmark for the question, enables Remove Bookmark button & disables Bookmark button
        //
        private void bookmark_Click(object sender, EventArgs e)
        {
            //Sets the bookmark
            b[index].status = true;
            DataGridViewRow drow = bookmarkGrid.Rows[index];
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
            DataGridViewRow drow = bookmarkGrid.Rows[index];
            drow.Cells[1].Value = false;

            //Disables Remove Bookmark button & enables Bookmark button
            bookmark.Enabled = true;
            removeBookmark.Enabled = false;
        }


        //
        //On click of another question in Boomark Grid: Stores the selected ans, gets the clicked questions and navigates to it
        //
        private void bookmarkGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Stores the selected ans
            string ans = "";
            if (option1Radio.Checked)
                ans = ans + "1";
            else if (option2Radio.Checked)
                ans = ans + "2";
            else if (option3Radio.Checked)
                ans = ans + "3";
            else if (option4Radio.Checked)
                ans = ans + "4";
            ab.storeAnswer(a, index, ans);

            //Gets the clicked questions and navigates to it
            Point p = bookmarkGrid.CurrentCellAddress;
            index = p.Y; ;
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
        //Updates & displays time. On time up, submits the paper
        //
        private void Timer_Tick(object sender, EventArgs e)
        {  
            if (timeLeft > 0)
            {   //Updates & display the new time left
                timeLeft = timeLeft - 1;
                min = timeLeft / 60;
                sec = timeLeft - 60 * min;
                timeLabel.Text = min + " minutes: " + sec + " seconds";
            }
            else
            {
                //If the user runs out of time, stops the timer, shows a MessageBox
                Timer.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You have run out of time! You didn't finish in time. Sorry.", "Time up !", MessageBoxButtons.OK);

                //Stores the answer
                string ans = "";
                if (option1Radio.Checked)
                    ans = ans + "1";
                else if (option2Radio.Checked)
                    ans = ans + "2";
                else if (option3Radio.Checked)
                    ans = ans + "3";
                else if (option4Radio.Checked)
                    ans = ans + "4";
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
