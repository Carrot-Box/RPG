﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Player : FightUnit
{
    private Inven PlayerInven = new Inven(5, 3);
    public Inven Plven
    {
        get 
        { 
            return PlayerInven; 
        }
    }

    
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
        if (HP < GetMaxHp)
        {
            PrintHp();
            HP = GetMaxHp;
            DEF = GetMaxDef;
            return;
        }
        Console.WriteLine("현재 플레이어의 HP는" + HP + "입니다.");
        Console.WriteLine("플레이어의 체력이 가득찼습니다.");
        Console.ReadKey();
    }
    public void LvUp()
    {
        ATT = (int)(ATT * 140 / 100);
        ORIMAXDEF = (int)(ORIMAXDEF * 140 / 100);
        ORIMAXHP = (int)(ORIMAXHP * 140 / 100);
        MaxHeal();
        Console.Clear();
        StatusRender();
        Console.WriteLine("플레이어가 레벨업 하였습니다.\n");
    }
}