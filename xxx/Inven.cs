using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Inven
{
    int SelectIndex = 0;

    int ItemX;
    Item[] ArrItem;
    public Inven(int _X, int _Y)
    {
        if (1 > _X)
        {
            _X = 1;
        }
        if (1 > _Y)
        {
            _Y = 1;
        }
        ArrItem = new Item[(_X * _Y)];
        ItemX = _X;
    }
    public void ItemIn(Item _item)
    {
        int index = 0;
        for (int i = 0; i < ArrItem.Length; i++)
        {
            if (ArrItem[i] == null)
            {
                index = 1;
                break;
            }
        }
        ArrItem[index] = _item;
    }
    public bool OverCheck(int _SelectIndex)
    {
        return false;
    }
    public void Left()
    {
        int CheckIndex = SelectIndex;
        CheckIndex -= 1;
        if (OverCheck(CheckIndex))
        {
            return;
        }
        CheckIndex -= 1;
    }
    public void Right()
    {
        int CheckIndex = SelectIndex;
        CheckIndex += 1;
        if (OverCheck(CheckIndex))
        {
            return;
        }
        CheckIndex += 1;
    }
    public void Up()
    {
        int CheckIndex = SelectIndex;
        CheckIndex -= ItemX;
        if (OverCheck(CheckIndex))
        {
            return;
        }
        CheckIndex -= ItemX;
    }
    public void Down()
    {
        int CheckIndex = SelectIndex;
        CheckIndex += ItemX;
        if (OverCheck(CheckIndex))
        {
            return;
        }
        CheckIndex += ItemX;
    }
    public void Render()
    {

        for (int i = 0; i < ArrItem.Length; i++)
        {
            if (i != 0 && i % ItemX == 0)
            {
                Console.WriteLine("");
            }
            if (SelectIndex == i)
            {
                Console.Write("▣");
            }
            else if (ArrItem[i] == null)
            {
                Console.Write("□");
            }
            else
            {
                Console.Write("■");
            }
        }
        Console.WriteLine("");
        if (null != ArrItem[SelectIndex])
        {
            Console.WriteLine("현재 선택된 아이템");
        }
        Console.WriteLine("현재 선택된 아이템 비어있음");
    }
}

