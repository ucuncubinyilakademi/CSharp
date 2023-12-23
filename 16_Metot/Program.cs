namespace _16_Metot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* ****** METHOD ******

              Belirli bir işlemi tanımlamımızı ve ihtiyac durumunda çağrırarak kullanmamızı sağlar.
             Methodları temsil eden karakter ()'dır. 
             Methodlar çağrılmadan çalışmazlar.


             Methodlar 2'ye ayrılır.
                *Değer Döndürmeyen Metot => parametreli ve parametresiz 
                *Değer Döndüren Metot    => parametreli ve parametresiz 


               /***** DEĞER DÖNDÜRMEYEN METOTLAR ***********

            'void' keyword'ü metodun değer döndürmediğini belirtir.


            Data Access Modifier => public,internal,private,protected

                public   : Solution altındaki bütün projelerde erişilebilir.
                internal : Kendi projesi altında erişilebilir.
                private  : Sadece tanımlı olduğu class içerisinde erişilebilir.
                protected: Miras ile türeyen classlar içerisinde erişilebilir.

            
            Static: Tanımlı olduğu class'tan instance alınmadan, class adı üzerinden direk erişilebilir.
                   * Static bir yapının altında static yapılar çağrılabilir.

             */
            //FaktoriyelHesapla();
            //FaktoriyelHesapla();
            //FaktoriyelHesapla();
            //FaktoriyelHesapla();


            //Static Çağrılma
            //Matematik.FaktoriyelHesapla();

            //Nonstatic Çağrılma
            //Matematik m = new Matematik();
            //m.FaktoriyelHesapla();



            //Matematik.Toplama();
            //Matematik.Cikarma ();
            //Matematik.Carpma();
            //Matematik.Bolme();

            //Yaz("Emre");


            //Console.WriteLine("Ad:");
            //string isim = Console.ReadLine();

            //Yaz(isim);


            DortIslem.Toplama(11,13);


            Console.WriteLine("1.Sayı:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayı:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            DortIslem.Toplama(sayi1, sayi2);



        }

        #region 
        //static void FaktoriyelHesapla()
        //{
        //    Console.WriteLine("sayı:");
        //    int sayi1 = Convert.ToInt32(Console.ReadLine());

        //    int fakt = 1;

        //    while (sayi1 > 0)
        //    {
        //        fakt *= sayi1;
        //        sayi1--;
        //    }

        //    Console.WriteLine("Faktöriyel:" + fakt);
        //}
        #endregion


        #region Parametresiz Metot
        //static void Yaz()
        //{
        //    Console.WriteLine("Ad:");
        //    string ad = Console.ReadLine();

        //    Console.WriteLine(ad);

        //}

        #endregion


        //Parametreli Metot
        static void Yaz(string ad)
        {
            Console.WriteLine(ad);
        }

    }
}