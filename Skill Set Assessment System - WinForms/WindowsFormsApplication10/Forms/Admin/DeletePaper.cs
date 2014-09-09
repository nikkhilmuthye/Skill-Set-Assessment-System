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
    public partial class DeletePaper : Form
    {
        PaperBS ed = new PaperBS();
            
        public DeletePaper()
        {
            InitializeComponent();
        }


        //
        //Deletes the selected Exam & pops up a Success or Error message
        //
        private void DeletePaper_Load(object sender, EventArgs e)
        {
            
        	// to allign the Legend(Group Box) to
            // the center of form
		    int centerForm;
            int centerGroup;
            int groupStartPosition;

            centerForm = this.Width / 2;
            centerGroup = deletePaperLegend.Width / 2;
            groupStartPosition = centerForm - centerGroup;
            deletePaperLegend.Left = groupStartPosition;     
                
            examIDCombo.Items.Clear();
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
                MessageBox.Show("There are no exams in the database for which paper have been set.","Error");
         }


        //
        //Navigates back to the Admin home
        //
        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //
        //Loads Exam IDs to select for deletion
        //
        private void delete_Click(object sender, EventArgs e)
        {
            if (examIDCombo.SelectedIndex != -1)
            {
                Paper b = new Paper();
                b.exam_ID = examIDCombo.SelectedItem.ToString();
                DialogResult result = MessageBox.Show("Are you sure you want delete " + examIDCombo.SelectedItem.ToString() + "?", "Delete Exam Type", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string abc = ed.deletePaper(b);
                    MessageBox.Show(abc,"Delete Paper");
                }
            }
            else
                MessageBox.Show("Please select a valid Exam ID.","Error");

            this.DeletePaper_Load(sender, e);
        }
    }
}
