using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TxtAdventure
{
    class Enemy
    {
        private int hp;
        private int mana;

        public void setHP(int health)
        {
            hp = health;
        }

        public int getHP()
        {
            return hp;
        }

    }
}
