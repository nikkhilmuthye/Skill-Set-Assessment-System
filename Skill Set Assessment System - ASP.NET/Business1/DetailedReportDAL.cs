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
    public class DetailedReportDAL
    {
        SqlConnection conn = new SqlConnection(@"Server=sony-vaio\sqlexpress;Integrated Security=true; database=OnlineExamination");
        SqlCommand cmd;
        SqlDataReader dread;

        //
        //Returns the number of Results for a Detailed Report for a particular Exam
        //
        public int getResultCountForDetailedReport(Results p)
        {
            conn.Open();
            cmd = new SqlCommand("select count(Employee_ID) from DetailedReports where Exam_ID ='" + p.exam_ID + "'", conn);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return count;
        }


        //
        //Returns detailed results for a particular Exam
        //
        public DetailedReports[] getDetailedReports(Results s, int count)
        {
            DetailedReports[] arr = new DetailedReports[count];
            conn.Open();
            cmd = new SqlCommand("select Employee_ID, Exam_ID, Section,Percentage from DetailedReports where Exam_ID ='" + s.exam_ID + "'", conn);
            dread = cmd.ExecuteReader();
            for (int i = 0; i < count; i++)
            {
                if (dread.Read())
                {
                    arr[i] = new DetailedReports();
                    arr[i].employee_ID = dread[0].ToString();
                    arr[i].exam_ID = dread[1].ToString();
                    arr[i].section = dread[2].ToString();
                    arr[i].percentage = Convert.ToSingle(dread[3].ToString());
                }
            }
            dread.Close();
            conn.Close();
            return arr;
        }
    }
}
