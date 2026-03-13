//using System;

//namespace Kustom2
//{
//    public class Kendaraan
//    {
//        public string Type;
//        public Kendaraan() { }
//        public Kendaraan(string type) { this.Type = type; }
//    }

//    public class Merk : Kendaraan
//    {
//        public string Brand;
//        public Merk() { }
//        public Merk(string type, string brand) : base(type)
//        {
//            this.Brand = brand;
//        }
//    }

//    public class Kecepatan : Merk
//    {
//        public int Speed;

//        public Kecepatan() { }
//        public Kecepatan(int speed)
//        {
//            this.Speed = speed;
//        }
//    }

//    public class Variant : Kecepatan
//    {
//        public string Name;
//        public void TampilkanInfo()
//        {
//            Console.WriteLine($"Mobil {Brand} {Name} berjenis {Type} dengan top speed {Speed} km/jam.");
//        }
//    }

//    class Program
//    {
//        public static void Main()
//        {
//            Variant Ferrari = new Variant();
//            Ferrari.Brand = "Ferrari";
//            Ferrari.Type = "Hypercar";
//            Ferrari.Name = "SF 90 Stradale";
//            Ferrari.Speed = 450;

//            Ferrari.TampilkanInfo();
//        }
//    }
//}