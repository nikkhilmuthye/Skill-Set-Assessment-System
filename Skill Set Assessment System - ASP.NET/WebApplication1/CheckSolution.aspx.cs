using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entities2;
using Business1;
using System.Collections;
using System.Data;

namespace WebApplication1
{
    public partial class CheckSolution : System.Web.UI.Page
    {
        Questions[] q;
        Answers[] a;
        Employee emp = new Employee();
        Exam_Details ed = new Exam_Details();

        protected void Page_Load(object sender, EventArgs e)
        {
            q = (Questions[])Session["questions"];
            a = (Answers[])Session["answers"];
            emp = (Employee)Session["employee"];
            ed = (Exam_Details)Session["exam"];

            DataTable dt = new DataTable();
            dt.Columns.Add("No.", Type.GetType("System.Int32"));
            dt.Columns.Add("Question", Type.GetType("System.String"));
            dt.Columns.Add("Right Answer", Type.GetType("System.String"));
            dt.Columns.Add("Answer Marked", Type.GetType("System.String"));

            for (int i = 0; i < q.Length; i++)
            {
                dt.Rows.Add();
                dt.Rows[dt.Rows.Count - 1]["No."] = (i + 1);
                dt.Rows[dt.Rows.Count - 1]["Question"] = q[i].question;
                string ans = "", a2 = "";

                //dt.Rows[dt.Rows.Count - 1]["Right Answer"] = arr[i].score;
                //dt.Rows[dt.Rows.Count - 1]["Answer Marked"] = arr[i].percentage;

                switch (q[i].format)
                {
                    case "Match The Column":
                        dt.Rows[dt.Rows.Count - 1]["Right Answer"] = q[i].solution;
                        dt.Rows[dt.Rows.Count - 1]["Answer Marked"] = a[i].answer;
                        break;
                        

                    case "MCQ (Single Answer)":
                        switch (q[i].solution)
                        {
                            case "1":
                                dt.Rows[dt.Rows.Count - 1]["Right Answer"] = q[i].option1;
                                break;
                            case "2":
                                dt.Rows[dt.Rows.Count - 1]["Right Answer"] = q[i].option2;
                                break;
                            case "3":
                                dt.Rows[dt.Rows.Count - 1]["Right Answer"] = q[i].option3;
                                break;
                            case "4":
                                dt.Rows[dt.Rows.Count - 1]["Right Answer"] = q[i].option4;
                                break;
                        }
                        switch (a[i].answer)
                        {
                            case "1":
                                dt.Rows[dt.Rows.Count - 1]["Answer Marked"] = q[i].option1;
                                break;
                            case "2":
                                dt.Rows[dt.Rows.Count - 1]["Answer Marked"] = q[i].option2;
                                break;
                            case "3":
                                dt.Rows[dt.Rows.Count - 1]["Answer Marked"] = q[i].option3;
                                break;
                            case "4":
                                dt.Rows[dt.Rows.Count - 1]["Answer Marked"] = q[i].option4;
                                break;
                        }
                        break;
                        
                    case "MCQ (Multiple Answers)":
                        ans =  q[i].solution;
                        a2="";
                        if (ans.Contains("1"))
                            a2 += q[i].option1 + "  ";
                        if (ans.Contains("2"))
                            a2 += q[i].option2 + "  ";
                        if (ans.Contains("3"))
                            a2 += q[i].option3 + "  ";
                        if (ans.Contains("4"))
                            a2 += q[i].option4 + "  ";
                        dt.Rows[dt.Rows.Count - 1]["Right Answer"] = a2;

                        ans =  a[i].answer;
                        a2="";
                        if (ans.Contains("1"))
                            a2 += q[i].option1 + "  ";
                        if (ans.Contains("2"))
                            a2 += q[i].option2 + "  ";
                        if (ans.Contains("3"))
                            a2 += q[i].option3 + "  ";
                        if (ans.Contains("4"))
                            a2 += q[i].option4 + "  ";
                        dt.Rows[dt.Rows.Count - 1]["Answer Marked"] = a2;
                        break;
                        

                    case "Picture Question: Single Answer":
                        switch (q[i].solution)
                        {
                            case "1":
                                dt.Rows[dt.Rows.Count - 1]["Right Answer"] = q[i].option1;
                                break;
                            case "2":
                                dt.Rows[dt.Rows.Count - 1]["Right Answer"] = q[i].option2;
                                break;
                            case "3":
                                dt.Rows[dt.Rows.Count - 1]["Right Answer"] = q[i].option3;
                                break;
                            case "4":
                                dt.Rows[dt.Rows.Count - 1]["Right Answer"] = q[i].option4;
                                break;
                        }
                        switch (a[i].answer)
                        {
                            case "1":
                                dt.Rows[dt.Rows.Count - 1]["Answer Marked"] = q[i].option1;
                                break;
                            case "2":
                                dt.Rows[dt.Rows.Count - 1]["Answer Marked"] = q[i].option2;
                                break;
                            case "3":
                                dt.Rows[dt.Rows.Count - 1]["Answer Marked"] = q[i].option3;
                                break;
                            case "4":
                                dt.Rows[dt.Rows.Count - 1]["Answer Marked"] = q[i].option4;
                                break;
                        }
                        break;

                    case "Picture Question: Multiple Answer":
                        ans =  q[i].solution;
                        a2="";
                        if (ans.Contains("1"))
                            a2 += q[i].option1+"  ";
                        if (ans.Contains("2"))
                            a2 += q[i].option2 + "  ";
                        if (ans.Contains("3"))
                            a2 += q[i].option3 + "  ";
                        if (ans.Contains("4"))
                            a2 += q[i].option4 + "  ";
                        dt.Rows[dt.Rows.Count - 1]["Right Answer"] = a2;

                        ans =  a[i].answer;
                        a2="";
                        if (ans.Contains("1"))
                            a2 += q[i].option1 + "  ";
                        if (ans.Contains("2"))
                            a2 += q[i].option2 + "  ";
                        if (ans.Contains("3"))
                            a2 += q[i].option3 + "  ";
                        if (ans.Contains("4"))
                            a2 += q[i].option4 + "  ";
                        dt.Rows[dt.Rows.Count - 1]["Answer Marked"] = a2;
                        break;
                        
                }
            }
            GridView1.DataSource = dt;
            GridView1.Enabled = false;
            GridView1.DataBind();
        }

        //
        //Navigates to Feedback Form
        //    
        protected void Proceed_Click(object sender, EventArgs e)
        {
            Session["employee"] = emp;
            Session["exam"] = ed;
            Response.Redirect("~/FeedbackForm.aspx");
        }
    }
}