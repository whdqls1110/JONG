using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4WeekHome
{
    class Program
    {
        public static List<string> Cardklist = new List<string>();
        public static List<string> GroundList = new List<string>();
        public static List<string> AttackCard = new List<string>();
        public static Dictionary<string, int> CardDic = new Dictionary<string, int>();
        public static int attackcount = 1;
        public static string code;
        public static int codNum;
        static void Main(string[] args)
        {
            creatCard();
            Player player = new Player();
            Player com1 = new Player();
            Player com2 = new Player();
            Player com3 = new Player();
            Console.WriteLine("Game Start");
            player.GetHand();
            com1.GetHand();
            com2.GetHand();
            com3.GetHand();
            MakeGround();
            
        }
        private static void creatCard()
        {//11은 j 12는 q 13은 k
            for (int i = 0; i < 13; i++)
            {
                Cardklist.Add("Heart" + Convert.ToString(i + 1));
                CardDic.Add("Heart" + Convert.ToString(i + 1), i + 1);
            }
            for (int i = 0; i < 13; i++)
            {
                Cardklist.Add("Clover" + Convert.ToString(i + 1));
                CardDic.Add("Clover" + Convert.ToString(i + 1), i + 1 + 13);
            }
            for (int i = 0; i < 13; i++)
            {
                Cardklist.Add("Diamond" + Convert.ToString(i + 1));
                CardDic.Add("Diamond" + Convert.ToString(i + 1), i + 1 + (13 * 2));
            }
            for (int i = 0; i < 13; i++)
            {
                Cardklist.Add("Spade" + Convert.ToString(i + 1));
                CardDic.Add("Spade" + Convert.ToString(i + 1), i + 1 + (13 * 3));
            }
            Cardklist.Add("Joker");
            Cardklist.Add("BlackJoker");
            for(int i = 0; i < 2; i++)
            {
                AttackCard.Add("Heart" + Convert.ToString(i + 1));
                AttackCard.Add("Clover" + Convert.ToString(i + 1));
                AttackCard.Add("Diamond" + Convert.ToString(i + 1));
                AttackCard.Add("Spade" + Convert.ToString(i + 1));
            }
            AttackCard.Add("BlackJoker");
            AttackCard.Add("Joker");

        }
        public static void EndlessCard()
        {
            for (int i = 1; i < GroundList.Count; i++)
            {
                Cardklist.Add(GroundList[i]);
                GroundList.RemoveAt(i);
            }
        }
        public static void MakeGround()
        {
            Random random = new Random();
            int a = random.Next(0, Cardklist.Count);
            GroundList.Add(Cardklist[a]);
            Cardklist.RemoveAt(a);
            ShowGround();
        }
        public static void ShowGround()
        {
            #region code
            if (GroundList[0].Contains("Heart"))
            {
                code = "Heart";
            }
            else if (GroundList[0].Contains("Clover"))
            {
                code = "Clover";
            }
            else if (GroundList[0].Contains("Diamond"))
            {
                code = "Diamond";
            }
            else if (GroundList[0].Contains("Spade"))
            {
                code = "Spade";
            }
            else
            {
                code = "non";
            }
            #endregion
            #region codNum
            if (code == "Non")
            {
                codNum = 0;
            }
            else
            {
                codNum = CardDic[GroundList[0]] % 13;
            }
            Console.WriteLine($"카드문양{code} 카드번호{codNum}");
            #endregion
        }
    }
    class Player : Program
    {
        public List<string> HandList = new List<string>();
        
        public void GetHand()
        {
            for (int i = 0; i < 7; i++)
            {
                Random random = new Random();
                int a = random.Next(0, Cardklist.Count);
                HandList.Add(Cardklist[a]);
                Cardklist.RemoveAt(a);
            }
        }
        public void GetCard(int Value)
        {
            for (int i = 0; i < Value; i++)
            {
                Random random = new Random();
                int a = random.Next(0, Cardklist.Count);
                HandList.Add(Cardklist[a]);
                Cardklist.RemoveAt(a);
                attackcount = 1;
            }
        }
        public void UseCard(int Value)
        {
            GroundList.Insert(0, HandList[Value]);
            Console.WriteLine("놓여진 카드 : " + GroundList[0]);
            HandList.RemoveAt(Value);
            ShowGround();
            if (AttackCard.Contains(GroundList[0]))
            {
                if (codNum == 2)
                {
                    attackcount += 2;
                }
                else if (code== "Spade" || GroundList[0].Contains("BlackJoker"))
                {
                    attackcount += 5;
                }
                else if(GroundList[0].Contains("Joker"))
                {
                    attackcount += 10;
                }
                else
                {
                    attackcount += 3;
                }
            }
        }
        public void ShowMyHand()
        {
            for (int i = 0; i < HandList.Count; i++)
            {
                Console.Write($" {HandList[i]}");
            }
        }
    }
}
