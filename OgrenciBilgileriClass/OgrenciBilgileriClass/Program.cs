using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgileriClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();

            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

            while (true)
            {
                Console.WriteLine("Öğrenci Ad Soyad: ");
                ogrenci.AdSoyad = textInfo.ToTitleCase(Console.ReadLine().Trim());
            TCKimlikNo:

                Console.WriteLine("TC Kimlik No giriniz: ");
                ogrenci.TCKimlikNo = Console.ReadLine();
                if (ogrenci.TCNoKontrol() != true)
                {
                    Console.WriteLine("TC Kimlik Numarası 11 haneli olmalıdır!");
                    goto TCKimlikNo;
                }
                else
                {
                OgrenciNo:
                    Console.WriteLine("Öğrenci numarasını giriniz: ");
                    ogrenci.OgrenciNo = int.Parse(Console.ReadLine());
                    if (ogrenci.OgrenciNoKontrol() != true)
                    {
                        Console.WriteLine("Öğrenci Numarası 3 basamaklı olmalıdır!");
                        goto OgrenciNo;
                    }
                    else
                    {
                        Console.WriteLine($"Öğrencinin adı soyadı: {ogrenci.AdSoyad} \nTC Kimlik No: {ogrenci.TCKimlikNo}\nÖğrenci Numarası: {ogrenci.OgrenciNo}");
                    }
                }


                Console.ReadKey();
            }
        }
    }
}
