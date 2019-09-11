using System;

namespace QUIZ09092019
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HELLO!");

            BangunDatar kelas = new BangunDatar();
             kelas.Persegi();
             kelas.Luas_Segitiga();
             kelas.Lingkaran();


            BangunRuang kelas2 = new BangunRuang();
             kelas2.Volume_Balok();
             kelas2.Volume_Kubus();
            Console.WriteLine("@COPYRIGHT ALIAU :)!");

            
        }
    }
}
