using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities2;
using Data1;

namespace Business1
{
    public class FeedbackBS
    {
        FeedbackDAL f2 = new FeedbackDAL();
       
        public string addFeedback(Feedback f)
        {   
            string feed = f2.addFeedback(f);
            return feed;
        }
    }
}
