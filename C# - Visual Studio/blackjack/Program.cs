/*

 ************************************************************************
 * Author: Nathan Price                   Instructor: Mr. Damani        *
 * Created: 10/27/14                      Last Modified: 10/31/14       *
 * Copyleft: 2014                                                       *
 *                                                                      *
 * Description: 
 ************************************************************************
 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.rng();

            // Variables
            string[] suite = {"Clubs", "Spades", "Hearts", "Diamonds"};
            int deck = 0;

            // Player
            if (deck >= 1 && deck <= 13)
            {
                Console.WriteLine(suite[0]);
            }
            else if (deck >= 14 && deck <= 26)
            {
                Console.WriteLine(suite[1]);
            }

            Console.ReadKey();
        }

        // Random Generator
        public void rng()
        {
            Random r = new Random();
            int deck = r.Next(1, 53);
            Console.WriteLine(deck);
        }
       
    }
}