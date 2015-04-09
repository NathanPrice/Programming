using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace damanigradebook
{
    class Class1
    {
        private string fname;
        private string lname;
        private int[] grades = new int[3];
        private double average =0;
        private char lettergrade;


        public void setFname( string name)
        {
            fname = name;
        }

        public string getFname() { return fname; }

         public void setLname( string name)
        {
            lname = name;
        }

         public string getLname() { return lname; }

         public void setFname( int [] gd)
        {
            for (int i=0; i < gd.Length; i++)
             {
                 grades[i] = gd[i];
             }
        }






    }
}
