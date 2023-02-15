using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    int AT = 100;
    int HP = 500;
    int MP = 50;
    int MAXHP = 1000;
    int MAXMP = 500;

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
    public void PlayerSetting()
    {
        Console.WriteLine("---------UserStatus---------");
        Console.WriteLine("AT : " + AT);
        Console.Write("HP : " + HP);
        Console.WriteLine("/" + MAXHP);
        Console.Write("MP : " + MP);
        Console.WriteLine("/" + MAXMP);
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
                _Player.PlayerSetting();
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
            while (true)
            {
                Console.Clear();
                _Player.PlayerSetting();
                Console.WriteLine("적이 나타났다!!! \n무엇을 고르겠습니까");
                Console.WriteLine("1. 싸운다");
                Console.WriteLine("2. 자폭한다");
                Console.WriteLine("3. 도망간다");
                Console.WriteLine("----------------------------");

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        break;
                    case ConsoleKey.D2:
                        break;
                    case ConsoleKey.D3: 
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
