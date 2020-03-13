using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            IHuman h;
            Theodore t;
            h = new Theodore();
            //cast for assignement  
            t = (Theodore)h;
            //use class based reference 
            t.Name = "Fred";
            t.Speak("I like public implementations!");
            //use interface reference  
            h.Name = "Tin";
            h.Speak("Tin Bile <3");
            Console.ReadLine();
        }
    }
}
