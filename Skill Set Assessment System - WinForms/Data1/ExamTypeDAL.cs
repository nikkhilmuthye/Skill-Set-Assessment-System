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
    public class ExamTypeDAL
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\BE Project\Final Backup\WindowsFormsApplication10\Data1\Database2.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dread;


        ////
        ////Returns the number of attempts for the exam_type in the results entity
        ////
        //public Exam_Types getNoOfAttempts(Exam_Types r)
        //{
        //    conn.Open();
        //    cmd = new SqlCommand("Select No_Of_Attempts from Exam_Types where Exam_Type='" + r.exam_Type + "'", conn);
        //    r.no_Of_Attempts = Convert.ToInt32(cmd.ExecuteScalar());
        //    conn.Close();
        //    return r;
        //}


        //
        //Adds Exam Type and returns assigned Exam Type (or Error Message)
        //
        public string addExamType(Exam_Types e)
        {
            e.exam_Type = this.getNext();
            try
            {
                conn.Open();
                cmd = new SqlCommand("Insert into Exam_Types(Exam_Type,Subject,Level_Number,No_Of_Attempts) values('" +e.exam_Type + "','" + e.subject + "'," + e.level_Number + "," + e.no_Of_Attempts + ")", conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if(i==1)
                    return "Exam Type was successfully added & assigned Exam Type " + e.exam_Type + ".";
                else
                    return "Some error occured. Sorry for the inconvenience."; 
            }
            catch (Exception ex)
            {
                conn.Close();
                return "Some error occured. Sorry for the inconvenience."; 
            }
        }


        //
        //Updates fields of Exam Type, returns Success or Error Message
        //
        public string updateExamType(Exam_Types e)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("Update Exam_Types SET Subject='" + e.subject + "',Level_Number=" + e.level_Number + ",No_Of_Attempts=" + e.no_Of_Attempts + " Where Exam_Type='" + e.exam_Type + "'", conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if(i==1)
                    return "Exam was successfully updated";
                else
                    return "Some error occured. Sorry for the inconvenience.";
            }
            catch (Exception ex)
            {
                conn.Close();
                return "Some error occured. Sorry for the inconvenience.";
            }
        }


        //
        //Returns an array containing all the Exam Types
        //
        public string[] loadExamType(int i)
        {
            string[] abc = new string[i];
            cmd = new SqlCommand("select Exam_Type from Exam_Types", conn);
            conn.Open();
            dread = cmd.ExecuteReader();
            int j = 0;
            while (dread.Read())
            {
                abc[j] = dread["Exam_Type"].ToString();
                j++;
            }
            dread.Close();
            conn.Close();
            return abc;
        }


        //
        //Returns number of Exam Types
        //
        public int getCount()
        {
            cmd = new SqlCommand("select count(Exam_Type) from Exam_Types", conn);
            conn.Open();
            int count = (int)cmd.ExecuteScalar();
            conn.Close();
            return count;
        }


        //
        // Gets the next Exam Type
        //
        public string getNext()
        {
            cmd = new SqlCommand("select Max(Exam_Type) from Exam_Types", conn);
            conn.Open();
            string id = (string)cmd.ExecuteScalar();
            int last = Convert.ToInt32(id.Substring(2, 3));
            last = last + 1;
            string lastmod;
            if (last >= 0 && last <= 9)
                lastmod = "00" + last;
            else if (last >= 10 && last <= 99)
                lastmod = "0" + last;
            else
                lastmod = last + "";
            string next = id.Substring(0, 2) + lastmod;
            conn.Close();
            return next;
        }


        //
        //Gets other fields of a Exam Type given the Exam Type
        //
        public Exam_Types getExamType(Exam_Types e)
        {
            conn.Open();
            cmd = new SqlCommand("select Subject, Level_Number, No_Of_Attempts from Exam_Types where Exam_Type ='"+e.exam_Type+"'", conn);
            dread = cmd.ExecuteReader();
            dread.Read();
            e.subject = dread[0].ToString();
            e.level_Number = Convert.ToInt32(dread[1]);
            e.no_Of_Attempts = Convert.ToInt32(dread[2]);
            dread.Close();
            conn.Close();
            return e;
        }


        //
        //Deletes an Exam  Type with given Exam Type, and returns a success or error message
        //
        public string deleteExamType(Exam_Types et)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("Delete Exam_Types where Exam_Type='" + et.exam_Type + "'", conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if(i==1)
                    return "Exam Type " + et.exam_Type + " is successfully deleted";
                else
                    return "Attempt unsuccessful. Sorry for the inconvenience."; 
            }
            catch (Exception ex)
            {
                conn.Close();
                return "Attempt unsuccessful. Sorry for the inconvenience."; 
            }
        }

        /*public Exam_Types getExamTypeU(Exam_Types et)
        {
            SqlConnection cnNorth;
            SqlCommand cmdProducts;
            SqlDataReader dreadProducts;

            string constr = @"Server=NIKKHIL-HP\sqlexpress;Integrated Security=true; database=OnlineExamination";
            cnNorth = new SqlConnection(constr);
            cmdProducts = new SqlCommand("select * from Exam_Types Where Exam_Type='" + et.exam_Type + "'", cnNorth);
            cnNorth.Open();
            dreadProducts = cmdProducts.ExecuteReader();
            int i = 0;
            //Employee et = new Employee();
            dreadProducts.Read();
            et.subject = (string)dreadProducts[1];
            et.level_Number = (int)dreadProducts[2];
            et.no_Of_Attempts = (int)dreadProducts[3];
            cnNorth.Close();
            
         * 
         * string constr = @"Server=NIKKHIL-HP\sqlexpress;Integrated Security=true; database=OnlineExamination";
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
            Object []abc = new Object[4];
            abc= dr.ItemArray;
            et.exam_Type = (string)abc.ElementAt(0);
            et.subject = (string)abc.ElementAt(1);
            et.level_Number = (int)abc.ElementAt(2);
            et.no_Of_Attempts = (int)abc.ElementAt(3);
            conn.Close();
            return et;
            
        }*/

    }
}
