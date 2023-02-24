using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXTRPG
{
    public class Third_Floor
    {
        public static STARTSELECT Battle3(Player _Player)
        {
            Monster NewMonster3 = new Monster();
            
            Console.Clear();
            _Player.StatusRender();
            NewMonster3.StatusRender();
            Console.WriteLine("3층에 도착하셨습니다\n장군등급 몬스터가 등장합니다.");
            Console.ReadKey();
            while (true)
            {
                break;
            }

            return STARTSELECT.NONESELECT;
        }
    }
}
