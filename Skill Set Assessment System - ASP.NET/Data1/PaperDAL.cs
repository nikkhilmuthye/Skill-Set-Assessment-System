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
    public class PaperDAL
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\BE Project\Final Backup\WindowsFormsApplication10\Data1\Database2.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dread;


        //
        //Returns count of set Exam IDs 
        //
        public int getSetPaperCount()
        {
            cmd = new SqlCommand("select count(distinct Exam_ID) from SetPaper", conn);
            conn.Open();
            int i = (int)cmd.ExecuteScalar();
            conn.Close();
            return i;
        }


        //
        //Returns an array containing all the Set Exam IDs
        //
        public string[] loadSetExamID(int i)
        {
            string[] abc = new string[i];
            cmd = new SqlCommand("select distinct Exam_ID from SetPaper", conn);
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
        //Returns the number of added Questions for a given Exam ID
        //
        public int getAddedQuestionCount(Paper pq)
        {
            cmd = new SqlCommand("select No_Of_Questions from SetPaper where Exam_ID='" + pq.exam_ID + "'", conn);
            conn.Open();
            dread = cmd.ExecuteReader();
            int count = 0;
            while (dread.Read())
            {
                string n = dread["No_Of_Questions"].ToString();
                int m = Convert.ToInt32(n);
                count += m;
            }
            dread.Close();
            conn.Close();
            return count;
        }
        

        //
        //Adds the selected Section-Format-No Of Questions, returns Success, Already Added or Error Message
        //
        public string addSectionFormat(Paper s)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("Insert into SetPaper(Exam_ID,Section,Format,No_Of_Questions) values('" + s.exam_ID + "','" + s.section + "','" + s.format + "'," + s.no_Of_Questions + ")", conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if(i==1)
                    return "Successfully added";
                else
                    return "Some error occured. Sorry for the inconvenience.";
            }
            catch (SqlException ex)
            {
                conn.Close();
                return "You have already added questions for the selected combination of Section-Format.";
            }
            catch (Exception e)
            {
                conn.Close();
                return "Some error occured. Sorry for the inconvenience.";
            }
        }


        //
        //Gets the No Of Questions for the Section-Format combination for the given Exam 
        //
        public int getNoOfQuestions(Paper pq)
        {
            try
            {
                cmd = new SqlCommand("select No_Of_Questions from SetPaper where Exam_ID='" + pq.exam_ID + "' and Section ='" + pq.section + "' and Format = '" + pq.format + "'", conn);
                conn.Open();
                int i = (int)cmd.ExecuteScalar();
                conn.Close();
                return i;
            }
            catch (SqlException e)
            {
                conn.Close();
                return 0;
            }
            catch(Exception e)
            {
                conn.Close();
                return 0;
            }

        }


        //
        //Updates the selected Section-Format-No Of Questions, returns Success, or Error Message
        //
        public string updateSectionFormat(Paper s)
        {
            int count;
            try
            {
                conn.Open();
                cmd = new SqlCommand("Update SetPaper SET No_Of_Questions="+s.no_Of_Questions+" Where Exam_ID='" + s.exam_ID + "' and Section='" + s.section + "' and Format ='" + s.format + "'");
                count = cmd.ExecuteNonQuery();
                if (count == 0)
                {
                    cmd = new SqlCommand("Insert into SetPaper(Exam_ID,Section,Format,No_Of_Questions) values('" + s.exam_ID + "','" + s.section + "','" + s.format + "'," + s.no_Of_Questions + ")", conn);
                    count = cmd.ExecuteNonQuery();
                }
                conn.Close();
                if (count == 1)
                    return "Successfully Updated.";
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
        //Deletes paper, returns Success or Error Message
        //
        public string deletePaper(Paper b)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("Delete From SetPaper where Exam_ID='" + b.exam_ID + "'", conn);
                int i =cmd.ExecuteNonQuery();
                conn.Close();
                if(i>0)
                    return "Paper for Exam " + b.exam_ID + " is successfully deleted"; 
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
        //Gets the row count for given Exam in Set Paper table
        //
        public int getRowCountForExam(Paper p)
        {  
            conn.Open();
            cmd = new SqlCommand("select Section, Format, No_Of_Questions from SetPaper where Exam_ID ='"+p.exam_ID+"'", conn);
            dread = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dread);
            int a = dt.Rows.Count;
            dread.Close();
            conn.Close();
            return a;
        }


        //
        //Returns an array containing the paper Details for a given Paper
        //
        public Paper[] viewPaperDetails(Paper s, int count)
        {
            Paper[] arr = new Paper[count];
            conn.Open();
            cmd = new SqlCommand("select Section, Format, No_Of_Questions from SetPaper where Exam_ID ='"+s.exam_ID+"'", conn);
            dread = cmd.ExecuteReader();
            for (int i = 0; i < count; i++)
            {
                dread.Read();
                arr[i] = new Paper();
                arr[i].section = dread[0].ToString();
                arr[i].format = dread[1].ToString();
                arr[i].no_Of_Questions = Convert.ToInt32(dread[2].ToString());
                arr[i].exam_ID = s.exam_ID;
            }
            dread.Close();
            conn.Close();
            return arr;
        }


        public bool check(int m, int[] array)
        {
            int size = array.Length;
            for (int i = 0; i < size; i++)
            {
                if (m == array[i])
                    return false;
            }
            return true;
        }


        public int getTotalQuestions(Paper pq)
        {
            SqlConnection cnNorth;
            SqlCommand cmdProducts;
            SqlDataReader dreadProducts;

            string constr = @"Server=NIKKHIL-HP\sqlexpress;Integrated Security=true; database=OnlineExamination";
            cnNorth = new SqlConnection(constr);
            cnNorth = new SqlConnection(constr);
            cmdProducts = new SqlCommand("select * from Paper", cnNorth);
            cnNorth.Open();
            dreadProducts = cmdProducts.ExecuteReader();
            int j = 0;
            while (dreadProducts.Read())
            {
                j++;
            }
            constr = @"Server=NIKKHIL-HP\sqlexpress;Integrated Security=true; database=OnlineExamination";
            cnNorth = new SqlConnection(constr);
            cnNorth = new SqlConnection(constr);
            String query = string.Format("select No_Of_Questions from Paper where Exam_ID = '{0}'", pq.exam_ID);
            cmdProducts = new SqlCommand(query, cnNorth);
            //cmdProducts = new SqlCommand("select No_Of_Questions from Paper", cnNorth);
            cnNorth.Open();
            dreadProducts = cmdProducts.ExecuteReader();
            int[] a = new int[j];
            int count = 0;
            string b;
            while (dreadProducts.Read())
            {
                b = dreadProducts[0].ToString();
                count += Convert.ToInt32(b);
            }
            dreadProducts.Close();
            return count;
        }

        public string[] loadPaperType(int i)
        {

            SqlConnection cnNorth;
            SqlCommand cmdProducts;
            SqlDataReader dreadProducts;

            string constr = @"Server=NIKKHIL-HP\sqlexpress;Integrated Security=true; database=OnlineExamination";
            cnNorth = new SqlConnection(constr);

            string[] abc = new string[i];

            cnNorth = new SqlConnection(constr);
            cmdProducts = new SqlCommand("select distinct Exam_ID from Paper", cnNorth);
            cnNorth.Open();
            dreadProducts = cmdProducts.ExecuteReader();
            int j = 0;

            while (dreadProducts.Read())
            {
                abc[j] = dreadProducts["Exam_ID"].ToString();
                j++;

            }

            dreadProducts.Close();
            return abc;

        }

        
        public Paper[] getPaperDetails(Paper p)
        {
            SqlConnection cnNorth;
            SqlCommand cmdOrders;
            SqlDataReader dreadOrders;
            string constr = @"Server=NIKKHIL-HP\sqlexpress;Integrated Security=true; database=OnlineExamination";
            cnNorth = new SqlConnection(constr);
            cnNorth.Open();
            string query = string.Format("select Format from SetPaper where Exam_ID ='{0}'", p.exam_ID);
            cmdOrders = new SqlCommand(query, cnNorth);
            dreadOrders = cmdOrders.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dreadOrders);
            int a = dt.Rows.Count;
            
            Paper[] pa = new Paper[a];
            return pa;
            DataRow drow = dt.Rows[0];

            pa[0].format = drow[0].ToString();



           /* string[] tab = new string[a];
            DataRow dr;
            Object[] ob = new Object[1]; 
            for (int i = 0; i < a; i++)
            {
                dr = dt.Rows[i];
                ob= dr.ItemArray;
                tab[i] = Convert.ToString(ob);
               // tab[i] = ob.ToString();
            }*/
            dreadOrders.Close();
            cnNorth.Close();
            return pa;
        }
        public int getTotalMarks(Paper pq)
        {
            string constr = @"Server=NIKKHIL-HP\sqlexpress;Integrated Security=true; database=OnlineExamination";
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommandBuilder sb = new SqlCommandBuilder(da);
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            SqlTransaction tran = conn.BeginTransaction();
            String sql = "Select Marks from TempPaper where Exam_ID ='" + pq.exam_ID + "'";
            da.SelectCommand = new SqlCommand(sql, conn, tran);
            DataSet ds = new DataSet();
            da.Fill(ds, "TempPaper");
            DataTable dt = ds.Tables["TempPaper"];
            int sum = 0;
            int a = dt.Rows.Count;
            DataRow dr;
            string m;
            int n;
            for (int i = 0; i < a; i++)
            {
                dr = dt.Rows[i];
                m = dr[0].ToString();
                n = Convert.ToInt32(m);
                sum += n;
            }

            conn.Close();
            return sum ;

        }
        public int getFormatCount(Questions q, string a)
        {
            String constr = @"Server=NIKKHIL-HP\sqlexpress;Integrated Security=true; database=OnlineExamination";
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            String query = string.Format("select Question_ID from TempPaper where Format='" + a + "' and  Section ='" + q.section + "'");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = query;
            SqlDataReader rdr = cmd.ExecuteReader();
            int i = 0;
            while (rdr.Read())
            {
                i++;
            }
            conn.Close();
            return i;
        }
              
       
        
    }
}
