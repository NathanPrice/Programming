using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace inventory_class
{
    class Program
    { 
        static void Main(string[] args)
        {
           // Inventory Shop = new Inventory();
           

            int amount = 0;
            List <Inventory> invlist = new List<Inventory>();

            Console.WriteLine("Welcome!");
            Console.WriteLine();

            try
            {
                Console.Write("Amount of Items: ");
                amount = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("You did not enter a number!");
            }

            for (int i = 0; i < amount; i++)
            {
                Console.Write("Enter Item Name: ");
                String item_name = Console.ReadLine();                
                
                
                Console.Write("Enter Item Description: ");
                String description = Console.ReadLine();

                Console.Write("Enter Item Quantity: ");
                String quantity = Console.ReadLine();

                Console.Write("Enter Item Unit Price: ");
                String uprice = Console.ReadLine();

                Inventory a = new Inventory(item_name, description, quantity, uprice);

                invlist.Add(a);
                Console.WriteLine();


            }
            foreach (var a in invlist)
            {
                Console.WriteLine("Item:  {0}, {1}, {2}, {3}", a.getItemName(), a.getDescription(), a.getQuanity(), a.getUnitPrice() );
      


            }

                Console.ReadKey();
        }

    }
}
