using System.Collections;

namespace _13_Otomat_Makinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] products = { "Kola", "Fanta", "Ayran" };
            double[] prices = { 15, 15, 10 };

            while (true)
            {
                Console.WriteLine("Yönetici-1\nMüşteri-2\nÇıkış-Q\nSeçiminiz:");
                string secim = Console.ReadLine().ToUpper();

                if (secim == "1") 
                {
                    while (true)
                    {
                        Console.WriteLine("1-Ürün Ekle\n2-Ürün Güncelle\n3-Ürün Sil\n4-Ürün Listele\n5-Çıkış\nSeçiminiz:");
                        string islem = Console.ReadLine();

                        if (islem == "1")
                        {
                            Console.WriteLine("Ürün adı:");
                            string ad = Console.ReadLine();
                            Console.WriteLine("Ürün fiyatı:");
                            double fiyat = Convert.ToDouble(Console.ReadLine());

                            Array.Resize(ref products, products.Length + 1);
                            Array.Resize(ref prices, prices.Length + 1);

                            products[products.Length - 1] = ad;
                            prices[prices.Length - 1] = fiyat;

                            Console.Clear();
                        }
                        else if (islem == "2") 
                        {
                            for (int i = 0; i < products.Length; i++)
                            {
                                Console.WriteLine(i + "-" + products[i] + ":" + prices[i]);
                            }

                            Console.WriteLine("Güncellenecek ürün numarası:");
                            int no = Convert.ToInt32(Console.ReadLine());

                            if(no>=0 && no < prices.Length)
                            {
                                Console.WriteLine("Yeni Ürün adı:");
                                string ad = Console.ReadLine();
                                Console.WriteLine("Yeni Ürün fiyatı:");
                                double fiyat = Convert.ToDouble(Console.ReadLine());

                                products[no] = ad;
                                prices[no] = fiyat;

                                Console.Clear();

                            }
                            else
                            {
                                Console.WriteLine("Hatalı Ürün Seçimi!");
                            }


                        }
                        else if (islem == "3") 
                        {
                            for (int i = 0; i < products.Length; i++)
                            {
                                Console.WriteLine(i + "-" + products[i] + ":" + prices[i]);
                            }

                            Console.WriteLine("Silinecek ürün numarası:");
                            int no = Convert.ToInt32(Console.ReadLine());

                            if (no >= 0 && no < prices.Length)
                            {
                                Array.Clear(products, no, 1);
                                Array.Clear(prices, no, 1);
                            }
                            else
                            {
                                Console.WriteLine("Hatalı Ürün Seçimi!");
                            }



                        }
                        else if (islem == "4")
                        {
                            for (int i = 0; i < products.Length; i++)
                            {
                                Console.WriteLine(i + "-" + products[i] + ":" + prices[i]);
                            }
                        }
                        else if (islem == "5") { break; }
                        else { Console.WriteLine("Hatalı Tuşlama!"); }
                    }
                  

                }
                else if (secim == "2")
                {
                    while (true)
                    {
                        for (int i = 0; i < products.Length; i++)
                        {
                            Console.WriteLine(i + "-" + products[i] + ":" + prices[i]);
                        }
                        Console.WriteLine("Çıkış için -1");
                        Console.WriteLine("Ürün Numarası Giriniz:");
                        int no = Convert.ToInt32(Console.ReadLine());

                        if (no == -1)
                            break;
                        else if (no >= 0 && no < products.Length)
                        {
                            Console.WriteLine("Para Yatırınız:");
                            double fiyat = Convert.ToDouble(Console.ReadLine());

                            if (fiyat >= prices[no])
                            {
                                Console.WriteLine("Ürünü alt bölmeden alınız. Para üstü:" + (fiyat - prices[no]));
                            }
                            else
                            {
                                Console.WriteLine("Yetersiz Bakiye..");
                                Console.WriteLine("Paranız iade edildi.");
                            }
                        }

                        else
                        {
                            Console.WriteLine("Hatalı Ürün Seçimi!!");
                        }
                    }



                }
                else if (secim == "Q") { break; }
                else { Console.WriteLine("Hatalı Seçim!!"); }
            }

        }
    }
}

#region Dilruba
//static void Main(string[] args)
//{
//    string admin = "a";
//    string adminsifre = "1";
//    string[] urunler = { "ÇİKOLATA", "KAHVE", "KRAKER", "BİSKÜVİ" };
//    int[] fiyatlar = { 12, 25, 10, 14 };


//AnaSecim:
//    Console.WriteLine("1-Admin Girişi\n2-Üye Girişi");
//    int secim = Convert.ToInt32(Console.ReadLine());

//    if (secim == 1)
//    {
//        for (int hak = 3; hak > 0; hak--)
//        {
//            Console.WriteLine("Admin kullanıcı adını girin");
//            string girilenad = Console.ReadLine();
//            Console.WriteLine("Şifreyi Giriniz");
//            string girilensifre = Console.ReadLine();

