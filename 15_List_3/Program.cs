namespace _15_List_3
{
    class Urun
    {
        public string Ad;
        public int Stok;
        public int Fiyat;
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Urun> manavMeyve = new List<Urun>();
            List<Urun> manavSebze = new List<Urun>();

            List<Urun> halMeyveler = new List<Urun>();
      
            Urun u = new Urun(); // Instance (Örneklem)
            u.Ad = "ELMA";
            u.Stok = 100;
            u.Fiyat = 10;

            halMeyveler.Add(u);

            Urun u2 = new Urun(); // Instance (Örneklem)
            u2.Ad = "ARMUT";
            u2.Stok = 100;
            u2.Fiyat = 10;

            halMeyveler.Add(u2);


            Urun u3 = new Urun(); // Instance (Örneklem)
            u3.Ad = "MUZ";
            u3.Stok = 50;
            u3.Fiyat = 15;

            halMeyveler.Add(u3);


            List<Urun> halSebzeler = new List<Urun>()
            {
                new Urun(){Ad="BIBER",Stok=100,Fiyat=10},
                new Urun(){Ad="PATLICAN",Stok=100,Fiyat=20},
                new Urun(){Ad="DOMATES",Stok=100,Fiyat=30}
            };

            List<Urun> musteri = new List<Urun>();

            while (true)
            {
                Console.WriteLine(" **** HALE HOŞGELDİNİZ ****");
                Console.WriteLine("Meyve Mi Sebze Mi (M/S)?"); // Çıkış işlemi ??
                string halSecim = Console.ReadLine().ToUpper();

                if (halSecim == "M")
                {
                    foreach (Urun urun in halMeyveler)
                    {
                        Console.WriteLine("Ad:"+urun.Ad+"  Fiyat:"+urun.Fiyat);
                    }

                    Console.WriteLine("İstenilen ürün Ad:");
                    string ad = Console.ReadLine().ToUpper();

                    #region 1.Yol
                    //Urun meyve = new Urun();

                    //foreach (Urun item in halMeyveler)
                    //{
                    //    if (item.Ad == ad)
                    //    {
                    //        meyve = item;
                    //        break;
                    //    }

                    //}

                    //if (meyve.Ad == null) { }
                    #endregion

                    Urun meyve = halMeyveler.FirstOrDefault(item => item.Ad == ad);

                    if (meyve == null)
                    {
                        Console.WriteLine("Olmayan meyve seçildi.."); //Çıkış ??
                    }
                    else
                    {
                        Console.WriteLine($"{meyve.Ad}'dan kaç kilo istersiniz?");
                        int kilo = Convert.ToInt32(Console.ReadLine());

                       

                        if (meyve.Stok >= kilo)
                        {
                            if (manavMeyve.Any(i=> i.Ad==ad)==false)
                            {
                                Urun m = new Urun();
                                m.Ad = meyve.Ad;
                                m.Stok = kilo;
                                m.Fiyat = meyve.Fiyat + 5;

                                manavMeyve.Add(m);

                                halMeyveler.FirstOrDefault(i => i.Ad == ad).Stok -= kilo;

                            }
                            else
                            {
                                manavMeyve.FirstOrDefault(i => i.Ad == meyve.Ad).Stok+=kilo;
                                halMeyveler.FirstOrDefault(i => i.Ad == ad).Stok -= kilo;
                            }
                               
                        }
                        else
                        {
                            Console.WriteLine($"{meyve.Ad}'dan elimizde {meyve.Stok} kg mevcut.");
                        }

                        Console.WriteLine("Devam etmek için E tuşuna basınız");
                        string cevap = Console.ReadLine();

                        if (cevap != "E")
                            break;

                    }


                }
                else if (halSecim == "S")
                {

                }
                else
                {
                    Console.WriteLine("Hatalı Seçim!!");
                }
            }

            Console.WriteLine("MANAV");
            Console.WriteLine("MANAV");
            Console.WriteLine("MANAV");
            Console.WriteLine("MANAV");

        }
    }

   
}