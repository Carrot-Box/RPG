//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Cryptography;
//using System.Text;
//using System.Threading.Tasks;

//public enum ItemType
//{
//    WEAPON,
//    CHEST,
//    RING
//}

//public class Item
//{
//    public int id; // 아이템 고유 ID
//    public string name;
//    public string description;
//    public ItemType itemType;
//    public int ATT;
//    public int DEF;
//    public int HP;

//    public Item(ItemType type)
//    {
//        this.id = 0;
//        this.name = "착용 장비 없음";
//        this.description = null;
//        this.itemType = type;
//        ATT = 0;
//        DEF = 0;
//        HP = 0;
//    }

//    public Item(int id, string name, string description, ItemType iTEMTYPE, int aTT, int dEF, int hP)
//    {
//        this.id = id;
//        this.name = name;
//        this.description = description;
//        this.itemType = iTEMTYPE;
//        ATT = aTT;
//        DEF = dEF;
//        HP = hP;
//    }
//}