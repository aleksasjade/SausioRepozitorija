using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kortos
{
    internal class Korta
    {
        public string Pavadinimas { get; }
        public int Verte { get; }   
        public string Zenklas { get; }

        public Korta(string pavadinimas, int verte, string zenklas)
        {
            Pavadinimas = pavadinimas;
            Verte = verte;
            Zenklas = zenklas;
        }


    }
}
