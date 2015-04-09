using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initials
{
    class Program
    {
        static void Main(string[] args)
        {
            string letters;
            Console.WriteLine("Type in your initials: ");
            letters = Console.ReadLine();
            Console.WriteLine("Welcome {0}!", letters);
            Console.ReadKey();
        }
    }
}
