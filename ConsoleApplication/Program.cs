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

            //C# 변수타입 -> 소문자로 시작
            /*
            short shortNum = 0;
            int intNum = 0;
            double doubleNum = 0;
            float floatNum = 0;     //부동소수점 자리
            string stringText = "";
            char charText = 'a';
            bool boolVal = true;
            */

            //.Net Framework 변수타입
            /*
            Int16 dotNetShort = 0;
            Int32 dotNetInt = 0;
            Int64 dotNetDouble = 0;
            String dotNetString = "";
            */

            //var dynamicType = false;

            //** if문 **
            var num = 1;

            Console.WriteLine("0 ~ 9 사이의 값을 입력 : ");

            //입력값
            var input = Console.ReadLine();

            //ToString() : String 으로 변환

            //if (num.ToString() == input)
            //{
            //    Console.WriteLine("같은 값을 입력했습니다!");
            //}
            //else
            //{
            //    Console.WriteLine("다른 값을 입력했습니다!");
            //}

            if (num.ToString() == input)
            {
                Console.WriteLine("같은 값을 입력했습니다!");
            }
            else if (num.ToString() != input)
            {
                Console.WriteLine("다른 값을 입력했습니다!");
            }

        }
    }
}
