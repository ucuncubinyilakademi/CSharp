using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
            * SWITCH-CASE: IF yapısıyla aynı mantıkta çalışır
            * Switch case yapısı, çok durumlu dallanma ifadelerinde if-else blokları yerine tercihen kullanılırlar. Switch-case ile yapılabilecek tüm işlemler if-else merdiveni ile de yapılabilmektedir.
            * 
            *  1) switch içine değişken yazılır.

               2) case ifadelerinde ise değişkenin eşitliğine göre işlem yapılmasını sağlar. case ifadelerinde sayısal normal yazılır, string " "(çift tırnak) içinde, char ' '(tek tırnak) içinde

               3) Her case’den sonra break yazmak zorunludur.case bölümünün bitiğini belirtir.

                4) default ifadesi ise değerin case şartlarından hiçbirine uymadığında yapılmasını sağlar.



           if(değer==eşitlik1)
           {
                İşlemler
           }
           else if(değer==eşitlik2)
           {
               İşlemler
           }
           else if(değer==eşitlik3)
           {
                İşlemler
           }
           else
           {
                İşlemler
           }
            */
            #region 1.Örnek

            Console.WriteLine("Haftanın kaçıncı günü?");
            //int gun = Convert.ToInt32(Console.ReadLine());
            string gun = Console.ReadLine();
            
            switch (gun)
            {
                case "1":
                    Console.WriteLine("Pazartesi");
                    break;
                case "2":
                    Console.WriteLine("Salı");
                    break;
                case "3":
                    Console.WriteLine("Çarşamba");
                    break;
                case "4":
                    Console.WriteLine("Perşembe");
                    break;
                case "5":
                    Console.WriteLine("Cuma");
                    break;
                case "6":
                    Console.WriteLine("Cumartesi");
                    break;
                case "7":
                    Console.WriteLine("Pazar");
                    break;

                default:
                    Console.WriteLine("Hatalı Gün Bilgisi!!");
                    break;
            }
            #endregion

            #region 2.Örnek
            /*
            kullanıcıdan alınan cinsiyet bilgisine göre
           ==> ERKEK ise
              yaşı 60 ve üstü ise maaşının 10 katı kadar ikramiye alarak emekli edilecek, yaş 60'ın altında ise çalıştığı gün sayısına göre eğer 6000 gün ve üstü ise maaşının 11 katı kadar ikramiye alarak emekli edilecek,    6000 altında ise emekli edilmeyecek bilgisi kullanıcıya gösterilecek
           ==> KADIN ise
              yaşı 58 ve üstü ise maaşının 10 katı kadar ikramiye alarak emekli edilecek, yaş 58'ın altında ise çalıştığı gün sayısına göre eğer 5600 gün ve üstü ise maaşının 11 katı kadar ikramiye alarak emekli edilecek, 5600 altında ise emekli edilmeyecek bilgisi kullanıcıya gösterilecek
               ==> cinsiyet bilgisi switch-case ile sorgulanacak
            */

            Console.WriteLine("Cinsiyet:");
            string cinsiyet = Console.ReadLine().ToLower();

            if (cinsiyet == "erkek")
            {
                Console.WriteLine("Yaş:");
                int yas = Convert.ToInt32(Console.ReadLine());

                if (yas >= 60)
                {
                    Console.WriteLine("Maaş:");
                    double maas = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Emekli ikramiyesi:"+(maas*10));
                }
                else
                {
                    Console.WriteLine("Prim Günü:");
                    int prim = Convert.ToInt32(Console.ReadLine());

                    if (prim > 6000)
                    {
                        Console.WriteLine("Maaş:");
                        double maas = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Emekli ikramiyesi:" + (maas * 11));
                    }
                    else
                    {
                        Console.WriteLine("Emeklilik hayal çalışmaya devam...");
                    }
                }
            }
            else if (cinsiyet == "kadın")
            {
                Console.WriteLine("Yaş:");
                int yas = Convert.ToInt32(Console.ReadLine());

                if (yas >= 58)
                {
                    Console.WriteLine("Maaş:");
                    double maas = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Emekli ikramiyesi:" + (maas * 10));
                }
                else
                {
                    Console.WriteLine("Prim Günü:");
                    int prim = Convert.ToInt32(Console.ReadLine());

                    if (prim > 4500)
                    {
                        Console.WriteLine("Maaş:");
                        double maas = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Emekli ikramiyesi:" + (maas * 11));
                    }
                    else
                    {
                        Console.WriteLine("Emeklilik hayal çalışmaya devam...");
                    }
                }
            }
            else
            {
                Console.WriteLine("Hatalı cinsiyet girişi");
            }






            #endregion
            Console.ReadLine();


        }
    }
}
