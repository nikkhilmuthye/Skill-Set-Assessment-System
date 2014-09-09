using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities2;
using Data1;

namespace Business1
{
    public class DetailedReportsBS
    {
        DetailedReportDAL dd = new DetailedReportDAL();

        //
        //DAL call to get number of Results for Detailed Report for a particular Exam
        //
        public int getResultCountForDetailedReport(Results p)
        {
            int a = dd.getResultCountForDetailedReport(p);
            return a;
        }


        //
        //DAL call to get Detailed Reports for an Exam
        //
        public DetailedReports[] getDetailedReports(Results s, int count)
        {
            DetailedReports[] arr = new DetailedReports[count];
            arr = dd.getDetailedReports(s, count);
            return arr;
        }

    }
}
