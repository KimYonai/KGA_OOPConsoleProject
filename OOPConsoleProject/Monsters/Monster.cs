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

        public Game game;
        public Monster(Game game) { this.game = game; }

        public Monster()
        {

        }

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

    public class MonsterBuilder
    {
        public string name;
        public int level;
        public int maxHP;
        public int curHP;
        public int attack;
        public int defense;
        public int gold;

        public MonsterBuilder()
        {
            name = "몬스터";
            level = 0;
            maxHP = 0;
            curHP = 0;
            attack = 0;
            defense = 0;
            gold = 0;
        }

        public Monster Build()
        {
            Monster monster = new Monster();
            monster.name = name;
            monster.level = level;
            monster.maxHP = maxHP;
            monster.curHP = curHP;
            monster.attack = attack;
            monster.defense = defense;
            monster.gold = gold;
            return monster;
        }

        public MonsterBuilder SetName(string name)
        {
            this.name = name;
            return this;
        }

        public MonsterBuilder SetLevel(int level)
        {
            this.level = level;
            return this;
        }

        public MonsterBuilder SetMaxHP(int maxHP)
        {
            this.maxHP = maxHP;
            return this;
        }

        public MonsterBuilder SetCurHP(int curHP)
        {
            this.curHP = curHP;
            return this;
        }

        public MonsterBuilder SetAttack(int attack)
        {
            this.attack = attack;
            return this;
        }

        public MonsterBuilder SetDefense(int defense)
        {
            this.defense = defense;
            return this;
        }

        public MonsterBuilder SetGold(int gold)
        {
            this.gold = gold;
            return this;
        }
    }
}
