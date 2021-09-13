using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HM_Generics
{

    public partial class Form1 : Form
    {
        #region 2
        ReadOnlyCollection<Students> studentsManage = new ReadOnlyCollection<Students>();
        #endregion
        #region 3
        collection_targil3<int> intlist= new collection_targil3<int>();
        collection_targil3<double> doublelist = new collection_targil3<double>();
        collection_targil3<char> charlist = new collection_targil3<char>();
        #endregion
        #region 4
        CreateInstance<Person> cip = new CreateInstance<Person>();
        
        #endregion
        #region 7
        ClassWithName basename = new ClassWithName();
        #endregion
        #region 5
        Stack<int> stackint = new Stack<int>();
        #endregion
        #region 6 
        Queue<int> queueint= new Queue<int>();
        #endregion

        public Form1()
        {
            InitializeComponent();
        }
       

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            studentsManage.AddToList(new Students());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            studentsManage.stopReadOnly();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox4.Text = studentsManage.FindById(int.Parse(textBox3.Text));
            }
            catch
            {

                textBox4.Text = "somthing wrong";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (type.Text == "int")
            {
                 intlist.AddItem(int.Parse(add.Text));
                
            }
            else if (type.Text == "double")
            {
                 doublelist.AddItem(double.Parse(add.Text));
            }
            else if (type.Text == "char")
            {
                    charlist.AddItem(char.Parse(add.Text));
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            cip.Instance.Id = 3;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox8.Text = basename.Name;
            textBox9.Text = basename.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            stackint.Push(int.Parse(push.Text));
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pop.Text = stackint.Pop().ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            peek.Text = stackint.Peek().ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
            queueint.Enqueue(int.Parse(enqueue.Text));
        }

        private void button14_Click(object sender, EventArgs e)
        {
            dequeue.Text = queueint.Dequeue().ToString();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            var student = new Student();
            if (!stunameBox1.Text.IsValidName()) MessageBox.Show("First name not valid!!");
            
            student.FirstName = stunameBox1.Text;

            
            
        }
    }
}
