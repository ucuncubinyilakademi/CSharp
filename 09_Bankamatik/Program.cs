using System;
using System.IO;
using System.Threading;

namespace _09_Bankamatik
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region /*   
            //              *   2500 tl parası olacak 
            //             Bir bankamatik düşünülerek tasarlanacak bir program  için 
            //             Kartlı işlem    1
            //             Kartsız işlem   2
            //             //********Kartlı işlem bölümü
            //             Şifre istenecek=> Şifre:ab18
            //             ==> şifrenin 3 defa yanlış olması halinde sistemden atılacak,değilse Ana Menü
            //             //*******************Ana Menü 
            //             Para Çekmek için    1
            //             Para yatırmak için  2
            //             Para Transferleri   3
            //             Eğitim Ödemeleri    4
            //             Ödemeler            5
            //             Bilgi Güncelleme    6
            //             //*********************Seçim 1************
            //             Bakiye yeterli ise para çekilecek,değilse yetersiz bakiye
            //             Ana menüye dönmek için   9
            //             Çıkmak için             0
            //             //******************Seçim 2***********************
            //             Kredi Kartına   1
            //             Kendi Hesabınıza yatırmak için  2
            //             Ana Menü        9
            //             Çıkmak için     0
            //             //------------------------------------
            //             //----1
            //             Kredi kardı için en az 12 haneli kart numarasını girsin
            //             bakiye yeterli ise hesaptan kredi kartına para yatırılaca
            //             Ana Menü        9
            //             Çıkmak için     0
            //             //--------------------------
            //             //---2
            //             hesaba yatırılacak para değeri istenir veişlem gerçekleştirilir
            //             Ana Menü        9
            //             Çıkmak için     0
            //             //*****************************Seçim 3
            //             Başka Hesaba EFT    1
            //             Başka Hesaba Havale 2
            //             //---------------------------------
            //             //--1
            //             EFT numarası istenecek ve başında tr olmalı ve sonrasında 12 haneli sayı işlemleri doğru ise
            //             yatılacak para istenir ,hesap uygun ise işlem gerçekleşir değilse
            //             Ana Menü        9
            //             Çıkmak için     0
            //             //-----------------------------
            //             //---2
            //             hesap için 11 haneli hesap numarası işlemler doğru ise
            //             gönderilecek para miktarı, hesap uygun ise transfer olacak ,değilse
            //             Ana Menü        9
            //             Çıkmak için     0
            //             //****************Seçim 4
            //             Eğitim Ödemeleri sayfası arızalı
            //             Ana Menü        9
            //             Çıkmak için     0
            //             //****************************Seçim 5
            //             Elektrik Faturası       1
            //             Telefon Faturası        2
            //             İnternet faturası       3
            //             Su Faturası             4
            //             OGS Ödemeleri           5
            //             //-----------------------------------------
            //             //---1 => bütün faturala için aşağıdaki şart yeterli
            //             fatura tutarı istenir, hesap uygun ise yatırılır değilse
            //             Ana Menü        9
            //             Çıkmak için     0
            //             //-----------------------------------
            //             //***************Seçim 6
            //             Şifre değiştirmek için 1
            //             Şifre değiştirme işlemi gerçekleştirilir
            //             Ana Menü        9
            //             Çıkmak için     0




            //            //********Kartsız işlem bölümü

            //             //*******************Ana Menü 
            //             CepBank Para Çekmek 1
            //             Para yatırmak için  2
            //             Kredi Kartı Ödeme   3
            //             Eğitim Ödemeleri    4
            //             Ödemeler            5

            //             //*********************Seçim 1************
            //             TC kimlik no ve cep telefonu numarasını girsin doğruysa kişiye 1000 ödeme 
            //             Yapın yanlış ise 3 kere daha denetin Hakkı bittiğinde 1 saat kilitleyin.
            //Ana menüye dönmek için   9
            //             Çıkmak için              0
            //             //******************Seçim 2***********************
            //             Nakit ödeme     1
            //             Hesaptan ödeme  2
            //             Ana Menü        9
            //             Çıkmak için     0
            //             //------------------------------------
            //             //----1
            //	      Kredi kartı için en az 12 haneli kart numarasını girsin
            //	      Tc kimlik numarasını girsin. 11 hane olup olmadığını kontrol edin.
            //             Nakit olarak ödeme gerçekleştirin.
            //             Ana Menü        9
            //             Çıkmak için     0
            //             //--------------------------
            //             //---2
            //             Kredi kartı için en az 12 haneli kart numarasını girsin
            // Hesap numarasını girsin

            //             Ana Menü        9
            //             Çıkmak için     0
            //             //*****************************Seçim 3
            //             Başka Hesaba EFT    1
            //             Başka Hesaba Havale 2
            //             //---------------------------------
            //             //--1
            //             EFT numarası istenecek ve başında tr olmalı ve sonrasında 12 haneli sayı işlemleri doğru ise
            //             yatılacak para istenir ,hesap uygun ise işlem gerçekleşir değilse
            //             Ana Menü        9
            //             Çıkmak için     0
            //             //-----------------------------
            //             //---2
            //             hesap için 11 haneli hesap numarası işlemler doğru ise
            //             gönderilecek para miktarı, hesap uygun ise transfer olacak ,değilse
            //             Ana Menü        9
            //             Çıkmak için     0
            //             //****************Seçim 4
            //             Eğitim Ödemeleri sayfası arızalı
            //             Ana Menü        9
            //             Çıkmak için     0
            //             //****************************Seçim 5
            //             Elektrik Faturası       1
            //             Telefon Faturası        2
            //             İnternet faturası       3
            //             Su Faturası             4
            //             OGS Ödemeleri           5
            //             //-----------------------------------------
            //             //---1 => bütün faturala için aşağıdaki şart yeterli
            //             fatura tutarı istenir, hesap uygun ise yatırılır değilse

            //              */


            #endregion

            int bakiye = 2500;
            string sifre = "ab18";
           
            while (true)
            {
                Console.WriteLine("1-Kartlı İşlem\n2-Kartsız İşlem\n3-Çıkış\nSeçiminiz");
                string kart = Console.ReadLine();

                if (kart == "1")
                {
                    int hak = 3;
                    bool girisDurum = false;
                    while (hak > 0)
                    {
                        Console.WriteLine("Şifre:");
                        string sfr = Console.ReadLine();
                        if (sfr == sifre)
                        {
                            Console.WriteLine("Giriş Başarılı");
                            girisDurum = true;
                            break;
                        }
                        else { Console.WriteLine("Şifre Hatalı!!"); }
                        hak--;
                    }

                   if(girisDurum==false)
                    {
                        Console.WriteLine("Giriş Hakkınız Bitti. Sistem 5 dakika kilitlendi.");
                        Thread.Sleep(5000);
                        Console.Clear();
                        continue;
                    }

                    while (true)
                    {
                        Console.WriteLine("********* ANA MENÜ *********");
                        Console.WriteLine("1-Para Çekme\n2-Para Yatırma\n3-Para Transferi\n4-Eğitim Ödemeleri\n5-Ödemeler\n6-Bilgi Güncelleme\n7-Çıkış\nSeçiminiz:");
                        string kartliIslem = Console.ReadLine();

                        if (kartliIslem == "1") 
                        {
                            Console.WriteLine("Çekilecek Miktar:");
                            int miktar = Convert.ToInt32(Console.ReadLine());

                            if (bakiye >= miktar) 
                            {
                                bakiye -= miktar;
                                Console.WriteLine("Paranızı Alınız. Bakiyeniz:"+bakiye);
                            }
                            else 
                            {
                                Console.WriteLine("Yetersiz Bakiye");
                            }

                        }
                        else if (kartliIslem == "2") 
                        {
                            KrediKart:
                            Console.WriteLine("1-Kredi Kartı\n2-Kendi Hesabına\nSeçiminiz:");
                            string secim = Console.ReadLine();

                            if (secim == "1") 
                            {
                                Console.WriteLine("12 haneli kredi kart numarası:");
                                string no = Console.ReadLine();

                                long krediKart;

                                if(no.Length==12 && long.TryParse(no,out krediKart))
                                {
                                    Console.WriteLine("Yatıralacak Miktar:");
                                    int miktar = Convert.ToInt32(Console.ReadLine());

                                    if (bakiye >= miktar)
                                    {
                                        bakiye -= miktar;
                                        Console.WriteLine("Paranız Yatırıldı. Bakiyeniz:" + bakiye);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Yetersiz Bakiye");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Kredi kart numarası hatalı!");
                                    goto KrediKart;
                                }

                            }
                            else if (secim == "2") 
                            {
                                Console.WriteLine("Yatırılacak Miktar:");
                                int miktar = Convert.ToInt32(Console.ReadLine());

                                bakiye += miktar;
                                Console.WriteLine("Paranız Yatırıldı. Bakiyeniz:" + bakiye);


                            }
                            else { Console.WriteLine("Hatalı Seçim!!"); }

                        }
                        else if (kartliIslem == "3") 
                        {
                            Console.WriteLine("1-EFT\n2-HAVALE\nSeçiminiz:");
                            string secim = Console.ReadLine();

                            if (secim == "1") 
                            {
                                Console.WriteLine("EFT yapılacak IBAN giriniz:");
                                string iban = Console.ReadLine().ToLower();

                                string ibanNo = iban.Substring(2);

                                long IBAN;

                                if(iban.StartsWith("tr") && ibanNo.Length==12 && long.TryParse(ibanNo,out IBAN))
                                {
                                    Console.WriteLine("EFT Miktarı:");
                                    int miktar = Convert.ToInt32(Console.ReadLine());

                                    if (bakiye >= miktar)
                                    {
                                        bakiye -= miktar;
                                        Console.WriteLine("EFT Yapıldı. Bakiyeniz:" + bakiye);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Yetersiz Bakiye");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Girilen IBAN bilgisi hatalı!!");
                                }

                            }
                            else if (secim == "2") 
                            {
                                HesapNo:
                                Console.WriteLine("11 haneli hesap numarası:");
                                string no = Console.ReadLine();

                                long hesapNo;

                                if (no.Length == 11 && long.TryParse(no, out hesapNo))
                                {
                                    Console.WriteLine("Havale Miktarı:");
                                    int miktar = Convert.ToInt32(Console.ReadLine());

                                    if (bakiye >= miktar)
                                    {
                                        bakiye -= miktar;
                                        Console.WriteLine("Havale Yapıldı. Bakiyeniz:" + bakiye);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Yetersiz Bakiye");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Hesap numarası hatalı!");
                                    goto HesapNo;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Hatalı Seçim!!");
                            }

                        }
                        else if (kartliIslem == "4") {
                            Console.WriteLine("Eğitim ödeme menüsü arızalı!!");
                        }
                        else if (kartliIslem == "5") 
                        {
                            Console.WriteLine("Fatura Miktar:");
                            int miktar = Convert.ToInt32(Console.ReadLine());

                            if (bakiye >= miktar)
                            {
                                bakiye -= miktar;
                                Console.WriteLine("Faturanız Yatırıldı. Bakiyeniz:" + bakiye);
                            }
                            else
                            {
                                Console.WriteLine("Yetersiz Bakiye");
                            }
                        }
                        else if (kartliIslem == "6") 
                        {
                            Console.WriteLine("Eski şifre:");
                            string eskisifre = Console.ReadLine();

                            if (eskisifre == sifre) 
                            {
                                Console.WriteLine("Yeni şifre:");
                                string yenisifre = Console.ReadLine();

                                Console.WriteLine("Tekrar Yeni şifre:");
                                string yenisifre2 = Console.ReadLine();

                                if (yenisifre == yenisifre2) { sifre = yenisifre; }
                                else { Console.WriteLine("Şifreler Uyuşmuyor!"); }

                            }
                            else { Console.WriteLine("Hatalı Şifre!!"); }
                        }
                        else if (kartliIslem == "7")
                        {
                            Console.WriteLine("Kartlı Kartsız işlem menüsüne yönlendiriliyorsunuz....");
                            Thread.Sleep(2000);
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Hatalı Kartlı İşlem Seçimi!!!");
                            Thread.Sleep(3000);
                            Console.Clear();
                        }
                        Thread.Sleep(3000);
                        Console.Clear();
                        Console.WriteLine("9-Anamenü\n0-Çıkış\nSeçiminiz:");
                        string menu = Console.ReadLine();

                        if (menu == "9")
                        {
                            continue;
                        }
                        else
                        {
                            Environment.Exit(0);
                        }
                    }

                }

                else if (kart == "2") { }
                else if (kart == "3") { break; }
                else
                {
                    Console.WriteLine("Hatalı Seçim!!!");
                }
            }

        }


    }
}
