using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Static
    {
        // Function Overloading
        public void myOverload(string s)
        {
            Console.WriteLine(s);
        }
        public void myOverload(int s)
        {
            Console.WriteLine(s);
        }
        public void myOverload(double s)
        {
            Console.WriteLine(s);
        }
        public void myOverload(string s, int t, double u)
        {
            Console.WriteLine("3 Parameters: " + s + " " + t +  " " + u);
        }

        // Operator Overloading

    }
}
