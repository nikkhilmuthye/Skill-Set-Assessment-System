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
    public partial class AdminHome : Form
    {
        Employee ed = new Employee();

        public AdminHome(Employee em)
        {
            InitializeComponent();
            ed = em;
        }
        

        //
        //Question Menu Item
        //
        private void singleOptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSingleChoiceQuestion f = new AddSingleChoiceQuestion();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }
        private void multipleOptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMultipleChoiceQuestion f = new AddMultipleChoiceQuestion();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }
        private void matchTheColumnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMatchTheColumnQuestion f = new AddMatchTheColumnQuestion();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }
        private void singleAnswerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPictureQuestionSingleAnswer f = new AddPictureQuestionSingleAnswer();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }
        private void multipleAnswersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPictureQuestionMultipleAnswer f = new AddPictureQuestionMultipleAnswer();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }
        private void bulkUploadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddQuestionsBulk f = new AddQuestionsBulk();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }
        private void updateAQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateQuestion f = new UpdateQuestion();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }
        private void deleteAQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteQuestion f = new DeleteQuestion();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }


        //
        //Exam Type Menu Item
        //
        private void updateAnExamTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateExamType f = new UpdateExamType();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }
        private void deleteAnExamTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteExamType f = new DeleteExamType();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }
        private void addAnExamTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddExamType f = new AddExamType();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }


        //
        //Exam Detail Menu Item
        //
        private void addAnExamDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddExam f = new AddExam();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }
        private void updateAnExamDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateExamDetail f = new UpdateExamDetail();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }
        private void deleteAnExamDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteExamDetail f = new DeleteExamDetail();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }


        //
        //Applicant Menu Item
        //
        private void addApplicantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddApplicant f = new AddApplicant();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }
        private void deleteApplicantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteApplicant f = new DeleteApplicant();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }


        //
        //Paper Menu Item
        //
        private void setPaperToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SelectSetPaper f = new SelectSetPaper();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }
        private void deletePaperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeletePaper f = new DeletePaper();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }
        private void viewPaperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewPaper f = new ViewPaper();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }
        private void updatePaperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectUpdatePaper f = new SelectUpdatePaper();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }


        //
        //Results Menu Item
        //
        private void viewResultsOfEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChooseEmployee f = new ChooseEmployee();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }
        private void viewResultsOfExamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectResult f = new SelectResult();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }
        private void detailedResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckDetailed f = new CheckDetailed();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        //
        //Logout Menu Item
        //
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Are you sure you want to Logout?", "Logout", MessageBoxButtons.YesNo);
            if (r.Equals(DialogResult.Yes))
            {
                Application.Exit();
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword f = new ChangePassword(ed);
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void setAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetAdmin f = new SetAdmin();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

       
    }
}
