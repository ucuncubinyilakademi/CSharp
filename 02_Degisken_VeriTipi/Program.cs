using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _02_Degisken_VeriTipi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bütün yazılım dillerin KÜÇÜK HARF BÜYÜK HARF duyarlılığı vardır.


            /*  ******** DEĞİŞKENLER(VARIABLES) VE VERİTİPLERİ(DATATYPE) ********
             Proje içerisinde tanımlı, dışarıdan alınacak veya bir işlem sonucunu ortaya çıkan verileri tutmak için değişkenler kullanılır. Değişkenler TEK DATA tutabilirler.

            Değişkenler isimlendirilirken her isim bir defa tanımlanabilir.

            Ad=altan
            ad=emre

            sayi1=12
            sayi2=13

            sayi1+sayi2 => 12+13=25


            Değişken İsimlendirme Kuralları(Case_sensitive)
            yanlışlar: 2sayi, ?sayi, isim?soyisim, sayi?, yas2lar, ad soyad
            doğrular:  sayi3, _sayi, isim_soyisim, sayi_, adsoyad 

            ** Özel karakter olarak _ alt çizgi her yazılım dilinde kabul edilen tek özel karakterdir.


            //DEĞİŞKEN TANIMLAMA

            veritipi degiskenAdi = data;


            ******* VERİ TİPLERİ ********
            SAYISAL VERİ TİPLERİ(INTEGER): byte,sbyte,short,ushort,int,uint,long,ulong
                int: 10 basamağa kadar +/- tam sayıları tanımlar.
                        int sayi=5;
                double: Ondalıklı sayıları tanımlar.
                        double sayi = 15.5;
                decimal: Her sayıyı kapsar.
                        decimal sayi = 12.5m;

            SÖZEL VERİ TİPLERİ(STRING):
                char: tek bir karakter tutar. ' tek tırnak ile tanımlanır.
                        char sayi = '5';
                        char harf = 'A';
                        char krk = '?';

                string: Ram bellek boyutu kadar karakter alabilir. " çift tırnak ile tanımlanır.  
                        string ad="altan emre demirci";
                        string yas ="10";


            MANTIKSAL VERİ TİPİ(BOOLEAN):
                bool: bir karşılaştırma sonucunda doğru(true) veya yanlış(false) blgisini tutar.
                      bool cevap = 5 < 3;


            */

            //long sayi = 12345678901;

            //double sayi = 15.5;
            //float sayi = 15.5f;

            //decimal sayi = 12.5m;

            //char sayi = '5';
            //char harf = 'A';
            //char krk = '?';

            //string harf = "A";

            //string isim = "Altan Emre Demirci";

            //string metin = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam eget neque a purus blandit lobortis at non sapien. Aenean bibendum nibh massa, eu iaculis augue sagittis a. Suspendisse eu orci in nisi mollis porta vel et quam. Proin et convallis nisi.";


            //bool cevap= 5 < 3;

            //Console.WriteLine(cevap);

            // İki yaş datası tanımlayınız ve tanımlanan yaşları toplayarak ekrana yazdırınız.

            //int yas = 33;

            //int yas2 = 25;

            //int toplam = yas + yas2;

            //Console.WriteLine(toplam);


            //int sayi = 5;

            //sayi = sayi + 7;


            // ********* SCOPE (KAPSAMA ALANI) *************

            //{
            //    int a = 5;
            //    {
            //        //int a = 10;
            //        Console.WriteLine(a);
            //    }
            //    {
            //        //int a = 10;
            //    }

            //}


            //{

            //    {
            //        int a = 5;
            //    }

            //    Console.WriteLine(a); // Error: Scope dışında
            //}

            //{
            //    int a;
            //    {
            //        long a; // Error: Tekrar tanımlama
            //    }
            //}

            //{
            //    {
            //        int a;
            //    }
            //    {
            //        long a;
            //    }
            //}


            // SABİT DEĞİŞKEN TANIMLAMA
            //const double pi = 3.14;
            //pi = 3;




            //int s1, s2; // int s1; int s2;

            //int sayi1; string ad; // Hatalı farklı tipdeki değişken tanımları ; olmadan yapılamaz.


            // + operatoru sayisal(integer) değerlerde toplama(sum), sözel(string) değerlerde birleştirme(concat) yapar.
            //string a = "1", b = "2";
            //string c = a + b;
            //Console.WriteLine(c);


            string _isim = "ilkim";

            Console.WriteLine(_isim);

         
           




            Console.ReadLine();
        }
    }
}
