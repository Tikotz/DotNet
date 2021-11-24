// See https://aka.ms/new-console-template for more information

public delegate void VoidSimpleDelegate();

public delegate void MyAction<in T1>(T1 t1);
public delegate void MyAction<in T1, in T2>(T1 t1, T2 t2);
public delegate void MyAction<in T1, in T2, in T3>(T1 t1, T2 t2, T3 t3);

public delegate T1 MyFunction<out T1>();
public delegate T2 MyFunction<in T1, out T2>(T1 t1);
public delegate T3 MyFunction<in T1, in T2, out T3>(T1 t1, T2 t2);
public class Program
{
    




    public static void Main()
    {
        #region 1
        MyAction<int, int, int> myAction1 = (a, b, c) =>
        {
              int smallestNum = a;

              if (a < smallestNum)
              {
                  smallestNum = a;
              }
              else if (b < smallestNum)
              {
                  smallestNum = b;

              }
              else if (c < smallestNum)
              {
                  smallestNum = c;
              }
              Console.WriteLine("the smallest number is: {0}", smallestNum);
        };
        myAction1(20,5,99);
        #endregion
        #region 2
        MyAction<int, int, int> myAction2 = (a, b, c) =>
        {
            double avarage = (a + b + c) / 3;
            Console.WriteLine("the average value is: {0}",avarage);
        };
        myAction2(25, 45, 65);
        #endregion

        #region 3
        MyAction<string> myAction3 = (a) =>
        {
            if (a.Length % 2 == 0)
            {
                char MiddleChar1 = a[(a.Length / 2) - 1];
                char MiddleChar2 = a[(a.Length / 2)];
                Console.WriteLine("The middle character in the string is: {0}{1}", MiddleChar1, MiddleChar2);
            }
            else
            {
                char MiddleChar = a[a.Length / 2];
                Console.WriteLine("The middle character in the string is: {0}", MiddleChar);
            }
            
        };
        myAction3("3500");
        #endregion

        #region 4
        MyAction<string> myAction4 = (a) =>
        {
            int count = 0;
            foreach (var item in a)
            {
                if (item == 'a' || item == 'o' || item == 'u' || item == 'e' || item == 'i')
                {
                    count++;
                }
            }
            Console.WriteLine($"Number of  Vowels in the string: {count}");
        };
        myAction4("w3resource");
        #endregion

        #region 5
        MyAction<string> myAction5 = (a) =>
        {
            int count = 0;
            foreach (var item in a)
            {
                if (item == ' ')
                {
                    count++;
                }
            }
            Console.WriteLine($"Number of words in the string: {count + 1}");
        };
        myAction5("The quick brown fox jumps over the lazy dog");
        #endregion
        #region 6
        MyAction<int> myAction6 = (a) =>
        {
            int sum = 0;
            foreach (var item in a.ToString())
            {
                sum += Convert.ToInt32(item.ToString());
            }
            Console.WriteLine($"Number of words in the string: {sum}");
        };
        myAction6(55);
        #endregion

        #region 6
        //MyAction<int, int> myAction7 = (First, Second) =>
        // {
        //     double number = First + Second;
        //     for (int i = 0; i < 50; i++)
        //     {
        //         if (i == 0) { Console.Write($"{First} "); }
        //         else if (i == 1) { Console.Write($"{Second} "); }
        //         else if (i == 2) { Console.Write($"{(First + Second) * 2} "); }
        //         else
        //         {
        //             number = number * 2;
        //             if ((i + 1) % 10 == 0)
        //             {
        //                 Console.Write(number + " ");
        //                 Console.WriteLine();
        //             }
        //             else
        //             {
        //                 Console.Write(number + " ");
        //             }
        //         }


        //     }
        // };
        //myAction7(1, 5);

        #endregion

    }
}