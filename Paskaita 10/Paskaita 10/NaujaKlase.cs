using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_10
{
    internal class NaujaKlase
    {
        private readonly int klasiokuSkaicius = 7;
        private readonly string mokytojosVardas = "Vitalija";
        public  readonly int pazymys;
        public List<string> PirmaC = new List<string>();

        public NaujaKlase(int Pazymys)
        {
            pazymys = Pazymys;
            pazymys = 7;
        }
    }
}
