/*

 ************************************************************************
 * Author: Nathan Price                   Instructor: Mr. Damani        *
 * Created: 11/03/14                      Last Modified: 11/05/14       *
 * Copyleft: 2014                                                       *
 *                                                                      *
 * Description: This is just a redo of my previous gradebook only
 * this time with functions and arrays
 ************************************************************************
 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gradebook2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int size;

            Console.WriteLine("Welcome to this simple gradebook.");
            Console.WriteLine();
            Console.Write("How many grades would you like to enter:  ");
            size = Convert.ToInt32(Console.ReadLine());
            double[] grades = new double[size];
            for (int i = 0; i < grades.Length; i++)
            {
                grades[i] = prompt();


            }
            double avg = calcAverage(grades);
            Console.Write("The average is:  " + avg);

            Console.ReadKey();
        }

        static double prompt()
        {
            double a;
            Console.Write("Enter Grade: ");
            a = Convert.ToDouble(Console.ReadLine());

            return a;
        }


        static double calcAverage(double[] g)
        {
            double total = 0;
            int counter = 0;
            for (int i = 0; i < g.Length; i++)
            {
                total += g[i];
                counter++;

            }

            double average = total / counter;
            return average;


        }

    }
}
