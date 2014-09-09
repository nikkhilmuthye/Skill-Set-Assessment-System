using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities2;
using Data1;


namespace Business1
{
    public class ResultStatusBS
    {
   
        ResultStatusDAL rsd = new ResultStatusDAL();

        //
        //DAL call to get the status of an employee for a given exam_type
        //
        public ResultStatus getResultStatus(ResultStatus rs)
        {
            rs = rsd.getResultStatus(rs);
            return rs;
        }


        //
        //DAL call to add result status for a first timer and returns success or error message
        //
        public string addResultStatus(ResultStatus rs)
        {
            string feedback = rsd.addResultStatus(rs);
            return feedback;
        }


        //
        //DAL call to update result status for a repeater and returns success or error message
        //
        public string updateResultStatus(ResultStatus rs)
        {
            string feedback = rsd.updateResultStatus(rs);
            return feedback;
        }


        //
        //DAL call to delete an Result Status for a particular Exam_Type and Employee in case of an error
        //
        public void deleteResultStatus(ResultStatus r)
        {
            rsd.deleteResultStatus(r);
            return;
        }
    }
}