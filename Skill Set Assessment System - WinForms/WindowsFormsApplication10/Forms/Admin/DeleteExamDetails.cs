/*
 naming
 minimization
 related DAL
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
    public partial class DeleteExamDetail : Form
    {
        Exam_DetailsBS ed = new Exam_DetailsBS();

        public DeleteExamDetail()
        {
            InitializeComponent();
        }

        //
        //Loads Exam IDs to select for deletion
        //
        private void DeleteExamDetail_Load(object sender, EventArgs e)
        {
            
        	// to allign the Legend(Group Box) to
           // the center of form
		    int centerForm;
            int centerGroup;
            int groupStartPosition;

            centerForm = this.Width / 2;
            centerGroup = deleteExamLegend.Width / 2;
            groupStartPosition = centerForm - centerGroup;
            deleteExamLegend.Left = groupStartPosition;     
            examIDCombo.Items.Clear();
            int i = ed.getCount();
            if (i > 0)
            {
                string[] abc = new string[i];
                abc = ed.loadExamDetail(i);
                for (int j = 0; j < i; j++)
                {
                    examIDCombo.Items.Add(abc[j]);
                }
            }
            else
                MessageBox.Show("No Data");
            examIDCombo.SelectedIndex = 0;
        }


        //
        //Navigates back to the Admin home
        //
        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //
        //Deletes the selected Exam & pops up a Success or Error message
        //
        private void delete_Click(object sender, EventArgs e)
        {   
            if (examIDCombo.SelectedIndex != -1)
            {
                DialogResult result = MessageBox.Show("Are you sure you want delete exam " + examIDCombo.SelectedItem.ToString() + "?", "Delete Exam",MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Exam_Details r = new Exam_Details();
                    r.exam_ID = examIDCombo.SelectedItem.ToString();
                    string feedback = ed.deleteExamDetails(r);
                    MessageBox.Show(feedback);
                }
            }
            else
                MessageBox.Show("Please select a valid entry.", "Error");

            this.DeleteExamDetail_Load(sender, e);
        }
    }
}
