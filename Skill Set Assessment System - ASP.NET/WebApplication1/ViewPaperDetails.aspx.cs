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
    public partial class ViewPaperDetails : System.Web.UI.Page
    {
        Paper ed = new Paper();
        PaperBS p = new PaperBS();

        protected void Page_Load(object sender, EventArgs e)
        {
            ed.exam_ID = (String)Session["exam_ID"];
            examIDText.Text = ed.exam_ID;
            int count = p.getRowCountForExam(ed);
            Paper[] arr = new Paper[count];
            arr = p.viewPaperDetails(ed, count);
            paperDataGrid.DataSource = arr;
            paperDataGrid.Enabled = false;
            //paperDataGrid.EnableHeadersVisualStyles = true;
            //paperDataGrid.GridColor = Color.DarkRed;
        }

        //
        //On click of Back button, navigates to Admin Home
        //
        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AdminHome.aspx");
        }


    }
}