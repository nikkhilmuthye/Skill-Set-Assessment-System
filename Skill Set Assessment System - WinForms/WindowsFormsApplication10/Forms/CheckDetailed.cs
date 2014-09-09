using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business1;
using Entities2;

namespace WindowsFormsApplication10
{
    public partial class CheckDetailed : Form
    {
        public CheckDetailed()
        {
            InitializeComponent();
        }


        //
        //On click of Check: Navigates to Detaile Report Form
        //
        private void check_Click(object sender, EventArgs e)
        {
            if (examIDCombo.SelectedIndex != -1)
            {
                Results r = new Results();
                r.exam_ID = examIDCombo.SelectedItem.ToString();
                DetailedReport dr = new DetailedReport(r);
                dr.MdiParent = this.MdiParent;
                dr.Dock = DockStyle.Fill;
                this.Close();
                dr.Show();
            }
            else
                MessageBox.Show("Please select a valid Exam ID.", "Error",MessageBoxButtons.OK);
        }

        
        //
        //On form Load: Loads the conducted exam IDs
        //
        private void CheckDetailed_Load(object sender, EventArgs e)
        {
            ResultsBS r = new ResultsBS();
            int count = r.getConductedExamsCount();
            if (count > 0)
            {
                Results[] rs = new Results[count];
                rs = r.loadConductedExamID(rs);
                for (int j = 0; j < count; j++)
                {
                    examIDCombo.Items.Add(rs[j].exam_ID);
                }
            }
            else
                MessageBox.Show("No Exams yet conducted","Error",MessageBoxButtons.OK);
        }

        
        //
        //On click of Back button, navigates to Admin Home
        //
        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
