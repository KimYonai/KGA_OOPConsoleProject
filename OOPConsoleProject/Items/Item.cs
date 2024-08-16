using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPConsoleProject
{
    // 아이템 부모 클래스
    public class Item
    {
        public string name {  get; set; }
        public string script { get; set; }
        public int price { get; set; }
        public int stat {  get; set; }

        public Item(string name, string script, int price, int stat)
        {
            this.name = name;
            this.script = script;
            this.price = price;
            this.stat = stat;
        }
    }
}
