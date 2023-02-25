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
