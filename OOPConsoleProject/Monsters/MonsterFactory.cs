using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Monsters
{
    public class MonsterFactory
    {
        public static Monster Instantiate(string name)
        {
            if (name == "슬라임")
            {
                Monster monster = new Monster();
                monster.name = "슬라임";
                monster.level = 1;
                monster.maxHP = 50;
                monster.curHP = 50;
                monster.attack = 10;
                monster.defense = 10;
                monster.gold = 50;
                monster.exp = 10;
                return monster;
            }
            else if (name == "스텀프")
            {
                Monster monster = new Monster();
                monster.name = "스텀프";
                monster.level = 3;
                monster.maxHP = 100;
                monster.curHP = 100;
                monster.attack = 20;
                monster.defense = 10;
                monster.gold = 70;
                monster.exp = 20;
                return monster;
            }
            else if (name == "진흙 골렘")
            {
                Monster monster = new Monster();
                monster.name = "진흙 골렘";
                monster.level = 10;
                monster.maxHP = 300;
                monster.curHP = 300;
                monster.attack = 80;
                monster.defense = 100;
                monster.gold = 300;
                monster.exp = 100;
                return monster;
            }
            else
            {
                return null;
            }
        }
    }
}
