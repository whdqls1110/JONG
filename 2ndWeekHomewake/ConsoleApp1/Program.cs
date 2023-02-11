using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자 2개를 입력하세요.");
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            int A = Convert.ToInt32(a);
            int B = Convert.ToInt32(b);
            int result = Sum(A, B);
            Console.WriteLine(result);
            for(int i = 0; i < 6; i++)
            {
                for(int j = 5; j > i; j--)
                {
                    Console.Write(" ");
                }
                for(int k = 2 * i + 1; k > 0; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 11 - 2 * i; k > 0; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        private static int Sum(int n1, int n2)
        {
            int sum = n1 + n2;
            return sum;
        }
    }
}
