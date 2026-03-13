using System;

namespace Praktikum3
{
    // Parent Class (Base Class)
    public class Manusia
    {
        public string Nama;

        // Constructor
        public Manusia() { }

        // Constructor dengan parameter
        public Manusia(string nama)
        {
            this.Nama = nama;
        }

        public void Perkenalan()
        {
            Console.WriteLine($"Halo, nama saya adalah {Nama}.");
        }
    }

    // 1. Child Class - Tanpa Constructor
    public class Karyawan : Manusia
    {
        public string Pekerjaan;

        public void InfoKaryawan()
        {
            Console.WriteLine($"Saya bekerja sebagai {Pekerjaan}.");
        }
    }

    // 2. Child Class - Dengan Constructor (Menggunakan base)
    public class Siswa : Manusia
    {
        public string Sekolah;

        // Memanggil constructor parent menggunakan 'base'
        public Siswa(string nama, string sekolah) : base(nama)
        {
            this.Sekolah = sekolah;
        }

        public void InfoSiswa()
        {
            Console.WriteLine($"Saya bersekolah di {Sekolah}.");
        }
    }

    class Program
    {
        static void Main()
        {
            // Skenario 1: Tanpa Constructor
            Karyawan karyawan1 = new Karyawan();
            karyawan1.Nama = "Budi"; // Atribut warisan dari class Manusia
            karyawan1.Pekerjaan = "Developer";

            Console.WriteLine("--- Data Karyawan ---");
            karyawan1.Perkenalan();
            karyawan1.InfoKaryawan();
            Console.WriteLine();

            Siswa siswa1 = new Siswa("Andi", "SMA Negeri 1");

            Console.WriteLine("--- Data Siswa ---");
            siswa1.Perkenalan(); // Method warisan dari class Manusia
            siswa1.InfoSiswa();

            Console.ReadLine();
        }
    }
}