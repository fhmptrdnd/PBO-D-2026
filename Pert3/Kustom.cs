//using System;

//namespace Kustom
//{
//    public class Merk
//    {
//        public string Brand;

//        public void Merknya()
//        {
//            Console.WriteLine($"Merknya adalah {Brand}.");
//        }
//    }

//    public class Jenis : Merk
//    {
//        public string Type;

//        public void Tipenya()
//        {
//            Console.WriteLine($"Tipenya adalah {Type}.");
//        }
//    }

//    public class Kecepatan : Jenis
//    {
//        public int Speed;

//        public void Kecepatannya()
//        {
//            Console.WriteLine($"Kecepatannya adalah {Speed} Km/h");
//        }
//    }

//    public class Kendaraan : Kecepatan
//    {
//        public string Apa;

//        public void InfoKendaraan()
//        {
//            Console.WriteLine($"Ada sebuah {Apa}.");
//        }
//    }

//    class Program
//    {
//        public static void Main()
//        {
//            Kendaraan Mobil = new Kendaraan();
//            Mobil.Apa = "Mobil";
//            Mobil.Speed = 340;
//            Mobil.Brand = "Ferrari";
//            Mobil.Type = "Hypercar";

//            Mobil.InfoKendaraan();
//            Mobil.Merknya();
//            Mobil.Tipenya();
//            Mobil.Kecepatannya();
//        }
//    }
//}