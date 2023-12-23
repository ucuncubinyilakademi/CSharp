using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  ************** OPERATORLER ********************
             
             * Aritmatik Operatorler(+,-,*,/,%)  
             
            int s1 = 5;
            int s2 = 3;

            Console.WriteLine(s1+s2);
            Console.WriteLine(s1-s2);
            Console.WriteLine(s1*s2);
            */
            //Bölme

            //int s1 = 5;
            //int s2 = 2;

            //double sonuc = s1 / s2;
            //Console.WriteLine(s1/s2); // değerlerden biri bile double tanımlı ise ondalıklı cevap döner.

            // Mod Alma: bir sayının diğer sayıya bölümünden kalanı gösterir.

            //int s1 = 10;
            //int s2 = 3;

            //Console.WriteLine(s1 % s2);





            //int i = 3 * 5 / 7;
            //int i = 3 * (5 / 7);
            //int i = 5 % 2;

            //float i = 5 / 2f;
            //float i = 2 / 5 / 2f;
            //float i = 2f / 5 / 2;
            //Console.WriteLine(i);


            //*Bir Arttırma Bir Azaltma Operatörü

            //int sayi = 5;

            //sayi++; //sayi = sayi + 1;  // sayi+=1;
            //sayi--; //sayi = sayi - 1;  // sayi-=1;


            //** KARŞILAŞTIRMA OPERATORLERİ
            /*
            >   5>3
            <   5<3
            >=  5>=3
            <=  5<=3
            ==  5==3
            !=  5!=3
             
             */




            // * MANTIKSAL OPERATORLER (VE,VEYA,DEĞİL)

            // AND(&&) : bir fazla karşılaştırma yapılması ve her durumun true olması grekliyse AND operatörü kullanılır.


            // 5-10 arasında sayı giriniz
            //double sayi = 8.5;

            //bool cevap = sayi >= 5 && sayi < 11;

            //Console.WriteLine(cevap);


            //string username = "altanemre";
            //string password = "1";


            //Console.WriteLine("Kullanıcı adı:");
            //string kullaniciadi = Console.ReadLine();

            //Console.WriteLine("Şifre:");
            //string sifre = Console.ReadLine();


            //Console.WriteLine(username==kullaniciadi && password==sifre);



            // OR(||) : bir fazla karşılaştırma yapılması ve herhangi bir durumun true olması yeterliyse OR operatörü kullanılır.

            //string email = "altanemre@gmail.com";
            //string phone = "5366295131";

            //string password = "1";


            //Console.WriteLine("Email/Phone:");
            //string data = Console.ReadLine();

            //Console.WriteLine("Password:");
            //string sifre = Console.ReadLine();


            //bool cevap = (data == email || data == phone) && password == sifre;


            //Console.WriteLine(cevap);


            // NOT(!): Bool değeri tersine çeviri. True => False  False => True

            //bool cevap = 5 > 3;

            //Console.WriteLine(!cevap);


            // * İşlemli Atama Operatörleri

            //int a = 5;
            //int b = 6;

            //a = a + b;


            //int sayi = 5;

            //sayi += 3; // sayi = sayi+3;

            /*
             a=a+b     a+=b
             a=a-b     a-=b
             a=a*b     a*=b
             a=a/b     a/=b
             a=a%b     a%=b
             
             */


            // * Kıyas Operatörü

            //int a = 5;

            //Console.WriteLine(a > 6 ? "Büyük" : "Küçük");


            //int s1 = 7;
            //int s2 = 6;

            //int Buyuk = s1 > s2 ? s1 : s2;


            //Console.WriteLine(Buyuk);


            //*  Concat Operatorü(+)

            //string ad = "Altan Emre";
            //string soyad = "Demirci";
            //int yas = 34;


            //string adSoyad = ad +" "+ soyad;

            //Console.WriteLine(adSoyad);

            //Console.WriteLine(ad + yas);



            // * Erişim Operatörü(.)

            //Console.ReadLine().ToString();


            Console.WriteLine("İLKİM");

            Console.ReadLine();
        }
    }
}
