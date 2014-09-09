using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities2;
using Data1;

namespace Business1
{
    public class PaperBS
    {
        PaperDAL pq = new PaperDAL();
        ExamDetailDAL ed = new ExamDetailDAL();
            

        //
        //Gets the count of the unset Exam IDs
        //
        public int getUnsetPaperCount()
        {   
            int i = ed.getCount();
            int k = pq.getSetPaperCount();
            return (i - k);
        }
          

        //
        //Loads the Unset Exam IDs
        //
        public string[] loadUnsetExamID()
        {
            int i = ed.getCount();
            int k = pq.getSetPaperCount();

            string [] abc = new string[i];
            string [] def = new string[k];
            
            abc = ed.loadExamDetail(i);
            def = pq.loadSetExamID(k);

            string[] xyz = new string[i - k];
            int index = 0;
            bool present;
            for (int j = 0; j < i; j++)
            {
                present = false;
                for (int l = 0; l < k; l++)
                {
                    if (abc[j].Equals(def[l]))
                        present = true;
                }
                if (present == false)
                {
                    xyz[index] = abc[j];
                    index++;
                }
            }
            return xyz;
        }


        //
        //DAL call to get the number of added questions for a particular Exam ID
        //
        public int getAddedQuestionCount(Paper p)
        {
            int i = pq.getAddedQuestionCount(p);
            return i;
        }

        
        //
        //DAL call to add selected Section-Format-No Of Questions 
        //
        public string addSectionFormat(Paper s)
        {
            string abc = pq.addSectionFormat(s);
            return abc;
        }


        //
        //DAL call to get count of Exams for which paper has been set
        //
        public int getSetPaperCount()
        {
            int abc = pq.getSetPaperCount();
            return abc;
        }


        //
        //DAL call to load Exam IDs for which paper has been set
        //
        public string[] loadSetExamID(int i)
        {
            string[] abc = new string[i];
            abc = pq.loadSetExamID(i);
            return abc;
        }


        //
        //DAL call to get the No Of Questions for the Section-Format combination for the given Exam
        //
        public int getNoOfQuestions(Paper s)
        {
            int a = pq.getNoOfQuestions(s);
            return a;
        }


        //
        //DAL call to update selected Section-Format-No Of Questions 
        //
        public string updateSectionFormat(Paper s)
        {
            string feed = pq.updateSectionFormat(s);
            return feed;
        }


        //
        //DAL call to delete Paper
        //
        public string deletePaper(Paper b)
        {
            string abc = pq.deletePaper(b);
            return abc;
        }


        //
        //DAL call to get the row count for given Exam in Set Paper table
        //
        public int getRowCountForExam(Paper p)
        {
            int a = pq.getRowCountForExam(p);
            return a;
        }


        //
        //DAL call to get an array containing the paper Details for a given Paper
        //
        public Paper[] viewPaperDetails(Paper s, int count)
        {
            Paper[] arr = new Paper[count];
            arr = pq.viewPaperDetails(s, count);
            return arr;
        }


        public bool validateExam(int index)
        {
            if (index == -1)
                return false;
            else
                return true;
        }
        public bool validateSection(int index)
        {
            if (index == -1)
                return false;
            else
                return true;
        }
        public bool validateNumbers(int p1, int p2, int p3)
        {
            if (p1 == -1 || p2 == -1 || p3 == -1)
                return false;
            else
                return true;
        }
        public int getTotalQuestions(Paper pq)
        {
            PaperDAL ed = new PaperDAL();
            int count = ed.getTotalQuestions(pq);
            return count;
        }
        

        public bool validatePaper(int index)
        {
            if (index == -1)
            {
                return false;
            }
            else
                return true;
        }

        
        public Paper[] getPaperDetails(Paper p)
        {
            PaperDAL pq = new PaperDAL();
            int a = pq.getRowCountForExam(p);
            Paper[] g = new Paper[a];
            g = pq.getPaperDetails(p);
            return g;
        }
        
        

       /* public string[] loadPaperType(int i)
        {
            PaperDAL em = new PaperDAL();
            int k = em.getPaperCount();
            string[] abc = new string[k];
            abc = em.loadPaperType(k);
            return abc;

        }*/

        /*public Exam_Details getExamType(Exam_Details ed)
        {
            ExamDetailDAL e = new ExamDetailDAL();
            ed = e.getExamDetails(ed);
            return ed;
        }*/
    }
}