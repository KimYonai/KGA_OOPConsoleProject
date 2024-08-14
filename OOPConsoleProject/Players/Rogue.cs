using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Players
{
    public class Rogue : Player
    {
        public Rogue(string name)
        {
            this.name = name;
            this.job = Job.Rogue;
            this.level = 1;
            this.maxHP = 100;
            this.curHP = maxHP;
            this.attack = 40;
            this.defense = 40;
            this.gold = 0;
            this.maxEXP = 50;
            this.curEXP = 0;
        }

        public override void Skill(Monster monster)
        {

        }
    }
}
