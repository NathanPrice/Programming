using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static int MaxValue(int[] intArray)
        {
            int maxVal = intArray[0];
            for (int i = 1; i < intArray.Length; i++)
            {
                if (intArray[1] > maxVal)
                    maxVal = intArray[1];
            }
            return maxVal;
        }

        static void Main(string[] args)
        {
        }
    }
}
