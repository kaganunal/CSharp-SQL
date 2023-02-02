using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotIcındeRandomMetot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(1, 20);
            }
            foreach (var sayi in dizi)
            {
                EnBuyuk(sayi);
            Console.WriteLine(sayiMax);
            }
            //foreach (var sayi in dizi)
            //{
            //    Ortalama(sayi);    
            //}
            Console.WriteLine();

        }
        static int EnBuyuk (int sayi, int sayiMax = 0)
        {
            if (sayi > sayiMax)
            {
                sayiMax = sayi;
            }
            return sayiMax;
        }
        static double Ortalama(int sayi, double toplam)
        {
            toplam += sayi ;
            return toplam;
        }
    }
}
