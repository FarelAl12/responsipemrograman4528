using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4528
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan k1 = new Karyawan("18112357", "anto", 3000000);
            Tampil(k1);
            Karyawan k2 = new Karyawan("18112234", "adi", 2000000);
            Tampil(k2);

            Console.WriteLine("\nHoree gaji saya naik 10%\n");
            Tampil2(k1);
            Tampil2(k2);

            Console.ReadKey();
        }
        static void Tampil(Karyawan k)
        {
            if (k.Nama == "Farel")
            {
                Console.WriteLine("No.   NIK/Nama             Gaji Bulanan");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("1.    {0}/{1}          {2}", k.NIK, k.Nama, k.gajiBulanan);
            }
            else
            {
                Console.WriteLine("2.    {0}/{1}         {2}", k.NIK, k.Nama, k.gajiBulanan);
            }
        }
        static void Tampil2(Karyawan i)
        {
            int naik, total;
            naik = (10 * i.gajiBulanan) / 100;
            total = i.gajiBulanan + naik;
            if (i.Nama == "Farel")
            {
                Console.WriteLine("No.   NIK/Nama             Gaji Bulanan");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("1.    {0}/{1}          {2}", i.NIK, i.Nama, total);
            }
            else
            {
                Console.WriteLine("2.    {0}/{1}         {2}", i.NIK, i.Nama, total);
            }
        }
    }
}