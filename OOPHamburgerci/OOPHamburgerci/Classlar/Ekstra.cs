using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHamburgerci
{
    /// <summary>
    /// Static soslar classı içinde oluşturduğumuz dictionary sayesinde ürünlerin hem ismini hem de fiyatını istediğimiz formda kullanabiliriz.
    /// </summary>
    public static class Soslar
    {

        public static Dictionary<string, decimal> sosDictionary = new Dictionary<string, decimal>();
        /// <summary>
        /// Elimizdeki default sosları dictionary listesine eklemek için bu constructoru kullanıyoruz. Daha sonra ekstra malzeme eklemek istediğimizde direkt bu dictionarye ekleyebileceğiz.
        /// </summary>
        static Soslar()
        {
            sosDictionary.Add("Ketçap", 2.50m); 
            sosDictionary.Add("Mayonez", 2.50m); 
            sosDictionary.Add("Acı Sos", 2.50m); 
            sosDictionary.Add("Ranch", 3.50m); 
            sosDictionary.Add("BBQ", 3.50m); 
            sosDictionary.Add("Hardal", 3.50m); 
            sosDictionary.Add("Ballı Hardal", 3.50m); 
            sosDictionary.Add("Buffalo", 3.50m); 
        }
    }
}
