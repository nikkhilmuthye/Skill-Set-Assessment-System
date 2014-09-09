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
    public class ResultsDAL
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\BE Project\Final Backup\WindowsFormsApplication10\Data1\Database2.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dread;

       
        ////
        ////Returns the number of attempts given by an employee for a given exam_type
        ////
        //public Results getCurrentNoOfAttemptsByEmployeeForExamType(Results em)
        //{
        //    try
        //    {
        //        conn.Open();
        //        cmd = new SqlCommand("Select Attempt_No from Results where Employee_ID = '"+ em.employee_ID+"' and Exam_Type = '"+ em.exam_Type +"'",conn);
        //        dread = cmd.ExecuteReader();
        //        if(dread.HasRows)
        //        {
        //            while (dread.Read())
        //            {
        //                em.attempt_No = Convert.ToInt32(dread["Attempt_No"]);
        //            }
        //        }
        //        else
        //            em.attempt_No = 0;
        //        dread.Close();
        //        conn.Close();
        //        return em;
        //    }
        //    catch (Exception ex)
        //    {
        //        conn.Close();
        //        return em;
        //    }
        //}


        //
        //Returns scores in Results array for different exams and employees
        //
        public Results[] checkIfAppeared(Results[] r)
        {
            bool[] b = new bool[r.Length];
            conn.Open();
            for (int i = 0; i < r.Length; i++)
            {
                cmd = new SqlCommand("select Score from Results where Employee_ID='" + r[i].employee_ID + "' and Exam_ID='" + r[i].exam_ID + "'", conn);
                r[i].score = Convert.ToInt32(cmd.ExecuteScalar());
            }
            conn.Close();
            return r;
        }


        //
        //Adds applicant and returns success or Error Message
        //
        public string addApplicant(Results e)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("Insert into Results(Employee_ID,Exam_ID, Score) values('"+e.employee_ID+"','"+e.exam_ID+"',-1"+")", conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if(i==1)
                    return "Employee " + e.employee_ID + " was successfully added for Exam " + e.exam_ID + ".";
                else
                    return "Error";
            }
            catch (Exception ex)
            {
                conn.Close();
                return "Error";
            }
        }


        //
        //Deletes an Applicant for a Exam, and returns a success or error message
        //
        public string deleteResults(Results r)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("Delete Results where Employee_ID='" + r.employee_ID + "' and Exam_ID='" + r.exam_ID + "'", conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if(i==1)
                    return "Employee " + r.Employee_ID + " is successfully deleted from Exam " + r.exam_ID;
                else
                    return "Error";
            }
            catch (Exception ex)
            {
                conn.Close();
                return "Error";
            }
        }


        //
        //Returns an array containing all the Applicants
        //
        public string[] loadApplicants(int i)
        {
            string[] abc = new string[i];
            cmd = new SqlCommand("select Employee_ID, Exam_ID from Results where Score == -1", conn);
            conn.Open();
            dread = cmd.ExecuteReader();
            int j = 0;
            while (dread.Read())
            {
                abc[j] = dread["Employee_ID"].ToString() + ":" + dread["Exam_ID"].ToString();
                j++;
            }
            dread.Close();
            conn.Close();
            return abc;
        }


        //
        //Returns number of Applicants
        //
        public int getCount()
        {
            cmd = new SqlCommand("select count(Employee_ID, Exam_ID) from Results where Score == -1", conn);
            conn.Open();
            int i = (int)cmd.ExecuteScalar();
            conn.Close(); 
            return i;
        }


        //
        //Returns the number of conducted exams
        //
        public int getCondcutedExamsCount()
        {
            cmd = new SqlCommand("select count(distinct Exam_ID) from Results where Score > 0", conn);
            conn.Open();
            int i = (int)cmd.ExecuteScalar();
            conn.Close();
            return i;
        }


        //
        //Returns an array containing IDs of conducted Exams.
        //
        public Results[] loadConductedExamID(Results[] r)
        {
            cmd = new SqlCommand("select distinct Exam_ID from Results where Score > 0", conn);
            conn.Open();
            dread = cmd.ExecuteReader();
            int j = 0;
            while (dread.Read())
            {
                r[j] = new Results();
                r[j].exam_ID = dread["Exam_ID"].ToString();
                j++;
            }
            dread.Close();
            conn.Close();
            return r;
        }


        //
        //Returns the number of Results for a particular Exam
        //
        public int getResultCountForExam(Results p)
        {
            conn.Open();
            cmd = new SqlCommand("select count(Employee_ID) from Results where Exam_ID ='"+p.exam_ID+"'", conn);
            int i = (int)cmd.ExecuteScalar();
            conn.Close();
            return i;
        }


        //
        //Returns results for a particular Exam
        //
        public Results[] viewResult(Results s)
        {
            int count = this.getResultCountForExam(s);
            Results[] arr = new Results[count];
            conn.Open();
            string query = string.Format("select Employee_ID, Exam_ID, Score,Percentage from Results where Exam_ID ='{0}'", s.exam_ID);
            cmd = new SqlCommand(query, conn);
            dread = cmd.ExecuteReader();
            for (int i = 0; i < count; i++)
            {
                dread.Read();
                arr[i] = new Results();
                arr[i].employee_ID = dread[0].ToString();
                arr[i].exam_ID = dread[1].ToString();
                arr[i].score = Convert.ToInt32(dread[2].ToString());
                arr[i].percentage = Convert.ToSingle(dread[3].ToString());
            }
            dread.Close();
            conn.Close();
            return arr;
        }


        //
        //Returns results for a particular Employee
        //
        public Results[] viewResultForEmployee(Results s, int count)
        {
            Results[] arr = new Results[count];
            conn.Open();
            cmd = new SqlCommand("select Employee_ID, Exam_ID, Score,Percentage from Results where Employee_ID ='" + s.employee_ID + "'", conn);
            dread = cmd.ExecuteReader();
            for (int i = 0; i < count; i++)
            {
                dread.Read();
                arr[i] = new Results();
                arr[i].employee_ID = dread[0].ToString();
                arr[i].exam_ID = dread[1].ToString();
                arr[i].score = Convert.ToInt32(dread[2].ToString());
                arr[i].percentage = Convert.ToSingle(dread[3].ToString()); ;
            }
            dread.Close();
            conn.Close();
            return arr;
        }


        //
        //Returns count of Exams for which the employee is an applicant
        //
        public int getExamCountForEmployee(Employee emp)
        {
            cmd = new SqlCommand("select Exam_ID from Results where Employee_ID ='"+emp.employee_Id+"'", conn);
            conn.Open();
            dread = cmd.ExecuteReader();
            int i = 0;
            while (dread.Read())
            {
                i++;
            }
            dread.Close();
            conn.Close();
            return i;
        }


        //
        //Returns count of Exams for which the employee is an applicant
        //
        public Exam_Details[] getExamIDsForEmployee(Employee emp, int count)
        {
            cmd = new SqlCommand("select Exam_ID from Results where Employee_ID ='" + emp.employee_Id + "'", conn);
            conn.Open();
            dread = cmd.ExecuteReader();
            Exam_Details [] ed = new Exam_Details[count];
            for(int i=0;i<count;i++)
            {
                dread.Read();
                ed[i] = new Exam_Details();
                ed[i].exam_ID = dread[0].ToString();
               
            }
            dread.Close();
            conn.Close();
            return ed;
        }
        

        //
        //Stores the result, returns true if successfully, else false
        //
        public bool addScore(Results e)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("Update Results SET Score= " + e.score + ", Percentage = " + e.percentage + " Where Employee_ID = '" + e.employee_ID + "' AND Exam_ID = '" + e.exam_ID + "'", conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                conn.Close();
                return false;
            }
        }


        //
        //Gets the result details of a Employee for a Exam
        //
        public Results getResult(Results r)
        {
            conn.Open();
            cmd = new SqlCommand("select Score from Results where Employee_ID ='" + r.employee_ID + "' and Exam_ID ='" + r.exam_ID + "'", conn);
            r.score = Convert.ToInt32(cmd.ExecuteScalar());
            cmd = new SqlCommand("select Percentage from Results where Employee_ID ='" + r.employee_ID + "' and Exam_ID ='" + r.exam_ID + "'", conn);
            r.percentage = Convert.ToSingle(cmd.ExecuteScalar());
            conn.Close();
            return r;
        }


        //
        //Returns the number of Results for a particular Employee
        //
        public int getResultCountForEmployee(Results p)
        {
            conn.Open();
            cmd = new SqlCommand("select count(Exam_ID) from Results where Employee_ID ='"+p.employee_ID+"' and Score > 0", conn);
            int a = (int)cmd.ExecuteScalar();
            conn.Close();
            return a;
        }


        //
        //Returns results for a particular Employee
        //
        public Results[] viewResultEmployee(Results s)
        {
            int count = this.getResultCountForExam(s);
            Results[] arr = new Results[count];
            conn.Open();
            cmd = new SqlCommand("select Employee_ID, Exam_ID, Score,Percentile from Results where Employee_ID ='"+s.employee_ID+"'", conn);
            dread = cmd.ExecuteReader();
            for (int i = 0; i < count; i++)
            {
                dread.Read();
                arr[i] = new Results();
                arr[i].employee_ID = dread[0].ToString();
                arr[i].exam_ID = dread[1].ToString();
                arr[i].score = Convert.ToInt32(dread[2].ToString());
                arr[i].percentage = Convert.ToSingle(dread[3].ToString());
            }
            dread.Close();
            conn.Close();
            return arr;
        }


        //
        //Loads Sections for a given Exam ID
        //
        public string[] loadSection(Results r, int k)
        {
            conn.Open();
            cmd = new SqlCommand("select distinct Section from SetPaper where Exam_ID = '" + r.exam_ID + "'", conn);
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

        //Add Detailed Result into the Database
        public bool addDetailedResult(DetailedReports dr)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert into Detailed_Reports(Employee_ID,Exam_ID,Section,Percentage) values('" + dr.employee_ID + "','" + dr.exam_ID + "','" + dr.section + "'," + dr.percentage + ")";
                conn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }
            conn.Close();
            return true;
        }

        //Get Total Questions for a particular Exam for a particular Section
        public int[] totalSectionQuestions(string[] section, Results r)
        {
            SqlConnection cnNorth;
            string constr = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\BE Project\Final Backup\WindowsFormsApplication10\Data1\Database2.mdf;Integrated Security=True";//@"Server=NIKKHIL-HP\sqlexpress;Integrated Security=true; database=OnlineExamination";
            cnNorth = new SqlConnection(constr);
            int[] total = new int[section.Length];
            try
            {
                cnNorth.Open();
                for (int i = 0; i < section.Length; i++)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cnNorth;
                    //SqlCommand cmd = new SqlCommand("Insert into Employee(Employee_ID) values('" + e.employee_Id + "','" + e.last_Name + "','" + e.first_Name + "','" + e.birthdate + "','" + e.hire_Date + "' ,'" + e.address + "','" + e.city + "','" + e.region + "'," + e.postalCode + ",'" + e.country + "','" + e.mobile_Number +  "')",cnNorth);
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Select No_Of_Questions from SetPaper where Exam_ID='" + r.exam_ID + "' and Section='" + section[i] + "'";
                    dread = cmd.ExecuteReader();
                    if (dread.Read())
                    {
                        total[i] = total[i] + dread.GetInt32(0);
                        while (dread.Read())
                        {
                            total[i] = total[i] + dread.GetInt32(0);
                        }
                    }
                    dread.Dispose();
                }
            }
            catch (Exception ex)
            {
                //return false;
            }

            cnNorth.Close();
            return total;
        }

        //
        //Gets count of Sections for a given Exam ID
        //
        public int getSectionCount(Results q)
        {
            conn.Open();
            cmd = new SqlCommand("select distinct Section from SetPaper where Exam_ID='" + q.exam_ID + "'", conn);
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




        //Check if Highest, Lowest, Average already calculated
        public Exam_Details CheckResult(Results r)
        {
            Exam_Details a = new Exam_Details();
            //try
            //{
                conn.Open();
                cmd = new SqlCommand("select * from Exam_Details where Exam_ID ='" + r.exam_ID + "'", conn);
                dread = cmd.ExecuteReader();
                dread.Read();
                a.exam_ID = dread.GetString(0);
                a.exam_Type = dread.GetString(1);
                a.datetime = dread.GetDateTime(2);
                a.highest = dread.GetInt32(3);
                a.lowest = dread.GetInt32(4);
                //string temp = dread.GetString(5);
                a.average = Convert.ToSingle(dread[5].ToString());
                a.answer_Config = dread.GetString(6);
                a.duration = dread.GetInt32(7);
                conn.Close();
                return a;
            //}
            //catch
            //{
            //    a.exam_ID = "ED000";
            //    conn.Close();
            //    return a;
            //}
        }


        //
        //Updates fields of Exam, returns Success or Error Message
        //
        public bool addResult(Exam_Details e)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("Update Exam_Details SET Highest=" + e.highest + ", Lowest=" + e.lowest + ", Average=" + e.average + " Where Exam_ID='" + e.exam_ID + "'", conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                conn.Close();
                return false;
            }
        }

        //
        //Gets other fields of a Exam given the Exam ID
        //
        public Exam_Details getExamDetails(Exam_Details ed)
        {
            conn.Open();
            cmd = new SqlCommand("select Highest,Lowest,Average from Exam_Details where Exam_ID = '" + ed.exam_ID + "'", conn);
            dread = cmd.ExecuteReader();
            dread.Read();
            ed.highest = dread.GetInt32(0);
            ed.lowest = dread.GetInt32(1);
            ed.average = Convert.ToSingle(dread[2].ToString()); ;
            dread.Close();
            conn.Close();
            return ed;
        }


    }
}
