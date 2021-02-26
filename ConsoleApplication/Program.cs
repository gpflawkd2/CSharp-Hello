using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generic List

            //List<string> list = new List<string>();

            //list.Add("text1");
            //list.Add("text2");
            //list.Add("text3");
            //list.Add("text4");
            //list.Add("text5");

            //foreach (var text in list)
            //{
            //    Console.WriteLine(text);
            //}

            var numberList = new List<int>();

            numberList.Add(1);
            numberList.Add(2);
            numberList.Add(3);

            var textList = new List<string>()
            {
                "text1",
                "text2",
                "text3",
                "text4",
                "text5"
            };


            foreach (var num in numberList)
            {
                Console.WriteLine(num);
            }

            foreach (var text in textList)
            {
                Console.WriteLine(text);
            }


        }
    }
}