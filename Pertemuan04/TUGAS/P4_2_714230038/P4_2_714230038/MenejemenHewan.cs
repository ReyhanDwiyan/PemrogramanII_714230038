using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714230038
{
    // Abstraction
    abstract class Hewan
    {
        // Encapsulation: Fields dengan property
        public string Nama { get; set; }
        public int Umur { get; set; }

        // Constructor
        public Hewan(string nama, int umur)
        {
            Nama = nama;
            Umur = umur;
        }

        // Metode abstrak
        public abstract void Makan();

        // Metode untuk menampilkan informasi hewan
        public void TampilkanInfo()
        {
            Console.WriteLine($"Nama: {Nama}, Umur: {Umur} tahun");
        }
    }

    // Inheritance dan Polymorphism
    class Karnivora : Hewan
    {
        public Karnivora(string nama, int umur) : base(nama, umur) { }

        // Polymorphism: Implementasi metode Makan khusus untuk Karnivora
        public override void Makan()
        {
            Console.WriteLine($"{Nama} adalah karnivora dan memakan daging.");
        }
    }

    class Herbivora : Hewan
    {
        public Herbivora(string nama, int umur) : base(nama, umur) { }

        // Polymorphism: Implementasi metode Makan khusus untuk Herbivora
        public override void Makan()
        {
            Console.WriteLine($"{Nama} adalah herbivora dan memakan tumbuhan.");
        }
    }

    class Omnivora : Hewan
    {
        public Omnivora(string nama, int umur) : base(nama, umur) { }

        // Polymorphism: Implementasi metode Makan khusus untuk Omnivora
        public override void Makan()
        {
            Console.WriteLine($"{Nama} adalah omnivora dan memakan daging dan tumbuhan.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Membuat daftar hewan
            List<Hewan> hewanKebunBinatang = new List<Hewan>
        {
            new Karnivora("Singa", 5),
            new Herbivora("Kelinci", 2),
            new Omnivora("Beruang", 7)
        };

            bool cariLagi = true;

            while (cariLagi)
            {
                // Meminta input nama hewan dari pengguna
                Console.WriteLine("Masukkan nama hewan yang ingin Anda cari: ");
                string namaHewan = Console.ReadLine();

                // Mencari hewan berdasarkan nama yang diinput
                Hewan hewanDitemukan = hewanKebunBinatang.Find(h => h.Nama.Equals(namaHewan, StringComparison.OrdinalIgnoreCase));

                // Menampilkan informasi hewan jika ditemukan
                if (hewanDitemukan != null)
                {
                    hewanDitemukan.TampilkanInfo();
                    hewanDitemukan.Makan();
                }
                else
                {
                    Console.WriteLine($"Hewan dengan nama '{namaHewan}' tidak ditemukan di kebun binatang.");
                }

                // Tanya apakah pengguna ingin mencari hewan lain
                Console.WriteLine("\nApakah Anda ingin mencari data hewan lain? (Y/N)");
                string jawaban = Console.ReadLine();

                if (jawaban.Equals("Y", StringComparison.OrdinalIgnoreCase))
                {
                    cariLagi = true;
                }
                else
                {
                    cariLagi = false;
                }
            }

            // Menutup program
            Console.WriteLine("Terima kasih telah menggunakan program ini. Tekan Enter untuk keluar...");
            Console.ReadLine();
        }
    }

}
