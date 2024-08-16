using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Players
{
    // 플레이어 자식 클래스: 도적 직업
    public class Rogue : Player
    {
        public Rogue(string name)
        {
            this.name = name;
            this.job = Job.Rogue;
            this.level = 1;
            this.maxHP = 100;
            this.maxMP = 100;
            this.curMP = maxMP;
            this.curHP = maxHP;
            this.attack = 40;
            this.defense = 40;
            this.gold = 0;
            this.maxEXP = 50;
            this.curEXP = 0;
        }

        public override void Skill(Monster monster)
        {
            Console.WriteLine($"{name} 이/가 {monster.name}에게 스킬을 사용한다.");
            Thread.Sleep(2000);
            Console.WriteLine("벽력일섬!");
            attack += 30;
        }

        public override void AfterSkill()
        {
            attack -= 30;
        }
    }
}
