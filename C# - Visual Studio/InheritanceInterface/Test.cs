using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceInterface
{
    class Test
    {
        public string myName = "Nathan";
        public int myAge = 16;
    }

    class Test2 : Test, Interface
    {

        public void myMethod(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public int Value()
        {
            throw new NotImplementedException();
        }
    }
}
