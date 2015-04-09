using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace damanigradebook
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Class1 student1 = new Class1();
            Class1 student2 = new Class1();
            Class1 student3 = new Class1();

         //   Class1[] a = new Class1 [3];



            Console.Write("Enter the student's first name:  ");
            student1.setFname(Console.ReadLine());
           // first = Console.ReadLine();
            //student1.setFname(first);


            // Student 2
            Console.Write("Enter the student's first name:  ");
            student2.setFname(Console.ReadLine());


            //Student 3

            Console.Write("Enter the student's first name:  ");
            student3.setFname(Console.ReadLine());



            Console.WriteLine("the student 1 name is:  " + student1.getFname());
            Console.WriteLine("The student 2 name is:  " + student2.getFname());
            Console.WriteLine("The student 3 name is:  " + student3.getFname());

            Console.ReadKey();

        }
    }
}
