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
    public partial class Instructions : Form
    {
        Employee emp = new Employee();
        Exam_Details ed = new Exam_Details();
        Questions[] q;
        Answers[] a;
        Bookmark[] b1;
        
        public Instructions(Employee e1, Exam_Details e2)
        {
            InitializeComponent();
            emp = e1;
            ed = e2;
        }

        //
        //On click Of Start Button
        //
        private void startTest_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Are you sure you want to start the test?", "Start the Test", MessageBoxButtons.OKCancel);
            if (r.Equals(DialogResult.OK))
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


                

                //Chooses the first from according to the format of first question
                string first = q[0].format;
                switch(first)
                {
                    case "Match The Column":
                        MatchTheColumnTest mc = new MatchTheColumnTest(qnew, a, b1, 0, timeLeft, emp, ed);
                        mc.MdiParent = this.MdiParent;
                        mc.Dock = DockStyle.Fill;
                        this.Close();
                        mc.Show();
                        break;
                        
                    case  "MCQ (Single Answer)":
                        SingleAnswerTest mb = new SingleAnswerTest(qnew, a, b1, 0, timeLeft, emp, ed);
                        mb.MdiParent = this.MdiParent;
                        mb.Dock = DockStyle.Fill;
                        this.Close();
                        mb.Show();
                        break;

                    case "MCQ (Multiple Answers)":
                        MultipleAnswerTest ma = new MultipleAnswerTest(qnew, a, b1, 0, timeLeft, emp, ed);
                        ma.MdiParent = this.MdiParent;
                        ma.Dock = DockStyle.Fill;
                        this.Close();
                        ma.Show();
                        break;

                    case "Picture Question: Single Answer":
                        PictureQuestionSingleAns mp = new PictureQuestionSingleAns(qnew, a, b1, 0, timeLeft, emp, ed);
                        mp.MdiParent = this.MdiParent;
                        mp.Dock = DockStyle.Fill;
                        this.Close();
                        mp.Show();
                        break;

                    case "Picture Question: Multiple Answer":
                        PictureQuestionMultipleAnswer mm = new PictureQuestionMultipleAnswer(qnew, a, b1, 0, timeLeft, emp, ed);
                        mm.MdiParent = this.MdiParent;
                        mm.Dock = DockStyle.Fill;
                        this.Close();
                        mm.Show();
                        break;
                }
            }
        }


        //
        //On Form Load: Displays the Employe Name and Exam ID
        //
        private void Instructions_Load(object sender, EventArgs e)
        {
            nameLabel.Text = emp.first_Name + " " + emp.last_Name;
            examIDLabel.Text += ed.exam_ID;
        }


        //
        //On click of Back button: Navigates to Tutorials Form
        //
        private void back_Click(object sender, EventArgs e)
        {
            Tutorial f = new Tutorial(emp, ed);
            f.MdiParent = this.MdiParent;
            f.Dock = DockStyle.Fill;
            this.Close();
            f.Show();
        }

        //
        //On click of Back button: Navigates to Tutorials Form
        //
        private void home_Click(object sender, EventArgs e)
        {
            EmpHome f = new EmpHome(emp);
            f.MdiParent = this.MdiParent;
            f.Dock = DockStyle.Fill;
            this.Close();
            f.Show();
        }
    }
}
