using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DikdortgenOrnek
{
    internal class Dikdortgen
    {
        private string Name { get; set; }
        private double SolX { get; set; }
        private double SolY { get; set; }
        private double SagX { get; set; }
        private double SagY { get; set; }

        public Dikdortgen(string name, double a, double b, double c, double d)
        {
            Name = name;
            SolX = a;
            SolY = b;
            SagX = c;
            SagY = d;
        }

        public void Yaz()
        {
            Console.WriteLine($"Adı: {Name}, Sol Üst: ({SolX}, {SolY}) Sağ Alt: ({SagX}, {SagY})");
        }
        public void SetName(string name)
        {
            Name = name;
        }

        public void SetSolUst(double a, double b)
        {
            SolX= a;
            SolY= b;

        }
        public void SetSagAlt(double a, double b)
        {
            SagX= a;
            SagY= b;    
        }

        public double GetBoy()
        {
            return Math.Abs(SolY - SagY);
        }

        public double GetEn()
        {
            return Math.Abs(SagX - SagY);
        }

        public double GetAlan()
        {
            return GetEn() * GetBoy();
        }

        public double GetCevre()
        {
            return 2 * (GetEn() + GetBoy());
        }

        public Dikdortgen BuyukOlan(Dikdortgen other)
        {
            return this.GetAlan() > other.GetAlan() ? this : other;
        }

        public void KareYap()
        {
            if (GetEn() > GetBoy())
            {
                SagX = SolX + GetBoy();
            }
            else
            {
                SagY = SolY - GetEn();
            }
        }
    }
}
