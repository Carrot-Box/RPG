using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXTRPG
{
    internal class Village
    {
        static void Shop(Player _Player, Inven _ShopInven)
        {
            while (true)
            {
                Console.Clear();
                _ShopInven.Render();
                _Player.Plven.Render();
                Console.ReadKey();
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.A:
                        _ShopInven.Left();
                        break;
                    case ConsoleKey.D:
                        _ShopInven.Right();
                        break;
                    case ConsoleKey.W:
                        _ShopInven.Up();
                        break;
                    case ConsoleKey.S:
                        _ShopInven.Down();
                        break;
                }
            }
        }
        public static STARTSELECT Town(Player _Player)
        {
            Inven ShopInven = new Inven(5, 3);
            ShopInven.ItemIn(new Item(1, "목재 단검", "플레이어가 나무로 단검이다", 100, 0, 0));
            ShopInven.ItemIn(new Item(2, "갑옷세트", "가장 기본적인 보호구다", 0, 100, 100));
            ShopInven.ItemIn(new Item(3, "유물의 반지", "대대손손 내려오는 반지이다.", 0, 0, 0));
            ShopInven.ItemIn(new Item(4, "철의 단검", "마을에서 흔히 볼수있는 단검이다", 0, 0, 0));
            ShopInven.ItemIn(new Item(5, "롱소드", "마을에서 흔히 볼수있는 장검이다", 0, 0, 0));
            while (true)
            {
                Console.Clear();
                _Player.StatusRender();
                Console.WriteLine("마을에 오신것을 환영합니다. \n무엇을 도와드릴까요?");
                Console.WriteLine("1. 체력회복 \n2. 타워 \n3. 상점\n4. 떠나기");
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
                        Shop(_Player, ShopInven);
                        break;
                    case ConsoleKey.D4:
                        return STARTSELECT.NONESELECT;
                }
            }
        }
    }
}
