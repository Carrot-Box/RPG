using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Player : FightUnit
{
    public Player(string _Name)
    {
        Name = _Name;
    }
    public void PrintHp()
    {
        Console.WriteLine("현재 플레이어의 HP는" + HP + "입니다.");
        Console.ReadKey();
    }
    public void MaxHeal()
    {
        if (HP < MAXHP)
        {
            PrintHp();
            HP = MAXHP;
            DEF = MAXDEF;
            return;
        }
        Console.WriteLine("현재 플레이어의 HP는" + HP + "입니다.");
        Console.WriteLine("플레이어의 체력이 가득찼습니다.");
        Console.ReadKey();
    }
    public void LvUp()
    {
        ATT = (int)(GetAtt * 140 / 100);
        MAXDEF = (int)(MAXDEF * 140 / 100);
        HP = (int)(HP * 140 / 100);
        MAXHP = (int)(MAXHP * 140 / 100);
        StatusRender();
        Console.WriteLine("플레이어가 레벨업 하였습니다.\n");
    }
}