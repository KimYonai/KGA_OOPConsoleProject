using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    public class Archor : Player
    {
        public Archor(string name)
        {
            this.name = name;
            this.job = Job.Archor;
            this.level = 1;
            this.maxHP = 100;
            this.curHP = maxHP;
            this.maxMP = 100;
            this.curMP = maxMP;
            this.attack = 50;
            this.defense = 20;
            this.gold = 100;
            this.maxEXP = 50;
            this.curEXP = 0;
        }

        public override void Skill(Monster monster)
        {

        }
    }
}
