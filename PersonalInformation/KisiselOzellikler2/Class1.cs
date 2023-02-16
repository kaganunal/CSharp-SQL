using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiselOzellikler2
{
    public class Kagan
    {
        public static void Topla()
        {

        }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public double Kilo { get; set; }
        public int Boy { get; set; }
        public short Yas { get; set; }
        public List<string> BildigiDiller { get; set; }
        public string MedeniHal { get; set; }
        public string EMail { get; set; }
        public string EhliyetTipi { get; set; }
        public string Meslek { get; set; }
        public List<string> BildigiProgramlar { get; set; }
        public bool TamirYapabiliyorMu { get; set; }
        public List<string> AkademikGecmis { get; set; }

        public Kagan()
        {
            Console.WriteLine("Ben bugün OOP'ye başladım.");
        }

        public void GetKisiselBilgiler()
        {

            string yeniTarih = DogumTarihi.ToShortDateString();
            string kisi = "\nBenim adım " + Ad + ", soyadım " + Soyad + ". " + yeniTarih + " tarihinde doğdum ve yaşım " + Yas + ". " + "Kilom " + Kilo + ", boyum " + Boy + " cm. Ehliyet tipim " + EhliyetTipi + " ve şu an BilgeAdam kurumunda " + Meslek + " olarak görev yapıyorum.";

            Console.WriteLine(kisi);
            Console.WriteLine("\nBildiği Diller: ");
            foreach (var item in BildigiDiller)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nBildiği Programlama Dilleri ve Programlar: ");
            foreach (var item in BildigiProgramlar)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nAkademik Geçmiş: ");
            foreach (var item in AkademikGecmis)
            {
                Console.WriteLine(item + "\n");
            }

        }

    }
}
