using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1den100eDisaridanCagir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz: ");
            GetStop(int.Parse(Console.ReadLine()));
            Console.ReadKey();
        }
        static void GetStop(int getSayi)
        {
            for (int i = 0; i < getSayi; i++)
            {
                Console.Write($"{i,3}");
            }
        }
    }
}
