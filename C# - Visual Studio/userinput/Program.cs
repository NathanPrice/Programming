using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userinput
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstname = null;
            string lastname = null;
            double grade = 0;
            double id = 0;
            string username = null;
            double gpa = 0.0;

            Console.WriteLine("First name: ");
            Console.WriteLine("Last name: ");
            Console.WriteLine("Grade (9-12): ");
            Console.WriteLine("Student ID: ");
            Console.WriteLine("Username: ");
            Console.WriteLine("GPA (0.0-4.0): \n");

            firstname = Console.ReadLine();
            lastname = Console.ReadLine();
            grade = Convert.ToDouble(Console.ReadLine());
            id = Convert.ToDouble(Console.ReadLine());
            username = Console.ReadLine();
            gpa = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Your Information:");
            Console.WriteLine(firstname);
            Console.WriteLine(lastname);
            Console.WriteLine(grade);
            Console.WriteLine(id);
            Console.WriteLine(username);
            Console.WriteLine(gpa);

            Console.ReadKey();
        }
    }
}
