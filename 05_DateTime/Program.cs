using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //DateTime tarih = DateTime.Now;

            //Console.WriteLine(tarih);
            //Console.WriteLine(tarih.Year);
            //Console.WriteLine(tarih.Month);
            //Console.WriteLine(tarih.Day);
            //Console.WriteLine(tarih.Hour);
            //Console.WriteLine(tarih.Minute);
            //Console.WriteLine(tarih.Second);


            //int gun = tarih.Day;
            //int ay = tarih.Month;


            Console.WriteLine(DateTime.Now.ToString("MM")); //11
            Console.WriteLine(DateTime.Now.ToString("MMM")); //KAS
            Console.WriteLine(DateTime.Now.ToString("MMMM")); //KASIM


            Console.WriteLine(DateTime.Now.ToString("dd")); //12
            Console.WriteLine(DateTime.Now.ToString("ddd")); //Paz
            Console.WriteLine(DateTime.Now.ToString("dddd")); //Pazar


            //string ad = "  ALTAN    ";

            //Console.WriteLine(ad);
            //Console.WriteLine(ad.Trim());
            //Console.WriteLine(ad.TrimStart());
            //Console.WriteLine(ad.TrimEnd());



            //string ad = "Altan";
            //Console.WriteLine(ad.TrimStart('A'));
            //Console.WriteLine(ad.TrimEnd('A'));

            //string soyad = "ayla";

            //Console.WriteLine(soyad.Trim('a'));
            //Console.WriteLine(soyad.TrimStart('a'));
            //Console.WriteLine(soyad.TrimEnd('a'));






            Console.ReadLine();
        }
    }
}
