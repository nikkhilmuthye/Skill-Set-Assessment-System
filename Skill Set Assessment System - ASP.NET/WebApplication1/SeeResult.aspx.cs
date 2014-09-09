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
    public partial class SeeResult : System.Web.UI.Page
    {
        Results ed = new Results();
        ResultsBS p = new ResultsBS();
            
        protected void Page_Load(object sender, EventArgs e)
        {
            ed.exam_ID = (String)Session["exam_ID"];
            Exam_Details feed = p.calculateResultFull(ed);

            if (feed.exam_ID == "ED00")
            {
                System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('Exam was conducted today. So please checlk the result tomorrow. Thank You!')</SCRIPT>");
                //MessageBox.Show("Exam was conducted today. So please checlk the result tomorrow. Thank You!");
            }
            else if (feed.exam_ID == "ED000")
            {
                System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('Sorry some error occured! Please try later!')</SCRIPT>");
                //MessageBox.Show("Sorry some error occured! Please try later!");
            }
            else
            {
                highestlabel.Text = "Highest:" + feed.highest;
                lowestlabel.Text = "Lowest: " + feed.lowest;
                averagelabel.Text = "Average: " + feed.average;

                examIDText.Text = ed.exam_ID;
                int count = p.getResultCountForExam(ed);

                DataTable dt = new DataTable();
                dt.Columns.Add("Employee_ID", Type.GetType("System.String"));
                dt.Columns.Add("Exam_ID", Type.GetType("System.String"));
                dt.Columns.Add("Score", Type.GetType("System.Int32"));
                dt.Columns.Add("Percentage", Type.GetType("System.Double"));

                if (count > 0)
                {
                    Results[] arr = new Results[count];
                    arr = p.viewResult(ed);
                    for (int i = 0; i < count; i++)
                    {
                        dt.Rows.Add();
                        dt.Rows[dt.Rows.Count - 1]["Employee_ID"] = arr[i].employee_ID;
                        dt.Rows[dt.Rows.Count - 1]["Exam_ID"] = arr[i].exam_ID;
                        dt.Rows[dt.Rows.Count - 1]["Score"] = arr[i].score;
                        dt.Rows[dt.Rows.Count - 1]["Percentage"] = arr[i].percentage;
                    }
                    GridView1.DataSource = dt;
                    GridView1.Enabled = false;
                    GridView1.DataBind();
                }
                else
                    System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('No Results present in the database.')</SCRIPT>");
                //MessageBox.Show("No Results present in the database.", "Error");

            }
        }
    }
}