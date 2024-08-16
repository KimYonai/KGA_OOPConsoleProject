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
            Console.WriteLine($"{name} 이/가 {monster.name}에게 스킬을 사용한다.");
            Thread.Sleep(2000);
            Console.WriteLine("스나이퍼 샷!");
            attack += 30;
        }

        public override void AfterSkill()
        {
            attack -= 30;
        }
    }
}
