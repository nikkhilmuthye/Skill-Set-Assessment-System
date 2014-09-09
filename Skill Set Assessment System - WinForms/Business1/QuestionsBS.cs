using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities2;
using Data1;

namespace Business1
{
    public class QuestionsBS
    {
        QuestionDAL cs = new QuestionDAL();


        //
        //Validates fields before adding Question
        //
        public String addQuestion(Questions e)
        {
            string feedback = "";
            bool feed = false;
            int i = 0;
            if (e.exam_Type == "")
            {
                feedback += (++i) + ". Exam Type  ";
                feed = true;
            }
            if (e.question == "")
            {
                feedback += (++i) + ". Question  ";
                feed = true;
            }
            if (e.solution == "")
            {
                feedback += (++i) + ". Solution  ";
                feed = true;
            }
            if (e.format.Equals("Match The Column"))
            {
                string temp = e.solution;
                if ((temp.Length != 4) || (temp.IndexOf("1") == -1) || (temp.IndexOf("2") == -1) || (temp.IndexOf("3") == -1) || (temp.IndexOf("4") == -1))
                {
                    feedback += (++i) + ". Solution  ";
                    feed = true;
                }
            }
            if (e.marks <= 0)
            {
                feedback += (++i) + ". Marks  ";
                feed = true;
            }
            if (e.section == "")
            {
                feedback += (++i) + ". Section  ";
                feed = true;
            }
            if (e.option1 == "")
            {
                feedback += (++i) + ". Option1  ";
                feed = true;
            }
            if (e.option2 == "")
            {
                feedback += (++i) + ". Option2  ";
                feed = true;
            }
            if (e.option3 == "")
            {
                feedback += (++i) + ". Option3  ";
                feed = true;
            }
            if (e.option4 == "")
            {
                feedback += (++i) + ". Option4  ";
                feed = true;
            }
            if (feed)
            {
                //Not valid: Returns erroneous fields
                return ("Please enter valid entries for: " + feedback);
            }
            else
            {
                //Valid: Adds Question and returns assigned Question ID or Error Message
                string feedDAL = cs.addQuestion(e);
                return feedDAL;
            }
        }


        //
        //Validates fields before updating Question
        //
        public String updateQuestion(Questions e)
        {
            string feedback = "";
            bool feed = false;
            int i = 0;
            if (e.exam_Type == "")
            {
                feedback += (++i) + ". Exam Type  ";
                feed = true;
            }
            if (e.question == "")
            {
                feedback += (++i) + ". Question  ";
                feed = true;
            }
            if (e.format == "")
            {
                feedback += (++i) + ". Format  ";
                feed = true;
            }
            if (e.solution == "")
            {
                feedback += (++i) + ". Solution  ";
                feed = true;
            }
            else if (e.format.Equals("Match The Column"))
            {
                string temp = e.solution;
                if ((temp.Length != 4) || (temp.IndexOf("1") == -1) || (temp.IndexOf("2") == -1) || (temp.IndexOf("3") == -1) || (temp.IndexOf("4") == -1))
                {
                    feedback += (++i) + ". Solution  ";
                    feed = true;
                }
            }
            if (e.marks <= 0)
            {
                feedback += (++i) + ". Marks  ";
                feed = true;
            }
            if (e.section == "")
            {
                feedback += (++i) + ". Section  ";
                feed = true;
            }
            if (!(e.format.Equals("Match The Column")))
            {
                if (e.option1 == "")
                {
                    feedback += (++i) + ". Option1  ";
                    feed = true;
                }
                if (e.option2 == "")
                {
                    feedback += (++i) + ". Option2  ";
                    feed = true;
                }
                if (e.option3 == "")
                {
                    feedback += (++i) + ". Option3  ";
                    feed = true;
                }
                if (e.option4 == "")
                {
                    feedback += (++i) + ". Option4  ";
                    feed = true;
                }
            }
            if (feed)
            {
                //Not valid: Returns erroneous fields
                return ("Please enter valid entries for: " + feedback);
            }
            else
            {
                //Valid: Updates Question and returns Success or Error Message
                string feedDAL = cs.updateQuestion(e);
                return feedDAL;
            }
        }

        
        //
        //DAL call to get the Next Question ID
        //
        public string getNext()
        {
            string next = cs.getNext();
            return next;
        }


        //
        //DAl call to delete an Question
        //
        public string deleteQuestion(Questions q)
        {   
            string feed = cs.deleteQuestion(q);
            return feed;
        }


        //
        //DAL call to get all the Question IDs in an array
        //
        public string[] loadQuestion(int i)
        {
            int k = cs.getCount();
            string[] abc = new string[k];
            abc = cs.loadQuestion(k);
            return abc;
        }


