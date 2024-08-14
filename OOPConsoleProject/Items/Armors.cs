using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPConsoleProject.Items
{
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
}
