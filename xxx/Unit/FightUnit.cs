using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FightUnit
{
    protected string Name = "None";
    protected int ATT = 2000;
    protected int DEF = 100;
    protected int HP = 500;
    protected int MAXHP = 1000;

    public int GetAtt { get => ATT; }

    public bool IsDeath()
    {
        return HP <= 0;
    }
    //public void Damage(FightUnit _OtherUnit)
    //{
    //    Console.WriteLine(Name + "가" + _OtherUnit.ATT + "의 데미지를 입었습니다");
    //    Console.ReadKey();
    //    HP -= _OtherUnit.ATT;
    //}
    public void Damage(int ATTDMG)
    {
        Console.WriteLine(Name + "가" + ATTDMG + "의 데미지를 입었습니다");
        Console.ReadKey();
        HP -= ATTDMG;
    }
    public void StatusRender()
    {
        Console.WriteLine(Name + "------------------------");
        Console.WriteLine("AT : " + GetAtt + "      DEF : " + DEF);
        Console.WriteLine("HP : " + HP + "/" + MAXHP);
        Console.WriteLine("------------------------------");
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