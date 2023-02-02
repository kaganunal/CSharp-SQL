using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacciEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetEvenFibonacci(4000000));
            Console.ReadKey();

        }

        static int GetEvenFibonacci(int sayi)
        {
            int a = 1, b = 0, c, evenTotal = 0;
            for (int i = 2; i < sayi;)
            {
                b = a + i;
                a = i;
                i = b;
                if (b % 2 == 0 && b <sayi) 
                {
                    evenTotal += b;
                }
            }
            return evenTotal;
        }
    }
}
