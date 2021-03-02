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
            //User Define Class

            // 번호 이름   나이 연락처
            // 01   홍길동 20   010-1234-1234
            // 02   홍길순 21   010-4321-4321

            //추가방식-1
            //var user1 = new User();

            //user1.No = 1;
            //user1.Name = "홍길동";

            //추가방식-2
            //var user2 = new User()
            //{
            //    No = 2,
            //    Name = "홍길순",
            //    Age = 21,
            //    Phone = "010-4321-4321"
            //};

            var list = new List<User>()
            {
                //리스트 추가방식-1
                //user1, user2

                //리스트 추가방식-2
                new User()
                {
                    No = 1,
                    Name = "홍길동",
                    Age = 20,
                    Phone = "010-1234-1234"
                },
                new User()
                {
                    No = 2,
                    Name = "홍길순",
                    Age = 21,
                    Phone = "010-4321-4321"
                }
            };

            //리스트 추가방식-3
            //list.Add(user1);
            //list.Add(user2);

            foreach (var user in list)
            {
                Console.WriteLine("번호 : " + user.No + " / " + "이름 : " + user.Name);
            }

        }
    }
}