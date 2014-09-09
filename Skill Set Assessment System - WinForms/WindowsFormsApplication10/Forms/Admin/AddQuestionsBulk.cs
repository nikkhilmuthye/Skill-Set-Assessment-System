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
    public partial class AddQuestionsBulk : Form
    {
        string path = "";
        QuestionsBS q = new QuestionsBS();
            

        public AddQuestionsBulk()
        {
            InitializeComponent();
        }

        private void select_Click(object sender, EventArgs e)
        {
            string filename = "";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                openFileDialog1.Filter = "Excel files (*.xls or *.xlsx)|*.xls;*.xlsx";
                filename = System.IO.Path.GetFileName(openFileDialog1.FileName);
                path = System.IO.Path.GetDirectoryName(openFileDialog1.FileName);
            }
            path = path + "\\" + filename;
            textBox1.Text = path;
        }

        private void add_Click(object sender, EventArgs e)
        {
            string result = q.addQuestionsBulk(path);
            MessageBox.Show(result);
        }

        //
        //On click of Back button: Navigates to Admin Home
        //

        private void back_Click(object sender, EventArgs e)
        {
          
            this.Close();
        }

        private void AddQuestionsBulk_Load(object sender, EventArgs e)
        {
            // to allign the Legend(Group Box) to
            // the center of form
		    int centerForm;
            int centerGroup;
            int groupStartPosition;

            centerForm = this.Width / 2;
            centerGroup = AddQuestionBulkLegend.Width / 2;
            groupStartPosition = centerForm - centerGroup;
            AddQuestionBulkLegend.Left = groupStartPosition; 
        }
    }
}
