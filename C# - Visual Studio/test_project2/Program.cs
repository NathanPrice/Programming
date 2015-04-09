/*

 ************************************************************************
 * Author: Nathan Price                   Instructor: Mr. Damani        *
 * Created: 10/15/14                      Last Modified: 10/15/14       *
 * Copyleft: 2014                                                       *
 *                                                                      *
 * Description: This is a simple program that holds a name. The user    *
 * must enter the correct name for the program to work. Once the right  *
 * name is entered it will display that name 5 times.                   *
 ************************************************************************
 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_project2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            string name = "Nathan", isname = null; 
            int num = 0;

            Console.Write("Please enter the developer's name: ");
            isname = Console.ReadLine();

            if (isname == name)
            {
                while (num < 1)
                {
                    num++;
                    Console.WriteLine("Hello {0}!", name);
                    Console.WriteLine("     Hello {0}!", name);
                    Console.WriteLine("         Hello {0}!", name);
                    Console.WriteLine("             Hello {0}!", name);
                    Console.WriteLine("                 Hello {0}!", name);
                }

            }

            while (isname != name)
            {
                Console.WriteLine("ERROR! Not Correct Name.");
                Console.WriteLine("\n");
                Console.Write("Please enter the developer's name: ");
                isname = Console.ReadLine();

                if (isname == name)
                {
                    while (num < 1)
                    {
                        num++;
                        Console.WriteLine("Hello {0}!", name);
                        Console.WriteLine("     Hello {0}!", name);
                        Console.WriteLine("         Hello {0}!", name);
                        Console.WriteLine("             Hello {0}!", name);
                        Console.WriteLine("                 Hello {0}!", name);
                    }
                }

            }

            Console.ReadKey();
        }
    }
}