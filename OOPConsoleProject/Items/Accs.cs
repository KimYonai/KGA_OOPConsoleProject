using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OOPConsoleProject.Scenes.SelectScene;

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
            stat = 0;
        }
    }

    public class AccFactory
    {
        public static Accs Instantiate(string name)
        {
            if (name == "축복받은 로자리오")
            {
                Accs acc = new Accs();
                acc.name = "축복받은 로자리오";
                acc.script = "요즘 전사들의 잇 아이템! 축복받은 로자리오!";
                acc.type = ItemType.Acc;
                acc.price = 150;
                acc.stat = 10;
                return acc;
            }
            else if (name == "마법 속성 수정")
            {
                Accs acc = new Accs();
                acc.name = "마법 속성 수정";
                acc.script = "마법의 속성을 강화시켜주는 수정이다.";
                acc.type = ItemType.Acc;
                acc.price = 150;
                acc.stat = 10;
                return acc;
            }
            else if (name == "사냥꾼의 깃털")
            {
                Accs acc = new Accs();
                acc.name = "사냥꾼의 깃털";
                acc.script = "전설의 사냥꾼이 지니고 다니던 깃털과 똑같은(?) 깃털이다.";
                acc.type = ItemType.Acc;
                acc.price = 150;
                acc.stat = 10;
                return acc;
            }
            else if (name == "은색 한쪽 귀고리")
            {
                Accs acc = new Accs();
                acc.name = "은색 한쪽 귀고리";
                acc.script = "빛 바랜 은으로 만들어진 한쪽 귀고리이다.";
                acc.type = ItemType.Acc;
                acc.price = 150;
                acc.stat = 10;
                return acc;
            }
            else if (name == "빛나는 십자가")
            {
                Accs acc = new Accs();
                acc.name = "빛나는 십자가";
                acc.script = "성스러운 빛을 내는 십자가이다.";
                acc.type = ItemType.Acc;
                acc.price = 150;
                acc.stat = 10;
                return acc;
            }
            else
            {
                return null;
            }
        }
    }
}
