using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

public enum thePlayerState
{
    idle,
    walk,
    run
}
namespace _4weeks
{
    class Program
    {
        static void Main(string[] args)
        {
            //int mymoney = 1000000;

            //MyBanking Abanking = new MyBanking();
            //MyBanking Bbanking = new MyBanking();
            //do
            //{
            //    Console.WriteLine("1.입금 2.출금 3.이체");
            //    string A = Console.ReadLine();
            //    if (A == "1")
            //    {
            //        Console.Write("입금할 금액 : ");
            //        int pmoney = Convert.ToInt32(Console.ReadLine());
            //        Abanking.Deposit(pmoney);
            //        mymoney -= pmoney;
            //        Console.WriteLine($"수중의 돈 : {mymoney}");
            //    }
            //    else if (A == "2")
            //    {
            //        Console.Write("출금할 금액 : ");
            //        int pmoney = Convert.ToInt32(Console.ReadLine());
            //        Abanking.Withdrawal(pmoney);
            //        mymoney += pmoney;
            //        Console.WriteLine($"수중의 돈 : {mymoney}");
            //    }
            //    else if (A == "3")
            //    {
            //        Console.Write("이체할 금액 : ");
            //        int pmoney = Convert.ToInt32(Console.ReadLine());
            //        Console.Write("A통장 : ");
            //        Abanking.Transfer(pmoney);
            //        Console.Write("B통장 : ");
            //        Bbanking.Deposit(pmoney);
            //    }
            //    else
            //    {
            //        Console.WriteLine("종료합니다.");
            //        break;
            //    }
            //} while (true);
            //------------------------------------------------------------------------------
            //Random random = new Random();

            //int ranInt = random.Next(0, 10);
            //Console.WriteLine(ranInt);
            //-----------------------------------------------------------------
            //thePlayerState myState = thePlayerState.idle;

            //switch (myState)
            //{
            //    case thePlayerState.idle:
            //        Console.WriteLine("idle");
            //        break;
            //    case thePlayerState.run:
            //        Console.WriteLine("run");
            //        break;
            //    case thePlayerState.walk:
            //        Console.WriteLine("walk");
            //        break;
            //}
            //프로퍼티
            //------------------------------------------------------
            //Player player = new Player();
            //DarkMonster dark = new DarkMonster();
            //player.AttackMonster(dark);
            //Player player = new Player();
            //Monster monster = new Monster();
            //while (player.hp != 0 && monster.hp != 0)
            //{
            //    player.Attack(monster);
            //    Thread.Sleep(500);
            //    monster.Attack(player);
            //    Thread.Sleep(500);
            //}
            //if (player.hp == 0)
            //{
            //    Console.WriteLine("플레이어 사망");
            //}
            //if (monster.hp == 0)
            //{
            //    Console.WriteLine("몬스터 사망");
            //}
            //----------------------------------------------------------------
            //List<int> intList = new List<int>() {3,7,9,3,5};
            //for (int i = 0; i < intList.Count; i++)
            //{
            //    Console.WriteLine(intList[i]);
            //}
            //List<string> stringList = new List<string>() { "a", "c", "t", "e", "L" };
            //for (int i = 0; i < stringList.Count; i++)
            //{
            //    Console.WriteLine(stringList[i]);
            //}
            //List<float> floatList = new List<float>() { 34.56f, 672.63f, 532.64f, 326.34f, 3342.5f };
            //for (int i = 0; i < floatList.Count; i++)
            //{
            //    Console.WriteLine(floatList[i]);
            //}
            List<Monster> MonsterList = new List<Monster>();

            Monster zombie = new Monster();
            zombie.name = "zombie";

            Monster skoul = new Monster();
            skoul.name = "skoul";

            Monster slaime = new Monster();
            slaime.name = "slaime";

            Monster golam = new Monster();
            golam.name = "golam";

            Monster dragon = new Monster();
            dragon.name = "dragon";

            MonsterList.Add(zombie);
            MonsterList.Add(skoul);
            MonsterList.Add(slaime);
            MonsterList.Add(golam);
            MonsterList.Add(dragon);

            
            Dictionary<string, Monster> myDic = new Dictionary<string, Monster>();

            myDic["Zombie"] = zombie;
            myDic["Skoul"] = skoul;
            myDic["Slaime"] = slaime;
            myDic["Golam"] = golam;
            myDic["Dragon"] = dragon;

            myDic["Zombie"].IntroduceMonster();
            myDic["Skoul"].IntroduceMonster();
            myDic["Slaime"].IntroduceMonster();
            myDic["Golam"].IntroduceMonster();
            myDic["Dragon"].IntroduceMonster();
        }
    }
    class Monster
    {
        public string name;
        public void IntroduceMonster()
        {
            Console.WriteLine($"This monster is {name}");
        }
    }
    //class Creature
    //{
    //    public virtual void Attack(Creature creature) { }//공격하기
    //    public virtual void Hit() { }//공격받기
    //    public virtual void Avoid() { }//회피하기
    //    public virtual void Getdamage() { }//피해받기
    //}
    //class Player : Creature
    //{
    //    public int hp = 5;
    //    public override void Attack(Creature creature)
    //    {
    //        Console.WriteLine("플레이어가 몬스터를 공격함");
    //        creature.Hit();

