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
    public partial class ViewPaper : Form
    {
        PaperBS ed = new PaperBS();
        
    
        public ViewPaper()
        {
            InitializeComponent();
        }


        //
        //On click of Back button, navigates to Admin Home
        //
        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //
        //On Form Load: Loads Exam ID ComboBox
        //
        private void ViewPaper_Load(object sender, EventArgs e)
        {
            
        	// to allign the Legend(Group Box) to
            // the center of form
		    int centerForm;
            int centerGroup;
            int groupStartPosition;

            centerForm = this.Width / 2;
            centerGroup = viewPaperLegend.Width / 2;
            groupStartPosition = centerForm - centerGroup;
            viewPaperLegend.Left = groupStartPosition; 
            
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
            {
                MessageBox.Show("No set papers are present in the database.","Error");
                examIDCombo.Enabled = false;
                view.Enabled = false;
            }
        }


        //
        //On click on View button: Opens the ViewPaperDetails Form, displaying the Paper
        //
        private void view_Click(object sender, EventArgs e)
        {
            if (examIDCombo.SelectedIndex != -1)
            {
                Paper p = new Paper();
                p.exam_ID = examIDCombo.SelectedItem.ToString();
                ViewPaperDetails f = new ViewPaperDetails(p);
                f.MdiParent = this.MdiParent;
                f.Dock = DockStyle.Fill;
                this.Close();
                f.Show();
            }
            else
                MessageBox.Show("Please select a valid Exam ID.", "Error");
        }
    }
}
