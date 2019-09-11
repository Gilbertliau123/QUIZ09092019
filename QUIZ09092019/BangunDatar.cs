using System;

namespace QUIZ09092019
{
    public class BangunDatar
    {
        
        public void Luas_Segitiga()
        {
                Console.WriteLine("*****************************");
            Console.WriteLine("Membuat Luas Segitiga");
            Console.WriteLine("-----------------------");

            int alas, tinggi, luas;
            Console.WriteLine("Alas = ");
            alas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Tinggi = ");
            tinggi = Convert.ToInt32(Console.ReadLine());

            luas =  alas * tinggi / 2;

            Console.WriteLine("Luas Segitiga adalah "+luas);
        }
            public void Persegi()
        {
                Console.WriteLine("*****************************");
            Console.WriteLine("Membuat Luas Persegi");
            Console.WriteLine("-----------------------");

            int sisi, luas2;
            Console.WriteLine("Sisi = ");
            sisi = Convert.ToInt32(Console.ReadLine());
       
            luas2 =  sisi * sisi;

            Console.WriteLine("Luas Persegi adalah "+luas2);
        }

        public void Lingkaran()
        {
                Console.WriteLine("*****************************");
            Console.WriteLine("Membuat Luas Lingkaran");
            Console.WriteLine("-----------------------");

            int radius, luas3;
            Console.WriteLine("Radius = ");
            radius = Convert.ToInt32(Console.ReadLine());
       
            luas3 =  22 * radius * radius / 7;

            Console.WriteLine("Luas Lingkaran adalah "+luas3);
        }
    }
}