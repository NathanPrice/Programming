using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foodmenu2
{
    class Program
    {
        static void Main(string[] args)
        {
            double tax = 0.0885;
            double tax1 = 0;
            double price = 0;
            double price2 = 0;
            double price3 = 0;
            double subtotal = 0;
            double total = 0;
            string appetizer = null;
            string entree = null;
            string drink = null;
            
            // Start
            Console.WriteLine("Welcome El Fancy.\n");
            Console.WriteLine("What would you like as an Appetizer?\n");
            Console.WriteLine("(1) Salad - $9.99 | (2) Caviar - $16.99 | (3) Breadsticks - $13.99");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                appetizer = "Salad - $9.99";
                price = 9.99;
                subtotal = price;
            }
            else if (choice == 2)
            {
                appetizer = "Caviar - $16.99";
                price = 16.99;
                subtotal = price;
            }
            else if (choice == 3)
            {
                appetizer = "Breadsticks - $13.99";
                price = 13.99;
                subtotal = price;
            }

            // Entree
            Console.WriteLine("\nNow choose your Entree\n");
            Console.WriteLine("(1) Steak - $21.99 | (2) Premium Burger - $17.99 | (3) L33t Sliders - $1337.37");

            int choice2 = Convert.ToInt32(Console.ReadLine());

            if (choice2 == 1)
            {
                entree = "Steak - $21.99";
                price2 = 21.99;
                subtotal = price + price2;
            }
            else if (choice2 == 2)
            {
                entree = "Premium Burger - $17.99";
                price2 = 17.99;
                subtotal = price + price2;
            }
            else if (choice2 == 3)
            {
                entree = "L33t Sliders - $1337.37";
                price2 = 1337.37;
                subtotal = price + price2;
            }

            // Drink
            Console.WriteLine("\nFinally, choose your drink\n");
            Console.WriteLine("(1) Water - $9.99 | (2) Coke - $ 4.99 | (3) Dr Pepper - $5.99");

            int choice3 = Convert.ToInt32(Console.ReadLine());

            if (choice3 == 1)
            {
                drink = "Water - $9.99";
                price3 = 9.99;
                subtotal = price + price2 + price3;
                tax1 = subtotal * tax;
                total = subtotal + tax1;
            }
            else if (choice3 == 2)
            {
                drink = "Coke - $4.99";
                price3 = 4.99;
                subtotal = price + price2 + price3;
                tax1 = subtotal * tax;
                total = subtotal + tax1;
            }
            else if (choice3 == 3)
            {
                drink = "Dr Pepper - $5.99";
                price3 = 5.99;
                subtotal = price + price2 + price3;
                tax1 = subtotal * tax;
                total = subtotal + tax1;
            }

            // Receipt
            Console.Clear();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("|\tEl Facy               |");
            Console.WriteLine("| (Tel): 555-555-5555         |");
            Console.WriteLine("| Address: 1234 Street Street |");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("\nReceipt");
            Console.WriteLine("-------------------");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("\n");
            Console.WriteLine(appetizer);
            Console.WriteLine(entree);
            Console.WriteLine(drink);
            Console.WriteLine("\nYour subtotal is {0:C}", subtotal);
            Console.WriteLine("Your tax is {0:C}", tax1);
            Console.WriteLine("Your total is {0:C}", total);

            Console.ReadKey();
        }
    }
}