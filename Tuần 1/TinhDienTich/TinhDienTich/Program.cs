using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhDienTich
{
    class Program
    {
        static void Main(string[] args)
        {
            int dai, rong, dientich = 0, chuvi = 0;
            Console.Clear();
            Console.WriteLine("********** TinhDienTich va ChuVI **********");
            Console.Write("nhap so thu 1: ");
            dai = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap so thu 2: ");
            rong = Convert.ToInt32(Console.ReadLine());
            dientich = dai * rong;
            chuvi = (dai + rong) * 2;
            Console.WriteLine("Chuvi: " + chuvi);
            Console.WriteLine("DienTich: " + dientich);
            Console.ReadLine();
        }
    }
}
