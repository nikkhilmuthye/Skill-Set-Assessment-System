using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entities2;
using Business1;

namespace WebApplication1
{
    public partial class AddEmployee : System.Web.UI.Page
    {
        public string myMessageFromCodeBehind;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //
        //On click of Add button, validates, adds Employee & displays assigned Employee ID
        //
        protected void register_Click(object sender, EventArgs e)
        {
            
            Employee emp = new Employee();
            emp.first_Name = firstNameText.Text.ToString();
            emp.last_Name = lastNameText.Text.ToString();
            emp.birthdate = DateTime.Parse(Request.Form[birthdatePicker.UniqueID]);
            emp.hire_Date = DateTime.Parse(Request.Form[hireDatePicker.UniqueID]);
            emp.address = addressText.Text.ToString();
            emp.city = cityText.Text.ToString();
            emp.region = regionText.Text;
            string temp = emp.birthdate + "";
            emp.password = temp.Substring(0, 10);
            if (postalCodeText.Text.Length == 0)
                emp.postalCode = 9999999;
            else
                emp.postalCode = Convert.ToInt32(postalCodeText.Text);
            emp.country = countryText.Text.ToString();
            emp.mobile_Number = mobileText.Text.ToString();
            emp.password = passwordText.Text.ToString();
            string confirm = confirmPasswordText.Text.ToString();
            emp.type = 2;
            EmployeeBS cs = new EmployeeBS();
            string feedback = cs.addEmployee(emp, confirm);
            if (feedback.Contains("successfully"))
            {
                /*DialogResult result = MessageBox.Show(feedback + "   Click Ok to go to Home Page. Click Cancel to Logout", "Add Employee", MessageBoxButtons.OKCancel);
                //if (result == DialogResult.OK)
                //{
                    //    EmpHome f = new EmpHome(emp);
                    //    this.Close();
                    //    f.Show();
                    //ParentForm f = new ParentForm(emp);
                    //this.Close();
                    //f.Show();
                //}
                else if (result == DialogResult.Cancel)
                {
                    Application.Exit();
                }*/
                Response.Redirect("~/EmpHome.aspx");
            }
            else
                myMessageFromCodeBehind = feedback;
                //ScriptManager.RegisterStartupScript(this, GetType(), "displayalertmessage", "showMessage({0});",    true);
                       //ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", feedback);
                //ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert(feedback);", true);
                //System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('Some error! Please Check again!')</SCRIPT>");
                //MessageBox.Show(feedback, "Error", MessageBoxButtons.OK);

        }

        //
        //On click on Back button: Navigates to Admin Home
        //
        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Login.aspx");
        }
    }
}