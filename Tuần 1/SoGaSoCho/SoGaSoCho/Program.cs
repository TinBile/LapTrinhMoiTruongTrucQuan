using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoGaSoCho
{
    class Program
    {
        static void Main(string[] args)
        {
            float a1, b1, c1, a2, b2, c2;
            Console.Clear();
            Console.WriteLine("****** So Ga So Cho********");
            Console.Write("{0}", "nhap so a1: ");
            a1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("{0}", "nhap so b1: ");
            b1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("{0}", "nhap so c1: ");
            c1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("{0}", "nhap so a2: ");
            a2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("{0}", "nhap so b2: ");
            b2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("{0}", "nhap so c2: ");
            c2 = Convert.ToInt32(Console.ReadLine());

            float D = a1 * b2 - a2 * b1;
            float Dx = c1 * b2 - c2 * b1;
            float Dy = a1 * c2 - a2 * c1;
            Console.WriteLine("Results: ");
            Console.WriteLine("Ga = {0}", Dx / D);
            Console.WriteLine("Cho = {0}", Dy / D);
            Console.ReadLine();
        }
    }
}