//            if (hak == 1) { Console.WriteLine("Game Over"); }
//            else
//            {
//                if (admin == girilenad && adminsifre == girilensifre)
//                {
//                Adminpanel:
//                    Console.WriteLine("Admin paneline hoşgeldiniz");
//                    Console.WriteLine("1-Ürün Ekle\n2-Ürün Güncelle\n3-Ürün Sil");
//                    int adminsecim = Convert.ToInt32(Console.ReadLine());
//                    if (adminsecim == 1)
//                    {
//                        Console.WriteLine("Eklemek istediğiniz ürünü giriniz");
//                        string yeniurun = Console.ReadLine().ToUpper();
//                        Array.Resize(ref urunler, urunler.Length + 1);
//                        urunler[urunler.Length - 1] = yeniurun;
//                        foreach (string item in urunler)
//                        {
//                            Console.WriteLine(item);
//                        }
//                        Console.WriteLine("Eklemek istediğiniz ürünün fiyatını giriniz");
//                        int yeniurunfiyat = Convert.ToInt32(Console.ReadLine());
//                        Array.Resize(ref fiyatlar, fiyatlar.Length + 1);
//                        fiyatlar[fiyatlar.Length - 1] = yeniurunfiyat;
//                        foreach (int item in fiyatlar)
//                        {
//                            Console.WriteLine(item);
//                        }

//                    }
//                    else if (adminsecim == 2)
//                    {
//                    GuncellemeEkranı:
//                        Console.WriteLine("Güncellemek istediğiniz ürünü yazın");
//                        string guncelleme = Console.ReadLine().ToUpper();
//                        if (urunler.Contains(guncelleme))
//                        {
//                            int index = Array.IndexOf(urunler, guncelleme);
//                            Console.WriteLine("Güncellemek istediğiniz fiyatı giriniz");
//                            int gfiyat = Convert.ToInt32(Console.ReadLine());
//                            fiyatlar[index] = gfiyat;
//                            Array.ForEach(fiyatlar, Console.WriteLine);

//                        }
//                        else
//                        {
//                            Console.WriteLine("Ürün Bulunamadı");
//                            goto GuncellemeEkranı;
//                        }

//                    }
//                    else if (adminsecim == 3)
//                    {
//                    SilmeEkranı:
//                        Console.WriteLine("Silmek istediğiniz ürünü yazın");
//                        string silme = Console.ReadLine().ToUpper();
//                        if (urunler.Contains(silme))
//                        {
//                            int indexUr = Array.IndexOf(urunler, silme);
//                            int f = fiyatlar[indexUr];
//                            urunler = urunler.Where((silme, index) => index != indexUr).ToArray();
//                            fiyatlar = fiyatlar.Where((f, index) => index != indexUr).ToArray();
//                            Array.ForEach(urunler, Console.WriteLine);
//                            Array.ForEach(fiyatlar, Console.WriteLine);

//                        }
//                        else
//                        {
//                            Console.WriteLine("Ürün Bulunamadı");
//                            goto SilmeEkranı;
//                        }



//                    }
//                    else
//                    {
//                        Console.WriteLine("Geçerli seçim yapın");
//                        goto Adminpanel;
//                    }
//                    Console.WriteLine("Başka bir işlem için bekleyiniz");
//                    Thread.Sleep(3000);
//                    Console.Clear();
//                    Console.WriteLine("1-Admin Paneline Dön\n2-Çıkış ");
//                    int don = Convert.ToInt32(Console.ReadLine());
//                    if (don == 1) { goto Adminpanel; }
//                    else if (don == 2) { break; }
//                    else Console.WriteLine("Geçerli sayı gir");



//                    break;
//                }
//                else
//                {
//                    Console.WriteLine("Tekrar Deneyiniz");
//                }
//            }
//        }
//    }
//    else if (secim == 2)
//    {
//    Urunsecim:
//        for (int i = 0; i < urunler.Count(); i++)
//        {
//            Console.WriteLine(i + "-" + urunler[i]);
//        }

//        Console.WriteLine("\n\nSeçim yapınız");
//        int msecim = Convert.ToInt32(Console.ReadLine());
//        if (msecim < urunler.Count() && msecim >= 0)
//        {
//            Console.WriteLine("Seçtiğiniz ürün: {0} -- {1} TL", urunler[msecim], fiyatlar[msecim]);
//            Console.WriteLine("Ücreti yerleştir");
//            int price = Convert.ToInt32(Console.ReadLine());
//            if (price == fiyatlar[msecim])
//            {
//                Console.WriteLine("Ürününüzü alınız.Afied");

//            }
//            else if (price > fiyatlar[msecim])
//            {
//                Console.WriteLine("Ürününüzü alınız");
//                int paraustu = price - fiyatlar[msecim];
//                Console.WriteLine("Para üstünüz :" + paraustu + "\nAfied");

//            }
//            else
//            {
//                Console.WriteLine("Yetersiz Bakiye");
//                goto Urunsecim;
//            }
//        }
//    }
//    else
//    {
//        Console.WriteLine("Geçerli sayı giriniz");
//        goto AnaSecim;
//    }








//}
#endregion