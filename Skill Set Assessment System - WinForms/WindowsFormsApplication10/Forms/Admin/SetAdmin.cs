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
    public partial class SetAdmin : Form
    {
        Employee[] earray;
        EmployeeBS eb = new EmployeeBS();

        public SetAdmin()
        {
            InitializeComponent();
        }

        private void SetAdmin_Load(object sender, EventArgs e)
        {
            
        	// to allign the Legend(Group Box) to
            // the center of form
		    int centerForm;
            int centerGroup;
            int groupStartPosition;

            centerForm = this.Width / 2;
            centerGroup = setAdminLegend.Width / 2;
            groupStartPosition = centerForm - centerGroup;
            setAdminLegend.Left = groupStartPosition; 
            
            
            int count = eb.getNonAdminCount();
            earray = new Employee[count];
            earray = eb.loadNonAdmins(count);
            for (int i = 0; i < count; i++)
            {
                listBox.Items.Add(earray[i].employee_Id + ": " + earray[i].first_Name + " " + earray[i].last_Name);
            }

            listBox.SelectionMode = SelectionMode.MultiSimple;

        }

        private void Set_Click(object sender, EventArgs e)
        {
            int count = listBox.SelectedIndices.Count;

            ListBox.SelectedIndexCollection l = listBox.SelectedIndices;
            Employee [] r = new Employee[count];
            for (int i = 0; i < count; i++)
            {
                r[i] = new Employee();
                r[i].employee_Id = earray[l[i]].employee_Id;
            }
            string feedback = eb.setAdmin(r);
            MessageBox.Show(feedback, "Set Admin", MessageBoxButtons.OK);
        }


        //
        //On click on Back button: Navigates to Admin Home
        //
        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
