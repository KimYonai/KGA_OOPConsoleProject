using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            stat = 0;
        }
    }

    public class WeaponFactory
    {
        public static Weapons Instantiate(string name)
        {
            if (name == "롱 소드")
            {
                Weapons weapon = new Weapons();
                weapon.name = "롱 소드";
                weapon.script = "많은 전사들이 애용하는 검이다.";
                weapon.type = ItemType.Weapon;
                weapon.price = 200;
                weapon.stat = 20;
                return weapon;
            }
            else if (name == "고목 스태프")
            {
                Weapons weapon = new Weapons();
                weapon.name = "고목 스태프";
                weapon.script = "오래된 나무로 만든 스태프이다.";
                weapon.type = ItemType.Weapon;
                weapon.price = 200;
                weapon.stat = 10;
                return weapon;
            }
            else if (name == "사냥꾼의 활")
            {
                Weapons weapon = new Weapons();
                weapon.name = "사냥꾼의 활";
                weapon.script = "전설의 사냥꾼이 사용하는 활과 같은 모델이다.";
                weapon.type = ItemType.Weapon;
                weapon.price = 200;
                weapon.stat = 10;
                return weapon;
            }
            else if (name == "복수의 단검")
            {
                Weapons weapon = new Weapons();
                weapon.name = "복수의 단검";
                weapon.script = "복수자의 피가 묻었던 단검이다.";
                weapon.type = ItemType.Weapon;
                weapon.price = 200;
                weapon.stat = 10;
                return weapon;
            }
            else if (name == "홀리 바이블")
            {
                Weapons weapon = new Weapons();
                weapon.name = "홀리 바이블";
                weapon.script = "성스러운 축복을 받은 성경이다.";
                weapon.type = ItemType.Weapon;
                weapon.price = 200;
                weapon.stat = 10;
                return weapon;
            }
            else
            {
                return null;
            }
        }
    }
}
