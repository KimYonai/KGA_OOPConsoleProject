using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    public abstract class Player
    {
        protected string name;
        public string Name { get { return name; } }

        protected Job job;
        public Job Job { get { return job; } }

        protected int level;
        public int Level { get { return level; } }

        public int curHP;
        public int CurHP { get { return curHP; } }

        protected int maxHP;
        public int MaxHP { get { return maxHP; } }

        public int curMP;
        public int CurMP { get { return curMP; } }

        protected int maxMP;
        public int MaxMP { get { return maxMP; } }

        public int attack;
        public int Attack { get { return attack; } set { gold = value; } }

        protected int defense;
        public int Defense { get { return defense; } }

        public int gold;
        public int Gold { get { return gold; } set { gold = value; } }

        protected int maxEXP;
        public int MaxEXP { get { return maxEXP; } }

        public int curEXP;
        public int CurEXP { get { return curEXP; } set { curEXP = value; } }

        public abstract void Skill(Monster monster);

        public void ShowInfo()
        {
            Console.SetCursorPosition(0, 20);
            Console.WriteLine("▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼");
            Console.WriteLine($" 이름: {name, -6}     직업: {job, -6}");
            Console.WriteLine($" 체력: {curHP, +3} / {maxHP}     공격력: {attack, -3} / 방어력: {defense,-3}");
            Console.WriteLine($" 마나: {curMP, +3} / {maxMP}");
            Console.WriteLine($" 골드: {gold, +5} G");
            Console.WriteLine($" EXP: {curEXP, +5} / {maxEXP}");
            Console.WriteLine("▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲");
            Console.WriteLine();
            Console.SetCursorPosition(0, 0);
        }

        public void TakeDamage(Monster monster)
        {
            if (attack < monster.defense)
            {
                Console.WriteLine($"하지만 {name}의 공격이 너무 약해 {monster.name}에게 피해를 주지 못했습니다.");
            }
            else 
            {
                Console.WriteLine($"{name} 이/가 {monster.attack - defense}의 데미지를 받았습니다.");
                curHP = curHP - (monster.attack - defense);
            } 
        }

        public void AttackMonster(Monster monster)
        {
            Console.WriteLine($"{name} 이/가 {monster.name}을 공격한다.");
        }

        public void Die()
        {
            Console.WriteLine($"{name}의 체력이 0이 되었습니다.");
            Thread.Sleep(2000);
            Console.WriteLine($"{name} 은/는 쓰러졌습니다.");
            Thread.Sleep(2000);
            Console.WriteLine("눈을 뜨니 숙소의 침대 위에 있다.");
            curHP = 30;
            Thread.Sleep(2000);
        }

        public void LevelUp()
        {
            if (curEXP >= maxEXP)
            {
                Console.WriteLine("============Level Up!============");

                level += 1;
                curEXP = curEXP - maxEXP;
                maxEXP += 20;
                attack += 5;
                defense += 5;
            }
        }
    }
}
