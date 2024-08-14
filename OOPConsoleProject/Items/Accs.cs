using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Items
{
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
}
