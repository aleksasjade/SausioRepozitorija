using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_11._1_Geometrija
{
    internal class Kvadratas : Figura, IGeometrija, IInformacija
    {
        public readonly double a;

        public Kvadratas(double A) : base("Kvadratas")
        {
            a = A;
        }

        public void Info()
        {
            Console.WriteLine($"{pavadinimas} A: {a} plotas {Plotas()} perimetras {Perimetras()} "); ;
        }

        public double Perimetras()
        {
            return a * 4;
        }

        public double Plotas()
        {
            return a * a;
        }
    }
}
