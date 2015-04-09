using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TxtAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Damage dmg = new Damage();
            Enemy mob = new Enemy();
            mob.setHP(0);

            string choice = null;

            while (mob.getHP() != 0)
            {
                int enemy_hp = mob.getHP();
                Console.WriteLine("You run into an Enemy!");
                Console.Write("> ");
                choice = Console.ReadLine();

                
            }
            
            Console.WriteLine("Lol");
            

            Console.ReadKey();
        }
    }
}
