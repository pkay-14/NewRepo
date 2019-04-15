using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheGitHubProjectForm
{
    public partial class PromotedStudents : Form3
    {
        StringBuilder sb2 = new StringBuilder();
        public PromotedStudents()
        {
            InitializeComponent();
        }

        private void PromotedStudents_Load(object sender, EventArgs e)
        {
            
            foreach (Student std in Nstudent)
            {

                if (Convert.ToInt32( std.informaticsMark + std.mathematicsMark + std.physicsMark) > 140)
                {
                    //Console.ForegroundColor = ConsoleColor.White;
                    sb2.Append(std.firstName + " " + std.surName + "Is Promoted");
                    sb2.Append(Environment.NewLine);
                }
            }
            txtPromoted.Text = sb2.ToString();
        }
    }
}
