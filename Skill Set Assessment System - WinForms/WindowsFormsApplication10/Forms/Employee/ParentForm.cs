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
    public partial class ParentForm : Form
    {
        public Employee emp = new Employee();

        public ParentForm(Employee ed)
        {
            InitializeComponent();
            emp = ed;
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {
            EmpHome f = new EmpHome(emp);
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }
    }
}
