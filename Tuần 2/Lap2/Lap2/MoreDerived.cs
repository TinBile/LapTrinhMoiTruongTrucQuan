using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap2
{
    class MoreDerived:Derived
    {
        //notice the use of the base keyword to chain the construction to the base 
        public MoreDerived() : base("DEFAULT")
        {
            Console.WriteLine("In MoreDerived Constructor!");
        }
    }
}
