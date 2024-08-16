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
            this.level = 1;
            this.maxHP = 80;
            this.curHP = maxHP;
            this.maxMP = 150;
            this.curMP = maxMP;
            this.attack = 20;
            this.defense = 40;
            this.gold = 0;
            this.maxEXP = 50;
            this.curEXP = 0;
        }

        public override void Skill(Monster monster)
        {
            Console.WriteLine($"{name} 이/가 {monster.name}에게 스킬을 사용한다.");
            Thread.Sleep(2000);
            Console.WriteLine("홀리 매직!");
            attack += 40;
        }

        public override void AfterSkill()
        {
            attack -= 40;
        }
    }
}
