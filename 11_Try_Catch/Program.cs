namespace _11_Try_Catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region TRY CATCH

            //try
            //{
            //Kontrol edilecek kodlar yazılır.
            //}
            //catch (Exception)
            //{
            //    Try bloğunda exception alınması durumunda yapılacak işler..  
            //}

            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("Yaş:");
            //        int yas = Convert.ToInt32(Console.ReadLine());

            //        break;
            //    }
            //    catch (Exception)
            //    {

            //        Console.WriteLine("Yaş RAKAM ile girilir.");
            //    }
            //}








            #endregion


            #region // Kullanıcıdan 2 sayı alınız ve toplama işlemi uygulayarak sonucu ekrana yazdırınız. Hata kontrollerini uygulayınız.
            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("1.sayı:");
            //        int sayi1 = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("2.sayı:");
            //        int sayi2 = Convert.ToInt32(Console.ReadLine());

            //        Console.WriteLine("Toplam:" + (sayi1 + sayi2));
            //        break;
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Sayılar RAKAMLARDAN oluşur LAN!!!!");
            //    }
            //}



            int sayi1, sayi2;

            while (true)
            {
                try
                {
                    Console.WriteLine("1.sayı:");
                    sayi1 = Convert.ToInt32(Console.ReadLine());                   
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Sayılar RAKAMLARDAN oluşur LAN!!!!");
                }
            }

            while (true)
            {
                try
                {
                    Console.WriteLine("2.sayı:");
                    sayi2 = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Sayılar RAKAMLARDAN oluşur LAN!!!!");
                }
            }


            Console.WriteLine("Toplam:"+(sayi2+sayi1));

            #endregion
        }
    }
}