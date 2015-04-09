using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch5types
{
    class Program
    {

        enum test : int
        {
            one = 1,
            two = 2,
            three = 3
        }

        static void Main(string[] args)
        {
            test test1 = test.one;
            Console.WriteLine("Test = {0}", test1);
            Console.ReadKey();
        }
    }
}
