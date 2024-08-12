using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public void TakeDamage()
        {

        }

        public void Attack()
        {

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
