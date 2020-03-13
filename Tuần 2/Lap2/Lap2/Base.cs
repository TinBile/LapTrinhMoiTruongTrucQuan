using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap2
{
    class Base
    {
        public Base()
        {
            Console.WriteLine("In Base Constructor!");
        }
        public virtual void Method1()
        {
            Console.WriteLine("In Base.Method1");
        }
        public void Method2()
        {
            Console.WriteLine("In Base.Method2");
        }
    }
}

