using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities2;
using Data1;

namespace Business1
{
    public class Exam_TypeBS
    {
        ExamTypeDAL em = new ExamTypeDAL();

        
        ////
        ////Gets the next permitted number of attempts for an employee for a given exam_type
        ////
        //public Results getNextNoOfAttemptsByEmployeeForExamType(Results e)
        //{
        //    Exam_Types et = new Exam_Types();
        //    et.exam_Type = e.exam_Type;
        //    et = em.getNoOfAttempts(et);
        //    if (e.attempt_No == et.no_Of_Attempts)
        //        e.attempt_No = 0;
        //    else
        //        e.attempt_No++;
        //    return e;
        //}


        //
        //Validates fields before adding Exam Type
        //
        public String addExamType(Exam_Types e)
        {
            string feedback = "";
            bool feed = false;
            int i = 0;
            if (e.subject == "")
            {
                feedback += (++i) + ". Subject  ";
                feed = true;
            }
            if (e.level_Number <= 0)
            {
                feedback += (++i) + ". Level Number  ";
                feed = true;
            }
            if (e.no_Of_Attempts <= 0)
            {
                feedback += (++i) + ". No of Attempts  ";
                feed = true;
            }
            if (feed)
            {
                //Not valid: Returns erroneous fields
                return ("Please enter valid entries for: " + feedback);
            }
            else
            {
                //Valid: Adds Exam Type and returns assigned Exam Type or Error Message
                string feedDAL = em.addExamType(e);
                return feedDAL;
            }
        }


        //
        //Validates fields before updating Exam Type
        //
        public String updateExamType(Exam_Types e)
        {
            string feedback = "";
            bool feed = false;
            int i = 0;
            if (e.subject == "")
            {
                feedback += (++i) + ". Subject  ";
                feed = true;
            }
            if (e.level_Number <= 0)
            {
                feedback += (++i) + ". Level Number  ";
                feed = true;
            }
            if (e.no_Of_Attempts <= 0)
            {
                feedback += (++i) + ". No of Attempts  ";
                feed = true;
            }
            if (feed)
            {
                //Not valid: Returns erroneous fields
                return ("Please enter valid entries for: " + feedback);
            }
            else
            {
                //Valid: Updates Exam Type and returns assigned Exam Type or Error Message
                string feedDAL = em.updateExamType(e);
                return feedDAL;
            }
        }


        //
        //DAL call to get the Next Exam Type
        //
        public string getNext()
        {
            string next = em.getNext();
            return next;
        }


        //
        //DAL call to get the number of Exam Types
        //
        public int getCount()
        {
            int i = em.getCount();
            return i;
        }


        //
        //DAL call to get all the Exam ID's in an array
        //
        public string[] loadExamType(int i)
        {
            int k = em.getCount();
            string[] abc= new string[k];
            abc = em.loadExamType(k);
           
            return abc;
        }


        //
        //DAL call to get other fields of a Exam Type given the Exam Type
        //
        public Exam_Types getExamType(Exam_Types et)
        {
            et = em.getExamType(et);
            return et;
        }


        //
        //DAl call to delete an Exam Type
        //
        public string deleteExamType(Exam_Types et)
        {
            string feed = em.deleteExamType(et);
            return feed;
        }

       /* public bool validatedeleteExamType(int index)
        {
            if (index == -1)
            {
                return false;
            }
            else
                return true;
        }*/
    }
}