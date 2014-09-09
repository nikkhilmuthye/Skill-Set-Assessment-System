/*
 comments
 naming
 related DAL
 minimization
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
    public partial class SelectSetPaper : Form
    {
        Exam_DetailsBS ed = new Exam_DetailsBS();
        PaperBS p = new PaperBS();

            
        public SelectSetPaper()
        {
            InitializeComponent();
        }


        //
        //On Loading of Form, loads Exam IDs for which papers have not been set
        //
        private void SelectSetPaper_Load(object sender, EventArgs e)
        {
            

            // to allign the Legend(Group Box) to
            // the center of form
		    int centerForm;
            int centerGroup;
            int groupStartPosition;

            centerForm = this.Width / 2;
            centerGroup = selectPaperLegend.Width / 2;
            groupStartPosition = centerForm - centerGroup;
            selectPaperLegend.Left = groupStartPosition; 
            int x = p.getUnsetPaperCount();
            if (x > 0)
            {
                string[] arr = new string[x];
                arr = p.loadUnsetExamID();
                for (int m = 0; m < x; m++)
                    examIDCombo.Items.Add(arr[m]);
                examIDCombo.SelectedIndex = 0;
            }
            else
                MessageBox.Show("No Unset Exams present in the database.", "Error");
        }

        
        //
        //On click of Back button, navigates to Admin Home
        //
        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //
        //On click of Go button, passes selected Exam to Set Paper Form
        //
        private void go_Click(object sender, EventArgs e)
        {
            if (examIDCombo.SelectedIndex != -1)
            {
                Exam_Details d = new Exam_Details();
                d.exam_ID = examIDCombo.SelectedItem.ToString();
                d = ed.getExamDetails(d); 
                SetPaper f28 = new SetPaper(d);
                f28.MdiParent = this.MdiParent;
                f28.Dock = DockStyle.Fill; 
                this.Close();
                f28.Show();
            }
            else
                MessageBox.Show("Please select a valid Exam ID.", "Error");
        }

        private void selectExamLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
