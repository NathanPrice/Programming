using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            string fname = null, fname2 = null, fname3 = null;
            string lname = null, lname2 = null, lname3 = null;
            string tel = null, tel2 = null, tel3 = null;

            Console.WriteLine("Welcome to this simple phonebook.");
            Console.WriteLine("Please enter 3 different names / phone numbers.");
            Console.WriteLine("\n");

            Console.Write("First Name: ");
            fname = Console.ReadLine();
            Console.Write("Last Name: ");
            lname = Console.ReadLine();
            Console.Write("Phone Number: ");
            tel = Console.ReadLine();
            Console.WriteLine("\n");

            Console.Write("First Name: ");
            fname2 = Console.ReadLine();
            Console.Write("Last Name: ");
            lname2 = Console.ReadLine();
            Console.Write("Phone Number: ");
            tel2 = Console.ReadLine();
            Console.WriteLine("\n");

            Console.Write("First Name: ");
            fname3 = Console.ReadLine();
            Console.Write("Last Name: ");
            lname3 = Console.ReadLine();
            Console.Write("Phone Number: ");
            tel3 = Console.ReadLine();
            Console.WriteLine("\n");

            Console.Clear();

            Console.WriteLine("The #1 Phonebook!");
            Console.WriteLine("------------------------------");

            Console.Write(fname + " " + lname + " " + tel);
            Console.WriteLine("\n");
            Console.Write(fname2 + " " + lname2 + " " + tel2);
            Console.WriteLine("\n");
            Console.Write(fname3 + " " + lname3 + " " + tel3);

            Console.ReadKey();
        }
    }
}
