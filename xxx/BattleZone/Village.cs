using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXTRPG
{
    internal class Village
    {
        public static STARTSELECT Town(Player _Player)
        {
            while (true)
            {
                Console.Clear();
                _Player.StatusRender();
                Console.WriteLine("마을에 오신것을 환영합니다. \n무엇을 도와드릴까요?");
                Console.WriteLine("1. 체력회복 \n2. 타워 \n3. 떠나기");
                Console.WriteLine("------------------------------");

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        _Player.MaxHeal();
                        break;
                    case ConsoleKey.D2:
                        // D2를 바로 배틀 선택 페이지로 갈 수 있도록 만들어 보자
                        // 항상 나가고 배틀 누르고 층 수 누르기 귀찮음 해결 시급
                        Console.WriteLine("1. 1F | 2. 2F | 3. 3F | 4. 4F | 5. 5F");
                        switch (Console.ReadKey().Key)
                        {
                            case ConsoleKey.D1:
                                return STARTSELECT.SELECTBATTLE;
                            case ConsoleKey.D2:
                                return STARTSELECT.BATTLE2;
                            case ConsoleKey.D3:
                                return STARTSELECT.BATTLE3;
                            case ConsoleKey.D4:
                                return STARTSELECT.BATTLE4;
                            case ConsoleKey.D5:
                                return STARTSELECT.BATTLE5;
                            default:
                                Console.WriteLine("잘못된 선택입니다.");
                                break;
                        }
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D3:
                        return STARTSELECT.NONESELECT;
                }
            }
        }
    }
}
