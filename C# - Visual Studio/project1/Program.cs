/*
 
 ***********************************************************************
 * Author: Nathan Price         Instructor: Mr. Damani                 *
 * Copyleft 2014                Created: 9/23/14                       *
 * Last Modified: 9/24/14                                              *
 *                                                                     *
 * Description: This is a little program that will prompt the user     *
 * to enter in a set of numbers. The amount of numbers entered is      *
 * up to the user. Then, the program loops comparing the numbers       *
 * and assigning the lowest number to the variable temp.               *
 * Finally, the program will tell you the lowest number of the         *
 * set of numbers the user entered.                                    *
 ***********************************************************************
 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Variables
            int counter = 1, choice = 0, num1 = 0, num2 = 0, temp = 0;

            Console.WriteLine("How many numbers do you want to compare?");
            choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter you numbers.");
            num1 = Convert.ToInt32(Console.ReadLine());
            temp = num1;

            // Loop that does the calculations
            while (counter < choice)
            {
                counter += 1;
                num2 = Convert.ToInt32(Console.ReadLine());

                if (temp < num2)
                {
                   temp = temp;
                }
                else
                {
                    temp = num2;
                }
                
            }

            Console.WriteLine("Your Lowest Number is {0}", temp);

            Console.ReadKey();


        }
    }
}