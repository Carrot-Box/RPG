using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXTRPG
{
    public class Fourth_Floor
    {
        public static STARTSELECT Battle4(Player _Player)
        {
            Monster NewMonster4 = new Monster();
            NewMonster4.SetUp(800, 1000, 2000, 2000, "군단장");
            while (!NewMonster4.IsDeath() && !_Player.IsDeath())
            {
                Console.Clear();
                Console.WriteLine("4층에 입장하셨습니다.\n군단장 등급의 몬스터가 등장합니다.");
                _Player.StatusRender();
                NewMonster4.StatusRender();
                Console.WriteLine("1. 싸우기\n2. 도망가기\n");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("슉. 슈슉 시. tlqkf럼아\n");
                        NewMonster4.Damage(_Player.GetAtt);
                        if (!NewMonster4.IsDeath())
                        {
                            _Player.Damage(NewMonster4.GetAtt);
                            break;
                        }
                        NewMonster4.IsDeath();
                        Console.WriteLine("\n몬스터 체력이 0이 되었습니다.\n플레이어의 승리입니다.");
                        Console.ReadKey();
                        Console.Clear();
                        _Player.LvUp();
                        Console.WriteLine("어디로 가시겠습니가?.\n1. 마을로 돌아가기\n2. 마지막층으로 올라가기");
                        switch (Console.ReadKey().Key)
                        {
                            case ConsoleKey.D1:
                                return STARTSELECT.SELECTTOWN;
                            case ConsoleKey.D2:
                                return STARTSELECT.BATTLE5;
                        }
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine("장군 등급 몬스터 : 쫄?");
                        Console.ReadKey();
                        return STARTSELECT.SELECTTOWN;
                    default:
                        break;
                }
            }
            Console.Clear();
            _Player.StatusRender();
            NewMonster4.StatusRender();
            Console.WriteLine("플레이어가 사망했습니다\n마을로 돌아가겠습니다.");
            Console.ReadKey();
            return STARTSELECT.SELECTTOWN;
        }
    }
}


