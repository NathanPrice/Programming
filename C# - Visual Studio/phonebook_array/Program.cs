using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phonebook_array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] first_names = new string[3];
            string[]  last_names = new string[3];
            string[] phone_numbers = new string[3];

            Console.WriteLine("Welcome to this simple phonebook.");
            Console.WriteLine("Please enter 3 different names / phone numbers.");
            Console.WriteLine("\n");

            Console.Write("First Name: ");
            first_names[0] = Console.ReadLine();
            Console.Write("Last Name: ");
            last_names[0] = Console.ReadLine();
            Console.Write("Phone Number: ");
            phone_numbers[0] = Console.ReadLine();
            Console.WriteLine("\n");

            Console.Write("First Name: ");
            first_names[1] = Console.ReadLine();
            Console.Write("Last Name: ");
            last_names[1] = Console.ReadLine();
            Console.Write("Phone Number: ");
            phone_numbers[1] = Console.ReadLine();
            Console.WriteLine("\n");

            Console.Write("First Name: ");
            first_names[2] = Console.ReadLine();
            Console.Write("Last Name: ");
            last_names[2] = Console.ReadLine();
            Console.Write("Phone Number: ");
            phone_numbers[2] = Console.ReadLine();
            Console.WriteLine("\n");

            Console.Clear();

            Console.WriteLine("The #1 Phonebook!");
            Console.WriteLine("------------------------------");
            Console.Write(first_names[0] + " ");
            Console.Write(last_names[0] + " ");
            Console.Write(phone_numbers[0]);
            Console.WriteLine("\n");
            Console.Write(first_names[1] + " ");
            Console.Write(last_names[1] + " ");
            Console.Write(phone_numbers[1]);
            Console.WriteLine("\n");
            Console.Write(first_names[2] + " ");
            Console.Write(last_names[2] + " ");
            Console.Write(phone_numbers[2]);
            Console.WriteLine("\n");

            Console.ReadKey();
        }
    }
}
