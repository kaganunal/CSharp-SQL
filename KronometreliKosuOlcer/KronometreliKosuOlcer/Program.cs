using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KronometreliKosuOlcer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba, bu uygulamayı kullanarak günlük koşu mesafenizi ölçebilirsiniz. Bu uygulama adım boyunuzu, bir dakika içerisinde kaç adım attığınızı ve toplam koşu sürenizi belirttiğinizde metre ve km cinsinden toplam koşu mesafenizi ekrana yazdıracaktır. Çıkış yapmak isterseniz herhangi bir kullanıcı giriş kısmına 'exit' yazabilirsiniz.");

            while (true)
            {
                Bas:

                // Main Metot içerisinde işlem kalabalığı olmaması için kullanıcıdan alacağımız değerleri farklı metotlar uygulayarak gerçekleştirdim.
                double adimOlcusu = GetAdimMesafe(); //Bu metotla kullanıcının bir adımının kaç cm olduğu bilgisini aldım.
                double adimSayisiDk = GetBirDakikalikMesafe(); //Bu metotla kullanıcının bir dakikada kaç adım koşabildiğinin bilgisini aldım.
                double toplamKosuSuresi = GetKosuSuresi(); //Bu metotla kullanıcıdan toplam koşu süresini önce saat daha sonra dakika olarak aldım ve toplam süreyi dakikaya çevirerek ana metota gönderdim.
                double gunlukKosuMesafesi = adimOlcusu * adimSayisiDk * toplamKosuSuresi; //Toplam koşu mesafesini almak için gerekli işlemleri uyguladım.

                Console.WriteLine($"Bugün toplamda {toplamKosuSuresi} dakika koştunuz, attığınız toplam adım sayısı {adimSayisiDk * toplamKosuSuresi} adımdır. Gün içinde koştuğunuz toplam mesafe {gunlukKosuMesafesi / 100000} km veya {gunlukKosuMesafesi / 100} m'dir ");

                Console.WriteLine("(Programdan çıkmak isterseniz 'exit' yazabilirsiniz! Tekrardan değer girmek istiyorsanız lütfen 'Enter' tuşuna basınız!)");
                string cikis = Convert.ToString(Console.ReadLine());
                if (cikis == "exit") //Programın sonunda çıkış yapılmasını sorgulamak için bu kısma da if koydum.
                {
                    Environment.Exit(0);
                }

                goto Bas;
            }
        }

        static double GetAdimMesafe()
        {
        AdimBas:
            try
            {
                Console.WriteLine("Bir adımınızın kaç cm olduğunu giriniz: ");
                var adimOlcusu = Console.ReadLine(); //Kullanıcının programın herhangi bir kısmında 'exit' yazarak çıkış yapabilmesini sağlamak için değişkeni double olarak cast etmek yerine önce 'var' olarak cast ettim. Böylelikle girilen değeri ilk olarak 'string' türünde tanımlayabildim.

                if (adimOlcusu == "exit") //Bu kısımda 'exit' yazıldığı durumda programdan çıkış sağlanıyor.
                {
                    Environment.Exit(0);
                }

                double adimOlcusu2 = Convert.ToDouble(adimOlcusu); //Girdiyi Double'a çevirdim.

                if (adimOlcusu2 <= 0) // Girilen değer 0' dan küçük olduğu durumda yeniden değer girilmesini istiyorum.
                {
                    Console.WriteLine("Lütfen '0'dan büyük bir değer giriniz!");
                    goto AdimBas;
                }

                return adimOlcusu2;
            }

            catch (InvalidCastException) // Burada örnek olarak sayı ve 'exit' girişi dışında bir karakter girildiği zaman hata yakalama yapıyorum.
            {
                Console.WriteLine("Lütfen sayı biçiminde giriş yapınız.");
                goto AdimBas;
            }

            catch (Exception e) //Burada genel hataları yazdırıyorum.
            {
                Console.WriteLine("Hata oluştu: " + e.Message + "Lütfen tekrardan giriş yapınız!");
                goto AdimBas;
            }
        }

        static double GetBirDakikalikMesafe()
        {
        AdimDkBas:
            try
            {
                Console.WriteLine("Bir dakikada toplam kaç adım koştuğunuzu giriniz: ");
                var adimSayisiDk = Console.ReadLine();

                if (adimSayisiDk == "exit")
                {
                    Environment.Exit(0);
                }

                double adimSayisiDk2 = Convert.ToDouble(adimSayisiDk);

                if (adimSayisiDk2 <= 0)
                {
                    Console.WriteLine("Lütfen '0'dan büyük bir değer giriniz!");
                    goto AdimDkBas;
                }

                return adimSayisiDk2;
            }

            catch (InvalidCastException)
            {
                Console.WriteLine("Lütfen sayı biçiminde giriş yapınız.");
                goto AdimDkBas;
            }

            catch (Exception e)
            {
                Console.WriteLine("Hata oluştu " + e.Message + "Lütfen tekrardan giriş yapınız!");
                goto AdimDkBas;
            }
        }

        static double GetKosuSuresi()
        {
        KosuSuresiSaatBas:
            try
            {
                Console.WriteLine("Lütfen koşu sürenizi önce saat sonra dakika olacak biçimde giriniz (Örnek: 1 saat 30 dakika): ");

                var kosuSuresiSaat = Console.ReadLine();
                var kosuSuresiDk = Console.ReadLine();

                if (kosuSuresiSaat == "exit" || kosuSuresiDk == "exit")
                {
                    Environment.Exit(0);
                }

                double kosuSuresiSaat2 = Convert.ToDouble(kosuSuresiSaat);
                double kosuSuresiDk2 = Convert.ToDouble(kosuSuresiDk);

                if (kosuSuresiSaat2 <= 0 || kosuSuresiDk2 <= 0)
                {
                    Console.WriteLine("Lütfen '0'dan büyük bir değer giriniz!");
                    goto KosuSuresiSaatBas;
                }
                double toplamKosuSuresi = Convert.ToDouble((60 * kosuSuresiSaat2) + kosuSuresiDk2);

                return toplamKosuSuresi;
            }

            catch (InvalidCastException)
            {
                Console.WriteLine("Lütfen sayı biçiminde giriş yapınız.");
                goto KosuSuresiSaatBas;
            }

            catch (Exception e)
            {
                Console.WriteLine("Hata oluştu " + e.Message + "Lütfen tekrardan giriş yapınız!");
                goto KosuSuresiSaatBas;
            }
        }
    }
}
