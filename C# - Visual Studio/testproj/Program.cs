using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testproj
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = " ";

            Console.Write("Enter Name: ");
            myName = Console.ReadLine();

            Console.WriteLine("Hello, {0}", myName);

            Console.ReadKey();
        }
    }
}
