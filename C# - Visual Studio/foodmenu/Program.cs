using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foodmenu
{
    class Program
    {

        static void Main(string[] args)
        {
            
            // Tax
            double tax;
            tax = 0.0885;

            // Appetizer Items
            string app1 = "(1) Salad - $9.99";
            string app2 = "(2) Stuffed Mushrooms - $5.99";
            string app3 = "(3) Shrimp - $6.99";

            // Entree Items
            string ent1 = "(1) Steak - $21.99";
            string ent2 = "(2) Ribs - $23.99";
            string ent3 = "(3) Steak Burger - $12.99";

            // Drinks
            string dri1 = "(1) Small Coke - $1.99";
            string dri2 = "(2) Medium Coke - $2.99";
            string dri3 = "(3) Large Coke - $3.99";


            // Appetizer Cost
            double amon1 = 9.99;
            double amon2 = 5.99;
            double amon3 = 6.99;

            // Entree Cost
            double emon1 = 21.99;
            double emon2 = 23.99;
            double emon3 = 12.99;

            // Drink Cost
            double dmon1 = 1.99;
            double dmon2 = 2.99;
            double dmon3 = 3.99;

            // Food Tax

            // Salad, Steak, and Drink 1
            double salSteak1 = amon1 + emon1 + dmon1;
            double salSteakTax1 = salSteak1 * tax;
            double salSteakFinal1= salSteak1 + salSteakTax1;
            // Salad, Steak, and Drink 2
            double salSteak2 = amon1 + emon1 + dmon2;
            double salSteakTax2 = salSteak2 * tax;
            double salSteakFinal2 = salSteak2 + salSteakTax2;
            // Salad, Steak, and Drink 3
            double salSteak3 = amon1 + emon1 + dmon3;
            double salSteakTax3 = salSteak3 * tax;
            double salSteakFinal3 = salSteak3 + salSteakTax3;
            // Salad, Ribs, and Drink 1
            double salRibs1 = amon1 + emon2 + dmon1;
            double salRibsTax1 = salRibs1 * tax;
            double salRibsFinal1 = salRibs1 + salRibsTax1;
            // Salad, Ribs, and Drink 2
            double salRibs2 = amon1 + emon2 + dmon2;
            double salRibsTax2 = salRibs1 * tax;
            double salRibsFinal2 = salRibs1 + salRibsTax1;
            // Salad, Ribs, and Drink 3
            double salRibs3 = amon1 + emon2 + dmon3;
            double salRibsTax3 = salRibs3 * tax;
            double salRibsFinal3 = salRibs3 + salRibsTax3;
            // Salad, Burger and Drink 1
            double salBur1 = amon1 + emon3 + dmon1;
            double salBurTax1 = salBur1 * tax;
            double salBurFinal1 = salBur1 + salBurTax1;
            // Salad, Burger, and Drink 2
            double salBur2 = amon1 + emon3 + dmon2;
            double salBurTax2 = salBur2 * tax;
            double salBurFinal2 = salBur2 + salBurTax2;
            // Salad, Burger, and Drink 3
            double salBur3 = amon1 + emon3 + dmon3;
            double salBurTax3 = salBur3 * tax;
            double salBurFinal3 = salBur3 + salBurTax3;
            // Mushrooms, Steak, and Drink 1
            double mushSteak1 = amon2 + emon1 + dmon1;
            double mushSteakTax1 = mushSteak1 * tax;
            double mushSteakFinal1 = mushSteak1 + mushSteakTax1;
            // Mushrooms, Steak, and Drink 2
            double mushSteak2 = amon2 + emon1 + dmon2;
            double mushSteakTax2 = mushSteak2 * tax;
            double mushSteakFinal2 = mushSteak2 + mushSteakTax2;
            // Mushrooms, Steak, and Drink 3
            double mushSteak3 = amon2 + emon1 + dmon3;
            double mushSteakTax3 = mushSteak3 * tax;
            double mushSteakFinal3 = mushSteak3 + mushSteakTax3;
            // Mushrooms, Ribs and Drink 1
            double mushRibs1 = amon2 + emon2 + dmon1;
            double mushRibsTax1 = mushRibs1 * tax;
            double mushRibsFinal1 = mushRibs1 + mushRibsTax1;
            // Mushrooms, Ribs and Drink 2
            double mushRibs2 = amon2 + emon2 + dmon2;
            double mushRibsTax2 = mushRibs2 * tax;
            double mushRibsFinal2 = mushRibs2 + mushRibsTax2;
            // Mushrooms, Ribs and Drink 3
            double mushRibs3 = amon2 + emon2 + dmon1;
            double mushRibsTax3 = mushRibs3 * tax;
            double mushRibsFinal3 = mushRibs3 + mushRibsTax3;
            // Mushrooms, Burger, and Drink 1
            double mushBur1 = amon2 + emon3 + dmon1;
            double mushBurTax1 = mushBur1 * tax;
            double mushBurFinal1 = mushBur1 + mushBurTax1;
            // Mushrooms, Burger, and Drink 2
            double mushBur2 = amon2 + emon3 + dmon2;
            double mushBurTax2 = mushBur2 * tax;
            double mushBurFinal2 = mushBur2 + mushBurTax2;
            // Mushrooms, Burger, and Drink 3
            double mushBur3 = amon2 + emon3 + dmon3;
            double mushBurTax3 = mushBur3 * tax;
            double mushBurFinal3 = mushBur3 + mushBurTax3;
            // Shrimp, Steak and Drink 1
            double shriSteak1 = amon3 + emon1 + dmon1;
            double shriSteakTax1 = shriSteak1 * tax;
            double shriSteakFinal1 = shriSteak1 + shriSteakTax1;
            // Shrimp, Steak and Drink 2
            double shriSteak2 = amon3 + emon1 + dmon2;
            double shriSteakTax2 = shriSteak2 * tax;
            double shriSteakFinal2 = shriSteak2 + shriSteakTax2;
            // Shrimp, Steak and Drink 3
            double shriSteak3 = amon3 + emon1 + dmon3;
            double shriSteakTax3 = shriSteak3 * tax;
            double shriSteakFinal3 = shriSteak3 + shriSteakTax3;
            // Shrimp, Ribs, and Drink 1
            double shriRibs1 = amon3 + emon2 + dmon1;
            double shriRibsTax1 = shriRibs1 * tax;
            double shriRibsFinal1 = shriRibs1 + shriRibsTax1;
            // Shrimp, Ribs, and Drink 2
            double shriRibs2 = amon3 + emon2 + dmon2;
            double shriRibsTax2 = shriRibs2 * tax;
            double shriRibsFinal2 = shriRibs2 + shriRibsTax2;
            // Shrimp, Ribs, and Drink 3
            double shriRibs3 = amon3 + emon2 + dmon3;
            double shriRibsTax3 = shriRibs3 * tax;
            double shriRibsFinal3 = shriRibs3 + shriRibsTax3;
            // Shrimp, Burger, and Drink 1
            double shriBur1 = amon3 + emon3 + dmon1;
            double shriBurTax1 = shriBur1 * tax;
            double shriBurFinal1 = shriBur1 + shriBurTax1;
            // Shrimp, Burger, and Drink 2
            double shriBur2 = amon3 + emon3 + dmon2;
            double shriBurTax2 = shriBur2 * tax;
            double shriBurFinal2 = shriBur2 + shriBurTax2;
            // Shrimp, Burger, and Drink 3
            double shriBur3 = amon3 + emon3 + dmon3;
            double shriBurTax3 = shriBur3 * tax;
            double shriBurFinal3 = shriBur3 + shriBurTax3;

            // Displays Items
            Console.WriteLine("Please select an appetizer.");
            Console.WriteLine(app1);
            Console.WriteLine(app2);
            Console.WriteLine(app3);

            // User chooses an appetizer
            int choice = Convert.ToInt32(Console.ReadLine());

            // If Choice is Salad
            if (choice == 1)
            {
                // Displays Entree Items
                Console.WriteLine("\nNow Choose an Entree to go with your Salad.");
                Console.WriteLine(ent1);
                Console.WriteLine(ent2);
                Console.WriteLine(ent3);

                int choice2 = Convert.ToInt32(Console.ReadLine());
                // If Choice is Steak
                if (choice2 == 1)
                {
                    Console.WriteLine("\nNow Choose a Drink");
                    Console.WriteLine(dri1);
                    Console.WriteLine(dri2);
                    Console.WriteLine(dri3);

                    // User Chooses Drink
                    int choice3 = Convert.ToInt32(Console.ReadLine());

                    // If Choice is Drink 1
                    if (choice3 == 1)
                    {
                        Console.WriteLine("Subtotal: {0:C}", salSteak1);
                        Console.WriteLine("Total: {0:C}", salSteakFinal1);
                    }
                    // If Choice is Drink 2
                    else if (choice3 == 2)
                    {
                        Console.WriteLine("Subtotal: {0:C}", salSteak2);
                        Console.WriteLine("Total: {0:C}", salSteakFinal2);
                    }
                    // If Choice is Drink 3
                    else
                    {
                        Console.WriteLine("Subtotal: {0:C}", salSteak3);
                        Console.WriteLine("Total: {0:C}", salSteakFinal3);
                    }
                    
                }
                // If Choice is Ribs
                else if (choice2 == 2)
                {
                    
                    Console.WriteLine("\nNow Choose a Drink");
                    Console.WriteLine(dri1);
                    Console.WriteLine(dri2);
                    Console.WriteLine(dri3);

                    // User Chooses Drink
                    int choice3 = Convert.ToInt32(Console.ReadLine());

                    // If Choice is Drink 1
                    if (choice3 == 1)
                    {
                        Console.WriteLine("Subtotal: {0:C}", salRibs1);
                        Console.WriteLine("Total: {0:C}", salSteakFinal1);
                    }
                    // If Choice is Drink 2
                    else if (choice3 == 2)
                    {
                        Console.WriteLine("Subtotal: {0:C}", salRibs2);
                        Console.WriteLine("Total: {0:C}", salRibsFinal2);
                    }
                    // If Choice is Drink 3
                    else
                    {
                        Console.WriteLine("Subtotal: {0:C}", salRibs3);
                        Console.WriteLine("Total: {0:C}", salRibsFinal3);
                    }
                }
                // If Choice is Burger
                else if (choice2 == 3)
                {
                    Console.WriteLine("\nNow Choose a Drink");
                    Console.WriteLine(dri1);
                    Console.WriteLine(dri2);
                    Console.WriteLine(dri3);
                    // User Chooses Drink
                    int choice3 = Convert.ToInt32(Console.ReadLine());

                    // If Choice is Drink 1
                    if (choice3 == 1)
                    {
                        Console.WriteLine("Subtotal: {0:C}", salBur1);
                        Console.WriteLine("Total: {0:C}", salBurFinal1);
                    }
                    // If Choice is Drink 2
                    else if (choice3 == 2)
                    {
                        Console.WriteLine("Subtotal: {0:C}", salBur2);
                        Console.WriteLine("Total: {0:C}", salBurFinal2);
                    }
                    // If Choice is Drink 3
                    else
                    {
                        Console.WriteLine("Subtotal: {0:C}", salBur3);
                        Console.WriteLine("Total: {0:C}", salBurFinal3);
                    }
                }

            }

            // If Choice is Mushroom
            else if (choice == 2)
            {
                // Displays Entree Items
                Console.WriteLine("\nNow Choose an Entree to go with your Stuffed Mushrooms.");
                Console.WriteLine(ent1);
                Console.WriteLine(ent2);
                Console.WriteLine(ent3);

                int choice2 = Convert.ToInt32(Console.ReadLine());
                // If Choice is Steak
                if (choice2 == 1)
                {
                    Console.WriteLine("\nNow Choose a Drink");
                    Console.WriteLine(dri1);
                    Console.WriteLine(dri2);
                    Console.WriteLine(dri3);

                    int choice3 = Convert.ToInt32(Console.ReadLine());
                    // If Choice is Drink 1
                    if (choice3 == 1)
                    {
                        Console.WriteLine("Subtotal: {0:C}", mushSteak1);
                        Console.WriteLine("Total: {0:C}", mushSteakFinal1);
                    }
                    // If Choice is Drink 2
                    else if (choice3 == 2)
                    {
                        Console.WriteLine("Subtotal: {0:C}", salRibs2);
                        Console.WriteLine("Total: {0:C}", salRibsFinal2);
                    }
                    // If Choice is Drink 3
                    else
                    {
                        Console.WriteLine("Subtotal: {0:C}", salRibs3);
                        Console.WriteLine("Total: {0:C}", salRibsFinal3);
                    }
                }
                // If Choice is Ribs
                else if (choice2 == 2)
                {
                    Console.WriteLine("\nNow Choose a Drink");
                    Console.WriteLine(dri1);
                    Console.WriteLine(dri2);
                    Console.WriteLine(dri3);

                    int choice3 = Convert.ToInt32(Console.ReadLine());
                    // If Choice is Drink 1
                    if (choice3 == 1)
                    {
                        Console.WriteLine("Subtotal: {0:C}", mushRibs1);
                        Console.WriteLine("Total: {0:C}", mushRibsFinal1);
                    }
                    // If Choice is Drink 2
                    else if (choice3 == 2)
                    {
                        Console.WriteLine("Subtotal: {0:C}", mushRibs2);
                        Console.WriteLine("Total: {0:C}", mushRibsFinal2);
                    }
                    // If Choice is Drink 3
                    else
                    {
                        Console.WriteLine("Subtotal: {0:C}", mushRibs3);
                        Console.WriteLine("Total: {0:C}", mushRibsFinal3);
                    }
                }
                // If Choice is Burger
                else if (choice2 == 3)
                {
                    Console.WriteLine("\nNow Choose a Drink");
                    Console.WriteLine(dri1);
                    Console.WriteLine(dri2);
                    Console.WriteLine(dri3);

                    int choice3 = Convert.ToInt32(Console.ReadLine());
                    // If Choice is Drink 1
                    if (choice3 == 1)
                    {
                        Console.WriteLine("Subtotal: {0:C}", mushBur1);
                        Console.WriteLine("Total: {0:C}", mushBurFinal1);
                    }
                    // If Choice is Drink 2
                    else if (choice3 == 2)
                    {
                        Console.WriteLine("Subtotal: {0:C}", mushBur2);
                        Console.WriteLine("Total: {0:C}", mushBurFinal2);
                    }
                    // If Choice is Drink 3
                    else
                    {
                        Console.WriteLine("Subtotal: {0:C}", mushBur3);
                        Console.WriteLine("Total: {0:C}", mushBurFinal3);
                    }
                }

            }
            
            // If Choice is Shrimp
            else if (choice == 3)
            {
                // Displays Entree Items
                Console.WriteLine("\nNow Choose an Entree to go with your Shrimp.");
                Console.WriteLine(ent1);
                Console.WriteLine(ent2);
                Console.WriteLine(ent3);

                int choice2 = Convert.ToInt32(Console.ReadLine());
                // If Choice is Steak
                if (choice2 == 1)
                {
                    Console.WriteLine("\nNow Choose a Drink");
                    Console.WriteLine(dri1);
                    Console.WriteLine(dri2);
                    Console.WriteLine(dri3);

                    int choice3 = Convert.ToInt32(Console.ReadLine());
                    // If Choice is Drink 1
                    if (choice3 == 1)
                    {
                        Console.WriteLine("Subtotal: {0:C}", shriSteak1);
                        Console.WriteLine("Total: {0:C}", shriSteakFinal1);
                    }
                    // If Choice is Drink 2
                    else if (choice3 == 2)
                    {
                        Console.WriteLine("Subtotal: {0:C}", shriSteak2);
                        Console.WriteLine("Total: {0:C}", shriSteakFinal2);
                    }
                    // If Choice is Drink 3
                    else
                    {
                        Console.WriteLine("Subtotal: {0:C}", shriSteak3);
                        Console.WriteLine("Total: {0:C}", shriSteakFinal3);
                    }
                }
                // If Choice is Ribs
                else if (choice2 == 2)
                {
                    Console.WriteLine("\nNow Choose a Drink");
                    Console.WriteLine(dri1);
                    Console.WriteLine(dri2);
                    Console.WriteLine(dri3);

                    int choice3 = Convert.ToInt32(Console.ReadLine());
                    // If Choice is Drink 1
                    if (choice3 == 1)
                    {
                        Console.WriteLine("Subtotal: {0:C}", shriRibs1);
                        Console.WriteLine("Total: {0:C}", shriRibsFinal1);
                    }
                    // If Choice is Drink 2
                    else if (choice3 == 2)
                    {
                        Console.WriteLine("Subtotal: {0:C}", shriRibs2);
                        Console.WriteLine("Total: {0:C}", shriRibsFinal2);
                    }
                    // If Choice is Drink 3
                    else
                    {
                        Console.WriteLine("Subtotal: {0:C}", shriRibs3);
                        Console.WriteLine("Total: {0:C}", shriRibsFinal3);
                    }
                }
                // If Choice is Burger
                else if (choice2 == 3)
                {
                    Console.WriteLine("\nNow Choose a Drink");
                    Console.WriteLine(dri1);
                    Console.WriteLine(dri2);
                    Console.WriteLine(dri3);

                    int choice3 = Convert.ToInt32(Console.ReadLine());
                    // If Choice is Drink 1
                    if (choice3 == 1)
                    {
                        Console.WriteLine("Subtotal: {0:C}", shriBur1);
                        Console.WriteLine("Total: {0:C}", shriBurFinal1);
                    }
                    // If Choice is Drink 2
                    else if (choice3 == 2)
                    {
                        Console.WriteLine("Subtotal: {0:C}", shriBur2);
                        Console.WriteLine("Total: {0:C}", shriBurFinal2);
                    }
                    // If Choice is Drink 3
                    else
                    {
                        Console.WriteLine("Subtotal: {0:C}", shriBur3);
                        Console.WriteLine("Total: {0:C}", shriBurFinal3);
                    }
                }
            }

            Console.ReadKey();
        }

    }

}