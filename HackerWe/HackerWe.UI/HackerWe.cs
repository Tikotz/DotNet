using HackerWe.Logic;
using HackerWe.Entities;

namespace HackerWe.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Library.ReadCSVFile();
           //Library.ReadBooksFromJSON();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //    Library.SaveBooks();
            Library.SaveBooksAsJSON();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BorrowingUserControl borrowingUserControl = new BorrowingUserControl();
            borrowingUserControl.Parent = panel1;
            borrowingUserControl.Show();
        }
    }
}