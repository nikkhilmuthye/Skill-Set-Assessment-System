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
    public partial class DeleteQuestion : Form
    {
        QuestionsBS ed = new QuestionsBS();

        public DeleteQuestion()
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
        //Deletes the selected Question & pops up a Success or Error message
        //
        private void delete_Click(object sender, EventArgs e)
        {
            if (questionIDCombo.SelectedIndex != -1)
            {
                DialogResult result = MessageBox.Show("Are you sure you want delete " + questionIDCombo.SelectedItem.ToString() + "?", "Delete Question", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Questions q = new Questions();
                    string temp = questionIDCombo.SelectedItem.ToString();
                    int index = temp.IndexOf(":");
                    q.question_ID = temp.Substring(0, index - 1);
                    string feed = ed.deleteQuestion(q);
                    MessageBox.Show(feed);
                }
            }
            else
                MessageBox.Show("Please select a valid Question ID.");

            this.DeleteQuestion_Load(sender, e);
        }


        //
        //Loads Question Nos to select for deletion
        //
        private void DeleteQuestion_Load(object sender, EventArgs e)
        {
            
        	// to allign the Legend(Group Box) to
            // the center of form
		    int centerForm;
            int centerGroup;
            int groupStartPosition;

            centerForm = this.Width / 2;
            centerGroup = deleteQuestionLegend.Width / 2;
            groupStartPosition = centerForm - centerGroup;
            deleteQuestionLegend.Left = groupStartPosition;     
                
                
            questionIDCombo.Items.Clear();
            int i = ed.getCount();
            if (i > 0)
            {
                string[] abc = new string[i];
                abc = ed.loadQuestion(i);
                for (int j = 0; j < i; j++)
                {
                    questionIDCombo.Items.Add(abc[j]);
                }
            }
            else
                MessageBox.Show("No Data");
            questionIDCombo.SelectedIndex = 0;
        }
    }
}
