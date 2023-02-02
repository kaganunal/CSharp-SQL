using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayiToplayanveKüpünüGetiren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen toplamak ve küpünü almak istediğiniz iki sayıyı giriniz: ");
            int sayi1 = int.Parse(Console.ReadLine());
            int sayi2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Girdiğiniz iki sayının toplamının küpü: " + GetToplamaVeKup(sayi1, sayi2));
            Console.ReadKey();
        }
        static int GetToplamaVeKup(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            int kup = toplam*toplam*toplam;

            return kup;
        }

    }
}
