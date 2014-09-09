using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities2
{
    public class Exam_Types
    {
        private string Exam_Type,Subject;
        private int Level_Number,No_Of_Attempts;

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
          
          public string subject
        {
            get
            {
                return Subject;
            }
            set
            {
                Subject = value;
            }
        }
        
        public int level_Number
        {
            get
            {
                return Level_Number;
            }
            set
            {
                Level_Number = value;
            }
        }
         
        public int no_Of_Attempts
        {
            get
            {
                return No_Of_Attempts;
            }
            set
            {
                No_Of_Attempts = value;
            }
        }
    }
}
