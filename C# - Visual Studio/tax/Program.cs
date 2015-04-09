using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tax
{
    class Program
    {
        static void Main(string[] args)
        {
            double amount = 50.00;
            double taxAmount;
            double tot;
            
            taxAmount = tax(amount);
            tot =  Total(amount, taxAmount);
            Console.WriteLine(taxAmount);
            Console.WriteLine(tot);

            Console.ReadKey();
        }

        static double tax(double subtotal)
        {
            double tax = subtotal * 0.1;
           // Console.WriteLine(tax);
            return tax;
            
        }

        static double Total(double subtotal, double tax)
        {
            double total = subtotal + tax;
            return total;

        }


    }
}
