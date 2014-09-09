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
    public partial class FeedbackForm : System.Web.UI.Page
    {
        public Employee emp = new Employee();
        public Exam_Details ed = new Exam_Details();
        FeedbackBS f = new FeedbackBS();

        protected void Page_Load(object sender, EventArgs e)
        {
            emp = (Employee)Session["employee"];
            ed = (Exam_Details)Session["exam"];

            employeeNameLabel.Text = emp.first_Name + " " + emp.last_Name;
            examIDLabel.Text = "Exam ID:" + ed.exam_ID;

            for (int i = 0; i <= 5; i++)
            {
                comboBox1.Items.Add(i+"");
                comboBox2.Items.Add(i+"");
                comboBox3.Items.Add(i+"");
                comboBox4.Items.Add(i+"");
                comboBox5.Items.Add(i+"");
                comboBox1.SelectedIndex = comboBox2.SelectedIndex = comboBox3.SelectedIndex = comboBox4.SelectedIndex = comboBox5.SelectedIndex = 0;
            }
        }

        //
        //On click of Submit: Validates selection, stores feedback and navigates to Logout form
        //
        protected void submit_Click(object sender, EventArgs e)
        {

            if ((comboBox1.SelectedIndex == -1) || (comboBox2.SelectedIndex == -1) || (comboBox3.SelectedIndex == -1) || (comboBox4.SelectedIndex == -1) || (comboBox5.SelectedIndex == -1))
                System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('Some error! Please Check again!')</SCRIPT>");
                //MessageBox.Show("Please select a valid entry.", "Error");
            else
            {
                Feedback g = new Feedback();
                g.employee_ID = emp.employee_Id;
                g.exam_ID = ed.exam_ID;
                g.answer1 = Convert.ToInt32(comboBox1.SelectedItem.ToString());
                g.answer2 = Convert.ToInt32(comboBox2.SelectedItem.ToString());
                g.answer3 = Convert.ToInt32(comboBox3.SelectedItem.ToString());
                g.answer4 = Convert.ToInt32(comboBox4.SelectedItem.ToString());
                g.answer5 = Convert.ToInt32(comboBox5.SelectedItem.ToString());
                string feed = f.addFeedback(g);

                Session["employee"] = emp;
                Session["exam"] = ed;

                //MessageBox.Show(feed, "Feedback");

                /*LogoutForm fm9 = new LogoutForm(emp, ed);
                fm9.MdiParent = this.MdiParent;
                fm9.Dock = DockStyle.Fill;
                this.Close();
                fm9.Show();*/
                Response.Redirect("~/LogoutForm.aspx");
            }
        }
    }
}