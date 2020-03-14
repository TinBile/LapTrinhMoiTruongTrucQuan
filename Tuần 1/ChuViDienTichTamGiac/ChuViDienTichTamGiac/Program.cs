using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuViDienTichTamGiac
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int a, b, c;
                Console.Clear();
                Console.WriteLine("^^^^^^^ Tinh V & S cua Tam Giac ^^^^^^^^");
                Console.Write("nhap a: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("nhap b: ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.Write("nhap c: ");
                c = Convert.ToInt32(Console.ReadLine());
                int cv = a + b + c;
                float p = cv / 2;
                float d = (p * (p - a) * (p - b) * (p - c));
                double dt = Math.Sqrt(d);
                if (a + b > c || a + c > b || b + c > a)
                {
                    Console.WriteLine("Chu Vi la:" + cv);
                    Console.WriteLine("dien tich la: " + dt);
                }
                else
                {
                    Console.WriteLine("khong phai la tam giac ");
                }
                Console.ReadLine();
            }
        }
    }
}
