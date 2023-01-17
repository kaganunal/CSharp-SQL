using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ikiSayininKareleriToplamiInput
{
    internal class Program
    {
        static void Main(string[] args)
        {

           

            Console.WriteLine("Lütfen karelerini toplamak istediğiniz sayıları giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            double total = (sayi1 * sayi1) + (sayi2 * sayi2);
            Console.WriteLine("Girdiğiniz sayıların karelerinin toplamı = " + total);

            Console.ReadKey();  
        }
    }
}
