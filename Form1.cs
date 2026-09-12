using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Windows.Forms;

namespace Rethabile_Ledidi_601910
{
    public partial class Form1 : Form
    {
        Manager manager = new Manager();
        public Form1()

        {
            manager.OnResultProcessed += Manager_OnResultProcessed;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboCourse.Items.AddRange(Enum.GetNames(typeof(CourseType)));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtStudentID.Text == "" || txtName.Text == "" || txtMark.Text == "")
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            Student s = new Student();
            s.StudentID = int.Parse(txtStudentID.Text);
            s.Name = txtName.Text;
            s.Course = (CourseType)Enum.Parse(typeof(CourseType), comboCourse.Text);
            s.Mark = double.Parse(txtMark.Text);

            manager.AddStudent(s);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = manager.students;
        }

        private void Manager_OnResultProcessed(Student s)
        {
            MessageBox.Show("Student " + s.Name + " added. Result: " + s.GetResult());
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
    

