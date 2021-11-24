using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HackerWe.Entities;

namespace HackerWe.UI
{
    public partial class BooksUserControl : UserControl
    {
        
        public BooksUserControl()
        {
            InitializeComponent();
        }

        private void BorrowingUserControl_Load(object sender, DataGridViewCellEventArgs e)
        {
            dtpBorrowingDate.MinDate = DateTime.Now;
            dtpBorrowingDate.MaxDate = DateTime.Now;

        }
    }
}
