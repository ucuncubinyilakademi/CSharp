
namespace _10_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
              LOOPS - DÖNGÜLER
                WHILE -  FOR - DO WHILE - FOREACH

            *********** WHILE ***********
            while döngüsü kendisine verilen koşul ifadesi TRUE olduğu sürece kapsamındaki işlemi tekrar tekrar çalıştırır


            while(koşul)
            {
                //kod bloğu
            }



             */

            //1-10 arasındaki sayıları ekrana yazdırınız

            //Console.WriteLine(1);
            //Console.WriteLine(2);
            //Console.WriteLine(3);
            //Console.WriteLine(4);
            //Console.WriteLine(5);
            //Console.WriteLine(6);
            //Console.WriteLine(7);
            //Console.WriteLine(8);
            //Console.WriteLine(9);
            //Console.WriteLine(10);

            //for (int i = 1; i < 11; i++)
            //{
            //    Console.WriteLine(i);
            //}

            /*
             1-başlangıç değerini tanımla
            2- koşul kontrol et T -> 3 F->5
            3- işi yap
            4- değeri arttır ->2 
            5- bitti
             */


            //int j = 1;

            //while (j<11)
            //{
            //    Console.WriteLine(j);
            //    j++;
            //}


            //int i = 1;

            //while (i<11)
            //{
            //    Console.WriteLine(i);
            //    i += 1; //i++;  i=i+1;
            //}

            #region   // 20 ile 40 arasındaki çift sayıları ekrana yazdırınız.

            //int s = 20; 

            //while (s <= 40) // 20-40 kadar tekrar olacak koşul son değer 40 olduğu için yazılmış
            //{
            //    Console.WriteLine(s); //20
            //    s += 2; // çift olduğu niçin 2 artmış.
            //}

            //while (s < 41)
            //{
            //    if (s % 2 == 0)
            //    {
            //        Console.WriteLine(s);
            //    }
            //    s++;
            //}


            #endregion

            #region // 1-100 arasındaki sayıların toplamını ekrana yazdırınız

            //int i = 1;
            //int toplam = 0;
            //while (i < 101)
            //{
            //    toplam += i;
            //    i++;
            //}
            //Console.WriteLine(toplam);

            #endregion

            #region // 20-200 arasında çift sayıların toplamını ekrana yazdırınız

            //int i = 20;
            //int toplam = 0;
            //while (i < 201)
            //{
            //    if (i % 2 == 0)
            //    {
            //        toplam += i;
            //    }
            //    i++;
            //}

            //Console.WriteLine(toplam);

            #endregion

            #region    // Müşteriden ürün sayısı istenilecek.
            // her ürünün fiyatı müşteriden istenilerek toplanacak
            // ve toplam ödeme ekrana yazdırılacak.


            //1-ürün sayısını öğren
            //2-Girilen ürün sayısı kadar kullanıcıya ürün fiyatı nedir? sorusunu sor
            //3-Girilen her fiyatı topla
            //4-Sonucu ekrana yaz.

            //Console.WriteLine("Ürün sayısı?");
            //int adet = Convert.ToInt32(Console.ReadLine());

            //int toplam = 0;

            //while (adet > 0)
            //{
            //    Console.WriteLine("Ürün fiyatı?");
            //    int fiyat = Convert.ToInt32(Console.ReadLine());
            //    toplam = toplam + fiyat;

            //    adet--;
            //}

            //Console.WriteLine("Ödemeniz:" + toplam);
            #endregion

            #region //250 den 0 kadar sayılardan 11'in katı olanları ekrana yazdırınız.

            //int s = 250;

            //while (s > 0)
            //{
            //    if (s % 11 == 0)
            //    {
            //        Console.WriteLine(s);
            //    }
            //    s--;
            //}

            #endregion

            #region  //Kullanıcıya 3 hak vererek giriş yapmasını isteyelim.

            //string username = "altanemre";
            //string password = "1";

            //int hak = 3;

            //while (hak > 0)
            //{
            //    Console.WriteLine("Username:");
            //    string kadi = Console.ReadLine();
            //    Console.WriteLine("Password:");
            //    string sfr = Console.ReadLine();

            //    if(username==kadi && password == sfr)
            //    {
            //        Console.WriteLine("Giriş Başarılı");
            //        break;
            //    }
            //    else if (hak > 1)
            //    {
            //        Console.WriteLine("Tekrar Deneyiniz");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Hakkınız Bitti");
            //    }
            //    hak--;

            //}



            //break;
            #endregion



            #region ************ RANDOM ***************
            //RANDOM KÜTÜPHANESİ: Belirtilena aralıklarda rastgele sayı üretir.

            //Random r = new Random();

            //Console.WriteLine(r.Next());

            //int rastgele = r.Next();
            //int rastgele = r.Next(5);
            //int rastgele = r.Next(3,9);

            //Console.WriteLine(rastgele);


            #region  //Bilgisayar 1-100 arasında rastgele br sayı tutsun. Kullanıcı 5 hakkında tahmin etmeye çalışsın.
            //Tahmin>rastgele : Tahmini küçült
            //Tahmin<rastgele : Tahmini büyült yönlediriniz.

            //Random r = new Random();

            //int rastgele = r.Next(1, 100);
            //Console.WriteLine(rastgele);
            //int hak = 5;

            //while (hak > 0)
            //{
            //    Console.WriteLine("Tahmininiz:");
            //    int tahmin = Convert.ToInt32(Console.ReadLine());
            //    hak--;

            //    if (tahmin == rastgele)
            //    {
            //        Console.WriteLine("Tebrikler");
            //        break;
            //    }
            //    else if (hak == 0)
            //    {
            //        Console.WriteLine("Hakkınız Bitti");
            //    }
            //    else if (tahmin > rastgele)
            //    {
            //        Console.WriteLine("Tahmininiz küçültünüz");
            //    }
            //    else if (tahmin < rastgele)
            //    {
            //        Console.WriteLine("Tahmininiz büyültünüz");
            //    }

            //}


            #endregion


            #endregion

            #region //Kullanıcıdan başlangıç değer bitiş değeri altında iki değer isteyelim ve bu iki değer arasındaki sayıların arasında 2,5 ve 7 bölünenlerin toplamını hesaplayınız
            //NOT:Başlangış değeri en az 50 olacak
            //    bitiş değeri en az 200 olacak ve 1500 geçmeyecek.
            //kullanıcını min değeri max değerden büyük girerse işlem yapılmayacak kullanıcıdan yeni sayı istenecek


            //while (true)
            //{
            //    Console.WriteLine("Başlangıç:");
            //    int basla = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Bitiş:");
            //    int bitis = Convert.ToInt32(Console.ReadLine());

            //    int toplam = 0;

            //    if (basla > 49 && bitis > 199 && bitis < 1501 && basla < bitis)  // basla:50 bitis:1500
            //    {
            //        while (bitis > basla)
            //        {
            //            if (bitis % 70 == 0)
            //            {
            //                toplam += bitis;
            //            }
            //            bitis--;
            //        }

            //        Console.WriteLine("Toplam:"+toplam);
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Değerler hatalı!!");
            //        Thread.Sleep(3000);
            //        Console.Clear();
            //    }
            //}



            //while (true)
            //{
            //    Console.WriteLine("Başlangıç:");
            //    int basla = Convert.ToInt32(Console.ReadLine());

            //    if (basla > 49)
            //    {
            //        while (true)
            //        {
            //            Console.WriteLine("Bitiş:");
            //            int bitis = Convert.ToInt32(Console.ReadLine());

            //            if (bitis > 199 && bitis < 1501)  // basla:50 bitis:1500
            //            {
            //                int toplam = 0;
            //                while (bitis > basla)
            //                {
            //                    if (bitis % 70 == 0)
            //                    {
            //                        toplam += bitis;
            //                    }
            //                    bitis--;
            //                }

            //                Console.WriteLine("Toplam:" + toplam);
            //                break;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Bitiş Değeri En Az 200 En Fazla 1500 olacak...");
            //            }
            //        }

            //    }
            //    else
            //    {
            //        Console.WriteLine("Başlangıç Değeri En Az 50 olacak...");
            //    }




            //}




            #endregion

            #region ************ FOR *************

            //1-10 olan sayıları ekrana yazdıran kod

            //int i = 1;
            //while (i < 11)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //for(int i=1; i<11; i++)
            //{
            //    Console.WriteLine(i);
            //}

            #region //1-500 arasındaki sayılarıdan 13'ün katı olanları ekrana yazdırınız.

            //for (int i = 1; i < 501; i++)
            //{
            //    if (i % 13 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }


            //}

            //for (int i = 13; i < 500; i+=13)
            //{
            //        Console.WriteLine(i);   
            //}

            #endregion


            #region   // kullanıcıdan alınacak bir sayının faktöriyelini bulan hesaplamayı  for ile yapınız

            //Console.WriteLine("Faktöriyel Hesaplanacak Sayı:");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //int fak = 1;

            //for (int i = 1; i <= sayi; i++)
            //{
            //    Console.WriteLine(fak + "*" + i);
            //    fak *= i;
            //}
            //Console.WriteLine("Faktöriyel:" + fak);

            #endregion


            #region // Kullanıcı giriş işlemini for ile yapınız.

            //string username = "admin";
            //string password = "1";

            //for (int hak = 3; hak>0; hak--)
            //{
            //    Console.WriteLine("Kullanıcı Adı:");
            //    string kullaniciAdi = Console.ReadLine();
            //    Console.WriteLine("Şifre:");
            //    string sfr = Console.ReadLine();

            //    if (kullaniciAdi == username && sfr == password)
            //    {
            //        Console.WriteLine("HOŞGELDİN BEYBİ");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("TEKRAR DENEYİNİZ");
            //    }
            //}




            #endregion

            #endregion


            #region DO WHILE 

            //int i = 1;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //} while (i < 11);


            #region  //Kullanıcı sayı isteyiniz ve her girilen sayıyı toplayınız. 
            //Kullanıcı sayı olarak 0 girdiğinden toplama işlemini bitirip ekrana toplamı yazınız.

            //int toplam = 0; int sayi;
            //do
            //{

            //    Console.WriteLine("Sayı:");
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //    toplam += sayi;

            //} while (sayi != 0);




            //int toplam = 0; int sayi;
            //do
            //{

            //    Console.WriteLine("Sayı:");
            //    sayi = Convert.ToInt32(Console.ReadLine());

            //    if (sayi == 0)
            //        break;

            //    toplam += sayi;

            //} while (true);



            //Console.WriteLine(toplam);
            #endregion

            #endregion


            #region  //250-1250 arasındaki tek ve çift sayıların toplamını ayrı ayrı hesaplayınız

            #region FOR
            //int tektoplam = 0;
            //int cifttoplam = 0;

            //for (int i = 250; i < 1250; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        cifttoplam = cifttoplam + i;
            //    }
            //    else
            //    {
            //        tektoplam = tektoplam + i;
            //    }
            //}
            //Console.WriteLine("Tek Sayılar Toplamı:" + tektoplam);
            //Console.WriteLine("Çift Sayılar Toplamı:" + cifttoplam);
            #endregion

            //int tektoplam = 0;
            //int cifttoplam = 0;

            //int i = 250;

            //while (i < 1250)
            //{
            //    if (i % 2 == 0)
            //    {
            //        cifttoplam = cifttoplam + i;
            //    }
            //    else
            //    {
            //        tektoplam = tektoplam + i;
            //    }
            //    i++;
            //}
            //Console.WriteLine("Tek Sayılar Toplamı:" + tektoplam);
            //Console.WriteLine("Çift Sayılar Toplamı:" + cifttoplam);

            #endregion

        }
    }
}