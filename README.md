# JONG

## 제작 
윤종빈

## 기간

2023/02/19 ~ 2023/03/05
## ONE CARD GAME
### 목표

원카드 게임을 C#콘솔창에서 재현
### 사용기술
리스트를 샐성하고 추가 및 제거하는 방식을 주로 사용하였다.

public static List<string> Cardlist = new List<string>();
public static List<string> GroundList = new List<string>();

위에서부터 카드뭉치,바닥에 내려놓은 카드를 구현하기 위해 선언하고

public static Dictionary<string, int> CardDic = new Dictionary<string, int>();

카드를 사용할 수 있는지 구분하기 위해 Dictionary를 사용하였다.

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
        
        카드를 생성하여 Cardlist와 CardDic에 저장하는 메소드이다.
        리스트에 저장한 이름은 검색어 기능을 하도록 디셔너리의 키코드 또한 같은 이름으로 생성하였다.
        해당 메소드를 처음 제작했을 때 딕셔너리에 검색한 결과가 같으면 카드를 사용할 수 있도록 만들 계획이였지만
        검색 결과가 같은 딕셔너리는 생성할 수가 없어 13의 배수를 검색 결과에 넣었다.
        
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
        
                바닥에 놓인 카드를 code와 codNum으로 저장하고 code와 codNum를 보여주는 메소드이다.
                code는 지정한 단어를 포함하고 있으면 지정한 단어를 저장하며
                codNum은 바닥에 놓인 카드를 CardDic에 검색하여 나온 결과를 13으로 나눈 나머지 값에 따라 숫자를 저장하도록 만들었                   다.

    class Player : Program //유저와 컴퓨터의 공통된 행동(메소드)을 묶어놓기 위해 만든 클래스이다.
                            부모 클래스를 따로 만들어 본문에서 선언하면 Cardlist를 공유하지 않아
                             본문이 포함된 클래스에 리스트를 선언하고 해당 클래스를 부모 클래스로 지정하였다.
    {
        public List<string> HandList = new List<string>();//손패를 구현하는 리스트이다.
                                                            손패는 각자 저장해햐 하기 때문에 자식클래스에 생성하였다.
        
        public void GetHand()//게임 시작시 각 플레이어에게 패를 분배하기 위한 메소드이다.
        {
            Random random = new Random();
            int a = random.Next(0, Cardlist.Count);
            HandList.Add(Cardlist[a]);
            Cardlist.RemoveAt(a);
        }
        public void GetCard(int Value)//턴을 넘기거나 공격 받을시 방어에 실패한 경우 attackpoint값만큼
                                        Cardlist에서 카드를 얻도록만든 메소드이다. 
                                        attackpoint값은 평소 1값을 가지고 있어 공격받지 않아도 턴을 넘기면
                                        카드를 1장 얻도록 만들었다.
                                        플레이어중 누군가가 공격카드를 사용하면 attackpoint값이 올라가고
                                        방어에 실패하면 attackpoint값만큼 카드를 얻도록 Main함수에서 attackpoint를
                                        대입하여 사용하였다.
        {
            if (Value > Cardlist.Count)//attackpoint가 Cardlist의 크기보다 크면 Groundlist에서 한장만 남기고 Cardlist에
                                                       추가한다.
            {
                EndlessCard();//리스트 보충용 메소드
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
