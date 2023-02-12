using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3week
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 키입력
            //ConsoleKeyInfo cski;

            //int x = 10;
            //int y = 10;

            //while (true)
            //{
            //    Console.Clear();

            //    Console.SetCursorPosition(x, y);

            //    Console.Write("#");

            //    cski = Console.ReadKey(true);

            //    switch (cski.Key)
            //    {
            //        case ConsoleKey.LeftArrow:
            //            x--;
            //            break;
            //        case ConsoleKey.RightArrow:
            //            x++;
            //            break;
            //        case ConsoleKey.UpArrow:
            //            y--;
            //            break;
            //        case ConsoleKey.DownArrow:
            //            y++;
            //            break;
            //    }
            //}
            #endregion
            #region 문제풀이
            //    //1. 산술 이항 하나씩 쓰기 (+-*/%),출력하기 5줄
            //    int a = 3;
            //    int b = 2;
            //    int s1 = a + b;
            //    int s2 = a - b;
            //    int s3 = a * b;
            //    int s4 = a / b;
            //    int s5 = a % b;
            //    Console.WriteLine("+ : " + s1);
            //    Console.WriteLine("- : " + s2);
            //    Console.WriteLine("* : " + s3);
            //    Console.WriteLine("/ : " + s4);
            //    Console.WriteLine("% : " + s5);
            //    //2.할당(+=...),출력하기 5줄
            //    a += b;
            //    Console.WriteLine("+= : " + a);
            //    a -= b;
            //    Console.WriteLine("-= : " + a);
            //    a *= b;
            //    Console.WriteLine("*= : " + a);
            //    a /= b;
            //    Console.WriteLine("/= : " + a);
            //    a %= b;
            //    Console.WriteLine("%= : " + a);
            //    //3.증감(++...) 앞뒤로 4줄
            //    Console.Write(++a);
            //    Console.WriteLine(" " + a);
            //    Console.Write(a++);
            //    Console.WriteLine(" " + a);
            //    Console.Write(--a);
            //    Console.WriteLine(" " + a);
            //    Console.Write(a--);
            //    Console.WriteLine(" " + a);
            //    //4. 2개 숫자 입력 후 A가 짝수 이고 B가 5보다 큰가를 if문으로
            //    //5. 아니면 A가 홀수 이거나 B가 3보다 작은가를 elseif문으로
            //    //6. else문으로 없음 출력하기

            //    //7.입력한 숫자만큼 문장 출력(while)
            //    //8.(for)

            //    //9.위에 했던 4~8을 메소드로 뽑아 실행하기
            //    ffs();
            //    se();
            //    //10. for문에서 숫자를 계속 입력받는다.
            //    //짝수인 경우 continue로 넘김
            //    //10인경우 break
            //    //그 외"다음 숫자 입력"출력

            //    Console.WriteLine("숫자입력");
            //    for (int i=1;i>0;i++)
            //    {
            //        i = 1;
            //        string nn = Console.ReadLine();
            //        int NN = Convert.ToInt32(nn);
            //        if (NN == 10)
            //        {
            //            break;
            //        }
            //        else if (NN % 2 == 0)
            //        {
            //            continue;
            //        }
            //        else
            //        {
            //            Console.WriteLine("다음 숫자를 입력");
            //        }
            //    }
            //}
            //private static void ffs()
            //{
            //    Console.WriteLine("숫자2개");
            //    string aa = Console.ReadLine();
            //    string bb = Console.ReadLine();
            //    int A = Convert.ToInt32(aa);
            //    int B = Convert.ToInt32(bb);
            //    if (A % 2 == 0 && B > 5)
            //    {
            //        Console.WriteLine("4번");
            //    }
            //    else if (A % 2 == 1 || B < 3)
            //    {
            //        Console.WriteLine("5번");
            //    }
            //    else
            //    {
            //        Console.WriteLine("없음");
            //    }
            //}
            //private static void se()
            //{
            //    Console.WriteLine("반복횟수입력");
            //    string c = Console.ReadLine();
            //    int C = Convert.ToInt32(c);
            //    int d = 0;
            //    while (d < C)
            //    {
            //        Console.WriteLine((d + 1) + "문장");
            //        d++;
            //    }
            //    Console.WriteLine();
            //    for (int i = 0; i < C; i++)
            //    {
            //        Console.WriteLine((i + 1) + "문장");
            //    }
            #endregion
            //Studunt Astudunt = new Studunt();
            //Astudunt.name = "윤종빈";
            //Astudunt.age = 29;

            //Astudunt.WritelineStudentInfo();

            ////1. 학생 하나의 정보 입력받기


            ////2. 학생 클래스를 만들어서 메소드로 학생 하나의 정보를 입력 받기
            //Astudunt.InputStudentInfoData();
            ////3.학생 클래스를 만들어서 for문으로 학생 여럿을 입력받는.
            //Studunt[] studunts = new Studunt[10];
            //for(int i = 0; i < 10; i++)
            //{
            //    studunts[i] = new Studunt();
            //    studunts[i].InputStudentInfoData();
            //}
            //먹을것 클래스를 만들어서 음식을 여러개 입력 받는다.
            //1.5개의 음식을 입력 받는다.
            //2.추가로 음식을 입력 받는데,5개중 이미 있는 음식이면 제외됩니다.
            //예)a,b,c,d,e가 있는데 추가로 b가 입력됨
            //   ->a,c,d,e가 된다.
            //Foods foods = new Foods();
            //foods.InputData();
            //foods.ExtraInputData();
            //foods.WriteData();

            //나이에 해당하는 띠를 출력해줄 클래스를 만든다.
            //탄생년도를 입력하면 해당하는 띠를 출력한다.
            //출력할 때 나이도 같이 계산되어 출력된다.
            //AGE x = new AGE();
            //x.InputAge();
            //x.PrintAge();

            //게임들을 보유하고 있는 게임 클레스를 제작한다.
            //게임을 입력하면 배열에 값이 있는지 비교해서 이지 없는지 출력한다.
            //Game name = new Game();
            //name.InputGame();
            //name.ExtraInput();
            //name.PrintData();

            //Classes myclass = new Classes();
            //myclass.WriteSchool("가정초등학교");
            //Korean korean = new Korean();
            //korean.MenuSetting();
            //korean.ShowMenu();

            //Console.WriteLine();

            //Console.Write("먹을 음식 : ");
            //int inputMenu = Convert.ToInt32(Console.ReadLine()) - 1;
            //korean.OderMenu(inputMenu);

            //Console.WriteLine();

            //Weston weston = new Weston();
            //weston.MenuSetting();
            //weston.ShowMenu();

            //Console.WriteLine();

            //Console.Write("먹을 음식 : ");
            //int InWMenu = Convert.ToInt32(Console.ReadLine()) - 1;
            //weston.OderMenu(InWMenu);

            //Console.WriteLine();

            //Chinies chinies = new Chinies();
            //chinies.MenuSetting();
            //chinies.ShowMenu();

            //Console.WriteLine();

            //Console.Write("먹을 음식 : ");
            //int InCMenu = Convert.ToInt32(Console.ReadLine()) - 1;
            //chinies.OderMenu(InCMenu);

            //9.서점 클ㄹㅐ스에 제목 ,지은이 ,출판사를 입력받아 책 데이터를 쌓는다.
            //특정 키를 입려ㄱ 바 때까지 지속되며,특정키 입력을 받으면
            //제목을 입력받고 제목에 맞는 지은이,ㅊ판사를 순서대로 출력한다.
            //BookShop book = new BookShop();
            //book.InputData();
            //book.SearchData();
            Classes classes = new Classes();
            classes.InputData();
            classes.SearchData();
        }
    }

    class School
    {
        protected string[] student;
        protected int[] classes;
        public void InputData()
        {
            student = new string[99];
            classes = new int[99];
            for(int i = 0; ; i++)
            {
                Console.Write("이름 : ");
                student[i] = Console.ReadLine();
                Console.WriteLine();
                Console.Write("반 : ");
                classes[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("입력 끝? Y/N");
                string a = Console.ReadLine();
                if (a == "y" || a == "Y")
                {
                    break;
                }
            }
        }
    }
    class Classes : School
    {
        public void SearchData()
        {
            Console.WriteLine("검색할 반을 입력하세요");
            int a=Convert.ToInt32(Console.ReadLine());
            for(int i = 0; ; i++)
            {
                if (a == classes[i])
                {
                    Console.WriteLine(student[i]);
                }
                if (student[i + 1] == null)
                {
                    break;
                }
            }
        }
    }
    //class BookShop
    //{
    //    public string[] books;
    //    public string[] person;
    //    public string[] comperm;
    //    public void InputData()
    //    {
    //        books = new string[99];
    //        person = new string[99];
    //        comperm = new string[99];
    //        for(int i = 0; ;i++)
    //        {
    //            Console.Write("책 제목 : ");
    //            books[i] = Console.ReadLine();
    //            Console.WriteLine();
    //            Console.Write("작가 이름 : ");
    //            person[i] = Console.ReadLine();
    //            Console.WriteLine();
    //            Console.Write("출판사 : ");
    //            comperm[i] = Console.ReadLine();
    //            Console.WriteLine();
    //            Console.WriteLine("계속 입력할까요? Y/N");
    //            string a = Console.ReadLine();
    //            if (a == "N" || a == "n")
    //            {
    //                break;
    //            }
    //        }
    //    }
    //    public void SearchData()
    //    {
    //        Console.WriteLine("책 제목을 입력해세요.");
    //        string a = Console.ReadLine();
    //        for(int i=0; ; i++)
    //        {
    //            if (a == books[i])
    //            {
    //                Console.WriteLine($"책 제목 : {books[i]}");
    //                Console.WriteLine($"작가 : {person[i]}");
    //                Console.WriteLine($"출판사 : {comperm[i]}");
    //                break;
    //            }
    //            if (books[i] == null)
    //            {
    //                Console.WriteLine("찾지 못하였습니다.");
    //                break;
    //            }
    //        }
    //    }
    //}

    //class Restaurant
    //{
    //    protected string[] menu;
    //    protected int[] menuPrice;

    //    public void TakeMoney(int money)
    //    {
    //        Console.WriteLine($"돈내기 : {money}");
    //    }
    //    public void OderMenu(int number)
    //    {
    //        Console.WriteLine($"주문 : {menu[number]}");
    //        TakeMoney(menuPrice[number]);
    //    }
    //    public void ShowMenu()
    //    {
    //        Console.Write("종류 : ");
    //        for(int i = 0; i < menu.Count(); i++)
    //        {
    //            Console.Write($"{menu[i]}  ");
    //        }
    //    }
    //}
    //class Korean : Restaurant
    //{
    //    public void MenuSetting()
    //    {
    //        menu = new string[2];
    //        menu[0] = "밥";
    //        menu[1] = "국";

    //        menuPrice = new int[2];
    //        menuPrice[0] = 1000;
    //        menuPrice[1] = 8000;
    //    }
    //}
    //class Weston : Restaurant
    //{
    //    public void MenuSetting()
    //    {
    //        menu = new string[3];
    //        menu[0] = "스파게티";
    //        menu[1] = "피자";
    //        menu[2] = "햄버거";

    //        menuPrice = new int[3];
    //        menuPrice[0] = 8000;
    //        menuPrice[1] = 12000;
    //        menuPrice[2] = 6000;
    //    }
    //}
    //class Chinies : Restaurant
    //{
    //    public void MenuSetting()
    //    {
    //        menu = new string[3];
    //        menu[0] = "짜장면";
    //        menu[1] = "짬뽕";
    //        menu[2] = "탕수육";

    //        menuPrice = new int[3];
    //        menuPrice[0] = 5000;
    //        menuPrice[1] = 6000;
    //        menuPrice[2] = 12000;
    //    }
    //}

    //class school
    //{
    //    protected string SchoolName;
    //    protected void WriteSchoolName()
    //    {
    //        Console.WriteLine($"학교이름 : {SchoolName}");
    //    }
    //}
    //class Classes : school
    //{
    //    private string ClassesName = "3반";
    //    public void WriteSchool(string _schoolName)
    //    {
    //        SchoolName = _schoolName;
    //        WriteSchoolName();
    //        Console.WriteLine($"내 반은 {ClassesName}");
    //    }
    //}
    //class Game
    //{
    //    public string[] games;

    //    public void InputGame()
    //    {
    //        games = new string[5];
    //        for (int i = 0; i < 5; i++)
    //        {
    //            games[i] = Console.ReadLine();
    //        }
    //    }
    //    public void ExtraInput()
    //    {
    //        Console.Write("선택한 게임 : ");
    //        string a = Console.ReadLine();
    //        for (int i = 0; i < 5; i++)
    //        {
    //            if (a == games[i])
    //            {
    //                games[i] += " *";
    //                break;
    //            }
    //            if (i == 4)
    //            {
    //                Console.WriteLine("없습니다.");
    //            }
    //        }
    //    }
    //    public void PrintData()
    //    {
    //        for (int i = 0; i < 5; i++)
    //        {
    //            Console.WriteLine(games[i]);
    //        }
    //    }
    //}
    
    //class AGE
    //{
    //    public int age;
    //    public void InputAge()
    //    {
    //        string myage = Console.ReadLine();
    //        age = Convert.ToInt32(myage);
    //    }
    //    public void PrintAge()
    //    {
    //        int a = age % 12;
    //        switch (a)
    //        {
    //            case 0:
    //                Console.WriteLine("원숭이");
    //                break;
    //            case 1:
    //                Console.WriteLine("닭");
    //                break;
    //            case 2:
    //                Console.WriteLine("개");
    //                break;
    //            case 3:
    //                Console.WriteLine("돼지");
    //                break;
    //            case 4:
    //                Console.WriteLine("쥐");
    //                break;
    //            case 5:
    //                Console.WriteLine("소");
    //                break;
    //            case 6:
    //                Console.WriteLine("호랑이");
    //                break;
    //            case 7:
    //                Console.WriteLine("토끼");
    //                break;
    //            case 8:
    //                Console.WriteLine("용");
    //                break;
    //            case 9:
    //                Console.WriteLine("뱀");
    //                break;
    //            case 10:
    //                Console.WriteLine("말");
    //                break;
    //            case 11:
    //                Console.WriteLine("양");
    //                break;
    //        }
    //    }
    //}

    //class Foods
    //{
    //    public string[] FoodList;
    //    public void InputData()
    //    {
    //        FoodList = new string[5];
    //        for (int i = 0; i < 5; i++)
    //        {
    //            Console.Write("음식이름 : ");
    //            FoodList[i] = Console.ReadLine();
    //        }
    //    }
    //    public void ExtraInputData()
    //    {
    //        Console.WriteLine("추가 음식 입력");
    //        string extraFood = Console.ReadLine();
    //        for (int i = 0; i < 5; i++)
    //        {
    //            if (extraFood == FoodList[i])
    //            {
    //                FoodList[i] = " ";
    //                break;
    //            }
    //        }
    //    }
    //    public void WriteData()
    //    {
    //        for (int i = 0; i < 5; i++)
    //        {
    //            Console.WriteLine($"남은 음식이름{FoodList[i]}");
    //        }
    //    }
    //}
    
    //class Studunt
    //{
    //    public string name;
    //    public int age;

    //    public void WritelineStudentInfo()
    //    {
    //        System.Console.WriteLine($"학생의 이름은 {name}");
    //        System.Console.WriteLine($"학생의 나이는 {age}");
    //    }
    //    public void InputStudentInfoData()
    //    {
    //        name = Console.ReadLine();
    //        age = Convert.ToInt32(Console.ReadLine());

    //        WritelineStudentInfo();
    //    }
    //}
}
