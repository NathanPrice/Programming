using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _99bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int count = 100;

            while (count > 2)
            {
                count--;
                Console.WriteLine("{0} bottles of beer on the wall, {0} bottles of beer.", count);
                Console.WriteLine("Take one down and pass it around, {0} bottles of beer on the wall.\n", count);
            }

            Console.WriteLine("1 bottle of beer on the wall, 1 bottle of beer.");
            Console.WriteLine("Take one down and pass it around, no more bottles of beer on the wall.\n");
            Console.WriteLine("No more bottles of beer on the wall, no more bottles of beer.");
            Console.WriteLine("Go to the store and buy some more, 99 bottles of beer on the wall.");

            Console.ReadKey();
        }
    }
}