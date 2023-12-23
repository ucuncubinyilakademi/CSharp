
using System.Collections;

namespace _14_Arraylist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ARRAY: Veritipi ve boyutu belirlenemelidir.
            //int[] sayilar = new int[4];

            //sayilar[0] = 1;
            //sayilar[1] = 1.5;


            // ************** ARRAYLIST **************

            /* 
           using System.Collections; eklenerek erişim sağlanır.
           Belirli bir datatype tanımı ve uzunluk sınırlandırması yoktur. 
           Add komutu ile eleman eklenir. ve index kavramına sahiptir.

           */


            // Boş Arraylist Tanımı
            //ArrayList liste = new ArrayList();
            //liste.Add(1);
            //liste.Add("Ali");
            //liste.Add(2.5);
            //liste.Add(45.6f);
            //liste.Add(13.5m);

            ////Console.WriteLine(liste[3]);

            //foreach (var item in liste)
            //{
            //    Console.WriteLine(item);
            //}

            #region 1.SORU
            //Arraylist elemanlarının her birine 10 eklerek tekrar bir arrayliste koyunuz ve ekrana yazdırınız.
            //ArrayList array = new ArrayList() { 10, 11, 12, 13, 14 };

            //ArrayList newArray = new ArrayList();


            ////foreach (int item in array)
            ////{
            ////    newArray.Add(item + 10);
            ////}


            //for (int i = 0; i < array.Count; i++)
            //{
            //    newArray.Add((int)array[i]+10);
            //}


            //foreach (int item in newArray)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Clone()
            //ArrayList l = new ArrayList() { 10, 20, 30 };

            //ArrayList yeni = new ArrayList();

            ////yeni = l;


            //yeni = (ArrayList)l.Clone();
            //l.Add(40);

            //foreach (var item in l)
            //{
            //    Console.WriteLine(item);
            //}



            //foreach (var item in yeni)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Capacity()  Count()  IndexOf()  LastIndexOf()   Insert()  InsertRange()   Remove()  RemoveAt()

            //ArrayList array = new ArrayList() { 11, 2, 3,4,56,7,8,9,11 };

            //Console.WriteLine(array.Capacity);
            //Console.WriteLine(array.Count);


            //Console.WriteLine(array.IndexOf(11));
            //Console.WriteLine(array.LastIndexOf(11));

            //array.Insert(2, 34); //İstenilen indexe değer eklenir. O index de bulunan değer bir sağa ötelenir.



            //InsertRange() => belirtilen indexten başlayarak verilen koleksiyon yapısını ekler.
            //array.InsertRange(2, new ArrayList() { 22, 23, 34 });

            //ArrayList liste = new ArrayList() { 22, 23, 24, 25 };
            //array.InsertRange(1, liste);

            //int[] sayilar = { 0, 0, 0, 0 };
            //array.InsertRange(1, sayilar);


            //Remove() => Kendisine verilen değeri ArrayList'en siler.
            //array.Remove(11);

            //RemoveAt() => Kendisine verilen index deki değeri ArrayList'en siler.
            //array.RemoveAt(1);

            //foreach (int item in array)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region ODEV
            // 0 girilene kadar girilen değerleri ArrayListe atan ve sonunda bu listeyi büyükten küçüğe sıralayan ve listedeki en büyük en küçük ve ortalama değerleri bulan program

            #endregion
        }
    }
}