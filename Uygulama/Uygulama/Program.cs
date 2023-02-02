using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kisi kisi = new Kisi();
            BasaDon:

            Console.WriteLine("Lütfen adınızı giriniz: ");
            kisi.Ad = Console.ReadLine(); 

            Console.WriteLine("Lütfen soyadınızı giriniz: ");
            kisi.Soyad = Console.ReadLine();
            
            Console.WriteLine("Lütfen doğum yılınızı giriniz: ");
            kisi.DogumYili = Convert.ToInt32(Console.ReadLine());            
            
            Console.WriteLine("Lütfen TC No giriniz: ");
            kisi.TcNo = long.Parse(Console.ReadLine());

            bool durum;

            try
            {
                using (KimlikDogrula.KPSPublicSoapClient service = new KimlikDogrula.KPSPublicSoapClient { })
                {
                    durum = service.TCKimlikNoDogrula(kisi.TcNo, kisi.Ad, kisi.Soyad, kisi.DogumYili);
                }
            }
            catch (Exception)
            {

                throw;
            }
            if (durum == true)
            {
                Console.WriteLine("Girmiş olduğunuz bilgiler DOĞRUDUR");
            }
            else
            {
                Console.WriteLine("Girmiş olduğunuz bilgiler YANLIŞTIR");
            }
            goto BasaDon;
        }
        class Kisi
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public int DogumYili { get; set; }
            public long TcNo { get; set; }
        }
    }
}
