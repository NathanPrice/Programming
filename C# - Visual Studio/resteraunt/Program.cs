/*

 ************************************************************************
 * Author: Nathan Price                   Instructor: Mr. Damani        *
 * Created: 11/11/14                      Last Modified: 11/12/14       *
 * Copyleft: 2014                                                       *
 *                                                                      *
 * Description: This is just a simple resteraunt program to demonstrate *
 * my knowledge on functions and arrays. The user can choose how many   *
 * orders they want so if they have a group they can all order          *
 * something. They can choose from 3 sets of 4 items each. Once they    *
 * choose their items the program will clear the screen and print their *
 * receipt with the subtotal, tax, and total.                           *
 ************************************************************************
 
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resteraunt
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int num = 0;
            double subtotal = 0;
            double tax = 0;

            Console.Write("How many orders do you have: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < num; i++)
            {
                displayItems();
                subtotal += menuChoice();
            }

            // Displays Receipt
            string logo = @"    ____           ____            __                              __ 
   / __ \____ _   / __ \___  _____/ /____  _________ ___  ______  / /_
  / / / / __ `/  / /_/ / _ \/ ___/ __/ _ \/ ___/ __ `/ / / / __ \/ __/
 / /_/ / /_/ /  / _, _/  __(__  ) /_/  __/ /  / /_/ / /_/ / / / / /_  
/_____/\__,_/  /_/ |_|\___/____/\__/\___/_/   \__,_/\__,_/_/ /_/\__/  
                                                                       ";
            DateTime t = DateTime.Now;
            Console.WriteLine(logo);
            Console.WriteLine(t);
            Console.WriteLine("----------------------");
            Console.WriteLine("Your subtotal is: {0:C}", subtotal);
            tax = calcTax(subtotal);
            calcTotal(subtotal, tax);

            Console.ReadKey();
        }


        static double calcTotal(double a, double b)
        {
            double total = 0;
            total = a + b;

            Console.WriteLine("Your total is: {0:C}", total);
            return total;
        }

        static double calcTax(double a)
        {
            double taxPercent = 0.0885;
            double tax = 0;

            tax = taxPercent * a;
            Console.WriteLine("The tax cost is: {0:C}", tax);
            return tax;
        }

        static double menuChoice()
        {
            double appChoice, entChoice, driChoice;
            double appPrice = 0, entPrice = 0, driPrice = 0;
            double subtotal = 0;


            Console.Write("Appetizer: ");
            appChoice = Convert.ToDouble(Console.ReadLine());
            if (appChoice == 1)
            {
                appPrice = 6.99;
            }
            else if (appChoice == 2)
            {
                appPrice = 8.99;
            }
            else if (appChoice == 3)
            {
                appPrice = 6.49;
            }
            else if (appChoice == 4)
            {
                appPrice = 9.99;
            }

            Console.Write("Entree: ");
            entChoice = Convert.ToDouble(Console.ReadLine());
            if (entChoice == 1)
            {
                entPrice = 22.99;
            }
            else if (entChoice == 2)
            {
                entPrice = 7.99;
            }
            else if (entChoice == 3)
            {
                entPrice = 6.49;
            }
            else if (entChoice == 4)
            {
                entPrice = 9.99;
            }

            Console.Write("Drink: ");
            driChoice = Convert.ToDouble(Console.ReadLine());
            if (driChoice == 1)
            {
                driPrice = 3.99;
            }
            else if (driChoice == 2)
            {
                driPrice = 3.99;
            }
            else if (driChoice == 3)
            {
                driPrice = 0.00;
            }
            else if (driChoice == 4)
            {
                driPrice = 2.49;
            }
            Console.Clear();

            // Gets total w/o tax
            subtotal = appPrice + entPrice + driPrice;

            return subtotal;
        }

        static void displayItems()
        {
            string[] appetizers = {"(1) Caesar Salad - $6.99", "(2) Chips and Salsa - $8.99", "(3) Mozarella Sticks - $6.49", "(4) Fried Mushrooms - $9.99"};
            string[] entrees = {"(1) Steak - $22.99", "(2) Cheeseburger - $7.99" , "(3) Club Sandwhich - $11.99", "(4) Philly - $9.99"};
            string[] drinks = {"(1) Dr Pepper - $3.99", "(2) Coke - $3.99", "(3) Water - FREE", "(4) Coffee - $2.49"};

            // Displays Appetizers
            Console.WriteLine("APPETIZERS");
            Console.WriteLine("--------");
            for (int i = 0; i < appetizers.Length; i++)
            {
                Console.WriteLine(appetizers[i]);
            }

            // Displays Entrees
            Console.WriteLine();
            Console.WriteLine("ENTREES");
            Console.WriteLine("--------");
            for (int i = 0; i < entrees.Length; i++)
            {
                Console.WriteLine(entrees[i]);
            }
            // Displays Drinks
            Console.WriteLine();
            Console.WriteLine("DRINKS");
            Console.WriteLine("--------");

            for (int i = 0; i < drinks.Length; i++)
            {
                Console.WriteLine(drinks[i]);
            }

            Console.WriteLine();
        }


    }
}