using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXTRPG
{
    internal class Last_Floor
    {
        public static STARTSELECT Battle5(Player _Player)
        {
            Monster LastMonster = new Monster();
            LastMonster.SetUp(1000, 1000, 3000, 3000, "탑의 주인");
            while (!LastMonster.IsDeath()&&!_Player.IsDeath())
            {
                Console.Clear();
                Console.WriteLine("5층에 오신것을 환영합니다\n타워의 주인이 등장합니다.");
                _Player.StatusRender();
                LastMonster.StatusRender();
                Console.WriteLine("1. 싸우기\n2. 도망가기\n");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("통통폭탄!\n");
                        LastMonster.Damage(_Player.GetAtt);
                        if (!LastMonster.IsDeath())
                        {
                            _Player.Damage(LastMonster.GetAtt);
                            break;
                        }
                        Console.Clear();
                        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n                                          타워의 주인 체력이 0이 되었습니다.\n" +
                            "                                       타워의 주인과의 전투에서 승리하였습니다.");
                        Console.ReadKey();
                        return STARTSELECT.LAST;
                    case ConsoleKey.D2:
                        Console.Clear();
                        Console.WriteLine("핳하핳ㅎㅎ하ㅏㅏ핳ㅅ.");
                        Console.ReadKey();
                        return STARTSELECT.SELECTTOWN;
                    default:
                        break;
                }
            }
            Console.Clear();
            _Player.StatusRender();
            LastMonster.StatusRender();
            Console.WriteLine("플레이어의 체력이 0이 되었습니다.\n마을로 돌아가겠습니다.");
            Console.ReadKey();
            return STARTSELECT.SELECTTOWN;
        }
    }
}
