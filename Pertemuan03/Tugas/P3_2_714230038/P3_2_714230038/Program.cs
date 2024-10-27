using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_2_714230027
{
    internal class Program
    {
        static void HitungLuas()
        {
            Console.Write("Masukkan panjang dalam cm: ");
            double panjang = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan lebar dalam cm: ");
            double lebar = Convert.ToDouble(Console.ReadLine());

            double luas = panjang * lebar;
            Console.WriteLine($"Luas Persegi Panjang: {luas} cm²");
        }

        static void HitungKeliling()
        {
            Console.Write("Masukkan panjang dalam cm: ");
            double panjang = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan lebar dalam cm: ");
            double lebar = Convert.ToDouble(Console.ReadLine());

            double keliling = 2 * (panjang + lebar);
            Console.WriteLine($"Keliling Persegi Panjang: {keliling} cm");
        }

        static void Main(string[] args)
        {
            bool loop = true;

            while (loop)
            {
                Console.WriteLine("--- MENU PERSEGI PANJANG ---");
                Console.WriteLine("1. Hitung Luas");
                Console.WriteLine("2. Hitung Keliling");
                Console.WriteLine("3. Keluar");
                Console.Write("Pilih menu: ");

                string pilih = Console.ReadLine();

                switch (pilih)
                {
                    case "1":
                        HitungLuas();
                        break;
                    case "2":
                        HitungKeliling();
                        break;
                    case "3":
                        loop = false;
                        Console.WriteLine("Terima kasih!");
                        break;
                    default:
                        Console.WriteLine("Pilih Menu Yang Tertera");
                        break;
                }

                if (loop)
                {
                    Console.Write("\nIngin mengulang kembali (Y/T)? ");
                    string jawab = Console.ReadLine().ToUpper();
                    loop = (jawab == "Y");
                }
            }

        }

        
    }
}