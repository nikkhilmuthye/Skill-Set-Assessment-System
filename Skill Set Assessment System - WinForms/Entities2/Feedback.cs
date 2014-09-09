using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities2
{
    public class Feedback
    {
        public string Employee_ID, Exam_ID;
        public int Answer1, Answer2, Answer3, Answer4, Answer5;
        public string employee_ID
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

        public int answer1
        {
            get
            {
                return Answer1;
            }
            set
            {
                Answer1 = value;
            }
        }
        public int answer2
        {
            get
            {
                return Answer2;
            }
            set
            {
                Answer2 = value;
            }
        }
        public int answer3
        {
            get
            {
                return Answer3;
            }
            set
            {
                Answer3 = value;
            }
        }
        public int answer4
        {
            get
            {
                return Answer4;
            }
            set
            {
                Answer4 = value;
            }
        }
        public int answer5
        {
            get
            {
                return Answer5;
            }
            set
            {
                Answer5 = value;
            }
        }

    }
}

