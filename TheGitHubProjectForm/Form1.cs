using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace TheGitHubProjectForm
{
    public partial class Form1 : Form
    {
        List<Student> Nstudent = new List<Student>(30);
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            Hide();
            f2.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }
    }
}
