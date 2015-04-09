using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            int my_int = 0;

            try
            {
                my_int = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(my_int);
            }
            catch
            {
                Console.WriteLine("ERROR! You did not enter an integer.");
            }

            Console.ReadKey();
        }
        
    }
}
