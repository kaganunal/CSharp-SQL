using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31._01._2023
{
    internal class Program
    {
        static void Main(string[] args)

        #region
        {
            Yaz();
            Console.WriteLine("Lütfen toplamak istediğiniz iki sayıyı giriniz: ");
            int sayi1 = int.Parse(Console.ReadLine());
            int sayi2 = int.Parse(Console.ReadLine());
            GetToplama(sayi1,sayi2);
            GetCarpma(sayi1,sayi2);
            KareAl(sayi1);
            Yuz();

        }
        static void Yaz()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Bilge Adam");
            }
        }

        static int GetToplama(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        static int GetCarpma(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        static int KareAl(int sayi1)
        {
            return sayi1 * sayi1;
        }

        static int Yuz()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i + " ");
            }
        }
        #endregion



    }
}
