using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongTrinhBac2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            double delta = 0;
            Console.Clear();
            Console.WriteLine("--------------- Phuong Trinh bac 2--------------");
            Console.Write("{0}", "Nhap so a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhao so b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("nhap so  c: ");
            c = Convert.ToDouble(Console.ReadLine());

            if (a == 0)
            {
                if (b != 0)
                {
                    Console.WriteLine("Phuong trinh co 1 nghiem: x = " + (-b / a));
                }
                else if (b == 0 && c == 0)
                {
                    Console.WriteLine("Phuong trinh vo so nghiem");
                }
                else
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
            }
            else
            {
                delta = Math.Pow(b, 2) - 4 * a * c;
                if (delta < 0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
                else if (delta == 0)
                {
                    Console.WriteLine("Phuong trinh co 1 nghiem kep x1=x2 = " + (-b / (2 * a)));
                }
                else
                {
                    Console.WriteLine("Co 2 nghiem phan biet : ");
                    Console.WriteLine("x1 = " + (-b + Math.Sqrt(delta)) / (2 * a));
                    Console.WriteLine("x2 = " + (-b - Math.Sqrt(delta)) / (2 * a));

                }
            }
            Console.ReadLine();
        }
    }
}
