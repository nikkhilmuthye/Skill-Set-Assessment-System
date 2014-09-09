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
    public class ResultStatusDAL
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\BE Project\Final Backup\WindowsFormsApplication10\Data1\Database2.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dread;


        //
        //Returns the status of an employee for a given exam_type
        //
        public ResultStatus getResultStatus(ResultStatus rs)
        {
            conn.Open();
            cmd = new SqlCommand("Select Attempt_No, Status from ResultStatus where Employee_ID = '" + rs.employee_ID + "' and Exam_Type = '" + rs.exam_Type + "'", conn);
            dread = cmd.ExecuteReader();
            if (dread.HasRows)
            {
                //Has attempted before
                dread.Read();
                rs.attempt_No = Convert.ToInt32(dread["Attempt_No"]);
                rs.status = dread["Status"].ToString();
            }
            else
            {
                //Unattempted
                rs.Attempt_No = 0;
                rs.status = "Unscheduled";
            }
            dread.Close();
            conn.Close();
            return rs;
        }


        //
        //Adds result status for a first timer, returns success or error message
        //
        public string addResultStatus(ResultStatus rs)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("Insert into ResultStatus(Employee_ID,Exam_Type,Attempt_No,Status) values('"+rs.employee_ID+"','"+rs.exam_Type+"',"+rs.attempt_No+",'"+rs.status+"')", conn);
                int i =cmd.ExecuteNonQuery();
                conn.Close();
                if(i==1)
                    return "Attempt No: "+rs.attempt_No+" for Exam Type "+rs.exam_Type+".";
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
        //Updates result status and no of attempts for a repeater, returns success or error message
        //
        public string updateResultStatus(ResultStatus rs)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("Update ResultStatus SET Attempt_No= " + rs.attempt_No + " and Status ='"+rs.status+"' Where Employee_ID = '" + rs.employee_ID + "' and Exam_Type = '" + rs.exam_Type + "'", conn);
                int i =cmd.ExecuteNonQuery();
                conn.Close();
                if(i==1)
                    return "Attempt No: "+rs.attempt_No+" for Exam Type "+rs.exam_Type+".";
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
        //Updates result status after attempting an exam
        //
        public bool updateStatus(ResultStatus rs)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("Update ResultStatus SET Status ='"+rs.status+"' Where Employee_ID = '" + rs.employee_ID + "' and Exam_Type = '" + rs.exam_Type + "'", conn);
                int i =cmd.ExecuteNonQuery();
                conn.Close();
                if(i==1)
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
        //Deletes an Result Status for a particular Exam_Type and Employee
        //
        public void deleteResultStatus(ResultStatus r)
        {
            conn.Open();
            cmd = new SqlCommand("Delete ResultStatus where Employee_ID='" + r.employee_ID + "' and Exam_ID='" + r.exam_Type + "'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            return;
        }


        ////
        ////Returns the number of attempts given by an employee for a given exam_type
        ////
        //public ResultStatus addOrUpdateAttempt(ResultStatus rs, int max_attempt)
        //{
        //    conn.Open();
        //    cmd = new SqlCommand("Select Attempt_No, Status from ResultStatus where Employee_ID = '" + rs.employee_ID + "' and Exam_Type = '" + rs.exam_Type + "'", conn);
        //    dread = cmd.ExecuteReader();
        //    if (dread.HasRows)
        //    {
        //        //Has attempted before
        //        dread.Read();
        //        rs.attempt_No = Convert.ToInt32(dread["Attempt_No"]);
        //        rs.status = dread["Status"].ToString();
        //        dread.Close();

        //        if (rs.status == "Fail")
        //        {
        //            //Status is fail
        //            if (rs.attempt_No == max_attempt)
        //            {
        //                //Exhausted no of attempts
        //                rs.attempt_No++;
        //            }
        //            else
        //            {
        //                //Attempts left
        //                rs.attempt_No++;
        //                rs.status = "Scheduled";
        //                cmd = new SqlCommand("Update ResultStatus SET Attempt_No= " + rs.attempt_No + " and Status ='"+rs.status+"' Where Employee_ID = '" + rs.employee_ID + "' and Exam_Type = '" + rs.exam_Type + "'", conn);
        //                cmd.ExecuteNonQuery();
        //            }
        //        }
        //    }
        //    else
        //    {
        //        //First timer
        //        rs.Attempt_No = 1;
        //        rs.status = "Scheduled";
        //        cmd = new SqlCommand("Insert into ResultStatus(Employee_ID,Exam_Type,Attempt_No,Status) values('" + rs.employee_ID + "','" + rs.exam_Type + "'," +rs.attempt_No+ ",'"+rs.status+"')", conn);
        //        cmd.ExecuteNonQuery();
        //    }
        //    conn.Close();
        //    return rs;
        //}
    }
}
