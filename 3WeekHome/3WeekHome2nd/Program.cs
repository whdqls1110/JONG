using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3WeekHome2nd
{
    class Program
    {
        static void Main(string[] args)
        {
            Res resto = new Res();
            Korean korean = new Korean();
            Chaina chaina = new Chaina();
            Weston weston = new Weston();

            resto.ChoRes();
            if(resto.res=="1"|| resto.res == "한식")
            {
                korean.Menue();
            }
            else if(resto.res == "2" || resto.res == "중식")
            {
                chaina.Menue();
            }
            else if (resto.res == "3" || resto.res == "양식")
            {
                weston.Menue();
            }
            else
            {
                Console.WriteLine("선택지에 없습니다.");
            }
        }
    }
    class Res
    {
        protected string[] korean = { ("김치찌게"), ("밥"), ("삼계탕") };
        protected string[] chaina = { ("짜장면"), ("짬뽕"), ("탕수육") };
        protected string[] westan = { ("파스타"), ("피자"), ("스테이크") };
        public string res;
        protected int mypay;
        public void ChoRes()
        {
            Console.WriteLine("식당을 골라주세요. (1)한식 (2)중식 (3)양식");
            res = Console.ReadLine();
        }
        protected void PayMoney()
        {
            Console.WriteLine("지불할 금액을 입력하세요.");
            mypay = Convert.ToInt32(Console.ReadLine());
        }
    }
    class Korean : Res
    {
        int[] pay = { (5000), (1000), (9000) };
        int menue;
        public void Menue()
        {
            Console.WriteLine("한식");
            Console.WriteLine($"메뉴를 골라주세요. 1번{korean[0]}, 2번{korean[1]}, 3번{korean[2]}");
            menue = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.WriteLine($"{korean[menue]} // {pay[menue]}원");
            do
            {
                PayMoney();
                if (mypay < pay[menue])
                {
                    Console.WriteLine("금액이 부족합니다.");
                }
            } while (mypay < pay[menue]);
            int backpay = mypay - pay[menue];
            Console.WriteLine($"주문하신 {korean[menue]}나왔습니다. 거스름돈은 {backpay}원 입니다.");
        }
    }
    class Chaina : Res
    {
        int[] pay = { (9000), (8500), (12000) };
        int menue;
        public void Menue()
        {
            Console.WriteLine("중식");
            Console.WriteLine($"메뉴를 골라주세요. 1번{chaina[0]}, 2번{chaina[1]}, 3번{chaina[2]}");
            menue = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.WriteLine($"{chaina[menue]} // {pay[menue]}원");
            do
            {
                PayMoney();
                if (mypay < pay[menue])
                {
                    Console.WriteLine("금액이 부족합니다.");
                }
            } while (mypay < pay[menue]);
            int backpay = mypay - pay[menue];
            Console.WriteLine($"주문하신 {chaina[menue]}나왔습니다. 거스름돈은 {backpay}원 입니다.");
        }
    }
    class Weston : Res
    {
        int[] pay = { (8000), (12000), (14000) };
        int menue;
        public void Menue()
        {
            Console.WriteLine("양식");
            Console.WriteLine($"메뉴를 골라주세요. 1번{westan[0]}, 2번{westan[1]}, 3번{westan[2]}");
            menue = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.WriteLine($"{westan[menue]} // {pay[menue]}원");
            do
            {
                PayMoney();
                if (mypay < pay[menue])
                {
                    Console.WriteLine("금액이 부족합니다.");
                }
            } while (mypay < pay[menue]);
            int backpay = mypay - pay[menue];
            Console.WriteLine($"주문하신 {westan[menue]}나왔습니다. 거스름돈은 {backpay}원 입니다.");
        }
    }
}
