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
    public partial class SeeResult : Form
    {
        Results ed = new Results();
        ResultsBS p = new ResultsBS();
            
        public SeeResult(Results e)
        {
            InitializeComponent();
            ed = e;
        }


        //
        //On Form Load: Displays Result in Grid
        //
        private void SeeResult_Load(object sender, EventArgs e)
        {
            // to allign the Legend(Group Box) to
            // the center of form
            int centerForm;
            int centerGroup;
            int groupStartPosition;

            centerForm = this.Width / 2;
            centerGroup = seeResultLegend.Width / 2;
            groupStartPosition = centerForm - centerGroup;
            seeResultLegend.Left = groupStartPosition; 

            Exam_Details feed = p.calculateResultFull(ed);

            if (feed.exam_ID == "ED00")
            {
                MessageBox.Show("Exam was conducted today. So please checlk the result tomorrow. Thank You!");
            }
            else if (feed.exam_ID == "ED000")
            {
                MessageBox.Show("Sorry some error occured! Please try later!");
            }
            else
            {
                highestlabel.Text = "Highest:" + feed.highest;
                lowestlabel.Text = "Lowest: " + feed.lowest;
                averagelabel.Text = "Average: " + feed.average;

                examIDText.Text = ed.exam_ID;
                int count = p.getResultCountForExam(ed);
                if (count > 0)
                {
                    Results[] arr = new Results[count];
                    arr = p.viewResult(ed);
                    resultDataGrid.DataSource = arr;
                    resultDataGrid.Enabled = false;
                }
                else
                    MessageBox.Show("No Results present in the database.", "Error");
            }
        }

        
        //
        //On click of Back button, navaigtes to Admin Home
        //
        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
