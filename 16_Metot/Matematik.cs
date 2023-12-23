using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Metot
{
    internal class Matematik
    {
        //eğer bir access modifier verilmezse default PRIVATE olur.
        //public void FaktoriyelHesapla()
        //{
        //    Console.WriteLine("sayı:");
        //    int sayi1 = Convert.ToInt32(Console.ReadLine());

        //    int fakt = 1;

        //    while (sayi1 > 0)
        //    {
        //        fakt *= sayi1;
        //        sayi1--;
        //    }

        //    Console.WriteLine("Faktöriyel:" + fakt);
        //}

        internal static void Toplama()
        {
            Console.WriteLine("1.Sayı:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayı:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Toplam:"+(sayi1+sayi2));
        }
        internal static void Cikarma()
        {
            Console.WriteLine("1.Sayı:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayı:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Çıkarma:" + (sayi1 - sayi2));
        }
        internal static void Carpma()
        {
            Console.WriteLine("1.Sayı:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayı:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Çarpma:" + (sayi1 * sayi2));
        }
        internal static void Bolme()
        {
            Console.WriteLine("1.Sayı:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayı:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Bölme:" + (sayi1 / sayi2));
        }




    }
}
