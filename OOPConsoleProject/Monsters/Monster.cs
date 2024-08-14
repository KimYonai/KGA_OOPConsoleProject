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
        public string Name { get { return name; } }

        public int level;
        public int Level { get { return level; } }

        public int maxHP;
        public int MaxHP { get { return maxHP; } }

        public int curHP;
        public int CurHP { get { return curHP; } }

        public int attack;
        public int Attack { get { return attack; } }

        public int defense;
        public int Defense { get { return defense; } }

        public int gold;
        public int Gold { get { return gold; } }

        public int exp;
        public int Exp { get { return exp; } }

        public SceneType place;
        public SceneType Place { get { return place; } }

        public Game game;
        public Monster(Game game) { this.game = game; }

        public Player player;

        public Monster()
        {

        }

        public void TakeDamage(Player player)
        {
            if (attack < game.Player.Defense)
            {
                Console.WriteLine($"하지만 {name}의 공격이 너무 약해 {game.Player.Name}에게 피해를 주지 못했습니다.");
            }
            else
            {
                Console.WriteLine($"{name} 이/가 {player.attack - defense}의 데미지를 받았습니다.");
                curHP = curHP - (player.attack - defense);
            }
        }

        public void AttackPlayer(Player player)
        {
            Console.WriteLine($"{name} 이/가 {game.Player.Name}을 공격합니다.");
        }

        public void Die()
        {
            if (curHP == 0)
            {
                Die();
                Console.WriteLine($"{game.Monster.Name} 이/가 처치됐습니다.");
                GiveItem();
            }
        }

        public void GiveItem()
        {
            Console.WriteLine($"{game.Player.Name} 은/는 {game.Monster.Gold}G와 {game.Monster.Exp}를 획득했다.");
            player.gold += game.Monster.Gold;
            player.curEXP += game.Monster.Exp;
        }
    }
}
