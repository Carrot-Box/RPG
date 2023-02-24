using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEXTRPG;

public class Monster : FightUnit
{
    public void SetUp(int _ATT, int _DEF, int _HP, int _MAXHP, string _Name)
    {
        ATT = _ATT;
        DEF = _DEF;
        HP = _HP;
        MAXHP = _MAXHP;
        Name = _Name;
    }
    // 크리티컬 & 크리티컬 확률
    //public int Critical()
    //{
    //    return (int)(GetAtt * 130 / 100);
    //}
    //public void AttRandom()
    //{
    //    Random rand = new Random();
    //    for (int i = 0; i < 101; i++)
    //    {
    //        int CreDamg = rand.Next(1, 101);
    //    }
    //}
   
}