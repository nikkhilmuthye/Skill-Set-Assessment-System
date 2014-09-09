using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using Entities2;

namespace Data1
{
    public class AnswersDAL
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\BE Project\Final Backup\WindowsFormsApplication10\Data1\Database2.mdf;Integrated Security=True");
        SqlDataAdapter da;
        SqlCommandBuilder cb;
        SqlTransaction tran;
        DataSet ds;
        DataTable dt;
        DataRow drow;
  

        //
        //Stores the answers in the Answer table, returns true if successful, else false
        //
        public bool submitAnswers(Answers [] a)
        {
            da = new SqlDataAdapter();
            cb = new SqlCommandBuilder(da);
            conn.Open();
            tran = conn.BeginTransaction();
            da.SelectCommand = new SqlCommand( "Select * from Answers", conn, tran);
            ds = new DataSet();
            da.Fill(ds, "Answers");
            dt = ds.Tables["Answers"];
            
            for (int i = 0; i < a.Length; i++)
            {
                drow = dt.NewRow();
                drow["Employee_ID"] = a[i].employee_Id;
                drow["Exam_ID"] = a[i].exam_ID;
                drow["Question_ID"] = a[i].question_ID;
                drow["Answer"] = a[i].answer;
                drow["Marks"] = a[i].marks;
                dt.Rows.Add(drow);
            }

            try
            {
                int updates = da.Update(ds, "Answers");
            }
            catch (Exception ex)
            {
                if (tran != null)
                {
                    tran.Rollback();
                    tran = null;
                    conn.Close();
                    return false;
                }
            }
            finally
            {
                if (tran != null)
                {
                    tran.Commit();
                    tran = null;
                }
            }
            conn.Close();
            return true;
        }
    }
}
