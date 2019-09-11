using System;

namespace QUIZ09092019
{
    public class BangunRuang
    {
        
            public void Volume_Balok()
        {   
                Console.WriteLine("//////////////////////////////////");
            Console.WriteLine("Menghitung Volume Balok");
            Console.WriteLine("-------------------------------");

            int panjang, lebar, tinggi, volume;
            Console.WriteLine("Panjang = ");
            panjang = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Lebar = ");
            lebar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Tinggi = ");
            tinggi = Convert.ToInt32(Console.ReadLine()); 

                volume = panjang * lebar * tinggi;
        
            Console.WriteLine("Volume Balok adalah " +volume);

        }

            public void Volume_Kubus()
            {
            Console.WriteLine("//////////////////////////////////");
            Console.WriteLine("Menghitung Volume Kubus");
            Console.WriteLine("-------------------------------");

            int sisi, volume2;
            Console.WriteLine("Sisi = ");
            sisi = Convert.ToInt32(Console.ReadLine());

                volume2 = sisi * sisi * sisi;

            Console.WriteLine("Volume Kubus adalah " +volume2);
            
        }
    }
}
