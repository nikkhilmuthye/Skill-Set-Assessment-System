using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities2
{
    public class Bookmark
    {
        private int Question_No;
        private bool Status;

        public bool status
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
        
        public int question_No
        {
            get
            {
                return Question_No;
            }
            set
            {
                Question_No = value;
            }
        }
        
    }
}
