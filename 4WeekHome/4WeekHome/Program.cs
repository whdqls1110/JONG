using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _4WeekHome
{
    class Program
    {
        #region 리스트 및 상수 선언
        public static List<string> Cardlist = new List<string>();
        public static List<string> GroundList = new List<string>();
        public static List<string> AttackCard = new List<string>();
        public static Dictionary<string, int> CardDic = new Dictionary<string, int>();
        public static int attackcount = 1;
        public static string code;
        public static int codNum;
        public static int[] Trun = { 0, 1, 2, 3 };
        public static int trun = 0;

        public static bool canUse = true;
        public static bool game = true;
        public static int gameover = 0;
        public static string[] list77 = { "heart","clover","diamond","spade"};

        private static string[] not2 = { "heart1", "clover1", "diamond1", "spade1", "blackjoker", "joker" };
        private static string[] not3 = { "spade1", "blackjoker", "joker" };

        public static int c = 0;
        #endregion
        static void Main(string[] args)
        {
            Console.SetWindowSize(150, 50);
            MainMenue();
        }
        public static void MainMenue()
        {
            int s0 = 0;
            Console.WriteLine("                                                                                                                     ");
            Console.WriteLine("                                                                                                                     ");
            Console.WriteLine("                                                                                                                     ");
            Console.WriteLine("                                                                                                                     ");
            Console.WriteLine("                                                                                                                     ");
            Console.WriteLine("                                                                                                                     ");
            Console.WriteLine("                                                                                                                     ");
            Console.WriteLine("                                                                                                                     ");
            Console.WriteLine("                                                                                                                     ");
            Console.WriteLine("                                                                                                                     ");
            Console.WriteLine("                                            ******   **   **  *******                                                ");
            Console.WriteLine("                                           **    **  ***  **  **                                                     ");
            Console.WriteLine("                                           **    **  ** * **  *******                                                ");
            Console.WriteLine("                                           **    **  **  ***  **                                                     ");
            Console.WriteLine("                                            ******   **   **  *******                                                ");
            Console.WriteLine("                                                                                                                     ");
            Console.WriteLine("                                                            ******       **     *******   ******                     ");
            Console.WriteLine("                                                           **     *     ****    **    **  **    **                   ");
            Console.WriteLine("                                                           **          **  **   *******   **    **                   ");
            Console.WriteLine("                                                           **     *   ********  **    **  **    **                   ");
            Console.WriteLine("                                                            ******   **      ** **     ** ******                     ");
            Console.WriteLine("                                                                                                                     ");
            Console.WriteLine("                                                                                                                     ");
            Console.WriteLine("                                                                                                                     ");
            Console.WriteLine("                                                                                                                     ");
            Console.SetCursorPosition(66, 37);
            Console.WriteLine("Game Start");
            Console.SetCursorPosition(66, 39);
            Console.WriteLine("조작법");
            Console.SetCursorPosition(77, 37);
            Console.Write("<-");

            ConsoleKeyInfo keyInfo;
            while (true)
            {
                keyInfo = Console.ReadKey();
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        s0--;
                        break;
                    case ConsoleKey.DownArrow:
                        s0++;
                        break;
                    case ConsoleKey.LeftArrow:
                        s0--;
                        break;
                    case ConsoleKey.RightArrow:
                        s0++;
                        break;
                    case ConsoleKey.Spacebar:
                        break;
                    case ConsoleKey.Enter:
                        break;
                }
                s0 = s0 % 2;
                if (s0 == 0)
                {
                    Console.SetCursorPosition(77, 39);
                    Console.Write("       ");
                    Console.SetCursorPosition(77, 37);
                    Console.Write("<-");
                }
                else
                {
                    Console.SetCursorPosition(77, 37);
                    Console.Write("       ");
                    Console.SetCursorPosition(77, 39);
                    Console.Write("<-");
                }
                if (keyInfo.Key == ConsoleKey.Separator || keyInfo.Key == ConsoleKey.Enter)
                {
                    break;
                }
            }
            if (s0 == 0)
            {
                Console.Clear();
                Game();
            }
            else
            {
                Console.Clear();
                GameControll();
            }
        }
        public static void GameControll()
        {
            Console.WriteLine("방향키를 이용해 카드 선택");
            Console.WriteLine("엔터로 카드 선택한 카드 사용");
            Console.WriteLine("스패이스바로 카드 얻고 순서 넘기기");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("처음 화면으로 돌아가려면 아무 키나 입력하세요.");
            ConsoleKeyInfo info;
            info = Console.ReadKey();
            Console.Clear();
            MainMenue();
        }
        public static void Game()
        {
            #region 게임준비
            MakePan();
            creatCard();
            Player player = new Player();
            Player com1 = new Player();
            Player com2 = new Player();
            Player com3 = new Player();
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
            #endregion
            player.ShowMyHand(c);
            while (game)
            {
                if (Trun[trun] == 0)//플래이어 턴
                {
                    if (player.HandList.Count != 0)
                    {
                        if (gameover == 3)
                        {
                            break;//게임 종료
                        }
                        Console.SetCursorPosition(66, 10);
                        Console.WriteLine("   Player의 턴   ");
                        Console.SetCursorPosition(66, 11);
                        Console.WriteLine($"Attackcount : {attackcount}          ");
                        Console.WriteLine();
                        if (attackcount > 1)
                        {
                            c = 0;
                            do
                            {
                                player.ShowMyHand(c);
                                ConsoleKeyInfo key;
                                do
                                {
                                    key = Console.ReadKey();
                                    switch (key.Key)
                                    {
                                        case ConsoleKey.LeftArrow:
                                            c--;
                                            break;
                                        case ConsoleKey.RightArrow:
                                            c++;
                                            break;
                                        case ConsoleKey.Enter:
                                            break;
                                        case ConsoleKey.Spacebar:
                                            break;
                                    }
                                    if (c == -1)
                                    {
                                        c = player.HandList.Count;
                                    }
                                    if (c == player.HandList.Count)
                                    {
                                        c = 0;
                                    }
                                    player.ShowMyHand(c);
                                } while (key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Spacebar);
                                if (codNum == 2 && AttackCard.Contains(player.HandList[c]))
                                {
                                    canUse = true;
                                    break;
                                }
                                else if (codNum == 1 && code != "spade" && not2.Contains(player.HandList[c]))
                                {
                                    canUse = true;
                                    break;
                                }
                                else if ((codNum == 1 || GroundList[0] == "blackjoker") && not3.Contains(player.HandList[c]))
                                {
                                    canUse = true;
                                    break;
                                }
                                if (key.Key == ConsoleKey.Spacebar)
                                {
                                    player.GetCard(attackcount);
                                    c = 0;
                                    player.ShowMyHand(c);
                                    canUse = false;
                                    break;
                                }
                                else
                                {
                                    canUse = true;
                                }
                            } while (true);
                            if(canUse)
                            {
                                player.UseCard(c);
                                c = 0;
                                player.ShowMyHand(c);
                                if (game == false)
                                {
                                    break;//게임 종료
                                }
                            }
                        }
                        else
                        {
                            c = 0;
                            do
                            {
                                player.ShowMyHand(c);
                                ConsoleKeyInfo key;
                                do
                                {
                                    key = Console.ReadKey();
                                    switch (key.Key)
                                    {
                                        case ConsoleKey.LeftArrow:
                                            c--;
                                            break;
                                        case ConsoleKey.RightArrow:
                                            c++;
                                            break;
                                        case ConsoleKey.Enter:
                                            break;
                                        case ConsoleKey.Spacebar:
                                            break;
                                    }
                                    if (c == -1)
                                    {
                                        c = player.HandList.Count;
                                    }
                                    if (c == player.HandList.Count)
                                    {
                                        c = 0;
                                    }
                                    player.ShowMyHand(c);
                                } while (key.Key != ConsoleKey.Enter && key.Key !=ConsoleKey.Spacebar);
                                if (player.HandList[c] == "blackjoker" || player.HandList[c] == "joker")
                                {
                                    canUse = true;
                                    break;
                                }
                                if (code == "joker")
                                {
                                    canUse = true;
                                    break;
                                }
                                if(key.Key == ConsoleKey.Spacebar)
                                {
                                    player.GetCard(attackcount);
                                    c = 0;
                                    player.ShowMyHand(c);
                                    canUse = false;
                                    break;
                                }
                                else
                                {
                                    canUse = true;
                                }
                            } while (player.HandList[c].Contains(code) == false && CardDic[player.HandList[c]] % 13 != codNum);
                            if (canUse)
                            {
                                player.UseCard(c);
                                c = 0;
                                player.ShowMyHand(c);
                                if (game == false)
                                {
                                    break;//게임 종료
                                }
                                if (codNum == 7)
                                {
                                    c = 0;
                                    ConsoleKeyInfo console1;
                                    Console.SetCursorPosition(66, 36);
                                    Console.Write("[heart] clover diamond spade    ");
                                    do
                                    {
                                        console1 = Console.ReadKey();
                                        switch (console1.Key)
                                        {
                                            case ConsoleKey.LeftArrow:
                                                c--;
                                                if (c == -1)
                                                {
                                                    c = 3;
                                                }
                                                break;
                                            case ConsoleKey.RightArrow:
                                                c++;
                                                if (c == 4)
                                                {
                                                    c = 0;
                                                }
                                                break;
                                            case ConsoleKey.Enter:
                                                break;
                                        }
                                        Console.SetCursorPosition(66, 36);
                                        switch (c)
                                        {
                                            case 0:
                                                Console.Write("[heart] clover diamond spade    ");
                                                break;
                                            case 1:
                                                Console.Write("heart [clover] diamond spade    ");
                                                break;
                                            case 2:
                                                Console.Write("heart clover [diamond] spade    ");
                                                break;
                                            case 3:
                                                Console.Write("heart clover diamond [spade]    ");
                                                break;
                                        }
                                    } while (console1.Key != ConsoleKey.Enter);
                                    code = list77[c];
                                    Console.SetCursorPosition(36, 17);
                                    Console.WriteLine($"  | {code} | | {codNum} |     ");
                                    Console.SetCursorPosition(66, 36);
                                    Console.Write("                                       ");
                                }
                            }
                        }
                    }
                    trun++;
                    trun = trun % 4;
                    Thread.Sleep(2000);
                }
                else if (Trun[trun] == 1)//Com1
                {
                    if (com1.HandList.Count != 0)
                    {
                        if (gameover == 3)
                        {
                            break;//게임 종료
                        }
                        Console.SetCursorPosition(66, 10);
                        Console.WriteLine("   Com1의 턴   ");
                    }
                    ComAI(com1);
                    if (game == false)
                    {
                        trun--;
                        if (trun == -1)
                        {
                            trun = 3;
                        }
                        break;//게임 종료
                    }
                }
                else if (Trun[trun] == 2)//Com2
                {
                    if (com2.HandList.Count != 0)
                    {
                        if (gameover == 3)
                        {
                            break;//게임 종료
                        }
                        Console.SetCursorPosition(66, 10);
                        Console.WriteLine("   Com2의 턴   ");
                    }
                    ComAI(com2);
                    if (game == false)
                    {
                        trun--;
                        if (trun == -1)
                        {
                            trun = 3;
                        }
                        break;//게임 종료
                    }
                }
                else//Com3
                {
                    if (com3.HandList.Count != 0)
                    {
                        if (gameover == 3)
                        {
                            break;//게임 종료
                        }
                        Console.SetCursorPosition(66, 10);
                        Console.WriteLine("   Com3의 턴   ");
                    }
                    ComAI(com3);
                    if (game == false)
                    {
                        trun--;
                        if (trun == -1)
                        {
                            trun = 3;
                        }
                        break;//게임 종료
                    }
                }
            }
            //player 0 com1 1 com2 2 com3 3
            Console.Clear();
            switch (Trun[trun])
            {
                case 0:
                    Console.WriteLine("Player Win!!!");
                    break;
                case 1:
                    Console.WriteLine("Com1 Win!!!");
                    break;
                case 2:
                    Console.WriteLine("Com2 Win!!!");
                    break;
                case 3:
                    Console.WriteLine("Com3 Win!!!");
                    break;
            }
            Console.WriteLine("다시 시작하겠습니까? y/n");
            string rs;
            while (true)
            {
                rs = Console.ReadLine();
                if (rs == "y" || rs == "n")
                {
                    break;
                }
            }
            if (rs == "y")
            {
                Console.Clear();
                Cardlist.Clear();
                GroundList.Clear();
                CardDic.Clear();
                AttackCard.Clear();
                game = true;
                gameover = 0;
                c = 0;
                trun = 0;
                Game();
            }
        }
        public static void ComAI(Player players)
        {
            if (players.HandList.Count != 0)
            {
                Console.SetCursorPosition(66, 11);
                Console.WriteLine($"Attackcount : {attackcount}         ");
                if (attackcount > 1)
                {
                    for (int i = 0; i < players.HandList.Count + 1; i++)
                    {
                        if (i == players.HandList.Count)
                        {
                            players.GetCard(attackcount);
                            break;
                        }
                        else if (codNum == 2 && AttackCard.Contains(players.HandList[i]))
                        {
                            players.UseCard(i);
                            break;
                        }
                        else if (codNum == 1 && code != "spade" && not2.Contains(players.HandList[i]))
                        {
                            players.UseCard(i);
                            break;
                        }
                        else if ((codNum == 1 || GroundList[0] == "blackjoker") && not3.Contains(players.HandList[i]))
                        {
                            players.UseCard(i);
                            break;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < players.HandList.Count + 1; i++)
                    {
                        if (i == players.HandList.Count)
                        {
                            players.GetCard(attackcount);
                            break;
                        }
                        else if (players.HandList[i].Contains(code) || CardDic[players.HandList[i]] % 13 == codNum ||
                            players.HandList[i] == "blackjoker" || players.HandList[i] == "joker" || code == "joker")
                        {
                            players.UseCard(i);
                            if (game == false)
                            {
                                break;
                            }
                            if (codNum == 7)
                            {
                                Console.SetCursorPosition(36, 16);
                                Console.Write("문양 변환");
                                Thread.Sleep(2000);
                                Console.SetCursorPosition(36, 16);
                                Console.Write("          ");
                                Random dom = new Random();
                                int ii7 = dom.Next(0, 4);
                                switch (ii7)
                                {
                                    case 0:
                                        code = "heart";
                                        break;
                                    case 1:
                                        code = "clover";
                                        break;
                                    case 2:
                                        code = "diamond";
                                        break;
                                    case 3:
                                        code = "spade";
                                        break;
                                }
                                Console.SetCursorPosition(36, 17);
                                Console.WriteLine($"  | {code} | | {codNum} |     ");
                            }
                            break;
                        }
                    }
                }
            }
            trun++;
            trun = trun % 4;
            Thread.Sleep(2000);
        }
        public static void MakePan()
        {
            for (int i = 0; i < 4; i++)
            {
                if (Trun[i] == 0)
                {
                    Console.SetCursorPosition(66, 35);
                    Console.Write("Player");
                    if (Trun[(i + 1) % 4] == 1 && Trun[(i + 2) % 4] == 2)
                    {
                        Console.SetCursorPosition(0, 17);
                        Console.Write("Com1");
                        Console.SetCursorPosition(66, 0);
                        Console.Write("Com2");
                        Console.SetCursorPosition(132, 17);
                        Console.Write("Com3");
                    }
                    else if(Trun[(i + 1) % 4] == 1 && Trun[(i + 2) % 4] == 3)
                    {
                        Console.SetCursorPosition(0, 17);
                        Console.Write("Com1");
                        Console.SetCursorPosition(66, 0);
                        Console.Write("Com3");
                        Console.SetCursorPosition(132, 17);
                        Console.Write("Com2");
                    }
                    else if(Trun[(i + 1) % 4] == 2 && Trun[(i + 2) % 4] == 1)
                    {
                        Console.SetCursorPosition(0, 17);
                        Console.Write("Com2");
                        Console.SetCursorPosition(66, 0);
                        Console.Write("Com1");
                        Console.SetCursorPosition(132, 17);
                        Console.Write("Com3");
                    }
                    else if (Trun[(i + 1) % 4] == 2 && Trun[(i + 2) % 4] == 3)
                    {
                        Console.SetCursorPosition(0, 17);
                        Console.Write("Com2");
                        Console.SetCursorPosition(66, 0);
                        Console.Write("Com3");
                        Console.SetCursorPosition(132, 17);
                        Console.Write("Com1");
                    }
                    else if (Trun[(i + 1) % 4] == 3 && Trun[(i + 2) % 4] == 1)
                    {
                        Console.SetCursorPosition(0, 17);
                        Console.Write("Com3");
                        Console.SetCursorPosition(66, 0);
                        Console.Write("Com1");
                        Console.SetCursorPosition(132, 17);
                        Console.Write("Com2");
                    }
                    else
                    {
                        Console.SetCursorPosition(0, 17);
                        Console.Write("Com3");
                        Console.SetCursorPosition(66, 0);
                        Console.Write("Com2");
                        Console.SetCursorPosition(132, 17);
                        Console.Write("Com1");
                    }
                }
            }
        }
        private static void creatCard()
        {
            for (int i = 0; i < 13; i++)
            {
                Cardlist.Add("heart" + Convert.ToString(i + 1));
                CardDic.Add("heart" + Convert.ToString(i + 1), i + 1);
            }
            for (int i = 0; i < 13; i++)
            {
                Cardlist.Add("clover" + Convert.ToString(i + 1));
                CardDic.Add("clover" + Convert.ToString(i + 1), i + 1 + 13);
            }
            for (int i = 0; i < 13; i++)
            {
                Cardlist.Add("diamond" + Convert.ToString(i + 1));
                CardDic.Add("diamond" + Convert.ToString(i + 1), i + 1 + (13 * 2));
            }
            for (int i = 0; i < 13; i++)
            {
                Cardlist.Add("spade" + Convert.ToString(i + 1));
                CardDic.Add("spade" + Convert.ToString(i + 1), i + 1 + (13 * 3));
            }
            Cardlist.Add("blackjoker");
            CardDic.Add("blackjoker", 53);
            Cardlist.Add("joker");
            CardDic.Add("joker", 54);
            for(int i = 0; i < 2; i++)
            {
                AttackCard.Add("heart" + Convert.ToString(i + 1));
                AttackCard.Add("clover" + Convert.ToString(i + 1));
                AttackCard.Add("diamond" + Convert.ToString(i + 1));
                AttackCard.Add("spade" + Convert.ToString(i + 1));
            }
            AttackCard.Add("joker");
            AttackCard.Add("blackjoker");

        }
        public static void EndlessCard()
        {
            for (int i = 1; i < GroundList.Count; i++)
            {
                Cardlist.Add(GroundList[i]);
                GroundList.RemoveAt(i);
            }
        }
        public static void MakeGround()
        {
            Random random = new Random();
            int a = random.Next(0, Cardlist.Count);
            GroundList.Add(Cardlist[a]);
            Cardlist.RemoveAt(a);
            ShowGround();
        }
        public static void ShowGround()
        {
            #region code
            if (GroundList[0].Contains("heart"))
            {
                code = "heart";
            }
            else if (GroundList[0].Contains("clover"))
            {
                code = "clover";
            }
            else if (GroundList[0].Contains("diamond"))
            {
                code = "diamond";
            }
            else if (GroundList[0].Contains("spade"))
            {
                code = "spade";
            }
            else
            {
                code = "joker";
            }
            #endregion
            #region codNum
            if (code == "joker")
            {
                codNum = 99;
            }
            else if(CardDic[GroundList[0]] % 13 == 0)
            {
                codNum = 13;
            }
            else
            {
                codNum = CardDic[GroundList[0]] % 13;
            }
            Console.SetCursorPosition(36, 17);
            Console.WriteLine($"  | {code} | | {codNum} |     ");
            #endregion
        }
    }
    class Player : Program
    {
        public List<string> HandList = new List<string>();
        
        public void GetHand()
        {
            Random random = new Random();
            int a = random.Next(0, Cardlist.Count);
            HandList.Add(Cardlist[a]);
            Cardlist.RemoveAt(a);
        }
        public void GetCard(int Value)
        {
            if (Value > Cardlist.Count)
            {
                EndlessCard();
            }
            for (int i = 0; i < Value; i++)
            {
                Random random = new Random();
                int a = random.Next(0, Cardlist.Count);
                HandList.Add(Cardlist[a]);
                Cardlist.RemoveAt(a);
                attackcount = 1;
            }
            if (HandList.Count >= 20)
            {
                for (int i = 0; i < HandList.Count; i++)
                {
                    Cardlist.Add(HandList[i]);
                }
                HandList.Clear();
                Console.WriteLine("패배하였습니다.");
                gameover++;
            }
        }
        public void UseCard(int Value)
        {
            GroundList.Insert(0, HandList[Value]);
            HandList.RemoveAt(Value);
            ShowGround();
            if (CardDic[GroundList[0]] % 13 == 11)
            {
                trun++;
                trun = trun % 4;
                Console.SetCursorPosition(66, 32);
                Console.Write("건너뛰기");
                Thread.Sleep(700);
                Console.SetCursorPosition(66, 32);
                Console.Write("         ");
            }
            if(CardDic[GroundList[0]] % 13 == 12)
            {
                int t = trun - 1;
                if (t < 0)
                {
                    t = 3;
                }
                int tt = trun + 1;
                if (tt > 3)
                {
                    tt = 0;
                }
                int T = Trun[t];
                int T1 = Trun[tt];
                Trun[t] = T1;
                Trun[tt] = T;
                Console.SetCursorPosition(66, 32);
                Console.Write("방향전환");
                Thread.Sleep(700);
                Console.SetCursorPosition(66, 32);
                Console.Write("         ");
            }
            if (codNum==13)
            {
                trun--;
                trun = trun % 4;
            }
            
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
                else if (code== "spade" || GroundList[0].Contains("blackjoker"))
                {
                    attackcount += 5;
                }
                else if(GroundList[0].Contains("joker"))
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
                Console.WriteLine("승리하였습니다.");
                game = false;
            }
        }
        public void ShowMyHand(int c)
        {
            if (HandList.Count != 0)
            {
                Console.SetCursorPosition(20, 38);
                for (int i = 0; i < c; i++)
                {
                    Console.Write($" {HandList[i]} ");
                    if (i == 10)
                    {
                        Console.SetCursorPosition(20, 39);
                    }
                }
                if (c == 11)
                {
                    Console.SetCursorPosition(20, 39);
                }
                Console.Write($" [{HandList[c]}] ");
                for (int i = c + 1; i < HandList.Count; i++)
                {
                    Console.Write($" {HandList[i]}  ");
                    if (i == 10)
                    {
                        Console.SetCursorPosition(20, 39);
                    }
                }
                Console.Write("             ");
            }
        }
    }
}
