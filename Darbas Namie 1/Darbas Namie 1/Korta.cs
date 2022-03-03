using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darbas_Namie_1
{
    internal class Korta
    {
        public string Pavadinimas { get; set; }
        public int Verte { get; set; }
        public string Zenklas { get; set; }

        public Korta(string pavadinimas, int verte, string zenklas)
        {
            Pavadinimas = pavadinimas;
            Verte = verte;
            Zenklas = zenklas;
        }
    }
}
