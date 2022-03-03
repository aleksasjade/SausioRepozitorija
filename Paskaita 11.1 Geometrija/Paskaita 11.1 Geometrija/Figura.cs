using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_11._1_Geometrija
{
    abstract class Figura
    {
        public readonly string pavadinimas;

        public Figura(string Pavadinimas)
        {
            pavadinimas = Pavadinimas;
        }
    }
}
