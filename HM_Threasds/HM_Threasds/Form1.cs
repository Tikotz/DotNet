using HM_Threasds5;
using System.Diagnostics;

namespace HM_Threasds5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SuperSearch.SearchValue += (value) =>
            {
                this.Invoke(new Action(() =>
                {
                    listBox1.Items.Add(value);
                }));
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                for (int i = 1; i < 5000; i++)
                {
                    Debug.WriteLine(i);
                }
            });
            thread.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                SuperSearch search = new SuperSearch(DrivetextBox1.Text, SearchTermtextBox1.Text);
                
                search.searchValue();
            });
            thread.Start();
        }
    }
}