using LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkedList
{
    //class Node<T>
    //{
    //    public T Data { get; set; }
    //    public Node NextNode { get; set; }
    //}

    //class List
    //{
    //    public Node<Student> Head { get; set; }

    //    public Node<Student> GetNodeByName(string name)
    //    {
    //        Node<Student> index = Head;
    //        while (index != null)
    //        {
    //            if (index.Data.Name == name)
    //                return index;
    //            index = index.NextNode;
    //        }
    //        return null;
    //    }

    //}
    
}

static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        
    }
    
    
}

