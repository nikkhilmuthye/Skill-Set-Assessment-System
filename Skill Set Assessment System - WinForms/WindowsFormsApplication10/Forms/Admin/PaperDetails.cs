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
    public partial class ViewPaperDetails : Form
    {
        Paper ed = new Paper();
        PaperBS p = new PaperBS();


        //
        //Accepts the passed Paper from ViewPaper form  
        //
        public ViewPaperDetails(Paper e)
        {
            InitializeComponent();
            ed = e;
        }


        //
        //On Form Load: Loads Exam ID ComboBox
        //
        private void ViewPaperDetails_Load(object sender, EventArgs e)
        {
            
        	// to allign the Legend(Group Box) to
            // the center of form
		    int centerForm;
            int centerGroup;
            int groupStartPosition;

            centerForm = this.Width / 2;
            centerGroup = paperDetailsLegend.Width / 2;
            groupStartPosition = centerForm - centerGroup;
            paperDetailsLegend.Left = groupStartPosition;     
                
            examIDText.Text = ed.exam_ID;
            int count = p.getRowCountForExam(ed);
            Paper[] arr = new Paper[count];
            arr = p.viewPaperDetails(ed, count);
            paperDataGrid.DataSource = arr;
            paperDataGrid.Enabled = false;
            paperDataGrid.EnableHeadersVisualStyles = true;
            paperDataGrid.GridColor = Color.DarkRed;    
        }


        //
        //On click of Back button, navigates to View Paper Details Form
        //
        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
