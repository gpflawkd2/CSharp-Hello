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
            //** if문 **
            //var num = 1;

            //Console.WriteLine("0 ~ 9 사이의 값을 입력 : ");

            //var input = Console.ReadLine();

            //if (num.ToString() == input)
            //{
            //    Console.WriteLine("같은 값을 입력했습니다!");
            //}
            //else if (num.ToString() != input)
            //{
            //    Console.WriteLine("다른 값을 입력했습니다!");
            //}


            //** While문 **
            var num = 1;

            //while(num < 10)
            //{
            //    Console.WriteLine(++num);   //전위연산자
            //}

            //무한Loop
            //while (true)
            //{
            //    num++;

            //    if (num % 3 == 0)
            //    {
            //        continue;   //하단 while문 코드를 통과함
            //    }

            //    Console.WriteLine(num);

            //    if (num == 100)
            //    {
            //        break;  //while문을 빠져나옴
            //    }
            //}

            //한번은 실행됨
            do
            {
                Console.WriteLine(num++);
            } while (num < 10);

        }
    }
}
