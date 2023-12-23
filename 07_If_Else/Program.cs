using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_If_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* AKIŞ KONTROL - KARAR YAPILARI

            * if else
            * switch case
            * try catch           

            */

            //Console.WriteLine("Meyve M Sebze S");
            //string cevap = Console.ReadLine().ToUpper();

            ////Console.WriteLine(cevap=="M" ? "Meyve" : "Sebze");


            //if (cevap == "M") // true
            //{
            //    Console.WriteLine("Meyve");
            //}
            //else
            //{
            //    Console.WriteLine("Meyve Değildir");
            //}


            // IF - ELSE IF - ELSE

            //Bir kod akışın bazı durumlara göre devam edecek ise karar yapıları kullanılır.


            // Kullanıcıdan alınan sayı 100'den büyük ise ekrana "BÜYÜK", 100'den küçük ise "KÜÇÜK" ve 100'e eşit ise "100" yazdıran koşul yapısı.

            //Console.WriteLine("Sayı giriniz:");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //if (sayi > 100)
            //{
            //    Console.WriteLine("BÜYÜK");
            //}
            //else if (sayi < 100)
            //{
            //    Console.WriteLine("KÜÇÜK");
            //}
            //else
            //{
            //    Console.WriteLine("100");
            //}


            #region Kullancıdan alınan sayı pozitif mü negatif ekrana yazdırınız.
            //Console.WriteLine("Sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //if (sayi > 0)
            //{
            //    Console.WriteLine("Sayı pozitiftir");
            //}

            //else if (sayi == 0)
            //{
            //    Console.WriteLine("Sayı sıfıra eşittir");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı negatiftir");
            //}

            #endregion

            #region  Kullanıcından haftanın kaçıncı gününde olduğumuzun bilgisini alınız ve girilen sayıya göre haftanın gün adını ekrana yazdırınız.

            #region 1.Yol
            //Console.Write("Haftanın kaçıncı günündeyiz? (1-7): ");
            //int gunNumarasi = Convert.ToInt32(Console.ReadLine());

            //if (gunNumarasi == 1)
            //{
            //    Console.WriteLine("Girilen gün, Pazartesi günüdür.");
            //}
            //else if (gunNumarasi == 2)
            //{
            //    Console.WriteLine("Girilen gün, Salı günüdür.");
            //}
            //else if (gunNumarasi == 3)
            //{
            //    Console.WriteLine("Girilen gün, Çarşamba günüdür.");
            //}
            //else if (gunNumarasi == 4)
            //{
            //    Console.WriteLine("Girilen gün, Perşembe günüdür.");
            //}
            //else if (gunNumarasi == 5)
            //{
            //    Console.WriteLine("Girilen gün, Cuma günüdür.");
            //}
            //else if (gunNumarasi == 6)
            //{
            //    Console.WriteLine("Girilen gün, Cumartesi günüdür.");
            //}
            //else if (gunNumarasi == 7)
            //{
            //    Console.WriteLine("Girilen gün, Pazar günüdür.");
            //}
            //else
            //{
            //    Console.WriteLine("Geçersiz gün numarası girdiniz. 1 ile 7 arasında bir sayı giriniz.");
            //}

            #endregion

            #region 2.Yol
            //Console.Write("Haftanın kaçıncı günündeyiz? (1-7): ");
            //int gunNumarasi = Convert.ToInt32(Console.ReadLine());

            //if(gunNumarasi<1 || gunNumarasi > 7)
            //{
            //    Console.WriteLine("Geçersiz gün numarası girdiniz. 1 ile 7 arasında bir sayı giriniz.");
            //}

            //else if (gunNumarasi == 1)
            //{
            //    Console.WriteLine("Girilen gün, Pazartesi günüdür.");
            //}
            //else if (gunNumarasi == 2)
            //{
            //    Console.WriteLine("Girilen gün, Salı günüdür.");
            //}
            //else if (gunNumarasi == 3)
            //{
            //    Console.WriteLine("Girilen gün, Çarşamba günüdür.");
            //}
            //else if (gunNumarasi == 4)
            //{
            //    Console.WriteLine("Girilen gün, Perşembe günüdür.");
            //}
            //else if (gunNumarasi == 5)
            //{
            //    Console.WriteLine("Girilen gün, Cuma günüdür.");
            //}
            //else if (gunNumarasi == 6)
            //{
            //    Console.WriteLine("Girilen gün, Cumartesi günüdür.");
            //}
            //else
            //{
            //    Console.WriteLine("Girilen gün, Pazar günüdür.");
            //}
            #endregion


            #endregion

            #region kullanıcıdan alınacak yaş değerine göre
            /*  
             0-3 arasında ise bebek
             4-10 arasında çocuk
             11-18 ergen
             19-28 genç
             29-35 orta yaş
             36-45 olgun
             46-55 emekli adayı
             56 ve üstü ise emekliliğin tadını çıkarın
             */

            //Console.Write("Yaşınızı girin: ");
            //int yas = Convert.ToInt32(Console.ReadLine());

            //if (yas >= 0 && yas <= 3)
            //{
            //    Console.WriteLine("Bu yaş aralığındaki kişi bir bebektir.");
            //}
            //else if (yas > 3 && yas < 11)
            //{
            //    Console.WriteLine("Bu yaş aralığındaki kişi bir çocuktur.");
            //}
            //else if (yas >= 11 && yas <= 18)
            //{
            //    Console.WriteLine("Bu yaş aralığındaki kişi bir ergendir.");
            //}
            //else if (yas >= 19 && yas <= 28)
            //{
            //    Console.WriteLine("Bu yaş aralığındaki kişi bir gençtir.");
            //}
            //else if (yas >= 29 && yas <= 35)
            //{
            //    Console.WriteLine("Bu yaş aralığındaki kişi bir orta yaşlıdır.");
            //}
            //else if (yas >= 36 && yas <= 45)
            //{
            //    Console.WriteLine("Bu yaş aralığındaki kişi bir olgundur.");
            //}
            //else if (yas >= 46 && yas <= 55)
            //{
            //    Console.WriteLine("Bu yaş aralığındaki kişi bir emekli adayıdır.");
            //}
            //else if (yas >= 56)
            //{
            //    Console.WriteLine("Bu yaş aralığındaki kişi emekli olacak yaşta.");
            //}
            //else
            //{
            //    Console.WriteLine("Geçersiz yaş değeri girdiniz.");
            //}


            #endregion

            #region Öğrencinin bir vize birde final sınav sonucu alalım. Alınan vize ve finalin ortalamasını alarak harf notu yazdıralım. Vize%40 final%60 
            /*
            0-24   FF
            25-44  DD
            45-54  CC
            55-69  CB
            70-84  BB
            85-100 AA

             */
           
            //VIZE:
            //    Console.WriteLine("Vize:");
            //    int vize = Convert.ToInt32(Console.ReadLine());

            //    if (vize < 0 || vize > 100)
            //    {
            //        Console.WriteLine("Hatalı Vize Notu!!");
            //        goto VIZE;
            //    }
            //    else
            //    {
            //    FINAL:
            //        Console.WriteLine("Final:");
            //        int final = Convert.ToInt32(Console.ReadLine());

            //        if (final < 0 || final > 100)
            //        {
            //            Console.WriteLine("Hatalı Final Notu!!");
            //            goto FINAL;
            //        }
            //        else
            //        {
            //            double ort = vize * 0.4 + final * 0.6;

            //            if (ort >= 0 && ort < 25)
            //            {
            //                Console.WriteLine("FF");
            //            }
            //            else if (ort > 24 && ort < 45)
            //                Console.WriteLine("DD");

            //            else if (ort > 44 && ort < 55)
            //                Console.WriteLine("CC");

            //            else if (ort > 54 && ort < 70)
            //                Console.WriteLine("CB");

            //            else if (ort > 69 && ort < 85)
            //                Console.WriteLine("BB");

            //            else
            //                Console.WriteLine("AA");
            //        }

            //    }

           
        






            #endregion
            #region  kullanıcıdan iki ürün fiyatı isteyin, ürün fiyat toplamları 2500 tl geçerse ucuz ürüne  %25 indirim uygulayınız

            #region Mehdi
            //Console.Write("Gömlek fiyatını girin: ");
            //double gomlekFiyati = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Ayakkabı fiyatını girin: ");
            //double ayakkabiFiyati = Convert.ToDouble(Console.ReadLine());

            //double toplamFiyat = gomlekFiyati + ayakkabiFiyati;
            //if (toplamFiyat > 2500)
            //{
            //    //Toplam üzerinde %25 indirim uygulandı. Cevap bu değil
            //    double indirimliFiyat = toplamFiyat * 0.75;
            //    Console.WriteLine($"Sepetiniz 2500tl nin üzerinde, İndirimli Fiyat: {indirimliFiyat:C}");
            //}
            //else
            //{
            //    Console.WriteLine($"Toplam fiyat: {toplamFiyat:C}");
            //}
            #endregion


            //Console.WriteLine("1. Ürün Fiyatı:");
            //double urun1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("2. Ürün Fiyatı:");
            //double urun2 = Convert.ToDouble(Console.ReadLine());

            //double toplam = urun1 + urun2;

            //if (toplam <= 2500)
            //{
            //    Console.WriteLine("Ödemeniz:" + toplam);
            //}
            //else
            //{
            //    if (urun1 > urun2)
            //    {
            //        urun2 = urun2 * 0.75;
            //    }
            //    else
            //    {
            //        urun1 = urun1 * 0.75;
            //    }

            //    Console.WriteLine("Ödemeniz:" + (urun1 + urun2));
            //}


            #endregion

            #region Kullanıcıdan 4 sayı alınacak ve alınan sayılardan çift olanlar toplanacaktır.

            // (5%2)=>1

            //Console.WriteLine("1.sayı:");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("2.sayı:");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("3.sayı:");
            //int sayi3 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("4.sayı:");
            //int sayi4 = Convert.ToInt32(Console.ReadLine());

            //int toplam = 0;

            //if (sayi1 % 2 == 0) //2
            //    toplam += sayi1; // toplam = toplam + sayi1

            //if (sayi2 % 2 == 0) //3
            //    toplam += sayi2;

            //if (sayi3 % 2 == 0) //4
            //    toplam += sayi3;

            //if (sayi4 % 2 == 0)//5
            //    toplam += sayi4;


            //Console.WriteLine("Toplam:" + toplam);
            #endregion

            #region Kullanıcıdan 4 sayı alınacak ve alınan sayılardan tekleri ayrı çiftleri ayrı toplayarak ekrena yazdırınız.

            // (5%2)=>1

            //Console.WriteLine("1.sayı:");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2.sayı:");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("3.sayı:");
            //int sayi3 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("4.sayı:");
            //int sayi4 = Convert.ToInt32(Console.ReadLine());

            //int cifttoplam = 0;
            //int tektoplam = 0;

            //if (sayi1 % 2 == 0)
            //    cifttoplam += sayi1;
            //else
            //    tektoplam += sayi1;

            //if (sayi2 % 2 == 0)
            //    cifttoplam += sayi2;
            //else
            //    tektoplam += sayi2;

            //if (sayi3 % 2 == 0)
            //    cifttoplam += sayi3;
            //else
            //    tektoplam += sayi3;

            //if (sayi4 % 2 == 0)
            //    cifttoplam += sayi4;
            //else
            //    tektoplam += sayi4;


            //Console.WriteLine("ÇiftToplam:" + cifttoplam);
            //Console.WriteLine("TekToplam:" + tektoplam);
            #endregion

            Console.ReadLine();

        }
    }
}
