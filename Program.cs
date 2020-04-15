using System;

namespace ResponsiPemrogramman2907
{
    public class Program
    {
        static void Main(string[] args)
        {
            Karyawan saya = new Karyawan(01, 91760459, "Leon", 700000);
            Karyawan kamu = new Karyawan(02, 91824580, "Villa", 500000);

            Console.WriteLine("No \tNik \t \t Nama \t Gaji Bulanan");
            Console.WriteLine("-------------------------------------");
            saya.Data();
            kamu.Data();

            Console.WriteLine("\n\n Selamat... gaji naik sebesar 10%\n\n");

            Console.WriteLine("No \t Nik \t \t Nama \t Gaji Bulanan");
            Console.WriteLine("--------------------------------------");
            saya.Naikgaji();
            kamu.Naikgaji();

            Console.ReadKey();
        }
    }
}

