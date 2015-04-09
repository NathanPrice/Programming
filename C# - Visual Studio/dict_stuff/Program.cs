using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dict_stuff
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring your Dictionary
            Dictionary<int, string> myDict = new Dictionary<int, string>();

            // Initial Dictionary Items
            myDict.Add(0, "lol");
            myDict.Add(1, "derp");
            myDict.Add(2, "herp");
            myDict.Add(3, "trollolol");

            // Add something to the Dictionary
            myDict.Add(4, "test");

            // Replace a Value in the Dictionary
            myDict[2] = "lerp";

            // Display Values along with Strings in your Dictionary
            foreach (KeyValuePair<int, string> pair in myDict)
            {
                Console.WriteLine(pair.Key.ToString() + " - " + pair.Value.ToString());
            }

            Console.WriteLine();

            // Display Strings in your Dictionary
            foreach(string i in myDict.Values)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            // Display the Values in your Dictionary
            foreach (int i in myDict.Keys)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            // See if a value is found in your Dictionary
            if (myDict.ContainsValue(("derp")))
            {
                Console.WriteLine("Value Found!");
            }
            else
            {
                Console.WriteLine("Value Does Not Exist!");
            }

            // See if a key is found in your Dictionary
            if (myDict.ContainsKey((5)))
            {
                Console.WriteLine("Key Found!");
            }
            else
            {
                Console.WriteLine("Key Does Not Exist!");
            }

            Console.ReadKey();
        }
    }
}
