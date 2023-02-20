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
            return;
        }
        Console.WriteLine("현재 플레이어의 HP는" + HP + "입니다.");
        Console.ReadKey();
        Console.WriteLine("플레이어의 체력이 가득찼습니다.");
        Console.ReadKey();
    }
}