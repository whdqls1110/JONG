using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ndWeekHomewake
{
    class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자 2개를 입력해 주세요.");
            string n1 = Console.ReadLine();
            string n2 = Console.ReadLine();
            int N1 = Convert.ToInt32(n1);
            int N2= Convert.ToInt32(n2);
            int s1 = N1 + N2;
            if (s1 < 10)
            {
                Console.WriteLine("10미만 입니다.");
            }
            else if (s1 < 20)
            {
                Console.WriteLine("20미만 입니다.");
            }
            else if (s1 < 30)
            {
                Console.WriteLine("30미만 입니다.");
            }
            else
            {
                Console.WriteLine("최소 30이상 입니다.");
            }
            if (N1 % 2 == 0 && N2 % 2 == 0)
            {
                Console.WriteLine("짝짝");
            }
            else if (N1 % 2 == 0)
            {
                Console.WriteLine("짝홀");
            }
            else if (N2 % 2 == 0)
            {
                Console.WriteLine("홀짝");
            }
            else
            {
                Console.WriteLine("홀홀");
            }
            Console.WriteLine("반복 횟수를 입력하세요.");
            string C = Console.ReadLine();
            int c = Convert.ToInt32(C);
            for (int i = 0; i < c; i++)
            {
                Console.WriteLine((i + 1) + " for문장반복");
            }
            int t = 0;
            while (t < c)
            {
                Console.WriteLine((t + 1) + " while문장반복");
                t++;
            }

        }
    }
}
