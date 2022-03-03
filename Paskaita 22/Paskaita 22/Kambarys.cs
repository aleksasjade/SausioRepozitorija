using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_22
{
    public class Kambarys
    {
        public double Plotis { get; }
        public double Ilgis { get; }
        public Kambarys(double plotis, double ilgis)
        {
            Ilgis = ilgis;
            Plotis = plotis;
        }

        public double GautiPloti()
        {
            return Plotis * Ilgis;
        }
    }
}
