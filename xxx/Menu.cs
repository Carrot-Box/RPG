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
            Console.WriteLine("1. 마을 \n2. 타워");
            Console.WriteLine("------------------------------");

            ConsoleKeyInfo CKI = Console.ReadKey();
            switch (CKI.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("마을로 떠나겠습니다.");
                    Console.ReadKey();
                    return STARTSELECT.SELECTTOWN;
                case ConsoleKey.D2:
                    Console.WriteLine("타워로 떠나겠습니다.\n\n1. 1F | 2. 2F | 3. 3F | 4. 4F | 5. 5F");
                    // 배틀필드 선택지 만들기
                    switch (Console.ReadKey().Key)
                    {
                        case ConsoleKey.D1:
                            Console.WriteLine("1F");
                            Console.ReadKey();
                            return STARTSELECT.SELECTBATTLE;
                        case ConsoleKey.D2:
                            Console.WriteLine("2F");
                            Console.ReadKey();
                            return STARTSELECT.BATTLE2;
                        case ConsoleKey.D3:
                            Console.WriteLine("3F");
                            Console.ReadKey();
                            return STARTSELECT.BATTLE3;
                        case ConsoleKey.D4:
                            Console.WriteLine("4F");
                            Console.ReadKey ();
                            return STARTSELECT.BATTLE4;
                        case ConsoleKey.D5:
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
    }
}
