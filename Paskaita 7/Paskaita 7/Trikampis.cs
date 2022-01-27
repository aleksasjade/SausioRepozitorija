using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_7
{
    internal class Trikampis
    {
        public double A;
        public double B;
        public double C;

        public Trikampis(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double Perimetras()
        {
            return A + B + C;

        }

        public double Pusperimetris()
        {
            return (A + B + C) / 2;
        }
        public double Plotas()
        {
            double pusperimetris = (A + B + C) / 2;

            return Math.Sqrt(pusperimetris*(pusperimetris - A)*(pusperimetris - B)*(pusperimetris - C));
        }
    }
}
