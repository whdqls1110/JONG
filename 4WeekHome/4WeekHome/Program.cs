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
        public static int[] Trun = { 0, 1, 2, 3 };
        public static int trun = 0;

        public static int c = 0;
        static void Main(string[] args)
        {
            creatCard();
            Player player = new Player();
            Player com1 = new Player();
            Player com2 = new Player();
            Player com3 = new Player();
            Console.WriteLine("Game Start");
            for (int i = 0; i < 7; i++)
            {
                player.GetHand();
                com1.GetHand();
                com2.GetHand();
                com3.GetHand();
            }
            MakeGround();
            Random random = new Random();
            Trun = Trun.OrderBy(x => random.Next()).ToArray();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"{Trun[i]}");
            }
            while (true)
            {
                if (Trun[trun] == 0)//플래이어 턴
                {
                    if (attackcount > 1)
                    {
                        Console.WriteLine("Player의 턴");
                        Console.WriteLine($"Attackcount : {attackcount}");
                        Console.Write($"바닥의 카드 : ");
                        ShowGround();
                        Console.Write($"손의 카드 : ");
                        player.ShowMyHand();
                        Console.WriteLine();
                        do
                        {
                            Console.WriteLine("사용할 카드를 정해주세요.");
                            c = 0;
                            RetrunKey();
                            if (c < 0 || c > player.HandList.Count)
                            {
                                break;
                            }
                            else if(codNum == 2  )//<---------------------
                            {

                            }
                        } while (true);
                        if (c < 0 || c > player.HandList.Count)
                        {
                            player.GetCard(attackcount);
                        }
                        else
                        {
                            player.UseCard(c);
                        }
                        trun++;
                        trun = trun % 4;
                    }
                    else
                    {
                        Console.WriteLine("Player의 턴");
                        Console.WriteLine($"Attackcount : {attackcount}");
                        Console.Write($"바닥의 카드 : ");
                        ShowGround();
                        Console.Write($"손의 카드 : ");
                        player.ShowMyHand();
                        Console.WriteLine();
                        do
                        {
                            Console.WriteLine("사용할 카드를 정해주세요.");
                            c = 0;
                            RetrunKey();
                            if (c < 0 || c > player.HandList.Count)
                            {
                                break;
                            }
                        } while (player.HandList[c].Contains(code) == false && CardDic[player.HandList[c]] % 13 != codNum);
                        if (c < 0 || c > player.HandList.Count)
                        {
                            player.GetCard(attackcount);
                        }
                        else
                        {
                            player.UseCard(c);
                        }
                        trun++;
                        trun = trun % 4;
                    }
                }
                else if (Trun[trun] == 1)//Com1
                {
                    Console.WriteLine("Com1의 턴");
                    ComAI(com1);
                }
                else if (Trun[trun] == 2)
                {
                    Console.WriteLine("Com2의 턴");
                    ComAI(com2);
                }
                else
                {
                    Console.WriteLine("Com3의 턴");
                    ComAI(com3);
                }
            }
            //player 0 com1 1 com2 2 com3 3
        }
        public static void ComAI(Player players)
        {
            Console.WriteLine($"Attackcount : {attackcount}");
            Console.Write($"바닥의 카드 : ");
            ShowGround();
            Console.WriteLine("사용할 카드를 정해주세요.");
            for (int i = 0; i < players.HandList.Count; i++)
            {
                if (i>players.HandList.Count)
                {
                    players.GetCard(attackcount);
                    break;
                }
                else if(players.HandList[i].Contains(code) || CardDic[players.HandList[i]] % 13 == codNum)
                {
                    players.UseCard(i);
                    break;
                }
            }
            trun++;
            trun = trun % 4;
        }
        public static int RetrunKey()
        {
            ConsoleKeyInfo key;
            Console.WriteLine(c + 1);
            while (true)
            {
                key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.LeftArrow:
                        c--;
                        Console.WriteLine(c + 1);
                        break;
                    case ConsoleKey.RightArrow:
                        c++;
                        Console.WriteLine(c + 1);
                        break;
                    case ConsoleKey.Enter:
                        return c;
                }
            }
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
                codNum = 99;
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
            Random random = new Random();
            int a = random.Next(0, Cardklist.Count);
            HandList.Add(Cardklist[a]);
            Cardklist.RemoveAt(a);
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
            if (CardDic[GroundList[0]] % 13 == 11)
            {
                trun++;
                trun = trun % 4;
                Console.WriteLine("건너뛰기");
            }
            if(CardDic[GroundList[0]] % 13 == 12)
            {
                int T = Trun[0];
                int T1 = Trun[1];
                int T2 = Trun[2];
                int T3 = Trun[3];
                Trun[3] = T;
                Trun[2] = T1;
                Trun[1] = T2;
                Trun[0] = T3;
                Console.WriteLine("방향전환");
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine($"{Trun[i]}");
                }
            }
            if (CardDic[GroundList[0]] % 13 == 0)
            {
                trun--;
                trun = trun % 4;
            }
            HandList.RemoveAt(Value);
            ShowGround();
            if (AttackCard.Contains(GroundList[0]))
            {
                if (attackcount == 1)
                {
                    attackcount = 0;
                }
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
            if (HandList.Count == 0)
            {
                Console.WriteLine($"{Trun}win");
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
