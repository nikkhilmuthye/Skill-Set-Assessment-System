/*
 Naming
 related DAL
 minimization
 comments
 */
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
    public partial class SelectResult : Form
    {
        ResultsBS r = new ResultsBS();
            
        public SelectResult()
        {
            InitializeComponent();
        }
        

        //
        //On Form Load
        //
        private void SelectResult_Load(object sender, EventArgs e)
        {
            // to allign the Legend(Group Box) to
            // the center of form
            int centerForm;
            int centerGroup;
            int groupStartPosition;

            centerForm = this.Width / 2;
            centerGroup = selectExamLegend.Width / 2;
            groupStartPosition = centerForm - centerGroup;
            selectExamLegend.Left = groupStartPosition; 

            ResultsBS r = new ResultsBS();
            int count = r.getConductedExamsCount();
            if (count > 0)
            {
                Results[] rs = new Results[count];
                rs = r.loadConductedExamID(rs);
                for (int i = 0; i < count; i++)
                {
                    examIDCombo.Items.Add(rs[i].exam_ID);
                }
            }
            else
                MessageBox.Show("No Exams yet conducted");
        }


        //
        //On click of Back button, navaigtes to Admin Home
        //
        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //
        //On click of Check button
        //
        private void check_Click(object sender, EventArgs e)
        {
            if (examIDCombo.SelectedIndex != -1)
            {
                Results ro = new Results();
                ro.exam_ID = examIDCombo.SelectedItem.ToString();
                SeeResult f28 = new SeeResult(ro);
                f28.MdiParent = this.MdiParent;
                f28.Dock = DockStyle.Fill; 
                this.Close();
                f28.Show();
            }
            else
                MessageBox.Show("Please select a valid Exam ID.", "Error");
        }
    }
}
