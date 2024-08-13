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
        protected string name;
        public string Name { get { return name; } }

        protected int maxHP;
        public int MaxHP { get { return maxHP; } }

        protected int curHP;
        public int CurHP { get { return curHP; } }

        protected int attack;
        public int Attack { get { return attack; } }

        protected int defense;
        public int Defense { get { return defense; } }

        protected Game game;
        public Monster(Game game) { this.game = game; }

        public void TakeDamage(Player player)
        {
            Console.WriteLine($"{game.Monster.Name} 이/가 {game.Player.Attack - game.Monster.Defense}의 데미지를 받았습니다.");
            curHP = curHP - (game.Player.Attack - game.Monster.Defense);
        }

        public void AttackPlayer(Player player)
        {
            Console.WriteLine($"{game.Monster.Name} 이/가 {game.Player.Name}을 공격합니다.");
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
