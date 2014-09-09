using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities2
{
    public class Answers
    {
        private string Employee_ID, Exam_ID, Question_ID, Answer;
        private int Marks;


        public string employee_Id
        {
            get
            {
                return Employee_ID;
            }
            set
            {
                Employee_ID = value;
            }
        }
        

        public string exam_ID
        {
            get
            {
                return Exam_ID;
            }
            set
            {
                Exam_ID = value;
            }
        }
        

        public string question_ID
        {
            get
            {
                return Question_ID;
            }
            set
            {
                Question_ID = value;
            }
        }


        public string answer
        {
            get
            {
                return Answer;
            }
            set
            {
                Answer = value;
            }
        }
        

        public int marks
        {
            get
            {
                return Marks;
            }
            set
            {
                Marks = value;
            }
        }
        
    }
}
