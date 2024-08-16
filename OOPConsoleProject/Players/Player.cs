using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    // 플레이어를 다루는 부모 클래스
    public abstract class Player
    {
        // 인자값을 해당 클래스 및 자식 클래스 밖에서 사용해야 할 경우에 맞춰 프로퍼티 및 접근제한자 사용
        protected string name;
        public string Name { get { return name; } }

        protected Job job;
        public Job Job { get { return job; } }

        protected int level;
        public int Level { get { return level; } }

        public int curHP;
        public int CurHP { get { return curHP; } }

        protected int maxHP;
        public int MaxHP { get { return maxHP; } set { maxHP = value; } }

        public int curMP;
        public int CurMP { get { return curMP; } }

        protected int maxMP;
        public int MaxMP { get { return maxMP; }   }

        public int attack;
        public int Attack { get { return attack; } set { attack = value; } }

        public int defense;
        public int Defense { get { return defense; } }

        public int gold;
        public int Gold { get { return gold; } set { gold = value; } }

        protected int maxEXP;
        public int MaxEXP { get { return maxEXP; } }

        public int curEXP;
        public int CurEXP { get { return curEXP; } set { curEXP = value; } }

        // 전투 시 플레이어가 사용하는 스킬 -> 스킬을 맞는 대상이 몬스터이므로 몬스터를 생성자로 대입
        public abstract void Skill(Monster monster);

        // 플레이어의 현재 정보 출력
        public void ShowInfo()
        {
            Console.SetCursorPosition(0, 20);
            Console.WriteLine("▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼");
            Console.WriteLine($" 이름: {name, -6}     직업: {job, -6}");
            Console.WriteLine($" 체력: {curHP, +3} / {maxHP}     공격력: {attack, -3} / 방어력: {defense,-3}");
            Console.WriteLine($" 마나: {curMP, +3} / {maxMP}");
            Console.WriteLine($" 골드: {gold, +3} G");
            Console.WriteLine($" EXP: {curEXP, +3} / {maxEXP}");
            Console.WriteLine("▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲");
            Console.WriteLine();
            Console.SetCursorPosition(0, 0);
        }

        // 플레이어 피격 함수
        public void TakeDamage(Monster monster)
        {
            if (monster.attack < defense)
            {
                Console.WriteLine($"하지만 {monster.name}의 공격이 너무 약해 {name}에게 피해를 주지 못했습니다.");
            }
            else 
            {
                Console.WriteLine($"{name} 이/가 {monster.attack - defense}의 데미지를 받았습니다.");
                curHP = curHP - (monster.attack - defense);
            } 
        }

        // 플레이어 공격 함수
        public void AttackMonster(Monster monster)
        {
            Console.WriteLine($"{name} 이/가 {monster.name}을 공격한다.");
        }

        // 플레이어 사망 함수
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

        // 플레이어 레벨업 함수
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

        // 플레이어 스킬 사용 이후 처리 함수
        public abstract void AfterSkill();
    }
}
