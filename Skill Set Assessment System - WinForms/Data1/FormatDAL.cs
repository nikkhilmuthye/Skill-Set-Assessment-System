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
    public class FormatDAL
    {
        /*public string[] loadFormat(int i)
        {

            SqlConnection cnNorth;
            SqlCommand cmdProducts;
            SqlDataReader dreadProducts;

            string constr = @"Server=NIKKHIL-HP\sqlexpress;Integrated Security=true; database=OnlineExamination";
            cnNorth = new SqlConnection(constr);

            string[] abc = new string[i];

            cnNorth = new SqlConnection(constr);
            cmdProducts = new SqlCommand("select Format from Format", cnNorth);
            cnNorth.Open();
            dreadProducts = cmdProducts.ExecuteReader();
            int j = 0;

            while (dreadProducts.Read())
            {
                abc[j] = dreadProducts["Format"].ToString();
                j++;

            }

            dreadProducts.Close();
            return abc;

        }
        public int getCount()
        {
            SqlConnection cnNorth;
            SqlCommand cmdProducts;
            SqlDataReader dreadProducts;

            string constr = @"Server=NIKKHIL-HP\sqlexpress;Integrated Security=true; database=OnlineExamination";
            cnNorth = new SqlConnection(constr);
            cmdProducts = new SqlCommand("select Format from Format", cnNorth);
            cnNorth.Open();
            dreadProducts = cmdProducts.ExecuteReader();
            int i = 0;

            while (dreadProducts.Read())
            {

                i++;

            }
            cnNorth.Close();
            return i;

        }
        public Exam_Types getExamType(int index)
        {
            string constr = @"Server=NIKKHIL-HP\sqlexpress;Integrated Security=true; database=OnlineExamination";
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommandBuilder sb = new SqlCommandBuilder(da);
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            SqlTransaction tran = conn.BeginTransaction();
            String sql = "Select * from Exam_Types";
            da.SelectCommand = new SqlCommand(sql, conn, tran);
            DataSet ds = new DataSet();
            da.Fill(ds, "Exam_Types");
            DataTable dt = ds.Tables["Exam_Types"];

            Exam_Types et = new Exam_Types();
            DataRow dr = dt.Rows[index];
            dr = dt.Rows[index];
            Object[] abc = new Object[4];
            abc = dr.ItemArray;
            et.exam_Type = (string)abc.ElementAt(0);
            et.subject = (string)abc.ElementAt(1);
            et.level_Number = (int)abc.ElementAt(2);
            et.no_Of_Attempts = (int)abc.ElementAt(3);
            conn.Close();
            return et;

        }
        */


    }
}
