using System.Diagnostics;

namespace _15_List_2_Otomat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ürün satışı
            // Ürün adı ve Fiyat

            List<Urun> urunler = new List<Urun>();

            Urun u1 = new Urun();
            u1.Ad = "Kola";
            u1.Fiyat = 15;
            u1.Stok = 1;

            urunler.Add(u1);

            Urun u2 = new Urun();
            u2.Ad = "Fanta";
            u2.Fiyat = 15;
            u2.Stok = 10;
            urunler.Add(u2);

            while (true)
            {
                Console.WriteLine("Yönetici-1\nMüşteri-2\nÇıkış-Q\nSeçiminiz:");
                string secim = Console.ReadLine().ToUpper();

                if (secim == "1")
                {
                }
                else if (secim == "2")
                {

                    foreach (Urun item in urunler)
                    {
                        if(item.Stok>0)
                            Console.WriteLine(item.Ad + ":" + item.Fiyat);
                    }

                    Console.WriteLine("İstediğiniz ürün adı:");
                    string ad = Console.ReadLine();

                    foreach (Urun item in urunler)
                    {
                        if (item.Ad == ad)
                        {
                            Console.WriteLine("Para yatırınız");
                            double para = Convert.ToDouble(Console.ReadLine());

                            if (item.Fiyat <= para)
                            {
                                Console.WriteLine("Afiyet olsun");
                                item.Stok--;
                            }
                        }
                    }


                }
                else if (secim == "Q") { break; }
                else { Console.WriteLine("Hatalı Seçim!!"); }
            }

        }
    }

    class Urun
    {
        public string Ad;
        public double Fiyat;
        public int Stok;
    }
}