using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_7
{
    internal class Keturkampis
    {
        public double krastine1;
        public double krastine2;

        public Keturkampis(double Krastine1, double Krastine2)
        {
            krastine1 = Krastine1;
            krastine2 = Krastine2;

        }
        public void GautiIlgi()
        {
            Console.WriteLine($"Keturkampio ilgis = {(krastine1 + krastine2) * 2}");
        }
        public void GautiPlota()
        {
            Console.WriteLine($"Keturkampio plotas = {krastine1 * krastine2}");
        }

    }
}
