using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch09Ex01
{

    public abstract class MyBase
    {

    }

    internal class MyClass : MyBase
    {

    }

    public interface IMyBaseInterface
    {

    }

    internal interface IMyBaseInterface2
    {

    }

    internal interface IMyinterface : IMyBaseInterface, IMyBaseInterface2
    {

    }

    internal sealed class MyComplexClass : MyClass, IMyinterface
    {


    }

    class Program
    {
        static void Main(string[] args)
        {

            MyComplexClass myObj = new MyComplexClass();
            Console.WriteLine(myObj.ToString());

            Console.ReadKey();
        }
    }
}
