using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    class Player
    {
        private string element;
        private string player1Name;
        private string elementDescription;
        private int p1H= 150;
        private int p1Mana = 100;

        public void setPlayerName(string name)
        {
            player1Name = name;
        }

        public string getPlayerName()
        {
            return player1Name;
        }

        public void setHP(int hp)
        {
            p1H = hp;
        }

        public int getHP()
        {
            return p1H;
        }

        public void setMana(int mana)
        {
            p1Mana = mana;
        }

        public int getMana()
        {
            return p1Mana;
        }

        public void setElementalMastery()
        {
            string tempans;
            bool finish = true;
            while (finish == true)
            {
                tempans = Console.ReadLine();
                switch (tempans)
                {
                    case "1":
                        element = "Fireball";
                        elementDescription = "Summons a ball of fire that deals damage to an enemy!";
                        finish = false;
                        break;
                    case "2":
                        element = "Water Elemental";
                        elementDescription = "Summons a Water elemental to aid you in battle!";
                        finish = false;
                        break;
                    case "3":
                        element = "Stone Fist";
                        elementDescription = "Coalesces rocks around your fists, allowing you to do double damage!";
                        finish = false;
                        break;
                    case "4":
                        element = "Fleet of Foot";
                        elementDescription = "Harnesses the wind around your body allowing you to evade attacks more efficiently!";
                        finish = false;
                        break;
                    default:
                        Console.WriteLine("You failed to choose a number correlating to an element please try again\n1)Fire\n2)Water\n3)Earth\n4)Air");
                        break;
                }
            }
        }
        
        public string getElementalMastery()
        {
            return element;
        }
        public string getElementalDesc()
        {
            return elementDescription;
        }
    }
}
