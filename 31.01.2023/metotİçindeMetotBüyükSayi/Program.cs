using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotİçindeMetotBüyükSayi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen birinci sayıyı giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen ikinci sayıyı giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen üçüncü sayıyı giriniz: ");
            int sayi3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("")
        }

        static double GetBuyuk(int sayi1, int sayi2, int sayi3)
        {
            if (sayi1 > sayi2 && sayi1>sayi3)
            {
                return sayi1;
            }
        }
    }
}
