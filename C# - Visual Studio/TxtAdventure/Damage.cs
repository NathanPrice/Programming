using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TxtAdventure
{
    class Damage
    {
        public void isHit()
        {
            Random r = new Random();
            int hit = r.Next(1,20);
                
            if(hit <= 14)
            {
                Console.WriteLine(hit);
            }
            else
            {
                Console.WriteLine("MISS!");
            }
            
        }

        public void attack()
        {

        }

    }
}
