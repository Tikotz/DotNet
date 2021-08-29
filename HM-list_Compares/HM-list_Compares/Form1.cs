using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HM_list_Compares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static List<Students> list = new List<Students>();
        static List<TempurtureChack> templist = new List<TempurtureChack>();

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                list.Add(new Students(nameBox3.Text, lastBox2.Text, int.Parse(gradeBox1.Text)));
                listBox1.Items.Add(list[list.Count - 1]);

            }
            catch
            {

                MessageBox.Show("error, try to put name,last name or grade");
            }
            
         
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            list.Sort();
            listBox1.Items.Clear();
            foreach (var item in list)
            {
                listBox1.Items.Add(item);
            }
            MessageBox.Show("list is sorted");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                templist.Add(new TempurtureChack(cityBox1.Text, dateBox2.Text, int.Parse(tempBox3.Text), int.Parse(HumidityBox4.Text)));
                listBox2.Items.Add(templist[templist.Count - 1]);

            }
            catch
            {

                MessageBox.Show("error, one or more of the following text box is not full");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            templist.Sort();
            listBox2.Items.Clear();
            foreach (var item in templist)
            {
                listBox2.Items.Add(item);
            }
            MessageBox.Show("list is sorted");
        }
    }
}
