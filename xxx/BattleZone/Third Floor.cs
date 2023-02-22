using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 몬스터
//
namespace TEXTRPG
{
    public class ThirdFloor
    {
        public static STARTSELECT Battle3(Player _Player)
        {
            Console.Clear();
            _Player.StatusRender();
            Console.WriteLine("웰컴 투 삼층");
            Console.ReadKey();

            return STARTSELECT.NONESELECT;
        }
    }
}
