using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    public class Warrior : Player
    {
        public Warrior(string name)
        {
            this.name = name;
            this.job = Job.Warrior;
            this.level = 1;
            this.maxHP = 150;
            this.curHP = maxHP;
            this.maxMP = 50;
            this.curMP = maxMP;
            this.attack = 30;
            this.defense = 50;
            this.gold = 0;
            this.maxEXP = 50;
            this.curEXP = 0;
        }

        public override void Skill(Monster monster)
        {
            
        }
    }
}
