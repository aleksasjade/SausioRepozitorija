using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_12
{
    struct Struktura
    {
        public string tekstas1;
        public int skaicius1;
        public List<Klase> sarasas1;


        public Struktura(string tekstas1)
        {
            skaicius1 = 51;
            this.tekstas1 = "Penki vienas";
            sarasas1 = new List<Klase>();
        }
    }

    
}
