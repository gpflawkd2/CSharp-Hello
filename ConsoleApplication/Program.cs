using FirstLibrary;
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
            //Calc calc = new Calc();
            //calc.PrintHello();
            //Console.WriteLine(calc.Plus(10, 20));

            #region + About Class Library

            //Console 프로그램에서 Main 함수는 하나여야 하므로 Project 추가시 Class Library(DLL 파일을 만들 때 사용) 선택

            // 다른 projcet의 Class 사용시 Reference에 등록 후 사용
            // 1)Reference 우클릭 > Add Reference > Projects > Solution > 체크
            // 2)Ctrl + .(점): 인텔리센스를 사용하여 using~ 구문 추가

            #endregion

            FirstClass first = new FirstClass();
            first.FirstClassPrint();
        }
    }
}