using System.Collections;
using System.Runtime.Serialization;

namespace _15_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Collections
            //SortedList
            //Hashtable;
            //Queue
            #endregion

            //int[] rakams = new int[5];

            //ArrayList arrayList = new ArrayList();

            // Veri tipi tanımlanarak bir sınır verilmeden tanımlanır.
            //List<string> isimler = new List<string>();

            // Dolu Liste Tanımı
            //List<string> ogrenciler = new List<string>(){ "ali", "veli" };


            //ogrenciler.Add("Altan");
            //ogrenciler.Add("Emre");
            //ogrenciler.Add("Uras");

            //foreach (string item in ogrenciler)
            //{
            //    Console.WriteLine(item);
            //}

            // Tek satır foreach
            //ogrenciler.ForEach(item => Console.WriteLine(item));


            //Liste Eleman sayısı
            //Console.WriteLine(ogrenciler.Count);
            //Console.WriteLine(ogrenciler.Capacity);


            #region AddRange()

            //List<string> isimler = new List<string>() { "Öykü", "İlkim", "Kübra" };

            //ogrenciler.AddRange(isimler);
            #endregion

            //ogrenciler.Clear(); // Tüm elemanları siler.

            //ogrenciler.Contains("ali"); //Liste içinde ali datası var mı?

            //ogrenciler.Remove("ali"); //Liste içinde ali datasını siler.

            //ogrenciler.RemoveAt(0); //Liste içinde 0. index değerini siler.

            //ogrenciler.Insert(3, "Dilruba"); //Liste içinde istenilen index e eleman ekler.


            #region CLASS

            // Ürün: ad,fiyat,stok,üretimTarihi

            // Ürün bir nesnedir. Kendine ait özellikleri vardır.

            /*
            Product product = new Product();

            product.name = "Kola";
            product.price = 15;
            product.stock = 100;

            Product product2 = new Product();

            product2.name = "Fanta";
            product2.price = 15;
            product2.stock = 200;


            List<Product> urunler = new List<Product>();

            urunler.Add(product);
            urunler.Add(product2);

            foreach (Product item in urunler)
            {
                if (item.name == "Fanta")
                {
                    Console.WriteLine(item.price);
                }
            }
            */
            #endregion

            #region ÖRNEK
            //List<User> users = new List<User>();

            //while (true)
            //{
            //    Console.WriteLine("1-Kayıt ol\n2-Giriş");
            //    string secim = Console.ReadLine();

            //    if (secim == "1")
            //    {
            //        User newUser = new User();

            //        Console.WriteLine("Ad:");
            //        newUser.Name = Console.ReadLine();

            //        Console.WriteLine("Soyad:");
            //        newUser.Surname = Console.ReadLine();

            //        Console.WriteLine("Kullanıcıadı:");
            //        newUser.Username = Console.ReadLine();

            //        Console.WriteLine("Şifre:");
            //        newUser.Password = Console.ReadLine();

            //        Console.WriteLine("Yaş:");
            //        newUser.Age = Convert.ToInt32(Console.ReadLine());

            //        users.Add(newUser);
            //    }
            //    else if (secim == "2") 
            //    {

            //        Console.WriteLine("Kullanıcıadı:");
            //        string username = Console.ReadLine();

            //        Console.WriteLine("Şifre:");
            //        string password = Console.ReadLine();

            //        foreach (User item in users)
            //        {
            //            if(item.Username==username && item.Password == password)
            //            {
            //                Console.WriteLine("Giriş Başarılı");
            //                Console.WriteLine(item.Name+" "+item.Surname);
            //            }
            //        }


            //    }
            //    else
            //    {
            //        Console.WriteLine("HATA!!");
            //    }

            //}
            #endregion

            #region INSTANCE-ÖRNEKLEM

            //1.Yol
            //List<Urun> uruns = new List<Urun>();

            //Urun u = new Urun(); // Instance (Örneklem)
            //u.Ad = "ELMA";
            //u.Stok = 100;
            //u.Fiyat = 10;

            //uruns.Add(u);


            ////2.Yol
            //Urun u2 = new Urun()
            //{
            //    Ad="ARMUT",
            //    Stok=100,
            //    Fiyat=15
            //};
            //uruns.Add(u2);


            //3.Yol
            //List<Urun> uruns = new List<Urun>() 
            //{ 
            //    new Urun(){Ad="MUZ",Stok=100,Fiyat=20},
            //    new Urun(){Ad="ELMA",Stok=100,Fiyat=10},
            //    new Urun(){Ad="ARMUT",Stok=100,Fiyat=15},
            //    new Urun(){Ad="KARPUZ",Stok=100,Fiyat=10}
            //};



            #endregion





        }
    }

    //class Product
    //{
    //    public string name;
    //    public double price;
    //    public int stock;
    //}

    //class User
    //{
    //    public string Name;
    //    public string Surname;
    //    public string Username;
    //    public string Password;
    //    public int Age;
    //}

    class Urun
    {
        public string Ad;
        public int Stok;
        public int Fiyat;
    }
}