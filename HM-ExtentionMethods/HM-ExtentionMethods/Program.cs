using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ExtentionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            #region targil 1
            string name = "OrI";
            bool unswer = name.HasLowerChar();
            Console.WriteLine(unswer);
            #endregion
            #region targil 2
            string unswer2 = name.ReverseCase();
            Console.WriteLine(unswer2);
            Console.WriteLine(name);
            #endregion

            #region targil 4
            int x = 2;
            int unswer4 = x.MultipleBy(5);
            Console.WriteLine(unswer4);
            #endregion

            #region targil 5
            string d;
            if (d.IsNull())
            {

            }
            #endregion
        }
    }
}
