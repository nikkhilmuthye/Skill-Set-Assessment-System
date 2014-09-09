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
    public partial class ChooseEmployee : Form
    {
        ResultsBS r = new ResultsBS();
        EmployeeBS ed = new EmployeeBS();
            

        public ChooseEmployee()
        {
            InitializeComponent();
        }


        //
        //On form Load: Loads Employees:
        //
        private void ChooseEmployee_Load(object sender, EventArgs e)
        {
            
            // to allign the Legend(Group Box) to
            // the center of form
		    int centerForm;
            int centerGroup;
            int groupStartPosition;

            centerForm = this.Width / 2;
            centerGroup = employeeResultLabel.Width / 2;
            groupStartPosition = centerForm - centerGroup;
            employeeResultLabel.Left = groupStartPosition; 
            
            int i = ed.getCount();
            if (i > 0)
            {
                string[] abc = new string[i];
                abc = ed.loadEmployee(i);
                for (int j = 0; j < i; j++)
                {
                    employeeIDCombo.Items.Add(abc[j]);
                }
            }
            else
                MessageBox.Show("No Employees present in the database", "Error");
        }


        //
        //On click on Check button: Validates selection & Naviagtes to Check Employee Result Form
        //
        private void check_Click(object sender, EventArgs e)
        {
            if (employeeIDCombo.SelectedIndex != -1)
            {
                string temp;
                Results ro = new Results();
                temp = employeeIDCombo.SelectedItem.ToString();
                ro.employee_ID = temp.Substring(0, 4);
                CheckEmployeeResult f28 = new CheckEmployeeResult(ro);
                this.Close();
                f28.Show();
            }
            else
                MessageBox.Show("Please select a valid Employee ID.", "Error");
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
