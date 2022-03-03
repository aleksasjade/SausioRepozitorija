using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darbas_Namie_1
{
    internal class Apskritimas
    {
        public double spindulys;

        public Apskritimas(double Spindulys)
        {
            spindulys = Spindulys;
        }

        public double GautiPlota()
        {
            return Math.Pow(spindulys, 2) * Math.PI;
        }

        public double GautiIlgi()
        {
            return Math.PI * 2 * spindulys;
        }

        public void Info()
        {
            Console.WriteLine($"Apskritimo plotas: {GautiPlota()}, ilgis {GautiIlgi()}");
        }
    }
}
