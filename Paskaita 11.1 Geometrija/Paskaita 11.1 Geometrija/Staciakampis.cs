using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_11._1_Geometrija
{
    internal class Staciakampis : Figura, IGeometrija, IInformacija
    {
        public readonly double a;
        public readonly double b;

        public Staciakampis(double A, double B) : base("Staciakampis")
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
            return a * 2 + b * 2;
        }


        public double Plotas()
        {
            return a * b;
        }
    }

}
