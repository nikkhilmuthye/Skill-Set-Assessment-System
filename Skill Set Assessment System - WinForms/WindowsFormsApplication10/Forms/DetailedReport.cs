using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business1;
using Entities2;

namespace WindowsFormsApplication10
{
    public partial class DetailedReport : Form
    {
        Results r = new Results();
        ResultsBS p = new ResultsBS();
        DetailedReportsBS re = new DetailedReportsBS();
        
        public DetailedReport(Results ro)
        {
            InitializeComponent();
            r = ro;
        }

        
        //
        //On click of Back button, navigates to Admin Home
        //
        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //
        //On form Load: Loads the detailed reports for the selected exam
        //
        private void DetailedReport_Load(object sender, EventArgs e)
        {
            examIDTextBox.Text = r.exam_ID;
            int count = re.getResultCountForDetailedReport(r);
            if (count > 0)
            {
                DetailedReports[] arr = new DetailedReports[count];
                arr = re.getDetailedReports(r, count);
                resultDataGrid.DataSource = arr;
                resultDataGrid.Enabled = false;
            }
            else
                MessageBox.Show("No Results present in the database.", "Error");
        }
    }
}
