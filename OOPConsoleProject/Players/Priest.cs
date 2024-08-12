using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    public class Priest : Player
    {
        public Priest(string name)
        {
            this.name = name;
            this.job = Job.Priest;
            this.maxHP = 80;
            this.curHP = maxHP;
            this.attack = 20;
            this.defense = 40;
            this.gold = 0;
        }

        public override void Skill(Monster monster)
        {

        }
    }
}
