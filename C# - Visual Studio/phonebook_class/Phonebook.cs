using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phonebook_class
{
    class Phonebook
    {
        private string fname = null;
        private string lname = null;
        private string phonenum = null;

        public void setFname(string name)
        {
            fname = name;

        }

        public string getFirst()
        {
            return fname;
        }

        public void setLname(string name)
        {
            lname = name;

        }

        public string getLast()
        {
            return lname;
        }

        public void setPhone(string phone)
        {
            phonenum = phone;

        }

        public string getPhone()
        {
            return phonenum;
        }
    }
}
