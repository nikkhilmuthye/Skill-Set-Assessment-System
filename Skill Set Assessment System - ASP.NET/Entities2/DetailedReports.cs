using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities2
{
    public class DetailedReports
    {
        public string Employee_ID, Exam_ID,Section;
        public float Percentage;

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
        public float percentage
        {
            get
            {
                return Percentage;
            }
            set
            {
                Percentage = value;
            }
        }
    }
}

