using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Algoritma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // DERLEYİCİ(Compiler) - Visual Studio 2022            
            // Compiler: Yazılan her kodun yazım hatasını ve ilişkilerini denetler.
            // Optimize: sistem çalıştırmaya uygunmu ? (Donanımsal)
            // Compile : Kod mac diline çevirir.
            // Execute: Kod çalışır
            // Result: Sonuç getirilir.

            //Bütün kodlamalar static void Main() içine yapılacak.

            //Program.cs (class dosyası) içinde yazılacak her kelime, ifade C# komutu olması gereklidir. Kod harici bir not yazılacak ise mutlaka COMMENT olması gereklidir.

            // Tek satır yorum(comment) oluşturur.

            /*
             Birden 
                Fazla
                    Satır Yorum yazılır.

             */

            // Solution Explorer :  Projeleri tek başlık altında toplar.
            /*
               Proje Açma => File => New Project => Console App(C# .Net Framework olmasına dikkat ediyoruz.)
               Solution => Birden fazla projeyi altında barındırabilen yapıdır.

                         Kapsadığı projelerin birbirlerini tanımasını ve senkronize olarak iletişim kurmasını sağlar.


               .NET FRAMEWORK NEDİR?
                  .Net microsoft firmasına ait yazılımların yazılabildiği kontrol(yazım kuralları) edildiği bir yapıdır.
                  .NET Framework ise Microsoft firmasına ait bütün dillerin ve yapıların birlikte geliştirilebilceği ve çalıştırılabileceği bir platformdur.

                         C#      => Console ve Masaüstü

                         MSSQL   => Veritabanı yazılımı

                         ASP.NET => Web Yazılım

                         Unity   => Oyun Programlama

                         Azure   => Bulut Tabanlı Veri Tabanı

                         Xamarin => Mobil Yazılım

                         Web Service

            Algoritma: Bir sorunu çözmek veya belirlenmiş bir hedefe ulaşmak için gerçekleştirilen işlemin işlem adımlarıdır.
            Amaca ulaşmak için işlenecek yolları ve sıralamalarını belirli bir mantıkla takip etmemezi sağlar.

            Giriş / Çıkış Bilgisi: Program başlangıcında verilecek değerleri veya kullanıcıdan dışarıdan alınacak değerlerin neler    olduğu ve işlemler sonucunda ne çıktısı alınacağının belirtilmiş olması gereklidir.

            Sonluluk: Her türlü olasılık bir sonuca ulaşmalıdır.Ucu açık bir durum kalmamalıdır.

            Kesinlik: Her komutun(işlem) net bir şekilde yapacağı iş belirtilmelidir.

            Etkinlik: Yazılan algoritmalar etkin ve dolasıyla gereksiz tekrarlandan kaçınmalıdır. Algoritma genellenebilir ve modüler olmalıdır.

            Başarı ve Performans: Amaça ulaşılmalı ve algoritma paradan,zamandan ve performanstan kazanç sağlamalıdır.          

           
            EVDE ÇAY DEMLEME
            1-Başla
            2-Mutfağa Git
            3-Çaydanlığa Su Koy
            4-Ocağı Yak
            5-Su Kaynadı Mı? T->7 F->6
            6-Bekle ->5
            7-Demliğe Çay Koy
            8-Çaydanlığa Su Koy
            9-Çay Demlendi Mi? T->11 F->10
            10-Bekle ->9
            11-Servis Et
            12-Bitti


            * Su Yok
            * Çay Yok
            * Bakkal kapalı
            

            1-Başla
            2-Mutfağa Git
            3-Su ve Çay Var Mı? T->9 F->4
            4-Bakkala Git
            5-Bakkal Açık Mı? T->7 F->6
            6-Başka Bakkala Git -> 5
            7-Eksikleri Al
            8-Eve Dön -> 2
            9-Çaydanlığa Su Koy
            10-Ocağı Yak
            11-Su Kaynadı Mı? T->13 F->12
            12-Bekle ->11
            13-Demliğe Çay Koy
            14-Çaydanlığa Su Koy
            15-Çay Demlendi Mi? T->17 F->16
            16-Bekle -> 15
            17-Servis Et
            18-Bitti
           
             // EVDEN AKADEMİYE GELİŞ ALGORİTMASI

            1-Başla
            2-Evden Çık
            3-Asansör Mü? Merdiven Mi? A->4 M->10
            4-Asansör Katta Mı? F->5 T->6
            5-Asansörü Çağır -> 4
            6-İstenilen Kat Tuşuna Bas
            7-Asansör İstenilen Katta Mı? F->8 T->9
            8-Bekle -> 7
            9-Asansörden İn -> 12
            10-Bir kat hareket et
            11-İstenilen Katta Mıyız? F->10 T->12
            12-Binadan Çık
            13-Akbil Dolu Mu? F->14 T->16
            14-Büfeye Git
            15-Akbil Doldur
            16-Durağa Git
            17-Toplu Taşıma Geldi Mi? F->18 T->19
            18-Bekle ->17 
            19-Toplu Taşımaya Bin
            20-Akbil Bas
            21-Boş Yer Var Mı? F->23 T->22
            22-Otur ->24
            23-Ayakta Git
            24-İstenilen Durağına Geldi Mi? T->26 F->25
            25-Bekle -> 24
            26-Toplu Tasşımadan İn
            27-Akademiye Yürü
            28-Bitti
             */


            //Console.WriteLine("Altan"); // verilen datayı tek satırda yazdırır.
            //Console.WriteLine("AltanAltanAltanAltanAltanAltanAltanAltanAltanAnAltanAltanAlttanAltanAlttanAltanAlttanAltanAlttanAltanAlttanAltanAlttanAltanAlttanAltanAlttanAltanAlttanAltanAlt");

            Console.WriteLine("Altan");
            Console.WriteLine("Emre");
            Console.WriteLine("Demirci");

            Console.ReadLine();
        }
       
    }

}
