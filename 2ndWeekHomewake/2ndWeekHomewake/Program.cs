using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ndWeekHomewake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자 2개를 입력하세요.");
            string N0 = Console.ReadLine();
            string N1 = Console.ReadLine();
            int n0 = Convert.ToInt32(N0);
            int n1 = Convert.ToInt32(N1);
            int sum0 = n0 + n1;
            int subt0 = n0 - n1;
            int mul0 = n0 * n1;
            int divi0a = n0 / n1;
            int divi0b = n0 % n1;
            string Sum0 = Convert.ToString(sum0);
            string Subt0 = Convert.ToString(subt0);
            string Mul0 = Convert.ToString(mul0);
            string Divi0a = Convert.ToString(divi0a);
            string Divi0b = Convert.ToString(divi0b);
            Console.WriteLine($"덧셈 : {Sum0}, 뺄셈 : {Subt0}, 곱셈 : {Mul0}, 나눗셈(몫) : {Divi0a}, 나눗셈(나머지) : {Divi0b}");
            Console.WriteLine("추가로 1개의 숫자를 입력하세요.");
            string N2 = Console.ReadLine();
            int n2 = Convert.ToInt32(N2);
            sum0 += n2;
            subt0 -= n2;
            mul0 *= n2;
            divi0a /= n2;
            divi0b %= n2;
            string Sum1 = Convert.ToString(sum0);
            string Subt1 = Convert.ToString(subt0);
            string Mul1 = Convert.ToString(mul0);
            string Divi1a = Convert.ToString(divi0a);
            string Divi1b = Convert.ToString(divi0b);
            Console.WriteLine($"+= : {Sum1}, -= : {Subt1}, *= : {Mul1}, /= : {Divi1a}, %= : {Divi1b}");
            
            Console.WriteLine(n2++);
            Console.WriteLine(n2);
            Console.WriteLine(++n2);
            Console.WriteLine(n2);
            Console.WriteLine(n2--);
            Console.WriteLine(n2);
            Console.WriteLine(--n2);
            Console.WriteLine(n2);
        }
    }
}
