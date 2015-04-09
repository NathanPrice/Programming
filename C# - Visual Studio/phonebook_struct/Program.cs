using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phonebook_struct
{
    class Program
    {
        public struct Name1
        {
            public string first, last, phone;
        };

        public struct Name2
        {
            public string first2, last2, phone2;
        };

        public struct Name3
        {
            public string first3, last3, phone3;
        };

        static void Main(string[] args)
        {

            Name1 s;
            Name2 t;
            Name3 u;

            Console.WriteLine("Welcome to this simple phonebook.");
            Console.WriteLine("Please enter 3 different names / phone numbers.");
            Console.WriteLine("\n");

            Console.Write("First Name: ");
            s.first = Console.ReadLine();
            Console.Write("Last Name: ");
            s.last = Console.ReadLine();
            Console.Write("Phone Number: ");
            s.phone = Console.ReadLine();
            Console.WriteLine("\n");

            Console.Write("First Name: ");
            t.first2 = Console.ReadLine();
            Console.Write("Last Name: ");
            t.last2 = Console.ReadLine();
            Console.Write("Phone Number: ");
            t.phone2 = Console.ReadLine();
            Console.WriteLine("\n");

            Console.Write("First Name: ");
            u.first3 = Console.ReadLine();
            Console.Write("Last Name: ");
            u.last3 = Console.ReadLine();
            Console.Write("Phone Number: ");
            u.phone3 = Console.ReadLine();
            Console.WriteLine("\n");

            Console.Clear();

            Console.WriteLine("The #1 Phonebook!");
            Console.WriteLine("------------------------------");
            Console.Write(s.first + " ");
            Console.Write(s.last + " ");
            Console.Write(s.phone);
            Console.WriteLine("\n");
            Console.Write(t.first2 + " ");
            Console.Write(t.last2 + " ");
            Console.Write(t.phone2);
            Console.WriteLine("\n");
            Console.Write(u.first3 + " ");
            Console.Write(u.last3 + " ");
            Console.Write(u.phone3);
            Console.WriteLine("\n");

            Console.ReadKey();
        }
    }
}
