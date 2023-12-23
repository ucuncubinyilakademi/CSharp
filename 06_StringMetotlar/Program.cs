using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_StringMetotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*

            //CONCAT
            string ad = "Altan";
            string soyad = "Demirci";

            Console.WriteLine(ad + soyad);
            Console.WriteLine(string.Concat(ad, soyad));


            //LENGTH
            int uzunluk = ad.Length;
            Console.WriteLine(ad.Length);
           

            //INDEX OF

            string adsoyad = "Altan Emre Demirci";

            //int indexNumarasi = adsoyad.IndexOf('A');


            //LAST INDEX OF
            //int indexNumarasi = adsoyad.LastIndexOf('i'); 
            //Console.WriteLine(indexNumarasi);
          

            // STARTWITH
            string adsoyad = " Altan Emre Demirci";

            Console.WriteLine(adsoyad.StartsWith(" Alt"));

            // ENDSWITH
            Console.WriteLine(adsoyad.EndsWith("rci"));
             */


            // TOUPPER()  TOLOWER()

            //string ad = "Kübra";

            //Console.WriteLine(ad.ToUpper());

            //ad = ad.ToUpper();
            //Console.WriteLine(ad);

            //string soyad = "KarAdaĞ";

            //Console.WriteLine(soyad.ToLower().ToUpper().Replace('A','E'));


            //Console.WriteLine("Meyve mi Sebze mi? M/S");
            //string secim = Console.ReadLine().ToUpper();


            //Console.WriteLine(secim);
            //Console.WriteLine(secim=="M" ? "Meyve":"seçim hatalı" );



            //SUBSTRING

            //string ad = "altan emre demirci";

            //Console.WriteLine(ad.Substring(2)); // kesmeye başlanacak index
            
            //Console.WriteLine(ad.Substring(2, 5));



            //Console.WriteLine("Kullanıcı Adı:");
            //string username = Console.ReadLine();

            //Console.WriteLine(username[0].ToString().ToUpper() + username.Substring(1));

            /*

                    // REMOVE 

                    string ad = "Altan";

                    Console.WriteLine(ad.Remove(2));
                    Console.WriteLine(ad.Remove(2,1));
                    */


            // INSERT

            string ad = "Altan";

            Console.WriteLine(ad.Insert(0, "Emre"));


            // REPLACE
            //string ad = "Altan emre ders anlatır. Altan ders anlatırken.";

            //ad = ad.Replace("Altan", "Emre");

            //Console.WriteLine(ad);
            Console.ReadLine();
        }
    }
}
