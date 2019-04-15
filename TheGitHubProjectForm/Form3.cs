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
    public partial class Form3 : Form
    {
        StringBuilder sb = new StringBuilder();
        StringBuilder sb2 = new StringBuilder();

        public List<Student> Nstudent = new List<Student>(30);
        public Form3()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            btnShow.Visible = false;
            btnPromoted.Visible = true;
            FileStream fs = new FileStream("StudentData.txt", FileMode.Open, FileAccess.Read);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            while (fs.Position < fs.Length)
            {
                Nstudent.Add((Student)binaryFormatter.Deserialize(fs));
                

                // ps = ((Student)binaryFormatter.Deserialize(fs));

            }
            foreach (Student stud in Nstudent)
            {
                
                sb.Append("Firstname: "+stud.firstName + " ");
                sb.Append(Environment.NewLine);
                sb.Append("Surname: "+stud.surName+ " ");
                sb.Append(Environment.NewLine);
                sb.Append("Gender: " + stud.gender + " ");
                sb.Append(Environment.NewLine);
                sb.Append("Age: " + stud.Age + " ");
                sb.Append(Environment.NewLine);
                sb.Append("Maths Grade: "+stud.mathematicsMark + " ");
                sb.Append(Environment.NewLine);
                sb.Append("Physics Grade: " + stud.physicsMark + " ");
                sb.Append(Environment.NewLine);
                sb.Append("IT Grade: " + stud.informaticsMark + " ");
                sb.Append(Environment.NewLine);
                sb.Append("Scholarsip? " + stud.scholarship + " ");
                sb.Append(Environment.NewLine);
                sb.Append(Environment.NewLine);
            }

            txtDisplay.Text = "\n"+sb.ToString() + "";
           
            
                
           
            fs.Close();


        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void btnPromoted_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            btnPromoted.Visible = false;
            //PromotedStudents fp = new PromotedStudents();
            //fp.Show();

            foreach (Student std in Nstudent)
            {

                if (Convert.ToInt32(std.informaticsMark) + Convert.ToInt32(std.mathematicsMark) + Convert.ToInt32(std.physicsMark) > 140)
                {
                    //Console.ForegroundColor = ConsoleColor.White;
                    sb2.Append(std.firstName + " " + std.surName + " Is Promoted");
                    sb2.Append(Environment.NewLine);
                }
                else {
                    sb2.Append(std.firstName + " " + std.surName + " Failed");
                    sb2.Append(Environment.NewLine);
                }
            }
            txtDisplay.Text = sb2.ToString();

        }
    }
}
