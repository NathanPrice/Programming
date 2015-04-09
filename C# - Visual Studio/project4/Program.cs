/*

 ************************************************************************
 * Author: Nathan Price                   Instructor: Mr. Damani        *
 * Created: 10/13/14                      Last Modified: 10/14/14       *
 * Copyleft: 2014                                                       *
 *                                                                      *
 * Description: This is a program that works like a simple bar graph.   *
 * The user must enter 5 numbers between 1 - 30 otherwise it will just  *
 * print error. If any number is less than 30 it will print that number *
 * along with the same amount of asterisks using for loops.             *
 ************************************************************************
 
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project4
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0, num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0;

            Console.WriteLine("Enter a number between 1-30: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());
            num4 = Convert.ToInt32(Console.ReadLine());
            num5 = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("\n");
            Console.Write(num1 + " ");


               for (int i = 0; i < num1; i++)
                {
                    if (num1 >= 30)
                    {
                        Console.WriteLine("Error!");
                    }

                    else
                    {
                        Console.Write("*");
                    }
                }


               Console.WriteLine();
               Console.Write(num2 + " ");
               for (int i = 0; i < num2; i++)
               {
                   if (num2 >= 30)
                   {
                       Console.WriteLine("Error!");
                   }

                   else
                   {
                       Console.Write("*");
                   }
               }

               Console.WriteLine();
               Console.Write(num3 + " ");
               for (int i = 0; i < num3; i++)
               {
                   if (num3 >= 30)
                   {
                       Console.WriteLine("Error!");
                   }

                   else
                   {
                       Console.Write("*");
                   }
               }

               Console.WriteLine();
               Console.Write(num4 + " ");
               for (int i = 0; i < num4; i++)
               {
                   if (num4 >= 30)
                   {
                       Console.WriteLine("Error!");
                   }

                   else
                   {
                       Console.Write("*");
                   }
               }

               Console.WriteLine();
               Console.Write(num5 + " ");
               for (int i = 0; i < num5; i++)
               {
                   if (num5 >= 30)
                   {
                       Console.WriteLine("Error!");
                   }

                   else
                   {
                       Console.Write("*");
                   }
               }
               Console.WriteLine();

            Console.ReadKey();
        }
    }
}
