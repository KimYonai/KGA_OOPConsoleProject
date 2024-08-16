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
        public string name {  get; set; }
        public string script { get; set; }
        public ItemType type { get; set; }
        public int price { get; set; }
        public int stat {  get; set; }

        public Item(string name, string script, ItemType type, int price, int stat)
        {
            this.name = name;
            this.script = script;
            this.type = type;
            this.price = price;
            this.stat = stat;
        }
    }
}
