namespace _12_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ARRAYS
            //string ad1 = "Altan";
            //string ad2 = "Ceylan";
            //string ad3 = "Uras";
            //string ad4 = "Kıvanç";
            //string ad5 = "Kerem";

            // Dizi: Aynı vertipinde kendisine verilen boyut kadar datayı birlikte tutabilen koleksiyonlardır.
            // Index: Koleksiyon yapıları kendilerine verilen dataları INDEX adı verilen numaralandırma sistemi ile 0 başlayarak 1'er 1'er artarak numaralandırır.

            string[] isimler = new string[10]; // 0,1,2,3,4,5,6,7,8,9
                                               //isimler[8] = "Mahmut";
                                               //isimler[3] = "Kamile";
                                               //isimler[10] = "Kübra";


        //string[] isimler = { "Altan", "Ceylan", "Uras", "Kıvanç", "Kerem" };

        //Console.WriteLine(isimler.Length);

        //Console.WriteLine(isimler[0]);
        //Console.WriteLine(isimler[1]);
        //Console.WriteLine(isimler[2]);
        //Console.WriteLine(isimler[3]);
        //Console.WriteLine(isimler[4]);
        //Console.WriteLine(isimler[5]); //IndexOutOfRangeException olmayan INDEX çağrıldı.

        //Console.WriteLine(isimler[0] + " " + isimler[2]);


        //for (int i = 0; i < isimler.Length; i++)
        //{
        //    Console.WriteLine(isimler[i]);
        //}

        //string[] ogrenciler = new string[6]; //0,1,2,3,4,5
        //ogrenciler[0] = "Kübra";
        //ogrenciler[3] = "Bayram";

        //for (int i = 0; i < ogrenciler.Length; i++)
        //{
        //    Console.WriteLine("Ogrenci Adı:");
        //    string ad = Console.ReadLine();
        //    ogrenciler[i] = ad;
        //}

        #endregion

        #region // Kullanıcıya kayıt olacak personel sayısını sorarak kullanıcıdan alınan isimleri bir diziye atınız ve ekrana yazdırınız.

        //Console.WriteLine("Kaç Personeliniz Var?");
        //int personelSayisi = Convert.ToInt32(Console.ReadLine());

        //string[] personeller = new string[personelSayisi];

        //for (int i = 0; i < personeller.Length; i++)
        //{
        //    Console.WriteLine("Personel Adı:");
        //    personeller[i] = Console.ReadLine();
        //}

        //for (int i = 0; i < personeller.Length; i++)
        //{
        //    Console.WriteLine(personeller[i]);
        //}

        //FOREACH : Sadece Yazma işleminde kullanılabilir.

        //foreach (string item in personeller)
        //{
        //    Console.WriteLine(item);
        //}

        #endregion


        #region // sayısal olarak eleman tutan 12 elemanlı bir dizinin 5 elemanı tek sayı, 7 elemanı da çift sayıdır. dizinin tek ve çift elemanlarını ayrı ayrı toplayıp gösteriniz

        //int[] sayilar = { 1, 3, 5, 7, 9, 2, 0, 4, 6, 8, 10, 12 };
        //int tektoplam = 0;
        //int cifttoplam = 0;

        //for (int i = 0; i < sayilar.Length; i++)
        //{
        //    if (sayilar[i] % 2 == 0)
        //    {
        //        cifttoplam = cifttoplam + sayilar[i];
        //    }
        //    else
        //    {
        //        tektoplam = tektoplam + sayilar[i];
        //    }


        //}

        //Console.WriteLine("Çift sayıların toplamı: " + (cifttoplam));
        //Console.WriteLine("Tek sayıların toplamı: " + (tektoplam));




        #endregion

        #region  //bir dizinin eleman sayısı 10 ile 20 arsında olacak şekilde sistem tarafında otomatik atılmaktadır. Bu dizinin elemanlarını da sistem 0,1000 arasında otomatik atmaktadır.Otomatik oluşturulan bu dizinin eleman sayısını ve elemanlarını kullanıcıya gösteriniz

        //Random r = new Random();

        //int elemansayisi = r.Next(10, 20);

        //int[] dizi = new int[elemansayisi]; //int[] dizi = new int[r.Next(10, 20)];

        //Console.WriteLine("Eleman sayısı : " + (elemansayisi));

        //for (int i=0; i < dizi.Length; i++)
        //{
        //    dizi[i] = r.Next(0, 1000);
        //}

        //foreach (int item in dizi)
        //{
        //    Console.WriteLine(item);
        //}
        #endregion
        #region ARRAY.METHODS()

        /*

        System.Array.Sınıfı
        Dizi nesneleri System.Array sınıfından türemişlerdir. Dolay sınıfın 
        bazı özellikleri ve metotlarını bünyelerinde barındırırlar.Afı altındaki üyeleri kullanarak diziler üzerinde çeşitli işlemler yapabiliriz.*/





        #region CLEAR
        //int[] sayilar = { 11, 22, 33, 44 };
        //Array.Clear(sayilar);
        #endregion

        #region COPY

        //int[] sayilar = { 11, 22, 33, 44 };
        //int[] sayilar2 = new int[10];

        //Array.Copy(sayilar, sayilar2, 2);
        //Array.Copy(sayilar, 1, sayilar2, 4, 2);


        //int x = 0;

        //for (int i = sayilar.Length-1; i >= 0 ; i--)
        //{
        //    sayilar2[x] = sayilar[i];
        //    x++;
        //}


        //foreach (var item in sayilar2)
        //{
        //    Console.WriteLine(item);
        //}
        #endregion

        #region INDEXOF and LASINDEXOF

        //int[] sayilar = { 11, 22, 11, 33,11, 44,11,55,66 };

        //int indx = Array.IndexOf(sayilar, 11);
        //Console.WriteLine(indx);

        //int indx2 = Array.LastIndexOf(sayilar, 11);
        //Console.WriteLine(indx2);

        //int indx3 = Array.IndexOf(sayilar, 11, 3);
        //Console.WriteLine(indx3);


        // Yukarıdaki dizide bulunan 11 değerinin index değerlerini bir döngü yardımı ile ekrana yazdırınız
        //int[] sayilar = { 11, 22, 11, 33, 11, 44, 11,55,66 };

        //int indx = -1;

        //while (true)
        //{
        //    indx = Array.IndexOf(sayilar, 11, indx + 1);
        //    if (indx == -1) break;
        //    Console.WriteLine(indx);
        //}

        //for (int i = 0; i < sayilar.Length; i++)
        //{
        //    indx = Array.IndexOf(sayilar, 11, indx + 1);
        //    if (indx == -1) break;
        //    Console.WriteLine(indx);
        //}


        //Yukarıdaki dizide 11 olmayan değerlerin indexlerini ekrana yazdırınız

        //for (int i = 0; i < sayilar.Length; i++)
        //{
        //    if (sayilar[i]!=11)
        //        Console.WriteLine(i);
        //}




        #endregion

        #region SORT
        //int[] sayilar = { 11, 22, 77, 88, 55, 9,2,12,99 };

        //foreach (var item in sayilar)
        //{
        //    Console.WriteLine(item);
        //}

        //Array.Sort(sayilar);
        //Console.WriteLine("SIRALANDI");
        //foreach (var item in sayilar)
        //{
        //    Console.WriteLine(item);
        //}

        #endregion

        #region REVERSE
        //int[] sayilar = { 11, 22, 77, 88, 55, 9, 2, 12, 99 };

        //Array.Reverse(sayilar);

        //foreach (var item in sayilar)
        //{
        //    Console.WriteLine(item);
        //}

        #endregion

        //int[] sayilar = { 11, 22, 77, 88, 55, 9, 2, 12, 99 };

        //Array.Sort(sayilar);   //0->9
        //foreach (var item in sayilar)
        //{
        //    Console.WriteLine(item);
        //}



        //Array.Reverse(sayilar); //9->0
        //foreach (var item in sayilar)
        //{
        //    Console.WriteLine(item);
        //}

        #region RESIZE
        //string[] ogrenciler = new string[3];

        //ogrenciler[0] = "Kübra";
        //ogrenciler[1] = "Mehdi";
        //ogrenciler[2] = "Dilruba";

        ////Array.Resize(ref ogrenciler, 5);
        //ogrenciler[3] = "Öykü";

        //foreach (var item in ogrenciler)
        //{
        //    Console.WriteLine(item);
        //}



        DON:
            //try
            //{
            //    ogrenciler[0] = "Kübra";
            //    ogrenciler[1] = "Mehdi";
            //    ogrenciler[2] = "Dilruba";

            //    ogrenciler[3] = "Öykü";

            //    foreach (var item in ogrenciler)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            //catch (Exception e)
            //{
            //    if(e.Message== "Index was outside the bounds of the array.")
            //    {
            //        int uzunluk = ogrenciler.Length;

            //        Array.Resize(ref ogrenciler, uzunluk + 5);
            //        goto DON;
            //    }
            //}



            #endregion



            #endregion


            #region İKİ VE ÇOK BOYUTLU DİZİLER
            /*İKİ BOYUTLU DİZİLER*/
            //Tek boyutlu dizileri, tek satırlı; ancak çok sayıda sütuna sahip olabilecek bir tablo gibi düşünmüştük.
            //Çok boyutlu dizilerde ise satır sayısıda tıpkı sütun sayısı gibi değişiklik gösterir. 
            //Standart boyutlu dizilerden farklı olarak Yatay x koordinatının yanına bir de dikey y koordinatı gelir.
            //Çok boyutlu dizi düzenli ve düzensiz olarak ikiye ayrılabilir.

            #region DÜZENLİ DİZİLER - MATRİS

            //Dikey ve Yatayda alacağı değerlerin sabit olduğu dizi şeklidir.

            //int[] sayilar = new int[5];
            //int[,] sayilar = new int[3, 3]; //[satır,sütun]

            //sayilar[0, 0] = 11;
            //sayilar[0, 1] = 22;
            //sayilar[0, 2] = 33;
            //sayilar[1, 0] = 44;
            //sayilar[1, 1] = 55;
            //sayilar[1, 2] = 66;
            //sayilar[2, 0] = 77;
            //sayilar[2, 1] = 88;
            //sayilar[2, 2] = 99;

            ////foreach (int item in sayilar)
            ////{
            ////    Console.WriteLine(item);
            ////}

            //for (int i = 0; i < sayilar.GetLength(0); i++)
            //{
            //    for (int j = 0; j < sayilar.GetLength(1); j++)
            //    {
            //        Console.Write(sayilar[i,j] + " ");
            //    }
            //    Console.WriteLine();
            //}


            //int[,,] sayilar = new int[2, 2, 2];
            //sayilar[0, 0,0] = 11;
            //sayilar[0, 0,1] = 12;
            //sayilar[0, 1,0] = 13;
            //sayilar[0, 1,1] = 14;
            //sayilar[1,0,0] = 22;
            //sayilar[1,0,1] = 23;
            //sayilar[1,1,0] = 24;
            //sayilar[1,1,1] = 25;

            //for (int i = 0; i < sayilar.GetLength(0); i++)
            //{
            //    for (int j = 0; j < sayilar.GetLength(1); j++)
            //    {
            //        for (int k = 0; k < sayilar.GetLength(2); k++)
            //        {
            //            Console.Write(sayilar[i,j,k]+" ");
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine();
            //}


            //# Örnek: 4x4'lük 0'lardan oluşan bir matris oluşturun(liste)
            //# 1. satırı 1-100 arası rastgele sayılardan oluşturunuz.
            //# 2. satırı Kullanıcıdan sayıları alınız.
            //# 3. satırda 1. satırın karelerini saklayınız.
            //# 4. satırda 2. satırdaki verilerin 5'er fazlasını saklayınız.

            int[,] matris = new int[4, 4];

            Random r = new Random();

            for (int satir = 0; satir < matris.GetLength(0); satir++)
            {
                if (satir == 0)
                {
                    for (int sutun = 0; sutun < 4; sutun++)
                    {
                        matris[satir, sutun] = r.Next(1, 100);
                    }
                }
                else if (satir == 1)
                {
                    for (int sutun = 0; sutun < 4; sutun++)
                    {
                        Console.WriteLine("Sayı:");
                        matris[satir, sutun] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                else if (satir == 2)
                {
                    for (int sutun = 0; sutun < 4; sutun++)
                    {
                        matris[satir, sutun] = matris[0, sutun] * matris[0, sutun];
                    }
                }
                else if (satir == 3)
                {
                    for (int sutun = 0; sutun < 4; sutun++)
                    {
                        matris[satir, sutun] = matris[1, sutun] +5;
                    }
                }
            }

            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    Console.Write(matris[i, j] + " ");
                }
                Console.WriteLine();
            }







            #endregion

            #endregion

        }
    }
}