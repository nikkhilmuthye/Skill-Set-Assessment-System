/*
 Naming
 related DAL
 minimization
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
    public partial class UpdateEmployee : Form
    {
        EmployeeBS ed = new EmployeeBS();
        public UpdateEmployee()
        {
            InitializeComponent();
        }


        //
        // On click of Back button, navaigtes to Admin Home
        //
        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //
        //On click of Update button
        //
        private void update_Click(object sender, EventArgs e)
        {
            if (employeeIDcombo.SelectedIndex == -1)
                MessageBox.Show("Please select a valid Employee ID", "Error");
            else
            {
                Employee em = new Employee();
                string temp2 = employeeIDcombo.SelectedItem.ToString();
                em.employee_Id = temp2.Substring(0, 4);
                em.last_Name = lastNameText.Text.ToString();
                em.first_Name = firstNameText.Text.ToString();
                em.birthdate = birthdatePicker.Value;
                em.hire_Date = hireDatePicker.Value;
                em.address = addressText.Text.ToString();
                em.city = cityText.Text.ToString();
                em.region = regionText.Text.ToString();
                string temp = postalCodeText.Text.ToString();
                //To prevent an exception for unentered number
                if (postalCodeText.TextLength == 0)
                    em.postalCode = 9999999;
                else
                    em.postalCode = Convert.ToInt32(postalCodeText.Text);
                em.country = countryLText.Text.ToString();
                em.mobile_Number = mobileNumberText.Text.ToString();

                //Business logic call, forwarded to DAL
                string feedback = ed.updateEmployee(em);
                MessageBox.Show(feedback, "Update Exam");
            }  
        }


        //
        //On Form Load
        //
        private void UpdateEmployee_Load(object sender, EventArgs e)
        {
            
            // to allign the Legend(Group Box) to
            // the center of form
		    int centerForm;
            int centerGroup;
            int groupStartPosition;

            centerForm = this.Width / 2;
            centerGroup = updateEmployeeLegend.Width / 2;
            groupStartPosition = centerForm - centerGroup;
            updateEmployeeLegend.Left = groupStartPosition;     
                
            // Filling the Employee ID ComboBox 
            int i = ed.getCount();
            if (i > 0)
            {
                string[] abc = new string[i];
                abc = ed.loadEmployee(i);
                for (int j = 0; j < i; j++)
                {
                    employeeIDcombo.Items.Add(abc[j]);
                }
            }
            else
                MessageBox.Show("No Data");
            //Disabling the other controls
            lastNameText.Enabled = false;
            firstNameText.Enabled = false;
            birthdatePicker.Enabled = false;
            hireDatePicker.Enabled = false;
            addressText.Enabled = false;
            cityText.Enabled = false;
            regionText.Enabled = false;
            postalCodeText.Enabled = false;
            mobileNumberText.Enabled = false;
            countryLText.Enabled = false;
            update.Enabled = false;
        }


        //
        //On changing the Employee ID
        //
        private void employeeIDc_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Resets the other controls on change of Employee ID, also disables then in case of an invalid selection
            lastNameText.Text = firstNameText.Text = addressText.Text = cityText.Text = regionText.Text = postalCodeText.Text = mobileNumberText.Text =  countryLText.Text= "";
            lastNameText.Enabled = false;
            firstNameText.Enabled = false;
            birthdatePicker.Enabled = false;
            hireDatePicker.Enabled = false;
            addressText.Enabled = false;
            cityText.Enabled = false;
            regionText.Enabled = false;
            postalCodeText.Enabled = false;
            mobileNumberText.Enabled = false;
            countryLText.Enabled = false;
            update.Enabled = false;

            if (employeeIDcombo.SelectedIndex != -1)
            {
                //Gets the details of the selected Employee
                Employee et = new Employee();
                string temp = employeeIDcombo.SelectedItem.ToString();
                int pos = temp.IndexOf(":");
                et.employee_Id = temp.Substring(0, pos);
                et = ed.getEmployee(et);
                
                //Enables the other controls
                lastNameText.Enabled = true;
                firstNameText.Enabled = true;
                birthdatePicker.Enabled = true;
                hireDatePicker.Enabled = true;
                addressText.Enabled = true;
                cityText.Enabled = true;
                regionText.Enabled = true;
                postalCodeText.Enabled = true;
                mobileNumberText.Enabled = true;
                countryLText.Enabled = true;
                update.Enabled = true;

                //Loads the Employee Details
                lastNameText.Text = et.last_Name;
                firstNameText.Text = et.first_Name;
                birthdatePicker.Value = et.birthdate;
                hireDatePicker.Value = et.hire_Date;
                addressText.Text = et.address;
                cityText.Text = et.city;
                regionText.Text = et.region;
                postalCodeText.Text = et.postalCode + "";
                countryLText.Text = et.country;
                mobileNumberText.Text = et.mobile_Number;
            }
            else
                MessageBox.Show("Please select a valid Employee ID.");   
         }

    }
}
