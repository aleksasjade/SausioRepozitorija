using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darbas_Namie_1
{
    internal class Snipas
    {
        private int _infiltracijuKiekis;
        private string _vardas;

        public Snipas(string vardas)
        {
            _vardas = vardas;
            _infiltracijuKiekis = 0;
        }

        public void Infiltruotis()
        {
            _infiltracijuKiekis++;
            Console.WriteLine($" {_vardas} infiltravosi {_infiltracijuKiekis} kartu");
        }
    }
}
