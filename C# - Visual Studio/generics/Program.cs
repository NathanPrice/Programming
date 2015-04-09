using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generics
            Class1<int, int> test1 = new Class1<int, int> {First = 5, Second = 8};
            Class1<string, string> test2 = new Class1<string, string> { First = "Nathan", Second = "Price" };

            Console.WriteLine(test1.ToString());
            Console.WriteLine(test2);
            

            Console.ReadKey();
        }
    }
}
