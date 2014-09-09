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
    public partial class DeleteExamType : Form
    {
        Exam_TypeBS ed = new Exam_TypeBS();
        public DeleteExamType()
        {
            InitializeComponent();
        }


        //
        //Navigates back to the Admin home
        //
        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //
        //Deletes the selected Exam Type & pops up a Success or Error message
        //
        private void delete_Click(object sender, EventArgs e)
        {
            if (examTypeCombo.SelectedIndex != -1)
            {
                DialogResult result = MessageBox.Show("Are you sure you want delete " + examTypeCombo.SelectedItem.ToString() + "?", "Delete Exam Type", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Exam_Types r = new Exam_Types();
                    r.exam_Type = examTypeCombo.SelectedItem.ToString();
                    string feedback = ed.deleteExamType(r);
                    MessageBox.Show(feedback);
                }
            }
            else
                MessageBox.Show("Please select a valid Exam Type.");

            this.DeleteExamType_Load(sender, e);
        }


        //
        //Loads Exam Types to select for deletion
        //
        private void DeleteExamType_Load(object sender, EventArgs e)
        {
            
        	// to allign the Legend(Group Box) to
            // the center of form
		    int centerForm;
            int centerGroup;
            int groupStartPosition;

            centerForm = this.Width / 2;
            centerGroup = deleteExamTypeLegend.Width / 2;
            groupStartPosition = centerForm - centerGroup;
            deleteExamTypeLegend.Left = groupStartPosition; 
                
            examTypeCombo.Items.Clear();
            int i = ed.getCount();
            if (i > 0)
            {
                string[] abc = new string[i];
                abc = ed.loadExamType(i);
                for (int j = 0; j < i; j++)
                {
                    examTypeCombo.Items.Add(abc[j]);
                }
            }
            else
                MessageBox.Show("No Data");
            examTypeCombo.SelectedIndex = 0;
        }
    }
}
