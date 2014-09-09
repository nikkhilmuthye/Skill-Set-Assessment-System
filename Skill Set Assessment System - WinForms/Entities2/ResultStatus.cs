using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities2
{
    public class ResultStatus
    {
        public string Employee_ID, Exam_Type, Status;
        public int Attempt_No;

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

        public string status
        {
            get
            {
                return Status;
            }
            set
            {
                Status = value;
            }
        }

        public int attempt_No
        {
            get
            {
                return Attempt_No;
            }
            set
            {
                Attempt_No = value;
            }
        }
    }
}
