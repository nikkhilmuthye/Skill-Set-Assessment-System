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
    public partial class DeleteApplicant : System.Web.UI.Page
    {
        ResultsBS em = new ResultsBS();

        protected void Page_Load(object sender, EventArgs e)
        {
            empIDexamIDcombo.Items.Clear();
            int i = em.getCount();
            if (i > 0)
            {
                string[] abc = new string[i];
                abc = em.loadApplicants(i);
                for (int m = 0; m < i; m++)
                {
                    empIDexamIDcombo.Items.Add(abc[m]);
                }
            }
            else
                System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('No Applicants present in the datavase.')</SCRIPT>");
                //MessageBox.Show("No Applicants present in the datavase.");
            empIDexamIDcombo.SelectedIndex = 0;
        }

        //
        //Deletes the selected Exam & pops up a Success or Error message
        //
        protected void delete_Click(object sender, EventArgs e)
        {
            if (empIDexamIDcombo.SelectedIndex != -1)
            {
                //DialogResult result = MessageBox.Show("Are you sure you want delete " + empIDexamIDcombo.SelectedItem.ToString() + "?", "Delete Applciant", MessageBoxButtons.YesNo);
                
                    //Results Object
                    Results r = new Results();
                    string temp = empIDexamIDcombo.SelectedItem.ToString();
                    int pos = temp.IndexOf(":");
                    r.employee_ID = temp.Substring(0, pos);
                    r.exam_ID = temp.Substring(pos + 1);

                    //Gets Exam type
                    Exam_Details ed = new Exam_Details();
                    ed.exam_ID = r.exam_ID;
                    Exam_DetailsBS edb = new Exam_DetailsBS();
                    ed = edb.getExamDetails(ed);

                    //ResultStatus object
                    ResultStatus rs = new ResultStatus();
                    rs.employee_ID = r.employee_ID;
                    rs.exam_Type = ed.exam_Type;

                    //Gets Attempt No
                    ResultStatusBS rsb = new ResultStatusBS();
                    rs = rsb.getResultStatus(rs);

                    if (rs.attempt_No == 1)
                    {
                        //First Timer
                        string feedback = em.deleteResults(r);
                        if (feedback != "Error")
                        {
                            rsb.deleteResultStatus(rs);
                            System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('Succesfully deleted.')</SCRIPT>");
                            //essageBox.Show("Succesfully deleted.", "Delete Applicant", MessageBoxButtons.OK);
                        }
                        else
                            System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('Unsuccessful attempt. Sorry for the inconvenience')</SCRIPT>");
                            //MessageBox.Show("Unsuccessful attempt. Sorry for the inconvenience.", "Error", MessageBoxButtons.OK);
                    }
                    else
                    {
                        //Repeater
                        rs.attempt_No--;
                        string feedback = em.deleteResults(r);
                        if (feedback != "Error")
                        {
                            rsb.updateResultStatus(rs);
                            System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('Succesfully deleted.')</SCRIPT>");
                            //MessageBox.Show("Succesfully deleted.", "Delete Applicant", MessageBoxButtons.OK);
                        }
                        else
                            System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('Unsuccessful attempt. Sorry for the inconvenience')</SCRIPT>");
                            //MessageBox.Show("Unsuccessful attempt. Sorry for the inconvenience.", "Error", MessageBoxButtons.OK);
                    }
            }
            else
                System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('Please select a valid entry')</SCRIPT>");
                //MessageBox.Show("Please select a valid entry.", "Error");
            this.Page_Load(sender, e);
        }


        //
        //Navigates back to the Admin home
        //
        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AdminHome.aspx");
        }
    }
}