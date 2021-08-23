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
        collection_targil3<string> stringlist = new collection_targil3<string>();
        #endregion
        #region 4
        GenericID<boss> Boss = new GenericID<boss>();
        GenericID<imploye> Imploye = new GenericID<imploye>();
        boss boss1 = new boss();
        imploye imploye1 = new imploye();
        #endregion
        #region 7
        ClassWithName basename = new ClassWithName();
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
            try
            {
                textBox1.Text = intlist.GetType(int.Parse(textBox2.Text));
            }
            catch
            {

                try
                {
                    textBox1.Text = doublelist.GetType(double.Parse(textBox2.Text));
                }
                catch 
                {

                    try
                    {
                        textBox1.Text = charlist.GetType(char.Parse(textBox2.Text));
                    }
                    catch 
                    {
                        textBox1.Text = stringlist.GetType(textBox2.Text);
                    }
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == boss1.ToString())
            {
                Boss.add(new boss());
            }
            else if (textBox5.Text == imploye1.ToString())
            {
                Imploye.add(new imploye());
            }
            else
            {
                textBox5.Text = "wrong input";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox7.Text = Boss.sarchById(textBox6.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox6.Text = Boss.sarchById(textBox7.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox8.Text = basename.Name;
            textBox9.Text = basename.ToString();
        }
    }
}
