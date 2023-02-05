using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230205class
{
    class Program
    {
        static void Main(string[] args)
        {
            //1~4
            System.Console.WriteLine("이름을 입력하세요.");
            string myName = System.Console.ReadLine();
            System.Console.WriteLine("생년을 입력해 주세요.");
            System.Console.Write("년 : ");
            string yy = System.Console.ReadLine();
            System.Console.WriteLine("당신의 이름은 {0} 입니다.", myName);
            System.Console.WriteLine("당신은 {0}년에 태어났습니다.", yy);
            int age = 2023 - Convert.ToInt32(yy);
            string myAge = Convert.ToString(age);
            System.Console.WriteLine("당신의 나이는 {0}입니다.", myAge);
            System.Console.WriteLine("자기소개");
            string me = System.Console.ReadLine();
            System.Console.WriteLine(me);
            //5
            System.Console.WriteLine($"당신의 이름은 {myName} 입니다.");
            System.Console.WriteLine($"당신은 {yy}년에 태어났습니다.");
            System.Console.WriteLine($"당신의 나이는 {myAge}입니다.");
            System.Console.WriteLine($"자기소개 : {me}");
            //6
            System.Console.WriteLine(@"@@@@@@@@@@
@@@@@@@@@@
@@@@@@@@@@
@@@@@@@@@@
@@@@@@@@@@");
            //7
            string[] myA = new string[3] { myName, myAge, me };
            //8
            System.Console.WriteLine("당신의 이름은 {0} 입니다.", myA[0]);
            System.Console.WriteLine("당신의 나이는 {0}입니다.", myA[1]);
            System.Console.WriteLine("자기소개 : {0}",myA[2]);
            //9
            System.Console.WriteLine($"당신의 이름은 {myA[0]} 입니다.");
            System.Console.WriteLine($"당신의 나이는 {myA[1]}입니다.");
            System.Console.WriteLine($"자기소개 : {myA[2]}");
            //기버깅 F9 혹은 좌측 좌클릭 후 F5,F10누르면 한줄씩 진행
        }
    }
}
