//using System;

//class Rumah
//{
//    // Properties / Attributes
//    string warna = "Putih";
//    int jumlahKamar;
//    int jumlahLantai;

//    // Konstruktor 
//    public Rumah(int jumlahKamarInput, int jumlahLantaiInput)
//    {
//        jumlahKamar = jumlahKamarInput;
//        jumlahLantai = jumlahLantaiInput;
//    }

//    public void TampilkanInfoRumah()
//    {
//        Console.WriteLine($"Rumah aku punya warna {warna} kamar {jumlahKamar} dan lantainya ada {jumlahLantai}.");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Rumah rumahsaya = new Rumah(2, 3);
//        Rumah rumahsaja = new Rumah(3, 2);
//        rumahsaya.TampilkanInfoRumah();
//    }
//}

////using System;

////namespace Praktikum2
////{
////    // Definisi Class
////    class Rumah
////    {
////        // Atribut (Fields)
////        public string warna;
////        public int jumlahKamar;

////        // Method
////        public static void TampilkanInformasi()
////        {
////            Console.WriteLine($"Rumah ini berwarna {warna} dan memiliki {jumlahKamar} kamar.");
////        }
////    }

////    class Program
////    {
////        static void Main(string[] args)
////        {
////            // Instansiasi Objek (Membuat object dari class)
////            Rumah rumahSaya = new Rumah();

////            // Memberikan nilai ke atribut
////            rumahSaya.warna = "Putih";
////            rumahSaya.jumlahKamar = 3;

////            // Memanggil method
////            rumahSaya.TampilkanInformasi();
////        }
////    }
////}