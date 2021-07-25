using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10_cc_MethodeAdv_Access
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] words = { "ori", "tiko" };
            Console.WriteLine(BuildSentence(words)); 
            
        }

        public static string BuildSentence(params string[] words)
        {
            string sentence = "";
            for (int i = 0; i < words.Length; i++)
            {
                sentence += words[i] + " ";
                
            }
            return sentence;
        }

        public static void PrintNameAndIncreaceAge(params person[] person)
        {
            for (int i = 0; i < person.Length; i++)
            {
                Console.WriteLine(person[i].name);
                person[i].incraeseAge(person[i]);
            }
        }
    }


    class person
    {
        public string name;
        public int age;

        public void incraeseAge(person person)
        {
            person.age ++;
        }

    }
}
