﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    // 이벤트 보고 TkeDamage와 Die 추가해보기
    public abstract class Player
    {
        protected string name;
        public string Name { get { return name; } }

        public Job job;
        public Job Job { get { return job; } }

        public int curHP;
        public int CurHP { get { return curHP; } }

        public int maxHP;
        public int MaxHP { get { return maxHP; } }

        public int attack;
        public int Attack { get { return attack; } }

        protected int defense;
        public int Defense { get { return defense; } }

        protected int gold;
        public int Gold { get { return gold; } set { gold = value; } }

        public abstract void Skill(Monster monster);

        public void ShowInfo()
        {
            Console.SetCursorPosition(0, 20);
            Console.WriteLine("▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼");
            Console.WriteLine($" 이름: {name, -6}     직업: {job, -6}");
            Console.WriteLine($" 체력: {curHP, +3} / {maxHP}     공격력: {attack, -3} / 방어력: {defense,-3}");
            Console.WriteLine($" 골드: {gold,+5} G");
            Console.WriteLine("▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲");
            Console.WriteLine();
            Console.SetCursorPosition(0, 0);
        }

        public void TakeDamage(Monster monster)
        {
            Console.WriteLine($"{name} 이/가 {monster.attack - defense}의 데미지를 받았습니다.");
            curHP = curHP - (monster.attack - defense);

            if (curHP <= 0)
            {
                Die();
            }
        }

        public void Die()
        {
            Console.WriteLine($"{name}의 체력이 0이 되었습니다.");
            Thread.Sleep(2000);
            Console.WriteLine($"{name} 은/는 쓰러졌습니다.");
            Thread.Sleep(2000);
            Console.WriteLine("눈을 뜨니 숙소의 침대 위에 있다.");
        }
    }
}
