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
    public partial class EmpHome : Form
    {
        public Employee emp = new Employee();
        public Exam_Details ed = new Exam_Details();
        EmployeeBS b = new EmployeeBS();
        Exam_DetailsBS eb = new Exam_DetailsBS();
        Exam_TypeBS et = new Exam_TypeBS();
            
        
        public EmpHome(Employee ed)
        {
            InitializeComponent();
            emp = ed;
        }
        //
        //On Form Load: Displays Welcome Message, displays today's schedule, if any
        //
        private void EmpHome_Load(object sender, EventArgs e)
        {
            emp = b.getEmployee(emp);
            welcomeLabel.Text = "Welcome " + emp.first_Name + " " + emp.last_Name;

            ResultsBS r = new ResultsBS();
            int count = r.getExamCountForEmployee(emp);
            Exam_Details[] er = new Exam_Details[count];
            er = r.getExamIDsForEmployee(emp, count);
            er = eb.getSchedule(er);
            int[] index = eb.checkTodaysSchedule(er);
            Results[] res = new Results[index.Length];
            for (int i = 0; i < index.Length; i++)
            {
                res[i] = new Results();
                res[i].employee_ID = emp.employee_Id;
                res[i].exam_ID = er[index[i]].exam_ID;
            }

            //bool[] feed = new bool[index.Length];
            res = r.checkIfAppeared(res);

            int total = 0;
            for (int i = res.Length - 1; i >= 0; i--)
            {
                if (res[i].score == -1)
                {
                    total++;
                    ed.exam_ID = res[i].exam_ID;
                }
            }

            if (total == 0)
            {
                examIDLabel.Text = "Sorry.";
                examTypeLabel.Text = "You dont have any test scheduled today.";
                dateLabel.Text = "";
                durationLabel.Text = "";
                noteLabel.Text = "";
                skipTutorial.Enabled = false;
                takeTutorial.Enabled = false;
            }
            else
            {
                ed = eb.getExamDetails(ed);
                Exam_Types et1 = new Exam_Types();
                et1.exam_Type = ed.exam_Type;
                et1 = et.getExamType(et1);

                examIDLabel.Text += ed.exam_ID;
                examTypeLabel.Text +=" " +et1.exam_Type + " (" + et1.subject + " Level " + et1.level_Number+")";
                dateLabel.Text += ed.datetime.Date.ToShortDateString(); ;
                durationLabel.Text += +ed.duration;
                total--;
                if (total >= 1)
                    noteLabel.Text += "You have " + total + " more exams scheduled today.";
                else
                    noteLabel.Text = "";
            }

        }
        

        //
        //On click of Take Tutorial button: Navigates to Tutorial Form
        //
        private void takeTutorial_Click(object sender, EventArgs e)
        {  
            Tutorial fm3 = new Tutorial(emp, ed);
            fm3.MdiParent = this.MdiParent;
            fm3.Dock = DockStyle.Fill;
            this.Close();
            fm3.Show();
        }


        //
        //On click of Skip Tutorial button: Navigates to Instructions Form
        //
        private void skipTutorial_Click(object sender, EventArgs e)
        {
            Instructions fm4 = new Instructions(emp, ed);
            fm4.MdiParent = this.MdiParent;
            fm4.Dock = DockStyle.Fill;
            this.Close();
            fm4.Show();
        }


        //
        //On click of Logout button: Asks for confirmation and exits the application
        //
        private void logout_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to Logout?", "Logout", MessageBoxButtons.YesNo);
            if(dr.Equals(DialogResult.Yes))
                Application.Exit();
        }


        //
        //On click of Change Password button: Navigates to Change Password Form
        //
        private void changePassword_Click(object sender, EventArgs e)
        {
            ChangePassword f1 = new ChangePassword(emp);
            f1.MdiParent = this.MdiParent;
            f1.Dock = DockStyle.Fill;
            this.Close();
            f1.Show();
        }

        private void todayScheduleGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
