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
    public partial class SetAdmin : System.Web.UI.Page
    {
        Employee[] earray;
        EmployeeBS eb = new EmployeeBS();

        protected void Page_Load(object sender, EventArgs e)
        {
            int count = eb.getNonAdminCount();
            earray = new Employee[count];
            earray = eb.loadNonAdmins(count);
            for (int i = 0; i < count; i++)
            {
                listBox.Items.Add(earray[i].employee_Id + ": " + earray[i].first_Name + " " + earray[i].last_Name);
            }

            //listBox.SelectionMode = SelectionMode.MultiSimple;
        }

        protected void Set_Click(object sender, EventArgs e)
        {
            int count = 0, i = 0;
            //int count = listBox.SelectedIndices.Count;
            //Employee[] r;
            //listBox.Items.CopyTo(r,0);
            foreach (ListItem l in listBox.Items)
            {
                if (l.Selected)
                    count++;
            }
            Employee[] r = new Employee[count];
            String h = count + "";

            //l1.Text = h;
            //System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert(h)</SCRIPT>");
            //int c = count.Count();

            /*for (int i = 0; i( < count.Count(); i++)
            {
                r[i] = new Employee();
                r[i].employee_Id = earray[listBox.Items.[i]].employee_Id;
            }*/
            foreach (ListItem li in listBox.Items)
            {
                if (li.Selected)
                {
                    r[i] = new Employee();
                    r[i].employee_Id = li.Value;
                    i++;
                }
            }
            string feedback = eb.setAdmin(r);
            System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('Successfully')</SCRIPT>");
            //MessageBox.Show(feedback, "Set Admin", MessageBoxButtons.OK);
        }


        //
        //On click on Back button: Navigates to Admin Home
        //
        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AdminHome.aspx");
        }
    }
}