using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap2
{
    class Derived :Base
    {
        public Derived(string var)
        {
            Console.WriteLine("In Derived constructor. Constructor parameter value:{0}", var);
        }
        public override void Method1()
        {
            Console.WriteLine("In Base.Method1");
        }
        public void Method2()
        {
            Console.WriteLine("In Base.Method2");
        }
    }
}
