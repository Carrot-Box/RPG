using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FightUnit
{
    protected string Name = "None";
    protected int ATT = 3000;
    protected int DEF = 100;
    protected int MAXDEF = 100;
    protected int HP = 500;
    protected int MAXHP = 1000;

    public int GetAtt { get => ATT; }

    public bool IsDeath()
    {
        return HP <= 0;
    }
    public void Damage(int ATTDMG)
    {
        Console.WriteLine(Name + "가" + ATTDMG + "의 데미지를 입었습니다");
        Console.ReadKey();
        if (DEF >= 0)
        {
            DEF -= ATTDMG;
        }
        HP -= ATTDMG;
    }
    public void StatusRender()
    {
        Console.WriteLine(Name + "------------------------");
        Console.WriteLine("AT : " + GetAtt + "      DEF : " + DEF);
        Console.WriteLine("HP : " + HP + "/" + MAXHP);
        Console.WriteLine("------------------------------");
    }
}