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
    public partial class StartParent : Form
    {
        public StartParent()
        {
            InitializeComponent();
        }

        private void StartParent_Load(object sender, EventArgs e)
        {
            Home f = new Home();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }
    }
}