        //
        //DAL call to get the number of Question
        //
        public int getCount()
        {
            int i = cs.getCount();
            return i;
        }


        //
        //DAL call to get other fields of a Question given the Question ID
        //
        public Questions getQuestion(Questions q)
        {
            q = cs.getQuestion(q);
            return q;
        }


        //
        //DAL call to get count of Sections for a given Exam Type
        //
        public int getSectionCount(Questions q)
        {
            int abc = cs.getSectionCount(q);
            return abc;
        }


        //
        //DAL call to load Sections for a given Exam Type
        //
        public string[] loadSection(Questions q, int i)
        {
            string[] abc = new string[i];
            abc = cs.loadSection(q, i);
            return abc;
        }


        //
        //DAL call to get count of Formats for a given Exam Type and Section
        //
        public int getFormatCount(Questions q)
        {
            int abc = cs.getFormatCount(q);
            return abc;
        }


        //
        //DAL call to load Formats for a given Exam Type and Section
        //
        public string[] loadFormat(Questions q, int k)
        {
            string[] abc = new string[k];
            abc = cs.loadFormat(q, k);
            return abc;
        }


        //
        //DAL call to get count of Questions for a given Exam Type, Section & Format  
        //
        public int getQuestionNoCount(Questions q)
        {
            int abc = cs.getQuestionNoCount(q);
            return abc;
        }

       
        //
        //DAL call to randomly selects questions for each Format-Section specification of the Paper as per the No Of Questions and Shuffles the question
        //
        public Questions[] getQuestionPaper(Paper [] arr, Questions[] q, Exam_Details ed)
        {
            q = cs.getQuestionPaper(arr, q, ed);

            //Shuffles the questions: Setp 1: Gets random order for shuffling
            Questions[] qtemp = new Questions[q.Length];
            q.CopyTo(qtemp, 0);
            Random r1 = new Random();
            int[] order = new int[q.Length];
            int no = 0;
            int m;
            bool sign = false;
            while (no < q.Length)
            {
                m = r1.Next(q.Length);
                sign = false;
                for (int j = 0; j < q.Length - 1; j++)
                {
                    if (order[j] == m)
                    {
                        sign = true;
                    }
                }
                if (!sign)
                {
                    order[no] = m;
                    no++;
                }
            }

            //Shuffles the questions: Setp 2: Re-orders question according to the random order
            for (int i = 0; i < q.Length; i++)
            {
                q[i] = qtemp[order[i]];
            }
            return q;
        }
        
        
        //
        //Validates fields before adding Picture Question
        //
        public String addPictureQuestion(Questions e, Picture p)
        {
            string feedback = "";
            bool feed = false;
            int i = 0;
            if (e.exam_Type == "")
            {
                feedback += (++i) + ". Exam Type  ";
                feed = true;
            }
            if (e.question == "")
            {
                feedback += (++i) + ". Question  ";
                feed = true;
            }
            if (e.solution == "")
            {
                feedback += (++i) + ". Solution  ";
                feed = true;
            }
            if (e.marks <= 0)
            {
                feedback += (++i) + ". Marks  ";
                feed = true;
            }
            if (e.section == "")
            {
                feedback += (++i) + ". Section  ";
                feed = true;
            }
            if (e.option1 == "")
            {
                feedback += (++i) + ". Option1  ";
                feed = true;
            }
            if (e.option2 == "")
            {
                feedback += (++i) + ". Option2  ";
                feed = true;
            }
            if (e.option3 == "")
            {
                feedback += (++i) + ". Option3  ";
                feed = true;
            }
            if (e.option4 == "")
            {
                feedback += (++i) + ". Option4  ";
                feed = true;
            }
            if (p.image == null)
            {
                feedback += (++i) + ". Image ";
                feed = true;
            }
            if (feed)
            {
                //Not valid: Returns erroneous fields
                return ("Please enter valid entries for: " + feedback);
            }
            else
            {
                //Valid: Adds Question and returns assigned Question ID or Error Message
                string feedDAL = cs.addPictureQuestion(e, p);
                return feedDAL;
            }
        }



