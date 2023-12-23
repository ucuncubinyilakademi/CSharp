namespace _16_Metot_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OVERLOAD METHODS

            //Toplam();
            //Toplam(1, 2);


            //kullanıcıdan alınacak bir ürün fiyatın KDV uygulayarak yeni fiyatı kullanıcıya gösteriniz
            //KDVUygula=>%20

            KDVUygula();


            Console.WriteLine("Ürün Fiyat:");
            int f = Convert.ToInt32(Console.ReadLine());
            KDVUygula(f);


        }

        static void KDVUygula()
        {
            Console.WriteLine("Ürün Fiyat:");
            int fiyat = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(fiyat*1.2);
        }

        static void KDVUygula(int fiyat)
        {
            Console.WriteLine(fiyat * 1.2);
        }



        /// <summary>
        /// Bu metot iki sayı toplar.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Toplama sonucu</returns>
        static void Toplam()
        {
            Console.WriteLine("1.Sayı:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayı:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Toplam:" + (sayi1 + sayi2));
        }

        //static void Toplam(int s1, int s2)
        //{
        //    Console.WriteLine("Toplam:" + (s1+s2 ));
        //}

        //static void Toplam(double s1, int s2)
        //{
        //    Console.WriteLine("Toplam:" + (s1 + s2));
        //}

        //static void Toplam(int s1, double s2)
        //{
        //    Console.WriteLine("Toplam:" + (s1 + s2));
        //}

        //static void Toplam(int s1, int s2,int s3)
        //{
        //    Console.WriteLine("Toplam:" + (s1 + s2 + s3));
        //}
    }
}