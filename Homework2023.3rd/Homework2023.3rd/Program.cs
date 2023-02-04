using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2023._3rd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Foods = new string[4] { "떡볶이", "김밥", "만두", "튀김" };
            System.Console.WriteLine("메뉴를 선택해 주세요.(1){0} (2){1} (3){2} (4){3}",Foods[0],Foods[1],Foods[2],Foods[3]);
            string cho = System.Console.ReadLine();
            int choN = Convert.ToInt32(cho);
            int myMenew = choN - 1;
            System.Console.WriteLine("{0}을(를) 먹었다.", Foods[myMenew]);
            Foods[myMenew] = null;
            System.Console.WriteLine("남은 메뉴 : (1){0} (2){1} (3){2} (4){3}", Foods[0], Foods[1], Foods[2], Foods[3]);

        }
    }
}
