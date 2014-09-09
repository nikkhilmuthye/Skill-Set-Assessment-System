using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities2
{
    public class Questions
    {
        private String Question_ID, Exam_Type, Format, Question, Option1, Option2, Option3, Option4, Solution, Section, Picture_ID;
        private int Marks;


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
        public string exam_Type
        {
            get
            {
                return Exam_Type;
            }
            set
            {
                Exam_Type = value;
            }
        }
        public string format
        {
            get
            {
                return Format;
            }
            set
            {
                Format = value;
            }
        }
        public string question
        {
            get
            {
                return Question;
            }
            set
            {
                Question = value;
            }
        }
        public string option1
        {
            get
            {
                return Option1;
            }
            set
            {
                Option1 = value;
            }
        }
        public string option2
        {
            get
            {
                return Option2;
            }
            set
            {
                Option2 = value;
            }
        }
        public string option3
        {
            get
            {
                return Option3;
            }
            set
            {
                Option3 = value;
            }
        }
        public string option4
        {
            get
            {
                return Option4;
            }
            set
            {
                Option4 = value;
            }
        }
        public string solution
        {
            get
            {
                return Solution;
            }
            set
            {
                Solution = value;
            }
        }
        public string section
        {
            get
            {
                return Section;
            }
            set
            {
                Section = value;
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
        public string picture_ID
        {
            get
            {
                return Picture_ID;
            }
            set
            {
                Picture_ID = value;
            }
        }

    }
}

