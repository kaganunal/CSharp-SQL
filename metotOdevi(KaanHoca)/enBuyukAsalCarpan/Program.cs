using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enBuyukAsalCarpan
{
    class Program
    {
        static void Main(string[] args)
        {
            long sayi;
            Console.WriteLine(GetLargestPrimeFactor(sayi = 600851475143));
            Console.ReadKey();
        }

        static long GetLargestPrimeFactor(long sayi)
        {
            for (long i = 2; i <= sayi / 2; i++)
            {
                if (sayi % i == 0)
                {
                    sayi /= i;
                    i = 2;
                }
            }
            return sayi;
        }
    }
}
