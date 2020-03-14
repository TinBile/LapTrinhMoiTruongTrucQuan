using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongTrinhBac1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Clear();
            Console.WriteLine("==========Phuong Trinh bac 1 =========");

            Console.Write("{0}", "Nhap so  a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so  b: ");
            b = Convert.ToInt32(Console.ReadLine());

            if (a != 0)
            {
                Console.WriteLine("Phuong trinh co 1 nghiem: x = " + (-b / a));
                Console.ReadLine();
            }
            else if (a == 0 && b == 0)
            {
                Console.WriteLine("Phuong trinh vo so nghiem");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Phuong trinh vo nghiem");
                Console.ReadLine();
            }

        }
    }
}
