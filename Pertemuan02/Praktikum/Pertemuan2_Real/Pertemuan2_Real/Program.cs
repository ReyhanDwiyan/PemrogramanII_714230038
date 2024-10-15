using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace latihan_projek_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello adul");
            Console.WriteLine("test");

            Console.WriteLine("hello " + "ULBI");*/
            /*
                        string alamat;
                        int umur;
                        double beratBadan;
                        bool isMenikah;

                        alamat = "Jalan Sariasih No.54";
                        umur = 20;
                        beratBadan = 49.5;
                        isMenikah = false;

                        string nama = "ULBI";
                        int angkatan = 2022;
                        float nilaiAkademis = 3.84f;

                        Console.WriteLine("Alamatnya di " + alamat + " " + umur);
                        Console.WriteLine("berat badannya " + beratBadan + "KG");*/

            /*var nama = "ULBI";
            var umur = 18;
            var nilai = 90.5;

            Console.WriteLine(nilai.GetType());*/

            //string text = "Hello dul";
            //Console.WriteLine("panjang variable text adalah : " + text.Length);
            //Console.WriteLine(text.ToLower());
            //Console.WriteLine(text.ToUpper());

            /* string firstname = "John";
             string lastname = "Doe";
             string name = firstname + " " + lastname;
             string fullname  = string.Concat(firstname, lastname);
             Console.WriteLine(fullname);

             string nama = $"nama lengkap saya adalah {firstname} {lastname}"; 
             Console.WriteLine(nama);

             string namaLengkap = string.Format("nama saya {0} {1}", firstname, lastname);
             Console.WriteLine(namaLengkap);
             Console.WriteLine();

             string myString = "Hello";
             Console.WriteLine(myString[3]);*/
            /*String input;
            Console.WriteLine("=== PERCOBAAN SINTAKS INPUT ===");
            Console.Write("Masukan nama anda : ");
            input = Console.ReadLine();
            //*Console.WriteLine($"hi, {input} selamat sore ");//*
            Console.WriteLine("hi, {0} selamat sore sayang", input);*/

            //int myint = 9;
            //double myDouble = myint;


            //Console.WriteLine(myDouble);
            //Console.WriteLine(myDouble.GetType());

            //double myDouble2 = 74.3;
            //int myInt2 = (int)myDouble2;

            //Console.WriteLine(myDouble2.GetType());
            //Console.WriteLine(myInt2.GetType());



            Console.Write("Angka pertama: ");
            double input1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Angka kedua: ");
            double input2 = Convert.ToDouble(Console.ReadLine());

            double penambahan;
            double pengurangan;
            double perkalian;
            double pembagian;

            penambahan = input1 + input2;
            pengurangan = input1 - input2;
            perkalian = input1 * input2;
            pembagian = input1 / input2;

            Console.WriteLine($" {input1} + {input2} = {penambahan}");
            Console.WriteLine($" {input1} - {input2} = {pengurangan}");
            Console.WriteLine($" {input1} x {input2} = {perkalian}");
            Console.WriteLine($" {input1} / {input2} = {pembagian}");
            //Console.WriteLine(Convert.ToInt32(input2));

            //double hasil;
            //hasil = Convert.ToDouble(Console.ReadLine());








        }
    }
}