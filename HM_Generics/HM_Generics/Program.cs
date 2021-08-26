using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HM_Generics
{
    public class Readonlyclass<T>
    {

    }
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            #region targil 1
            //int[] vs = new int[] { 1, 2, 3 };
            //int[] vs2 = new int[] { 4, 5, 6 };
            //canCombine.Combine<int>(vs, vs2);
            //canCombine.Combine<string>(new string[] { }, new string[] { });
        }
        #endregion
        #region targil 2
        class BasicProp
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        class Students : BasicProp
        {
            public override string ToString()
            {
                return $"student";
            }
        }


        class ReadOnlyCollection<T> where T : BasicProp
        {
            T[] list = new T[1000];
            public bool IsReadOnly { get; set; }
            public int count { get; set; } = 1;


            public void AddToList(T Data)
            {
                if (!IsReadOnly)
                {
                    for (int i = 0; i < list.Length; i++)
                    {
                        if (list[i] == null)
                        {
                            list[i] = Data;
                            list[i].Id = count;
                            list[i].Name = $"{Data.ToString()}{count}";
                            count++;
                            break;
                        }
                    }
                }
                else
                {
                    throw new InvalidOperationException("cant add because the list is readOnly");
                }
            }

            public void stopReadOnly()
            {
                if (IsReadOnly == true)
                {
                    IsReadOnly = false;
                }
                else
                {
                    IsReadOnly = true;
                }
            }
            public string FindById(int index)
            {
                for (int i = 0; i < list.Length; i++)
                {
                    if (list[i].Id == index)
                    {
                        return list[i].Name;
                    }

                }
                return null;
            }
        }
        #endregion











        Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        
    }
    #region targil 1
    class canCombine
    {
        public static T[] Combine<T>(T [] arr1,T[] arr2)
        {
            int i = 0;
            T[] result = new T[arr1.Length + arr2.Length];
            foreach (T item in arr1)
            {
                result[i++] = item;
            }
            foreach (T item in arr2)
            {
                result[i++] = item;
            }
            return result;
        } 

    }
    #endregion

}
