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
    public partial class SelectUpdatePaper : Form
    {
        PaperBS ed = new PaperBS();
        Exam_DetailsBS d = new Exam_DetailsBS();
        

        public SelectUpdatePaper()
        {
            InitializeComponent();
        }


        //
        //On Loading of Form, loads Exam IDs for which papers have been set
        //
        private void SelectUpdatePaper_Load(object sender, EventArgs e)
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

            int i = ed.getSetPaperCount();
            if (i > 0)
            {
                string[] abc = new string[i];
                abc = ed.loadSetExamID(i);
                for (int j = 0; j < i; j++)
                {
                    examIDCombo.Items.Add(abc[j]);
                }
                examIDCombo.SelectedIndex = 0;
            }
            else
                MessageBox.Show("No Paper has been set yet.");           
        }


        //
        //On click of Back button, navigates to Admin Home
        //
        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //
        //On click of Go button, passes selected Exam to Update Paper Form
        //
        private void go_Click(object sender, EventArgs e)
        {  
            if (examIDCombo.SelectedIndex != -1)
            {   
                Exam_Details ed = new Exam_Details();
                ed.exam_ID = examIDCombo.SelectedItem.ToString();
                ed= d.getExamDetails(ed);
                UpdatePaper f28 = new UpdatePaper(ed);
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
