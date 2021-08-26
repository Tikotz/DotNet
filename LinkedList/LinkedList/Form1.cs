using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkedList
{
    public partial class Form1 : Form
    {
        static List<Student> list = new List<Student>(3);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            list.Add(new Student (namebox.Text));
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Student student in list)
            {
                if (student.Name == namebox.Text)
                {
                    list.Remove(student);
                    break;
                }
                
            }
            
        }
    }
}
