using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] friendNames = { "Robert Barwell", "Mike Parry", "Jeremy Beacock" };

           foreach (string i in friendNames)
           {
               Console.WriteLine(i);
           }
            Console.ReadKey();
        }
    }
}
