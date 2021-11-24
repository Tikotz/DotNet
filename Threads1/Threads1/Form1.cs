using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace Threads1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                for (int i = 0; i < 5000; i++)
                {
                    Debug.WriteLine(i);
                }

            });
            thread.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Im Doing somthing else");
        }
    }
}
