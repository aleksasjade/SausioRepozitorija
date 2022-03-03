using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_11._1_Geometrija
{
    internal class StatusisTrikampis : Figura, IGeometrija, IInformacija
    {
        public readonly double a;
        public readonly double b;

        public StatusisTrikampis(double A, double B) : base("Statusis Trikampis")
        {
            this.a = A;
            this.b = B;
        }

        public void Info()
        {
            Console.WriteLine($"{pavadinimas} A: {a} B: {b} plotas {Plotas()} perimetras {Perimetras()} ");
        }

        public double Perimetras()
        {
            double c = Math.Sqrt(a*a+b*b);
            return c;
        }

        public double Plotas()
        {
            return a*b/2;
        }
    }


}
