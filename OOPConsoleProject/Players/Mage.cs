using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    public class Mage : Player
    {
        public Mage(string name)
        {
            this.name = name;
            this.job = Job.Mage;
            this.level = 1;
            this.maxHP = 80;
            this.curHP = maxHP;
            this.attack = 50;
            this.defense = 10;
            this.gold = 200;
            this.maxEXP = 50;
            this.curEXP = 0;
        }

        public override void Skill(Monster monster)
        {

        }
    }
}
