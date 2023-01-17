using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tlDolar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal tl, euro, dolar;

            Console.WriteLine("Yatırmak istediğiniz TL tutarını giriniz: ");
            tl = Convert.ToDecimal(Console.ReadLine());
        
          

            euro = (0.049m * tl);
            dolar = (0.053m * tl);

            Console.WriteLine(tl + "TL karşılığında " + euro + " Euro veya " + dolar + "Dolar alabilirsiniz.");
            
                Console.ReadKey();
        }
    }
}
