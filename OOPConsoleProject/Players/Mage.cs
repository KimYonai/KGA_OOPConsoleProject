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
            this.maxMP = 200;
            this.curMP = maxMP;
            this.attack = 50;
            this.defense = 10;
            this.gold = 200;
            this.maxEXP = 50;
            this.curEXP = 0;
        }

        public override void Skill(Monster monster)
        {
            Console.WriteLine($"{name} 이/가 {monster.name}에게 스킬을 사용한다.");
            Thread.Sleep(2000);
            Console.WriteLine("썬더 브레이크!");
            attack += 40;
        }

        public override void AfterSkill()
        {
            attack -= 40;
        }
    }
}
