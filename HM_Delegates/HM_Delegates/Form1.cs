using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HM_Delegates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        Calculation calculation1 = new Calculation();
        private void button1_Click(object sender, EventArgs e)
        {
            CalcDelegate calcDelegate = calculation1.Add;
            Resulte.Text = calcDelegate(int.Parse(num1.Text), int.Parse(Num2.Text)).ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CalcDelegate calcDelegate = calculation1.Sub;
            Resulte.Text = calcDelegate(int.Parse(num1.Text), int.Parse(Num2.Text)).ToString();
        }

        private void manageStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
