using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse_string
{
    class Program
    {
        static void Main(string[] args)
        {

            Program.even();

            Console.ReadKey();
        }

        public static void even()
        {
            int even = 2;

            while (even < 22)
            {
                Console.WriteLine(even);
                even = even + 2;
            }
        }
    }
}
