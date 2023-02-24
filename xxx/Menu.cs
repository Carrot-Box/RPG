using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXTRPG
{
    public class Menu
    {
        public static STARTSELECT StartSelect()
        {
            Console.Clear();
            Console.WriteLine("이세계에 오신것을 환영합니다,\n어느곳으로 가실 겁니까?");
            Console.WriteLine("1. 마을 \n2. 배틀");
            Console.WriteLine("------------------------------");

            ConsoleKeyInfo CKI = Console.ReadKey();
            switch (CKI.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("마을로 떠나겠습니다.");
                    Console.ReadKey();
                    return STARTSELECT.SELECTTOWN;
                case ConsoleKey.D2:
                    Console.WriteLine("타워로 떠나겠습니다.");
                    Console.WriteLine("A : 1F | B : 2F | C : 3F | D : 4F | E : 5F");
                    Console.ReadKey();
                    // 배틀필드 선택지 만들기
                    switch (Console.ReadKey().Key)
                    {
                        case ConsoleKey.A:
                            Console.WriteLine("1F");
                            return STARTSELECT.SELECTBATTLE;
                        case ConsoleKey.B:
                            Console.WriteLine("2F");
                            return STARTSELECT.BATTLE2;
                        case ConsoleKey.C:
                            Console.WriteLine("3F");
                            Console.ReadKey();
                            return STARTSELECT.BATTLE3;
                        case ConsoleKey.D:
                            Console.WriteLine("4F");
                            Console.ReadKey ();
                            return STARTSELECT.BATTLE4;
                        case ConsoleKey.E:
                            Console.WriteLine("5F");
                            Console.ReadKey();
                            return STARTSELECT.BATTLE5;
                        default:
                            Console.WriteLine("잘못된 선택입니다");
                            Console.ReadKey();
                            break;
                    }
                    return STARTSELECT.NONESELECT;
                default:
                    Console.WriteLine("잘못 입력하였습니다.");
                    Console.ReadKey();
                    return STARTSELECT.NONESELECT;
            }
        }
        public static STARTSELECT Town(Player _Player)
        {
            while (true)
            {
                Console.Clear();
                _Player.StatusRender();
                Console.WriteLine("마을에 오신것을 환영합니다. \n무엇을 도와드릴까요?");
                Console.WriteLine("1. 체력회복 \n2. 머하지... \n3. 떠나기");
                Console.WriteLine("------------------------------");

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        _Player.MaxHeal();
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine("이것을 보고있는 당신 생각해봐!");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D3:
                        return STARTSELECT.NONESELECT;
                }
            }
        }
    }
}
