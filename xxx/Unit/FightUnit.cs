using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FightUnit
{
    // 능력치
    protected string Name = "None";
    protected int ATT = 200;        // 현재 공격력(장비X)
    protected int DEF = 100;        // 현재 방어력
    protected int ORIMAXDEF = 100;  // 최대 방어력(장비X)
    protected int MAXDEF = 100;     // 최대 방어력(장비O)
    protected int HP = 1000;        // 현재 체력
    protected int ORIMAXHP = 1000;  // 최대 체력(장비X)
    protected int MAXHP = 1000;     // 최대 체력(장비O)

    // 장비
    //protected Item WEAPON = new Item(ItemType.WEAPON);
    //protected Item CHEAT = new Item(ItemType.CHEST);
    //protected Item RING = new Item(ItemType.RING);

    public int GetAtt {
        get
        {
            return ATT;// + WEAPON.ATT + CHEAT.ATT + RING.ATT;
        }
    }

    public int GetMaxHp
    {
        get
        {
            return ORIMAXHP; // + WEAPON.HP + CHEAT.HP + RING.HP;
        }
    }

    public int GetMaxDef
    {
        get
        {
            return ORIMAXDEF;// + WEAPON.DEF + CHEAT.DEF + RING.DEF;
        }
    }

    public bool IsDeath()
    {
        return HP <= 0;
    }
    public void Damage(int ATTDMG)
    {
        Console.WriteLine(Name + "가" + ATTDMG + "의 데미지를 입었습니다");
        Console.ReadKey();

        int remainATT = 0;

        /* 공격력 : ATTDMG
        *  쉴드   : DEF
        *  체력   : HP
        *  
        *  만약, 쉴드보다 공격력이 높다면
        *  쉴드 = 0
        *  남은공격력 = 공격력 - 쉴드
        *  체력 = 체력 - 남은공격력
        */

        if (DEF < ATTDMG)
        {
            remainATT = ATTDMG - DEF;
            HP = HP - remainATT;
            DEF = 0;
        }

        else
        {
            DEF = DEF - ATTDMG;
        }
    }
    public void StatusRender()
    {
        Console.WriteLine(Name + "------------------------");
        Console.WriteLine("AT : " + GetAtt + "      DEF : " + DEF);
        Console.WriteLine("HP : " + HP + "/" + ORIMAXHP);
        Console.WriteLine("------------------------------");
    }
}