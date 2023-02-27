using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    internal class ItemDB
{
    public List<Item> itemType;

    public ItemDB()
    {
        List<Item> items = new List<Item>();

        items.Add(new Item(1, "숏소드", "작지만 강한 칼이다. 상점에서 저렴하게 구매 가능하다."
                            , ItemType.WEAPON, 100, 0, 0));
        items.Add(new Item(2, "반팔티", "작지만 강한 칼이다. 상점에서 저렴하게 구매 가능하다."
                            , ItemType.CHEST, 100, 0, 0));

    }
}

