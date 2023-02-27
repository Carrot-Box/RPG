using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXTRPG
{
    internal class Second_Floor
    {
        public static STARTSELECT Battle2(Player _Player)
        {
            Monster NewMonster2 = new Monster();
            NewMonster2.SetUp(300, 100, 1000, 1000, "정예");
            while (!NewMonster2.IsDeath() && !_Player.IsDeath())
            {
                Console.Clear();
                _Player.StatusRender();
                NewMonster2.StatusRender();
                Console.WriteLine("2층에 진입하셨습니다.\n정예등급 몬스터가 나옵니다.");
                Console.WriteLine("1. 싸운다\n2. 도망간다\n");
                Console.ReadKey();
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("의라챠차\n");
                        NewMonster2.Damage(_Player.GetAtt);
                        if (!NewMonster2.IsDeath())
                        {
                            _Player.Damage(NewMonster2.GetAtt);
                            // if에서 확률에 속하면 크리티컬 아니면 이 매소드
                            //if (NewMonster2.AttRandom())
                            //{
                            //    _Player.Damage(NewMonster2.Critical());
                            //}
                            break;
                        }
                        NewMonster2.IsDeath();
                        Console.WriteLine("적을 처치하였습니다.\n몬스터의 체력이 0이 되었습니다.\n");
                        Console.ReadKey();
                        Console.Clear();
                        _Player.LvUp();
                        Console.WriteLine("어디로 가시겠습니까?\n");
                        Console.WriteLine("1. 마을로 돌아가기\n2. 3층으로 올라가기");
                        Console.WriteLine("------------------------------");
                        switch (Console.ReadKey().Key)
                        {
                            case ConsoleKey.D1:
                                Console.WriteLine("\n마을로 돌아가겠습니다.");
                                Console.ReadKey();
                                return STARTSELECT.SELECTTOWN;
                            case ConsoleKey.D2:
                                Console.WriteLine("\n3층으로 입장하겠습니다.");
                                Console.ReadKey();
                                return STARTSELECT.BATTLE3;
                        }
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine("호다다닥");
                        Console.ReadKey();
                        return STARTSELECT.SELECTTOWN;
                    default:
                        Console.WriteLine("잘못된 선택입니다.");
                        Console.ReadKey();
                        break;
                }
            }
            Console.Clear();
            _Player.StatusRender();
            NewMonster2.StatusRender();
            Console.WriteLine("플레이어가 사망했습니다\n마을로 돌아가겠습니다.");
            Console.ReadKey();
            return STARTSELECT.SELECTTOWN;
        }
    }
}
