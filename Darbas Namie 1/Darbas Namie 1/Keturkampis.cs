using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darbas_Namie_1
{
    internal class Keturkampis
    {
        public double A;
        public double B;


        public Keturkampis(double a, double b)
        {
            A = a;
            B = b;
        }

        public double GautiPlota()
        {
            return A * B;
        }

        public double GautiPerimetra()
        {
            return A * 2 + B * 2;
        }

        public void Info()
        {
            Console.WriteLine($"Keturkapio plotas: {GautiPlota()}, perimetras: {GautiPerimetra()}");
        }
    }
}
