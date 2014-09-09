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
    public class ExamDetailDAL
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\BE Project\Final Backup\WindowsFormsApplication10\Data1\Database2.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dread;

        

        public string getExamType(string exam)
        {
            try
            {
                conn.Open();
                //cmd = new SqlCommand("select * from Exam_Details where Exam_ID='" + exam.exam_ID + "'", conn);
                cmd = new SqlCommand("select Exam_Type from Exam_Details where Exam_ID = '" + exam+ "'", conn);

                //cmd = new SqlCommand("Select Exam_Type from Exam_Details where Exam_ID='"+exam.exam_ID+"')", conn); '"+ed.exam_ID+"'"
                dread = cmd.ExecuteReader();
                dread.Read();
                string exams = (string)dread["Exam_Type"];
                
                conn.Close();
                return exams;
                
            }
            catch (Exception ex)
            {
                conn.Close();
                return "Some error occured. Sorry for the inconvenience.";
            }
        
        }
            

        //
        //Adds Exam Detail and returns assigned Exam ID (or Error Message)
        //
        public string addExamDetails(Exam_Details e,string configure)
        {
            try
            {
                string config = configure;
                e.exam_ID = this.getNext();
                conn.Open();
                cmd = new SqlCommand("Insert into Exam_Details(Exam_ID,Exam_Type,Datetime,Highest,Lowest,Average,Answer_Config,Duration) values('" + e.exam_ID + "','" + e.exam_Type + "','" + e.datetime + "'," + e.highest + " ," + e.lowest +"," + e.average + ",'"+config+"',"+e.duration+")", conn);
                int i =cmd.ExecuteNonQuery();
                conn.Close();
                if(i==1)
                    return "Exam was successfully added & assigned ID " + e.exam_ID + ".";
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
        //Updates fields of Exam, returns Success or Error Message
        //
        public string updateExamDetails(Exam_Details e, string configure)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("Update Exam_Details SET Exam_Type='" + e.exam_Type + "', Datetime='" + e.datetime + "', No_Of_Applicants= " + ", Highest=" + e.highest + ", Lowest=" + e.lowest + ", Average=" + e.average + " , Answer_Config='" + configure + "', Duration ="+e.duration+" Where Exam_ID='" + e.exam_ID + "'", conn);
                int  i = cmd.ExecuteNonQuery();
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
        //Returns an array containing all the Exam IDs
        //
        public string[] loadExamDetail(int i)
        {
            string[] abc = new string[i];
            cmd  = new SqlCommand("select Exam_ID from Exam_Details", conn);
            conn.Open();
            dread = cmd.ExecuteReader();
            int j = 0;
            while (dread.Read())
            {
                abc[j] = dread["Exam_ID"].ToString();
                j++;
            }
            dread.Close();
            conn.Close();
            return abc;
        }
        

        //
        //Returns number of Exams
        //
        public int getCount()
        {
            cmd = new SqlCommand("select count(Exam_ID) from Exam_Details", conn);
            conn.Open();
            int count = (int)cmd.ExecuteScalar();
            conn.Close();
            return count;
        }


        //
        //Gets other fields of a Exam given the Exam ID
        //
        public Exam_Details getExamDetails(Exam_Details ed)
        {
            conn.Open();
            cmd = new SqlCommand("select Exam_Type, DateTime,Answer_Config,Duration from Exam_Details where Exam_ID = '"+ed.exam_ID+"'", conn);
            dread = cmd.ExecuteReader();
            dread.Read();
            ed.exam_Type = dread.GetString(0);
            ed.datetime = dread.GetDateTime(1);
            ed.answer_Config = dread.GetString(2);
            ed.duration = dread.GetInt32(3);
            dread.Close();
            conn.Close();
            return ed;
        }
       

        //
        // Gets the next Exam ID
        //
        public string getNext()
        {
            cmd = new SqlCommand("select Max(Exam_ID) from Exam_Details", conn);
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
        //Deletes an Exam with given Exam ID, and returns a success or error message
        //
        public string deleteExamDetails(Exam_Details et)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("Delete Exam_Details where Exam_ID='" + et.exam_ID + "'",conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if(i==1)
                    return "Exam " + et.exam_ID + " is successfully deleted";
                else
                    return "Attempt unsuccessful. Sorry for the inconvenience.";
            }
            catch (Exception ex)
            {
                conn.Close();
                return "Attempt unsuccessful. Sorry for the inconvenience.";
            }
        }


        //
        //Gets exam Type and schedule of Exam with given Exam IDs
        //
        public Exam_Details[] getSchedule(Exam_Details[] er)
        {
            conn.Open();
            int count = er.Length;
            for (int i = 0; i < count; i++)
            {
                cmd = new SqlCommand("select Exam_Type, Datetime, Duration from Exam_Details where Exam_ID = '"+er[i].exam_ID+"'", conn);
                dread = cmd.ExecuteReader();
                dread.Read();
                er[i].exam_Type = dread[0].ToString();
                er[i].datetime = Convert.ToDateTime(dread[1]);
                er[i].duration = Convert.ToInt32(dread[2]);
                dread.Close();
            }
            conn.Close();
            return er;
        }


        /* public Exam_Details getExamDetailsU(Exam_Details et)
       {
           SqlConnection cnNorth;
           SqlCommand cmdProducts;
           SqlDataReader dreadProducts;

           string constr = @"Server=NIKKHIL-HP\sqlexpress;Integrated Security=true; database=OnlineExamination";
           cnNorth = new SqlConnection(constr);
           cmdProducts = new SqlCommand("select * from Exam_Details Where Exam_ID='" + et.exam_ID + "'", cnNorth);
           cnNorth.Open();
           dreadProducts = cmdProducts.ExecuteReader();
           int i = 0;
           //Employee et = new Employee();
           dreadProducts.Read();
           et.exam_Type = (string)dreadProducts[1];
           et.datetime = (DateTime)dreadProducts[2];
           et.no_Of_Applicants = (int)dreadProducts[3];
           et.highest = (int)dreadProducts[4];
           et.lowest = (int)dreadProducts[5];
           et.average = (int)dreadProducts[6];
           cnNorth.Close();
           return et;
         
        
           string constr = @"Server=NIKKHIL-HP\sqlexpress;Integrated Security=true; database=OnlineExamination";
           SqlDataAdapter da = new SqlDataAdapter();
           SqlCommandBuilder sb = new SqlCommandBuilder(da);
           SqlConnection conn = new SqlConnection(constr);
           conn.Open();
           SqlTransaction tran = conn.BeginTransaction();
           String sql = "Select * from Exam_Details";
           da.SelectCommand = new SqlCommand(sql, conn, tran);
           DataSet ds = new DataSet();
           da.Fill(ds, "Exam_Details");
           DataTable dt = ds.Tables["Exam_Details"];
           Exam_Details et = new Exam_Details();
           DataRow dr = dt.Rows[index];
           dr = dt.Rows[index];
           Object[] abc = new Object[7];
           abc = dr.ItemArray;
           et.exam_ID = (string)abc.ElementAt(0);
           et.exam_Type = (string)abc.ElementAt(1);
           et.datetime = (DateTime)abc.ElementAt(2);
           et.no_Of_Applicants = (int)abc.ElementAt(3);

           conn.Close();
           return et;

       }*/
    }
}