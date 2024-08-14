using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPConsoleProject.Items
{
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
}
