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
    public class FeedbackDAL
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\BE Project\Final Backup\WindowsFormsApplication10\Data1\Database2.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dread;


        //
        //Adds feedback and returns success or error message
        //
        public string addFeedback(Feedback f)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("Insert into Feedback (Employee_ID,Exam_ID,Answer1, Answer2, Answer3, Answer4, Answer5) values('" + f.Employee_ID + "', '" + f.exam_ID + "', " + f.answer1 + ", " + f.answer2 + ", " + f.answer3 + ", " + f.answer4 + ", " + f.answer5 + ")", conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i == 1)
                    return "You have successfully submitted your feedback.";
                else
                    return "Some error occured. Sorry for the inconvenience.";
            }
            catch (Exception ex)
            {
                conn.Close();
                return "Some error occured. Sorry for the inconvenience.";
            }
        }
    }
}
