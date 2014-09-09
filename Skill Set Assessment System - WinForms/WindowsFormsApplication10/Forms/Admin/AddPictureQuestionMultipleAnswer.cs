using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Entities2;
using Business1;

namespace WindowsFormsApplication10
{
    public partial class AddPictureQuestionMultipleAnswer : Form
    {
        QuestionsBS ed = new QuestionsBS();
        Picture p = new Picture();

        public AddPictureQuestionMultipleAnswer()
        {
            InitializeComponent();
        }

        private void AddPictureQuestionMultipleAnswer_Load(object sender, EventArgs e)
        {
            
            // to allign the Legend(Group Box) to
            // the center of form
		    int centerForm;
            int centerGroup;
            int groupStartPosition;

            centerForm = this.Width / 2;
            centerGroup = AddPQMALegend.Width / 2;
            groupStartPosition = centerForm - centerGroup;
            AddPQMALegend.Left = groupStartPosition;
 

            //Loads Marks
            for (int j = 0; j <= 5; j++)
            {
                marksCombo.Items.Add(j + 1);
            }
            marksCombo.SelectedIndex = 0;

            //Displays Format
            formatText.Text = "Picture Question: Multiple Answer";

            //Loads Exam Types
            Exam_TypeBS em = new Exam_TypeBS();
            int i = em.getCount();
            string[] abc = new string[i];
            abc = em.loadExamType(i);
            for (int j = 0; j < i; j++)
            {
                examTypeCombo.Items.Add(abc[j]);
            }
            examTypeCombo.SelectedIndex = 0;

            //Loads Sections

            int k = ed.getSectionCount();
            if (k > 0)
            {
                string[] bcd = new string[k];
                bcd = ed.loadSection(k);

                for (int j = 0; j < k; j++)
                {
                    sectioncomboBox.Items.Add(bcd[j]);
                }
                sectioncomboBox.SelectedIndex = 0;
            }
        }

        //
        //On click of Back button: Navigates to Admin Home
        //
        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //
        //On click of browse button: Displays the Open File Dialog, read picture, and displays the selected picture in Picture Box
        //
        private void browse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
                sr.Close();
            }
            FileInfo filimage = new FileInfo(openFileDialog1.FileName);
            long n = filimage.Length;

            p.image = new byte[Convert.ToInt32(n)];
            FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read, FileShare.Read);
            int b = fs.Read(p.image, 0, Convert.ToInt32(n));
            pictureBox1.Image = Image.FromStream(fs);
            fs.Close();
        }


        //
        //On click of Add button: Validates, adds question and picture, displays assigned Question ID & Picture ID
        //
        private void add_Click(object sender, EventArgs e)
        {
            if ((marksCombo.SelectedIndex == -1) || (examTypeCombo.SelectedIndex == -1))
                MessageBox.Show("Please select a valid entry", "Error");
            else
            {
                Questions que = new Questions();
                que.exam_Type = examTypeCombo.Text.ToString();
                que.question = questionText.Text.ToString();
                que.format = formatText.Text.ToString();
                que.option1 = option1Text.Text.ToString();
                que.option2 = option2Text.Text.ToString();
                que.option3 = option3Text.Text.ToString();
                que.option4 = option4Text.Text.ToString();
                string t = marksCombo.Text.ToString();
                if (t == "")
                    que.marks = 0;
                else
                    que.marks = Convert.ToInt32(t);
                if (sectioncomboBox.SelectedIndex != -1)
                    que.section = sectioncomboBox.SelectedItem.ToString();
                else if (sectioncomboBox.Text != "")
                    que.section = sectioncomboBox.Text.ToString();
                else
                    MessageBox.Show("Enter Section");

                string sol = "";
                if (option1Check.Checked)
                    sol = sol + "1";
                if (option2Check.Checked)
                    sol = sol + "2";
                if (option3Check.Checked)
                    sol = sol + "3";
                if (option4Check.Checked)
                    sol = sol + "4";
                que.solution = sol;

                string feedback = ed.addPictureQuestion(que, p);
                

                if (feedback.Contains("successfully"))
                {
                    option1Check.Checked = option2Check.Checked = option3Check.Checked = option4Check.Checked = false;
                    examTypeCombo.SelectedIndex = marksCombo.SelectedIndex = 0;
                    questionText.Text = formatText.Text = option1Text.Text = option2Text.Text = option3Text.Text = option4Text.Text = "";
                    pictureBox1.Image = null;
                }

                MessageBox.Show(feedback, "Add Question");
            }
        }
    }
}
