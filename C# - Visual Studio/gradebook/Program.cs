/*

 ****************************************************************
 * Author: Nathan Price       Created 9/17/14                   *
 * Copyleft 2014              Last Modified: 9/23/14            *
 *                                                              *
 * Desctiption: This is just a simple gradebook. The user is    *
 * allowed to enter in as many grades as he or she needs too.   *
 * Once they are done entering grades they can simply type      *
 * -1 to quit entering their grades and finally figure out      *
 * there actual grade after averaging their previously entered  *
 * grades.                                                      *
 ****************************************************************

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gradebook
{
    class Program
    {
        static void Main(string[] args)
        {

            // Variables
            sbyte grade;
            double average = 0.0;
            int counter = 0, total = 0;
            char letter;

            Console.WriteLine("Enter Grade. Type -1 to Exit");
            grade = Convert.ToSByte(Console.ReadLine());

            while (grade != -1)
            {
                total += grade;
                counter += 1;
                Console.WriteLine("Enter Grade. Press -1 to Exit");
                grade = Convert.ToSByte(Console.ReadLine());
            }

            Console.Clear();

            // Displays Final Grade
            average = total / counter;
            Console.WriteLine("Your final grade is a {0}", average);

            // Determines Letter Grade
            if (average >= 90.0 && average <= 100.0)
            {
                letter = 'A';
            }
            else if (average <= 89.0 && average >= 80.0)
            {
                letter = 'B';
            }
            else if (average <= 79.0 && average >= 70.0)
            {
                letter = 'C';
            }
            else if (average <= 69.0 && average >= 60.0)
            {
                letter = 'D';
            }
            else
            {
                letter = 'F';
            }

            switch (letter)
            {
                case 'A':
                     Console.WriteLine("You're an excellent student!");
                    break;
                case 'B':
                    Console.WriteLine("You're above average.");
                    break;
                case 'C':
                    Console.WriteLine("You're average.");
                    break;
                case 'D':
                    Console.WriteLine("You could do better.");
                    break;
                case 'F':
                    Console.WriteLine("You should study more.");
                    break;
            }

            // Final Result
            Console.WriteLine("You entered in a total of {0} grade(s)", counter);
            Console.WriteLine("Your letter grade is an: {0}", letter);

            Console.ReadKey();

        }
    }
}