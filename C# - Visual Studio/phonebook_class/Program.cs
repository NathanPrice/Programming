using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phonebook_class
{
    class Program
    {
        static void Main(string[] args)
        {
            // Object that holds phonebook + addressbook info
            Addressbook book = new Addressbook();

            Console.Write("First Name: ");
            book.setFname(Console.ReadLine());

            Console.Write("Last Name: ");
            book.setLname(Console.ReadLine());

            Console.Write("Phone Number: ");
            book.setPhone(Console.ReadLine());

            Console.Write("Address: ");
            book.Address = Console.ReadLine();

            Console.Write("City: ");
            book.City = Console.ReadLine();

            Console.Write("State: ");
            book.State = Console.ReadLine();

            Console.Write("Zip: ");
            book.Zip = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Result(s)");
            Console.WriteLine("-------------");
            Console.Write("First Name: " + book.getFirst());
            Console.WriteLine("");
            Console.Write("Last Name: " + book.getLast());
            Console.WriteLine("");
            Console.Write("Phone Number: " + book.getPhone());
            Console.WriteLine("");
            Console.Write("Address: " + book.Address);
            Console.WriteLine("");
            Console.Write("City: " + book.City);
            Console.WriteLine("");
            Console.Write("State: " + book.State);
            Console.WriteLine("");
            Console.Write("Zip: " + book.Zip);
            Console.WriteLine("");


            Console.ReadKey();
        }
    }
}
