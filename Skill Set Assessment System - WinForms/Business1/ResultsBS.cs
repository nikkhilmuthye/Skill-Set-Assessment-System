using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities2;
using Data1;

namespace Business1
{
    public class ResultsBS
    {
        ResultsDAL cs = new ResultsDAL();


        ////
        ////DAL call to get the number of attempts given by an employee for a given exam_type
        ////
        //public Results getCurrentNoOfAttemptsByEmployeeForExamType(Results e)
        //{
        //    e = cs.getNoOfAttemptsByEmployeeForExamType(e);
        //    return e;
        //}


        //
        //DAL call to check whether the employee has attempted the exam today
        //
        public Results[] checkIfAppeared(Results[] r)
        {
            r = cs.checkIfAppeared(r);
            return r;
        }


        //
        //DAL cal to add Applicants
        //
        public string addApplicant(Results e)
        {
            string feedback = cs.addApplicant(e);
            return feedback;
        }


        //
        //DAL call to get the number of Applicantss
        //
        public int getCount()
        {
            int i = cs.getCount();
            return i;
        }


        //
        //DAL call to get all the Exam ID's in an array
        //
        public string[] loadApplicants(int i)
        {
            string[] abc = new string[i];
            abc = cs.loadApplicants(i);
            return abc;
        }

        
        //
        //DAl call to delete an Employee from an Exam
        //
        public string deleteResults(Results r)
        {
            string feedDAL = cs.deleteResults(r);
            return feedDAL;
        }


        //
        //DAL call to get the number of conducted exams
        //
        public int getConductedExamsCount()
        {
            int count = cs.getCondcutedExamsCount();
            return count;
        }


        //
        //DAL call to get the Exam IDs of conducted Exams
        //
        public Results[] loadConductedExamID(Results[] s)
        {
            s = cs.loadConductedExamID(s);
            return s;
        }


        //
        //DAL call to get number of Results for a particular Exam
        //
        public int getResultCountForExam(Results p)
        {
            int a = cs.getResultCountForExam(p);
            return a;
        }


        //
        //DAL call to get results for an Exam
        //
        public Results[] viewResult(Results s)
        {
            int count = cs.getResultCountForExam(s);
            Results[] arr = new Results[count];
            arr = cs.viewResult(s);
            return arr;
        }


        //
        //DAL call to get results for an Employee
        //
        public Results[] viewResultForEmployee(Results s, int k)
        {
            Results[] arr = new Results[k];
            arr = cs.viewResultForEmployee(s,k);
            return arr;
        }



        //
        //DAL call to get count of Exams for which the employee is an applicant
        //
        public int getExamCountForEmployee(Employee emp)
        {
            int count = cs.getExamCountForEmployee(emp);
            return count;
        }


        //
        //DAL call to get Exam_IDs for which the employee is an applicant
        //
        public Exam_Details[] getExamIDsForEmployee(Employee emp, int count)
        {
            Exam_Details[] er = new Exam_Details[count];
            er = cs.getExamIDsForEmployee(emp,count);
            return er;
        }


        //
        //DAL all to get result details of a Employee for a Exam
        //
        public Results getResult(Results r)
        {
            r = cs.getResult(r);
            return r;
        }



        //
        //DAL call to get number of Results for a particular Employee
        //
        public int getResultCountForEmployee(Results p)
        {
            int a = cs.getResultCountForEmployee(p);
            return a;
        }

       
        //
        //DAL call to get results for an Employee
        //
        public Results[] viewResultEmployee(Results s)
        {
            int count = cs.getResultCountForEmployee(s);
            Results[] arr = new Results[count];
            arr = cs.viewResultEmployee(s);
            return arr;
        }

        //Calculate Detailed Result
        public bool calculateResult(Answers[] a, Questions[] q, Results r, Employee emp)
        {

            bool flag = true;
            int count = q.Length;
            int total = 0;
            string[] abc;
            ResultsDAL d = new ResultsDAL();

            int i = d.getSectionCount(r);
            DetailedReports[] re = new DetailedReports[i];
            abc = new string[i];
            int[] section = new int[i];
            abc = d.loadSection(r, i);

            int[] totalQuestions = d.totalSectionQuestions(abc, r);

            for (int j = 0; j < count; j++)
            {

                //total = total + q[j].marks;
                if (a[j].answer.Equals(q[j].solution))
                {
                    string click = q[j].section;
                    for (int k = 0; k < i; k++)
                    {
                        if (click == abc[k])
                            section[k]++;
                    }
                }
            }


            for (int k = 0; k < i; k++)
            {
                re[k] = new DetailedReports();
                re[k].employee_ID = emp.employee_Id;
                re[k].exam_ID = r.exam_ID;
                re[k].section = abc[k];
                re[k].percentage = (section[k] * 100) / totalQuestions[k];
                flag = d.addDetailedResult(re[k]);
            }
            return flag;

        }


        //Calculate Highest, Lowest, Average
        public Exam_Details calculateResultFull(Results re)
        {
            Results[] r = cs.viewResult(re);
            Exam_Details ed = new Exam_Details();
            Exam_Details ed1 = new Exam_Details();
            ed.exam_ID = re.exam_ID;
            int highest = 0, lowest = 999, sum = 0;
            ed1 = cs.CheckResult(re);
            if (ed1.exam_ID != "ED000")
            {
                if (ed1.datetime.Date == DateTime.Today.Date)
                {
                    ed.exam_ID = "ED00";
                }
                else
                {
                    for (int i = 0; i < r.Length; i++)
                    {
                        if (highest < r[i].score)
                            highest = r[i].score;
                        if (lowest > r[i].score)
                            lowest = r[i].score;
                        sum += r[i].score;
                    }
                    ed.highest = highest;
                    ed.lowest = lowest;
                    ed.average = sum / r.Length;
                    bool feed = cs.addResult(ed);
                }
            }
            else if (cs.CheckResult(re).exam_ID == "ED000")
            {
                ed.exam_ID = "ED000";
            }
            else
                ed = cs.getExamDetails(ed);

            return ed;
        }

        /*
        public void addScore(Results r)
        {
            cs.addScore(r);
        }*/

    }

}