using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2023._2st
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("이름을 입력하세요.");
            string name = System.Console.ReadLine();
            System.Console.WriteLine("태어난 연도를 입력하세요.");
            string yy = System.Console.ReadLine();
            System.Console.WriteLine("사는 곳을 입력하세요.");
            string home = System.Console.ReadLine();
            System.Console.WriteLine("성별을 입력하세요");
            string MF = System.Console.ReadLine();
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine();
            int yyyy = Convert.ToInt32(yy);
            int years = 2023 - yyyy;
            string myOld = Convert.ToString(years);
            System.Console.WriteLine("저의 이름은 {0} 입니다", name);
            System.Console.WriteLine("제 나이는 {0} 이며 {1}에서 살고 있습니다", myOld, home);
            System.Console.WriteLine("저의 성별은 {0} 입니다.", MF);
        }
    }
}
