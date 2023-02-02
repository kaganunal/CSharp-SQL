using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotOdevi_KaanHoca_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = GetSum(1000);
            Console.WriteLine(total);
            Console.ReadKey();
        }

        static int GetSum(int sayilar)
        {
            int total = 0;
            for (sayilar = 0; sayilar < 1000 ; sayilar++)
            {
                if (sayilar %3==0 || sayilar%5==0)
                {
                    total += sayilar;
                }
            }
                return total;
        }

    }
}
