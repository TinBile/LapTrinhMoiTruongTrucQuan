using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhTongSoChuoi
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, n;
            Console.Clear();
            Console.WriteLine("----------------Tinh tong so chuoi----------------");
            Console.Write("nhap x : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap n : ");
            n = Convert.ToInt32(Console.ReadLine());

            double sum = 0;
            for (int i = 1; i <= x; i++)
            {
                n = n * i;
                for (int j = 1; j <= n; j++)
                {
                    sum += Math.Pow(x, i) / n;
                }
            }
            Console.WriteLine("S({0},{1}) ={2}", x, n, sum);
            Console.ReadLine();
        }
    }
}
