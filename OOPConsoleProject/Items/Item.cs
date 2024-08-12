using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPConsoleProject
{
    public class Item
    {
        public string name;
        public string script;
        public ItemType type;
        public int price;
        public int count;

        public Item(string name, string script, ItemType type, int price, int count)
        {
            this.name = name;
            this.script = script;
            this.type = type;
            this.price = price;
            this.count = count;
        }
    }

    public class Weapons : Item
    {
        public Weapons() : base("무기", "무기 설명", ItemType.Weapon, 0, 0)
        {
            name = "무기";
            script = "무기 설명";
            type = ItemType.Weapon;
            price = 0;
            count = 0;
        }
    }

    public class Armors : Item
    {
        public Armors() : base("방어구", "방어구 설명", ItemType.Armor, 0, 0)
        {
            name = "방어구";
            script = "방어구 설명";
            type = ItemType.Armor;
            price = 0;
            count = 0;
        }
    }

    public class Accs : Item
    {
        public Accs() : base("장신구", "장신구 설명", ItemType.Acc, 0, 0)
        {
            name = "장신구";
            script = "장신구 설명";
            type = ItemType.Acc;
            price = 0;
            count = 0;
        }
    }

    public class Consumes : Item
    {
        public Consumes() : base("소비 아이템", "소비 아이템 설명", ItemType.Consume, 0, 0)
        {
            name = "소비 아이템";
            script = "소비 아이템 설명";
            type = ItemType.Consume;
            price = 0;
            count = 0;
        }
    }

    public class ItemFactory
    {
        public static Item Instantiate(ItemType type)
        {
            if (type == ItemType.Weapon)
            {
                Weapons weapon = new Weapons();
                weapon.name = "무기";
                weapon.script = "무기 설명";
                weapon.type = ItemType.Weapon;
                weapon.price = 0;
                weapon.count = 0;
                return weapon;
            }
            else if (type == ItemType.Armor)
            {
                Armors armor = new Armors();
                armor.name = "방어구";
                armor.script = "방어구 설명";
                armor.type = ItemType.Armor;
                armor.price = 0;
                armor.count = 0;
                return armor;
            }
            else if (type == ItemType.Acc)
            {
                Accs acc = new Accs();
                acc.name = "장신구";
                acc.script = "장신구 설명";
                acc.type = ItemType.Acc;
                acc.price = 0;
                acc.count = 0;
                return acc;
            }
            else if (type == ItemType.Consume)
            {
                Consumes consume = new Consumes();
                consume.name = "소비 아이템";
                consume.script = "소비 아이템 설명";
                consume.type = ItemType.Consume;
                consume.price = 0;
                consume.count = 0;
                return consume;
            }
            else
            {
                return null;
            }
        }
    }
}
