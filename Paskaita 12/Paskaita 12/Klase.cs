using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_12
{
    internal class Klase
    {
        public string tekstas;
        public int skaicius;
        public List<Klase> sarasas;

        public Klase(string Tekstas, int Skaicius, List<Klase> Sarasas)
        {
            tekstas = Tekstas;
            skaicius = Skaicius;
            sarasas = Sarasas;
        }
    }
}
