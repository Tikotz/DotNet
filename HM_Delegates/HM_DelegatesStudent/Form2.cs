using HM_Delegates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HM_DelegatesStudent
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public int PaidSums(Student student)
        {
            return student.Paid;
        }
        public int CostSums(Student student)
        {
            return student.Cost;
        }

        public double AgeAverage(Student student)
        {
            return student.Age;
        }
        public double GradeAverage(Student student)
        {
            return student.Grade;
        }
        public bool CheckSimilarStartFnameAndLname(Student student)
        {
            if (student.FirstName[0] == student.LastName[0])
            {
                return true;
            }
            return false;
        }
        public bool Studentgrade(Student student)
        {
            if (student.Grade < 50)
            {
                return true;
            }
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            StudentManage.Add(IdText.Text, NameText.Text, LastNameText.Text, int.Parse(AgeText.Text), int.Parse(GradeText.Text), int.Parse(CostText.Text), int.Parse(PaidText.Text));
            listBox1.Items.Clear();
            foreach (var student in StudentManage.StudentsList)
            {
                listBox1.Items.Add(student.ToString());
            }
            AllPaysText.Text = StudentManage.Sum(PaidSums).ToString();
            ToPayText.Text = StudentManage.Sum(CostSums).ToString();
            AvarageAgeText.Text = StudentManage.Average(AgeAverage).ToString();
            AvarageGradesText.Text = StudentManage.Average(GradeAverage).ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                bool remove = StudentManage.Remove(NameText.Text, LastNameText.Text);
                if (!remove)
                {
                    MessageBox.Show("Student not found");
                }
                else
                {
                    listBox1.Items.Clear();
                    foreach (var student in StudentManage.StudentsList)
                    {
                        listBox1.Items.Add(student.ToString());
                    }
                    AllPaysText.Text = StudentManage.Sum(PaidSums).ToString();
                    ToPayText.Text = StudentManage.Sum(CostSums).ToString();
                    AvarageAgeText.Text = StudentManage.Average(AgeAverage).ToString();
                    AvarageGradesText.Text = StudentManage.Average(GradeAverage).ToString();
                    MessageBox.Show("Student removed succesfully");
                }
            }
            catch
            {
                MessageBox.Show("Enter name in name text box");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (StudentManage.Contains(Studentgrade))
            {
                MessageBox.Show("Yes! there are grades lower then 50");
            }
            else
            {
                MessageBox.Show("No! There are no Grades under 50");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (StudentManage.Contains(CheckSimilarStartFnameAndLname))
            {
                MessageBox.Show("TRUE !, There is a student thet the first letter at the First name and Last name are the same");
            }
            else
            {
                MessageBox.Show("FALSE !, There are not a student thet the first letter at the First name and Last name are the same");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (var item in StudentManage.StudentsList)
            {
                var filterByAge = StudentManage.FilterByAge(item);
                if (filterByAge)
                {
                    MessageBox.Show("ther are student the are above 26 years old");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (var item in StudentManage.StudentsList)
            {
                var filterByLength = StudentManage.FilterByLength(item);
                if (filterByLength)
                {
                    MessageBox.Show("ther are not student that ther name contains less than 2 letters");
                }
            }
        }
    }
}
