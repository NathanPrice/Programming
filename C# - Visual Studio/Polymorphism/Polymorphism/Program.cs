using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            // Objects
            Static sPoly = new Static();

            Console.WriteLine("Function Overloading");
            Console.WriteLine("----------------------");
            sPoly.myOverload("Nathan");
            sPoly.myOverload(16);
            sPoly.myOverload(134.23);
            sPoly.myOverload("Nick", 69, 69.69);

            Console.ReadKey();
        }
    }
}