        //
        //Validates fields before updating Picture Question
        //
        public String updatePictureQuestion(Questions e, Picture p)
        {
            string feedback = "";
            bool feed = false;
            int i = 0;
            if (e.exam_Type == "")
            {
                feedback += (++i) + ". Exam Type  ";
                feed = true;
            }
            if (e.question == "")
            {
                feedback += (++i) + ". Question  ";
                feed = true;
            }
            if (e.solution == "")
            {
                feedback += (++i) + ". Solution  ";
                feed = true;
            }
            if (e.marks <= 0)
            {
                feedback += (++i) + ". Marks  ";
                feed = true;
            }
            if (e.section == "")
            {
                feedback += (++i) + ". Section  ";
                feed = true;
            }
            if (e.option1 == "")
            {
                feedback += (++i) + ". Option1  ";
                feed = true;
            }
            if (e.option2 == "")
            {
                feedback += (++i) + ". Option2  ";
                feed = true;
            }
            if (e.option3 == "")
            {
                feedback += (++i) + ". Option3  ";
                feed = true;
            }
            if (e.option4 == "")
            {
                feedback += (++i) + ". Option4  ";
                feed = true;
            }
            if (p.image == null)
            {
                feedback += (++i) + ". Image ";
                feed = true;
            }
            if (feed)
            {
                //Not valid: Returns erroneous fields
                return ("Please enter valid entries for: " + feedback);
            }
            else
            {
                //Valid: Updates Question and returns Success or Error Message
                string feedDAL = cs.updatePictureQuestion(e, p);
                return feedDAL;
            }
        }


        //
        //DAL call to add Questions in Bulk
        //
        public String addQuestionsBulk(String path)
        {
            String result = cs.addQuestionsBulk(path);
            return result;
        }


        //
        //DAL call to get the Picture_ID for the question, and retrieve the corresponding image
        //
        public byte[] getImage(Questions q)
        {
            byte[] a = cs.getImage(q);
            return a;
        }
        
        
        public Questions getQuestion(int index)
        {
            QuestionDAL cs = new QuestionDAL();
            Questions et = new Questions();
            et = cs.getQuestion(index);
            return et;

        }



        //Swap Options
        public Questions[] swapOptions(Questions[] qtemp)
        {
            Questions[] q = new Questions[qtemp.Length];
            for (int i = 0; i < qtemp.Length; i++)
            {
                if (qtemp[i].format == "Match The Column")
                {
                    q[i] = this.swapMatchTheFollowing(qtemp[i]);
                }
                else if (qtemp[i].format == "MCQ (Single Answer)" || qtemp[i].format == "Picture Question: Single Answer" )
                {
                    q[i] = this.swapSingleAnswer(qtemp[i]);
                }
                else if (qtemp[i].format == "MCQ (Multiple Answers)" || qtemp[i].format == "Picture Question: Multiple Answer" )
                {
                    q[i] = this.swapMultipleChoice(qtemp[i]);
                }
                /*else
                {
                    q[i] = this.swapPictureOption(qtemp[i]);
                }*/
            }
            return q;
        }

        //Swap Match the following options

        public Questions swapMatchTheFollowing(Questions a)
        {
            Questions b = new Questions();

            b.exam_Type = a.exam_Type;
            b.format = a.format;
            b.marks = a.marks;
            b.question = a.question;
            b.question_ID = a.question_ID;
            b.section = a.section;
            //b.picture_ID = a.picture_ID;
            //b.solution = a.solution;
            //String option = a.solution;

            Random r = new Random();
            int r1 = r.Next(1,3);
            string temp;
            if (r1 == 1)
            {
                b.option2 = a.option1;
                b.option3 = a.option2;
                b.option4 = a.option3;
                b.option1 = a.option4;
                temp = a.solution;

                for (int i = 0; i < 4; i++)
                {
                    //int gef = Convert.ToInt32(temp.ElementAt(i));
                    //gef++;
                    //if (gef > 4)
                    //{
                    //    gef = gef - 4;
                    //    b.solution += "" + gef;
                    //}
                    switch (temp.ElementAt(i))
                    {
                        case '1':
                            b.solution += "2";
                            break;
                        case '2':
                            b.solution += "3";
                            break;
                        case '3':
                            b.solution += "4";
                            break;
                        case '4':
                            b.solution += "1";
                            break;
                    }
                }

            }
            else if (r1 == 2)
            {
                b.option3 = a.option1;
                b.option4 = a.option2;
                b.option1 = a.option3;
                b.option2 = a.option4;
                temp = a.solution;
                for (int i = 0; i < 4; i++)
                {
                    //int gef = Convert.ToInt32(temp.ElementAt(i));
                    //gef=gef+2;
                    //if (gef > 4)
                    //{
                    //    gef = gef - 4;
                    //    b.solution += "" + gef;
                    //}

                    switch (temp.ElementAt(i))
                    {
                        case '1':
                            b.solution += "3";
                            break;
                        case '2':
                            b.solution += "4";
                            break;
                        case '3':
                            b.solution += "1";
                            break;
                        case '4':
                            b.solution += "2";
                            break;
                    }
                }
            }
            else
            {
                b.option4 = a.option1;
                b.option1 = a.option2;
                b.option2 = a.option3;
                b.option3 = a.option4;
                temp = a.solution;
                for (int i = 0; i < 4; i++)
                {
                    //int gef = Convert.ToInt32(temp.ElementAt(i));
                    //gef = gef+3;
                    //if (gef > 4)
                    //{
                    //    gef = gef - 4;
                    //    b.solution += "" + gef;
                    //}

                    switch (temp.ElementAt(i))
                    {
                        case '1':
                            b.solution += "3";
                            break;
                        case '2':
                            b.solution += "4";
                            break;
                        case '3':
                            b.solution += "1";
                            break;
                        case '4':
                            b.solution += "2";
                            break;
                    }
                }
            }

            return b;
        }

