using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buyukSayiMetot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen birinci sayıyı giriniz: ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen ikinci sayıyı giriniz: ");
            int sayi2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Girdiğiniz sayılardan büyük olan: " + BuyukSayi(sayi1, sayi2));
            Console.ReadKey();
        }

        static int BuyukSayi(int sayi1, int sayi2)
        {
            if (sayi1 > sayi2)
            {
                return sayi1;
            }
            else
            {
                return sayi2;
            }
        }
    }
}
