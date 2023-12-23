using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace _04_TurDonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("1.kardeş yaşı");
            //int yas1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("2.kardeş yaşı");
            //int yas2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(yas1+yas2);

            /*
            
             Uygulama içerisinde tanımladığımız değişkenlerimizin başka veri tiplerine dönüştürme işlemlerine tür dönüşümü denir.
            1-Bilinçsiz (Implicit) Tür Dönüşümü
            2-Bilinçli (Explicit) Tür Dönüşümü
            3-Boxing
            4-UnBoxing
            


            // 1-Bilinçsiz (Implicit) Tür Dönüşümü
             */
            //int sayi = 1;
            //decimal sayi2 = sayi;

            //// BÜYÜK => küçük HATA
            decimal s = 12345679;
            int s2 = (int)s;


            //2-Bilinçli (Explicit) Tür Dönüşümü

            //decimal sayi = 12;
            //int sayi2 = (int)sayi; // Boxing


            //Console.WriteLine("Yaş:");
            //string yas = Console.ReadLine();

            //int y = Convert.ToInt32(yas);
            //Console.WriteLine(y+10);



            // İki kardeşin yaşını alıp toplayınız.

            //Console.WriteLine("1. kardeşin Yaşı:");
            //int yas = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("2. kardeşin Yaşı:");
            //int yas2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(yas+yas2);




            // INTEGER TO STRING

            //int tc = 152132312;
            //int tc2 = 141231232;

            //Console.WriteLine(tc.ToString() + tc2.ToString());



            Console.ReadLine();

        }
    }
}
