using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darbas_Namie_1
{
    internal class Zmogus
    {
        public string Vardas { get; set; }
        public string Pavarde { get; set; }

        public Zmogus(string vardas, string pavarde)
        {
            Vardas = vardas;
            Pavarde = pavarde;
        }

        public virtual void InfoZmogus()
        {
            Console.WriteLine($"Vardas {Vardas}, pavarde {Pavarde}");
        }
    }
}
