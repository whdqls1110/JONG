using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3WeekHome
{
    class Program
    {
        static void Main(string[] args)
        {
            //원숭이 닭 개 돼지 쥐 소 호랑이 토끼 용 뱀 말 양
            Console.WriteLine("출생 년도를 입력해 주세요.");
            int a = Convert.ToInt32(Console.ReadLine());
            int A = a % 12;
            switch (A)
            {
                case 0:
                    Console.Write("원숭이");
                    break;
                case 1:
                    Console.Write("닭");
                    break;
                case 2:
                    Console.Write("개");
                    break;
                case 3:
                    Console.Write("돼지");
                    break;
                case 4:
                    Console.Write("쥐");
                    break;
                case 5:
                    Console.Write("소");
                    break;
                case 6:
                    Console.Write("호랑이");
                    break;
                case 7:
                    Console.Write("토끼");
                    break;
                case 8:
                    Console.Write("용");
                    break;
                case 9:
                    Console.Write("뱀");
                    break;
                case 10:
                    Console.Write("말");
                    break;
                case 11:
                    Console.Write("양");
                    break;
            }
            Console.WriteLine(" 나이 : " + (2023 - a));
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("숫자 2개와 하나의 연산자를 입력하세요.");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            string math = Console.ReadLine();
            switch (math)
            {
                case "+":
                    Console.WriteLine($"합산 : {n1 + n2}");
                    break;
                case "-":
                    Console.WriteLine($"뺄셈 : {n1 - n2}");
                    break;
                case "*":
                    Console.WriteLine($"곱 : {n1 * n2}");
                    break;
                case "/":
                    Console.WriteLine($"몫 : {n1 / n2}");
                    break;
                case "%":
                    Console.WriteLine($"나머지 : {n1 % n2}");
                    break;
            }
        }
    }
}
