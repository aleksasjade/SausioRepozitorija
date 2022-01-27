using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_9
{
    internal class Zmogus
    {
        public string vardas { get; set; }
        public string pavarde { get; set; }

        public Zmogus(string Vardas, string Pavarde)
        {
            vardas = Vardas;
            pavarde = Pavarde;
        }
        public virtual void Info()
        {
            Console.WriteLine($"Vardas {vardas}, pavarde {pavarde}");
        }
    }
}
