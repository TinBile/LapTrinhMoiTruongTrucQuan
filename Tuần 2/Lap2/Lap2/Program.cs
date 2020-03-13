using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap2
{
    class Program
    {
        static void Main(string[] args)
        {
            Base b;
            Derived d;
            //create an instance of Derived 
            d = new Derived("test");
            b = d;
            b.Method2();
            //does this go to Derived implementation or Base? 
            d.Method2();//what about this call
            Console.ReadLine();
        }
    }
}
