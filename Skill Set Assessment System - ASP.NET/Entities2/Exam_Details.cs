using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities2
{
    public class Exam_Details
    {
        private string Exam_ID, Exam_Type, Answer_Config;
        private DateTime Datetime;
        private int Highest, Lowest,Duration;
        private float Average;

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

        public string answer_Config
        {
            get
            {
                return Answer_Config;
            }
            set
            {
                Answer_Config = value;
            }
        }

        public int duration
        {
            get
            {
                return Duration;
            }
            set
            {
                Duration = value;
            }
        }

        public DateTime datetime
        {
            get
            {
                return Datetime;
            }
            set
            {
                Datetime = value;
            }
        }

        public int highest
        {
            get
            {
                return Highest;
            }
            set
            {
                Highest = value;
            }
        }

        public int lowest
        {
            get
            {
                return Lowest;
            }
            set
            {
                Lowest = value;
            }
        }

        public float average
        {
            get
            {
                return Average;
            }
            set
            {
                Average = value;
            }
        }
        

    }
}

