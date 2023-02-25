using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXTRPG
{
    public class First_Floor
    {
        public static STARTSELECT Battle(Player _Player)
        {
            Monster NewMonster = new Monster();
            NewMonster.SetUp(200, 100, 800, 800, "기사");
            while (!NewMonster.IsDeath() && !_Player.IsDeath())
            {
                Console.Clear();
                Console.WriteLine("1층에 진입하셨습니다.\n 기사등급 몬스터가 나타났습니다.");
                _Player.StatusRender();
                NewMonster.StatusRender();
                Console.WriteLine("1. 싸우기\n2. 도망가기\n");
                // D1 싸우기 D2 도망가기
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("덤벼랏\n");
                        switch (Console.ReadKey().Key)
                        {
                            case ConsoleKey.D1:
                                NewMonster.Damage(_Player.GetAtt);
                                if (!NewMonster.IsDeath())
                                {
                                    _Player.Damage(NewMonster.GetAtt);
                                    break;
                                }
                                // 몬스터가 죽었을 경우
                                NewMonster.IsDeath();
                                Console.WriteLine("몬스터 체력이 0이 되었습니다.");
                                Console.ReadKey();
                                Console.Clear();
                                Console.WriteLine("전투에서 승리하였습니다");
                                _Player.LvUp();
                                Console.WriteLine("어디로 가시겠습니까?");
                                Console.WriteLine("1. 마을로 돌아가기\n2. 2층으로 올라가기");
                                Console.WriteLine("------------------------------");
                                switch (Console.ReadKey().Key)
                                {
                                    case ConsoleKey.D1:
                                        Console.WriteLine("\n마을로 돌아가겠습니다.");
                                        Console.ReadKey();
                                        return STARTSELECT.SELECTTOWN;
                                    case ConsoleKey.D2:
                                        Console.WriteLine("\n2층으로 입장하겠습니다.");
                                        Console.ReadKey();
                                        return STARTSELECT.BATTLE2;
                                }
                                break;
                        }
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine("니게룽다요~★");
                        Console.ReadKey();
                        return STARTSELECT.SELECTTOWN;
                    default:
                        Console.WriteLine("잘못된 선택입니다.");
                        Console.ReadKey();
                        break;
                
                }
            }
            return STARTSELECT.SELECTTOWN;
        }
    }
}

