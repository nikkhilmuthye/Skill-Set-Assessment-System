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
    public partial class AddApplicant : System.Web.UI.Page
    {
        ResultsBS js = new ResultsBS();
        Exam_DetailsBS edb = new Exam_DetailsBS();
        Exam_TypeBS etbs = new Exam_TypeBS();

        protected void Page_Load(object sender, EventArgs e)
        {
            //Exam IDs
            Exam_DetailsBS em = new Exam_DetailsBS();
            int i = em.getCount();
            if (i > 0)
            {
                string[] abc = new string[i];
                abc = em.loadExamDetail(i);
                for (int m = 0; m < i; m++)
                {
                    examIDCombo.Items.Add(abc[m]);
                }
                examIDCombo.SelectedIndex = 0;
            }
            
            //Employee IDs
            EmployeeBS emp = new EmployeeBS();
            int j = emp.getCount();
            if (j > 0)
            {
                string[] abcd = new string[j];
                abcd = emp.loadEmployee(j);
                for (int k = 0; k < j; k++)
                {
                    employeeIDCombo.Items.Add(abcd[k]);
                }
                employeeIDCombo.SelectedIndex = 0;
            }
        }

        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AdminHome.aspx");
        }

        //
        //On click of Add button, validates and adds applicants
        //
       
    }
}