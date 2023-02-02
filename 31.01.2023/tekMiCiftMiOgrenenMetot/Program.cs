using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tekMiCiftMiOgrenenMetot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz: ");

            int sayi1 = Convert.ToInt32(Console.ReadLine());
            GetTekCift(sayi1);

            Console.ReadKey();
        }

        static void GetTekCift(int sayi1)
        {
            if (sayi1 % 2 == 0)
            {
                Console.WriteLine("Girdiğiniz sayı çifttir.");
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayı tektir.");
            }
        }
    }
}
