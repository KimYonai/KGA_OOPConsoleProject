using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static OOPConsoleProject.Scenes.SelectScene;

namespace OOPConsoleProject.Items
{
    // 아이템 자식 클래스: 방어구 아이템
    public class Armors : Item
    {
        public Armors() : base("방어구", "방어구 설명", 0, 0)
        {
            name = "방어구";
            script = "방어구 설명";
            price = 0;
            stat = 0;
        }
    }

    // 방어구 아이템 팩토리 클래스
    public class ArmorFactory
    {
        public static Armors Instantiate(string name)
        {
            if (name == "철 갑옷")
            {
                Armors armor = new Armors();
                armor.name = "철 갑옷";
                armor.script = "전사들만이 무게를 버틸 수 있다는 철제 갑옷이다.";
                armor.price = 300;
                armor.stat = 20;
                return armor;
            }
            else if (name == "마법의 로브")
            {
                Armors armor = new Armors();
                armor.name = "마법의 로브";
                armor.script = "마법의 힘이 깃들어 있는 로브이다.";
                armor.price = 300;
                armor.stat = 10;
                return armor;
            }
            else if (name == "사냥꾼의 옷")
            {
                Armors armor = new Armors();
                armor.name = "사냥꾼의 옷";
                armor.script = "전설의 사냥꾼이 입던 옷과 같은 모델이다.";
                armor.price = 300;
                armor.stat = 10;
                return armor;
            }
            else if (name == "검정색 슈트")
            {
                Armors armor = new Armors();
                armor.name = "검정색 슈트";
                armor.script = "어떤 대머리가 생각날 정도로 잘 정돈된 슈트이다.";
                armor.price = 300;
                armor.stat = 10;
                return armor;
            }
            else if (name == "성스러운 로브")
            {
                Armors armor = new Armors();
                armor.name = "성스러운 로브";
                armor.script = "성스러운 축복을 받은 특제 로브이다.";
                armor.price = 300;
                armor.stat = 10;
                return armor;
            }
            else
            {
                return null;
            }
        }
    }
}
