using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 출처 : 나혼렙 주술회전

namespace TEXTRPG
{
    internal class Player_Skill
    {
        int mMP = 100;

        public int MP { get => mMP; set => mMP = value; }

        public void PlayerSkill()
        {
            Console.WriteLine("1. 살기\n2. 난도\n3. 영역전개");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.Q:
                    Murderous_Spirit();
                    break;
                case ConsoleKey.W:
                    Mutilat();
                    break;
                case ConsoleKey.E:
                    Area_Expention();
                    break;
            }
        }
        public void Murderous_Spirit()
        {
            MP -= 100;
            
            //1.살기 MP 100
            //    1.강력한 기운으로 대상을 공포에 빠트린다.
            //    2. 2턴 지속
        }
        public void Mutilat()
        {
            MP -= 130;
            
            //2. 난도 MP 130
            //    1. 효율적으로 공격하는 방법을 알게 되었다.
            //    2. 한번의 공격에 3연타 날림
        }
        public void Area_Expention()
        {
            MP -= 200;
            //3. 영역전개 MP 200
            //    1. 자신만의 고유 공간을 얻는다.
            //    2. 모든 능력치를 2배 올린다
        }

    }
}
