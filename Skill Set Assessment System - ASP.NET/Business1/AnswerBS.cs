using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities2;
using Data1;


namespace Business1
{
    public class AnswerBS
    {
        AnswersDAL d = new AnswersDAL();


        //
        //Calculates marks for each question and the total, stores them in Answers array, DAL call to store the answers in the Answers table, and final results in the Result table 
        //
        public bool submit(Answers[] a, Questions[] q, Employee emp, Exam_Details ed)
        {
            //Calculates marks for each question (stores them in Answers array), total and percentage
            int score = 0;
            int outOf = 0;
            float per = 0;
            for (int i = 0; i < q.Length; i++)
            {
                if (a[i].answer.Equals(q[i].solution))
                    a[i].marks = q[i].marks;
                else
                    a[i].marks = 0;
                score += a[i].marks;
                outOf += q[i].marks;
            }
            per = (score *100) / outOf;

            //DAL call to store the answers in the Answers table
            bool feed = d.submitAnswers(a);

            //DAL call to store final result in the Result table 
            if (feed)
            {
                Results re = new Results();
                re.employee_ID = emp.employee_Id;
                re.exam_ID = ed.exam_ID;
                re.score = score;
                re.percentage = per;
                ResultsDAL rb = new ResultsDAL();
                bool feed1 = rb.addScore(re);
                if (feed1)
                {
                    ResultStatusDAL rsd = new ResultStatusDAL();
                    ResultStatus rs = new ResultStatus();
                    rs.employee_ID = emp.employee_Id;
                    rs.exam_Type = ed.exam_Type;
                    if (re.percentage >= 50.0)
                        rs.status = "Passed";
                    else
                        rs.status = "Failed";
                    bool feed2 = rsd.updateStatus(rs);
                    if (feed2)
                        return true;
                    else
                        return false;
                }
                else
                    return false;
            }
            else
                return false;
        }


        //
        //Stores the given answer for given question in the Answer array and returns the array
        //
        public Answers[] storeAnswer(Answers [] a, int index, string ans)
        {
            a[index].answer = ans;
            return a;
        }


        //
        //Initializes the fields of Answers array including answers
        //
        public Answers[] initializeAnswersArray(Answers[] a, Questions[] q, Exam_Details ed, Employee emp)
        {
            for (int i = 0; i < q.Length; i++)
            {
                a[i] = new Answers();
                a[i].exam_ID = ed.exam_ID;
                a[i].employee_Id = emp.employee_Id;
                a[i].question_ID = q[i].question_ID;
                a = this.storeAnswer(a, i, "");
            }
            return a;
        }


        //
        //Initializes the Bookmarks array 
        //
        public Bookmark[] initializeBookmarksArray(Bookmark [] b)
        {
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = new Bookmark();
                b[i].question_No = i + 1;
                b[i].status = false;
            }
            return b;
        }



        /*
        //
        //Calculates and stores the marks for all the questions in the array, and returns the total score
        //
        public int calculateScore(Answers[] a, Questions[] q)
        {
            int score = 0;
            for (int i = 0; i < q.Length; i++)
            {
                if (a[i].answer.Equals(q[i].solution))
                    a[i].marks = q[i].marks;
                else
                    a[i].marks = 0;
                score += a[i].marks;
            }
            return score;

            //AnswersDAL ab = new AnswersDAL();
            //ab.addScore(a, score);
        }*/       

        /* //
        //DAL call to store the answers in the Answer table
        //
        public bool submitAnswer(Answers[] a)
        {
            bool feed = d.submitAnswer(a);
            return feed;
        }*/

    }
}
