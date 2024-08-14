using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            stat = 0;
        }
    }

    public class ConsumeFactory
    {
        public static Consumes Instantiate(string name)
        {
            if (name == "빨간 포션")
            {
                Consumes consume = new Consumes();
                consume.name = "빨간 포션";
                consume.script = "마시면 체력이 회복될 것 같은 포션이다.";
                consume.type = ItemType.Consume;
                consume.price = 50;
                consume.stat = 20;
                return consume;
            }
            else if (name == "파란 포션")
            {
                Consumes consume = new Consumes();
                consume.name = "파란 포션";
                consume.script = "마시면 마나 회복될 것 같은 포션이다.";
                consume.type = ItemType.Consume;
                consume.price = 50;
                consume.stat = 10;
                return consume;
            }
            else if (name == "닭다리")
            {
                Consumes consume = new Consumes();
                consume.name = "닭다리";
                consume.script = "닭다리는 중요한 단백질 공급원이다. 먹으면 힘이 난다.";
                consume.type = ItemType.Consume;
                consume.price = 50;
                consume.stat = 10;
                return consume;
            }
            else if (name == "성수")
            {
                Consumes consume = new Consumes();
                consume.name = "성수";
                consume.script = "성스러운 힘을 우리에게 전해주는 성수이다.";
                consume.type = ItemType.Consume;
                consume.price = 100;
                consume.stat = 10;
                return consume;
            }
            else
            {
                return null;
            }
        }
    }
}
