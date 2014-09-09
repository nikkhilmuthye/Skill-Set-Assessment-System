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
    public partial class Tutorial : System.Web.UI.Page
    {
        public Employee emp = new Employee();
        public Exam_Details ed = new Exam_Details();

        protected void Page_Load(object sender, EventArgs e)
        {
            emp = (Employee)Session["employee"];
            ed = (Exam_Details)Session["exam"];
            nameLabel.Text = emp.first_Name + " " + emp.last_Name;
            examIDLabel.Text += ed.exam_ID;
        }

        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/EmpHome.aspx");
        }

        protected void proceed_Click(object sender, EventArgs e)
        {
            Session["employee"] = emp;
            Session["exam"] = ed;
            Response.Redirect("");
        }
    }
}