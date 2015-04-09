/*

 ************************************************************************
 * Author: Nathan Price                   Instructor: Mr. Damani        *
 * Created: 10/18/14                      Last Modified: 10/27/14       *
 * Copyleft: 2014                                                       *
 *                                                                      *
 * Description: This a simple number guessing game. Each time you start *
 * the program a random number is picked and it's the user's job to     *
 * figure out that number. If the number is lower or higher than the    *
 * assigned number it will notify the user making it easier to figure   *
 * out the correct number. Once the user has figured out the correct    *
 * number the program will notify them with a simple message and they   *
 * can restart the program to do it again if they wish to.              *
 ************************************************************************
 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int num = 0, choice = 0, count = 0;
            Random r = new Random();

            num = (r.Next(1, 100));


            Console.WriteLine("Try to guess the number (1-100)");
            choice = Convert.ToInt32(Console.ReadLine());
            count++;
            
            while (choice != num)
            {
                if (choice < num)
                {
                    count++;
                    Console.WriteLine("HIGHER");
                    Console.WriteLine("Try to guess the number (1-100)");
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                else if (choice > num)
                {
                    count++;
                    Console.WriteLine("LOWER");
                    Console.WriteLine("Try to guess the number (1-100)");
                    choice = Convert.ToInt32(Console.ReadLine());
                }
            }

            if (choice == num)
            {
                Console.WriteLine("\n");
                Console.WriteLine("YOU WIN!");
                Console.WriteLine("You guessed the number in '{0}' tries.", count);
            }

            switch (count)
            {
                case 1:
                    Console.WriteLine("You are a GOD!");
                    break;
                case 2:
                    Console.WriteLine("You are a DEMI-GOD!");
                    break;
                case 3:
                    Console.WriteLine("You are AWESOME!");
                    break;
                case 4:
                    Console.WriteLine("You are GOOD!");
                    break;
                case 5:
                    Console.WriteLine("You are AVERAGE!");
                    break;
                default:
                    Console.WriteLine("You are BAD!");
                    break;

            }
                Console.ReadKey();
        }
    }
}