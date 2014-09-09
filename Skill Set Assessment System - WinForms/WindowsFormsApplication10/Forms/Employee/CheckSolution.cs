using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entities2;
using Business1;


namespace WindowsFormsApplication10
{
    public partial class CheckSolution : Form
    {
        Questions[] q;
        Answers[] a;
        Employee emp = new Employee();
        Exam_Details ed = new Exam_Details();
        
        public CheckSolution(Questions[] q1, Answers[] a1, Employee e1, Exam_Details ed1)
        {
            InitializeComponent();
            q = q1;
            a = a1;
            emp = e1;
            ed = ed1;
        }

        private void CheckSolution_Load(object sender, EventArgs e)
        {
            solutionGridView.Show();
            solutionGridView.Rows.Add(q.Length);
            DataGridViewRow drow;
            for (int i = 0; i < q.Length; i++)
            {
                drow = solutionGridView.Rows[i];
                drow.Cells[0].Value = (i + 1);
                drow.Cells[1].Value = q[i].question;
                string ans = "", a2 = "";
                switch (q[i].format)
                {
                    case "Match The Column":
                        drow.Cells[2].Value = q[i].solution;
                        drow.Cells[3].Value = a[i].answer;
                        break;
                        

                    case "MCQ (Single Answer)":
                        switch (q[i].solution)
                        {
                            case "1":
                                drow.Cells[2].Value = q[i].option1;
                                break;
                            case "2":
                                drow.Cells[2].Value = q[i].option2;
                                break;
                            case "3":
                                drow.Cells[2].Value = q[i].option3;
                                break;
                            case "4":
                                drow.Cells[2].Value = q[i].option4;
                                break;
                        }
                        switch (a[i].answer)
                        {
                            case "1":
                                drow.Cells[3].Value = q[i].option1;
                                break;
                            case "2":
                                drow.Cells[3].Value = q[i].option2;
                                break;
                            case "3":
                                drow.Cells[3].Value = q[i].option3;
                                break;
                            case "4":
                                drow.Cells[3].Value = q[i].option4;
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
                        drow.Cells[2].Value = a2;

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
                        drow.Cells[3].Value = a2;
                        break;
                        

                    case "Picture Question: Single Answer":
                        switch (q[i].solution)
                        {
                            case "1":
                                drow.Cells[2].Value = q[i].option1;
                                break;
                            case "2":
                                drow.Cells[2].Value = q[i].option2;
                                break;
                            case "3":
                                drow.Cells[2].Value = q[i].option3;
                                break;
                            case "4":
                                drow.Cells[2].Value = q[i].option4;
                                break;
                        }
                        switch (a[i].answer)
                        {
                            case "1":
                                drow.Cells[3].Value = q[i].option1;
                                break;
                            case "2":
                                drow.Cells[3].Value = q[i].option2;
                                break;
                            case "3":
                                drow.Cells[3].Value = q[i].option3;
                                break;
                            case "4":
                                drow.Cells[3].Value = q[i].option4;
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
                        drow.Cells[2].Value = a2;

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
                        drow.Cells[3].Value = a2;
                        break;
                        
                }
            }
        }


        //
        //Navigates to Feedback Form
        //    
        private void Proceed_Click(object sender, EventArgs e)
        {
            FeedbackForm fm8 = new FeedbackForm(emp, ed);
            fm8.MdiParent = this.MdiParent;
            fm8.Dock = DockStyle.Fill;
            this.Close();
            fm8.Show();
        }
    }
}