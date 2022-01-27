using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kortos
{
    internal class Zaidejas
    {
        public string vardas { get; }
        public List<Korta> kortos { get; }

        public Zaidejas(string Vardas)
            {
            vardas = Vardas;
            kortos = new List<Korta>();
            }
    }
}
