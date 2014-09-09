using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data.Common;
using Entities2;

namespace Data1
{
    public class QuestionDAL
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\BE Project\Final Backup\WindowsFormsApplication10\Data1\Database2.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dread;

       
        //
        //Adds Question and returns assigned Question ID (or Error Message)
        //
        public string addQuestion(Questions q)
        {
            try
            {
                q.question_ID = this.getNext();
                conn.Open();
                cmd = new SqlCommand("Insert into Questions(Question_ID, Exam_Type, Format, Question, Option1, Option2, Option3, Option4, Solution, Marks, Section) values('" + q.question_ID + "','" + q.exam_Type + "','" + q.format + "','" + q.question + "','" + q.option1 + "','" + q.option2 + "','" + q.option3 + "','" + q.option4 + "','" + q.solution + "'," + q.marks + ",'" + q.section + "')", conn);
                int i= cmd.ExecuteNonQuery();
                conn.Close();
                if(i==1)
                    return "Question was successfully added & assigned Question ID " + q.question_ID + ".";
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
        //Updates fields of Question, returns Success or Error Message
        //
        public string updateQuestion(Questions q)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("Update Questions SET Question_ID='" +q.question_ID + "', Exam_Type='" +q.exam_Type+ "', Format ='"+q.format+"', Question = '"+ q.question +"', Option1 = '"+q.option1 +"', Option2 = '"+q.option2 +"', Option3 = '"+q.option3 +"', Option4 = '"+q.option4 +"', Solution = '"+q.solution +"', Marks = "+q.marks +", Section = '"+q.section + "' Where Question_ID='" + q.question_ID + "'", conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if(i==1)
                    return "Question was successfully updated";
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
        //Deletes an Question with given Question ID, and returns a success or error message
        //
        public string deleteQuestion(Questions q)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("Delete Questions where Question_ID='" + q.question_ID + "'", conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if(i==1)
                    return "Question " + q.question_ID + " is successfully deleted";
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
        //Returns an array containing all the Question IDs and Questions
        //
        public string[] loadQuestion(int i)
        {
            string[] abc = new string[i];
            cmd = new SqlCommand("select Question_ID, Question from Questions", conn);
            conn.Open();
            dread = cmd.ExecuteReader();
            int j = 0;
            while (dread.Read())
            {
                abc[j] = dread["Question_ID"].ToString() + " : " + dread["Question"].ToString();
                j++;
            }
            dread.Close();
            conn.Close();
            return abc;
        }


        //
        //Returns number of Question IDs
        //
        public int getCount()
        {
            cmd = new SqlCommand("select count(Question_ID) from Questions", conn);
            conn.Open();
            int i = (int)cmd.ExecuteScalar();
            conn.Close();
            return i;
        }


        //
        //Gets other fields of a Questions given the Question ID
        //
        public Questions getQuestion(Questions q)
        {
            conn.Open();
            cmd = new SqlCommand("select Exam_Type, Format, Question, Option1, Option2, Option3, Option4, Solution, Marks, Section, Picture_ID from Questions where Question_ID ='"+q.question_ID+"'", conn);
            dread = cmd.ExecuteReader();
            dread.Read();
            q.exam_Type = dread[0].ToString();
            q.format = dread[1].ToString();
            q.question = dread[2].ToString();
            q.option1 = dread[3].ToString();
            q.option2 = dread[4].ToString();
            q.option3 = dread[5].ToString();
            q.option4 = dread[6].ToString();
            q.solution = dread[7].ToString();
            q.marks = Convert.ToInt32(dread[8]);
            q.section = dread[9].ToString();
            q.picture_ID = dread[10].ToString();
            dread.Close();
            conn.Close();
            return q;
        }


        //
        // Gets the next Question ID
        //
        public string getNext()
        {
            cmd = new SqlCommand("select Max(Question_ID) from Questions", conn);
            conn.Open();
            string id = (string)cmd.ExecuteScalar();
            int last = Convert.ToInt32(id.Substring(1, 3));
            last = last + 1;
            string lastmod;
            if (last >= 0 && last <= 9)
                lastmod = "00" + last;
            else if (last >= 10 && last <= 99)
                lastmod = "0" + last;
            else
                lastmod = last + "";
            string next = id.Substring(0, 1) + lastmod;
            conn.Close();
            return next;
        }
    

        //
        //Gets count of Sections for a given Exam Type
        //
        public int getSectionCount(Questions q)
        {
            conn.Open();
            cmd = new SqlCommand("select count(distinct Section) from Questions where Exam_Type='"+q.exam_Type+"'", conn);
            int i = (int)cmd.ExecuteScalar();
            conn.Close();
            return i;
        }
        

        //
        //Loads Sections for a given Exam Type
        //
        public string[] loadSection(Questions q, int k)
        {
            conn.Open();
            cmd = new SqlCommand("select distinct Section from Questions where Exam_Type = '"+q.exam_Type+"'",conn);
            dread = cmd.ExecuteReader();
            string[] abc = new string[k];
            int i =0;
            while (i<k)
            {
                dread.Read();
                abc[i] = dread.GetString(0);
                i++;
            }
            dread.Close();
            conn.Close();
            return abc;
        }


        //
        //Gets count of Formats for a given Exam Type and Section
        //
        public int getFormatCount(Questions q)
        {
            conn.Open();
            cmd = new SqlCommand("select count(distinct Format) from Questions where Exam_Type='" + q.exam_Type + "' and Section='" + q.section + "'", conn);
            int i = (int)cmd.ExecuteScalar();
            conn.Close();
            return i;
        }


        //
        //Loads Formats for a given Exam Type and Section
        //
        public string[] loadFormat(Questions q, int k)
        {
            conn.Open();
            cmd = new SqlCommand("select distinct Format from Questions where Exam_Type ='" + q.exam_Type + "' and Section='" + q.section + "'",conn);
            dread = cmd.ExecuteReader();
            string[] abc = new string[k];
            int i = 0;
            while (i < k)
            {
                dread.Read();
                abc[i] = dread.GetString(0);
                i++;
            }
            dread.Close();
            conn.Close();
            return abc;
        }


        //
        //Gets count of Questions for a given Exam Type, Section & Format  
        //
        public int getQuestionNoCount(Questions q)
        {
            conn.Open();
            cmd = new SqlCommand("select count(Question_ID) from Questions where Exam_Type='" + q.exam_Type + "' and Section='" + q.section + "' and Format ='" + q.format + "'",conn);
            int i = (int)cmd.ExecuteScalar();
            conn.Close();
            return i;
        }


        //
        //Randomly selects questions for each Format-Section specification of the Paper as per the No Of Questions 
        //
        public Questions[] getQuestionPaper(Paper[] arr, Questions[] q, Exam_Details ed)
        {
            int maxcount = 0, mincount = 0;
            DataRow dr;
            int index = 0;
            Object[] abc = new Object[11];
            string temp;
            bool[] rand;
            int no = 0;
            int m;
            int param = arr.Length;
            DataTable dt;
            conn.Open();

            for (int l = 0; l < param; l++)
            {
                //Selects questions for each Format-Section specification of the Paper
                cmd = new SqlCommand("Select * from Questions where Exam_Type ='" + ed.exam_Type + "' and Section ='" + arr[l].section + "' and Format ='" + arr[l].format + "'",conn);
                dread = cmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(dread);                
                
                //Random Selection of questions
                maxcount = dt.Rows.Count;
                mincount = arr[l].no_Of_Questions;
                rand = new bool[maxcount];
                no = 0;
                while (no < mincount)
                {
                    Random r = new Random();
                    m = r.Next(maxcount);

                    if (rand[m] == false)
                    {
                        rand[m] = true;
                        no++;
                    }
                }

                //Loads the randomly selected question into Question Array
                for (int i = 0; i < maxcount; i++)
                {
                    if (rand[i] == true)
                    {
                        q[index] = new Questions();
                        dr = dt.Rows[i];
                        abc = dr.ItemArray;

                        q[index].question_ID = (string)abc.ElementAt(0);
                        q[index].exam_Type = (string)abc.ElementAt(1);
                        q[index].format = (string)abc.ElementAt(2);
                        q[index].question = (string)abc.ElementAt(3);
                        q[index].option1 = (string)abc.ElementAt(4);
                        q[index].option2 = (string)abc.ElementAt(5);
                        q[index].option3 = (string)abc.ElementAt(6);
                        q[index].option4 = (string)abc.ElementAt(7);
                        q[index].solution = (string)abc.ElementAt(8);
                        temp = abc.ElementAt(9).ToString();
                        q[index].marks = Convert.ToInt32(temp);
                        q[index].section = (string)abc.ElementAt(10);
                        if((q[index].format.Equals("Picture Question: Single Answer") )|| (q[index].format.Equals("Picture Question: Multiple Answer")))
                            q[index].picture_ID = (string)abc.ElementAt(11);
                        index++;
                    }
                }
                
            }
            dread.Close();
            conn.Close();
            return q;
        }


        //
        //Function call to getPictureID(), gets Question_ID, adds question and picture
        //
        public String addPictureQuestion(Questions q, Picture p)
        {
            p.picture_ID = this.getPictureID();
            q.question_ID = this.getNext();
            try
            {
                conn.Open();
                cmd = new SqlCommand("Insert into Questions(Question_ID, Exam_Type, Format, Question, Option1, Option2, Option3, Option4, Solution, Marks, Section,Picture_ID) values('" + q.question_ID + "','" + q.exam_Type + "','" + q.format + "','" + q.question + "','" + q.option1 + "','" + q.option2 + "','" + q.option3 + "','" + q.option4 + "','" + q.solution + "'," + q.marks + ",'" + q.section + "','" + p.picture_ID + "')", conn);
                int result1 = cmd.ExecuteNonQuery();

                cmd = new SqlCommand();
                cmd.CommandText = "Insert into Pictures(Picture_ID,Picture)" + " values(@Picture_ID, @Picture)";
                cmd.Parameters.Add("@Picture_ID", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@Picture", System.Data.SqlDbType.Image);
                cmd.Parameters["@Picture_ID"].Value = p.picture_ID;
                cmd.Parameters["@Picture"].Value = p.image;
                cmd.Connection = conn;
                int result = cmd.ExecuteNonQuery();
                conn.Close();
                if (result == 1 && result1 == 1)
                    return "Question was successfully added & assigned Question ID " + q.question_ID + ".";
                else
                    return "Sorry. There was some error.";

            }
            catch (Exception ex)
            {
                conn.Close();
                return ex.Message;
            }
        }


        //
        //Gets the next Primary ID
        //
        public String getPictureID()
        {
            cmd = new SqlCommand("select Max(Picture_ID) from Pictures", conn);
            conn.Open();
            string id = (string)cmd.ExecuteScalar();
            int last = Convert.ToInt32(id.Substring(1, 3));
            last = last + 1;
            string lastmod;
            if (last >= 0 && last <= 9)
                lastmod = "00" + last;
            else if (last >= 10 && last <= 99)
                lastmod = "0" + last;
            else
                lastmod = last + "";
            string next = id.Substring(0, 1) + lastmod;
            conn.Close();
            return next;
        }

        
        //
        //Bulk uploads Questions from a File to Questions table, returns success or error message
        //
        public String addQuestionsBulk(string path)
        {
            // Connection String to Excel Workbook
            string excelConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='" + path + "';Extended Properties='Excel 8.0;HDR=Yes;IMEX=1'";

            //Create Connection to Excel Workbook
            try
            {
                using (OleDbConnection connection = new OleDbConnection(excelConnectionString))
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand("Select * FROM [Data$]", connection);
                    DataSet ds = new DataSet();
                    OleDbDataAdapter dbDa = new OleDbDataAdapter(command);
                    System.Data.DataTable dt = new System.Data.DataTable();
                    dbDa.Fill(dt);
                    ds.Tables.Add(dt);
                    SqlDataAdapter da = new SqlDataAdapter();
                    SqlCommandBuilder sb = new SqlCommandBuilder(da);
                    SqlConnection conn1 = new SqlConnection(@"Server=NIKKHIL-HP\sqlexpress;Integrated Security=true; database=OnlineExamination");
                    conn1.Open();
                    SqlTransaction tran = conn1.BeginTransaction();
                    String sql = "Select * from Questions";
                    da.SelectCommand = new SqlCommand(sql, conn1, tran);
                    DataSet ds1 = new DataSet();
                    da.Fill(ds1, "Questions");
                    System.Data.DataTable dt1 = ds1.Tables["Questions"];
                    DataRow dr;
                    DataRow dr1;
                    connection.Close();
                    string id = getNext();
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        dr = dt.Rows[i];
                        dr1 = dt1.NewRow();
                        dr1["Question_ID"] = id;
                        dr1["Exam_Type"] = dr["Exam_Type"];
                        dr1["Format"] = dr["Format"];
                        dr1["Question"] = dr["Question"];
                        dr1["Option1"] = dr["Option1"];
                        dr1["Option2"] = dr["Option2"];
                        dr1["Option3"] = dr["Option3"];
                        dr1["Option4"] = dr["Option4"];
                        dr1["Solution"] = dr["Solution"];
                        dr1["Marks"] = dr["Marks"];
                        dr1["Section"] = dr["Section"];
                        dt1.Rows.Add(dr1);
                        int last = Convert.ToInt32(id.Substring(1, 3));
                        last = last + 1;
                        string lastmod;
                        if (last >= 0 && last <= 9)
                            lastmod = "00" + last;
                        else if (last >= 10 && last <= 99)
                            lastmod = "0" + last;
                        else
                            lastmod = last + "";
                        id = id.Substring(0, 1) + lastmod;
                    }
                    try
                    {
                        int updates = da.Update(ds1, "Questions");
                    }
                    catch (Exception ex)
                    {
                        if (tran != null)
                        {
                            tran.Rollback();
                            tran = null;
                            return "Unsuccessful Transaction";
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
                    conn1.Close();

                    return "Transaction Successful";
                }
            }
            catch (Exception e)
            {
                conn.Close();
                return "Unsuccessful Transaction";
            }
        }


        //
        //Gets the Picture_ID for the question, and retrieves the corresponding image
        //
        public byte[] getImage(Questions a)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "Select Picture from Pictures where Picture_ID=@ID";
            cmd.Parameters.Add("@ID", SqlDbType.VarChar, 4);
            cmd.Parameters["@ID"].Value = a.picture_ID;
            cmd.Connection = conn;
            conn.Open();
            byte[] c = (byte[])cmd.ExecuteScalar();
            conn.Close();
            return c;
        }


        //
        //Function call to getPictureID(), Updates fields of Question, returns Success or Error Message
        //
        public string updatePictureQuestion(Questions q, Picture p)
        {
            try
            {
                p.picture_ID = this.getPictureID();
                conn.Open();
                cmd = new SqlCommand("Update Questions SET Question_ID='" + q.question_ID + "', Exam_Type='" + q.exam_Type + "', Format ='" + q.format + "', Question = '" + q.question + "', Option1 = '" + q.option1 + "', Option2 = '" + q.option2 + "', Option3 = '" + q.option3 + "', Option4 = '" + q.option4 + "', Solution = '" + q.solution + "', Marks = " + q.marks + ", Section = '" + q.section + "', Picture_ID = '"+ p.picture_ID +"' Where Question_ID='" + q.question_ID + "'", conn);
                int i = cmd.ExecuteNonQuery();
                cmd = new SqlCommand();
                cmd.CommandText = "Insert into Pictures(Picture_ID,Picture)" + " values(@Picture_ID, @Picture)";
                cmd.Parameters.Add("@Picture_ID", System.Data.SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@Picture", System.Data.SqlDbType.Image);
                cmd.Parameters["@Picture_ID"].Value = p.picture_ID;
                cmd.Parameters["@Picture"].Value = p.image;
                cmd.Connection = conn;
                int j = cmd.ExecuteNonQuery();
                conn.Close();
                if (i == 1 && j==1)
                    return "Question was successfully updated.";
                else
                    return"Some error occured. Sorry for the inconvenience.";
            }
            catch (Exception ex)
            {
                conn.Close();
                return "Some error occured. Sorry for the inconvenience.";
            }
        }


        public Questions getQuestion(int index)
        {
            string constr = @"Server=NIKKHIL-HP\sqlexpress;Integrated Security=true; database=OnlineExamination";
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommandBuilder sb = new SqlCommandBuilder(da);
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            SqlTransaction tran = conn.BeginTransaction();
            String sql = "Select * from Questions";
            da.SelectCommand = new SqlCommand(sql, conn, tran);
            DataSet ds = new DataSet();
            da.Fill(ds, "Questions");
            DataTable dt = ds.Tables["Questions"];


            Questions et = new Questions();

            DataRow dr = dt.Rows[index];
            dr = dt.Rows[index];
            Object[] abc = new Object[11];
            abc = dr.ItemArray;
            et.question_ID = (string)abc.ElementAt(0);
            et.exam_Type = (string)abc.ElementAt(1);
            et.format = (string)abc.ElementAt(2);
            et.question = (string)abc.ElementAt(3);
            et.option1 = (string)abc.ElementAt(4);
            et.option2 = (string)abc.ElementAt(5);
            et.option3 = (string)abc.ElementAt(6);
            et.option4 = (string)abc.ElementAt(7);
            et.solution = (string)abc.ElementAt(8);
            string abcde = abc.ElementAt(9).ToString();
            et.marks = Convert.ToInt32(abcde);
            et.section = (string)abc.ElementAt(10);
            conn.Close();
            return et;

        }


        public int getSectionCount()
        {
            cmd = new SqlCommand("select distinct Section from Questions", conn);
            conn.Open();
            dread = cmd.ExecuteReader();
            int i = 0;
            if (dread.Read())
            {
                i++;
                while (dread.Read())
                {
                    i++;
                }
            }
            dread.Close();
            conn.Close();
            return i;
        }


        //
        //Returns an array containing all the Question IDs and Questions
        //
        public string[] loadSection(int i)
        {
            string[] abc = new string[i];
            cmd = new SqlCommand("select distinct Section from Questions", conn);
            conn.Open();
            dread = cmd.ExecuteReader();
            int j = 0;
            while (dread.Read())
            {
                abc[j] = dread["Section"].ToString();
                j++;
            }
            dread.Close();
            conn.Close();
            return abc;
        }


        /*string constr = @"Server=NIKKHIL-HP\sqlexpress;Integrated Security=true; database=OnlineExamination";
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommandBuilder sb = new SqlCommandBuilder(da);
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            SqlTransaction tran = conn.BeginTransaction();
            String sql;
            DataSet ds;
            DataTable dt;
            int maxcount = 0, mincount = 0;
            DataRow dr;
            int index = 0;
            Object[] abc = new Object[11];
            string temp;
            bool[] rand;
            int no = 0;
            int m;
            int param = arr.Length;

            for (int l = 0; l < param; l++) 
            {
                sql = "Select * from Questions where Exam_Type ='" + ed.exam_Type + "' and Section ='" + arr[l].section + "' and Format ='" + arr[l].format + "'";
                da.SelectCommand = new SqlCommand(sql, conn, tran);
                ds = new DataSet();
                da.Fill(ds, "Questions");
                dt = ds.Tables["Questions"];
                maxcount = dt.Rows.Count;
                mincount = arr[l].no_Of_Questions;
                
                rand = new bool[maxcount];
                no = 0;
                while (no < mincount)
                {
                    Random r = new Random();
                    m = r.Next(maxcount);

                    if (rand[m] == false)
                    {
                        rand[m] = true;
                        no++;
                    }
                }

                for (int i = 0; i < maxcount; i++)
                {
                    if (rand[i] == true)
                    {
                        q[index] = new Questions();
                        dr = dt.Rows[i];
                        abc = dr.ItemArray;

                        q[index].question_ID = (string)abc.ElementAt(0);
                        q[index].exam_Type = (string)abc.ElementAt(1);
                        q[index].format = (string)abc.ElementAt(2);
                        q[index].question = (string)abc.ElementAt(3);
                        q[index].option1 = (string)abc.ElementAt(4);
                        q[index].option2 = (string)abc.ElementAt(5);
                        q[index].option3 = (string)abc.ElementAt(6);
                        q[index].option4 = (string)abc.ElementAt(7);
                        q[index].solution = (string)abc.ElementAt(8);
                        temp = abc.ElementAt(9).ToString();
                        q[index].marks = Convert.ToInt32(temp);
                        q[index].section = (string)abc.ElementAt(10);
                        index++;
                    }
                }
            }
            conn.Close();
            return q;
            */


     }
}
