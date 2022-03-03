using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_11._1_Geometrija
{
    internal class Apskritimas : Figura, IGeometrija, IInformacija
    {
        public readonly double a;

        public Apskritimas(double A) : base("Apskritimas")
        {
            this.a = A;
        }

        public void Info()
        {
            Console.WriteLine($"{pavadinimas} Spindulys: {a} plotas {Plotas()} perimetras {Perimetras()} "); ;
        }

        public double Perimetras()
        {
            return 2 * Math.PI * a;
        }

        public double Plotas()
        {
            return Math.PI * a*a;
        }
    }
}
