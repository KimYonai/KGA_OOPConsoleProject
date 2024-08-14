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
}
