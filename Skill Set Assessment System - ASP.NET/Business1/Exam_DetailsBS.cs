using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities2;
using Data1;

namespace Business1
{
    public class Exam_DetailsBS
    {
        ExamDetailDAL ed = new ExamDetailDAL();

        
        //
        //Validates fields before adding Exam
        //
        public String addExamDetail(Exam_Details e, string configure)
        {
            string config = configure;
            string feedback="";
            bool feed = false;
            int i = 0;
            if(e.exam_Type.Length == 0)
            {
                feedback += (++i) + ". ExamType  ";
                feed = true;
            }
            if (e.datetime < DateTime.Today)
            {
                feedback += (++i) + ". Date  ";
                feed = true;
            }
            if (e.duration <= 0)
            {
                feedback += (++i) + ". Duration  ";
                feed = true;
            }
            if (feed)
            {
                //Not valid: Returns erroneous fields
                return ("Please enter valid entries for: " + feedback);
            }
            else
            {
                //Valid: Adds Exam Detail and returns assigned Exam ID or Error Message
                string eid = ed.addExamDetails(e,config);
                return eid;
            }
        }


        //
        //Validates fields before updating
        //
        public String updateExamDetail(Exam_Details e,string configure)
        {
            string feedback = "";
            bool feed = false;
            int i = 0;
            if (e.exam_Type.Length == 0)
            {
                feedback += (++i) + ". ExamType  ";
                feed = true;
            }
            if (e.datetime < DateTime.Today)
            {
                feedback += (++i) + ". Date  ";
                feed = true;
            }
            if (e.duration <= 0)
            {
                feedback += (++i) + ". Duration  ";
                feed = true;
            }
            if (feed)
            {
                //Not valid: Returns erroneous fields
                return ("Please enter valid entries for: " + feedback);
            }
            else
            {
                //Valid: Updates Exam Details, returns Success or Unsuccess message
                string feed2 = ed.updateExamDetails(e,configure);
                return feed2;
            }
        }


        //
        //DAL call to get the Next Exam ID
        //
        public string getNext()
        {
            string next = ed.getNext();
            return next;
        }


        //
        //DAL call to get the number of Exams
        //
        public int getCount()
        {
            int i = ed.getCount();
            return i;
        }


        //
        //DAL call to get all the Exam ID's in an array
        //
        public string[] loadExamDetail(int i)
        {
            int k = ed.getCount();
            string[] abc;
            if (k > 0)
            {
                abc = new string[k];
                abc = ed.loadExamDetail(k);
                
            }
            else
            {
                abc = new string[] {"No Data"};
            }
            return abc;
        }


        //
        //DAL call to get other fields of a Exam given the Exam ID
        //
        public Exam_Details getExamDetails(Exam_Details et)
        {
            et = ed.getExamDetails(et);
            return et;
        }


        //
        //DAl call to delete an Exam with the given Exam ID
        //
        public string deleteExamDetails(Exam_Details e)
        {
            string abc = ed.deleteExamDetails(e);
            return abc;
        }


        //
        //DAL call to get exam Type and schedule of Exam with given Exam IDs
        //
        public Exam_Details[] getSchedule(Exam_Details[] er)
        {
            er = ed.getSchedule(er);
            return er;
        }


        //
        //Returns array of indices of exam scheduled today from a array of Exam_Details
        //
        public int[] checkTodaysSchedule(Exam_Details[] er)
        {
            DateTime dt;
            int k = 0;
            for (int i = 0; i < er.Length; i++)
            {
                dt = er[i].datetime.Date;
                if (dt.Equals(DateTime.Today.Date))
                {
                    k = k + 1;
                }
            }

            int[] index = new int[k];
            int j = 0;
            for (int i = 0; i < er.Length; i++)
            {
                dt = er[i].datetime.Date;
                if (dt.Equals(DateTime.Today.Date))
                {
                    index[j] = i;
                    j++;
                }
            }
            return index;
        }
    }
}

