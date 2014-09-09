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
    public partial class CheckEmployeeResult : Form
    {
        Results ed=new Results();
        ResultsBS p = new ResultsBS();

        public CheckEmployeeResult(Results ro)
        {
            InitializeComponent();
            ed = ro;
        }


        //
        //On click of Back button, navaigtes to Admin Home
        //
        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //
        //On Form Load: Displays Result in Grid
        //
        private void CheckEmployeeResult_Load(object sender, EventArgs e)
        {
            

            // to allign the Legend(Group Box) to
            // the center of form
		    int centerForm;
            int centerGroup;
            int groupStartPosition;

            centerForm = this.Width / 2;
            centerGroup = checkEmpResultLegend.Width / 2;
            groupStartPosition = centerForm - centerGroup;
            checkEmpResultLegend.Left = groupStartPosition;
 

            employeeIDText.Text = ed.employee_ID;
            int count = p.getResultCountForEmployee(ed);
            if (count > 0)
            {
                Results[] arr = new Results[count];
                arr = p.viewResultForEmployee(ed,count);
                resultDataGrid.DataSource = arr;
                resultDataGrid.Enabled = false;
            }
            else
                MessageBox.Show("No Results present in the database.", "Error");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void resultDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void employeeIDText_TextChanged(object sender, EventArgs e)
        {

        }

        private void employeeIDLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
