using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entities2;
using Business1;

namespace WebApplication1.Account
{
    public partial class Login : Page
    {
        EmployeeBS b = new EmployeeBS();

        protected void Page_Load(object sender, EventArgs e)
        {
            // RegisterHyperLink.NavigateUrl = "Register";
            /*OpenAuthLogin.ReturnUrl = Request.QueryString["ReturnUrl"];

            var returnUrl = HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
            if (!String.IsNullOrEmpty(returnUrl))
            {
                RegisterHyperLink.NavigateUrl += "?ReturnUrl=" + returnUrl;
            }*/
        }

        protected void login_Click(object sender, EventArgs e)
        {
            Employee l = new Employee();
            l.employee_Id = UserName.Text.ToString();
            l.password = Password.Text.ToString();

            if (adminRadioButton.Checked)
            {
                l.type = 1;
                string feed = b.validateLogin(l);
                if (feed.Equals("true"))
                {
                    Session["admin"] = l;
                    //AdminHome f = new AdminHome(l);
                    //this.MdiParent.Hide();
                    //this.Close();
                    //f.Show();
                    Response.Redirect("~/AdminHome.aspx");
                }
                else
                {
                    System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('login error')</SCRIPT>");
                }
            }
            else if (employeeRadioButton.Checked)
            {
                l.type = 2;
                string feed = b.validateLogin(l);
                if (feed.Equals("true"))
                {
                    Session["employee"] = l;
                    /*ParentForm f2 = new ParentForm(l);
                    this.MdiParent.Hide();
                    this.Close();
                    f2.Show();*/
                    Response.Redirect("~/EmpHome.aspx");
                }
                else
                {
                    System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('login error')</SCRIPT>");
                }
            }
        }
    }
}