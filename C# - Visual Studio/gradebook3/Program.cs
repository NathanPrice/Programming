/*

 ************************************************************************
 * Author: Nathan Price                   Instructor: Mr. Damani        *
 * Created: 11/24/14                      Last Modified: 12/03/14       *
 * Copyleft: 2014                                                       *
 *                                                                      *
 * Description: This is yet another version of my gradebook. This is    *
 * to demonstarte my knowledge on classes and objects. The user is      *
 * asked to enter in 3 students and 3 grades for each student. Once     *
 * they do that the setter and getter functions in the class will       *
 * assign each object the students full name and grades. Lastly,        *
 * the rest of the fuctions will calculate the average and letter       *
 * grade for each student object and display the result.                *
 ************************************************************************
 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace GradebookClass
{
    class Program
    {
        static void Main(string[] args)
        {
           Gradebook student1 = new Gradebook();
           Gradebook student2 = new Gradebook();
           Gradebook student3 = new Gradebook();
                
           Console.WriteLine("Enter Student 1's First and Last Name.");
           student1.setFirst(Console.ReadLine());
           student1.setLast(Console.ReadLine());
           Console.WriteLine();

           Console.WriteLine("Enter Student 2's First and Last Name.");
           student2.setFirst(Console.ReadLine());
           student2.setLast(Console.ReadLine());
           Console.WriteLine();
                
            Console.WriteLine("Enter Student 3's First and Last Name.");
            student3.setFirst(Console.ReadLine());
            student3.setLast(Console.ReadLine());
            Console.WriteLine();
            

            Console.WriteLine("Student 1's Grades");
            student1.setGrade1(Convert.ToInt32(Console.ReadLine()));
            student1.setGrade2(Convert.ToInt32(Console.ReadLine()));
            student1.setGrade3(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine();

            Console.WriteLine("Student 2's Grades");
            student2.setGrade1(Convert.ToInt32(Console.ReadLine()));
            student2.setGrade2(Convert.ToInt32(Console.ReadLine()));
            student2.setGrade3(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine();

            Console.WriteLine("Student 3's Grades");
            student3.setGrade1(Convert.ToInt32(Console.ReadLine()));
            student3.setGrade2(Convert.ToInt32(Console.ReadLine()));
            student3.setGrade3(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine();

           student1.calcAverage();
           student2.calcAverage();
           student3.calcAverage();

           student1.calcLetterGrade();
           student2.calcLetterGrade();
           student3.calcLetterGrade();

           Console.WriteLine(student1.getFirst() + " " + student1.getLast() + "'s average is: " + student1.getAverage());
           Console.WriteLine(student2.getFirst() + " " + student2.getLast() + "'s average is: " + student2.getAverage());
           Console.WriteLine(student3.getFirst() + " " + student3.getLast() + "'s average is: " + student3.getAverage());
           Console.WriteLine();

           Console.WriteLine((student1.getFirst() + " " + student1.getLast() + "'s letter grade is: " + student1.getLetterGrade()));
           Console.WriteLine((student2.getFirst() + " " + student2.getLast() + "'s letter grade is: " + student2.getLetterGrade()));
           Console.WriteLine((student3.getFirst() + " " + student3.getLast() + "'s letter grade is: " + student3.getLetterGrade()));


           Console.ReadKey();
        }
    }
}