using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    public class Monster
    {
        public string name;
        public int maxHP;
        public int curHP;
        public int attack;
        public int defense;


        public void TakeDamage(Player player)
        {
            Console.WriteLine($"{name} 이/가 {player.attack - defense}의 데미지를 받았습니다.");
            curHP = curHP - (player.attack - defense);
        }

        public void Attack(Player player)
        {
            Console.WriteLine($"{name} 이/가 {player.name}을 공격한다.");
        }

        public void Die()
        {
            if (curHP == 0)
            {
                Die();
                Console.WriteLine("");
            }
        }
    }
}
