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
using System.Timers;
using System.Threading;

namespace TheGitHubProjectForm
{
    public partial class Form2 : Form
    {
        List<Student> Nstudent = new List<Student>(30);
        string Gender;
        string Scholarship;
        
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Nstudent.Add(new Student
                {
                    surName = txtSurname.Text,
                    firstName = txtFirstname.Text,
                    dateOfBirth = Convert.ToDateTime(txtDOB.Text),
                    mathematicsMark = txtMathsgrade.Text,
                    physicsMark = txtPhysicsgrade.Text,
                    informaticsMark = txtITgrade.Text,
                    Age = DateTime.Now.Year - Convert.ToDateTime(txtDOB.Text).Year,
                    gender = Gender,
                    scholarship = Scholarship,
                    
                    
                    
                });

                txtFirstname.Clear();
                txtITgrade.Clear();
                txtDOB.Clear();
                txtMathsgrade.Clear();
                txtPhysicsgrade.Clear();
                txtSurname.Clear();
                txtDOB.Clear();
                btnMale.Checked = false;
                btnFemale.Checked = false;
                btnYes.Checked = false;
                btnNo.Checked = false;
            }
            catch (Exception)
            {
                lblNotification.ForeColor = Color.Red;
                 lblNotification.Text = "Error Occured!!";
                btnSave.Visible = false;
                button1.Visible = false;
                btnReset.Visible = true;

                
             
                
            }
           

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            using (FileStream fs = new FileStream("StudentData.txt", FileMode.Append, FileAccess.Write))
            {
                foreach (Student Stud in Nstudent)
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, Stud);
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Student data saved \n");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void btnMale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void btnFemale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void btnYes_CheckedChanged(object sender, EventArgs e)
        {
            Scholarship = "Yes";
        }

        private void btnNo_CheckedChanged(object sender, EventArgs e)
        {
            Scholarship = "No";
        }

        private void txtDOB_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Close();
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
