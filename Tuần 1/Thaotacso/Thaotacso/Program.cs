using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thaotacso
{
    class Program
    {
        static void Main(string[] args)
        {
            int nSo1, nSo2, nTong, nTru = 0, nNhan = 0, nChia = 0;
            Console.Clear();
            Console.Write("{0}", "Nhap so thu 1: ");
            nSo1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap so thu 2: ");
            nSo2 = Convert.ToInt32(Console.ReadLine());
            nTong = nSo1 + nSo2;
            nTru = nSo1 - nSo2;
            nNhan = nSo1 * nSo2;
            nChia = nSo1 / nSo2;

            Console.WriteLine("Tong cua " + nSo1 + " va " + nSo2 + " la: " + nTong);
            Console.WriteLine("Hieu cua " + nSo1 + " va " + nSo2 + " la: " + nTru);
            Console.WriteLine("Tich cua " + nSo1 + " va " + nSo2 + " la: " + nNhan);
            Console.WriteLine("Thuong cua " + nSo1 + " va " + nSo2 + " la: " + nChia);
            Console.ReadLine();
        }
    }
}
