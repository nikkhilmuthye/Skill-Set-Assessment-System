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
    public partial class DeleteEmployee : Form
    {
        public DeleteEmployee()
        {
            InitializeComponent();
        }

        EmployeeBS ed = new EmployeeBS();


        //
        //Navigates back to the Admin home
        //
        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //
        //Deletes the selected Employee & pops up a Success or Error message
        //
        private void delete_Click(object sender, EventArgs e)
        {

            if (employeeIDCombo.SelectedIndex != -1)
            {
                DialogResult result = MessageBox.Show("Are you sure you want delete " + employeeIDCombo.SelectedItem.ToString() + "?", "Delete Employee", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {   
                    Employee r = new Employee();
                    string temp = employeeIDCombo.SelectedItem.ToString();
                    int pos = temp.IndexOf(":");
                    r.employee_Id = temp.Substring(0, pos-1);
                    string feed = ed.deleteEmployee(r);
                    MessageBox.Show(feed);
                }
            }
            else
                MessageBox.Show("Please select a valid Employee ID.");

            this.DeleteEmployee_Load(sender, e);
        }


        //
        //Loads Employee IDs to select for deletion
        //
        private void DeleteEmployee_Load(object sender, EventArgs e)
        {
            

            // to allign the Legend(Group Box) to
            // the center of form
		    int centerForm;
            int centerGroup;
            int groupStartPosition;

            centerForm = this.Width / 2;
            centerGroup = deleteEmployeeLegend.Width / 2;
            groupStartPosition = centerForm - centerGroup;
            deleteEmployeeLegend.Left = groupStartPosition; 
            employeeIDCombo.Items.Clear();
            int i = ed.getCount();
            if (i > 0)
            {
                string[] abc = new string[i];
                abc = ed.loadEmployee(i);
                for (int j = 0; j < i; j++)
                {
                    employeeIDCombo.Items.Add(abc[j]);
                }
                employeeIDCombo.SelectedIndex = 0;
            }
            else
                MessageBox.Show("No Data");
        }
    }
}
