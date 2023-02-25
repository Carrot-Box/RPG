using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 3층 들어가기 전 MP 시스템 + 스킬 획득 (스킬은 3종으로 예정중)
// 장군등급 몬스터부터 기본 스팩 높음 + 몬스터 고유 스킬 획득 or 확률적으로 크리터질예정
namespace TEXTRPG
{
    public class Third_Floor
    {
        public static STARTSELECT Battle3(Player _Player)
        {
            Monster NewMonster3 = new Monster();
            NewMonster3.SetUp(500, 300, 2000, 2000, "장군");
            while (true)
            {
                Console.Clear();
                _Player.StatusRender();
                NewMonster3.StatusRender();
                Console.WriteLine("3층에 도착하셨습니다\n장군등급 몬스터가 등장합니다.");
                Console.WriteLine("\n1. 싸우기\n2. 도망가기");
                Console.ReadKey();
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("피스- 피스-");
                        // 몬스터 치확치피 구연
                        // 플레이어 스킬 구연
                        NewMonster3.Damage(_Player.GetAtt);
                        if (!NewMonster3.IsDeath())
                        {
                            _Player.Damage(NewMonster3.GetAtt);
                            break;
                        }
                        Console.WriteLine("전투에서 승리하였습니다.\n몬스터 체력이 0이 되었습니다.");
                        Console.Clear();
                        _Player.LvUp();
                        Console.WriteLine("어디로 가시겠습니까?\n\n1. 마을로 돌아가기\n2. 4층으로 올라가기");
                        switch (Console.ReadKey().Key)
                        {
                            case ConsoleKey.D1:
                                Console.WriteLine("마을로 돌아가겠습니다.");
                                return STARTSELECT.SELECTTOWN;
                            case ConsoleKey.D2:
                                Console.WriteLine("4층으로 입장합니다.");
                                return STARTSELECT.BATTLE4;
                            default:
                                Console.WriteLine("잘못된 선택입니다.");
                                break;
                        }
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine("빤스런");
                        return STARTSELECT.SELECTTOWN;
                }
                break;
            }

            return STARTSELECT.NONESELECT;
        }
    }
}
