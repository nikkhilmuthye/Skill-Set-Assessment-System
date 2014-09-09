using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities2
{
    public class Paper
    {
        private string Exam_ID, Section, Format;
        private int No_Of_Questions;
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
       
        public int no_Of_Questions
        {
            get
            {
                return No_Of_Questions;
            }
            set
            {
                No_Of_Questions = value;
            }
        }
    }
}
