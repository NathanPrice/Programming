using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
    class Class1<T, U>
    {
        public T First { get; set; }
        public U Second { get; set; }

        public override string ToString()
        {
            return First + " " + Second;
        }

    }

    class InterfaceTest : IMyInterface
    {

        public bool Start()
        {
            throw new NotImplementedException();
        }

        public bool Stop()
        {
            throw new NotImplementedException();
        }
    }
}
