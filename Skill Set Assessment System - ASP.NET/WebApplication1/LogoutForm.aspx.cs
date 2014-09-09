using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business1;
using Entities2;

namespace WebApplication1
{
    public partial class LogoutForm : System.Web.UI.Page
    {
        public Employee emp = new Employee();
        public Exam_Details ed = new Exam_Details();


        protected void Page_Load(object sender, EventArgs e)
        {
            emp = (Employee)Session["employee"];
            ed = (Exam_Details)Session["exam"];

            employeeNameLabel.Text = emp.first_Name + " " + emp.last_Name;
            examLabel.Text += ed.exam_ID;

        }

        protected void logout_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Login.apsx");
        }
    }
}