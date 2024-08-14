using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Items
{
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
}