        //Swap Single Choice options

        public Questions swapSingleAnswer(Questions a)
        {
            Questions b = new Questions();

            b.exam_Type = a.exam_Type;
            b.format = a.format;
            b.marks = a.marks;
            b.question = a.question;
            b.question_ID = a.question_ID;
            b.section = a.section;
            b.picture_ID = a.picture_ID;
            string option;
            String ans = a.solution;
            if (ans == "1")
                option = a.option1;
            else if (ans == "2")
                option = a.option2;
            else if (ans == "3")
                option = a.option3;
            else
                option = a.option4;
            Random r = new Random();
            int r1 = r.Next(2, 4);

            if (r1 == 2)
            {
                b.option2 = a.option1;
                b.option3 = a.option2;
                b.option4 = a.option3;
                b.option1 = a.option4;
            }
            else if (r1 == 3)
            {
                b.option3 = a.option1;
                b.option4 = a.option2;
                b.option1 = a.option3;
                b.option2 = a.option4;
            }
            else
            {
                b.option4 = a.option1;
                b.option1 = a.option2;
                b.option2 = a.option3;
                b.option3 = a.option4;
            }
            if (option == b.option1)
                b.solution = "1";
            else if (option == b.option2)
                b.solution = "2";
            else if (option == b.option3)
                b.solution = "3";
            else
                b.solution = "4";
            return b;
        }

        //Swap Multiple Choice Options
        public Questions swapMultipleChoice(Questions a)
        {
            Questions b = new Questions();

            b.exam_Type = a.exam_Type;
            b.format = a.format;
            b.marks = a.marks;
            b.question = a.question;
            b.question_ID = a.question_ID;
            b.section = a.section;
            b.picture_ID = a.picture_ID;
            String ans = a.solution;
            Random r = new Random();
            int r1 = r.Next(2, 4);

            if (r1 == 2)
            {
                b.option2 = a.option1;
                b.option3 = a.option2;
                b.option4 = a.option3;
                b.option1 = a.option4;

                if (ans.Contains("4"))
                    b.solution += "1";
                if (ans.Contains("1"))
                    b.solution += "2";
                if (ans.Contains("2"))
                    b.solution += "3";
                if (ans.Contains("3"))
                    b.solution += "4";
            }
            else if (r1 == 3)
            {
                b.option3 = a.option1;
                b.option4 = a.option2;
                b.option1 = a.option3;
                b.option2 = a.option4;

                if (ans.Contains("4"))
                    b.solution += "1";
                if (ans.Contains("1"))
                    b.solution += "2";
                if (ans.Contains("2"))
                    b.solution += "3";
                if (ans.Contains("3"))
                    b.solution += "4";
            }
            else
            {
                b.option4 = a.option1;
                b.option1 = a.option2;
                b.option2 = a.option3;
                b.option3 = a.option4;

                if (ans.Contains("4"))
                    b.solution += "1";
                if (ans.Contains("1"))
                    b.solution += "2";
                if (ans.Contains("2"))
                    b.solution += "3";
                if (ans.Contains("3"))
                    b.solution += "4";
            }
            return b;
        }

        //Gives total Section Count
        public int getSectionCount()
        {
            int i = cs.getSectionCount();
            return i;
        }


        //
        //DAL call to get all the Exam ID's in an array
        //
        public string[] loadSection(int i)
        {
            int k = cs.getSectionCount();
            string[] abc = new string[k];
            abc = cs.loadSection(k);

            return abc;
        }


        /*public bool validate(int index)
        {
            if (index == -1)
            {
                return false;
            }
            else
                return true;
        }

        public bool validatedeleteQuestion(int index)
        {
            if (index == -1)
            {
                return false;
            }
            else
                return true;
        }
        */

    }
}