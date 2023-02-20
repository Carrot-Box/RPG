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
                    Console.WriteLine("전장으로 떠나겠습니다.");
                    Console.ReadKey();
                    return STARTSELECT.SELECTBATTLE;
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
        public static STARTSELECT Battle(Player _Player)
        {
            Monster NewMonster = new Monster("기사");
            while (!NewMonster.IsDeath() && !_Player.IsDeath())
            {
                Console.Clear();
                _Player.StatusRender();
                NewMonster.StatusRender();
                Console.ReadKey();
                Console.WriteLine("덤벼라!");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("");
                        Console.ReadKey();
                        NewMonster.Damage(_Player);
                        if (!NewMonster.IsDeath())
                        {
                            _Player.Damage(NewMonster);
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
                        Console.WriteLine("1. 마을로 돌아가기\n2. 다음 스테이지로 넘어가지");
                        Console.WriteLine("------------------------------");
                        switch (Console.ReadKey().Key)
                        {
                            case ConsoleKey.D1:
                                Console.WriteLine("마을로 돌아가겠습니다.");
                                Console.ReadKey();
                                return STARTSELECT.SELECTTOWN;
                            case ConsoleKey.D2:
                                Console.WriteLine("다음 스테이지가 없습니다. 마을로 돌아가겠습니다.");
                                Console.ReadKey();
                                return STARTSELECT.BATTLE2;
                        }
                        break;
                }
            }
            return STARTSELECT.SELECTTOWN;
        }
        public static STARTSELECT Battle2(Player _Player)
        {
            Monster NewMonster2 = new Monster("하이오크");
            while (true)
            {
                Console.Clear();
                Console.WriteLine("2번째 가나다라");
                Console.WriteLine("마바사아자차카");
                Console.ReadKey();
                break;
            }
            return STARTSELECT.SELECTTOWN;
        }
    }
}
