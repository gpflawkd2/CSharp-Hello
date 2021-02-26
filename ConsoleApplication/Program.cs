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
            //** for문 **

            //for (var i = 0; i<=10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //var num = 1;

            //for (; num <= 10; num++)
            //{
            //    Console.WriteLine(num);
            //}

            //Array List
            List<int> numberList = new List<int>();

            numberList.Add(1);
            numberList.Add(2);
            numberList.Add(3);
            numberList.Add(4);
            numberList.Add(5);

            //foreach : 특정 object에 있는 값을 모두 출력함
            foreach (var num in numberList)
            {
                Console.WriteLine(num);
            }

            for (var index = 0; index < numberList.Count; index++)
            {
                Console.WriteLine(numberList[index]);
            }
        }
    }
}
