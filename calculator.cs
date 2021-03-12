using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Kalkulator";
            //int a = 10; //deklarasi var a
            //int b = 6; //deklarasi var b
            Console.Write("Input Nilai a =");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Input Nilai b =");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Hasil Penambahan " + a + " + " + b + "=" + penambahan(a, b));
            Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, pengurangan(a, b));
            Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, perkalian(a, b));
            Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, pembagian(a, b));

            Console.WriteLine("\nTekan Sembarang Tombol untuk Keluar");
            Console.ReadKey();
        }
        static int penambahan(int a, int b)
        {
            return a + b;
        }
        static int pengurangan(int a, int b)
        {
            return a - b;
        }
        static int perkalian(int a, int b)
        {
            return a * b;
        }
        static int pembagian(int a, int b)
        {
            return a / b;
        }
    }
}
