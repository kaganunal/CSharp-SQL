using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinCosTanCotMetot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir açı giriniz: ");
            double aci = int.Parse(Console.ReadLine());

            double radyan = aci * (Math.PI / 180);

            Console.WriteLine("Hangi değerleri bulmak istiyorsunuz (Sinüs için 1, Cosinüs için 2, Tanjant için 3, Cotanjant için 4)");
            int secim = int.Parse(Console.ReadLine());
            if (secim == 1)
            {
                Console.WriteLine(GetSin(radyan));
            }
            else if (secim == 2)
            {
                Console.WriteLine(GetCos(radyan));
            }
            else if (secim == 3)
            {
                Console.WriteLine(GetTan(radyan));
            }
            else if (secim == 4)
            {
                Console.WriteLine(GetCot(radyan));
            }   
            else
            {
                Console.WriteLine("Lütfen 1 ve 4 arası bir değer giriniz: ");
            }
            
            Console.ReadKey();

        }

        static double GetSin(double radyan)
        {
            
            return Math.Sin(radyan);
        }
        static double GetCos(double radyan)
        {
            return Math.Cos(radyan);
        }
        static double GetTan(double radyan)
        {
            return Math.Tan(radyan);
        }
        static double GetCot(double radyan)
        {
            return (1 / Math.Tan(radyan));
        }


    }
}
