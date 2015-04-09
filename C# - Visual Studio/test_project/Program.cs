/*

 ************************************************************************
 * Author: Nathan Price                   Instructor: Mr. Damani        *
 * Created: 10/15/14                      Last Modified: 10/15/14       *
 * Copyleft: 2014                                                       *
 *                                                                      *
 * Description: This a program that will print print out the amount     *
 * of asterisks the user enters. They can only choose a number between  *
 * 1 - 255. If they choose a number outside of that range the program   *
 * will display an error and will prompt them again until they pick     *
 * a number within that range.                                          *
 ************************************************************************
 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            short num1 = 0, num2 = 0;

            Console.Write("Enter a number between 1 - 255: ");
            num1 = Convert.ToInt16(Console.ReadLine());

            while (num1 < 1 || num1 > 255)
            {
                Console.WriteLine("ERROR!");
                Console.Write("\n");
                Console.Write("Enter a number between 1 - 255: ");
                num1 = Convert.ToInt16(Console.ReadLine());
            }

            while (num2 < num1)
            {
                num2++;
                Console.Write("*");
            }

            Console.ReadKey();
        }
    }
}