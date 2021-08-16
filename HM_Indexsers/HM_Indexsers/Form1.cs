using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HM_Indexsers
{
    public partial class Form1 : Form
    {
        Wather w1 = new Wather();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a =  w1.GetWather(day.Text);
            temp.Text = a.ToString();
        }
    }
}
