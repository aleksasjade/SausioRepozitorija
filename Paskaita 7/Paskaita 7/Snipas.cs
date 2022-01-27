using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_7
{
    internal class Snipas
    {
        private string _vardas;
        private int _infiltracijuKiekis;
        public Snipas(string vardas)
        {
            _vardas = vardas;
            _infiltracijuKiekis = 0;
        }

        public void infiltruotis()
        {
            _infiltracijuKiekis++;
            Console.WriteLine($"{_vardas} infiltruojasi {_infiltracijuKiekis} karta!");
        }

    }
}
