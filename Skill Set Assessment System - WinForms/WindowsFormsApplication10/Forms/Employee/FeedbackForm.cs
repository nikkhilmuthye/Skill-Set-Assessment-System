using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entities2;
using Business1;

namespace WindowsFormsApplication10
{
    public partial class FeedbackForm : Form
    {
        public Employee emp = new Employee();
        public Exam_Details ed = new Exam_Details();
        FeedbackBS f = new FeedbackBS();
            

        public FeedbackForm(Employee e, Exam_Details exd)
        {
            InitializeComponent();
            emp = e;
            ed = exd;
        }

        //
        //On click of Submit: Validates selection, stores feedback and navigates to Logout form
        //
        private void submit_Click(object sender, EventArgs e)
        {
           
            if((comboBox1.SelectedIndex == -1) || (comboBox2.SelectedIndex == -1) || (comboBox3.SelectedIndex== -1) || (comboBox4.SelectedIndex== -1) ||  (comboBox5.SelectedIndex == -1))
                MessageBox.Show("Please select a valid entry.","Error"); 
            else
            {
                Feedback g = new Feedback();
                g.employee_ID = emp.employee_Id;
                g.exam_ID = ed.exam_ID;
                g.answer1 = Convert.ToInt32(comboBox1.SelectedItem);
                g.answer2 = Convert.ToInt32(comboBox2.SelectedItem);
                g.answer3 = Convert.ToInt32(comboBox3.SelectedItem);
                g.answer4 = Convert.ToInt32(comboBox4.SelectedItem);
                g.answer5 = Convert.ToInt32(comboBox5.SelectedItem);
                string feed = f.addFeedback(g);
                MessageBox.Show(feed, "Feedback");

                LogoutForm fm9 = new LogoutForm(emp, ed);
                fm9.MdiParent = this.MdiParent;
                fm9.Dock = DockStyle.Fill;
                this.Close();
                fm9.Show();
            }   
        }
        

        //
        //On form Load: Displays Employee name, Exam ID, and adds items to the comboboxes
        //
        private void Feedback_Load(object sender, EventArgs e)
        {
            employeeNameLabel.Text = emp.first_Name + " " + emp.last_Name;
            examIDLabel.Text += ed.exam_ID;

            for (int i = 0; i <= 5; i++)
            {
                comboBox1.Items.Add(i);
                comboBox2.Items.Add(i);
                comboBox3.Items.Add(i);
                comboBox4.Items.Add(i);
                comboBox5.Items.Add(i);
                comboBox1.SelectedIndex = comboBox2.SelectedIndex = comboBox3.SelectedIndex = comboBox4.SelectedIndex = comboBox5.SelectedIndex =0;
            }
        }
    }
}
