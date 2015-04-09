using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradebookClass
{
    class Gradebook
    {
        private string first;
        private string last;
        private int grade1;
        private int grade2;
        private int grade3;
        private double average = 0;
        private char lettergrade;


        public Gradebook()
        {

            first = null;
            last = null;
            grade1 = 0;
            grade2 = 0;
            grade3 = 0;
            average = 0;
            lettergrade = ' ';
        }

        public void setFirst(string name)
        {
            first = name;

        }

        public string getFirst()
        {
            return first;
        }

        public void setLast(string name)
        {
            last = name;
        }

        public string getLast()
        {
            return last;
        }

        public void setGrade1(int grades)
        {
            grade1 = grades;
        }

        public int getGrade()
        {
            return grade1;
        }
        
        public void setGrade2(int grade)
        {
            grade2 = grade;
        }

        public int getGrade2()
        {
            return grade2;
        }

        public void setGrade3(int grade)
        {
            grade3 = grade;
        }

        public int getGrade3()
        {
            return grade3;
        }
        
        public void calcAverage()
        {
            average = (grade1 + grade2 + grade3) / 3;
        }

        public double getAverage()
        {
            return average;
        }

        public void calcLetterGrade()
        {
            if (average >= 90 && average <= 100)
            {
                lettergrade = 'A';
            }
            else if (average >= 80 && average <= 89)
            {
                lettergrade = 'B';
            }
            else if (average >= 70 && average <= 79)
            {
                lettergrade = 'C';
            }
            else if (average >= 60 && average <= 69)
            {
                lettergrade = 'D';
            }
            else
            {
                lettergrade = 'F';
            }

        }

        public char getLetterGrade()
        {
            return lettergrade;
        }
    }
}
