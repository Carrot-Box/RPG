using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Item
{
    public int id; // 아이템 고유 ID
    public string name;
    public string description;
    public int ATT;
    public int DEF;
    public int HP;

    public Item(int id, string name, string description, int aTT, int dEF, int hP)
    {
        this.id = id;
        this.name = name;
        this.description = description;
        ATT = aTT;
        DEF = dEF;
        HP = hP;
    }
}

