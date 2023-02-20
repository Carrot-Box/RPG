using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FightUnit
{
    protected string Name = "None";
    protected int ATT = 200;
    protected int DEF = 100;
    protected int HP = 500;
    protected int MAXHP = 1000;

    public bool IsDeath()
    {
        return HP <= 0;
    }
    public void Damage(FightUnit _OtherUnit)
    {
        Console.WriteLine(Name + "가" + _OtherUnit.ATT + "의 데미지를 입었습니다");
        Console.ReadKey();
        HP -= _OtherUnit.ATT;
    }
    public void StatusRender()
    {
        Console.WriteLine(Name + "------------------------");
        Console.WriteLine("AT : " + ATT + "      DEF : " + DEF);
        Console.WriteLine("HP : " + HP + "/" + MAXHP);
        Console.WriteLine("------------------------------");
    }
    public void LvUp()
    {
        ATT = (int)(ATT * 120 / 100);
        DEF = (int)(DEF * 120 / 100);
        HP = (int)(HP * 120 / 100);
        MAXHP = (int)(MAXHP * 120 / 100);
        StatusRender();
        Console.WriteLine("플레이어가 레벨업 하였습니다.");
    }
    public void AttMechanism()
    {
        if (true)
        {
            // 만약 Def가 0이 아니라면 Def를 떄린다
            // 만약 Def가 0이라면 Hp를 공격한다.
        }
    }
}