    //        Console.WriteLine();
    //    }

    //    public override void Avoid()
    //    {
    //        Console.WriteLine("플레이어 회피");
    //        Console.WriteLine();
    //    }

    //    public override void Getdamage()
    //    {
    //        hp--;
    //        Console.WriteLine($"플레이어 피격! 현제 체력 : {hp}");
    //        Console.WriteLine();
    //    }

    //    public override void Hit()
    //    {
    //        Random random = new Random();
    //        int ranInt = random.Next(0, 2);
    //        if (ranInt == 0)
    //        {
    //            Avoid();
    //        }
    //        else
    //        {
    //            Getdamage();
    //        }
    //        Console.WriteLine();
    //    }
    //}
    //class Monster : Creature
    //{
    //    public int hp = 5;
    //    public override void Attack(Creature creature)
    //    {
    //        Console.WriteLine("몬스터가 플레이어를 공격함");
    //        creature.Hit();
    //        Console.WriteLine();
    //    }

    //    public override void Avoid()
    //    {
    //        Console.WriteLine("몬스터 회피");
    //        Console.WriteLine();
    //    }

    //    public override void Getdamage()
    //    {
    //        hp--;
    //        Console.WriteLine($"몬스터 피격! 현제 체력 : {hp}");
    //        Console.WriteLine();
    //    }

    //    public override void Hit()
    //    {
    //        Random random = new Random();
    //        int ranInt = random.Next(0, 2);
    //        if (ranInt == 0)
    //        {
    //            Avoid();
    //        }
    //        else
    //        {
    //            Getdamage();
    //        }
    //        Console.WriteLine();
    //    }
    //}
    //interface monster
    //{
    //    void HitFromPlayer(int damage);
    //}

    //abstract class LightMonster
    //{
    //    int attackvalue = 10;
    //    public abstract void AttackPlayer(Player player);
    //}
    //class DarkMonster : monster
    //{
    //    int hp = 100;
    //    int attackValue = 10;
    //    public void HitFromPlayer(int damage)
    //    {
    //        hp = hp - damage;
    //        Console.WriteLine($"Monster : I'm Hit! my Hp is {hp}");
    //    }
    //    public virtual void AttackPlayer(Player player)
    //    {
    //        Console.WriteLine("Dark!!!");
    //        player.HitFromMonster(attackValue);
    //    }
    //}

    //class Zombie : DarkMonster
    //{
    //    public override void AttackPlayer(Player player)
    //    {
    //        base.AttackPlayer(player);
    //    }
    //}
    //class Player
    //{
    //    int hp = 100;
    //    int Attack = 15;
    //    public void AttackMonster(monster monster)
    //    {
    //        Console.WriteLine("Player : I'm Attacking Monster!");
    //        monster.HitFromPlayer(Attack);
    //    }
    //    public void HitFromMonster(int AttackValue)
    //    {
    //        hp = hp - AttackValue;
    //        Console.WriteLine($"my hp id{hp}");
    //    }
    //}

    //class MyBanking
    //{
    //    public int bankMoney = 0;
    //    public void Deposit(int pmoney)
    //    {
    //        bankMoney += pmoney;
    //        Console.WriteLine($"통장 내 잔고 : {bankMoney}");
    //    }
    //    public void Withdrawal(int pmoney)
    //    {
    //        bankMoney -= pmoney;
    //        Console.WriteLine($"통장 내 잔고 : {bankMoney}");
    //    }
    //    public void Transfer(int pmoney)
    //    {
    //        bankMoney -= pmoney;
    //        Console.WriteLine($"통장 내 잔고 : {bankMoney}");
    //    }
    //}
}
