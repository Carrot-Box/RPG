using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    int AT = 100;
    public int HP = 500;
    public int MAXHP = 1000;
    public int MP = 50;
    public int MAXMP = 500;

    public void PlayerSetting()
    {
        Console.WriteLine("-------------------");
        Console.WriteLine("AT : " + AT);
        Console.Write("HP : " + HP);
        Console.WriteLine("/" + MAXHP);
        Console.Write("MP : " + MP);
        Console.WriteLine("/" + MAXMP);
        Console.WriteLine("-------------------");
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
            Console.WriteLine("2. 배틀");

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
                Console.WriteLine("2. 명상");
                Console.WriteLine("3. 나가기");
                
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        //Q. 캡슐화를 안쓰고 플레이어의 hp를 채운다 한다면... 어떻게 해야할까?
                        if (_Player.HP < _Player.MAXHP)
                        {
                            _Player.HP = _Player.MAXHP;
                        }
                        else
                        {
                            Console.WriteLine("풀피입니다.");
                        }
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D2:
                        // 명상타임(딜레이함수)
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
