/*

 ************************************************************************
 * Author: Nathan Price                   Instructor: Mr. Damani        *
 * Created: 10/08/14                      Last Modified: 10/13/14       *
 * Copyleft: 2014                                                       *
 *                                                                      *
 * Description: This is a simple program displays 4 different asterisk  *
 * triangles. It uses nested for loops to increment and display the     *
 * asterisk triangles. For the last 2 patterns a 3rd for loop is added  * 
 * to add +'s to shift the last 2 triangles to the right.               *
 ************************************************************************
 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project3
{
    class Program
    {
        static void Main(string[] args)
        {
 
           // First Pattern
            for (int row = 0; row <= 10; row++)
            {
                for (int col = 0; col <= row; col++)
                    Console.Write("*");
                    Console.Write("\n");
                    Console.WriteLine(" ");
            }

            Console.WriteLine("\n");

            // Second Pattern
            for (int row = 0; row <= 10; row++)
            {
                for (int col = 10; col >= row; col--)
                    Console.Write("*");
                    Console.Write("\n");
                    Console.WriteLine(" "); 
            }

            Console.WriteLine("\n");

            // Third Pattern
            for (int row = 0; row < 10; row++)
            {
                for (int space = 0; space < row; space++)

                    Console.Write("+");

                    for (int col = 10; col > row; col--)
                        Console.Write("*");
                        Console.Write("\n");
                        Console.WriteLine(" ");
            }

            Console.WriteLine("\n");

            // Fourth Pattern
            for (int row = 10; row > 0; row--)
            {
                for (int space = 0; space < row; space++)

                    Console.Write("+");

                for (int col = 10; col > row; col--)
                    Console.Write("*");
                Console.Write("\n");
                Console.WriteLine(" ");
            }


                Console.ReadKey();
        }
    }
}