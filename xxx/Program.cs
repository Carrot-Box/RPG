using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    public int AT = 500;
    public int HP = 500;
    public int MAXHP = 1000;

    public void PrintHp()
    {
        Console.Write("현재 당신의 HP는 " + HP);
        Console.WriteLine("입니다.");
    }
    public void MaxHp()
    {
        if (HP < MAXHP)
        {
            HP = MAXHP;
            PrintHp();
        }
        else
        {
            Console.WriteLine("체력이 가득찼습니다.");
        }
    }
    public void PlayerStatusRender()
    {
        Console.WriteLine("---------UserStatus---------");
        Console.WriteLine("AT : " + AT);
        Console.Write("HP : " + HP);
        Console.WriteLine("/" + MAXHP);
        Console.WriteLine("----------------------------");
    }
}
class Monster
{
    public int AT = 100;
    public int HP = 1000;
    public int MAXHP = 1000;


    public void MonStatusRender()
    {
        Console.WriteLine("----------------------------");
        Console.WriteLine("AT : " + AT);
        Console.Write("HP : " + HP);
        Console.WriteLine("/" + MAXHP);
        Console.WriteLine("----------------------------");
    }
}
enum STARTSELECT
{
    TOWN,
    BATTLE,
    NONE
}
namespace xxx
{
    internal class Program
    {
        static STARTSELECT StartSelect()
        {
            Console.Clear();
            Console.WriteLine("이세계에 오신걸 환영합니다. \n어디로 가시겠습니까?");
            Console.WriteLine("1. 마을");
            Console.WriteLine("2. 전장");
            Console.WriteLine("----------------------------");

            ConsoleKeyInfo CKI = Console.ReadKey();
            switch (CKI.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("마을에 입장하시겠습니다.");
                    Console.ReadKey();
                    return STARTSELECT.TOWN;
                case ConsoleKey.D2:
                    Console.WriteLine("전장으로 입장하셨습니다.");
                    Console.ReadKey();
                    return STARTSELECT.BATTLE;
                default:
                    Console.WriteLine("잘못된 선택입니다");
                    Console.ReadKey();
                    return STARTSELECT.NONE;
            }
        }
        static void Town(Player _Player)
        {   
            while (true)
            {
                Console.Clear();
                _Player.PlayerStatusRender();
                Console.WriteLine("마을에 입장하신걸 환영합니다. \n무엇을 고르겠습니까");
                Console.WriteLine("1. 체력회복");
                Console.WriteLine("2. 머하지..?");
                Console.WriteLine("3. 나가기");
                Console.WriteLine("----------------------------");

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        _Player.MaxHp();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D2:
                        // 미정
                        break;
                    case ConsoleKey.D3:
                        return;
                }
            }
        }
        static void Battle(Player _Player)
        {
            Monster NewMonster = new Monster();

            while (true)
            {
                Console.Clear();
                _Player.PlayerStatusRender();
                NewMonster.MonStatusRender();
                Console.WriteLine("몬스터가 출현했다!!! \n무엇을 고르겠습니까");
                Console.WriteLine("1. 싸운다");
                Console.WriteLine("2. 자폭한다");
                Console.WriteLine("3. 도망간다");
                Console.WriteLine("----------------------------");
                //Console.ReadKey();

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        _Player.HP -= NewMonster.AT;
                        NewMonster.HP -= _Player.AT;
                        Console.ReadKey();
                        if (NewMonster.HP == 0)
                        {
                            //NewMonster.MonStatusRender();
                            Console.WriteLine("승리하였습니다.\n마을로 돌아가겠습니다.");
                            Console.ReadKey();
                            Town(_Player);

                        }
                        else if (_Player.HP == 0)
                        {
                            Console.WriteLine("패배하였습니다\n마을로 돌아가겠습니다.");
                            Town(_Player);
                        }
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine("펑!");
                        Console.ReadKey();
                        return;
                    case ConsoleKey.D3:
                        Console.WriteLine("니게룽다요~");
                        Console.ReadKey();
                        return;
                }
            }
        }
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();

            while (true)
            {
                STARTSELECT SelectCheck = StartSelect();

                switch (SelectCheck)
                {
                    case STARTSELECT.TOWN:
                        Town(NewPlayer);
                        break;
                    case STARTSELECT.BATTLE:
                        Battle(NewPlayer);
                        break;
                }
            }
        }
    }
}

// 2.16 몬스터 클래스 + 니게룽다요