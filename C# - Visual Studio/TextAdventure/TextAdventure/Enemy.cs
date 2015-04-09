using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    class Enemy
    {
        private int aIH = 250;
        private int aIMana = 100;

        public void setHP(int hp)
        {
            aIH = hp;
        }

        public int getHP()
        {
            return aIH;
        }

        public void setMana(int mana)
        {
            aIMana = mana;
        }

        public int getMana()
        {
            return aIMana;
        }
    }
}
