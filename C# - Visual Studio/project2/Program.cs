/*

 *******************************************************************
 * Author: Nathan Price     Instructor: Mr. Damani                 *
 * Copyleft 2014            Created: 09/24/14                      *
 * Last Modified: 09/24/14                                         *
 *                                                                 *
 * Description: This is just a simple program that can             *
 * find the product of all odd numbers in a range. Any             *
 * range can work for this but I went for the number range         *
 * 1 - 15. Once you entered in you range you can simply run        *
 * the code to get your result.                                    *
 *******************************************************************
 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int num = 0, product = 1;

            while (num <=15)
            {
                if (num % 2 == 1)
                {
                    product *= num;
                }
                num ++;
            }

            Console.WriteLine("The product of the odd numbers in the range 1-15 is: {0}", product);
            Console.ReadKey();
        }
    }
}